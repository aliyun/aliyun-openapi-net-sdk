using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Auth
{
    public class RpcSignatureComposerTest
    {
        [Fact]
        public void RefreshSignParameters()
        {
            Dictionary<string, string> tmp = new Dictionary<string, string>
            { { "foo", "bar" },
                { "a", "A" },
                { "b", "B" }
            };
            Signer signer = new HmacSHA1Signer();
            FormatType formatType = FormatType.JSON;
            ISignatureComposer instance = RoaSignatureComposer.GetComposer();
            Dictionary<String, String> result = instance.RefreshSignParameters(tmp, signer, "accessKeyId", formatType);
        }

        [Fact]
        public void ComposeStringToSign()
        {
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
