using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class BearerTokenCredentialTest
    {
        [Fact]
        public void BearerTokenTest()
        {
            var bearerToken = new BearerTokenCredential("bearerToken");

            Assert.NotNull(bearerToken);

            Assert.Null(bearerToken.GetAccessKeyId());
            Assert.Null(bearerToken.GetAccessKeySecret());
            Assert.Equal("bearerToken", bearerToken.GetBearerToken());
        }
    }
}
