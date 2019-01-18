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
using System.Globalization;

namespace Aliyun.Acs.Core.Auth
{
    public class InstanceProfileCredentials : BasicSessionCredentials
    {
        private readonly long expiration;
        private readonly double expireFact = 0.9;
        private readonly long refreshIntervalInMillSeconds = 10000; // 10 sec
        private long lastFailedRefreshTime = 0;

        public InstanceProfileCredentials(String accessKeyId, String accessKeySecret,
                                          String sessionToken, String expiration,
                                          long roleSessionDurationSeconds) :
            base(accessKeyId, accessKeySecret, sessionToken, roleSessionDurationSeconds)
        {
            expiration = expiration.Replace('T', ' ').Replace('Z', ' ');
            DateTime dt = Convert.ToDateTime(expiration);

            this.expiration = dt.Ticks;
        }

        public override bool WillSoonExpire()
        {
            long now = DateTime.Now.Ticks;
            return this.roleSessionDurationSeconds * (1 - expireFact) > (expiration - now) / 1000;
        }

        public bool IsExpired()
        {
            long now = DateTime.Now.Ticks;
            return now >= expiration - refreshIntervalInMillSeconds;
        }

        public bool ShouldRefresh()
        {
            long now = DateTime.Now.Ticks;
            if (now - lastFailedRefreshTime > refreshIntervalInMillSeconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetLastFailedRefreshTime()
        {
            lastFailedRefreshTime = DateTime.Now.Ticks;
        }
    }
}
