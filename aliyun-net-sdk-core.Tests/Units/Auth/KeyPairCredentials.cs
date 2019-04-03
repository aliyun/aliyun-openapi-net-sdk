using System;

using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class KeyPairCredentialsTest
    {

        [Fact]
        public void GetAccessKeyId()
        {
            KeyPairCredentials instance = new KeyPairCredentials("publicKeyId", "privateKeySecret");
            Assert.Equal("publicKeyId", instance.GetAccessKeyId());

            Assert.Throws<ArgumentNullException>(() =>
            {
                instance = new KeyPairCredentials("publicKeyId", null);
            });
        }

        [Fact]
        public void GetAccessKeySecret()
        {
            KeyPairCredentials instance = new KeyPairCredentials("publicKeyId", "privateKeySecret");
            Assert.Equal("privateKeySecret", instance.GetAccessKeySecret());
            Assert.Equal("publicKeyId", instance.GetAccessKeyId());
        }
    }
}
