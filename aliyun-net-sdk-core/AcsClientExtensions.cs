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
using System.Threading;
using System.Threading.Tasks;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Regions;

namespace Aliyun.Acs.Core
{
    public static class AcsClientExtensions
    {
        public static Task<T> GetAcsResponseAsync<T>(this IAcsClient client, AcsRequest<T> request) where T : AcsResponse
        {
            return client.GetAcsResponseAsync(request, default(CancellationToken));
        }

        public static Task<T> GetAcsResponseAsync<T>(this IAcsClient client, AcsRequest<T> request, bool autoRetry, int maxRetryCounts) where T : AcsResponse
        {
            return client.GetAcsResponseAsync(request, autoRetry, maxRetryCounts, default(CancellationToken));
        }

        public static Task<T> GetAcsResponseAsync<T>(this IAcsClient client, AcsRequest<T> request, IClientProfile profile) where T : AcsResponse
        {
            return client.GetAcsResponseAsync(request, profile, default(CancellationToken));
        }

        public static Task<T> GetAcsResponseAsync<T>(this IAcsClient client, AcsRequest<T> request, string regionId, Credential credential) where T : AcsResponse
        {
            return client.GetAcsResponseAsync(request, regionId, credential, default(CancellationToken));
        }

        public static Task<CommonResponse> GetCommonResponseAsync(this IAcsClient client, CommonRequest request)
        {
            return client.GetCommonResponseAsync(request, default(CancellationToken));
        }

        public static Task<HttpResponse> DoActionAsync<T>(this IAcsClient client, AcsRequest<T> request) where T : AcsResponse
        {
            return client.DoActionAsync(request, default(CancellationToken));
        }

        public static Task<HttpResponse> DoActionAsync<T>(this IAcsClient client, AcsRequest<T> request, bool autoRetry, int maxRetryCounts) where T : AcsResponse
        {
            return client.DoActionAsync(request, autoRetry, maxRetryCounts, default(CancellationToken));
        }

        public static Task<HttpResponse> DoActionAsync<T>(this IAcsClient client, AcsRequest<T> request, IClientProfile profile) where T : AcsResponse
        {
            return client.DoActionAsync(request, profile, default(CancellationToken));
        }

        public static Task<HttpResponse> DoActionAsync<T>(this IAcsClient client, AcsRequest<T> request, string regionId, Credential credential) where T : AcsResponse
        {
            return client.DoActionAsync(request, regionId, credential, default(CancellationToken));
        }

        public static Task<HttpResponse> DoActionAsync<T>(this IAcsClient client, AcsRequest<T> request, bool autoRetry, int maxRetryCounts, IClientProfile profile) where T : AcsResponse
        {
            return client.DoActionAsync(request, autoRetry, maxRetryCounts, profile, default(CancellationToken));
        }

        public static Task<HttpResponse> DoActionAsync<T>(this IAcsClient client, AcsRequest<T> request,
           bool autoRetry, int maxRetryNumber,
           string regionId, Credential credential,
           Signer signer, FormatType? format,
           List<Endpoint> endpoints) where T : AcsResponse
        {
            return client.DoActionAsync(request, autoRetry, maxRetryNumber, regionId, credential, signer, format, endpoints, default(CancellationToken));
        }
    }
}
