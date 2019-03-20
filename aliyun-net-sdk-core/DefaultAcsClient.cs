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
using System.Net;
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

        private int maxRetryNumber = 3;
        private bool autoRetry = true;
        private IClientProfile clientProfile = null;
        private AlibabaCloudCredentialsProvider credentialsProvider;
        private readonly UserAgent userAgentConfig = new UserAgent();

        public int readTimeout { get; private set; }
        public int connectTimeout { get; private set; }
        public bool IgnoreCertificate { get; private set; }

        public HttpWebProxy WebProxy = new HttpWebProxy();

        public DefaultAcsClient()
        {
            this.clientProfile = DefaultProfile.GetProfile();
        }

        public DefaultAcsClient(IClientProfile profile)
        {
            this.clientProfile = profile;
            this.credentialsProvider = new StaticCredentialsProvider(profile);
            this.clientProfile.SetCredentialsProvider(this.credentialsProvider);
        }

        public DefaultAcsClient(IClientProfile profile, AlibabaCloudCredentials credentials)
        {
            this.clientProfile = profile;
            this.credentialsProvider = new StaticCredentialsProvider(credentials);
            this.clientProfile.SetCredentialsProvider(this.credentialsProvider);
        }

        public DefaultAcsClient(IClientProfile profile, AlibabaCloudCredentialsProvider credentialsProvider)
        {
            this.clientProfile = profile;
            this.credentialsProvider = credentialsProvider;
            this.clientProfile.SetCredentialsProvider(this.credentialsProvider);
        }

        public T GetAcsResponse<T>(AcsRequest<T> request) where T : AcsResponse
        {
            HttpResponse httpResponse = this.DoAction(request);
            return ParseAcsResponse(request, httpResponse);
        }

        public T GetAcsResponse<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber) where T : AcsResponse
        {
            HttpResponse httpResponse = this.DoAction(request, autoRetry, maxRetryNumber);
            return ParseAcsResponse(request, httpResponse);
        }

        public T GetAcsResponse<T>(AcsRequest<T> request, IClientProfile profile) where T : AcsResponse
        {
            HttpResponse httpResponse = this.DoAction(request, profile);
            return ParseAcsResponse(request, httpResponse);
        }

        public T GetAcsResponse<T>(AcsRequest<T> request, string regionId, Credential credential) where T : AcsResponse
        {
            HttpResponse httpResponse = this.DoAction(request, regionId, credential);
            return ParseAcsResponse(request, httpResponse);
        }

        public CommonResponse GetCommonResponse(CommonRequest request)
        {
            HttpResponse httpResponse = this.DoAction(request.BuildRequest());
            String data = null;
            if (httpResponse.Content != null)
            {
                data = System.Text.Encoding.UTF8.GetString(httpResponse.Content);
            }

            CommonResponse response = new CommonResponse();
            response.Data = data;
            response.HttpResponse = httpResponse;
            response.HttpStatus = httpResponse.Status;

            return response;
        }

        private T ParseAcsResponse<T>(AcsRequest<T> request, HttpResponse httpResponse) where T : AcsResponse
        {
            FormatType? format = httpResponse.ContentType;

            if (httpResponse.isSuccess())
            {
                return ReadResponse<T>(request, httpResponse, format);
            }
            else
            {
                AcsError error = ReadError(request, httpResponse, format);
                if (null != error.ErrorCode)
                {
                    if (500 <= httpResponse.Status)
                    {
                        throw new ServerException(error.ErrorCode, error.ErrorMessage, error.RequestId);
                    }
                    else
                    {
                        if (400 == httpResponse.Status && (error.ErrorCode.Equals("SignatureDoesNotMatch") || error.ErrorCode.Equals("IncompleteSignature")))
                        {
                            var errorMessage = error.ErrorMessage;
                            Regex re = new Regex(@"string to sign is:", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                            Match matches = re.Match(errorMessage);

                            if (matches.Success)
                            {
                                var errorStringToSign = errorMessage.Substring(matches.Index + matches.Length);

                                if (request.StringToSign.Equals(errorStringToSign))
                                {
                                    throw new ClientException("SDK.InvalidAccessKeySecret", "Specified Access Key Secret is not valid.", error.RequestId);
                                }
                            }
                        }
                        throw new ClientException(error.ErrorCode, error.ErrorMessage, error.RequestId);
                    }
                }
                else
                {
                    T t = System.Activator.CreateInstance<T>();
                    t.HttpResponse = httpResponse;
                    return t;
                }

            }
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request) where T : AcsResponse
        {
            return DoAction(request, autoRetry, maxRetryNumber, this.clientProfile);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber) where T : AcsResponse
        {
            return DoAction(request, autoRetry, maxRetryNumber, this.clientProfile);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, IClientProfile profile) where T : AcsResponse
        {
            return DoAction(request, this.autoRetry, this.maxRetryNumber, profile);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, string regionId, Credential credential) where T : AcsResponse
        {
            Signer signer = Signer.GetSigner(new LegacyCredentials(credential));
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
            return DoAction(request, autoRetry, maxRetryNumber, request.RegionId, credential, signer, format, endpoints);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry,
            int maxRetryNumber, IClientProfile profile) where T : AcsResponse
        {
            if (null == profile)
            {
                throw new ClientException("SDK.InvalidProfile", "No active profile found.");
            }
            bool retry = autoRetry;
            int retryNumber = maxRetryNumber;
            String region = profile.GetRegionId();
            if (null == request.RegionId)
            {
                request.RegionId = region;
            }

            AlibabaCloudCredentials credentials = credentialsProvider.GetCredentials();
            if (credentials == null)
            {
                credentials = new DefaultCredentialProvider().GetAlibabaCloudClientCredential();
            }
            Signer signer = Signer.GetSigner(credentials);
            FormatType format = profile.GetFormat();
            List<Endpoint> endpoints;

            endpoints = clientProfile.GetEndpoints(request.Product, request.RegionId,
                request.LocationProduct,
                request.LocationEndpointType);

            return DoAction(request, retry, retryNumber, request.RegionId, credentials, signer, format, endpoints);
        }

        public HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber, string regionId,
            Credential credential, Signer signer, FormatType? format, List<Endpoint> endpoints) where T : AcsResponse
        {
            return DoAction(request, autoRetry, maxRetryNumber, regionId, new LegacyCredentials(credential), signer, format, endpoints);
        }

        public virtual HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber, string regionId,
            AlibabaCloudCredentials credentials, Signer signer, FormatType? format, List<Endpoint> endpoints) where T : AcsResponse
        {
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

            request.Headers["User-Agent"] = UserAgent.Resolve(request.GetSysUserAgentConfig(), this.userAgentConfig);

            bool shouldRetry = true;
            for (int retryTimes = 0; shouldRetry; retryTimes++)
            {
                shouldRetry = autoRetry && retryTimes < maxRetryNumber;
                HttpRequest httpRequest = request.SignRequest(signer, credentials, format, domain);

                ResolveTimeout(httpRequest);
                SetHttpsInsecure(IgnoreCertificate);
                ResolveProxy(httpRequest, request);

                HttpResponse response = this.GetResponse(httpRequest);

                PrintHttpDebugMsg(request, response);

                if (response.Content == null)
                {
                    if (shouldRetry)
                    {
                        continue;
                    }
                    else
                    {
                        throw new ClientException("SDK.ConnectionReset", "Connection reset.");
                    }
                }

                if (500 <= response.Status && shouldRetry)
                {
                    continue;
                }

                return response;
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

        private T ReadResponse<T>(AcsRequest<T> request, HttpResponse httpResponse, FormatType? format) where T : AcsResponse
        {
            IReader reader = ReaderFactory.CreateInstance(format);
            UnmarshallerContext context = new UnmarshallerContext();
            string body = System.Text.Encoding.UTF8.GetString(httpResponse.Content);
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

        private AcsError ReadError<T>(AcsRequest<T> request, HttpResponse httpResponse, FormatType? format) where T : AcsResponse
        {
            string responseEndpoint = "Error";
            IReader reader = ReaderFactory.CreateInstance(format);
            UnmarshallerContext context = new UnmarshallerContext();
            string body = System.Text.Encoding.Default.GetString(httpResponse.Content);
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
        public virtual HttpResponse GetResponse(HttpRequest httpRequest)
        {
            return HttpResponse.GetResponse(httpRequest);
        }

        public void AppendUserAgent(string key, string value)
        {
            this.userAgentConfig.AppendUserAgent(key, value);
        }

        public UserAgent GetUserAgentConfig()
        {
            return this.userAgentConfig;
        }

        public void SetConnectTimeoutInMilliSeconds(int connectTimeout)
        {
            this.connectTimeout = connectTimeout;
        }

        public void SetReadTimeoutInMilliSeconds(int readTimeout)
        {
            this.readTimeout = readTimeout;
        }

        public void ResolveTimeout(HttpRequest request)
        {
            var finalReadTimeout = request.readTimeout > 0 ? request.readTimeout : this.readTimeout > 0 ? this.readTimeout : 0;
            request.SetReadTimeoutInMilliSeconds(finalReadTimeout);

            var finalConnectTimeout = request.connectTimeout > 0 ? request.connectTimeout : this.connectTimeout > 0 ? this.connectTimeout : 0;
            request.SetConnectTimeoutInMilliSeconds(finalConnectTimeout);
        }

        public void SetHttpsInsecure(bool ignoreCertificate = false)
        {
            IgnoreCertificate = ignoreCertificate;
        }

        /// <summary>
        /// Set Http, Https or no proxy
        /// </summary>
        /// <param name="type"></param>
        /// <param name="urls"></param>
        public void SetProxy(ProxyType type, string urls)
        {
            switch (type)
            {
                case ProxyType.HTTP_PROXY:
                    this.WebProxy.HttpProxyUrl = urls;
                    break;
                case ProxyType.HTTPS_PROXY:
                    this.WebProxy.HttpsProxyUrl = urls;
                    break;
                case ProxyType.NO_PROXY:
                    var urlList = urls.Split(',');
                    this.WebProxy.NoProxyUrlList = urlList;
                    break;
            }
        }

        private void ResolveProxy<T>(HttpRequest httpRequest, AcsRequest<T> request) where T : AcsResponse
        {
            if (null == this.WebProxy.HttpProxyUrl)
            {
                SetHttpWebEnvironmentProxyUrl();
            }

            if (request.Protocol == ProtocolType.HTTP)
            {
                httpRequest.WebProxy = new WebProxy(this.WebProxy.HttpProxyUrl, false, this.WebProxy.NoProxyUrlList);
            }
            else
            {
                httpRequest.WebProxy = new WebProxy(this.WebProxy.HttpsProxyUrl, false, this.WebProxy.NoProxyUrlList);
            }

        }

        private void SetHttpWebEnvironmentProxyUrl()
        {
            char[] splitItem = { ',', '，' };

            this.WebProxy.HttpProxyUrl = Environment.GetEnvironmentVariable("HTTP_PROXY") ?? Environment.GetEnvironmentVariable("http_proxy") ?? null;
            this.WebProxy.HttpsProxyUrl = Environment.GetEnvironmentVariable("HTTPS_PROXY") ?? Environment.GetEnvironmentVariable("https_proxy") ?? null;
            this.WebProxy.NoProxyUrlList = (Environment.GetEnvironmentVariable("NO_PROXY") ?? Environment.GetEnvironmentVariable("no_proxy") ?? "").Split(splitItem);
        }
    }
}
