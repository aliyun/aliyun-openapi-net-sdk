using Xunit;

using Aliyun.Acs.Core.Tests.Feature;
using Aliyun.Acs.Core.Tests.Mock.Services.Ecs;
using Aliyun.Acs.Core.Exceptions;
using System;

namespace Aliyun.Acs.Core.Tests.Features.HttpDebug
{
    public class HttpDebugTest : ProfileInitialization
    {
        [Fact]
        public void EcsHttpDebugTest()
        {
            Environment.SetEnvironmentVariable("DEBUG", "sdk");
            DescribeAccessPointsRequest request = new DescribeAccessPointsRequest();
            DescribeAccessPointsResponse response = client.GetAcsResponse(request);

            Assert.True(null != response.RequestId);
            Assert.Null(Environment.GetEnvironmentVariable("DEBUG"));
        }
    }
}
