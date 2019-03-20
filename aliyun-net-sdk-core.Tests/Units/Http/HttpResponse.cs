using System.Collections.Generic;
using System.Net;
using System.Text;

using Aliyun.Acs.Core.Http;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Http
{
    public class HttpResponseTest
    {
        private string requestUrl = "https://www.alibabacloud.com/";

        [Fact]
        public HttpResponse Instance()
        {
            HttpResponse instance = new HttpResponse();
            Assert.Null(instance.Url);

            instance = new HttpResponse(this.requestUrl);
            Assert.NotNull(instance.Url);
            Assert.Equal(this.requestUrl, instance.Url);

            return instance;
        }

        [Fact]
        public HttpResponse SetContent()
        {
            Dictionary<string, string> tmpHeaders = new Dictionary<string, string>
            { { "Content-MD5", "" },
                { "Content-Length", "" },
                { "Content-Type", "application/json; charset=UTF-8" },
                { "Accept", "accept" },
                { "Date", "Thu, 24 Jan 2019 05:16:46 GMT" }
            };
            byte[] content = Encoding.ASCII.GetBytes("someString");
            HttpResponse instance = new HttpResponse(this.requestUrl);
            instance.SetContent(content, "UTF-8", FormatType.JSON);
            Assert.Equal(content, instance.Content);
            Assert.Equal("UTF-8", instance.Encoding);
            Assert.Equal(FormatType.JSON, instance.ContentType);
            return instance;
        }

        [Fact]
        public void SetContentWithEmptyHeaders()
        {
            Dictionary<string, string> tmpHeaders = new Dictionary<string, string> { };
            byte[] content = Encoding.ASCII.GetBytes("");
            HttpResponse instance = new HttpResponse(this.requestUrl);
            instance.SetContent(content, "UTF-8", FormatType.JSON);
            Assert.Equal(content, instance.Content);
            Assert.Equal("UTF-8", instance.Encoding);
            Assert.Equal(FormatType.JSON, instance.ContentType);
        }

        [Fact]
        public void ReadContent()
        {
            HttpResponse response = this.SetContent();
            HttpWebResponse resw = new HttpWebResponse();

            Assert.Throws<System.ObjectDisposedException>(
                () => { HttpResponse.ReadContent(response, resw); }
            );
        }

        [Fact]
        public void GetResponse()
        {
            HttpResponse request = new HttpResponse(this.requestUrl);
            byte[] content = Encoding.ASCII.GetBytes("someString");
            request.SetContent(content, "UTF-8", FormatType.FORM);
            request.Method = MethodType.GET;
            HttpResponse response = HttpResponse.GetResponse(request);
            Assert.Equal("UTF-8", response.Encoding);
            Assert.Equal(MethodType.GET, response.Method);

            // When timeout!=0
            response = HttpResponse.GetResponse(request, 100000);

            // Done With No Exception
        }

        [Fact]
        public void GetWebRequest()
        {
            HttpRequest request = HttpRequestTest.SetContent();
            HttpWebRequest httpWebRequest = HttpResponse.GetWebRequest(request);
            Assert.IsType<HttpWebRequest>(httpWebRequest);
            Assert.Equal("application/octet-stream", httpWebRequest.ContentType);

            // 删除 Accept 和 Date 请求头
            request.Headers.Add("Accept", "accept");
            request.Headers.Add("Date", "Thu, 24 Jan 2019 05:16:46 GMT");

            // 覆盖POST方式
            request.Method = MethodType.POST;
            httpWebRequest = HttpResponse.GetWebRequest(request);
            Assert.IsType<HttpWebRequest>(httpWebRequest);
            Assert.Equal("application/octet-stream", httpWebRequest.ContentType);
        }

        [Fact]
        public void GetWebRequestWithTimeout()
        {
            HttpRequest request = HttpRequestTest.SetContent();
            HttpWebRequest httpWebRequest = HttpResponse.GetWebRequest(request);

            Assert.Equal(5000, httpWebRequest.Timeout);
            Assert.Equal(10000, httpWebRequest.ReadWriteTimeout);

            request.SetConnectTimeoutInMilliSeconds(1024);
            request.SetReadTimeoutInMilliSeconds(2048);
            httpWebRequest = HttpResponse.GetWebRequest(request);

            Assert.Equal(2048, httpWebRequest.ReadWriteTimeout);
            Assert.Equal(1024, httpWebRequest.Timeout);
        }

        [Fact]
        public void GetWebRequestWithIgnoreCertificate()
        {
            HttpRequest request = HttpRequestTest.SetContent();
            request.SetHttpsInsecure(true);

            HttpWebRequest httpWebRequest = HttpResponse.GetWebRequest(request);
        }

        [Fact]
        public void GetWebRequestWithProxy()
        {
            HttpRequest request = HttpRequestTest.SetContent();
            request.WebProxy = new System.Net.WebProxy();

            HttpWebRequest httpWebRequest = HttpResponse.GetWebRequest(request);
        }

        [Fact]
        public void isSuccess()
        {
            HttpResponse instance = this.SetContent();
            bool status = instance.isSuccess();
            Assert.False(status);

            instance.Status = 200;
            Assert.True(instance.isSuccess());
        }
    }
}
