using System;
using System.Collections.Generic;
using System.Text;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Transform;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests
{
    public class DefaultAcsClientTest
    {
        private static string AKID = "accessKeyId";

        private static string AKSE = "accessKeySecret";

        [Fact]
        public void Instance()
        {
            IClientProfile profile;
            DefaultAcsClient instance;

            instance = new DefaultAcsClient();

            profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            instance = new DefaultAcsClient(profile);
            Assert.Equal("cn-hangzhou", profile.GetRegionId());
            Assert.Equal(AKID, profile.GetCredential().AccessKeyId);
            Assert.Equal(AKSE, profile.GetCredential().AccessSecret);

            var mock = new Mock<AlibabaCloudCredentials>();
            AlibabaCloudCredentials alibabaCloudCredentials = mock.Object;
            instance = new DefaultAcsClient(profile, mock.Object);
            Assert.Equal("cn-hangzhou", profile.GetRegionId());
            Assert.Equal(AKID, profile.GetCredential().AccessKeyId);
            Assert.Equal(AKSE, profile.GetCredential().AccessSecret);

            var mockProvider = new Mock<AlibabaCloudCredentialsProvider>();
            AlibabaCloudCredentialsProvider alibabaCloudCredentialsProvider = mockProvider.Object;
            instance = new DefaultAcsClient(profile, mock.Object);
            Assert.Equal("cn-hangzhou", profile.GetRegionId());
            Assert.Equal(AKID, profile.GetCredential().AccessKeyId);
            Assert.Equal(AKSE, profile.GetCredential().AccessSecret);
        }

        public DefaultAcsClient MockDefaultAcsClient(
            int status = 200,
            string code = "ThisIsCode",
            string message = "ThisIsMessage",
            string requestId = "ThisIsRequestId"
        )
        {
            // Mock RegionIds
            ISet<String> regionIds = new HashSet<String>();
            regionIds.Add("cn-hangzhou");

            // Mock productDomains
            List<ProductDomain> productDomains = new List<ProductDomain>() { };
            ProductDomain productDomain = new ProductDomain("Ess", "ess.aliyuncs.com");
            productDomains.Add(productDomain);

            // Mock endpoint
            Endpoint endpoint = new Endpoint("cn-hangzhou", regionIds, productDomains);

            // Mock endpoints
            List<Endpoint> endpoints = new List<Endpoint>() { };
            endpoints.Add(endpoint);

            // Mock response
            HttpResponse response = new HttpResponse();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Code\":\"" + code + "\",\"Message\":\"" + message + "\",\"RequestId\":\"" + requestId + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;

            // Mock credential
            Credential credential = new Credential(AKID, AKSE);

            // Mock Profile
            var mockProfile = new Mock<IClientProfile>();
            mockProfile.Setup(foo => foo.GetCredential()).Returns(credential);
            IClientProfile profile = mockProfile.Object;

            // Mock DefaultAcsClient
            var mockDefaultAcsClient = new Mock<DefaultAcsClient>(profile);
            mockDefaultAcsClient.Setup(foo => foo.DoAction(
                It.IsAny<AcsRequest<AcsResponse>>(),
                It.IsAny<bool>(),
                It.IsAny<int>(),
                It.IsAny<string>(),
                It.IsAny<AlibabaCloudCredentials>(),
                It.IsAny<Signer>(),
                It.IsAny<FormatType>(),
                It.IsAny<List<Endpoint>>()
            )).Returns(response);
            DefaultAcsClient instance = mockDefaultAcsClient.Object;

            return instance;
        }

        [Fact]
        public void GetAndSet()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            DefaultAcsClient instance = new DefaultAcsClient(profile);

            // MaxRetryNumber
            instance.MaxRetryNumber = 3;
            Assert.Equal(3, instance.MaxRetryNumber);

            // AutoRetry
            instance.AutoRetry = true;
            Assert.True(instance.AutoRetry);
        }

        [Fact]
        public void GetAcsResponse1()
        {
            DefaultAcsClient instance = this.MockDefaultAcsClient();

            // Mock AcsResquest
            MockAcsRequestForDefaultAcsClient request = new MockAcsRequestForDefaultAcsClient();
            request.RegionId = "cn-hangzhou";
            request.Product = "Ess";
            request.LocationProduct = "ess";
            request.LocationEndpointType = "openAPI";

            var result = instance.GetAcsResponse<AcsResponse>(request);
            Assert.IsType<CommonResponse>(result);

            var mockIClientProfile = new Mock<IClientProfile>();
            IClientProfile iClientProfile = mockIClientProfile.Object;
            result = instance.GetAcsResponse<AcsResponse>(request, iClientProfile);
            Assert.IsType<CommonResponse>(result);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetAcsResponse2()
        {
            DefaultAcsClient instance = this.MockDefaultAcsClient();

            // Mock AcsResquest
            MockAcsRequestForDefaultAcsClient request = new MockAcsRequestForDefaultAcsClient();
            request.RegionId = "cn-hangzhou";
            request.Product = "Ess";
            request.LocationProduct = "ess";
            request.LocationEndpointType = "openAPI";

            var result = instance.GetAcsResponse<AcsResponse>(request, true, 3);
            Assert.True(instance.AutoRetry);
            Assert.Equal(3, instance.MaxRetryNumber);
        }

        [Fact]
        public void GetAcsResponse3()
        {
            DefaultAcsClient instance = this.MockDefaultAcsClient();

            // Mock AcsResquest
            MockAcsRequestForDefaultAcsClient request = new MockAcsRequestForDefaultAcsClient();
            request.RegionId = "cn-hangzhou";
            request.Product = "Ess";
            request.LocationProduct = "ess";
            request.LocationEndpointType = "openAPI";

            // Mock credentials
            Credential credentials = new Credential(AKID, AKSE);

            var result = instance.GetAcsResponse<AcsResponse>(request, "cn-hangzhou", credentials);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetAcsResponseWhenStatusIsNotSuccess()
        {
            DefaultAcsClient instance = this.MockDefaultAcsClient(400);

            // Mock AcsResquest
            MockAcsRequestForDefaultAcsClient request = new MockAcsRequestForDefaultAcsClient();
            request.RegionId = "cn-hangzhou";
            request.Product = "Ess";
            request.LocationProduct = "ess";
            request.LocationEndpointType = "openAPI";

            // Mock credentials
            Credential credentials = new Credential(AKID, AKSE);

            Action testCode = () =>
            {
                var result = instance.GetAcsResponse<AcsResponse>(request, "cn-hangzhou", credentials);
            };
            var ex = Record.Exception(testCode);
            Assert.NotNull(ex);
            Assert.IsType<ClientException>(ex);
            Assert.Equal("ThisIsCode : ThisIsMessage", ex.Message);
        }

        [Fact]
        public void GetCommonResponse()
        {
            int status = 200;
            string code = "ThisIsCode";
            string message = "ThisIsMessage";
            string requestId = "ThisIsRequestId";

            // Mock RegionIds
            ISet<String> regionIds = new HashSet<String>();
            regionIds.Add("cn-hangzhou");

            // Mock productDomains
            List<ProductDomain> productDomains = new List<ProductDomain>() { };
            ProductDomain productDomain = new ProductDomain("Ess", "ess.aliyuncs.com");
            productDomains.Add(productDomain);

            // Mock endpoint
            Endpoint endpoint = new Endpoint("cn-hangzhou", regionIds, productDomains);

            // Mock endpoints
            List<Endpoint> endpoints = new List<Endpoint>() { };
            endpoints.Add(endpoint);

            // Mock response
            HttpResponse response = new HttpResponse();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Code\":\"" + code + "\",\"Message\":\"" + message + "\",\"RequestId\":\"" + requestId + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;

            // Mock credential
            Credential credential = new Credential(AKID, AKSE);

            // Mock Profile
            var mockProfile = new Mock<IClientProfile>();
            mockProfile.Setup(foo => foo.GetCredential()).Returns(credential);
            IClientProfile profile = mockProfile.Object;

            // Mock DefaultAcsClient
            var mockDefaultAcsClient = new Mock<DefaultAcsClient>(profile);
            mockDefaultAcsClient.Setup(foo => foo.DoAction(
                It.IsAny<AcsRequest<CommonResponse>>(),
                It.IsAny<bool>(),
                It.IsAny<int>(),
                It.IsAny<string>(),
                It.IsAny<AlibabaCloudCredentials>(),
                It.IsAny<Signer>(),
                It.IsAny<FormatType>(),
                It.IsAny<List<Endpoint>>()
            )).Returns(response);
            DefaultAcsClient instance = mockDefaultAcsClient.Object;
            // DefaultAcsClient instance = this.MockDefaultAcsClient();

            // Mock AcsResquest
            CommonRequest request = new CommonRequest();
            request.RegionId = "cn-hangzhou";
            request.Product = "Ess";
            request.LocationProduct = "ess";
            request.LocationEndpointType = "openAPI";

            CommonResponse commonResponse = instance.GetCommonResponse(request);
            Assert.NotNull(commonResponse);
            Assert.Equal(200, commonResponse.HttpStatus);
        }

        public sealed class MockAcsRequestForDefaultAcsClient : AcsRequest<AcsResponse>
        {
            public MockAcsRequestForDefaultAcsClient(string urlStr = null) : base(urlStr)
            {

            }
            public override HttpRequest SignRequest(Signer signer, AlibabaCloudCredentials credentials,
                FormatType? format, ProductDomain domain)
            {
                HttpRequest httpRequest = new HttpRequest();
                httpRequest.Url = "Instance by MockAcsRequest";
                return httpRequest;
            }

            public override String ComposeUrl(String endpoint, Dictionary<String, String> queries)
            {
                return "";
            }

            public override AcsResponse GetResponse(UnmarshallerContext unmarshallerContext)
            {
                CommonResponse response = new CommonResponse();
                return response;
            }
        }
    }
}
