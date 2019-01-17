using System.Text;
using System.Web;
using Xunit;
using Aliyun.Acs.Core.Auth;

namespace Aliyun.Acs.Core.UnitTests.Auth
{
    public class AcsURLEncoder_Test
    {
        [Fact]
        public void Encode()
        {
            string source = " ♂:@#¥%&*（";
            string encode = HttpUtility.UrlDecode(AcsURLEncoder.Encode(" ♂:@#¥%&*（"), Encoding.UTF8);
            Assert.Equal(encode, source);
        }
    }
}
