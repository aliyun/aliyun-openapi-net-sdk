using System.Collections.Generic;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class RpcSignatureComposerTest
    {
        [Fact]
        public void RefreshSignParameters()
        {
            RpcSignatureComposer.ClearComposer();
            FormatType formatType = FormatType.JSON;;
            ISignatureComposer signatureComposer;
            UnmarshallerContext context;

            Dictionary<string, string> parameters = new Dictionary<string, string>
            { { "foo", "bar" },
                { "a", "A" },
                { "b", "B" }
            };

            // 覆盖formayType不为null, GetSignertype回调为null的情况
            HmacSHA1Signer hmacSHA1Signer = new HmacSHA1Signer();
            signatureComposer = RoaSignatureComposer.GetComposer();
            context = new UnmarshallerContext();
            context.ResponseDictionary = signatureComposer.RefreshSignParameters(parameters, hmacSHA1Signer, "accessKeyId", formatType);
            Assert.Equal("HMAC-SHA1", context.StringValue("x-acs-signature-method"));

            // 覆盖formayType为null, GetSignerType回调不为null的情况
            SHA256withRSASigner SHA256withRSASigner = new SHA256withRSASigner();
            Assert.NotNull(SHA256withRSASigner.GetSignerType());
            signatureComposer = new RpcSignatureComposer();
            context.ResponseDictionary = signatureComposer.RefreshSignParameters(parameters, SHA256withRSASigner, "accessKeyId", null);
            Assert.Null(context.StringValue("x-acs-signature-method"));
        }

        [Fact]
        public void ComposeStringToSign()
        {
            RpcSignatureComposer.ClearComposer();
            Dictionary<string, string> tmp = new Dictionary<string, string>
            { { "foo", "bar" },
                { "a", "A" },
                { "b", "B" }
            };
            MethodType method = MethodType.GET;
            Signer signer = new HmacSHA1Signer();
            ISignatureComposer instance = RoaSignatureComposer.GetComposer();
            string result = instance.ComposeStringToSign(method, "uriPattern", signer, tmp, tmp, tmp);
            Assert.Equal("GET\n\n\n\n\nuriPattern?a=A&b=B&foo=bar", result);
        }
    }
}
