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
    ///     EcsRamRoleCredential
    /// </summary>
    public class InstanceProfileCredentials : BasicSessionCredentials
    {
        private readonly long expiration;
        private readonly double expireFact = 0.95;
        private readonly long refreshIntervalInMillSeconds = 10000; // 10 sec
        private long lastFailedRefreshTime;

        public InstanceProfileCredentials(
            string accessKeyId,
            string accessKeySecret,
            string sessionToken,
            string expiration,
            long roleSessionDurationSeconds) : base(accessKeyId, accessKeySecret, sessionToken,
            roleSessionDurationSeconds)
        {
            expiration = expiration.Replace('T', ' ').Replace('Z', ' ');
            var dt = Convert.ToDateTime(expiration);

            this.expiration = dt.Ticks;
        }

        public override bool WillSoonExpire()
        {
            return roleSessionDurationSeconds * (1 - expireFact) * 1000 * 1000 * 10 > RemainTicks();
        }

        public bool IsExpired()
        {
            return refreshIntervalInMillSeconds * 1000 * 10 >= RemainTicks();
        }

        public bool ShouldRefresh()
        {
            var now = DateTime.UtcNow.Ticks;
            return now - lastFailedRefreshTime > refreshIntervalInMillSeconds;
        }

        public void SetLastFailedRefreshTime()
        {
            lastFailedRefreshTime = DateTime.UtcNow.Ticks;
        }

        public virtual long RemainTicks()
        {
            return expiration - DateTime.UtcNow.Ticks;
        }
    }
}
