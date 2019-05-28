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

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units
{
    public class RoaAcsRequestTest
    {
        [Fact]
        public void AddPathParameters()
        {
            var mockRoaAcsRequest = new MockRoaAcsRequest("product");
            mockRoaAcsRequest.AddPathParameters("name", "value");

            var context = new UnmarshallerContext();
            context.ResponseDictionary = mockRoaAcsRequest.PathParameters;

            Assert.Equal("value", context.StringValue("name"));
        }

        [Fact]
        public void ComposeUrl()
        {
            string endpoint, result;
            var mockRoaAcsRequest = new MockRoaAcsRequest("product");
            var queries = new Dictionary<string, string>
            {
                {"a", "A"},
                {"b", "B"}
            };

            endpoint = "endpoint.domain.com";
            result = mockRoaAcsRequest.ComposeUrl(endpoint, queries);
            // Console.WriteLine(result);
            Assert.Equal("HTTP://endpoint.domain.com?a=A&b=B", result);

            endpoint = "endpoint.domain.com?";
            result = mockRoaAcsRequest.ComposeUrl(endpoint, queries);
            // Console.WriteLine(result);
            Assert.Equal("HTTP://endpoint.domain.com?a=A&b=B", result);

            endpoint = "endpoint.domain.com?c=C";
            result = mockRoaAcsRequest.ComposeUrl(endpoint, queries);
            // Console.WriteLine(result);
            Assert.Equal("HTTP://endpoint.domain.com?c=C&a=A&b=B", result);
        }

        [Fact]
        public void Instance()
        {
            MockRoaAcsRequest mockRoaAcsRequest;

            mockRoaAcsRequest = new MockRoaAcsRequest("product");
            Assert.Equal("product", mockRoaAcsRequest.Product);

            mockRoaAcsRequest = new MockRoaAcsRequest("product", "version");
            Assert.Equal("product", mockRoaAcsRequest.Product);
            Assert.Equal("version", mockRoaAcsRequest.Version);

            mockRoaAcsRequest = new MockRoaAcsRequest("product", "version", "action");
            Assert.Equal("product", mockRoaAcsRequest.Product);
            Assert.Equal("version", mockRoaAcsRequest.Version);
            Assert.Equal("action", mockRoaAcsRequest.ActionName);

            mockRoaAcsRequest = new MockRoaAcsRequest("product", "version", "action", "locationProduct");
            Assert.Equal("product", mockRoaAcsRequest.Product);
            Assert.Equal("version", mockRoaAcsRequest.Version);
            Assert.Equal("action", mockRoaAcsRequest.ActionName);
            Assert.Equal("locationProduct", mockRoaAcsRequest.LocationProduct);

            mockRoaAcsRequest =
                new MockRoaAcsRequest("product", "version", "action", "locationProduct", "locationEndpointType");
            Assert.Equal("product", mockRoaAcsRequest.Product);
            Assert.Equal("version", mockRoaAcsRequest.Version);
            Assert.Equal("action", mockRoaAcsRequest.ActionName);
            Assert.Equal("locationProduct", mockRoaAcsRequest.LocationProduct);
            Assert.Equal("locationEndpointType", mockRoaAcsRequest.LocationEndpointType);
        }

        [Fact]
        public void SetVersion()
        {
            var mockRoaAcsRequest = new MockRoaAcsRequest("product");
            mockRoaAcsRequest.SetVersion("set_version");
            Assert.Equal("set_version", mockRoaAcsRequest.Version);
        }

        [Fact]
        public void SignRequest()
        {
            var mockRoaAcsRequest = new MockRoaAcsRequest("product");
            var signer = new HmacSHA1Signer();
            var basicSessionCredentials = new BasicSessionCredentials(
                "accessKeyId", "accessKeySecret", "sessionToken", 0
            );
            var domain = new ProductDomain();
            mockRoaAcsRequest.UriPattern = "UriPattern";
            var tmpDic = new Dictionary<string, string>
            {
                {"a", "A"},
                {"b", "B"}
            };
            mockRoaAcsRequest.BodyParameters = tmpDic;
            mockRoaAcsRequest.PathParameters = tmpDic;
            mockRoaAcsRequest.UriPattern = "UriPattern";
            Assert.Equal("UriPattern", mockRoaAcsRequest.UriPattern);

            var request = mockRoaAcsRequest.SignRequest(signer, basicSessionCredentials, FormatType.JSON, domain);
            Assert.IsType<MockRoaAcsRequest>(request);
            basicSessionCredentials = new BasicSessionCredentials(
                "accessKeyId", "accessKeySecret", null, 0
            );
            request = mockRoaAcsRequest.SignRequest(signer, basicSessionCredentials, FormatType.JSON, domain);

            mockRoaAcsRequest.BodyParameters = null;
            signer = null;
            var mockCredential = new Mock<AlibabaCloudCredentials>();
            mockCredential.Setup(foo => foo.GetAccessKeyId()).Returns("accessKeyId");
            mockCredential.Setup(foo => foo.GetAccessKeySecret()).Returns("accessKeySecret");
            var credential = mockCredential.Object;
            mockRoaAcsRequest.SignRequest(signer, credential, FormatType.JSON, domain);

            signer = new HmacSHA1Signer();
            mockRoaAcsRequest.SignRequest(signer, credential, FormatType.JSON, domain);

            // Test Bearertoken SignRequest with Rpc
            mockRoaAcsRequest.BodyParameters = null;
            var bearerTokenSigner = new BearerTokenSigner();
            var bearerTokenCredential = new BearerTokenCredential("FakeBearerToken");
            mockRoaAcsRequest.SignRequest(bearerTokenSigner, bearerTokenCredential, FormatType.JSON, domain);
        }
    }

    public sealed class MockRoaAcsRequest : RoaAcsRequest<CommonResponse>
    {
        public MockRoaAcsRequest(string product) : base(product)
        {
        }

        public MockRoaAcsRequest(string product, string version) : base(product, version)
        {
        }

        public MockRoaAcsRequest(string product, string version, string action) : base(product, version, action)
        {
        }

        public MockRoaAcsRequest(string product, string version, string action, string locationProduct) : base(product,
            version, action, locationProduct)
        {
        }

        public MockRoaAcsRequest(string product, string version, string action, string locationProduct,
            string locationEndpointType) : base(product, version, action, locationProduct, locationEndpointType)
        {
        }

        public override CommonResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            var request = new CommonResponse();
            return request;
        }
    }
}
