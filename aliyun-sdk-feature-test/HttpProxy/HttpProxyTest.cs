using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Ecs.Model.V20140526;

using Xunit;

namespace Aliyun.Acs.Feature.Test.HttpProxy
{
    [Trait("Category", "FeatureTest")]
    public class HttpProxyTest : FeatureTestBase
    {
        [Fact]
        public void HttpProxy()
        {
            DescribeAccessPointsRequest request = new DescribeAccessPointsRequest();
            client.SetHttpProxy("http://localhost:8989");

            var response = client.GetAcsResponse(request);
            Assert.NotNull(response.HttpResponse.Content);

            var expectValue = "HTTP/1.1 o_o";
            string actualValue;
            response.HttpResponse.Headers.TryGetValue("Via", out actualValue);
            Assert.Equal(expectValue, actualValue);

            client.SetHttpProxy(null);
        }

        [Fact]
        public void HttpProxyWithCredential()
        {
            DescribeAccessPointsRequest request = new DescribeAccessPointsRequest();
            client.SetHttpProxy("http://username:password@localhost:8989");
            var response = client.GetAcsResponse(request);

            var expectValue = "HTTP/1.1 o_o";
            string actualValue;
            response.HttpResponse.Headers.TryGetValue("Via", out actualValue);

            Assert.Equal(expectValue, actualValue);
            Assert.NotNull(response.HttpResponse.Content);

            client.SetHttpProxy(null);
        }
    }
}
