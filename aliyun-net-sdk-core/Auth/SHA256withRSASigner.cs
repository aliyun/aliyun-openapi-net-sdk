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
using System.Security.Cryptography;
using System.Text;
using Aliyun.Acs.Core.Auth;

namespace Aliyun.Acs.Core
{
    public class SHA256withRSASigner : Signer
    {
        private const String ALGORITHM_NAME = "SHA256withRSA";
        public const String ENCODING = "UTF-8";

        public override String SignString(String stringToSign, String accessKeySecret)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            SHA256 sha256 = SHA256.Create();
            byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(stringToSign));
            RSAPKCS1SignatureFormatter RSAFormatter = new RSAPKCS1SignatureFormatter(rsa);
            RSAFormatter.SetHashAlgorithm("SHA256");
            byte[] signedHash = RSAFormatter.CreateSignature(hashValue);
            return Convert.ToBase64String(signedHash);
        }

        public override String SignString(String stringToSign, AlibabaCloudCredentials credentials)
        {
            return SignString(stringToSign, credentials.GetAccessKeySecret());
        }

        public override String GetSignerName()
        {
            return ALGORITHM_NAME;
        }

        public override String GetSignerVersion()
        {
            return "1.0";
        }

        public override String GetSignerType()
        {
            return "PRIVATEKEY";
        }
    }
}
