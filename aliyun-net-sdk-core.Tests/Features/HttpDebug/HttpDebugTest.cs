using System;

using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Tests.Features;
using Aliyun.Acs.Core.Tests.Mock;
using Aliyun.Acs.Ecs.Model.V20140526;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Features.HttpDebug
{
    public class HttpDebugTest
    {
        private string regionId = "cn-shanghai";
        private string accessKey;
        private string accessKeySecret;

        private IClientProfile profile;
        private DefaultAcsClient client;

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void EcsHttpDebugTest()
        {

            accessKey = ACKMock.GetAccessKeyId();
            accessKeySecret = ACKMock.GetAccessKeySecret();

            profile = DefaultProfile.GetProfile(regionId, accessKey, accessKeySecret);
            client = new DefaultAcsClient(profile);

            Environment.SetEnvironmentVariable("DEBUG", "sdk");

            DescribeRegionsRequest request = new DescribeRegionsRequest();
            Console.Write("Test => ");
            DescribeRegionsResponse response = client.GetAcsResponse(request);

            Assert.True(null != response.RequestId);
            Assert.Null(Environment.GetEnvironmentVariable("DEBUG"));
        }
    }
}
