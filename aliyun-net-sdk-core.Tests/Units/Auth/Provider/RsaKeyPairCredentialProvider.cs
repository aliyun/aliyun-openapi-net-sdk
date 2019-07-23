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
using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Profile;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth.Provider
{
    public class RsaKeyPairCredentialProvider
    {
        [Fact]
        public void GetCredentials()
        {
            var mockRsaPairCredential = new Mock<KeyPairCredentials>("publicKeyId", "privateKeyFile");
            var rsaPairCredential = mockRsaPairCredential.Object;

            var response = new GetSessionAccessKeyResponse();
            response.SessionAccesskey = new GetSessionAccessKeyResponse.GetSessionAccessKey_SessionAccesskey();
            response.SessionAccesskey.SessionAccessKeyId = "ak";
            response.SessionAccesskey.SessionAccessKeySecert = "aks";

            var mockClient = new Mock<IAcsClient>();
            mockClient.Setup(x => x.GetAcsResponse(It.IsAny<AcsRequest<GetSessionAccessKeyResponse>>()))
                .Returns(response);
            var client = mockClient.Object;

            var instance = new Core.Auth.Provider.RsaKeyPairCredentialProvider(rsaPairCredential, client);

            Assert.NotNull(instance.GetCredentials());
        }

        [Fact]
        public void RsaKeyPairCredentialProviderTest()
        {
            var mockRsaPairCredential = new Mock<KeyPairCredentials>("ak", "aks");
            var rsaPairCredential = mockRsaPairCredential.Object;

            var profile = DefaultProfile.GetProfile();

            var instance = new Core.Auth.Provider.RsaKeyPairCredentialProvider(rsaPairCredential, profile);
            Assert.NotNull(instance);
        }

        [Fact]
        public void WithDurationSecondsTest()
        {
            long seconds = 100;
            var mockRsaPairCredential = new Mock<KeyPairCredentials>("ak", "aks");
            var rsaPairCredential = mockRsaPairCredential.Object;
            var profile = DefaultProfile.GetProfile();

            var instance = new Core.Auth.Provider.RsaKeyPairCredentialProvider(rsaPairCredential, profile);

            instance.WithDurationSeconds(seconds);
        }

        [Fact]
        public void WithStsClient()
        {
            var profile = DefaultProfile.GetProfile("cn-hangzhou");
            var mockClient = new Mock<IAcsClient>();
            var client = mockClient.Object;

            var mockRsaPairCredential = new Mock<KeyPairCredentials>("ak", "aks");
            var rsaPairCredential = mockRsaPairCredential.Object;

            var instance = new Core.Auth.Provider.RsaKeyPairCredentialProvider(rsaPairCredential, profile);
            instance.WithSTSClient(client);
        }
    }
}
