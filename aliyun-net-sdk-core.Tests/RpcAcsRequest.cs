using System;
using System.Collections.Generic;
using System.Text;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests
{
    public class RpcAcsRequestTest
    {
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

            mockRpcAcsRequest = new MockRpcAcsRequest("product", "version", "action", "locationProduct", "locationEndpointType");
            Assert.Equal("product", mockRpcAcsRequest.Product);
            Assert.Equal("version", mockRpcAcsRequest.Version);
            Assert.Equal("action", mockRpcAcsRequest.ActionName);
            Assert.Equal("locationProduct", mockRpcAcsRequest.LocationProduct);
            Assert.Equal("locationEndpointType", mockRpcAcsRequest.LocationEndpointType);
        }

        [Fact]
        public void GetAndSet()
        {
            MockRpcAcsRequest mockRpcAcsRequest = new MockRpcAcsRequest("product");

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
        public void SignRequest()
        {
            MockRpcAcsRequest mockRpcAcsRequest = new MockRpcAcsRequest("product");
            HmacSHA1Signer signer = new HmacSHA1Signer();
            BasicSessionCredentials basicSessionCredentials = new BasicSessionCredentials(
                "accessKeyId", "accessKeySecret", "sessionToken", 0
            );
            ProductDomain domain = new ProductDomain();

            Dictionary<string, string> tmpDic = new Dictionary<string, string>
            { { "a", "A" },
                { "b", "B" }
            };
            mockRpcAcsRequest.BodyParameters = tmpDic;
            mockRpcAcsRequest.RegionId = "cn-hangzhou";

            var request = mockRpcAcsRequest.SignRequest(signer, basicSessionCredentials, FormatType.JSON, domain);
            Assert.IsType<MockRpcAcsRequest>(request);
            basicSessionCredentials = new BasicSessionCredentials(
                "accessKeyId", "accessKeySecret", null, 0
            );

            request = mockRpcAcsRequest.SignRequest(signer, basicSessionCredentials, FormatType.JSON, domain);

            // 覆盖不同条件的执行
            mockRpcAcsRequest.BodyParameters = null;
            signer = null;
            var mockCredential = new Mock<AlibabaCloudCredentials>();
            mockCredential.Setup(foo => foo.GetAccessKeyId()).Returns("accessKeyId");
            mockCredential.Setup(foo => foo.GetAccessKeySecret()).Returns("accessKeySecret");
            AlibabaCloudCredentials credential = mockCredential.Object;
            mockRpcAcsRequest.SignRequest(signer, credential, FormatType.JSON, domain);

            signer = new HmacSHA1Signer();
            mockRpcAcsRequest.SignRequest(signer, credential, FormatType.JSON, domain);

            // Done With No Exception
        }

        [Fact]
        public void ComposeUrl()
        {
            string endpoint, result;
            MockRpcAcsRequest mockRpcAcsRequest = new MockRpcAcsRequest("product");
            Dictionary<string, string> queries = new Dictionary<string, string>
            { { "a", "A" },
                { "b", "B" }
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
    }

    public sealed class MockRpcAcsRequest : RpcAcsRequest<CommonResponse>
    {
        public MockRpcAcsRequest(String product) : base(product) { }

        public MockRpcAcsRequest(String product, String version) : base(product, version) { }

        public MockRpcAcsRequest(
            String product, String version, String action
        ) : base(
            product, version, action
        ) { }

        public MockRpcAcsRequest(
            String product, String version, String action, String locationProduct
        ) : base(product, version, action, locationProduct) { }

        public MockRpcAcsRequest(
            String product, String version, String action, String locationProduct, String locationEndpointType
        ) : base(product, version, action, locationProduct, locationEndpointType) { }

        public override CommonResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            CommonResponse request = new CommonResponse();
            return request;
        }
    }
}
