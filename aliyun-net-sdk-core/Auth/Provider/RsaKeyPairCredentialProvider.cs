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

using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;

namespace Aliyun.Acs.Core.Auth.Provider
{
    public class RsaKeyPairCredentialProvider : AlibabaCloudCredentialsProvider
    {
        public static readonly int DEFAULT_DURATION_SECONDS = 3600;
        private readonly RsaKeyPairCredential rsaKeyPairCredential;
        private IAcsClient stsClient;
        private long sessionDurationSeconds = DEFAULT_DURATION_SECONDS;
        private BasicSessionCredentials basicSessionCredentials = null;

        public RsaKeyPairCredentialProvider(RsaKeyPairCredential rsaKeyPairCredential, IClientProfile profile)
        {
            this.rsaKeyPairCredential = rsaKeyPairCredential;
            stsClient = new DefaultAcsClient(profile, rsaKeyPairCredential);
        }

        public RsaKeyPairCredentialProvider(RsaKeyPairCredential rsaKeyPairCredential, IAcsClient stsClient)
        {
            this.rsaKeyPairCredential = rsaKeyPairCredential;
            this.stsClient = stsClient;
        }

        public RsaKeyPairCredentialProvider WithDurationSeconds(long seconds)
        {
            sessionDurationSeconds = seconds;
            return this;
        }

        public RsaKeyPairCredentialProvider WithSTSClient(IAcsClient client)
        {
            stsClient = client;
            return this;
        }

        public AlibabaCloudCredentials GetCredentials()
        {
            if (basicSessionCredentials == null || basicSessionCredentials.WillSoonExpire())
            {
                basicSessionCredentials = GetNewSessionCredentials();
            }
            return basicSessionCredentials;
        }

        private BasicSessionCredentials GetNewSessionCredentials()
        {
            GetSessionAccessKeyRequest request = new GetSessionAccessKeyRequest
            {
                PublicKeyId = rsaKeyPairCredential.GetAccessKeyId(),
                DurationSeconds = (int) sessionDurationSeconds,
                Protocol = ProtocolType.HTTPS
            };

            GetSessionAccessKeyResponse response = stsClient.GetAcsResponse(request);

            return new BasicSessionCredentials(
                response.SessionAccesskey.SessionAccessKeyId,
                response.SessionAccesskey.SessionAccessKeySecert,
                null,
                sessionDurationSeconds
            );
        }
    }
}
