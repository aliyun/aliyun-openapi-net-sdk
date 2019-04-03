using System;

using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class BasicSessionCredentialsTest
    {
        [Fact]
        public BasicSessionCredentials getInstance()
        {
            BasicSessionCredentials instance;
            Assert.Throws<System.ArgumentOutOfRangeException>(() =>
            {
                instance = new BasicSessionCredentials(null, null, "", 0);
            });

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                instance = new BasicSessionCredentials("accessKeyId", null, "", 0);
            });

            instance = new BasicSessionCredentials("accessKeyId", "accessKeySecret", "sessionToken", 1);
            return instance;
        }

        [Fact]
        public void Get()
        {
            Assert.Equal("accessKeyId", this.getInstance().GetAccessKeyId());

            Assert.Equal("accessKeySecret", this.getInstance().GetAccessKeySecret());

            Assert.Equal("sessionToken", this.getInstance().GetSessionToken());
        }

        [Fact]
        public void WillSoonExpire()
        {
            BasicSessionCredentials instance;
            instance = new BasicSessionCredentials("accessKeyId", "accessKeySecret", "sessionToken", 1);
            instance.WillSoonExpire();
            instance = new BasicSessionCredentials("accessKeyId", "accessKeySecret", "sessionToken", 0);
            instance.WillSoonExpire();
            Assert.False(instance.WillSoonExpire());
        }
    }
}
