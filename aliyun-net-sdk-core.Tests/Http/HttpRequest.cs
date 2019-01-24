using System;
using System.Collections.Generic;
using System.Text;

using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Http
{
    public class HttpRequestTest
    {
        [Fact]
        public void Instance()
        {
            HttpRequest instance;

            instance = new HttpRequest();
            Assert.Null(instance.Url);
            Assert.Null(instance.Headers);

            instance = new HttpRequest("https://www.alibabacloud.com");
            Assert.Equal("https://www.alibabacloud.com", instance.Url);
            Assert.Empty(instance.Headers); // 会初始化为空字典，不为null

            instance = new HttpRequest("https://www.alibabacloud.com", null);
            Assert.Equal("https://www.alibabacloud.com", instance.Url);
            Assert.Null(instance.Headers); // 不会初始化为空字典，为null

            Dictionary<string, string> tmpHeaders = new Dictionary<string, string>
            { { "Content-MD5", "md5" },
                { "Content-Length", "length" },
                { "Content-Type", "text/json" }
            };
            instance = new HttpRequest("https://www.alibabacloud.com", tmpHeaders);
            UnmarshallerContext context = new UnmarshallerContext();
            context.ResponseDictionary = instance.Headers;
            Assert.Equal("md5", context.StringValue("Content-MD5"));
            Assert.Equal("https://www.alibabacloud.com", instance.Url);
        }

        [Fact]
        public static HttpRequest SetContent()
        {
            Dictionary<string, string> tmpHeaders = new Dictionary<string, string>
            { { "Content-MD5", "md5" },
                { "Content-Length", "length" },
                { "Content-Type", "text/json" }
            };
            HttpRequest instance = new HttpRequest("https://www.alibabacloud.com", tmpHeaders);
            instance.Method = MethodType.GET;
            Assert.Equal(MethodType.GET, instance.Method);

            // when content is null
            instance.SetContent(null, "UTF-8", FormatType.JSON);
            Assert.Null(instance.Content);

            // When content is not null
            byte[] content = Encoding.ASCII.GetBytes("someString");
            instance.SetContent(content, "UTF-8", FormatType.JSON);
            Assert.NotNull(instance.Content);
            Assert.Equal(content, instance.Content);

            // when formatType is null
            instance.SetContent(content, "UTF-8", null);
            Assert.NotNull(instance.Content);
            Assert.Equal(content, instance.Content);
            Assert.Equal(FormatType.JSON, instance.ContentType);

            return instance;
        }

        [Fact]
        public void TimeoutInMilliSeconds()
        {
            HttpRequest instance = new HttpRequest();
            int timeout = 100;
            instance.TimeoutInMilliSeconds = 100;
            Assert.Equal(timeout, instance.TimeoutInMilliSeconds);
        }
    }
}
