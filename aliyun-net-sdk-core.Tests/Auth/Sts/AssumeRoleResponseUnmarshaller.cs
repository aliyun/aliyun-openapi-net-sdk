using System.Collections.Generic;
using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Transform;
using Moq;
using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Auth.Sts
{
    public class AssumeRoleResponseUnmarshallerTest
    {
        [Fact]
        public void UnmarshallTest()
        {
            var context = new UnmarshallerContext();

            if (context.ResponseDictionary == null)
            {
                context.ResponseDictionary = new Dictionary<string, string> {
                    { "foo", "bar" },
                    { "a", "A" },
                    { "b", "B" }
                };
            }

            AssumeRoleResponse assumeRoleResponse = AssumeRoleResponseUnmarshaller.Unmarshall(context);
            Assert.NotNull(assumeRoleResponse);
        }
    }
}
