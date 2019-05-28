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

using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class BasicSessionCredentialsTest
    {
        [Fact]
        public void Get()
        {
            Assert.Equal("accessKeyId", getInstance().GetAccessKeyId());

            Assert.Equal("accessKeySecret", getInstance().GetAccessKeySecret());

            Assert.Equal("sessionToken", getInstance().GetSessionToken());
        }

        [Fact]
        public BasicSessionCredentials getInstance()
        {
            BasicSessionCredentials instance;
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                instance = new BasicSessionCredentials(null, null, "", 0);
            });

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                instance = new BasicSessionCredentials("accessKeyId", null, "", 0);
            });

            instance = new BasicSessionCredentials("accessKeyId", "accessKeySecret", "sessionToken", 1);
            return instance;
        }

        [Fact]
        public void WillSoonExpire()
        {
            BasicSessionCredentials instance;
            instance = new BasicSessionCredentials("accessKeyId", "accessKeySecret", "sessionToken", 1);
            instance.WillSoonExpire();
            instance = new BasicSessionCredentials("accessKeyId", "accessKeySecret", "sessionToken", 0);
            instance.WillSoonExpire();
            Assert.False(instance.WillSoonExpire());
        }
    }
}
