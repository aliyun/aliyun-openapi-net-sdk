using System;

using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Auth
{
    public class BasicCredentialsTest
    {
        [Fact]
        public void GetAccessKeyId()
        {
            BasicCredentials basicCredentials = new BasicCredentials("foo", "bar");
            Assert.Equal("foo", basicCredentials.GetAccessKeyId());
        }

        [Fact]
        public void GetAccessKeySecret()
        {
            BasicCredentials basicCredentials = new BasicCredentials("foo", "bar");
            Assert.Equal("bar", basicCredentials.GetAccessKeySecret());
        }
    }
}
