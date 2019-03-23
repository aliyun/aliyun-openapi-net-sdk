using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Profile;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class CredentialsBackupCompatibilityAdaptorTest
    {

        [Fact]
        public void GetAccessKeyId()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            DefaultAcsClient client = new DefaultAcsClient(profile);
            var provider = new StaticCredentialsProvider(profile);
            CredentialsBackupCompatibilityAdaptor instance = new CredentialsBackupCompatibilityAdaptor(provider);
            Assert.Equal("accessKeyId", instance.GetAccessKeyId());
        }

        [Fact]
        public void GetAccessKeySecret()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            DefaultAcsClient client = new DefaultAcsClient(profile);
            var provider = new StaticCredentialsProvider(profile);
            CredentialsBackupCompatibilityAdaptor instance = new CredentialsBackupCompatibilityAdaptor(provider);
            Assert.Equal("accessKeySecret", instance.GetAccessSecret());
        }

        [Fact]
        public void GetSecurityToken()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            DefaultAcsClient client = new DefaultAcsClient(profile);
            var provider = new StaticCredentialsProvider(profile);
            CredentialsBackupCompatibilityAdaptor instance = new CredentialsBackupCompatibilityAdaptor(provider);
            Assert.Null(instance.GetSecurityToken());

            profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            profile.GetCredential().SecurityToken = "some string";
            client = new DefaultAcsClient(profile);
            provider = new StaticCredentialsProvider(profile);
            instance = new CredentialsBackupCompatibilityAdaptor(provider);
            Assert.NotNull(instance.GetSecurityToken());

        }

        [Fact]
        public void Get()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            DefaultAcsClient client = new DefaultAcsClient(profile);
            var provider = new StaticCredentialsProvider(profile);
            CredentialsBackupCompatibilityAdaptor instance = new CredentialsBackupCompatibilityAdaptor(provider);
            ;
            Assert.IsType<int>(instance.GetHashCode());
            instance.GetType();
            Assert.IsType<Aliyun.Acs.Core.Auth.CredentialsBackupCompatibilityAdaptor>(instance);
        }

        [Fact]
        public void IsExpired()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            DefaultAcsClient client = new DefaultAcsClient(profile);
            var provider = new StaticCredentialsProvider(profile);
            CredentialsBackupCompatibilityAdaptor instance = new CredentialsBackupCompatibilityAdaptor(provider);
            Assert.False(instance.IsExpired());
        }
    }
}
