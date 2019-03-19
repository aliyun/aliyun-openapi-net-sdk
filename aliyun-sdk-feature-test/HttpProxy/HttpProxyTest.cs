using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Ecs.Model.V20140526;

using Xunit;

namespace Aliyun.Acs.Feature.Test.HttpProxy
{
    public class HttpProxyTest : FeatureTestBase
    {
        [Fact]
        public void HttpProxy()
        {
            DescribeAccessPointsRequest request = new DescribeAccessPointsRequest();
            client.SetProxy(ProxyType.HTTP_PROXY, "http://localhost:8989");

            var response = client.GetAcsResponse(request);

            Assert.NotNull(response.HttpResponse.Content);
        }
    }
}
