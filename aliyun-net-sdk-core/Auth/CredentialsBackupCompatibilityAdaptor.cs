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

namespace Aliyun.Acs.Core.Auth
{
    public class CredentialsBackupCompatibilityAdaptor : Credential
    {
        private readonly AlibabaCloudCredentialsProvider provider;

        public CredentialsBackupCompatibilityAdaptor(AlibabaCloudCredentialsProvider provider)
        {
            this.provider = provider;
        }

        private AlibabaCloudCredentials GetCredentials()
        {
            var credentials = provider.GetCredentials();
            return credentials;
        }

        public new string GetAccessKeyId()
        {
            return GetCredentials().GetAccessKeyId();
        }

        public string GetAccessSecret()
        {
            return GetCredentials().GetAccessKeySecret();
        }

        public new bool IsExpired()
        {
            return false;
        }

        public string GetSecurityToken()
        {
            var credentials = GetCredentials();
            var sessionCredentials = credentials as BasicSessionCredentials;

            return sessionCredentials != null ? sessionCredentials.GetSessionToken() : null;
        }
    }
}
