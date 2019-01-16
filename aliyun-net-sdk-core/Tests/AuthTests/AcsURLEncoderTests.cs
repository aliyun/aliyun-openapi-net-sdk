using Xunit;
using Aliyun.Acs.Core.Auth;

namespace AuthTests
{
    public class AcsURLEncoder_Test
    {
        [Fact]
        public void Encode()
        {
            string source = AcsURLEncoder.Encode(" ♂:@#¥%&*（");
            Assert.False(source.Contains("@"));
        }
    }
}