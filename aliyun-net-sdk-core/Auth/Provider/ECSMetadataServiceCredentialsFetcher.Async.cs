﻿/*
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
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Reader;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Auth
{
    public partial class ECSMetadataServiceCredentialsFetcher
    {

        public async Task<AlibabaCloudCredentials> GetCredentialsAsync(CancellationToken cancellationToken)
        {
            return await FetchAsync(cancellationToken).ConfigureAwait(false);
        }

        public async Task<string> GetMetadataAsync(CancellationToken cancellationToken)
        {
            var request = new HttpRequest(credentialUrl);
            request.Method = MethodType.GET;
            request.SetConnectTimeoutInMilliSeconds(connectionTimeoutInMilliseconds);

            HttpResponse response;
            try
            {
                response = await GetResponseAsync(request, cancellationToken).ConfigureAwait(false);
            }
            catch (WebException e)
            {
                throw new ClientException("Failed to connect ECS Metadata Service: " + e);
            }

            if (response.Status != 200)
            {
                throw new ClientException(ECS_METADAT_FETCH_ERROR_MSG + " HttpCode=" + response.Status);
            }

            return Encoding.UTF8.GetString(response.Content);
        }

        public virtual async Task<InstanceProfileCredentials> FetchAsync(CancellationToken cancellationToken)
        {
            Dictionary<string, string> dic;
            try
            {
                var jsonContent = await GetMetadataAsync(cancellationToken).ConfigureAwait(false);

                IReader reader = new JsonReader();
                dic = reader.Read(jsonContent, "");
            }
            catch (Exception e)
            {
                throw new ClientException(ECS_METADAT_FETCH_ERROR_MSG + " Reason: " + e);
            }

            if (
                DictionaryUtil.Get(dic, ".Code") == null ||
                DictionaryUtil.Get(dic, ".AccessKeyId") == null ||
                DictionaryUtil.Get(dic, ".AccessKeySecret") == null ||
                DictionaryUtil.Get(dic, ".SecurityToken") == null ||
                DictionaryUtil.Get(dic, ".Expiration") == null
            )
            {
                throw new ClientException("Invalid json got from ECS Metadata service.");
            }

            if (!"Success".Equals(DictionaryUtil.Get(dic, ".Code")))
            {
                throw new ClientException(ECS_METADAT_FETCH_ERROR_MSG);
            }

            return new InstanceProfileCredentials(
                DictionaryUtil.Get(dic, ".AccessKeyId"),
                DictionaryUtil.Get(dic, ".AccessKeySecret"),
                DictionaryUtil.Get(dic, ".SecurityToken"),
                DictionaryUtil.Get(dic, ".Expiration"),
                DEFAULT_ECS_SESSION_TOKEN_DURATION_SECONDS
            );
        }

        public async Task<InstanceProfileCredentials> FetchAsync(int retryTimes, CancellationToken cancellationToken)
        {
            for (var i = 0; i <= retryTimes; i++)
            {
                try
                {
                    return await FetchAsync(cancellationToken).ConfigureAwait(false);
                }
                catch (ClientException e)
                {
                    if (i == retryTimes)
                    {
                        throw new ClientException(e.ErrorCode, e.ErrorMessage);
                    }
                }
            }

            throw new ClientException("Failed to connect ECS Metadata Service: Max retry times exceeded.");
        }

        public virtual Task<HttpResponse> GetResponseAsync(HttpRequest request, CancellationToken cancellationToken)
        {
            return HttpResponse.GetResponseAsync(request, cancellationToken);
        }
    }
}
