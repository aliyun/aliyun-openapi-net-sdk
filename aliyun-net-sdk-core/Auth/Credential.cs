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
    public class Credential
    {

        public DateTime RefreshDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public String AccessKeyId { get; set; }
        public String AccessSecret { get; set; }
        public String SecurityToken { get; set; }

        public Credential()
        {
            this.RefreshDate = DateTime.Now;
        }

        public Credential(String keyId, String secret)
        {
            this.AccessKeyId = keyId;
            this.AccessSecret = secret;
            this.RefreshDate = DateTime.Now;
        }

        public Credential(String keyId, String secret, int expiredHours)
        {
            this.AccessKeyId = keyId;
            this.AccessSecret = secret;
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

    }
}
