using Aliyun.Acs.CCC.Model.V20170705;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;

using Xunit;

namespace Aliyun.Acs.Feature.Test.Credential
{
    public class BearerTokenTest : FeatureTestBase
    {
        [Trait("Category", "FeatureTest")]
        [Fact]
        public void BearerTokenAccessTest()
        {
            BearerTokenCredential bearerTokenCredential = new BearerTokenCredential(base.GetBearerToken());

            base.profile = DefaultProfile.GetProfile("cn-hangzhou");
            client = new Acs.Core.DefaultAcsClient(base.profile, bearerTokenCredential);

            ListPhoneNumbersRequest request = new ListPhoneNumbersRequest();

            var exception = Assert.Throws<ClientException>(() =>
            {
                var response = client.GetAcsResponse(request);
            });

            Assert.Equal("InvalidBearerToken.Inactive", exception.ErrorCode);
        }
    }
}
