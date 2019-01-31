using System;

using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class CredentialTest
    {
        [Fact]
        public void Instance()
        {
            Credential instance;
            instance = new Credential();
            instance = new Credential("keyId", "secret");
            instance = new Credential("keyId", "secret", "securityToken");
            instance = new Credential("keyId", "secret", 24);
            instance = new Credential("keyId", "secret", "securityToken", 24);
            Assert.NotNull(instance);
        }

        [Fact]
        public void SetExpiredDate()
        {
            Credential instance;
            instance = new Credential("keyId", "secret", -1);
            Assert.False(instance.IsExpired());

            instance = new Credential("keyId", "secret", 1);
            Assert.True(instance.IsExpired());
        }

        [Fact]
        public void IsExpired()
        {
            Credential instance;
            instance = new Credential("keyId", "secret", 1);
            instance.ExpiredDate = DateTime.Now.AddDays(1);
            Assert.True(instance.IsExpired());
        }
    }
}
