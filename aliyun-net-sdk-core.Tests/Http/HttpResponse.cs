using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;
using System.Text;

using Aliyun.Acs.Core.Http;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Http
{
    public class HttpResponseTest
    {
        private string requestUrl = "https://www.easy-mock.com/mock/5c494b3370e39f5d6f283390/example/";

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
                { "Content-Type", "application/json" },
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
            HttpRequest request = new HttpRequest(this.requestUrl);
            byte[] content = Encoding.ASCII.GetBytes("someString");
            request.SetContent(content, "UTF-8", FormatType.JSON);
            request.Method = MethodType.GET;
            // HttpResponse.GetResponse(request);
        }

        [Fact]
        public void GetWebRequest()
        {
            HttpRequest request = HttpRequestTest.SetContent();
            HttpWebRequest httpWebRequest = HttpResponse.GetWebRequest(request);
            Assert.IsType<HttpWebRequest>(httpWebRequest);
            Assert.Equal("application/octet-stream", httpWebRequest.ContentType);
        }

        [Fact]
        public void isSuccess()
        {
            bool status = this.Instance().isSuccess();
            Assert.IsType<bool>(status);
        }
    }
}
