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
    public abstract class Signer
    {
        private static readonly Signer hmacSHA1Signer = new HmacSHA1Signer();
        private static readonly Signer sha256withRSASigner = new SHA256withRSASigner();
        private static readonly Signer bearerTokenSigner = new BearerTokenSigner();
        public abstract string SignString(string stringToSign, AlibabaCloudCredentials credentials);
        public abstract string SignString(string stringToSign, string accessKeySecret);
        public abstract string GetSignerName();
        public abstract string GetSignerVersion();
        public abstract string GetSignerType();

        public static Signer GetSigner(AlibabaCloudCredentials credentials)
        {
            if (credentials is BearerTokenCredential)
            {
                return bearerTokenSigner;
            }

            return credentials is KeyPairCredentials ? sha256withRSASigner : hmacSHA1Signer;
        }
    }
}
