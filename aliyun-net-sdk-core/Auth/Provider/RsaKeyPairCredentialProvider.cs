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
        private readonly KeyPairCredentials rsaKeyPairCredential;
        private BasicSessionCredentials basicSessionCredentials;
        private long sessionDurationSeconds = 3600;
        private IAcsClient stsClient;

        public RsaKeyPairCredentialProvider(KeyPairCredentials rsaKeyPairCredential, IClientProfile profile)
        {
            this.rsaKeyPairCredential = rsaKeyPairCredential;
            stsClient = new DefaultAcsClient(profile, rsaKeyPairCredential);
        }

        public RsaKeyPairCredentialProvider(KeyPairCredentials rsaKeyPairCredential, IAcsClient stsClient)
        {
            this.rsaKeyPairCredential = rsaKeyPairCredential;
            this.stsClient = stsClient;
        }

        public virtual AlibabaCloudCredentials GetCredentials()
        {
            if (basicSessionCredentials == null || basicSessionCredentials.WillSoonExpire())
            {
                basicSessionCredentials = GetNewSessionCredentials();
            }

            return basicSessionCredentials;
        }

        public void WithDurationSeconds(long seconds)
        {
            sessionDurationSeconds = seconds;
        }

        public void WithSTSClient(IAcsClient client)
        {
            stsClient = client;
        }

        private BasicSessionCredentials GetNewSessionCredentials()
        {
            var request = new GetSessionAccessKeyRequest
            {
                PublicKeyId = rsaKeyPairCredential.GetAccessKeyId(),
                DurationSeconds = (int)sessionDurationSeconds,
                Protocol = ProtocolType.HTTPS
            };

            var response = stsClient.GetAcsResponse(request);

            return new BasicSessionCredentials(
                response.SessionAccesskey.SessionAccessKeyId,
                response.SessionAccesskey.SessionAccessKeySecert,
                null, sessionDurationSeconds
            );
        }
    }
}
