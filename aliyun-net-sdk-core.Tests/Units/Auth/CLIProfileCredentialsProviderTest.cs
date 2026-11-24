using System;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Auth.Provider;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Utils;
using Newtonsoft.Json;
using Xunit;


namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class CLIProfileCredentialsProviderTest
    {
        [Fact]
        public void GetProfileNameTest()
        {
            CLIProfileCredentialsProvider provider = new CLIProfileCredentialsProvider();
            Assert.Null(provider.GetProfileName());
            provider = new CLIProfileCredentialsProvider("AK");
            Assert.Equal("AK", provider.GetProfileName());

            var cacheProfile = Environment.GetEnvironmentVariable("ALIBABA_CLOUD_PROFILE");
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_PROFILE", "TEST");
            provider = new CLIProfileCredentialsProvider();
            Assert.Equal("TEST", provider.GetProfileName());
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_PROFILE", cacheProfile);

            var path = TestHelper.GetCLIConfigFilePath("aliyun");
            provider = new CLIProfileCredentialsProvider();
            var credential = provider.GetCredentials(path);

            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_PROFILE", "AK");
            credential = provider.GetCredentials(path);
            Environment.SetEnvironmentVariable("ALIBABA_CLOUD_PROFILE", cacheProfile);

            path = TestHelper.GetCLIConfigFilePath("empty");
            var ex = Assert.Throws<ClientException>(() => provider.GetCredentials(path));
            Assert.Equal("Unable to get profile form empty CLI credentials file.", ex.Message);
        }

        [Fact]
        public void ShouldReloadCredentialsProviderTest()
        {
            CLIProfileCredentialsProvider provider = new CLIProfileCredentialsProvider();
            Assert.True(provider.ShouldReloadCredentialsProvider(""));
        }

        [Fact]
        public void DisableCLIProfileTest()
        {
            bool isDisableCLIProfile = AuthUtils.EnvironmentDisableCLIProfile;
            AuthUtils.EnvironmentDisableCLIProfile = true;
            CLIProfileCredentialsProvider provider = new CLIProfileCredentialsProvider();
            var ex = Assert.Throws<ClientException>(() => { provider.GetCredentials(); });
            Assert.Contains("CLI credentials file is disabled.", ex.Message);
            AuthUtils.EnvironmentDisableCLIProfile = isDisableCLIProfile;
        }

        [Fact]
        public void ParseProfileTest()
        {
            CLIProfileCredentialsProvider provider = new CLIProfileCredentialsProvider();
            var ex = Assert.Throws<ClientException>(() => { provider.ParseProfile("./not_exist_config.json"); });
            Assert.Contains("Unable to open credentials file", ex.Message);

            string configPath = TestHelper.GetCLIConfigFilePath("invalid");
            ex = Assert.Throws<ClientException>(() => { provider.ParseProfile(configPath); });
            Assert.Contains("Failed to parse credential from CLI credentials file", ex.Message);

            configPath = TestHelper.GetCLIConfigFilePath("empty");
            CLIProfileCredentialsProvider.Config config = provider.ParseProfile(configPath);
            Assert.Null(config);

            configPath = TestHelper.GetCLIConfigFilePath("mock_empty");
            config = provider.ParseProfile(configPath);
            Assert.NotNull(config);
            Assert.Null(config.GetCurrent());
            Assert.Null(config.GetProfiles());

            configPath = TestHelper.GetCLIConfigFilePath("full");
            config = provider.ParseProfile(configPath);
            Assert.Equal("AK", config.GetCurrent());
            Assert.Equal(5, config.GetProfiles().Count);
            var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            Assert.Equal(
                "[{\"name\":\"AK\",\"mode\":\"AK\",\"access_key_id\":\"access_key_id\",\"access_key_secret\":\"access_key_secret\"},{\"name\":\"RamRoleArn\",\"mode\":\"RamRoleArn\",\"access_key_id\":\"access_key_id\",\"access_key_secret\":\"access_key_secret\",\"ram_role_arn\":\"ram_role_arn\",\"ram_session_name\":\"ram_session_name\",\"expired_seconds\":3600,\"sts_region\":\"cn-hangzhou\",\"enable_vpc\":true},{\"name\":\"EcsRamRole\",\"mode\":\"EcsRamRole\",\"ram_role_name\":\"ram_role_name\"},{\"name\":\"OIDC\",\"mode\":\"OIDC\",\"ram_role_arn\":\"ram_role_arn\",\"ram_session_name\":\"ram_session_name\",\"expired_seconds\":3600,\"sts_region\":\"cn-hangzhou\",\"oidc_token_file\":\"path/to/oidc/file\",\"oidc_provider_arn\":\"oidc_provider_arn\"},{\"name\":\"ChainableRamRoleArn\",\"mode\":\"ChainableRamRoleArn\",\"ram_role_arn\":\"ram_role_arn\",\"ram_session_name\":\"ram_session_name\",\"expired_seconds\":3600,\"sts_region\":\"cn-hangzhou\",\"source_profile\":\"AK\"}]",
                JsonConvert.SerializeObject(config.GetProfiles(), settings));
        }

        [Fact]
        public void ReloadCredentialsProviderTest()
        {
            CLIProfileCredentialsProvider provider = new CLIProfileCredentialsProvider();
            var configPath = TestHelper.GetCLIConfigFilePath("aliyun");
            CLIProfileCredentialsProvider.Config config = provider.ParseProfile(configPath);
            var ex = Assert.Throws<ClientException>(() => { provider.ReloadCredentialsProvider(config, "notExist"); });
            Assert.Contains("Unable to get profile with 'notExist' form CLI credentials file.", ex.Message);

            AlibabaCloudCredentialsProvider credentialsProvider = provider.ReloadCredentialsProvider(config, "AK");
            Assert.True(credentialsProvider is StaticCredentialsProvider);
            AlibabaCloudCredentials credential = credentialsProvider.GetCredentials();
            Assert.Equal("akid", credential.GetAccessKeyId());
            Assert.Equal("secret", credential.GetAccessKeySecret());

            credentialsProvider = provider.ReloadCredentialsProvider(config, "RamRoleArn");
            Assert.True(credentialsProvider is STSAssumeRoleSessionCredentialsProvider);
            ex = Assert.Throws<ClientException>(() => { credentialsProvider.GetCredentials(); });
            Assert.Contains("InvalidAccessKeyId.NotFound", ex.Message);

            credentialsProvider = provider.ReloadCredentialsProvider(config, "RamRoleArnEnableVpc");
            Assert.True(credentialsProvider is STSAssumeRoleSessionCredentialsProvider);
            ex = Assert.Throws<ClientException>(() => { credentialsProvider.GetCredentials(); });
            Assert.Contains("the request url is sts-vpc.cn-hangzhou.aliyuncs.com", ex.Message);

            var ex1 = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                provider.ReloadCredentialsProvider(config, "Invalid_RamRoleArn");
            });
            Assert.Contains("Access key ID cannot be null.", ex1.Message);

            credentialsProvider = provider.ReloadCredentialsProvider(config, "EcsRamRole");
            Assert.True(credentialsProvider is InstanceProfileCredentialsProvider);

            credentialsProvider = provider.ReloadCredentialsProvider(config, "OIDC");
            Assert.True(credentialsProvider is OIDCCredentialsProvider);

            credentialsProvider = provider.ReloadCredentialsProvider(config, "OIDCEnableVpc");
            Assert.True(credentialsProvider is OIDCCredentialsProvider);

            credentialsProvider = provider.ReloadCredentialsProvider(config, "ChainableRamRoleArn");
            Assert.True(credentialsProvider is STSAssumeRoleSessionCredentialsProvider);

            ex = Assert.Throws<ClientException>(() =>
            {
                provider.ReloadCredentialsProvider(config, "ChainableRamRoleArn1");
            });
            Assert.Equal("Source profile name can not be the same as profile name.", ex.Message);

            ex = Assert.Throws<ClientException>(() =>
            {
                provider.ReloadCredentialsProvider(config, "ChainableRamRoleArn2");
            });
            Assert.Contains("Unable to get profile with 'InvalidSource' form CLI credentials file.", ex.Message);

            ex = Assert.Throws<ClientException>(() => { provider.ReloadCredentialsProvider(config, "Unsupported"); });
            Assert.Contains("Unsupported profile mode 'Unsupported' form CLI credentials file.", ex.Message);
        }
    }
}
