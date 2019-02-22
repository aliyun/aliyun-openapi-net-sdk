using Xunit;

using Aliyun.Acs.Core.Tests.Feature;
using Aliyun.Acs.Core.Tests.Mock.Services.Ecs;
using Aliyun.Acs.Core.Exceptions;

namespace Aliyun.Acs.Core.Tests.Features.UserAgent
{
    public class UserAgentTest : ProfileInitialization
    {
        [Fact]
        public void GetUserAgentConfigTest()
        {
            try
            {
                DescribeAccessPointsRequest request = new DescribeAccessPointsRequest();
                DescribeAccessPointsResponse response = client.GetAcsResponse(request);

                request.AppendUserAgent("test", "111");

                var resultStr = Aliyun.Acs.Core.Http.UserAgent.GetDefaultMessage() + " test/111";
                Assert.Equal(resultStr, Aliyun.Acs.Core.Http.UserAgent.Resolve(request.GetSysUserAgentConfig(), null));
            }
            catch (ClientException ex)
            {
                Assert.True(ex.ErrorMessage.Contains("Can not find endpoint to access"));
            }
        }
    }
}
