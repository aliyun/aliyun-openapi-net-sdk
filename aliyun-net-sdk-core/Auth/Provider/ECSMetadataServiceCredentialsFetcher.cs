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
        private const int DEFAULT_TIMEOUT_IN_MILLISECONDS = 5000;

        private const string ECS_METADAT_FETCH_ERROR_MSG =
            "Failed to get RAM session credentials from ECS metadata service.";

        // stands for 3600 s
        private const int DEFAULT_ECS_SESSION_TOKEN_DURATION_SECONDS = 3600;
        private int connectionTimeoutInMilliseconds;
        private string credentialUrl;
        private string metadataServiceHost = "100.100.100.200";
        private string roleName;

        public ECSMetadataServiceCredentialsFetcher()
        {
            connectionTimeoutInMilliseconds = DEFAULT_TIMEOUT_IN_MILLISECONDS;
        }

        public AlibabaCloudCredentials GetCredentials()
        {
            return Fetch();
        }

        public void SetRoleName(string roleName)
        {
            if (string.IsNullOrEmpty(roleName))
            {
                throw new ArgumentNullException("You must specifiy a valid role name.");
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

        public void WithECSMetadataServiceHost(string host)
        {
            metadataServiceHost = host;
            SetCredentialUrl();
        }

        public void WithConnectionTimeout(int milliseconds)
        {
            connectionTimeoutInMilliseconds = milliseconds;
        }

        public string GetMetadata()
        {
            var request = new HttpRequest(credentialUrl);
            request.Method = MethodType.GET;
            request.SetConnectTimeoutInMilliSeconds(connectionTimeoutInMilliseconds);

            HttpResponse response;
            try
            {
                response = GetResponse(request);
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

        public virtual InstanceProfileCredentials Fetch()
        {
            Dictionary<string, string> dic;
            try
            {
                var jsonContent = GetMetadata();

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
