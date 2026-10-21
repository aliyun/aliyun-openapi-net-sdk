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

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class SignerTest
    {
        [Fact]
        public void Instance()
        {
            var instance = new MockSigner();
            var mock = new Mock<AlibabaCloudCredentials>();
            var credentials = mock.Object;
            Assert.IsType<HmacSHA256Signer>(Signer.GetSigner(credentials));

            var KeyPairCredentials = new KeyPairCredentials("publicKeyId", "privateKeySecret");
            Assert.IsType<SHA256withRSASigner>(Signer.GetSigner(KeyPairCredentials));

            var bearerTokenCredential = new BearerTokenCredential("FakeBearerToken");
            Assert.IsType<BearerTokenSigner>(Signer.GetSigner(bearerTokenCredential));
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void HmacFallbackPreservesCredentialRouting(bool useHmacSHA1)
        {
            var credentials = new AlibabaCloudCredentials[]
            {
                new BasicCredentials("test-id", "test-secret"),
                new BasicSessionCredentials("test-id", "test-secret", "test-token"),
                new LegacyCredentials(new Credential("test-id", "test-secret"))
            };
            foreach (var credential in credentials)
            {
                Assert.IsType<HmacSHA256Signer>(Signer.GetSigner(credential));
                Assert.Equal(useHmacSHA1 ? typeof(HmacSHA1Signer) : typeof(HmacSHA256Signer),
                    Signer.GetSigner(credential, useHmacSHA1).GetType());
            }

            Assert.IsType<SHA256withRSASigner>(Signer.GetSigner(
                new KeyPairCredentials("public-key-id", "private-key-secret"), useHmacSHA1));
            Assert.IsType<BearerTokenSigner>(Signer.GetSigner(new BearerTokenCredential("test-token"), useHmacSHA1));
        }
    }

    public class MockSigner : Signer
    {
        public override string SignString(string stringToSign, string accessKeySecret)
        {
            return "";
        }

        public override string SignString(string stringToSign, AlibabaCloudCredentials credentials)
        {
            return "";
        }

        public override string GetSignerName()
        {
            return "";
        }

        public override string GetSignerVersion()
        {
            return "";
        }

        public override string GetSignerType()
        {
            return "";
        }
    }
}
