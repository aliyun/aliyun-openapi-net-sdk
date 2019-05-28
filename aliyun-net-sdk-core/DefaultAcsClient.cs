/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Auth.Provider;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Reader;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core
{
    public class DefaultAcsClient : IAcsClient
    {
        private static readonly HttpWebProxy WebProxy = new HttpWebProxy();
        private readonly IClientProfile clientProfile;
        private readonly AlibabaCloudCredentialsProvider credentialsProvider;
        private readonly UserAgent userAgentConfig = new UserAgent();

        public DefaultAcsClient()
        {
            clientProfile = DefaultProfile.GetProfile();
        }

        public DefaultAcsClient(IClientProfile profile)
        {
            clientProfile = profile;
            credentialsProvider = new StaticCredentialsProvider(profile);
            clientProfile.SetCredentialsProvider(credentialsProvider);
        }

        public DefaultAcsClient(IClientProfile profile, AlibabaCloudCredentials credentials)
        {
            clientProfile = profile;
            credentialsProvider = new StaticCredentialsProvider(credentials);
            clientProfile.SetCredentialsProvider(credentialsProvider);
        }

        public DefaultAcsClient(IClientProfile profile, AlibabaCloudCredentialsProvider credentialsProvider)
        {
            clientProfile = profile;
            this.credentialsProvider = credentialsProvider;
            clientProfile.SetCredentialsProvider(this.credentialsProvider);
        }

        [Obsolete("readTimeout is deprecated as does not match Properties rule, please use readTimeout instead.")]
        public int readTimeout
        {
            get { return ReadTimeout; }
        }

        public int ReadTimeout { get; private set; }

        [Obsolete("connectTimeout is deprecated as does not match Properties rule, please use connectTimeout instead.")]
        public int connectTimeout
        {
            get { return ConnectTimeout; }
        }

        public int ConnectTimeout { get; private set; }

        public bool IgnoreCertificate { get; private set; }

        private int maxRetryNumber = 3;

        public int MaxRetryNumber
        {
            get { return maxRetryNumber; }
            set { maxRetryNumber = value; }
        }

        private bool autoRetry = true;

        public bool AutoRetry
        {
            get { return autoRetry; }
            set { autoRetry = value; }
        }

        public T GetAcsResponse<T>(AcsRequest<T> request) where T : AcsResponse
        {
            var httpResponse = DoAction(request);
            return ParseAcsResponse(request, httpResponse);
        }

        public T GetAcsResponse<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber) where T : AcsResponse
        {
            var httpResponse = DoAction(request, autoRetry, maxRetryNumber);
            return ParseAcsResponse(request, httpResponse);
        }

        public T GetAcsResponse<T>(AcsRequest<T> request, IClientProfile profile) where T : AcsResponse
        {
            var httpResponse = DoAction(request, profile);
            return ParseAcsResponse(request, httpResponse);
        }

        public T GetAcsResponse<T>(AcsRequest<T> request, string regionId, Credential credential)
            where T : AcsResponse
        {
            var httpResponse = DoAction(request, regionId, credential);
            return ParseAcsResponse(request, httpResponse);
        }

        public CommonResponse GetCommonResponse(CommonRequest request)
        {
            var httpResponse = DoAction(request.BuildRequest());
            string data = null;
            if (httpResponse.Content != null)
            {
                data = Encoding.UTF8.GetString(httpResponse.Content);
            }

            var response = new CommonResponse
            {
                Data = data,
                HttpResponse = httpResponse,
                HttpStatus = httpResponse.Status
            };

            return response;
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request) where T : AcsResponse
        {
            return DoAction(request, AutoRetry, MaxRetryNumber, clientProfile);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber)
            where T : AcsResponse
        {
            return DoAction(request, autoRetry, maxRetryNumber, clientProfile);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, IClientProfile profile) where T : AcsResponse
        {
            return DoAction(request, AutoRetry, MaxRetryNumber, profile);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, string regionId, Credential credential)
            where T : AcsResponse
        {
            var signer = Signer.GetSigner(new LegacyCredentials(credential));
            FormatType? format = null;
            if (null == request.RegionId)
            {
                request.RegionId = regionId;
            }

            List<Endpoint> endpoints = null;
            if (null != clientProfile)
            {
                format = clientProfile.GetFormat();
                endpoints = clientProfile.GetEndpoints(request.Product, request.RegionId,
                    request.LocationProduct,
                    request.LocationEndpointType);
            }

            return DoAction(request, AutoRetry, MaxRetryNumber, request.RegionId, credential, signer,
                format,
                endpoints);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry,
            int maxRetryNumber, IClientProfile profile) where T : AcsResponse
        {
            if (null == profile)
            {
                throw new ClientException("SDK.InvalidProfile", "No active profile found.");
            }

            var retry = autoRetry;
            var retryNumber = maxRetryNumber;
            var region = profile.GetRegionId();
            if (null == request.RegionId)
            {
                request.RegionId = region;
            }

            var credentials = credentialsProvider.GetCredentials();
            if (credentials == null)
            {
                credentials = new DefaultCredentialProvider().GetAlibabaCloudClientCredential();
            }

            var signer = Signer.GetSigner(credentials);
            var format = profile.GetFormat();
            List<Endpoint> endpoints;

            endpoints = clientProfile.GetEndpoints(request.Product, request.RegionId,
                request.LocationProduct,
                request.LocationEndpointType);

            return DoAction(request, retry, retryNumber, request.RegionId, credentials, signer, format, endpoints);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber, string regionId,
            Credential credential, Signer signer, FormatType? format, List<Endpoint> endpoints) where T : AcsResponse
        {
            return DoAction(request, autoRetry, maxRetryNumber, regionId, new LegacyCredentials(credential), signer,
                format, endpoints);
        }

        private T ParseAcsResponse<T>(AcsRequest<T> request, HttpResponse httpResponse) where T : AcsResponse
        {
            SerilogHelper.LogInfo(request, httpResponse, SerilogHelper.ExecuteTime, SerilogHelper.StartTime);
            var format = httpResponse.ContentType;

            if (httpResponse.isSuccess())
            {
                return ReadResponse(request, httpResponse, format);
            }

            try
            {
                var error = ReadError(request, httpResponse, format);
                if (null != error.ErrorCode)
                {
                    if (500 <= httpResponse.Status)
                    {
                        throw new ServerException(error.ErrorCode, error.ErrorMessage, error.RequestId);
                    }

                    if (400 == httpResponse.Status && (error.ErrorCode.Equals("SignatureDoesNotMatch") ||
                                                       error.ErrorCode.Equals("IncompleteSignature")))
                    {
                        var errorMessage = error.ErrorMessage;
                        var re = new Regex(@"string to sign is:", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                        var matches = re.Match(errorMessage);

                        if (matches.Success)
                        {
                            var errorStringToSign = errorMessage.Substring(matches.Index + matches.Length);

                            if (request.StringToSign.Equals(errorStringToSign))
                            {
                                throw new ClientException("SDK.InvalidAccessKeySecret",
                                    "Specified Access Key Secret is not valid.", error.RequestId);
                            }
                        }
                    }

                    throw new ClientException(error.ErrorCode, error.ErrorMessage, error.RequestId);
                }
            }
            catch (ServerException ex)
            {
                SerilogHelper.LogException(ex, ex.ErrorCode, ex.ErrorMessage);
                throw new ServerException(ex.ErrorCode, ex.ErrorMessage);
            }
            catch (ClientException ex)
            {
                SerilogHelper.LogException(ex, ex.ErrorCode, ex.ErrorMessage);
                throw new ClientException(ex.ErrorCode, ex.ErrorMessage);
            }

            var t = Activator.CreateInstance<T>();
            t.HttpResponse = httpResponse;
            return t;
        }

        public virtual HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber,
            string regionId,
            AlibabaCloudCredentials credentials, Signer signer, FormatType? format, List<Endpoint> endpoints)
            where T : AcsResponse
        {
            try
            {
                SerilogHelper.StartTime = DateTime.UtcNow.ToString("o");
                var watch = Stopwatch.StartNew();

                FormatType? requestFormatType = request.AcceptFormat;
                if (null != requestFormatType)
                {
                    format = requestFormatType;
                }

                ProductDomain domain = null;
                if (request.ProductDomain != null)
                {
                    domain = request.ProductDomain;
                }
                else
                {
                    domain = Endpoint.FindProductDomain(regionId, request.Product, endpoints);
                }

                if (null == domain)
                {
                    throw new ClientException("SDK.InvalidRegionId", "Can not find endpoint to access.");
                }

                request.Headers["User-Agent"] =
                    UserAgent.Resolve(request.GetSysUserAgentConfig(), userAgentConfig);

                var shouldRetry = true;
                for (var retryTimes = 0; shouldRetry; retryTimes++)
                {
                    shouldRetry = autoRetry && retryTimes < maxRetryNumber;
                    var httpRequest = request.SignRequest(signer, credentials, format, domain);

                    ResolveTimeout(httpRequest);
                    SetHttpsInsecure(IgnoreCertificate);
                    ResolveProxy(httpRequest, request);

                    var response = GetResponse(httpRequest);

                    PrintHttpDebugMsg(request, response);

                    if (response.Content == null)
                    {
                        if (shouldRetry)
                        {
                            continue;
                        }

                        throw new ClientException("SDK.ConnectionReset", "Connection reset.");
                    }

                    if (500 <= response.Status && shouldRetry)
                    {
                        continue;
                    }

                    watch.Stop();
                    SerilogHelper.ExecuteTime = watch.ElapsedMilliseconds;
                    return response;
                }
            }
            catch (ClientException ex)
            {
                SerilogHelper.LogException(ex, ex.ErrorCode, ex.ErrorMessage);
                throw new ClientException(ex.ErrorCode, ex.ErrorMessage);
            }

            return null;
        }

        private void PrintHttpDebugMsg(HttpRequest request, HttpResponse response)
        {
            var environment_debug_value = Environment.GetEnvironmentVariable("DEBUG");

            if (null != environment_debug_value && environment_debug_value.ToLower().Equals("sdk"))
            {
                if (null != request.Headers)
                {
                    Console.WriteLine(
                        "> " + request.Method + "\n" +
                        "> " + request.Url + "\n"
                    );
                    DictionaryUtil.Print(request.Headers, '>');

                    Console.WriteLine(
                        "< " + response.Status
                    );
                    DictionaryUtil.Print(response.Headers, '<');
                }

                Environment.SetEnvironmentVariable("DEBUG", null);
            }
        }

        private T ReadResponse<T>(AcsRequest<T> request, HttpResponse httpResponse, FormatType? format)
            where T : AcsResponse
        {
            var reader = ReaderFactory.CreateInstance(format);
            var context = new UnmarshallerContext();
            var body = Encoding.UTF8.GetString(httpResponse.Content);

            if (request.CheckShowJsonItemName())
            {
                context.ResponseDictionary = reader.Read(body, request.ActionName);
            }
            else
            {
                context.ResponseDictionary = reader.ReadForHideArrayItem(body, request.ActionName);
            }

            context.HttpResponse = httpResponse;
            return request.GetResponse(context);
        }

        private AcsError ReadError<T>(AcsRequest<T> request, HttpResponse httpResponse, FormatType? format)
            where T : AcsResponse
        {
            var responseEndpoint = "Error";
            var reader = ReaderFactory.CreateInstance(format);
            var context = new UnmarshallerContext();
            var body = Encoding.Default.GetString(httpResponse.Content);
            if (null == reader)
            {
                context.ResponseDictionary = new Dictionary<string, string>();
            }
            else
            {
                context.ResponseDictionary = reader.Read(body, responseEndpoint);
            }

            return AcsErrorUnmarshaller.Unmarshall(context);
        }

        public virtual HttpResponse GetResponse(HttpRequest httpRequest)
        {
            return HttpResponse.GetResponse(httpRequest);
        }

        public void AppendUserAgent(string key, string value)
        {
            userAgentConfig.AppendUserAgent(key, value);
        }

        public UserAgent GetUserAgentConfig()
        {
            return userAgentConfig;
        }

        public void SetConnectTimeoutInMilliSeconds(int connectTimeout)
        {
            ConnectTimeout = connectTimeout;
        }

        public void SetReadTimeoutInMilliSeconds(int readTimeout)
        {
            ReadTimeout = readTimeout;
        }

        private void ResolveTimeout(HttpRequest request)
        {
            var finalReadTimeout = request.ReadTimeout > 0 ? request.ReadTimeout :
                ReadTimeout > 0 ? ReadTimeout : 0;
            request.SetReadTimeoutInMilliSeconds(finalReadTimeout);

            var finalConnectTimeout = request.ConnectTimeout > 0 ? request.ConnectTimeout :
                ConnectTimeout > 0 ? ConnectTimeout : 0;
            request.SetConnectTimeoutInMilliSeconds(finalConnectTimeout);
        }

        public void SetHttpsInsecure(bool ignoreCertificate = false)
        {
            IgnoreCertificate = ignoreCertificate;
        }

        /// <summary>
        ///     Set Http Proxy
        /// </summary>
        /// <param name="httpProxy"></param>
        public void SetHttpProxy(string httpProxy)
        {
            WebProxy.HttpProxy = httpProxy;
        }

        /// <summary>
        ///     Set Https Proxy
        /// </summary>
        /// <param name="httpsProxy"></param>
        public void SetHttpsProxy(string httpsProxy)
        {
            WebProxy.HttpsProxy = httpsProxy;
        }

        /// <summary>
        ///     Set Proxy White List
        /// </summary>
        /// <param name="urls"></param>
        public void SetNoProxy(string urls)
        {
            WebProxy.NoProxy = urls;
        }

        /// <summary>
        ///     Get Http Proxy
        /// </summary>
        /// <returns></returns>
        public string GetHttpProxy()
        {
            return WebProxy.HttpProxy ?? Environment.GetEnvironmentVariable("HTTP_PROXY") ??
                   Environment.GetEnvironmentVariable("http_proxy");
        }

        /// <summary>
        ///     Get Https Proxy
        /// </summary>
        /// <returns></returns>
        public string GetHttpsProxy()
        {
            return WebProxy.HttpsProxy ?? Environment.GetEnvironmentVariable("HTTPS_PROXY") ??
                   Environment.GetEnvironmentVariable("https_proxy");
        }

        /// <summary>
        ///     Get Proxy White List
        /// </summary>
        /// <returns></returns>
        public string GetNoProxy()
        {
            return WebProxy.NoProxy ?? Environment.GetEnvironmentVariable("NO_PROXY") ??
                   Environment.GetEnvironmentVariable("no_proxy");
        }

        private void ResolveProxy<T>(HttpRequest httpRequest, AcsRequest<T> request) where T : AcsResponse
        {
            string authorization;
            string proxy;
            var noProxy = GetNoProxy() == null ? null : GetNoProxy().Split(',');

            if (request.Protocol == ProtocolType.HTTP)
            {
                proxy = GetHttpProxy();
            }
            else
            {
                proxy = GetHttpsProxy();
            }

            if (!string.IsNullOrEmpty(proxy))
            {
                var originProxyUri = new Uri(proxy);
                Uri finalProxyUri;
                if (!string.IsNullOrEmpty(originProxyUri.UserInfo))
                {
                    authorization =
                        Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(originProxyUri.UserInfo));
                    finalProxyUri = new Uri(originProxyUri.Scheme + "://" + originProxyUri.Authority);
                    var userInfoArray = originProxyUri.UserInfo.Split(':');
                    ICredentials credential = new NetworkCredential(userInfoArray[0], userInfoArray[1]);

                    httpRequest.WebProxy = new WebProxy(finalProxyUri, false, noProxy, credential);

                    if (httpRequest.Headers.ContainsKey("Authorization"))
                    {
                        httpRequest.Headers.Remove("Authorization");
                    }

                    httpRequest.Headers.Add("Authorization", "Basic " + authorization);
                }
                else
                {
                    finalProxyUri = originProxyUri;
                    httpRequest.WebProxy = new WebProxy(finalProxyUri, false, noProxy);
                }
            }
        }

        public void SetLogger(Logger logger)
        {
            SerilogHelper.SetLogger(logger);
        }

        public void CloseLogger()
        {
            SerilogHelper.CloseLogger();
        }
    }
}
