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

using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Reader;
using Aliyun.Acs.Core.Utils;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Aliyun.Acs.Core.Auth
{
    public class ECSMetadataServiceCredentialsFetcher
    {
        private const String URL_IN_ECS_METADATA = "/latest/meta-data/ram/security-credentials/";
        private const int DEFAULT_TIMEOUT_IN_MILLISECONDS = 5000;
        private String credentialUrl;
        private String roleName;
        private String metadataServiceHost = "100.100.100.200";
        private int connectionTimeoutInMilliseconds;
        private const String ECS_METADAT_FETCH_ERROR_MSG = "Failed to get RAM session credentials from ECS metadata service.";
        private const int DEFAULT_ECS_SESSION_TOKEN_DURATION_SECONDS = 3600 * 6;

        public ECSMetadataServiceCredentialsFetcher()
        {
            this.connectionTimeoutInMilliseconds = DEFAULT_TIMEOUT_IN_MILLISECONDS;
        }

        public void SetRoleName(String roleName)
        {
            if (String.IsNullOrEmpty(roleName))
            {
                throw new ArgumentNullException("You must specifiy a valid role name.");
            }

            this.roleName = roleName;
            SetCredentialUrl();
        }

        private void SetCredentialUrl()
        {
            credentialUrl = "http://" + metadataServiceHost + URL_IN_ECS_METADATA + roleName;
        }

        public ECSMetadataServiceCredentialsFetcher WithECSMetadataServiceHost(String host)
        {
            metadataServiceHost = host;
            SetCredentialUrl();
            return this;
        }

        public ECSMetadataServiceCredentialsFetcher WithConnectionTimeout(int milliseconds)
        {
            this.connectionTimeoutInMilliseconds = milliseconds;
            return this;
        }

        public String GetMetadata()
        {
            HttpRequest request = new HttpRequest(credentialUrl);
            request.Method = MethodType.GET;
            request.TimeoutInMilliSeconds = connectionTimeoutInMilliseconds;

            HttpResponse response;
            try
            {
                response = HttpResponse.GetResponse(request);
            }
            catch (WebException e)
            {
                throw new ClientException("Failed to connect ECS Metadata Service: " + e.ToString());
            }

            if (response.Status != 200)
            {
                throw new ClientException(ECS_METADAT_FETCH_ERROR_MSG + " HttpCode=" + response.Status);
            }

            return Encoding.UTF8.GetString(response.Content);
        }

        public InstanceProfileCredentials Fetch()
        {
            Dictionary<string, string> dic;
            try
            {
                String jsonContent = GetMetadata();

                IReader reader = new Reader.JsonReader();
                dic = reader.Read(jsonContent, "");
            }
            catch (Exception e)
            {
                throw new ClientException(ECS_METADAT_FETCH_ERROR_MSG + " Reason: " + e.ToString());
            }

            if (DictionaryUtil.Get(dic, ".Code") == null
                || DictionaryUtil.Get(dic, ".AccessKeyId") == null
                || DictionaryUtil.Get(dic, ".AccessKeySecret") == null
                || DictionaryUtil.Get(dic, ".SecurityToken") == null
                || DictionaryUtil.Get(dic, ".Expiration") == null)
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
            for (int i = 0; i <= retryTimes; i++)
            {
                try
                {
                    return Fetch();
                }
                catch (ClientException e)
                {
                    if (i == retryTimes)
                    {
                        throw e;
                    }
                }
            }
            throw new ClientException("Failed to connect ECS Metadata Service: Max retry times exceeded.");
        }
    }
}