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
    public interface IAcsClient
    {
        #region Sync
        T GetAcsResponse<T>(AcsRequest<T> request) where T : AcsResponse;

        T GetAcsResponse<T>(AcsRequest<T> request, bool autoRetry, int maxRetryCounts) where T : AcsResponse;

        T GetAcsResponse<T>(AcsRequest<T> request, IClientProfile profile) where T : AcsResponse;

        T GetAcsResponse<T>(AcsRequest<T> request, string regionId, Credential credential) where T : AcsResponse;

        CommonResponse GetCommonResponse(CommonRequest request);

        HttpResponse DoAction<T>(AcsRequest<T> request) where T : AcsResponse;

        HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry, int maxRetryCounts) where T : AcsResponse;

        HttpResponse DoAction<T>(AcsRequest<T> request, IClientProfile profile) where T : AcsResponse;

        HttpResponse DoAction<T>(AcsRequest<T> request, string regionId, Credential credential) where T : AcsResponse;

        HttpResponse DoAction<T>(AcsRequest<T> request, bool autoRetry, int maxRetryCounts, IClientProfile profile)
            where T : AcsResponse;

        HttpResponse DoAction<T>(AcsRequest<T> request,
            bool autoRetry, int maxRetryNumber,
            string regionId, Credential credential,
            Signer signer, FormatType? format,
            List<Endpoint> endpoints) where T : AcsResponse;
        #endregion

        #region Async

        Task<T> GetAcsResponseAsync<T>(AcsRequest<T> request,
            CancellationToken cancellationToken)
            where T : AcsResponse;

        Task<T> GetAcsResponseAsync<T>(AcsRequest<T> request,
            bool autoRetry,
            int maxRetryCounts,
            CancellationToken cancellationToken)
            where T : AcsResponse;

        Task<T> GetAcsResponseAsync<T>(AcsRequest<T> request,
            IClientProfile profile,
            CancellationToken cancellationToken)
            where T : AcsResponse;

        Task<T> GetAcsResponseAsync<T>(AcsRequest<T> request,
            string regionId,
            Credential credential,
            CancellationToken cancellationToken)
            where T : AcsResponse;

        Task<CommonResponse> GetCommonResponseAsync(CommonRequest request,
            CancellationToken cancellationToken);

        Task<HttpResponse> DoActionAsync<T>(AcsRequest<T> request,
            CancellationToken cancellationToken)
            where T : AcsResponse;

        Task<HttpResponse> DoActionAsync<T>(AcsRequest<T> request,
            bool autoRetry,
            int maxRetryCounts,
            CancellationToken cancellationToken)
            where T : AcsResponse;

        Task<HttpResponse> DoActionAsync<T>(AcsRequest<T> request,
            IClientProfile profile,
            CancellationToken cancellationToken)
            where T : AcsResponse;

        Task<HttpResponse> DoActionAsync<T>(AcsRequest<T> request,
            string regionId,
            Credential credential,
            CancellationToken cancellationToken)
            where T : AcsResponse;

        Task<HttpResponse> DoActionAsync<T>(AcsRequest<T> request,
            bool autoRetry,
            int maxRetryCounts,
            IClientProfile profile,
            CancellationToken cancellationToken)
            where T : AcsResponse;

        Task<HttpResponse> DoActionAsync<T>(AcsRequest<T> request,
            bool autoRetry, int maxRetryNumber,
            string regionId, Credential credential,
            Signer signer, FormatType? format,
            List<Endpoint> endpoints,
            CancellationToken cancellationToken)
            where T : AcsResponse;
        #endregion
    }
}
