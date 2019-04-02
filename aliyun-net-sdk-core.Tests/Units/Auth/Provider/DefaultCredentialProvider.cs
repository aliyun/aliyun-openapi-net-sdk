using System;
using System.Collections;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Auth.Provider;
using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Utils;

using Moq;

using SharpConfig;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth.Provider
{
    public class DefaultCredentialProvider
    {
        /*
        Case: Test Environment without ENV AK
        Result: Should be null
         */
        [Fact]
        public void GetEnvironmentClientCredentialWithoutAKTest()
        {
            Core.Auth.Provider.DefaultCredentialProvider defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider();
            var credential = (BasicCredentials) defaultCredentialProvider.GetEnvironmentAlibabaCloudCredential();
            Assert.Null(credential);
        }

        /*
        Case: Test Environment with ENV AK
        Result: Should not be null
         */
        [Fact]
        public void GetEnvironmentAlibabaCloudCredentialWithEnvAKTest()
        {
            DefaultProfile profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";

            TestHelper.InitializeEnvironmentValue();

            var defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider(profile, null);
            var credential = (BasicCredentials) defaultCredentialProvider.GetEnvironmentAlibabaCloudCredential();

            Assert.NotNull(credential);
            Assert.Equal("ACCESS_KEY_ID", credential.GetAccessKeyId());

            TestHelper.RemoveEnvironmentValue();
        }

        /*
        Case: Test Environment use credential chain
        Result: Should not be null and return AccessKeyCredential
         */
        [Fact]
        public void GetEnvironmentAlibabaCloudCredentialUseChain()
        {
            DefaultProfile profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";

            TestHelper.InitializeEnvironmentValue();

            var defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider(profile, null);
            var credential = (BasicCredentials) defaultCredentialProvider.GetAlibabaCloudClientCredential();

            Assert.NotNull(credential);
            Assert.Equal("ACCESS_KEY_ID", credential.GetAccessKeyId());

            TestHelper.RemoveEnvironmentValue();
        }

        /*
        Case: Test Credential File Without default Client Name and invalid file path 
        Result: should return null and go to next chain
         */
        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithInvalidFile()
        {
            DefaultProfile profile = DefaultProfile.GetProfile();
            var mockDefaultCredentialProvider = new Mock<Core.Auth.Provider.DefaultCredentialProvider>(profile, null);
            mockDefaultCredentialProvider.Setup(x => x.GetHomePath()).Returns("\\fsafas\\fsdafads");
            var defaultCredentialProvider = mockDefaultCredentialProvider.Object;

            var credential = defaultCredentialProvider.GetCredentialFileAlibabaCloudCredential();

            Assert.Null(credential);
        }

        /*
        Case: Test Credential File Without default Client Name and file exist with ak value
        Result: should return AccessKeyCredential
        Use credential chains
         */
        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithFileAndAkExist()
        {

            var homePath = EnvironmentUtil.GetHomePath();
            TestHelper.CreateIniFileWithAk(homePath);

            var slash = EnvironmentUtil.GetOSSlash();
            var finalLocation = GetFileLocation(homePath, slash);
            var configuration = Configuration.LoadFromFile(finalLocation);

            DefaultProfile profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = null;
            var mockDefaultCredentialProvider = new Mock<Core.Auth.Provider.DefaultCredentialProvider>(profile, null);
            mockDefaultCredentialProvider.Setup(x => x.LoadFileFromIni(It.IsAny<string>())).Returns(configuration);
            mockDefaultCredentialProvider.Setup(x => x.GetHomePath()).Returns(homePath);
            var defaultCredentialProvider = mockDefaultCredentialProvider.Object;

            var credential = (BasicCredentials) defaultCredentialProvider.GetCredentialFileAlibabaCloudCredential();

            Assert.NotNull(credential);
            Assert.Equal("foo", credential.GetAccessKeyId());
        }

        /*
        Case: Test Credential File With default Client Name and file exist with ak value and type
        Result: should return AccessKeyCredential
        Use credential chains
         */
        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithAKType()
        {
            DefaultProfile profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";
            var defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider(profile, null);
            var homePath = defaultCredentialProvider.GetHomePath();
            TestHelper.CreateIniFileWithAkType(homePath);

            var credential = (BasicCredentials) defaultCredentialProvider.GetAlibabaCloudClientCredential();

            TestHelper.DeleteIniFile(homePath);

            Assert.NotNull(credential);
            Assert.NotNull(credential.GetAccessKeyId());
            Assert.NotNull(credential.GetAccessKeySecret());
        }

        /*
        Case: Test Credential File With default Client Name and file exist with ecs credential
        Result: should return EcsRamRoleCredential
        Use credential chains
         */
        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithEcsRamRole()
        {
            var ecsRamRoleCredential = new InstanceProfileCredentials("fakeak", "fakeaks", "fakesession", DateTime.Now.ToString(), 4000);
            var homePath = EnvironmentUtil.GetHomePath();
            TestHelper.CreateIniFileWithEcs(homePath);

            var slash = EnvironmentUtil.GetOSSlash();
            var finalLocation = GetFileLocation(homePath, slash);
            var configuration = Configuration.LoadFromFile(finalLocation);

            DefaultProfile profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";

            var mockDefaultCredentialProvider = new Mock<Core.Auth.Provider.DefaultCredentialProvider>(profile, null);
            mockDefaultCredentialProvider.Setup(x => x.GetInstanceRamRoleAlibabaCloudCredential()).Returns(ecsRamRoleCredential);
            mockDefaultCredentialProvider.Setup(x => x.GetHomePath()).Returns(homePath);
            mockDefaultCredentialProvider.Setup(x => x.LoadFileFromIni(It.IsAny<string>())).Returns(configuration);
            var defaultCredentialProvider = mockDefaultCredentialProvider.Object;
            var credential = (InstanceProfileCredentials) defaultCredentialProvider.GetAlibabaCloudClientCredential();

            TestHelper.DeleteIniFile(homePath);
            Assert.NotNull(credential);
        }

        /*
        Case: Test Credential File With default Client Name and file exist with ram credential
        Result: should return RamRoleArnCredential
        Use credential chains
         */
        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithRamRole()
        {
            var ramRoleCredential = new InstanceProfileCredentials("fakeak", "fakeaks", "fakesessiontokne", DateTime.Now.ToString(), 4000);
            var homePath = EnvironmentUtil.GetHomePath();
            TestHelper.CreateIniFileWithRam(homePath);

            var slash = EnvironmentUtil.GetOSSlash();
            var finalLocation = GetFileLocation(homePath, slash);
            var configurtion = Configuration.LoadFromFile(finalLocation);

            DefaultProfile profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";

            var mockDefaultCredentialProvider = new Mock<Core.Auth.Provider.DefaultCredentialProvider>(profile, null);
            mockDefaultCredentialProvider.Setup(x => x.GetRamRoleArnAlibabaCloudCredential()).Returns(ramRoleCredential);
            mockDefaultCredentialProvider.Setup(x => x.GetHomePath()).Returns(homePath);
            mockDefaultCredentialProvider.Setup(x => x.LoadFileFromIni(It.IsAny<string>())).Returns(configurtion);
            var defaultCredentialProvider = mockDefaultCredentialProvider.Object;

            var credential = (InstanceProfileCredentials) defaultCredentialProvider.GetAlibabaCloudClientCredential();

            TestHelper.DeleteIniFile(homePath);
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
            var homePath = EnvironmentUtil.GetHomePath();

            TestHelper.CreateIniFileWithRsaKey(homePath);

            var slash = EnvironmentUtil.GetOSSlash();
            var finalLocation = GetFileLocation(homePath, slash);
            var configurtion = Configuration.LoadFromFile(finalLocation);

            DefaultProfile profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";

            var mockDefaultCredentialProvider = new Mock<Core.Auth.Provider.DefaultCredentialProvider>(profile, null);
            mockDefaultCredentialProvider.Setup(x => x.GetRsaKeyPairAlibabaCloudCredential()).Returns(basicSessionCredential);
            mockDefaultCredentialProvider.Setup(x => x.GetHomePath()).Returns(homePath);
            mockDefaultCredentialProvider.Setup(x => x.LoadFileFromIni(It.IsAny<string>())).Returns(configurtion);
            var defaultCredentialProvider = mockDefaultCredentialProvider.Object;

            var credential = (BasicSessionCredentials) defaultCredentialProvider.GetAlibabaCloudClientCredential();

            TestHelper.DeleteIniFile(homePath);
            Assert.NotNull(credential);
        }

        /*
        Case: Test Credential File With default Client Name and file not exist
        Result: should return clientexception  Invalid credentials file
        Use credential chains
         */
        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithEnvDefinedButNotFoundTest()
        {
            DefaultProfile profile = DefaultProfile.GetProfile();

            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_CREDENTIALS_FILE", "D://credentials1.ini");

            var defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider(profile, null);

            var exception = Assert.Throws<ClientException>(() =>
            {
                var credential = defaultCredentialProvider.GetAlibabaCloudClientCredential();
            });

            Assert.Equal("Invalid credentials file: D://credentials1.ini", exception.Message);
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_CREDENTIALS_FILE", null);
        }

        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithDefaultSection()
        {
            var iniData =
                "[default]  " + Environment.NewLine +
                "enable = true    " + Environment.NewLine +
                "type = access_key # Certification type : access_key " + Environment.NewLine +
                "access_key_id = foo # Key " + Environment.NewLine +
                "access_key_secret = bar # Secret " + Environment.NewLine +
                "region_id = cn-hangzhou # Optional£ Region ";
            var configuration = Configuration.LoadFromString(iniData);

            var homePath = EnvironmentUtil.GetHomePath();

            DefaultProfile profile = DefaultProfile.GetProfile();
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_CREDENTIALS_FILE", homePath);

            var mockProvider = new Mock<Core.Auth.Provider.DefaultCredentialProvider>(profile, null);
            mockProvider.Setup(x => x.LoadFileFromIni(It.IsAny<string>())).Returns(configuration);
            var providerObject = mockProvider.Object;

            var credential = providerObject.GetAlibabaCloudClientCredential();

            Assert.NotNull(credential);

            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_CREDENTIALS_FILE", null);
        }

        [Fact]
        public void GetInstanceRamRoleAlibabaCloudCredential()
        {
            var profile = DefaultProfile.GetProfile();
            var defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider(profile, null);

            var exception = Assert.Throws<ClientException>(() =>
            {
                defaultCredentialProvider.GetInstanceRamRoleAlibabaCloudCredential();
            });

            Assert.Equal("RegionID cannot be null or empty.", exception.Message);

            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", "region_id");
            profile.DefaultClientName = "test";
            defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider(profile, null);
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

            var ecsRamRoleCredential = new InstanceProfileCredentials("fakeak", "fakeaks", "fakesession", DateTime.Now.ToString(), 4000);
            var mockEcsMetaService = new Mock<ECSMetadataServiceCredentialsFetcher>();
            mockEcsMetaService.Setup(x => x.Fetch()).Returns(ecsRamRoleCredential);
            var eCSMetadataServiceCredentialsFetcher = mockEcsMetaService.Object;

            var defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider(profile, eCSMetadataServiceCredentialsFetcher);
            var actualCredential = defaultCredentialProvider.GetInstanceRamRoleAlibabaCloudCredential();

            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", null);
            Assert.NotNull(actualCredential);
            Assert.Equal("fakeak", actualCredential.GetAccessKeyId());
        }

        [Fact]
        public void GetRamRoleArnAlibabaCloudCredentialWithException()
        {
            var profile = DefaultProfile.GetProfile();
            var defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider(profile, null);

            var exception = Assert.Throws<ClientException>(() =>
            {
                var credential = defaultCredentialProvider.GetRamRoleArnAlibabaCloudCredential();
            });

            Assert.Equal("Missing required variable option for 'default Client'", exception.Message);
        }

        [Fact]
        public void GetRamRoleArnAlibabaCloudCredential()
        {
            TestHelper.InitializeEnvironmentValue();

            var ramRoleCredential = new InstanceProfileCredentials("accessKey", "aks", "roletoken", DateTime.Now.ToString(), 3000);
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
            var defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider(profile, stsProvider);

            var actualCredentil = defaultCredentialProvider.GetRamRoleArnAlibabaCloudCredential();

            TestHelper.RemoveEnvironmentValue();
            Assert.NotNull(actualCredentil);
            Assert.Equal("aks", actualCredentil.GetAccessKeySecret());
        }

        [Fact]
        public void GetRsaKeyPairAlibabaCloudCredentialWithException()
        {
            var profile = DefaultProfile.GetProfile();
            var defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider(profile, null);

            var exception = Assert.Throws<ClientException>(() =>
            {
                var credential = defaultCredentialProvider.GetRsaKeyPairAlibabaCloudCredential();
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
            mockClient.Setup(x => x.GetAcsResponse(It.IsAny<AcsRequest<GetSessionAccessKeyResponse>>())).Returns(response);
            var client = mockClient.Object;

            var basicSessionCredential = new BasicSessionCredentials("accessKey", "aks", "sessionToken");
            var rsaKeyCredential = new KeyPairCredentials("publicKey", "privateKey");
            var profile = DefaultProfile.GetProfile();

            var rsaProvider = new Core.Auth.Provider.RsaKeyPairCredentialProvider(rsaKeyCredential, client);

            var defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider(profile, rsaProvider, "publicKeyId", "privateKeyFile");

            var actualCredentil = defaultCredentialProvider.GetRsaKeyPairAlibabaCloudCredential();

            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_REGION_ID", null);
            Assert.NotNull(actualCredentil);
            Assert.Equal("aks", actualCredentil.GetAccessKeySecret());
        }

        private static string GetFileLocation(string homePath, string slash)
        {
            return homePath + slash + ".alibabacloud" + slash + "credentials.ini";
        }
    }
}
