using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units
{
    public class CommonRpcRequestTest
    {
        [Fact]
        public void Instance()
        {
            CommonRpcRequest request = new CommonRpcRequest("productName");
            UnmarshallerContext context = new UnmarshallerContext();
            var result = request.GetResponse(context);
            Assert.Null(result); // 仅回调null，无其它逻辑
        }

        [Fact]
        public void AcsRequestUserAgentConfigTest()
        {
            CommonRpcRequest request = new CommonRpcRequest("productTest");
            request.AppendUserAgent("test", "1.2.3");
            request.AppendUserAgent("test", "1.2.4");
            request.AppendUserAgent("mock", "1.1.2");

            var userAgent = UserAgent.Resolve(request.GetSysUserAgentConfig(), null);
            var resultStr = UserAgent.GetDefaultMessage() + " test/1.2.4" + " mock/1.1.2";

            Assert.Equal(resultStr, userAgent);
        }
    }
}
