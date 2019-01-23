using System.Collections.Generic;

using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Auth.Sts
{
    public class GetSessionAccessKeyResponseUnmarshallerTest
    {
        [Fact]
        public void GetSessionAccessKeyResponseUnmarshallTest()
        {
            UnmarshallerContext unmarshallerContext = new UnmarshallerContext();
            if (unmarshallerContext.ResponseDictionary == null)
            {
                unmarshallerContext.ResponseDictionary = new Dictionary<string, string>
                { { "GetSessionAccessKey.RequestId", "RequestId" },
                { "GetSessionAccessKey.SessionAccessKey.SessionAccessKeyId", "SessionAccessKeyId" },
                { "GetSessionAccessKey.SessionAccessKey.SessionAccessKeySecret", "SessionAccessKeySecret" },
                { "GetSessionAccessKey.SessionAccessKey.Expiration", "100" }
                };
            }

            // 无异常抛出即为通过
            GetSessionAccessKeyResponse response = GetSessionAccessKeyResponseUnmarshaller.Unmarshall(unmarshallerContext);
            Assert.Equal("RequestId", response.RequestId);
            Assert.Equal("SessionAccessKeyId", response.SessionAccesskey.SessionAccessKeyId);
            Assert.Equal("SessionAccessKeySecret", response.SessionAccesskey.SessionAccessKeySecert);
            Assert.Equal("100", response.SessionAccesskey.Expiration);
        }
    }
}
