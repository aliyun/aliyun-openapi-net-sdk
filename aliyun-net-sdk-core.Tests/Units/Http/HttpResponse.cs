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

using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

using Aliyun.Acs.Core.Http;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Http
{
    public class HttpResponseTest
    {
        private readonly string requestUrl = "https://www.aliyun.com/";

        [Fact]
        public void GetResponse()
        {
            var request = new HttpResponse(requestUrl);
            var content = Encoding.ASCII.GetBytes("someString");
            request.SetContent(content, "UTF-8", FormatType.FORM);
            request.Method = MethodType.GET;
            var response = HttpResponse.GetResponse(request);
            Assert.Equal("UTF-8", response.Encoding);
            Assert.Equal(MethodType.GET, response.Method);

            // When timeout!=0
            response = HttpResponse.GetResponse(request, 30000);

            // Done With No Exception
        }

        [Fact]
        public void GetWebRequest()
        {
            var request = HttpRequestTest.SetContent();
            var httpWebRequest = HttpResponse.GetWebRequest(request);
            Assert.IsType<HttpWebRequest>(httpWebRequest);
            Assert.Equal("application/octet-stream", httpWebRequest.ContentType);

            request.Headers.Add("Accept", "accept");
            request.Headers.Add("Date", "Thu, 24 Jan 2019 05:16:46 GMT");

            request.Method = MethodType.POST;
            httpWebRequest = HttpResponse.GetWebRequest(request);
            Assert.IsType<HttpWebRequest>(httpWebRequest);
            Assert.Equal("application/octet-stream", httpWebRequest.ContentType);
        }

        [Fact]
        public void GetWebRequestWithIgnoreCertificate()
        {
            var request = HttpRequestTest.SetContent();
            request.SetHttpsInsecure(true);

            var httpWebRequest = HttpResponse.GetWebRequest(request);

            Assert.NotNull(httpWebRequest);
        }

        [Fact]
        public void GetWebRequestWithProxy()
        {
            var request = HttpRequestTest.SetContent();
            request.WebProxy = null;

            var httpWebRequest = HttpResponse.GetWebRequest(request);

            Assert.NotNull(httpWebRequest);
        }

        [Fact]
        public void GetWebRequestWithTimeout()
        {
            var request = HttpRequestTest.SetContent();

            var httpWebRequest = HttpResponse.GetWebRequest(request);

            Assert.Equal(5000, httpWebRequest.Timeout);
            Assert.Equal(10000, httpWebRequest.ReadWriteTimeout);

            request.SetConnectTimeoutInMilliSeconds(1024);
            request.SetReadTimeoutInMilliSeconds(2048);
            httpWebRequest = HttpResponse.GetWebRequest(request);

            Assert.Equal(2048, httpWebRequest.ReadWriteTimeout);
            Assert.Equal(1024, httpWebRequest.Timeout);
        }

        [Fact]
        public HttpResponse Instance()
        {
            var instance = new HttpResponse();
            Assert.Null(instance.Url);

            instance = new HttpResponse(requestUrl);
            Assert.NotNull(instance.Url);
            Assert.Equal(requestUrl, instance.Url);

            return instance;
        }

        [Fact]
        public void isSuccess()
        {
            var instance = SetContent();
            var status = instance.isSuccess();
            Assert.False(status);

            instance.Status = 200;
            Assert.True(instance.isSuccess());
        }

        [Fact]
        public void ReadContent()
        {
#if !NET45
            var response = SetContent();
            var resw = new HttpWebResponse();

            Assert.Throws<ObjectDisposedException>(
                () => { HttpResponse.ReadContent(response, resw); }
            );
#endif
        }

        [Fact]
        public HttpResponse SetContent()
        {
            var tmpHeaders = new Dictionary<string, string>
                { { "Content-MD5", "" },
                    { "Content-Length", "" },
                    { "Content-Type", "application/json; charset=UTF-8" },
                    { "Accept", "accept" },
                    { "Date", "Thu, 24 Jan 2019 05:16:46 GMT" }
                };
            var content = Encoding.ASCII.GetBytes("someString");
            var instance = new HttpResponse(requestUrl);
            instance.SetContent(content, "UTF-8", FormatType.JSON);
            Assert.Equal(content, instance.Content);
            Assert.Equal("UTF-8", instance.Encoding);
            Assert.Equal(FormatType.JSON, instance.ContentType);
            return instance;
        }

        [Fact]
        public void SetContentWithEmptyHeaders()
        {
            var tmpHeaders = new Dictionary<string, string>();
            var content = Encoding.ASCII.GetBytes("");
            var instance = new HttpResponse(requestUrl);
            instance.SetContent(content, "UTF-8", FormatType.JSON);
            Assert.Equal(content, instance.Content);
            Assert.Equal("UTF-8", instance.Encoding);
            Assert.Equal(FormatType.JSON, instance.ContentType);
        }
    }
}
