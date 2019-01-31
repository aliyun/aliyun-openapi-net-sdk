using System;
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

            mockRoaAcsRequest = new MockRoaAcsRequest("product", "version", "action", "locationProduct", "locationEndpointType");
            Assert.Equal("product", mockRoaAcsRequest.Product);
            Assert.Equal("version", mockRoaAcsRequest.Version);
            Assert.Equal("action", mockRoaAcsRequest.ActionName);
            Assert.Equal("locationProduct", mockRoaAcsRequest.LocationProduct);
            Assert.Equal("locationEndpointType", mockRoaAcsRequest.LocationEndpointType);
        }

        [Fact]
        public void SetVersion()
        {
            MockRoaAcsRequest mockRoaAcsRequest = new MockRoaAcsRequest("product");
            mockRoaAcsRequest.SetVersion("set_version");
            Assert.Equal("set_version", mockRoaAcsRequest.Version);
        }

        [Fact]
        public void ComposeUrl()
        {
            string endpoint, result;
            MockRoaAcsRequest mockRoaAcsRequest = new MockRoaAcsRequest("product");
            Dictionary<string, string> queries = new Dictionary<string, string>
            { { "a", "A" },
                { "b", "B" }
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
        public void SignRequest()
        {
            MockRoaAcsRequest mockRoaAcsRequest = new MockRoaAcsRequest("product");
            HmacSHA1Signer signer = new HmacSHA1Signer();
            BasicSessionCredentials basicSessionCredentials = new BasicSessionCredentials(
                "accessKeyId", "accessKeySecret", "sessionToken", 0
            );
            ProductDomain domain = new ProductDomain();
            mockRoaAcsRequest.UriPattern = "UriPattern";
            Dictionary<string, string> tmpDic = new Dictionary<string, string>
            { { "a", "A" },
                { "b", "B" }
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

            // 覆盖不同条件的执行
            mockRoaAcsRequest.BodyParameters = null;
            signer = null;
            var mockCredential = new Mock<AlibabaCloudCredentials>();
            mockCredential.Setup(foo => foo.GetAccessKeyId()).Returns("accessKeyId");
            mockCredential.Setup(foo => foo.GetAccessKeySecret()).Returns("accessKeySecret");
            AlibabaCloudCredentials credential = mockCredential.Object;
            mockRoaAcsRequest.SignRequest(signer, credential, FormatType.JSON, domain);

            signer = new HmacSHA1Signer();
            mockRoaAcsRequest.SignRequest(signer, credential, FormatType.JSON, domain);

            // Done With No Exception
        }

        [Fact]
        public void AddPathParameters()
        {
            MockRoaAcsRequest mockRoaAcsRequest = new MockRoaAcsRequest("product");
            mockRoaAcsRequest.AddPathParameters("name", "value");

            UnmarshallerContext context = new UnmarshallerContext();
            context.ResponseDictionary = mockRoaAcsRequest.PathParameters;

            Assert.Equal("value", context.StringValue("name"));
        }
    }
    public sealed class MockRoaAcsRequest : RoaAcsRequest<CommonResponse>
    {

        public MockRoaAcsRequest(string product) : base(product) { }

        public MockRoaAcsRequest(string product, string version) : base(product, version) { }

        public MockRoaAcsRequest(
            string product, string version, string action
        ) : base(
            product, version, action
        ) { }

        public MockRoaAcsRequest(
            String product, String version, String action, String locationProduct
        ) : base(
            product, version, action, locationProduct
        ) { }

        public MockRoaAcsRequest(
            string product, string version, string action, string locationProduct, string locationEndpointType
        ) : base(
            product, version, action, locationProduct, locationEndpointType
        ) { }

        public override CommonResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            CommonResponse request = new CommonResponse();
            return request;
        }
    }
}
