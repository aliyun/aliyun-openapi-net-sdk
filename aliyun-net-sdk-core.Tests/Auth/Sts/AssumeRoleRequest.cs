using System.Text;
using System.Web;
using Xunit;
using Aliyun.Acs.Core.Auth.Sts;

namespace Aliyun.Acs.Core.UnitTests.Auth.Sts
{
    public class AssumeRoleRequest_Test
    {
        [Fact]
        public void AssumeRoleRequest()
        {
            AssumeRoleRequest assumeRoleRequest = new AssumeRoleRequest();
            string source = "foo";
            assumeRoleRequest.Policy = source;
            Assert.Equal(source, assumeRoleRequest.Policy);
        }
    }
}
