using System;

using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Tests.Features;
using Aliyun.Acs.Ecs.Model.V20140526;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Features.HttpDebug
{
    public class HttpDebugTest : ProfileInitialization
    {
        [Fact]
        public void EcsHttpDebugTest()
        {
            Environment.SetEnvironmentVariable("DEBUG", "sdk");
            DescribeRegionsRequest request = new DescribeRegionsRequest();
            DescribeRegionsResponse response = client.GetAcsResponse(request);

            Assert.True(null != response.RequestId);
            Assert.Null(Environment.GetEnvironmentVariable("DEBUG"));
        }
    }
}
