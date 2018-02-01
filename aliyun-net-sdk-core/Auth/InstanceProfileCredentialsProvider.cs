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
using Aliyun.Acs.Core.Exceptions;

namespace Aliyun.Acs.Core.Auth
{
    public class InstanceProfileCredentialsProvider : AlibabaCloudCredentialsProvider
    {
        private InstanceProfileCredentials credentials = null;
        public int ecsMetadataServiceFetchCount = 0;
        private ECSMetadataServiceCredentialsFetcher fetcher;
        private const int MAX_ECS_METADATA_FETCH_RETRY_TIMES = 3;
        private int maxRetryTimes = MAX_ECS_METADATA_FETCH_RETRY_TIMES;
        private readonly String roleName;

        public InstanceProfileCredentialsProvider(String roleName)
        {
            this.roleName = roleName;
            this.fetcher = new ECSMetadataServiceCredentialsFetcher();
            this.fetcher.SetRoleName(roleName);
        }

        public InstanceProfileCredentialsProvider withFetcher(ECSMetadataServiceCredentialsFetcher fetcher)
        {
            this.fetcher = fetcher;
            this.fetcher.SetRoleName(roleName);
            return this;
        }

        AlibabaCloudCredentials AlibabaCloudCredentialsProvider.GetCredentials()
        {
            if (credentials == null)
            {
                ecsMetadataServiceFetchCount += 1;
                credentials = fetcher.Fetch(maxRetryTimes);
            }
            else if (credentials.IsExpired())
            {
                throw new ClientException("SDK.SessionTokenExpired", "Current session token has expired.");
            }
            else if (credentials.WillSoonExpire() && credentials.ShouldRefresh())
            {
                try
                {
                    ecsMetadataServiceFetchCount += 1;
                    credentials = fetcher.Fetch();
                }
                catch (ClientException e)
                {
                    // Use the current expiring session token and wait for next round
                    credentials.SetLastFailedRefreshTime();
                }
            }
            return credentials;
        }
    }
}
