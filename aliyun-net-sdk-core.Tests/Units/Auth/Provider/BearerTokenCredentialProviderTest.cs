using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth.Provider
{
    public class BearerTokenCredentialProviderTest
    {
        [Fact]
        public void BearerTokenProvider()
        {
            var provider = new BearerTokenCredentialProvider("bearerTokenTest");
            var bearerTokenCredential = provider.GetCredentials() as BearerTokenCredential;

            Assert.NotNull(bearerTokenCredential);
            Assert.Equal("bearerTokenTest", bearerTokenCredential.GetBearerToken());
        }
    }
}
