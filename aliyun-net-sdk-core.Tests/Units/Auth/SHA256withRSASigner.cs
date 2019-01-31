using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class SHA256withRSASignerTest
    {
        private SHA256withRSASigner instance;

        public SHA256withRSASigner getInstance()
        {
            if (null == instance)
            {
                this.instance = new SHA256withRSASigner();
            }
            return this.instance;
        }

        [Fact]
        public void SignString()
        {
            // 结果每次都是不同的
            string str = this.getInstance().SignString("foo", "secret");
            Assert.NotEmpty(str);
        }

        [Fact]
        public void GetSignerName()
        {
            string signer = this.getInstance().GetSignerName();
            Assert.Equal("SHA256withRSA", signer);
        }

        [Fact]
        public void GetSignerVersion()
        {
            string signerVersion = this.getInstance().GetSignerVersion();
            Assert.Equal("1.0", signerVersion);
        }

        [Fact]
        public void GetSignerType()
        {
            string signerType = this.getInstance().GetSignerType();
            Assert.Equal("PRIVATEKEY", signerType);
        }
    }
}
