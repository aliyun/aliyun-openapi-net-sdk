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
using Aliyun.Acs.Core.Auth.Provider;
using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Utils;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth.Provider
{
    public class DefaultCredentialProviderTest
    {
        /*
        Case: Should throw ClientException("There is no credential chain can use")
         */
        [Fact]
        public void GetAlibabaCloudClientCredentialWithException()
        {
            var provider = new Mock<DefaultCredentialProvider>();
            var defaultProvider = provider.Object;

            var exception = Assert.Throws<ClientException>(() =>
            {
                var credential = defaultProvider.GetAlibabaCloudClientCredential();
            });

            Assert.Equal("There is no credential chain can use.", exception.Message);
        }

        /*
        Case: Test Credential File With default Client Name and file exist with ak value and type
        Result: should return AccessKeyCredential
        Use credential chains
         */
        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithAKType()
        {
            var profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";
            var defaultCredentialProvider = new DefaultCredentialProvider(profile, null);
            TestHelper.CreateIniFileWithAkType();

            var credential = (BasicCredentials) defaultCredentialProvider.GetAlibabaCloudClientCredential();

            TestHelper.DeleteIniFile();

            Assert.NotNull(credential);
            Assert.NotNull(credential.GetAccessKeyId());
            Assert.NotNull(credential.GetAccessKeySecret());
        }

        /*
        Case: Test Credential File With default Client Name and file exist with ak value and type but ak is empty
        Result: should return exception
        Use credential chains
        */
        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithAKTypeButAKIsEmpty()
        {
            var profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";
            var defaultCredentialProvider = new DefaultCredentialProvider(profile, null);
            TestHelper.CreateIniFileWithAkTypeWithEmptyAK();

            var exception = Assert.Throws<ClientException>(() =>
            {
                var credential = (BasicCredentials) defaultCredentialProvider.GetAlibabaCloudClientCredential();
            });

            TestHelper.DeleteIniFile();

            Assert.Equal("Missing required variable option for 'default Client'", exception.Message);
        }

        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithDefaultSection()
        {
            TestHelper.CreateIniFileWithDefaultSection();

            var profile = DefaultProfile.GetProfile();
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_CREDENTIALS_FILE", TestHelper.GetIniFilePath());

            var provider = new DefaultCredentialProvider(profile, null);

            var credential = provider.GetAlibabaCloudClientCredential();

            TestHelper.DeleteIniFile();
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_CREDENTIALS_FILE", null);
            Assert.NotNull(credential);
        }

        /*
        Case: Test Credential File With default Client Name and file exist with ecs credential
        Result: should return EcsRamRoleCredential
        Use credential chains
         */
        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithEcsRamRole()
        {
            var ecsRamRoleCredential =
                new InstanceProfileCredentials("fakeak", "fakeaks", "fakesession", DateTime.UtcNow.ToString(), 4000);
            var mockHomePath = EnvironmentUtil.GetHomePath();

            TestHelper.CreateIniFileWithEcs();

            var profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";

            var mockDefaultCredentialProvider = new Mock<DefaultCredentialProvider>(profile, null);
            mockDefaultCredentialProvider.Setup(x => x.GetInstanceRamRoleAlibabaCloudCredential())
                .Returns(ecsRamRoleCredential);
            mockDefaultCredentialProvider.Setup(x => x.GetHomePath()).Returns(mockHomePath);

            var defaultCredentialProvider = mockDefaultCredentialProvider.Object;
            var credential = (InstanceProfileCredentials) defaultCredentialProvider.GetAlibabaCloudClientCredential();

            TestHelper.DeleteIniFile();
            Assert.NotNull(credential);
        }

        /*
        Case: Test Credential File Without default Client Name and file exist with ak value
        Result: should return AccessKeyCredential
        Use credential chains
         */
        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithFileAndAkExist()
        {
            TestHelper.CreateIniFileWithAk();

            var profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = null;

            var defaultCredentialProvider = new DefaultCredentialProvider(profile, null);

            var credential = (BasicCredentials) defaultCredentialProvider.GetCredentialFileAlibabaCloudCredential();

            TestHelper.DeleteIniFile();
            Assert.NotNull(credential);
            Assert.Equal("foo", credential.GetAccessKeyId());
        }

        /*
        Case: Test Credential File Without default Client Name and file exist with ak value
        Result: crendential should be null
         */
        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithFileAndAkExistNotDefault()
        {
            TestHelper.CreateIniFileWithAkNotDefault();

            var profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = null;

            var defaultCredentialProvider = new DefaultCredentialProvider(profile, null);

            var credential = defaultCredentialProvider.GetCredentialFileAlibabaCloudCredential();

            TestHelper.DeleteIniFile();
            Assert.Null(credential);
        }

        /*
        Case: Test Credential File Without default Client Name and invalid file path 
        Result: should return null and go to next chain
         */
        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithInvalidFile()
        {
            var profile = DefaultProfile.GetProfile();
            var mockDefaultCredentialProvider = new Mock<DefaultCredentialProvider>(profile, null);
            mockDefaultCredentialProvider.Setup(x => x.GetHomePath()).Returns("\\fsafas\\fsdafads");
            var defaultCredentialProvider = mockDefaultCredentialProvider.Object;

            var credential = defaultCredentialProvider.GetCredentialFileAlibabaCloudCredential();

            Assert.Null(credential);
        }

        /*
        Case: Test Credential File With default Client Name and file exist with ram credential
        Result: should return RamRoleArnCredential
        Use credential chains
         */
        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithRamRole()
        {
            var ramRoleCredential = new InstanceProfileCredentials("fakeak", "fakeaks", "fakesessiontokne",
                DateTime.UtcNow.ToString(), 4000);
            TestHelper.CreateIniFileWithRam();

            var mockHomePath = EnvironmentUtil.GetHomePath();

            var profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";

            var mockDefaultCredentialProvider = new Mock<DefaultCredentialProvider>(profile, null);
            mockDefaultCredentialProvider.Setup(x => x.GetRamRoleArnAlibabaCloudCredential())
                .Returns(ramRoleCredential);
            mockDefaultCredentialProvider.Setup(x => x.GetHomePath()).Returns(mockHomePath);

            var defaultCredentialProvider = mockDefaultCredentialProvider.Object;

            var credential = (InstanceProfileCredentials) defaultCredentialProvider.GetAlibabaCloudClientCredential();

            TestHelper.DeleteIniFile();
            Assert.NotNull(credential);
        }

        /*
        Case: Test Credential File With default Client Name and file exist with rsa credential
        Result: should return BasicSessionCredentials
        Use credential chains
         */
        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithRsaKey()
        {
            var basicSessionCredential = new BasicSessionCredentials("fakeak", "fakeaks", "fakesessiontoken", 4000);
            var mockHomePath = EnvironmentUtil.GetHomePath();
            TestHelper.CreateIniFileWithRsaKey();

            var profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";

            var mockDefaultCredentialProvider = new Mock<DefaultCredentialProvider>(profile, null);
            mockDefaultCredentialProvider.Setup(x => x.GetRsaKeyPairAlibabaCloudCredential())
                .Returns(basicSessionCredential);
            mockDefaultCredentialProvider.Setup(x => x.GetHomePath()).Returns(mockHomePath);

            var defaultCredentialProvider = mockDefaultCredentialProvider.Object;

            var credential = (BasicSessionCredentials) defaultCredentialProvider.GetAlibabaCloudClientCredential();

            TestHelper.DeleteIniFile();
            Assert.NotNull(credential);
        }

        /*
        Case: Test Environment use credential chain
        Result: Should not be null and return AccessKeyCredential
         */
        [Fact]
        public void GetEnvironmentAlibabaCloudCredentialUseChain()
        {
            var profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";

            TestHelper.InitializeEnvironmentValue();

            var defaultCredentialProvider = new DefaultCredentialProvider(profile, null);
            var credential = (BasicCredentials) defaultCredentialProvider.GetAlibabaCloudClientCredential();

            Assert.NotNull(credential);
            Assert.Equal("ACCESS_KEY_ID", credential.GetAccessKeyId());

            TestHelper.RemoveEnvironmentValue();
        }

        /*
        Case: Test Environment with ENV AK
        Result: Should not be null
         */
        [Fact]
        public void GetEnvironmentAlibabaCloudCredentialWithEnvAKTest()
        {
            var profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";

            TestHelper.InitializeEnvironmentValue();

            var defaultCredentialProvider = new DefaultCredentialProvider(profile, null);
            var credential = (BasicCredentials) defaultCredentialProvider.GetEnvironmentAlibabaCloudCredential();

            Assert.NotNull(credential);
            Assert.Equal("ACCESS_KEY_ID", credential.GetAccessKeyId());

            TestHelper.RemoveEnvironmentValue();
        }

        /*
        Case: Test Environment without ENV AK
        Result: Should be null
         */
        [Fact]
        public void GetEnvironmentClientCredentialWithoutAKTest()
        {
            var defaultCredentialProvider = new DefaultCredentialProvider();
            var credential = (BasicCredentials) defaultCredentialProvider.GetEnvironmentAlibabaCloudCredential();
            Assert.Null(credential);
        }

        [Fact]
        public void GetInstanceRamRoleAlibabaCloudCredential()
        {
            var profile = DefaultProfile.GetProfile();
            var defaultCredentialProvider = new DefaultCredentialProvider(profile, null);

            var exception = Assert.Throws<ClientException>(() =>
            {
                defaultCredentialProvider.GetInstanceRamRoleAlibabaCloudCredential();
            });

            Assert.Equal("RegionID cannot be null or empty.", exception.Message);

            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", "region_id");
            profile.DefaultClientName = "test";
            defaultCredentialProvider = new DefaultCredentialProvider(profile, null);
            var credentialProvider = defaultCredentialProvider.GetInstanceRamRoleAlibabaCloudCredential();

            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", null);
            Assert.Null(credentialProvider);
        }

        [Fact]
        public void GetInstanceRamRoleAlibabaCloudCredential2()
        {
            var profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", "region_id");
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_ECS_METADATA", "role_name");

            var instanceProfileCredential =
                new InstanceProfileCredentials("fakeak", "fakeaks", "fakesession", DateTime.UtcNow.ToString(), 4000);
            var mockInstanceProfileProvider = new Mock<InstanceProfileCredentialsProvider>("role_name");
            mockInstanceProfileProvider.Setup(x => x.GetCredentials()).Returns(instanceProfileCredential);
            var instanceProfileProvider = mockInstanceProfileProvider.Object;

            var defaultCredentialProvider = new DefaultCredentialProvider(profile, instanceProfileProvider);
            var actualCredential = defaultCredentialProvider.GetInstanceRamRoleAlibabaCloudCredential();

            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", null);
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_ECS_METADATA", null);
            Assert.NotNull(actualCredential);
            Assert.Equal("fakeak", actualCredential.GetAccessKeyId());
        }

        [Fact]
        public void GetInstanceRamRoleAlibabaCloudCredential3()
        {
            var profile = DefaultProfile.GetProfile();
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", "region_id");
            profile.DefaultClientName = "default";
            var defaultCredentialProvider = new DefaultCredentialProvider(profile, null);
            var exception = Assert.Throws<ArgumentNullException>(() =>
            {
                var credentialProvider = defaultCredentialProvider.GetInstanceRamRoleAlibabaCloudCredential();
            });

            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", null);
            Assert.Equal("You must specifiy a valid role name.", exception.ParamName);
        }

        [Fact]
        public void GetRamRoleArnAlibabaCloudCredential()
        {
            TestHelper.InitializeEnvironmentValue();

            var ramRoleCredential =
                new InstanceProfileCredentials("accessKey", "aks", "roletoken", DateTime.UtcNow.ToString(), 3000);
            var profile = DefaultProfile.GetProfile();

            var response = new AssumeRoleResponse();
            response.Credentials = new AssumeRoleResponse.AssumeRole_Credentials();
            response.Credentials.AccessKeyId = "ak";
            response.Credentials.AccessKeySecret = "aks";
            response.Credentials.SecurityToken = "token";

            var mockClient = new Mock<IAcsClient>();
            mockClient.Setup(x => x.GetAcsResponse(It.IsAny<AcsRequest<AssumeRoleResponse>>())).Returns(response);
            var client = mockClient.Object;

            var stsProvider = new STSAssumeRoleSessionCredentialsProvider(ramRoleCredential, "roleArn", client);
            var defaultCredentialProvider = new DefaultCredentialProvider(profile, stsProvider);

            var actualCredentil = defaultCredentialProvider.GetRamRoleArnAlibabaCloudCredential();

            TestHelper.RemoveEnvironmentValue();
            Assert.NotNull(actualCredentil);
            Assert.Equal("aks", actualCredentil.GetAccessKeySecret());
        }

        [Fact]
        public void GetRamRoleArnAlibabaCloudCredential2()
        {
            TestHelper.InitializeEnvironmentValue();

            var ramRoleCredential =
                new InstanceProfileCredentials("accessKey", "aks", "roletoken", DateTime.UtcNow.ToString(), 3000);
            var profile = DefaultProfile.GetProfile();

            var defaultCredentialProvider = new DefaultCredentialProvider(profile, null);

            var exception = Assert.Throws<ClientException>(() =>
            {
                var actualCredentil = defaultCredentialProvider.GetRamRoleArnAlibabaCloudCredential();
            });

            TestHelper.RemoveEnvironmentValue();
            Assert.NotNull(exception.ErrorMessage);
        }

        [Fact]
        public void GetRamRoleArnAlibabaCloudCredentialWithException()
        {
            var profile = DefaultProfile.GetProfile();
            var defaultCredentialProvider = new DefaultCredentialProvider(profile, null);

            var exception = Assert.Throws<ClientException>(() =>
            {
                var credential = defaultCredentialProvider.GetRamRoleArnAlibabaCloudCredential();
            });

            Assert.Equal("Missing required variable option for 'default Client'", exception.Message);
        }

        [Fact]
        public void GetRsaKeyPairAlibabaCloudCredential()
        {
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", "region_id");

            var response = new GetSessionAccessKeyResponse();
            response.SessionAccesskey = new GetSessionAccessKeyResponse.GetSessionAccessKey_SessionAccesskey();
            response.SessionAccesskey.SessionAccessKeyId = "ak";
            response.SessionAccesskey.SessionAccessKeySecert = "aks";

            var mockClient = new Mock<IAcsClient>();
            mockClient.Setup(x => x.GetAcsResponse(It.IsAny<AcsRequest<GetSessionAccessKeyResponse>>()))
                .Returns(response);
            var client = mockClient.Object;

            var basicSessionCredential = new BasicSessionCredentials("accessKey", "aks", "sessionToken");
            var rsaKeyCredential = new KeyPairCredentials("publicKey", "privateKey");
            var profile = DefaultProfile.GetProfile();

            var rsaProvider = new Core.Auth.Provider.RsaKeyPairCredentialProvider(rsaKeyCredential, client);

            var defaultCredentialProvider =
                new DefaultCredentialProvider(profile, "publicKeyId", "privateKeyFile", rsaProvider);

            var actualCredentil = defaultCredentialProvider.GetRsaKeyPairAlibabaCloudCredential();

            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", null);
            Assert.NotNull(actualCredentil);
            Assert.Equal("aks", actualCredentil.GetAccessKeySecret());
        }

        [Fact]
        public void GetRsaKeyPairAlibabaCloudCredential2()
        {
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", "region_id");

            var basicSessionCredential = new BasicSessionCredentials("accessKey", "aks", "sessionToken");
            var rsaKeyCredential = new KeyPairCredentials("publicKey", "privateKey");
            var profile = DefaultProfile.GetProfile();

            var defaultCredentialProvider =
                new DefaultCredentialProvider(profile, "publicKeyId", "privateKeyFile", null);

            var exception = Assert.Throws<ClientException>(() =>
            {
                var actualCredentil = defaultCredentialProvider.GetRsaKeyPairAlibabaCloudCredential();
            });

            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", null);
            Assert.NotNull(exception.ErrorMessage);
        }

        [Fact]
        public void GetRsaKeyPairAlibabaCloudCredentialWithException()
        {
            var profile = DefaultProfile.GetProfile();
            var defaultCredentialProvider = new DefaultCredentialProvider(profile, null);

            var exception = Assert.Throws<ClientException>(() =>
            {
                var credential = defaultCredentialProvider.GetRsaKeyPairAlibabaCloudCredential();
            });

            Assert.Equal("Missing required variable option for 'default Client'", exception.Message);
        }
    }
}
