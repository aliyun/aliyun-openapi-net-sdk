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
    }
}
