using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Ecs.Model.V20140526;

using Xunit;

namespace Aliyun.Acs.Feature.Test.Credential
{
    [Trait("Category", "FeatureTest")]
    public class CredentialsTest : FeatureTestBase
    {
        [Fact]
        public void SdkManageTokenTest()
        {
            if (GetRoleArn().Equals("FakeRoleArn"))
                return;
            DefaultProfile profile = DefaultProfile.GetProfile("cn-hangzhou", GetBasicAccessKeyId(), GetBasicAccessKeySecret());
            BasicCredentials basicCredential = new BasicCredentials(GetBasicAccessKeyId(), GetBasicAccessKeySecret());
            STSAssumeRoleSessionCredentialsProvider provider = new STSAssumeRoleSessionCredentialsProvider(basicCredential, GetRoleArn(), profile);

            DefaultAcsClient client = new DefaultAcsClient(profile, provider);

            DescribeInstancesRequest request = new DescribeInstancesRequest();
            DescribeInstancesResponse response = client.GetAcsResponse(request);

            Assert.NotNull(response);
            Assert.True(0 <= response.TotalCount);
        }
    }
}
