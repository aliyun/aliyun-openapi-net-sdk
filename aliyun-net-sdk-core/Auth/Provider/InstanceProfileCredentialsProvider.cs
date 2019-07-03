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
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Auth
{
    /// <summary>
    ///     InstanceProfileCredentialsProvider provides EcsRamRoleCredential
    /// </summary>
    public class InstanceProfileCredentialsProvider : AlibabaCloudCredentialsProvider
    {
        private readonly int maxRetryTimes = 3;
        private readonly string roleName;
        private InstanceProfileCredentials credentials;
        private ECSMetadataServiceCredentialsFetcher fetcher;

        public InstanceProfileCredentialsProvider(string roleName)
        {
            this.roleName = roleName;
            fetcher = new ECSMetadataServiceCredentialsFetcher();
            fetcher.SetRoleName(roleName);
        }

        public virtual AlibabaCloudCredentials GetCredentials()
        {
            try
            {
                if (credentials == null)
                {
                    credentials = fetcher.Fetch(maxRetryTimes);
                }

                if (credentials.IsExpired())
                {
                    throw new ClientException("SDK.SessionTokenExpired", "Current session token has expired.");
                }

                if (!credentials.WillSoonExpire() || !credentials.ShouldRefresh())
                {
                    return credentials;
                }

                credentials = fetcher.Fetch();
                return credentials;
            }
            catch (ClientException ex)
            {
                if (ex.ErrorCode.Equals("SDK.SessionTokenExpired") &&
                    ex.ErrorMessage.Equals("Current session token has expired."))
                {
                    CommonLog.LogException(ex, ex.ErrorCode, ex.ErrorMessage);
                    throw new ClientException(ex.ErrorCode, ex.ErrorMessage);
                }

                // Use the current expiring session token and wait for next round
                credentials.SetLastFailedRefreshTime();
            }

            return credentials;
        }

        public void withFetcher(ECSMetadataServiceCredentialsFetcher fetcher)
        {
            this.fetcher = fetcher;
            this.fetcher.SetRoleName(roleName);
        }
    }
}
