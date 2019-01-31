using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class ShaHmac256Test
    {
        private ShaHmac256 instance;

        public ShaHmac256 getInstance()
        {
            if (null == instance)
            {
                this.instance = new ShaHmac256();
            }
            return this.instance;
        }

        [Fact]
        public void SignString()
        {
            string str = this.getInstance().SignString("foo", "secret");
            Assert.Equal("dzukRpPHVT1u4g9h6l0nV6mk9KRNKEGuTpW1LkzWLbQ=", str);
        }

        [Fact]
        public void GetSignerName()
        {
            string signer = this.getInstance().SignerName;
            Assert.Equal("HMAC-SHA256", signer);
        }

        [Fact]
        public void GetSignerVersion()
        {
            string signerVersion = this.getInstance().SignerVersion;
            Assert.Equal("1.0", signerVersion);
        }
    }
}
