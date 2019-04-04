using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Profile;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth.Provider
{
    public class RsaKeyPairCredentialProvider
    {
        [Fact]
        public void RsaKeyPairCredentialProviderTest()
        {
            DefaultProfile.ClearDefaultProfile();

            var mockRsaPairCredential = new Mock<KeyPairCredentials>("ak", "aks");
            var rsaPairCredential = mockRsaPairCredential.Object;

            var profile = DefaultProfile.GetProfile();

            var instance = new Core.Auth.Provider.RsaKeyPairCredentialProvider(rsaPairCredential, profile);
            Assert.NotNull(instance);
        }

        [Fact]
        public void WithDurationSecondsTest()
        {
            DefaultProfile.ClearDefaultProfile();

            long seconds = 100;
            var mockRsaPairCredential = new Mock<KeyPairCredentials>("ak", "aks");
            var rsaPairCredential = mockRsaPairCredential.Object;
            var profile = DefaultProfile.GetProfile();

            var instance = new Core.Auth.Provider.RsaKeyPairCredentialProvider(rsaPairCredential, profile);

            instance.WithDurationSeconds(seconds);
        }

        [Fact]
        public void WithStsClient()
        {
            DefaultProfile.ClearDefaultProfile();

            var profile = DefaultProfile.GetProfile("cn-hangzhou");
            var mockClient = new Mock<IAcsClient>();
            var client = mockClient.Object;

            var mockRsaPairCredential = new Mock<KeyPairCredentials>("ak", "aks");
            var rsaPairCredential = mockRsaPairCredential.Object;

            var instance = new Core.Auth.Provider.RsaKeyPairCredentialProvider(rsaPairCredential, profile);
            instance.WithSTSClient(client);
        }

        [Fact]
        public void GetCredentials()
        {
            DefaultProfile.ClearDefaultProfile();

            var mockRsaPairCredential = new Mock<KeyPairCredentials>("publicKeyId", "privateKeyFile");
            var rsaPairCredential = mockRsaPairCredential.Object;

            var response = new GetSessionAccessKeyResponse();
            response.SessionAccesskey = new GetSessionAccessKeyResponse.GetSessionAccessKey_SessionAccesskey();
            response.SessionAccesskey.SessionAccessKeyId = "ak";
            response.SessionAccesskey.SessionAccessKeySecert = "aks";

            var mockClient = new Mock<IAcsClient>();
            mockClient.Setup(x => x.GetAcsResponse(It.IsAny<AcsRequest<GetSessionAccessKeyResponse>>())).Returns(response);
            var client = mockClient.Object;

            var instance = new Core.Auth.Provider.RsaKeyPairCredentialProvider(rsaPairCredential, client);

            Assert.NotNull(instance.GetCredentials());
        }
    }
}
