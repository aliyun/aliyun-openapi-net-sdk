using System;

using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Auth
{
    public class LegacyCredentialsTest
    {

        [Fact]
        public void Instance()
        {
            Credential legacyCredential = new Credential("foo", "bar");
            LegacyCredentials instance = new LegacyCredentials(legacyCredential);
            Assert.IsType<LegacyCredentials>(instance);
            Assert.NotNull(instance);
        }

        [Fact]
        public void Get()
        {
            Credential legacyCredential = new Credential("foo", "bar");
            LegacyCredentials instance = new LegacyCredentials(legacyCredential);
            Assert.Equal("foo", instance.GetAccessKeyId());
        }

        [Fact]
        public void GetAccessKeySecret()
        {
            Credential legacyCredential = new Credential("foo", "bar");
            LegacyCredentials instance = new LegacyCredentials(legacyCredential);
            Assert.Equal("bar", instance.GetAccessKeySecret());
        }
    }
}
