using Aliyun.Acs.CCC.Model.V20170705;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;

using Xunit;

namespace Aliyun.Acs.Feature.Test.Credential
{
    [Trait("Category", "FeatureTest")]
    public class BearerTokenTest : FeatureTestBase
    {
        [Fact]
        public void BearerTokenAccessTest()
        {
            BearerTokenCredentialProvider provider = new BearerTokenCredentialProvider(GetBearerToken());

            base.profile = DefaultProfile.GetProfile("cn-hangzhou");
            client = new Acs.Core.DefaultAcsClient(base.profile, provider);

            ListPhoneNumbersRequest request = new ListPhoneNumbersRequest();

            var exception = Assert.Throws<ClientException>(() =>
            {
                var response = client.GetAcsResponse(request);
            });

            Assert.Equal("InvalidBearerToken.Inactive", exception.ErrorCode);
        }
    }
}
