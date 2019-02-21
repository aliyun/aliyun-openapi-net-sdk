using Xunit;

using Aliyun.Acs.Core.Tests.Feature;
using Aliyun.Acs.Core.Tests.Mock.Services.Ecs;

namespace Aliyun.Acs.Core.Tests.Features.UserAgent
{
    public class UserAgentTest : ProfileInitialization
    {
        [Fact]
        public void GetUserAgentConfigTest()
        {
            DescribeAccessPointsRequest request = new DescribeAccessPointsRequest();

            DescribeAccessPointsResponse response = client.GetAcsResponse(request);

            request.AppendUserAgent("test", "111");

            var resultStr = Aliyun.Acs.Core.Http.UserAgent.GetDefaultMessage() + " test/111";

            Assert.Equal("Alibaba Cloud (Microsoft Windows 10.0.17134 ) Microsoft.NETCore.App/2.2.2 Core/1.1.12.0 test/111", resultStr);
        }
    }
}
