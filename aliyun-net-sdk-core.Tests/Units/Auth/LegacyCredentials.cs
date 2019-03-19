using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class LegacyCredentialsTest
    {

        [Fact]
        public void Instance()
        {
            Core.Auth.Credential legacyCredential = new Core.Auth.Credential("foo", "bar");
            LegacyCredentials instance = new LegacyCredentials(legacyCredential);
            Assert.IsType<LegacyCredentials>(instance);
            Assert.NotNull(instance);
        }

        [Fact]
        public void Get()
        {
            Core.Auth.Credential legacyCredential = new Core.Auth.Credential("foo", "bar");
            LegacyCredentials instance = new LegacyCredentials(legacyCredential);
            Assert.Equal("foo", instance.GetAccessKeyId());
        }

        [Fact]
        public void GetAccessKeySecret()
        {
            Core.Auth.Credential legacyCredential = new Core.Auth.Credential("foo", "bar");
            LegacyCredentials instance = new LegacyCredentials(legacyCredential);
            Assert.Equal("bar", instance.GetAccessKeySecret());
        }
    }
}
