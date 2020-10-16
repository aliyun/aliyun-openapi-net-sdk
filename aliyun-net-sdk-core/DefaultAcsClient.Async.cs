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

using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Auth.Provider;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Retry;
using Aliyun.Acs.Core.Retry.Condition;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core
{
    public partial class DefaultAcsClient
    {
        public async Task<T> GetAcsResponseAsync<T>(AcsRequest<T> request, CancellationToken cancellationToken = default(CancellationToken)) where T : AcsResponse
        {
            var httpResponse = await DoActionAsync(request, cancellationToken).ConfigureAwait(false);
            return ParseAcsResponse(request, httpResponse);
        }

        public async Task<T> GetAcsResponseAsync<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber, CancellationToken cancellationToken = default(CancellationToken)) where T : AcsResponse
        {
            var httpResponse = await DoActionAsync(request, autoRetry, maxRetryNumber, cancellationToken).ConfigureAwait(false);
            return ParseAcsResponse(request, httpResponse);
        }

        public async Task<T> GetAcsResponseAsync<T>(AcsRequest<T> request, IClientProfile profile, CancellationToken cancellationToken = default(CancellationToken)) where T : AcsResponse
        {
            var httpResponse = await DoActionAsync(request, profile, cancellationToken).ConfigureAwait(false);
            return ParseAcsResponse(request, httpResponse);
        }

        public async Task<T> GetAcsResponseAsync<T>(AcsRequest<T> request, string regionId, Credential credential, CancellationToken cancellationToken = default(CancellationToken))
                where T : AcsResponse
        {
            var httpResponse = await DoActionAsync(request, regionId, credential, cancellationToken).ConfigureAwait(false);
            return ParseAcsResponse(request, httpResponse);
        }

        public async Task<CommonResponse> GetCommonResponseAsync(CommonRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var httpResponse = await DoActionAsync(request.BuildRequest(), cancellationToken).ConfigureAwait(false);
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

        public Task<HttpResponse> DoActionAsync<T>(AcsRequest<T> request, CancellationToken cancellationToken = default(CancellationToken)) where T : AcsResponse
        {
            return DoActionAsync(request, AutoRetry, MaxRetryNumber, clientProfile, cancellationToken);
        }

        public Task<HttpResponse> DoActionAsync<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber, CancellationToken cancellationToken = default(CancellationToken))
        where T : AcsResponse
        {
            return DoActionAsync(request, autoRetry, maxRetryNumber, clientProfile, cancellationToken);
        }

        public Task<HttpResponse> DoActionAsync<T>(AcsRequest<T> request, IClientProfile profile, CancellationToken cancellationToken = default(CancellationToken)) where T : AcsResponse
        {
            return DoActionAsync(request, AutoRetry, MaxRetryNumber, profile, cancellationToken);
        }

        public async Task<HttpResponse> DoActionAsync<T>(AcsRequest<T> request, string regionId, Credential credential, CancellationToken cancellationToken = default(CancellationToken))
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
                    endpoints = await clientProfile.GetEndpointsAsync(request.Product, request.RegionId, request.LocationProduct,
                        request.LocationEndpointType, cancellationToken).ConfigureAwait(false);
                }
            }

            return await DoActionAsync(request, AutoRetry, MaxRetryNumber, request.RegionId, credential, signer, format, endpoints, cancellationToken).ConfigureAwait(false);
        }

        public async Task<HttpResponse> DoActionAsync<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber, IClientProfile profile, CancellationToken cancellationToken) where T : AcsResponse
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

            var credentials = await credentialsProvider.GetCredentialsAsync(cancellationToken).ConfigureAwait(false);
            if (credentials == null)
            {
                credentials = await new DefaultCredentialProvider().GetAlibabaCloudClientCredentialAsync(cancellationToken).ConfigureAwait(false);
            }

            var signer = Signer.GetSigner(credentials);
            var format = profile.GetFormat();
            List<Endpoint> endpoints = null;

            if (request.ProductDomain == null)
            {
                endpoints = await clientProfile.GetEndpointsAsync(request.Product, request.RegionId,
                    request.LocationProduct,
                    request.LocationEndpointType, cancellationToken).ConfigureAwait(false);
            }

            return await DoActionAsync(request, retry, retryNumber, request.RegionId, credentials, signer, format, endpoints, cancellationToken).ConfigureAwait(false);
        }

        public Task<HttpResponse> DoActionAsync<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber, string regionId,
            Credential credential, Signer signer, FormatType? format, List<Endpoint> endpoints, CancellationToken cancellationToken = default(CancellationToken)) where T : AcsResponse
        {
            return DoActionAsync(request, autoRetry, maxRetryNumber, regionId, new LegacyCredentials(credential), signer,
                format, endpoints, cancellationToken);
        }

        public virtual async Task<HttpResponse> DoActionAsync<T>(AcsRequest<T> request, bool autoRetry, int maxRetryNumber,
            string regionId,
            AlibabaCloudCredentials credentials, Signer signer, FormatType? format, List<Endpoint> endpoints,
            CancellationToken cancellationToken = default(CancellationToken))
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
                    var response = await GetResponseAsync(httpRequest, cancellationToken).ConfigureAwait(false);

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

                await Task.Delay(retryPolicy.GetDelayTimeBeforeNextRetry(retryPolicyContext), cancellationToken).ConfigureAwait(false);
            } while ((retryPolicy.ShouldRetry(retryPolicyContext) & RetryCondition.NoRetry) != RetryCondition.NoRetry);

            if (exception != null)
            {
                CommonLog.LogException(exception, exception.ErrorCode, exception.ErrorMessage);
                throw new ClientException(exception.ErrorCode, exception.ErrorMessage);
            }

            return null;
        }

        public virtual Task<HttpResponse> GetResponseAsync(HttpRequest httpRequest, CancellationToken cancellationToken)
        {
            return HttpResponse.GetResponseAsync(httpRequest, cancellationToken);
        }
    }
}
