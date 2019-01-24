using System;
using System.Security.Cryptography;
using System.Text;

using Aliyun.Acs.Core.Auth;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Auth
{
    public class SignerTest
    {
        [Fact]
        public void Instance()
        {
            MockSigner instance = new MockSigner();
            var mock = new Mock<AlibabaCloudCredentials>();
            AlibabaCloudCredentials credentials = mock.Object;
            Assert.IsType<HmacSHA1Signer>(MockSigner.GetSigner(credentials));

            KeyPairCredentials KeyPairCredentials = new KeyPairCredentials("publicKeyId", "privateKeySecret");
            Assert.IsType<SHA256withRSASigner>(MockSigner.GetSigner(KeyPairCredentials));
        }
    }
    public class MockSigner : Signer
    {
        public override String SignString(String stringToSign, String accessKeySecret)
        {
            return "";
        }

        public override String SignString(String stringToSign, AlibabaCloudCredentials credentials)
        {
            return "";
        }

        public override String GetSignerName()
        {
            return "";
        }

        public override String GetSignerVersion()
        {
            return "";
        }

        public override String GetSignerType()
        {
            return "";
        }
    }
}
