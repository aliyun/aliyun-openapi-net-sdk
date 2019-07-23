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
using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Profile;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class STSAssumeRoleSessionCredentialsProviderTest
    {
        [Fact]
        public void GetCredentials()
        {
            var mockRamRoleArnCredential =
                new Mock<BasicSessionCredentials>("accesskeyId", "accessKeySecret", "sessionToken", 100);
            var ramRoleCredential = mockRamRoleArnCredential.Object;

            var response = new AssumeRoleResponse();
            response.Credentials = new AssumeRoleResponse.AssumeRole_Credentials();
            response.Credentials.AccessKeyId = "ak";
            response.Credentials.AccessKeySecret = "aks";
            response.Credentials.SecurityToken = "token";

            var mockClient = new Mock<IAcsClient>();
            mockClient.Setup(x => x.GetAcsResponse(It.IsAny<AcsRequest<AssumeRoleResponse>>())).Returns(response);
            var client = mockClient.Object;

            var mockInstance = new Mock<STSAssumeRoleSessionCredentialsProvider>(ramRoleCredential, "roleArn", client);

            var instance = mockInstance.Object;

            Assert.NotNull(instance.GetCredentials());
        }

        [Fact]
        public void GetCredentialsWithPolicy()
        {
            var response = new AssumeRoleResponse();
            response.Credentials = new AssumeRoleResponse.AssumeRole_Credentials();
            response.Credentials.AccessKeyId = "ak";
            response.Credentials.AccessKeySecret = "aks";
            response.Credentials.SecurityToken = "token";

            var mockClient = new Mock<IAcsClient>();
            mockClient.Setup(x => x.GetAcsResponse(It.IsAny<AcsRequest<AssumeRoleResponse>>())).Returns(response);
            var client = mockClient.Object;

            var mockInstance = new Mock<STSAssumeRoleSessionCredentialsProvider>("roleArn", "policy", client);

            var instance = mockInstance.Object;

            var credential = instance.GetCredentials();
            Assert.NotNull(credential);
        }

        [Fact]
        public void Instance()
        {
            var mock = new Mock<AlibabaCloudCredentials>();
            var longLivedCredentials = mock.Object;
            var roleArn = "roleArn";
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");

            var instance = new STSAssumeRoleSessionCredentialsProvider(longLivedCredentials, roleArn, profile);

            Assert.NotNull(instance);
        }

        [Fact]
        public void InstanceProvider()
        {
            var mock = new Mock<AlibabaCloudCredentialsProvider>();
            var longLivedCredentialsProvider = mock.Object;
            var roleArn = "roleArn";
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");

            var instance = new STSAssumeRoleSessionCredentialsProvider(longLivedCredentialsProvider, roleArn, profile);

            Assert.NotNull(instance);
        }

        [Fact]
        public void InstanceWithPolicy()
        {
            var roleArn = "roleArn";
            var policy = "policy";

            var mockClient = new Mock<IAcsClient>();
            var client = mockClient.Object;

            var instance = new STSAssumeRoleSessionCredentialsProvider(roleArn, policy, client);

            Assert.NotNull(instance);
        }

        [Fact]
        public void WithRoleSessionDurationSecondss()
        {
            var mock = new Mock<AlibabaCloudCredentials>();
            var longLivedCredentials = mock.Object;
            var roleArn = "roleArn";
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            var instance = new STSAssumeRoleSessionCredentialsProvider(longLivedCredentials, roleArn, profile);

            long roleSessionDurationSeconds = 1000;

            // No Exception
            instance.WithRoleSessionDurationSeconds(roleSessionDurationSeconds);

            Assert.Throws<ArgumentOutOfRangeException>(
                () => { instance.WithRoleSessionDurationSeconds(100); }
            );
        }

        [Fact]
        public void WithRoleSessionName()
        {
            var mock = new Mock<AlibabaCloudCredentials>();
            var longLivedCredentials = mock.Object;
            var roleArn = "roleArn";
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            var instance = new STSAssumeRoleSessionCredentialsProvider(longLivedCredentials, roleArn, profile);

            instance.WithRoleSessionName("roleSessionName");

            Assert.IsType<STSAssumeRoleSessionCredentialsProvider>(instance);
        }

        [Fact]
        public void WithSTSClient()
        {
            var mock = new Mock<AlibabaCloudCredentials>();
            var longLivedCredentials = mock.Object;
            var roleArn = "roleArn";
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            var instance = new STSAssumeRoleSessionCredentialsProvider(longLivedCredentials, roleArn, profile);

            var mockClient = new Mock<IAcsClient>();
            var client = mockClient.Object;
            instance.WithSTSClient(client);

            Assert.IsType<STSAssumeRoleSessionCredentialsProvider>(instance);
        }
    }
}
