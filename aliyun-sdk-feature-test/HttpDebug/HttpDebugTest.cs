using System;

using Aliyun.Acs.Ecs.Model.V20140526;

using Xunit;

namespace Aliyun.Acs.Feature.Test.HttpDebug
{
    public class HttpDebugTest : FeatureTestBase
    {
        [Trait("Category", "FeatureTest")]
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
