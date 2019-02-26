using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Tests.Mock;
using Aliyun.Acs.Ecs.Model.V20140526;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Features.UserAgent
{
    public class UserAgentTest
    {
        private string regionId = "cn-shanghai";
        private string accessKey;
        private string accessKeySecret;

        private IClientProfile profile;
        private DefaultAcsClient client;

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void GetUserAgentConfigTest()
        {
            accessKey = ACKMock.GetAccessKeyId();
            accessKeySecret = ACKMock.GetAccessKeySecret();

            profile = DefaultProfile.GetProfile(regionId, accessKey, accessKeySecret);
            client = new DefaultAcsClient(profile);

            var resultStr = Aliyun.Acs.Core.Http.UserAgent.GetDefaultMessage();

            DescribeAccessPointsRequest request = new DescribeAccessPointsRequest();
            DescribeAccessPointsResponse response = client.GetAcsResponse(request);

            request.AppendUserAgent("test", "111");

            resultStr += " test/111";
            var actualStr = Aliyun.Acs.Core.Http.UserAgent.Resolve(request.GetSysUserAgentConfig(), null);

            Assert.Equal(resultStr, actualStr);
        }
    }
}
