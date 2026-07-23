using System;
using Aliyun.Acs.Core.Auth.Provider;
using Aliyun.Acs.Core.Exceptions;
using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class URLCredentialProviderTest
    {
        [Fact]
        public void TestConstructor()
        {
            URLCredentialProvider provider;
            var ex = Assert.Throws<ArgumentNullException>(() =>
                provider = new URLCredentialProvider.Builder().CredentialsURI("").Build());
            Assert.Contains("Credential URI or environment variable ALIBABA_CLOUD_CREDENTIALS_URI cannot be empty.",
                ex.Message);
            var ex1 = Assert.Throws<ClientException>(() =>
                provider = new URLCredentialProvider.Builder().CredentialsURI("url").Build());
            Assert.Contains("Credential URI is not valid.", ex1.Message);
            provider = new URLCredentialProvider.Builder().CredentialsURI("http://test").Build();
            provider = new URLCredentialProvider.Builder().CredentialsURI(new Uri("http://test")).Build();
        }

        [Fact]
        public void TestGetCredentials()
        {
            var provider = new URLCredentialProvider.Builder()
                .CredentialsURI("http://10.10.10.10")
                .ConnectTimeout(2000)
                .ReadTimeout(2000)
                .Build();

            var ex = Assert.Throws<ClientException>(() => { provider.GetCredentials(); });
            Assert.StartsWith("Failed to connect Server: http://10.10.10.10", ex.Message);
        }
    }
}
