using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Http
{
    public class HttpWebProxy
    {
        [Fact]
        public void GetHttpWebProxyUrl()
        {
            var httpWebProxy = new Core.Http.HttpWebProxy();
            httpWebProxy.HttpProxyUrl = "httpProxyUrl";
            httpWebProxy.HttpsProxyUrl = "httpsProxyUrl";
            httpWebProxy.NoProxyUrlList = "localhost,localhost:8080".Split(',');
            var actualList = "localhost,localhost:8080".Split(',');

            Assert.Equal("httpProxyUrl", httpWebProxy.HttpProxyUrl);
            Assert.Equal("httpsProxyUrl", httpWebProxy.HttpsProxyUrl);
            Assert.Equal(actualList, httpWebProxy.NoProxyUrlList);
        }
    }
}
