using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Transform
{
    public class AcsErrorUnmarshallerTest
    {
        [Fact]
        public void Unmarshall()
        {
            UnmarshallerContext unmarshallerContext = new UnmarshallerContext();
            if (unmarshallerContext.ResponseDictionary == null)
            {
                unmarshallerContext.ResponseDictionary = new Dictionary<string, string>
                { { "Error.RequestId", "RequestId" },
                { "Error.Code", "ErrorCode" },
                { "Error.Message", "ErrorMessage" }
                };
            }
            AcsError error = AcsErrorUnmarshaller.Unmarshall(unmarshallerContext);

            Assert.Equal("ErrorCode", error.ErrorCode);
            Assert.Equal("ErrorMessage", error.ErrorMessage);
            Assert.Equal("RequestId", error.RequestId);
        }
    }
}
