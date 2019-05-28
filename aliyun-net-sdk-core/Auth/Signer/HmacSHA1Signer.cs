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
    public class HmacSHA1Signer : Signer
    {
        private const string ALGORITHM_NAME = "HmacSHA1";
        public const string ENCODING = "UTF-8";

        public override string SignString(string stringToSign, string accessKeySecret)
        {
            using (var hmac = new HMACSHA1(Encoding.UTF8.GetBytes(accessKeySecret)))
            {
                var hashValue = hmac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign));
                return Convert.ToBase64String(hashValue);
            }
        }

        public override string SignString(string stringToSign, AlibabaCloudCredentials credentials)
        {
            return SignString(stringToSign, credentials.GetAccessKeySecret());
        }

        public override string GetSignerName()
        {
            return "HMAC-SHA1";
        }

        public override string GetSignerVersion()
        {
            return "1.0";
        }

        public override string GetSignerType()
        {
            return null;
        }
    }
}
