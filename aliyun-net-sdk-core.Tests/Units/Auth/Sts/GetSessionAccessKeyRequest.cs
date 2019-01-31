using System.Collections.Generic;

using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth.Sts
{
    public class GetSessionAccessKeyRequestTest
    {
        [Fact]
        public void DurationSecondsTest()
        {
            GetSessionAccessKeyRequest instance = new GetSessionAccessKeyRequest();
            int source = 100;
            instance.DurationSeconds = source;
            Assert.Equal(source, instance.DurationSeconds);
        }

        [Fact]
        public void PublicKeyIdTest()
        {
            GetSessionAccessKeyRequest instance = new GetSessionAccessKeyRequest();
            string source = "publicKeyId";
            instance.PublicKeyId = source;
            Assert.Equal(source, instance.PublicKeyId);
        }

        [Fact]
        public void GetResponse()
        {
            GetSessionAccessKeyRequest instance = new GetSessionAccessKeyRequest();
            UnmarshallerContext unmarshallerContext = new UnmarshallerContext();
            if (unmarshallerContext.ResponseDictionary == null)
            {
                unmarshallerContext.ResponseDictionary = new Dictionary<string, string>
                { { "foo", "bar" },
                { "a", "A" },
                { "b", "B" }
                };
            }
            instance.GetResponse(unmarshallerContext);
        }
    }
}
