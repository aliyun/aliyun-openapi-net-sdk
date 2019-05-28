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

namespace Aliyun.Acs.Core.Auth
{
    public class ShaHmac1 : ISigner
    {
        private string signerName = "HMAC-SHA1";
        public override string SignerName
        {
            get { return signerName; }
        }

        private string signerVersion = "1.0";

        public override string SignerVersion
        {
            get { return signerVersion; }
        }

        public override string SignString(string source, string accessSecret)
        {
            using (KeyedHashAlgorithm algorithm = CryptoConfig.CreateFromName("HMACSHA1") as KeyedHashAlgorithm)
            {
                if (algorithm == null)
                {
                    throw new Exception("The current framework does not have this algorithm");
                }
                algorithm.Key = Encoding.UTF8.GetBytes(accessSecret.ToCharArray());
                return Convert.ToBase64String(algorithm.ComputeHash(Encoding.UTF8.GetBytes(source.ToCharArray())));
            }
        }
    }
}
