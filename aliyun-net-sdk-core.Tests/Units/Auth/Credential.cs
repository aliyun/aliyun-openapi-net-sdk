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
    public class CredentialTest
    {
        [Fact]
        public void Instance()
        {
            Credential instance;
            instance = new Credential();
            instance = new Credential("keyId", "secret");
            instance = new Credential("keyId", "secret", "securityToken");
            instance = new Credential("keyId", "secret", 24);
            instance = new Credential("keyId", "secret", "securityToken", 24);

            Assert.NotNull(instance);
            Assert.Equal("keyId", instance.GetAccessKeyId());
            Assert.Equal("secret", instance.GetAccessKeySecret());
        }

        [Fact]
        public void IsExpired()
        {
            Credential instance;
            instance = new Credential("keyId", "secret", 1);
            instance.ExpiredDate = DateTime.UtcNow.AddDays(1);
            Assert.True(instance.IsExpired());

            instance.ExpiredDate = null;
            Assert.False(instance.IsExpired());

            instance.ExpiredDate = DateTime.UtcNow.AddDays(-1);
            Assert.False(instance.IsExpired());
        }

        [Fact]
        public void SetExpiredDate()
        {
            Credential instance;
            instance = new Credential("keyId", "secret", -1);
            Assert.False(instance.IsExpired());

            instance = new Credential("keyId", "secret", 1);
            Assert.True(instance.IsExpired());
        }
    }
}
