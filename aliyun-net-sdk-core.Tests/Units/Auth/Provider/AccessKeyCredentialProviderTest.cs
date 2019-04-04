using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth.Provider
{
    public class AccessKeyCredentialProviderTest
    {
        [Fact]
        public void AccessKeyCredentialProvider()
        {
            var accessKeyCredentialProvier = new AccessKeyCredentialProvider("accessKeyId", "accessKeySecret");
            
            Assert.NotNull(accessKeyCredentialProvier);
            Assert.Equal("accessKeyId", accessKeyCredentialProvier.GetCredentials().GetAccessKeyId());
        }
    }
}
