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

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class CredentialsBackupCompatibilityAdaptorTest
    {
        [Fact]
        public void Get()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            var client = new DefaultAcsClient(profile);
            var provider = new StaticCredentialsProvider(profile);
            var instance = new CredentialsBackupCompatibilityAdaptor(provider);
            ;
            Assert.IsType<int>(instance.GetHashCode());
            instance.GetType();
            Assert.IsType<CredentialsBackupCompatibilityAdaptor>(instance);
        }

        [Fact]
        public void GetAccessKeyId()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            var client = new DefaultAcsClient(profile);
            var provider = new StaticCredentialsProvider(profile);
            var instance = new CredentialsBackupCompatibilityAdaptor(provider);
            Assert.Equal("accessKeyId", instance.GetAccessKeyId());
        }

        [Fact]
        public void GetAccessKeySecret()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            var client = new DefaultAcsClient(profile);
            var provider = new StaticCredentialsProvider(profile);
            var instance = new CredentialsBackupCompatibilityAdaptor(provider);
            Assert.Equal("accessKeySecret", instance.GetAccessSecret());
        }

        [Fact]
        public void GetSecurityToken()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            var client = new DefaultAcsClient(profile);
            var provider = new StaticCredentialsProvider(profile);
            var instance = new CredentialsBackupCompatibilityAdaptor(provider);
            Assert.Null(instance.GetSecurityToken());

            profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            profile.GetCredential().SecurityToken = "some string";
            client = new DefaultAcsClient(profile);
            provider = new StaticCredentialsProvider(profile);
            instance = new CredentialsBackupCompatibilityAdaptor(provider);
            Assert.NotNull(instance.GetSecurityToken());
        }

        [Fact]
        public void IsExpired()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            var client = new DefaultAcsClient(profile);
            var provider = new StaticCredentialsProvider(profile);
            var instance = new CredentialsBackupCompatibilityAdaptor(provider);
            Assert.False(instance.IsExpired());
        }
    }
}
