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
using Aliyun.Acs.Core.Exceptions;
using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class OIDCCredentialsProviderTest
    {
        [Fact]
        public void TestConstructor()
        {
            var filePath = TestHelper.GetOIDCTokenFilePath();
            var provider = new OIDCCredentialsProvider("roleArn", "providerArn", filePath, "sessionname", null);
            Assert.NotNull(provider);
            Assert.Equal("roleArn", provider.RoleArn);
            provider.RoleArn = "new-roleArn";
            Assert.Equal("new-roleArn", provider.RoleArn);

            Assert.Equal("providerArn", provider.OIDCProviderArn);
            provider.OIDCProviderArn = "new-providerArn";
            Assert.Equal("new-providerArn", provider.OIDCProviderArn);

            Assert.EndsWith("OIDCToken.txt", provider.OIDCTokenFilePath);
            provider.OIDCTokenFilePath = "/tmp/oidctoken";
            Assert.Equal("/tmp/oidctoken", provider.OIDCTokenFilePath);

            Assert.Equal("sessionname", provider.RoleSessionName);
            provider.RoleSessionName = "new-sessionname";
            Assert.Equal("new-sessionname", provider.RoleSessionName);

            Assert.Null(provider.Policy);
            provider.Policy = "{}";
            Assert.Equal("{}", provider.Policy);
        }

        [Fact]
        public void TestEmptyRoleArn()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => { new OIDCCredentialsProvider(null, null, null, null, null); });
            Assert.StartsWith("roleArn does not exist and env ALIBABA_CLOUD_ROLE_ARN is null.", ex.Message);

            ex = Assert.Throws<ArgumentNullException>(() => { new OIDCCredentialsProvider("roleArn", null, null, null, null); });
            Assert.StartsWith("OIDCProviderArn does not exist and env ALIBABA_CLOUD_OIDC_PROVIDER_ARN is null.", ex.Message);

            ex = Assert.Throws<ArgumentNullException>(() => { new OIDCCredentialsProvider("roleArn", "providerArn", null, null, null); });
            Assert.StartsWith("OIDCTokenFilePath does not exist and env ALIBABA_CLOUD_OIDC_TOKEN_FILE is null.", ex.Message);

            var provider = new OIDCCredentialsProvider("roleArn", "providerArn", "", "sessionname", null);
            var notExistEx = Assert.Throws<ClientException>(() => { provider.GetCredentials(); });
            Assert.Equal("OIDCTokenFilePath  does not exist.", notExistEx.Message);
        }

        [Fact]
        public void TestRealGetCredentials()
        {
            var filePath = TestHelper.GetOIDCTokenFilePath();
            var provider = new OIDCCredentialsProvider("roleArn", "providerArn", filePath, null, "us-west-1");
            Assert.NotNull(provider);
            var ex = Assert.Throws<ClientException>(() => { provider.GetCredentials(); });
            Assert.Contains("Parameter OIDCProviderArn is not valid", ex.Message);
        }

        [Fact]
        public void TestParseCredentials()
        {
            var ex = Assert.Throws<ClientException>(() => { OIDCCredentialsProvider.ParseCredentials("{}", 3600L); });
            Assert.Equal("AssumeRoleWithOIDC failed: {}", ex.Message);
            ex = Assert.Throws<ClientException>(() => { OIDCCredentialsProvider.ParseCredentials("", 3600L); });
            Assert.Equal("Invalid JSON", ex.Message);
            var credentials =OIDCCredentialsProvider.ParseCredentials("{\"Credentials\": {\"AccessKeyId\": \"sts_ak_id\",\"AccessKeySecret\": \"sts_ak_secret\", \"SecurityToken\": \"securitytoken\",\"Expiration\": \"2021-10-20T04:27:09Z\"}}", 3600L);
            Assert.Equal("sts_ak_id", credentials.GetAccessKeyId());
            Assert.Equal("sts_ak_secret", credentials.GetAccessKeySecret());
            Assert.Equal("securitytoken", credentials.GetSessionToken());
            Assert.False(credentials.WillSoonExpire());
        }
    }
}
