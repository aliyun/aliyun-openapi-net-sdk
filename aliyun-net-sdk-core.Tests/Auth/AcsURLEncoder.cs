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
            string result = AcsURLEncoder.PercentEncode("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~!@#$%^&*()");
            Assert.Equal("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~%21%40%23%24%25%5E%26%2A%28%29", result);
        }
    }
}
