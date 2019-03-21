using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Http
{
    public class HttpWebProxy
    {
        [Fact]
        public void GetHttpWebProxyUrl()
        {
            var httpWebProxy = new Core.Http.HttpWebProxy();
            httpWebProxy.HttpProxy = "http://localhost.com";
            httpWebProxy.HttpsProxy = "https://localohost.com";
            httpWebProxy.NoProxy = "localhost,localhost:8080";

            var actualList = "localhost,localhost:8080".Split(',');

            Assert.Equal("http://localhost.com", httpWebProxy.HttpProxy);
            Assert.Equal("https://localohost.com", httpWebProxy.HttpsProxy);
            Assert.Equal(actualList, httpWebProxy.NoProxy.Split(','));
        }
    }
}
