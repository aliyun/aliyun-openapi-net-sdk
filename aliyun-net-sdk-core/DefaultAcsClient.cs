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
using System.Threading;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Auth.Provider;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Reader;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Retry;
using Aliyun.Acs.Core.Retry.Condition;
using Aliyun.Acs.Core.Timeout.Util;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core
{
    public class DefaultAcsClient : IAcsClient
    {
        private static readonly HttpWebProxy WebProxy = new HttpWebProxy();
        private readonly IClientProfile clientProfile;
        private readonly AlibabaCloudCredentialsProvider credentialsProvider;
        private readonly RetryPolicy retryPolicy;
        private readonly UserAgent userAgentConfig = new UserAgent();

        private bool autoRetry = true;

        private int maxRetryNumber = 3;

        public DefaultAcsClient()
        {
            retryPolicy = AutoRetry ? new RetryPolicy(maxRetryNumber, true) : new RetryPolicy();
        }

        public DefaultAcsClient(IClientProfile profile) : this()
        {
            clientProfile = profile;
            credentialsProvider = new StaticCredentialsProvider(profile);
            clientProfile.SetCredentialsProvider(credentialsProvider);
        }

        public DefaultAcsClient(IClientProfile profile, AlibabaCloudCredentials credentials) : this()
        {
            clientProfile = profile;
            credentialsProvider = new StaticCredentialsProvider(credentials);
            clientProfile.SetCredentialsProvider(credentialsProvider);
        }

        public DefaultAcsClient(IClientProfile profile, AlibabaCloudCredentialsProvider credentialsProvider) : this()
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

        public int MaxRetryNumber
        {
            get { return maxRetryNumber; }
            set { maxRetryNumber = value; }
        }

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

            if (request.ProductDomain == null)
            {
                request.ProductDomain = EndpointUserConfig.GetProductDomain(request.Product, request.RegionId);
                if (request.ProductDomain == null)
                {
                    request.SetProductDomain();
                }
            }

            List<Endpoint> endpoints = null;
            if (null != clientProfile)
            {
                format = clientProfile.GetFormat();
                if (request.ProductDomain == null)
                {
                    endpoints = clientProfile.GetEndpoints(request.Product, request.RegionId, request.LocationProduct,
                        request.LocationEndpointType);
                }
            }

            return DoAction(request, AutoRetry, MaxRetryNumber, request.RegionId, credential, signer, format, endpoints);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber, IClientProfile profile) where T : AcsResponse
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

            if (request.ProductDomain == null)
            {
                request.ProductDomain = EndpointUserConfig.GetProductDomain(request.Product, request.RegionId);
                if (request.ProductDomain == null)
                {
                    request.SetProductDomain();
                }
            }

            var credentials = credentialsProvider.GetCredentials();
            if (credentials == null)
            {
                credentials = new DefaultCredentialProvider().GetAlibabaCloudClientCredential();
            }

            var signer = Signer.GetSigner(credentials);
            var format = profile.GetFormat();
            List<Endpoint> endpoints = null;

            if (request.ProductDomain == null)
            {
                endpoints = clientProfile.GetEndpoints(request.Product, request.RegionId,
                    request.LocationProduct,
                    request.LocationEndpointType);
            }

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
            CommonLog.LogInfo(request, httpResponse, CommonLog.ExecuteTime);
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
                        throw new ServerException(error.ErrorCode,
                            string.Format("{0}, the request url is {1}, the RequestId is {2}.", error.ErrorMessage,
                                httpResponse.Url ?? "empty", error.RequestId));
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
                CommonLog.LogException(ex, ex.ErrorCode, ex.ErrorMessage);
                throw new ServerException(ex.ErrorCode, ex.ErrorMessage, ex.RequestId);
            }
            catch (ClientException ex)
            {
                CommonLog.LogException(ex, ex.ErrorCode, ex.ErrorMessage);
                throw new ClientException(ex.ErrorCode, ex.ErrorMessage, ex.RequestId);
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
            var httpStatusCode = "";
            var retryAttemptTimes = 0;
            ClientException exception;
            RetryPolicyContext retryPolicyContext;

            do
            {
                try
                {
                    var watch = Stopwatch.StartNew();

                    FormatType? requestFormatType = request.AcceptFormat;
                    format = requestFormatType;

                    var domain = request.ProductDomain ??
                        Endpoint.FindProductDomain(regionId, request.Product, endpoints);

                    if (null == domain)
                    {
                        throw new ClientException("SDK.InvalidRegionId", "Can not find endpoint to access.");
                    }

                    var userAgent = UserAgent.Resolve(request.GetSysUserAgentConfig(), userAgentConfig);
                    DictionaryUtil.Add(request.Headers, "User-Agent", userAgent);
                    DictionaryUtil.Add(request.Headers, "x-acs-version", request.Version);
                    if (!string.IsNullOrWhiteSpace(request.ActionName))
                    {
                        DictionaryUtil.Add(request.Headers, "x-acs-action", request.ActionName);
                    }
                    var httpRequest = request.SignRequest(signer, credentials, format, domain);
                    ResolveTimeout(httpRequest, request.Product, request.Version, request.ActionName);
                    SetHttpsInsecure(IgnoreCertificate);
                    ResolveProxy(httpRequest, request);
                    var response = GetResponse(httpRequest);

                    httpStatusCode = response.Status.ToString();
                    PrintHttpDebugMsg(request, response);
                    watch.Stop();
                    CommonLog.ExecuteTime = watch.ElapsedMilliseconds;
                    return response;
                }
                catch (ClientException ex)
                {
                    retryPolicyContext = new RetryPolicyContext(ex, httpStatusCode, retryAttemptTimes, request.Product,
                        request.Version,
                        request.ActionName, RetryCondition.BlankStatus);

                    CommonLog.LogException(ex, ex.ErrorCode, ex.ErrorMessage);
                    exception = ex;
                }

                Thread.Sleep(retryPolicy.GetDelayTimeBeforeNextRetry(retryPolicyContext));
            } while ((retryPolicy.ShouldRetry(retryPolicyContext) & RetryCondition.NoRetry) != RetryCondition.NoRetry);

            if (exception != null)
            {
                CommonLog.LogException(exception, exception.ErrorCode, exception.ErrorMessage);
                throw new ClientException(exception.ErrorCode, exception.ErrorMessage);
            }

            return null;
        }

        private void PrintHttpDebugMsg(HttpRequest request, HttpResponse response)
        {
            var environmentDebugValue = Environment.GetEnvironmentVariable("DEBUG");

            if (null != environmentDebugValue && environmentDebugValue.ToLower().Equals("sdk"))
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

            context.ResponseDictionary = request.CheckShowJsonItemName() ?
                reader.Read(body, request.ActionName) :
                reader.ReadForHideArrayItem(body, request.ActionName);

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
            context.ResponseDictionary =
                null == reader ? new Dictionary<string, string>() : reader.Read(body, responseEndpoint);

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

        private void ResolveTimeout(HttpRequest request, string product, string version, string actionName)
        {
            var apiReadTimeout = TimeoutConfig.GetSpecificApiReadTimeoutValue(product, version, actionName);

            int finalReadTimeout;

            if (request.ReadTimeout > 0)
            {
                finalReadTimeout = request.ReadTimeout;
            }
            else if (ReadTimeout > 0)
            {
                finalReadTimeout = ReadTimeout;
            }
            else if (apiReadTimeout > 0)
            {
                finalReadTimeout = apiReadTimeout;
            }
            else
            {
                finalReadTimeout = 0;
            }

            request.SetReadTimeoutInMilliSeconds(finalReadTimeout);

            int finalConnectTimeout;

            if (request.ConnectTimeout > 0)
            {
                finalConnectTimeout = request.ConnectTimeout;
            }
            else if (ConnectTimeout > 0)
            {
                finalConnectTimeout = ConnectTimeout;
            }
            else
            {
                finalConnectTimeout = 0;
            }

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

        public static void EnableLogger(string template = CommonLog.DefaultTemplate)
        {
            CommonLog.EnableLogger(template);
        }

        public static void DisableLogger()
        {
            CommonLog.DisableLogger();
        }
    }
}
