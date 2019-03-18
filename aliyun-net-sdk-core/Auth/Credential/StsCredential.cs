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

using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Auth
{
    public class StsCredential : AlibabaCloudCredentials
    {
        public DateTime RefreshDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string AccessKeyId { get; set; }
        public string AccessSecret { get; set; }
        public string SecurityToken { get; set; }

        public StsCredential()
        {
            this.RefreshDate = DateTime.Now;
        }

        public StsCredential(string keyId, string secret)
        {
            this.AccessKeyId = keyId;
            this.AccessSecret = secret;
            this.RefreshDate = DateTime.Now;
        }

        public StsCredential(string keyId, string secret, string securityToken)
        {
            this.AccessKeyId = keyId;
            this.AccessSecret = secret;
            this.SecurityToken = securityToken;
            this.RefreshDate = new DateTime();
        }

        public StsCredential(string keyId, string secret, int expiredHours)
        {
            this.AccessKeyId = keyId;
            this.AccessSecret = secret;
            this.RefreshDate = new DateTime();

            SetExpiredDate(expiredHours);
        }

        public StsCredential(string keyId, string secret, string securityToken, int expiredHours)
        {
            this.AccessKeyId = keyId;
            this.AccessSecret = secret;
            this.SecurityToken = securityToken;
            this.RefreshDate = new DateTime();

            SetExpiredDate(expiredHours);
        }

        private void SetExpiredDate(int expiredHours)
        {
            if (expiredHours > 0)
            {
                ExpiredDate = DateTime.Now.AddHours(expiredHours);
            }
        }

        public bool IsExpired()
        {
            if (this.ExpiredDate == null)
            {
                return false;
            }
            if (this.ExpiredDate < DateTime.Now)
            {
                return false;
            }
            return true;
        }

        public string GetAccessKeyId()
        {
            return this.AccessKeyId;
        }

        public string GetAccessKeySecret()
        {
            return this.AccessSecret;
        }
    }
}
