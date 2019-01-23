using System;
using System.Globalization;
using System.Text;
using System.Web;

using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Auth
{
    public class AcsUrlEncoderTest
    {
        [Fact]
        public void Encode()
        {
            string source = " ♂:@#¥%&*（";
            string encode = HttpUtility.UrlDecode(AcsURLEncoder.Encode(" ♂:@#¥%&*（"), Encoding.UTF8);
            Assert.Equal(encode, source);
        }

        [Fact]
        public void PercentEncode()
        {
            Assert.NotNull(AcsURLEncoder.PercentEncode("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~!@#$%^&*()"));
        }
    }
}
