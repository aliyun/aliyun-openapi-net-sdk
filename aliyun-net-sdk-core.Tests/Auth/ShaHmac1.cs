using System;
using System.Security.Cryptography;

using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Auth
{
    public class ShaHmac1Test
    {
        private ShaHmac1 instance;

        public ShaHmac1 getInstance()
        {
            if (null == instance)
            {
                this.instance = new ShaHmac1();
            }
            return this.instance;
        }

        [Fact]
        public void SignString()
        {
            string str = this.getInstance().SignString("foo", "secret");
            Assert.Equal("m67ZG+f1i1fIJLYNp8smKy7K+9I=", str);
        }

        [Fact]
        public void GetSignerName()
        {
            string signer = this.getInstance().SignerName;
            Assert.Equal("HMAC-SHA1", signer);
        }

        [Fact]
        public void GetSignerVersion()
        {
            string signerVersion = this.getInstance().SignerVersion;
            Assert.Equal("1.0", signerVersion);
        }
    }
}
