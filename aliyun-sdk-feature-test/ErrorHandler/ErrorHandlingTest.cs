using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Ecs.Model.V20140526;

using Xunit;

namespace Aliyun.Acs.Feature.Test.ErrorHandler
{
    [Trait("Category", "FeatureTest")]
    public class ErrorHandlingTest : FeatureTestBase
    {
        [Fact]
        public void ParameterErrorTest()
        {
            CommonRequest request = new CommonRequest();
            request.Domain = "ecs-cn-hangzhou.aliyuncs.com";
            request.Version = "2014-05-26";
            request.Action = "actionError";

            var response = client.GetCommonResponse(request);
            var content = System.Text.Encoding.UTF8.GetString(response.HttpResponse.Content);

            Assert.True(content.Contains("Keyword=InvalidParameter"));
        }

        [Fact]
        public void BadFormatTypeTest()
        {
            var request = new StartInstanceRequest();
            request.InstanceId = "ttt";

            var exceptionMsg = Assert.Throws<ClientException>(() =>
            {
                var response = client.GetAcsResponse(request);
            });

            Assert.Equal("The specified InstanceId does not exist.", exceptionMsg.ErrorMessage);
            Assert.Equal("InvalidInstanceId.NotFound", exceptionMsg.ErrorCode);
        }
    }
}
