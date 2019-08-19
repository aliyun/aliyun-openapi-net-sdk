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

namespace Aliyun.Acs.Core.Auth
{
    /// <summary>
    ///     StsCredential AccessKeyId + AccessKeySecret + SecurityToken
    /// </summary>
    public class Credential : AlibabaCloudCredentials
    {
        public Credential()
        {
            RefreshDate = DateTime.UtcNow;
        }

        public Credential(string keyId, string secret)
        {
            AccessKeyId = keyId;
            AccessSecret = secret;
            RefreshDate = DateTime.UtcNow;
        }

        public Credential(string keyId, string secret, string securityToken)
        {
            AccessKeyId = keyId;
            AccessSecret = secret;
            SecurityToken = securityToken;
            RefreshDate = new DateTime();
        }

        public Credential(string keyId, string secret, int expiredHours)
        {
            AccessKeyId = keyId;
            AccessSecret = secret;
            RefreshDate = new DateTime();

            SetExpiredDate(expiredHours);
        }

        public Credential(string keyId, string secret, string securityToken, int expiredHours)
        {
            AccessKeyId = keyId;
            AccessSecret = secret;
            SecurityToken = securityToken;
            RefreshDate = new DateTime();

            SetExpiredDate(expiredHours);
        }

        public DateTime RefreshDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string AccessKeyId { get; set; }
        public string AccessSecret { get; set; }
        public string SecurityToken { get; set; }

        public string GetAccessKeyId()
        {
            return AccessKeyId;
        }

        public string GetAccessKeySecret()
        {
            return AccessSecret;
        }

        private void SetExpiredDate(int expiredHours)
        {
            if (0 < expiredHours)
            {
                ExpiredDate = DateTime.UtcNow.AddHours(expiredHours);
            }
        }

        public bool IsExpired()
        {
            if (null == ExpiredDate)
            {
                return false;
            }

            return !(ExpiredDate < DateTime.UtcNow);
        }
    }
}
