using System.Collections.Generic;

using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth.Sts
{
    public class AssumeRoleRequestTest
    {
        [Fact]
        public void PolicyTest()
        {
            AssumeRoleRequest assumeRoleRequest = new AssumeRoleRequest();
            string source = "foo";
            assumeRoleRequest.Policy = source;
            Assert.Equal(source, assumeRoleRequest.Policy);
        }

        [Fact]
        public void DurationSecondsTest()
        {
            AssumeRoleRequest assumeRoleRequest = new AssumeRoleRequest();
            long source = 10000000000;
            assumeRoleRequest.DurationSeconds = source;
            Assert.Equal(source, assumeRoleRequest.DurationSeconds);
        }

        [Fact]
        public void RoleArnTest()
        {
            AssumeRoleRequest assumeRoleRequest = new AssumeRoleRequest();
            string source = "foo";
            assumeRoleRequest.RoleArn = source;
            Assert.Equal(source, assumeRoleRequest.RoleArn);
        }

        [Fact]
        public void RoleSessionNameTest()
        {
            AssumeRoleRequest assumeRoleRequest = new AssumeRoleRequest();
            string source = "foo";
            assumeRoleRequest.RoleSessionName = source;
            Assert.Equal(source, assumeRoleRequest.RoleSessionName);
        }

        [Fact]
        public void GetResponseTest()
        {
            AssumeRoleRequest assumeRoleRequest = new AssumeRoleRequest();
            UnmarshallerContext unmarshallerContext = new UnmarshallerContext();
            if (unmarshallerContext.ResponseDictionary == null)
            {
                unmarshallerContext.ResponseDictionary = new Dictionary<string, string>
                { { "foo", "bar" },
                { "a", "A" },
                { "b", "B" }
                };
            }
            assumeRoleRequest.GetResponse(unmarshallerContext);
        }
    }
}
