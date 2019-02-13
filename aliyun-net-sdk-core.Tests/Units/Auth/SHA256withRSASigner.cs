using System;
using System.Security.Cryptography;

using Aliyun.Acs.Core.Auth;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class SHA256withRSASignerTest
    {
        [Fact]
        public void SignString()
        {
            SHA256withRSASigner instance = new SHA256withRSASigner();

            // 结果每次都是不同的
            string str = instance.SignString("foo", "secret");
            Assert.NotEmpty(str);

            var mock = new Mock<AlibabaCloudCredentials>();
            mock.Setup(foo => foo.GetAccessKeySecret()).Returns("secret");
            AlibabaCloudCredentials credentials = mock.Object;
            string str2 = instance.SignString("foo", credentials);
            Assert.NotEmpty(str2);
        }

        [Fact]
        public void GetSignerName()
        {
            SHA256withRSASigner instance = new SHA256withRSASigner();
            string signer = instance.GetSignerName();
            Assert.Equal("SHA256withRSA", signer);
        }

        [Fact]
        public void GetSignerVersion()
        {
            SHA256withRSASigner instance = new SHA256withRSASigner();
            string signerVersion = instance.GetSignerVersion();
            Assert.Equal("1.0", signerVersion);
        }

        [Fact]
        public void GetSignerType()
        {
            SHA256withRSASigner instance = new SHA256withRSASigner();
            string signerType = instance.GetSignerType();
            Assert.Equal("PRIVATEKEY", signerType);
        }
    }
}
