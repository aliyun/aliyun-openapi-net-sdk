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
    public class BasicCredentials : AlibabaCloudCredentials
    {
        private readonly string accessKeyId;
        private readonly string accessKeySecret;

        public BasicCredentials(string accessKeyId, string accessKeySecret)
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
        }

        public string GetAccessKeyId()
        {
            return accessKeyId;
        }

        public string GetAccessKeySecret()
        {
            return accessKeySecret;
        }
    }
}
