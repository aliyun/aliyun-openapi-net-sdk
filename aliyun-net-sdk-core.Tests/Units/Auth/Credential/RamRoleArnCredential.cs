using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth.Credential
{
    public class RamRoleArnCredential
    {
        [Fact]
        public void RamRoleArnCredentialGetTest()
        {
            var ramRoleArnCrendential = new Core.Auth.RamRoleArnCredential("accesskeyId", "accessKeySecret", "roleArn", "roleSessionName", "sessionToken", 100);

            Assert.Equal("roleArn", ramRoleArnCrendential.GetRoleArn());
            Assert.Equal("roleSessionName", ramRoleArnCrendential.GetRoleSessionName());
        }
    }
}
