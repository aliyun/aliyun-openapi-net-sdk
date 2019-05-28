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
    public class BasicCredentialsTest
    {
        [Fact]
        public void GetAccessKeyId()
        {
            var basicCredentials = new BasicCredentials("foo", "bar");
            Assert.Equal("foo", basicCredentials.GetAccessKeyId());
        }

        [Fact]
        public void GetAccessKeyIdException()
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var basicCredentials = new BasicCredentials(null, "accessKeySecret");
            });

            Assert.Equal("Access key ID cannot be null.", exception.ParamName);
        }

        [Fact]
        public void GetAccessKeySecret()
        {
            var basicCredentials = new BasicCredentials("foo", "bar");
            Assert.Equal("bar", basicCredentials.GetAccessKeySecret());
        }

        [Fact]
        public void GetAccessKeySecretException()
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var basicCredentials = new BasicCredentials("accessKeyId", null);
            });

            Assert.Equal("Access key secret cannot be null.", exception.ParamName);
        }
    }
}
