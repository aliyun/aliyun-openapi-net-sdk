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
                { { "foo", "bar" },
                { "a", "A" },
                { "b", "B" }
                };
            }

            GetSessionAccessKeyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
