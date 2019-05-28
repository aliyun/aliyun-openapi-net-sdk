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
        private const string ALGORITHM_NAME = "SHA256withRSA";
        public const string ENCODING = "UTF-8";

        public override string SignString(string stringToSign, string accessKeySecret)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                using (var sha256 = SHA256.Create())
                {
                    var hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(stringToSign));
                    var RSAFormatter = new RSAPKCS1SignatureFormatter(rsa);
                    RSAFormatter.SetHashAlgorithm("SHA256");
                    var signedHash = RSAFormatter.CreateSignature(hashValue);
                    return Convert.ToBase64String(signedHash);
                }
            }
        }

        public override string SignString(string stringToSign, AlibabaCloudCredentials credentials)
        {
            return SignString(stringToSign, credentials.GetAccessKeySecret());
        }

        public override string GetSignerName()
        {
            return ALGORITHM_NAME;
        }

        public override string GetSignerVersion()
        {
            return "1.0";
        }

        public override string GetSignerType()
        {
            return "PRIVATEKEY";
        }
    }
}
