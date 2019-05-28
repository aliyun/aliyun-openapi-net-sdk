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

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Profile;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class StaticCredentialsProviderTest
    {
        [Fact]
        public void AlibabaCloudCredentialsInstance()
        {
            var mock = new Mock<AlibabaCloudCredentials>();

            var credentials = mock.Object;
            var instance = new StaticCredentialsProvider(credentials);
        }

        [Fact]
        public void IClientProfileInstance()
        {
            // when securityToken is not null
            var mock = new Mock<IClientProfile>();
            var credential = new Credential("accessKeyId", "accessKeySecret", "securityToken");
            mock.Setup(foo => foo.GetCredential()).Returns(credential);
            var profile = mock.Object;
            var instance = new StaticCredentialsProvider(profile);
            Assert.IsType<BasicSessionCredentials>(instance.GetCredentials());

            // when securityToken is null
            var mock2 = new Mock<IClientProfile>();
            var credential2 = new Credential("accessKeyId", "accessKeySecret");
            mock2.Setup(foo => foo.GetCredential()).Returns(credential2);
            var profile2 = mock2.Object;
            var instance2 = new StaticCredentialsProvider(profile2);
            Assert.IsType<LegacyCredentials>(instance2.GetCredentials());
        }
    }
}
