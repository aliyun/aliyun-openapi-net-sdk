using System.Text;
using System.Web;
using Xunit;
using Aliyun.Acs.Core.Auth;

namespace AuthTests
{
    public class AcsURLEncoder_Test
    {
        [Fact]
        public void Encode()
        {
            string encode = AcsURLEncoder.Encode(" ♂:@#¥%&*（");
            string source = HttpUtility.UrlDecode(encode, Encoding.UTF8);
            Assert.Equal(encode, source);
        }
    }
}