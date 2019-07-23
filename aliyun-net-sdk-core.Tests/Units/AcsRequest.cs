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

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units
{
    public class AcsRequestTest
    {
        [Fact]
        public void CheckShowJsonItemName()
        {
            var mockAcsRequest = new MockAcsRequest();
            // CheckShowJsonItemName return true
            Assert.True(mockAcsRequest.CheckShowJsonItemName());
        }

        [Fact]
        public void ConcatQueryString()
        {
            var mockAcsRequest = new MockAcsRequest();

            Dictionary<string, string> tmpDic = null;

            // When parameters is null
            var result = MockAcsRequest.ConcatQueryString(tmpDic);
            Assert.Null(result);

            // when parameters is empty
            tmpDic = new Dictionary<string, string>();
            result = MockAcsRequest.ConcatQueryString(tmpDic);

            // Get the empty not null
            Assert.NotNull(result);
            Assert.Empty(result);

            // When parammters is not null
            tmpDic = new Dictionary<string, string> { { "foo", "bar" }, { "a", "A" }, { "n", null } };
            result = MockAcsRequest.ConcatQueryString(tmpDic);
            Assert.Equal("foo=bar&a=A&n", result);
        }

        [Fact]
        public void GetEndpoint()
        {
            var mockAcsRequest = new MockAcsRequest();
            Assert.Equal("", mockAcsRequest.GetProductEndpoint());

            var endpointMap = new Dictionary<string, string>();
            endpointMap.Add("cn-hangzhou", "test.cn-hangzhou.aliyuncs.com");

            mockAcsRequest.ProductEndpointMap = endpointMap;
            mockAcsRequest.ProductEndpointType = "regional";

            mockAcsRequest.RegionId = "cn-hangzhou";
            Assert.Equal("test.cn-hangzhou.aliyuncs.com", mockAcsRequest.GetProductEndpoint());

            mockAcsRequest.Product = "Test";
            mockAcsRequest.RegionId = "cn-beijing";
            Assert.Equal("test.cn-beijing.aliyuncs.com", mockAcsRequest.GetProductEndpoint());

            mockAcsRequest.ProductEndpointType = "central";
            Assert.Equal("test.aliyuncs.com", mockAcsRequest.GetProductEndpoint());

            mockAcsRequest.ProductNetwork = "vpc";
            Assert.Equal("test-vpc.aliyuncs.com", mockAcsRequest.GetProductEndpoint());

            var productEndpointMap = new Dictionary<string, string>();
            mockAcsRequest.ProductEndpointType = "test-type";
            mockAcsRequest.ProductEndpointMap = productEndpointMap;

            Assert.Empty(mockAcsRequest.GetProductEndpoint());
        }

        [Fact]
        public void SetProductDomain()
        {
            var endpoint = "test.ecs.cn-hangzhou.aliyuncs.com";
            var mockAcsRequest = new MockAcsRequest();

            mockAcsRequest.SetProductDomain();
            mockAcsRequest.SetProductDomain(endpoint);

            Assert.Equal(endpoint, mockAcsRequest.ProductDomain.DomainName);

            mockAcsRequest.ProductDomain = null;
        }

        [Fact]
        public void SetEndpoint()
        {
            var endpoint = "ecs.cn-hangzhou.aliyuncs.com";

            var mockAcsRequest = new MockAcsRequest();
            mockAcsRequest.SetEndpoint(endpoint);

            Assert.Equal(endpoint, mockAcsRequest.ProductDomain.DomainName);

            mockAcsRequest.ProductDomain = null;
        }

        [Fact]
        public void Instance()
        {
            var mockAcsRequest = new MockAcsRequest();
            Assert.IsType<MockAcsRequest>(mockAcsRequest);

            mockAcsRequest.AcceptFormat = FormatType.XML;
            Assert.Equal(FormatType.XML, mockAcsRequest.AcceptFormat);
            Assert.Equal(ProtocolType.HTTP, mockAcsRequest.Protocol);
        }

        [Fact]
        public void Parameters()
        {
            var mockAcsRequest = new MockAcsRequest();

            var tmpDic = new Dictionary<string, string> { { "foo", "bar" } };
            mockAcsRequest.QueryParameters = tmpDic;

            mockAcsRequest.DomainParameters = tmpDic;
            Assert.Equal(tmpDic, mockAcsRequest.DomainParameters);

            mockAcsRequest.BodyParameters = tmpDic;
            Assert.Equal(tmpDic, mockAcsRequest.BodyParameters);
        }

        [Fact]
        public void SignRequest()
        {
            var tmpDic = new Dictionary<string, string> { { "foo", "bar" }, { "a", "A" }, { "n", null } };

            var mockAcsRequest = new MockAcsRequest("https://www.alibabacloud.com/");
            var signer = new HmacSHA1Signer();
            var credential = new Credential("accessKeyId", "accessKeySecret", "securityToken");
            var domain = new ProductDomain();
            MockAcsRequest.ConcatQueryString(tmpDic);

            var request = mockAcsRequest.SignRequest(signer, credential, FormatType.JSON, domain);

            Assert.Equal("Instance by MockAcsRequest", request.Url);
        }

        [Fact]
        public void UserAgentConfigTest()
        {
            var mockAcsRequest = new MockAcsRequest();
            mockAcsRequest.AppendUserAgent("test", "1.2.3");
            mockAcsRequest.AppendUserAgent("test", "1.2.4");
            mockAcsRequest.AppendUserAgent("mock", "1.1.2");

            var userAgent = UserAgent.Resolve(mockAcsRequest.GetSysUserAgentConfig(), null);
            var resultStr = UserAgent.GetDefaultMessage() + " test/1.2.4" + " mock/1.1.2";

            Assert.Equal(resultStr, userAgent);
        }
    }

    public sealed class MockAcsRequest : AcsRequest<CommonRequest>
    {
        public MockAcsRequest(string urlStr = null) : base(urlStr) { }

        public override HttpRequest SignRequest(Signer signer, AlibabaCloudCredentials credentials,
            FormatType? format, ProductDomain domain)
        {
            var httpRequest = new HttpRequest();
            httpRequest.Url = "Instance by MockAcsRequest";
            return httpRequest;
        }

        public override string ComposeUrl(string endpoint, Dictionary<string, string> queries)
        {
            return "";
        }

        public override CommonRequest GetResponse(UnmarshallerContext unmarshallerContext)
        {
            var t = new CommonRequest();
            return t;
        }
    }
}
