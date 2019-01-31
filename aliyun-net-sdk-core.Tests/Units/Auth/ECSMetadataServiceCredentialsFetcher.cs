using System;

using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class ECSMetadataServiceCredentialsFetcherTest
    {
        private ECSMetadataServiceCredentialsFetcher instance;

        [Fact]
        public ECSMetadataServiceCredentialsFetcher getInstance()
        {
            if (null == this.instance)
            {
                this.instance = new ECSMetadataServiceCredentialsFetcher();
            }
            return this.instance;
        }

        [Fact]
        public void SetRoleName()
        {
            Assert.Throws<ArgumentNullException>(
                () => { this.getInstance().SetRoleName(""); }
            );

            this.getInstance().SetRoleName("roleName");
            // DONE WITH NO EXCEPTION
        }

        [Fact]
        public void WithECSMetadataServiceHost()
        {
            this.getInstance().WithECSMetadataServiceHost("host");

            // DONE WITH NO EXCEPTION
        }

        [Fact]
        public void WithConnectionTimeout()
        {
            this.getInstance().WithConnectionTimeout(100);

            // DONE WITH NO EXCEPTION
        }
    }
}
