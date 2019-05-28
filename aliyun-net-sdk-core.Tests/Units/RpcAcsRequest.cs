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
    public class RpcAcsRequestTest
    {
        [Fact]
        public void ComposeUrl()
        {
            string endpoint, result;
            var mockRpcAcsRequest = new MockRpcAcsRequest("product");
            var queries = new Dictionary<string, string>
            {
                {"a", "A"},
                {"b", "B"}
            };

            endpoint = "endpoint.domain.com";
            result = mockRpcAcsRequest.ComposeUrl(endpoint, queries);
            // Console.WriteLine(result);
            Assert.Equal("http://endpoint.domain.com/?a=A&b=B", result);

            endpoint = "endpoint.domain.com?";
            result = mockRpcAcsRequest.ComposeUrl(endpoint, queries);
            // Console.WriteLine(result);
            Assert.Equal("http://endpoint.domain.com?a=A&b=B", result);
        }

        [Fact]
        public void GetAndSet()
        {
            var mockRpcAcsRequest = new MockRpcAcsRequest("product");

            // ActionName
            mockRpcAcsRequest.ActionName = "ActionName";
            Assert.Equal("ActionName", mockRpcAcsRequest.ActionName);

            // Version
            mockRpcAcsRequest.Version = "Version";
            Assert.Equal("Version", mockRpcAcsRequest.Version);

            // AcceptFormat
            mockRpcAcsRequest.AcceptFormat = FormatType.JSON;
            Assert.Equal(FormatType.JSON, mockRpcAcsRequest.AcceptFormat);
        }

        [Fact]
        public void Instance()
        {
            MockRpcAcsRequest mockRpcAcsRequest;

            mockRpcAcsRequest = new MockRpcAcsRequest("product");
            Assert.Equal("product", mockRpcAcsRequest.Product);

            mockRpcAcsRequest = new MockRpcAcsRequest("product", "version");
            Assert.Equal("product", mockRpcAcsRequest.Product);
            Assert.Equal("version", mockRpcAcsRequest.Version);

            mockRpcAcsRequest = new MockRpcAcsRequest("product", "version", "action");
            Assert.Equal("product", mockRpcAcsRequest.Product);
            Assert.Equal("version", mockRpcAcsRequest.Version);
            Assert.Equal("action", mockRpcAcsRequest.ActionName);

            mockRpcAcsRequest = new MockRpcAcsRequest("product", "version", "action", "locationProduct");
            Assert.Equal("product", mockRpcAcsRequest.Product);
            Assert.Equal("version", mockRpcAcsRequest.Version);
            Assert.Equal("action", mockRpcAcsRequest.ActionName);
            Assert.Equal("locationProduct", mockRpcAcsRequest.LocationProduct);

            mockRpcAcsRequest =
                new MockRpcAcsRequest("product", "version", "action", "locationProduct", "locationEndpointType");
            Assert.Equal("product", mockRpcAcsRequest.Product);
            Assert.Equal("version", mockRpcAcsRequest.Version);
            Assert.Equal("action", mockRpcAcsRequest.ActionName);
            Assert.Equal("locationProduct", mockRpcAcsRequest.LocationProduct);
            Assert.Equal("locationEndpointType", mockRpcAcsRequest.LocationEndpointType);
        }

        [Fact]
        public void SignRequest()
        {
            var mockRpcAcsRequest = new MockRpcAcsRequest("product");
            var signer = new HmacSHA1Signer();
            var basicSessionCredentials = new BasicSessionCredentials(
                "accessKeyId", "accessKeySecret", "sessionToken", 0
            );
            var domain = new ProductDomain();

            var tmpDic = new Dictionary<string, string>
            {
                {"a", "A"},
                {"b", "B"}
            };
            mockRpcAcsRequest.BodyParameters = tmpDic;
            mockRpcAcsRequest.RegionId = "cn-hangzhou";

            var request = mockRpcAcsRequest.SignRequest(signer, basicSessionCredentials, FormatType.JSON, domain);
            Assert.IsType<MockRpcAcsRequest>(request);
            basicSessionCredentials = new BasicSessionCredentials(
                "accessKeyId", "accessKeySecret", null, 0
            );

            request = mockRpcAcsRequest.SignRequest(signer, basicSessionCredentials, FormatType.JSON, domain);

            mockRpcAcsRequest.BodyParameters = null;
            signer = null;
            var mockCredential = new Mock<AlibabaCloudCredentials>();
            mockCredential.Setup(foo => foo.GetAccessKeyId()).Returns("accessKeyId");
            mockCredential.Setup(foo => foo.GetAccessKeySecret()).Returns("accessKeySecret");
            var credential = mockCredential.Object;
            mockRpcAcsRequest.SignRequest(signer, credential, FormatType.JSON, domain);

            signer = new HmacSHA1Signer();
            mockRpcAcsRequest.SignRequest(signer, credential, FormatType.JSON, domain);

            // Test BearerToken SignRequest with Rpc
            mockRpcAcsRequest.BodyParameters = null;
            var bearerTokenSigner = new BearerTokenSigner();
            var bearerTokenCredential = new BearerTokenCredential("FakeBearerToken");

            mockRpcAcsRequest.SignRequest(bearerTokenSigner, bearerTokenCredential, FormatType.JSON, domain);
        }
    }

    public sealed class MockRpcAcsRequest : RpcAcsRequest<CommonResponse>
    {
        public MockRpcAcsRequest(string product) : base(product)
        {
        }

        public MockRpcAcsRequest(string product, string version) : base(product, version)
        {
        }

        public MockRpcAcsRequest(
            string product, string version, string action
        ) : base(
            product, version, action
        )
        {
        }

        public MockRpcAcsRequest(
            string product, string version, string action, string locationProduct
        ) : base(product, version, action, locationProduct)
        {
        }

        public MockRpcAcsRequest(
            string product, string version, string action, string locationProduct, string locationEndpointType
        ) : base(product, version, action, locationProduct, locationEndpointType)
        {
        }

        public override CommonResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            var request = new CommonResponse();
            return request;
        }
    }
}
