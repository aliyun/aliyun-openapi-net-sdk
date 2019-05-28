/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System.Collections.Generic;
using System.Net;
using System.Text;

using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Http
{
    public class HttpRequestTest
    {
        [Fact]
        public void ConnectTimeoutTest()
        {
            var instance = new HttpRequest();
            instance.SetConnectTimeoutInMilliSeconds(1024);

            Assert.Equal(1024, instance.ConnectTimeout);

            instance.SetReadTimeoutInMilliSeconds(2048);
            Assert.Equal(2048, instance.ReadTimeout);
        }

        [Fact]
        public void GetWebProxy()
        {
            var request = new HttpRequest();
            request.WebProxy = new WebProxy();

            Assert.NotNull(request.WebProxy);
        }

        [Fact]
        public void Instance()
        {
            HttpRequest instance;

            instance = new HttpRequest();
            Assert.Null(instance.Url);
            Assert.Null(instance.Headers);

            instance = new HttpRequest("https://www.alibabacloud.com");
            Assert.Equal("https://www.alibabacloud.com", instance.Url);
            Assert.Empty(instance.Headers);

            instance = new HttpRequest("https://www.alibabacloud.com", null);
            Assert.Equal("https://www.alibabacloud.com", instance.Url);
            Assert.Null(instance.Headers);

            var tmpHeaders = new Dictionary<string, string>
            {
                {"Content-MD5", "md5"},
                {"Content-Length", "length"},
                {"Content-Type", "text/json"}
            };
            instance = new HttpRequest("https://www.alibabacloud.com", tmpHeaders);
            var context = new UnmarshallerContext();
            context.ResponseDictionary = instance.Headers;
            Assert.Equal("md5", context.StringValue("Content-MD5"));
            Assert.Equal("https://www.alibabacloud.com", instance.Url);
        }

        [Fact]
        public void RequestIgnoreCertificateTest()
        {
            var instance = new HttpRequest();

            instance.SetHttpsInsecure();
            Assert.False(instance.IgnoreCertificate);

            instance.SetHttpsInsecure(true);
            Assert.True(instance.IgnoreCertificate);
        }

        [Fact]
        public static HttpRequest SetContent()
        {
            var tmpHeaders = new Dictionary<string, string>
            {
                {"Content-MD5", "md5"},
                {"Content-Length", "length"},
                {"Content-Type", "text/json"}
            };
            var instance = new HttpRequest("https://www.alibabacloud.com", tmpHeaders);
            instance.Method = MethodType.GET;
            Assert.Equal(MethodType.GET, instance.Method);

            // when content is null
            instance.SetContent(null, "UTF-8", FormatType.JSON);
            Assert.Null(instance.Content);

            // When content is not null
            var content = Encoding.ASCII.GetBytes("someString");
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
            var instance = new HttpRequest();
            var timeout = 100;
            instance.TimeoutInMilliseconds = 100;
            Assert.Equal(timeout, instance.TimeoutInMilliseconds);
        }
    }
}
