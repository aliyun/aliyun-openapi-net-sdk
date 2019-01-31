using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class HmacSHA1SignerTest
    {

        [Fact]
        public void SignString()
        {
            HmacSHA1Signer instance = new HmacSHA1Signer();
            string sign = instance.SignString("foo", "secret");
            Assert.Equal("m67ZG+f1i1fIJLYNp8smKy7K+9I=", sign);
        }

        [Fact]
        public void GetSignerName()
        {
            HmacSHA1Signer instance = new HmacSHA1Signer();
            string signer = instance.GetSignerName();
            Assert.Equal("HMAC-SHA1", signer);

            string signerVersion = instance.GetSignerVersion();
            Assert.Equal("1.0", signerVersion);

            // 此方法只回调了一个 null 值
            string signerType = instance.GetSignerType();
            Assert.Null(signerType);
        }
    }
}
