using System.Collections.Generic;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class RoaSignatureComposerTest
    {
        [Fact]
        public void RefreshSignParameters()
        {
            RoaSignatureComposer.ClearComposer();
            RoaSignatureComposer instance = new RoaSignatureComposer();
            Dictionary<string, string> parameters = new Dictionary<string, string>
            { { "foo", "bar" },
                { "a", "A" },
                { "nullValue", null }
            };
            var mock = new Mock<Signer>();
            mock.Setup(foo => foo.GetSignerType()).Returns("MockSigner");
            Signer signer = mock.Object;
            UnmarshallerContext context = new UnmarshallerContext();

            context.ResponseDictionary = instance.RefreshSignParameters(parameters, signer, "accessKeyId", FormatType.JSON);
            Assert.Equal("MockSigner", context.StringValue("x-acs-signature-type"));

            HmacSHA1Signer hmacSHA1Signer = new HmacSHA1Signer();
            context.ResponseDictionary = instance.RefreshSignParameters(parameters, hmacSHA1Signer, "accessKeyId", null);
            Assert.Null(context.StringValue("x-acs-signature-type"));
        }

        [Fact]
        public void ReplaceOccupiedParameters()
        {
            RoaSignatureComposer.ClearComposer();
            Dictionary<string, string> tmp = new Dictionary<string, string>
            { { "foo", "bar" },
                { "a", "A" },
                { "b", "B" }
            };
            string result = RoaSignatureComposer.ReplaceOccupiedParameters("url?a=[a]&foo=[foo]&b=[b]", tmp);
            Assert.Equal("url?a=A&foo=bar&b=B", result);
        }

        [Fact]
        public void ComposeStringToSign()
        {
            RoaSignatureComposer.ClearComposer();
            Dictionary<string, string> tmp = new Dictionary<string, string>
            { { "foo", "bar" },
                { "a", "A" },
                { "nullValue", null }
            };
            MethodType method = MethodType.GET;
            Signer signer = new HmacSHA1Signer();
            ISignatureComposer instance = RoaSignatureComposer.GetComposer();
            string result = instance.ComposeStringToSign(method, "www.alibabacloud.com?", signer, tmp, tmp, tmp);
            Assert.Equal("GET\n\n\n\n\nwww.alibabacloud.com?&a=A&foo=bar&nullValue", result);
        }
    }
}
