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
            Core.Auth.Credential instance;
            instance = new Core.Auth.Credential();
            instance = new Core.Auth.Credential("keyId", "secret");
            instance = new Core.Auth.Credential("keyId", "secret", "securityToken");
            instance = new Core.Auth.Credential("keyId", "secret", 24);
            instance = new Core.Auth.Credential("keyId", "secret", "securityToken", 24);
            Assert.NotNull(instance);
        }

        [Fact]
        public void SetExpiredDate()
        {
            Core.Auth.Credential instance;
            instance = new Core.Auth.Credential("keyId", "secret", -1);
            Assert.False(instance.IsExpired());

            instance = new Core.Auth.Credential("keyId", "secret", 1);
            Assert.True(instance.IsExpired());
        }

        [Fact]
        public void IsExpired()
        {
            Core.Auth.Credential instance;
            instance = new Core.Auth.Credential("keyId", "secret", 1);
            instance.ExpiredDate = DateTime.Now.AddDays(1);
            Assert.True(instance.IsExpired());

            instance.ExpiredDate = null;
            Assert.False(instance.IsExpired());

            instance.ExpiredDate = DateTime.Now.AddDays(-1);
            Assert.False(instance.IsExpired());
        }
    }
}
