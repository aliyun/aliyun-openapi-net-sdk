using System;

using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
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

        [Fact]
        public void GetAccessKeyIdException()
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var basicCredentials = new BasicCredentials(null, "accessKeySecret");
            });

            Assert.Equal("Access key ID cannot be null.", exception.ParamName);
        }

        [Fact]
        public void GetAccessKeySecretException()
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var basicCredentials = new BasicCredentials("accessKeyId", null);
            });

            Assert.Equal("Access key secret cannot be null.", exception.ParamName);
        }
    }
}
