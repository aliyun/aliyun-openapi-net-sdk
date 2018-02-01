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
    public class BasicSessionCredentials : AlibabaCloudCredentials
    {
        private readonly String accessKeyId;
        private readonly String accessKeySecret;
        private readonly String sessionToken;
        protected readonly long roleSessionDurationSeconds;
        private long sessionStartedTimeInMilliSeconds = 0;
        private readonly double expireFact = 0.8;

        public BasicSessionCredentials(String accessKeyId, String accessKeySecret,
                                       String sessionToken, long roleSessionDurationSeconds = 0)
        {
            if (accessKeyId == null)
            {
                throw new ArgumentOutOfRangeException("Access key ID cannot be null.");
            }
            if (accessKeySecret == null)
            {
                throw new ArgumentOutOfRangeException("Access key secret cannot be null.");
            }

            this.accessKeyId = accessKeyId;
            this.accessKeySecret = accessKeySecret;
            this.sessionToken = sessionToken;
            this.roleSessionDurationSeconds = roleSessionDurationSeconds;
            this.sessionStartedTimeInMilliSeconds = DateTimeExtensions.currentTimeMillis(DateTime.Now);
        }

        public String GetAccessKeyId()
        {
            return accessKeyId;
        }

        public String GetAccessKeySecret()
        {
            return accessKeySecret;
        }

        public String GetSessionToken()
        {
            return sessionToken;
        }

        public virtual bool WillSoonExpire()
        {
            if (roleSessionDurationSeconds == 0)
            {
                return false;
            }
            long now = DateTimeExtensions.currentTimeMillis(DateTime.Now);
            return roleSessionDurationSeconds * expireFact < (now - sessionStartedTimeInMilliSeconds) / 1000.0;
        }
    }
}
