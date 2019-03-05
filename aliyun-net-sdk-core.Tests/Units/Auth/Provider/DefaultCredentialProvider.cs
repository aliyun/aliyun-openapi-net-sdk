using System;
using System.Collections;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Auth.Provider;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;

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
            var credential = (AccessKeyCredential) defaultCredentialProvider.GetEnvironmentAlibabaCloudCredential();
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

            Core.Auth.Provider.DefaultCredentialProvider defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider(profile);
            var credential = (AccessKeyCredential) defaultCredentialProvider.GetEnvironmentAlibabaCloudCredential();

            Assert.NotNull(credential);
            Assert.Equal(Environment.GetEnvironmentVariable("ACCESS_KEY_ID"), credential.GetAccessKeyId());

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

            Core.Auth.Provider.DefaultCredentialProvider defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider(profile);
            var credential = (AccessKeyCredential) defaultCredentialProvider.GetAlibabaCloudClientCredential();

            Assert.NotNull(credential);
            Assert.Equal(Environment.GetEnvironmentVariable("ACCESS_KEY_ID"), credential.GetAccessKeyId());

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
            Mock<Core.Auth.Provider.DefaultCredentialProvider> mockDefaultCredentialProvider = new Mock<Core.Auth.Provider.DefaultCredentialProvider>(profile);
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

            var homePath = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Unix) ?
                Environment.GetEnvironmentVariable("HOME") :
                Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            TestHelper.CreateIniFileWithAk(homePath);

            var slash = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Unix) ? "/" : "\\";
            var finalLocation = homePath + slash + ".alibabacloud" + slash + "credentials.ini";
            var configuration = Configuration.LoadFromFile(finalLocation);

            DefaultProfile profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = null;
            Mock<Core.Auth.Provider.DefaultCredentialProvider> mockDefaultCredentialProvider = new Mock<Core.Auth.Provider.DefaultCredentialProvider>(profile);
            mockDefaultCredentialProvider.Setup(x => x.LoadFileFromIni(It.IsAny<string>())).Returns(configuration);
            mockDefaultCredentialProvider.Setup(x => x.GetHomePath()).Returns(homePath);
            var defaultCredentialProvider = mockDefaultCredentialProvider.Object;

            var credential = (AccessKeyCredential) defaultCredentialProvider.GetCredentialFileAlibabaCloudCredential();

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
            Core.Auth.Provider.DefaultCredentialProvider defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider(profile);
            var homePath = defaultCredentialProvider.GetHomePath();
            TestHelper.CreateIniFileWithAkType(homePath);

            var credential = (AccessKeyCredential) defaultCredentialProvider.GetAlibabaCloudClientCredential();

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
            var ecsRamRoleCredential = new EcsRamRoleCredential("fakeak", "fakeaks", "fakesession", DateTime.Now.ToString(), 4000);
            var homePath = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Unix) ?
                Environment.GetEnvironmentVariable("HOME") :
                Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            TestHelper.CreateIniFileWithEcs(homePath);

            var slash = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Unix) ? "/" : "\\";
            var finalLocation = homePath + slash + ".alibabacloud" + slash + "credentials.ini";
            var configuration = Configuration.LoadFromFile(finalLocation);

            DefaultProfile profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";

            Mock<Core.Auth.Provider.DefaultCredentialProvider> mockDefaultCredentialProvider = new Mock<Core.Auth.Provider.DefaultCredentialProvider>(profile);
            mockDefaultCredentialProvider.Setup(x => x.GetInstanceRamRoleAlibabaCloudCredential()).Returns(ecsRamRoleCredential);
            mockDefaultCredentialProvider.Setup(x => x.GetHomePath()).Returns(homePath);
            mockDefaultCredentialProvider.Setup(x => x.LoadFileFromIni(It.IsAny<string>())).Returns(configuration);
            var defaultCredentialProvider = mockDefaultCredentialProvider.Object;
            var credential = (EcsRamRoleCredential) defaultCredentialProvider.GetAlibabaCloudClientCredential();

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
            var ramRoleCredential = new RamRoleArnCredential("fakeak", "fakeaks", "fakeroleArn", "fakesessionname", "fakesessiontokne", 4000);
            var homePath = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Unix) ?
                Environment.GetEnvironmentVariable("HOME") :
                Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            TestHelper.CreateIniFileWithRam(homePath);

            var slash = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Unix) ? "/" : "\\";
            var finalLocation = homePath + slash + ".alibabacloud" + slash + "credentials.ini";
            var configurtion = Configuration.LoadFromFile(finalLocation);

            DefaultProfile profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";

            Mock<Core.Auth.Provider.DefaultCredentialProvider> mockDefaultCredentialProvider = new Mock<Core.Auth.Provider.DefaultCredentialProvider>(profile);
            mockDefaultCredentialProvider.Setup(x => x.GetRamRoleArnAlibabaCloudCredential()).Returns(ramRoleCredential);
            mockDefaultCredentialProvider.Setup(x => x.GetHomePath()).Returns(homePath);
            mockDefaultCredentialProvider.Setup(x => x.LoadFileFromIni(It.IsAny<string>())).Returns(configurtion);
            var defaultCredentialProvider = mockDefaultCredentialProvider.Object;

            var credential = (RamRoleArnCredential) defaultCredentialProvider.GetAlibabaCloudClientCredential();

            TestHelper.DeleteIniFile(homePath);
            Assert.NotNull(credential);
        }

        /*
        Case: Test Credential File With default Client Name and file exist with bearer token credential
        Result: should return BearerTokenCredential
        Use credential chains
         */
        [Fact]
        public void GetCredentialFileAlibabaCloudCredentialWithBearerToken()
        {
            DefaultProfile profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";
            Core.Auth.Provider.DefaultCredentialProvider defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider(profile);
            var homePath = defaultCredentialProvider.GetHomePath();

            TestHelper.CreateIniFileWithBearerToken(homePath);

            var credential = (BearerTokenCredential) defaultCredentialProvider.GetAlibabaCloudClientCredential();

            TestHelper.DeleteIniFile(homePath);
            Assert.NotNull(credential);
            Assert.Null(credential.GetAccessKeyId());
            Assert.Null(credential.GetAccessKeySecret());
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
            var homePath = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Unix) ?
                Environment.GetEnvironmentVariable("HOME") :
                Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            TestHelper.CreateIniFileWithRsaKey(homePath);

            var slash = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Unix) ? "/" : "\\";
            var finalLocation = homePath + slash + ".alibabacloud" + slash + "credentials.ini";
            var configurtion = Configuration.LoadFromFile(finalLocation);

            DefaultProfile profile = DefaultProfile.GetProfile();
            profile.DefaultClientName = "default";

            Mock<Core.Auth.Provider.DefaultCredentialProvider> mockDefaultCredentialProvider = new Mock<Core.Auth.Provider.DefaultCredentialProvider>(profile);
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

            Core.Auth.Provider.DefaultCredentialProvider defaultCredentialProvider = new Core.Auth.Provider.DefaultCredentialProvider(profile);

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

            var homePath = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.Unix) ?
                Environment.GetEnvironmentVariable("HOME") :
                Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            DefaultProfile profile = DefaultProfile.GetProfile();
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_CREDENTIALS_FILE", homePath);

            Mock<Core.Auth.Provider.DefaultCredentialProvider> mockProvider = new Mock<Core.Auth.Provider.DefaultCredentialProvider>(profile);
            mockProvider.Setup(x => x.LoadFileFromIni(It.IsAny<string>())).Returns(configuration);
            var providerObject = mockProvider.Object;

            var credential = providerObject.GetAlibabaCloudClientCredential();

            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_CREDENTIALS_FILE", null);
        }
    }
}
