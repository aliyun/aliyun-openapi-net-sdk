using System.Text;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests
{
    public class CommonRoaRequestTest
    {
        [Fact]
        public void Instance()
        {
            CommonRoaRequest request = new CommonRoaRequest("productName");
            UnmarshallerContext context = new UnmarshallerContext();
            var result = request.GetResponse(context);
            Assert.Null(result); // 仅回调null，无其它逻辑
        }
    }
}
