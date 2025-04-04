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

using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Reader;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Auth
{
    public class ECSMetadataServiceCredentialsFetcher : AlibabaCloudCredentialsProvider
    {
        private const string URL_IN_ECS_METADATA = "/latest/meta-data/ram/security-credentials/";
        private const string URL_IN_ECS_METADATA_TOKEN = "/latest/api/token";
        private const int DEFAULT_TIMEOUT_IN_MILLISECONDS = 1000;

        private const string ECS_METADAT_FETCH_ERROR_MSG =
            "Failed to get RAM session credentials from ECS metadata service.";

        // stands for 3600 s
        private const int DEFAULT_ECS_SESSION_TOKEN_DURATION_SECONDS = 3600;
        private string credentialUrl;
        private string metadataServiceHost = "100.100.100.200";
        private string roleName;
        private readonly bool disableIMDSv1;
        private const int metadataTokenDuration = 21600;
        private int connectionTimeout;
        private int readTimeout;

        public ECSMetadataServiceCredentialsFetcher()
        {
            this.connectionTimeout = DEFAULT_TIMEOUT_IN_MILLISECONDS;
            this.readTimeout = DEFAULT_TIMEOUT_IN_MILLISECONDS;
            this.disableIMDSv1 = false;
        }

        public ECSMetadataServiceCredentialsFetcher(string roleName, bool? disableIMDSv1, int? connectionTimeout, int? readTimeout)
        {
            this.roleName = roleName;
            this.disableIMDSv1 = disableIMDSv1 != null && (bool)disableIMDSv1;
            this.connectionTimeout = connectionTimeout == null ? 1000 : connectionTimeout.Value;
            this.readTimeout = readTimeout == null ? 1000 : readTimeout.Value;
        }

        public AlibabaCloudCredentials GetCredentials()
        {
            return Fetch();
        }

        [Obsolete]
        public void SetRoleName(string roleName)
        {
            if (string.IsNullOrEmpty(roleName))
            {
                throw new ArgumentNullException("You must specify a valid role name.");
            }

            this.roleName = roleName;
            SetCredentialUrl();
        }

        public string GetRoleName()
        {
            return roleName;
        }

        private void SetCredentialUrl()
        {
            credentialUrl = "http://" + metadataServiceHost + URL_IN_ECS_METADATA + roleName;
        }

        [Obsolete]
        public void WithECSMetadataServiceHost(string host)
        {
            metadataServiceHost = host;
            SetCredentialUrl();
        }

        [Obsolete]
        public void WithConnectionTimeout(int milliseconds)
        {
            this.connectionTimeout = milliseconds;
            this.readTimeout = milliseconds;
        }

        [Obsolete]
        public string GetMetadata()
        {
            return GetMetadata(credentialUrl);
        }

        private string GetMetadata(string url)
        {
            var request = new HttpRequest(url);
            request.Method = MethodType.GET;
            request.SetConnectTimeoutInMilliSeconds(this.connectionTimeout);
            request.SetReadTimeoutInMilliSeconds(this.readTimeout);
            var metadataToken = this.GetMetadataToken();
            
            if (metadataToken != null)
            {
                request.Headers.Add("X-aliyun-ecs-metadata-token", metadataToken);
            }

            HttpResponse response;
            try
            {
                response = GetResponse(request);
            }
            catch (WebException e)
            {
                throw new ClientException("Failed to connect ECS Metadata Service: " + e);
            }

            if (404 == response.Status)
            {
                throw new ClientException("The role name was not found in the instance.");
            }

            if (response.Status != 200)
            {
                throw new ClientException(ECS_METADAT_FETCH_ERROR_MSG + " HttpCode=" + response.Status);
            }

            return Encoding.UTF8.GetString(response.Content);
        }

        private string GetMetadataToken()
        {
            try
            {
                HttpRequest httpRequest = new HttpRequest("http://" + metadataServiceHost + URL_IN_ECS_METADATA_TOKEN)
                {
                    Method = MethodType.PUT
                };
                httpRequest.SetConnectTimeoutInMilliSeconds(this.connectionTimeout);
                httpRequest.SetReadTimeoutInMilliSeconds(this.readTimeout);
                httpRequest.Headers.Add("X-aliyun-ecs-metadata-token-ttl-seconds", metadataTokenDuration.ToString());

                HttpResponse httpResponse;
                try
                {
                    httpResponse = GetResponse(httpRequest);
                }
                catch (Exception ex)
                {
                    throw new ClientException("Failed to connect ECS Metadata Service: " + ex);
                }
                if (httpResponse != null && httpResponse.Status != 200)
                {
                    throw new ClientException("Failed to get token from ECS Metadata Service. HttpCode=" + httpResponse.Status + ", ResponseMessage=" + httpResponse.GetHttpContentString());
                }
                return httpResponse.GetHttpContentString();
            }
            catch (Exception ex)
            {
                return ThrowErrorOrReturn(ex);
            }
        }

        private string ThrowErrorOrReturn(Exception e)
        {
            if (this.disableIMDSv1)
            {
                throw new ClientException("Failed to get token from ECS Metadata Service, and fallback to IMDS v1 is disabled via the disableIMDSv1 configuration is turned on. Original error: " + e.Message);
            }
            return null;
        }

        public virtual InstanceProfileCredentials Fetch()
        {
            Dictionary<string, string> dic;

            try
            {
                var roleName = this.roleName;
                if (string.IsNullOrEmpty(this.roleName))
                {
                    roleName = GetMetadata("http://" + metadataServiceHost + URL_IN_ECS_METADATA);
                }
                var jsonContent = GetMetadata("http://" + metadataServiceHost + URL_IN_ECS_METADATA + roleName);

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

        public InstanceProfileCredentials Fetch(int retryTimes)
        {
            for (var i = 0; i <= retryTimes; i++)
            {
                try
                {
                    return Fetch();
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

        public virtual HttpResponse GetResponse(HttpRequest request)
        {
            return HttpResponse.GetResponse(request);
        }
    }
}
