using System;

using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class InstanceProfileCredentialsTest
    {
        [Fact]
        public void WillSoonExpire()
        {
            InstanceProfileCredentials instance = new InstanceProfileCredentials("a", "b", "c", DateTime.Now.ToString(), 100000);
            Assert.True(instance.WillSoonExpire());
        }

        [Fact]
        public void IsExpired()
        {
            InstanceProfileCredentials instance = new InstanceProfileCredentials("a", "b", "c", DateTime.Now.ToString(), 100000);
            Assert.True(instance.IsExpired());
        }

        [Fact]
        public void ShouldRefresh()
        {
            InstanceProfileCredentials instance = new InstanceProfileCredentials("a", "b", "c", DateTime.Now.ToString(), 100000);

            Assert.True(instance.ShouldRefresh());
        }

        [Fact]
        public void SetLastFailedRefreshTime()
        {
            InstanceProfileCredentials instance = new InstanceProfileCredentials("a", "b", "c", DateTime.Now.ToString(), 100000);
            instance.SetLastFailedRefreshTime();

            // DONE WITH NO EXCEPTION
        }
    }
}
