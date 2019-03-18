using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth.Credential
{
    public class StsCredential
    {
        [Fact]
        public void GetAccesKey()
        {
            var stsCredential = new Core.Auth.StsCredential("keyId", "secret");

            Assert.Equal("keyId", stsCredential.GetAccessKeyId());
            Assert.Equal("secret", stsCredential.GetAccessKeySecret());
        }
    }
}
