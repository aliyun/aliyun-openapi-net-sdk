using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class InstanceProfileCredentialsProviderTest
    {

        [Fact]
        public void Instance()
        {
            InstanceProfileCredentialsProvider instance = new InstanceProfileCredentialsProvider("roleName");
        }

        [Fact]
        public void withFetcher()
        {
            InstanceProfileCredentialsProvider instance = new InstanceProfileCredentialsProvider("roleName");
            ECSMetadataServiceCredentialsFetcher fetcher = new ECSMetadataServiceCredentialsFetcher();
            instance.withFetcher(fetcher);
        }
    }
}
