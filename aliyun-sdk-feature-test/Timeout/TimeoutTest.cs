using System;
using System.Net;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Ecs.Model.V20140526;

using Xunit;

namespace Aliyun.Acs.Feature.Test.Timeout
{
    [Trait("Category", "FeatureTest")]
    public class TimeoutTest : FeatureTestBase
    {
        [Fact]
        public void TestConnectTimeoutWithException()
        {
            HttpRequest request = new HttpRequest("https://alibaba.great");
            request.Method = MethodType.GET;
            request.SetConnectTimeoutInMilliSeconds(1);

            var exception = Assert.Throws<ClientException>(() =>
            {
                HttpResponse response = HttpResponse.GetResponse(request);
            });

            Assert.NotNull(exception.Message);
        }

        [Fact]
        public void TestEcsConnectTimeoutWithException()
        {
            DescribeAccessPointsRequest request = new DescribeAccessPointsRequest();
            request.SetConnectTimeoutInMilliSeconds(1);

            var exception = Assert.Throws<ClientException>(() =>
            {
                DescribeAccessPointsResponse response = client.GetAcsResponse(request);
            });

            Assert.NotNull(exception.Message);
        }

        [Fact]
        public void TestTimeoutPriority()
        {
            DescribeAccessPointsRequest request = new DescribeAccessPointsRequest();
            request.SetConnectTimeoutInMilliSeconds(8000);
            client.SetConnectTimeoutInMilliSeconds(1);

            DescribeAccessPointsResponse response = client.GetAcsResponse(request);

            client.SetConnectTimeoutInMilliSeconds(5000);
            Assert.True(0 <= response.AccessPointSet.Count);
        }
    }
}
