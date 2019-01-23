using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Auth
{
    public class RoaSignatureComposerTest
    {
        [Fact]
        public void ReplaceOccupiedParameters()
        {
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
