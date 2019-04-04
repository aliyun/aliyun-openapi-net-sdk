using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Vpc.Model.V20160428;

using Xunit;

namespace Aliyun.Acs.Feature.Test.Credential
{
    [Trait("Category", "FeatureTest")]
    public class CredentialsTest : FeatureTestBase
    {
        [Fact]
        public void SdkManageTokenTest()
        {
            if (GetRoleArn().Equals("FakeRoleArn")) return;
            DefaultProfile profile = DefaultProfile.GetProfile("cn-hangzhou", GetBasicAccessKeyId(), GetBasicAccessKeySecret());
            BasicCredentials basicCredential = new BasicCredentials(GetBasicAccessKeyId(), GetBasicAccessKeySecret());
            STSAssumeRoleSessionCredentialsProvider provider = new STSAssumeRoleSessionCredentialsProvider(basicCredential, GetRoleArn(), profile);

            DefaultAcsClient client = new DefaultAcsClient(profile, provider);

            var request = new DescribeAccessPointsRequest();
            var response = client.GetAcsResponse(request);

            Assert.NotNull(response);
            Assert.True(0 <= response.TotalCount);
        }

        [Fact]
        public void STSAssumeRoleCredentialWithPolicyTest()
        {
            if (GetRoleArn().Equals("FakeRoleArn")) return;
            var profile = DefaultProfile.GetProfile("cn-hangzhou", GetBasicAccessKeyId(), GetBasicAccessKeySecret());
            var basicCredential = new BasicCredentials(GetBasicAccessKeyId(), GetBasicAccessKeySecret());
            var policy = "{ \"Version\": \"1\",\"Statement\": [{\"Effect\": \"Deny\",\"Action\": \"vpc:Create*\",\"Resource\": \"acs:vpc:cn-hangzhou:*:*\"}]}";
            STSAssumeRoleSessionCredentialsProvider provider = new STSAssumeRoleSessionCredentialsProvider(basicCredential, GetRoleArn(), policy, profile);

            DefaultAcsClient client = new DefaultAcsClient(profile, provider);
            var request = new CreateVpcRequest();

            CreateVpcResponse response;

            var exception = Assert.Throws<ClientException>(() =>
            {
                response = client.GetAcsResponse(request);
            });

            Assert.Equal("Forbidden.RAM : User not authorized to operate on the specified resource, or this API doesn't support RAM.", exception.Message);
        }
    }
}
