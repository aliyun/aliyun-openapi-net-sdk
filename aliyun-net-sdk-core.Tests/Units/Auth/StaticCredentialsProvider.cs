using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Profile;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class StaticCredentialsProviderTest
    {
        [Fact]
        public void AlibabaCloudCredentialsInstance()
        {
            var mock = new Mock<AlibabaCloudCredentials>();

            AlibabaCloudCredentials credentials = mock.Object;
            StaticCredentialsProvider instance = new StaticCredentialsProvider(credentials); // 无回调

            // DONE WITH NO EXCEPTION
        }

        [Fact]
        public void IClientProfileInstance()
        {
            // when securityToken is not null
            var mock = new Mock<IClientProfile>();
            Core.Auth.Credential credential = new Core.Auth.Credential("accessKeyId", "accessKeySecret", "securityToken");
            mock.Setup(foo => foo.GetCredential()).Returns(credential);
            IClientProfile profile = mock.Object;
            StaticCredentialsProvider instance = new StaticCredentialsProvider(profile);
            Assert.IsType<BasicSessionCredentials>(instance.GetCredentials());

            // when securityToken is null
            var mock2 = new Mock<IClientProfile>();
            Core.Auth.Credential credential2 = new Core.Auth.Credential("accessKeyId", "accessKeySecret");
            mock2.Setup(foo => foo.GetCredential()).Returns(credential2);
            IClientProfile profile2 = mock2.Object;
            StaticCredentialsProvider instance2 = new StaticCredentialsProvider(profile2);
            Assert.IsType<LegacyCredentials>(instance2.GetCredentials());
        }
    }
}
