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

namespace Aliyun.Acs.Core.Tests.Units
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
            // 400 Error
            DefaultAcsClient instance = this.MockDefaultAcsClient(400);

            // Mock AcsResquest
            MockAcsRequestForDefaultAcsClient request = new MockAcsRequestForDefaultAcsClient();
            request.RegionId = "cn-hangzhou";
            request.Product = "Ess";
            request.LocationProduct = "ess";
            request.LocationEndpointType = "openAPI";

            // Mock credentials
            Credential credentials = new Credential(AKID, AKSE);

            Action testCode400 = () =>
            {
                var result = instance.GetAcsResponse<AcsResponse>(request, "cn-hangzhou", credentials);
            };
            var ex = Record.Exception(testCode400);
            Assert.NotNull(ex);
            Assert.IsType<ClientException>(ex);
            Assert.Equal("ThisIsCode : ThisIsMessage", ex.Message);

            // 502 Error
            instance = this.MockDefaultAcsClient(502);
            Action testCode502 = () =>
            {
                var result = instance.GetAcsResponse<AcsResponse>(request, "cn-hangzhou", credentials);
            };
            ex = Record.Exception(testCode400);
            Assert.NotNull(ex);
            Assert.IsType<ServerException>(ex);
            Assert.Equal("ThisIsCode : ThisIsMessage", ex.Message);
        }

        [Fact]
        public void TestSignatureDoesNotMatch()
        {
            DefaultAcsClient instance = this.MockDefaultAcsClient(400, "SignatureDoesNotMatch", "signature does not conform to standards. server string to sign is:Error Signature");
            MockAcsRequestForDefaultAcsClient request = new MockAcsRequestForDefaultAcsClient();
            request.StringToSign = "this is string to sign info";
            Credential credentials = new Credential(AKID, AKSE);

            Exception signatureException = Assert.Throws<ClientException>(() =>
            {
                var result = instance.GetAcsResponse<AcsResponse>(request, "cn-hangzhou", credentials);
            });

            Assert.Equal("SignatureDoesNotMatch : signature does not conform to standards. server string to sign is:Error Signature", signatureException.Message);

            instance = this.MockDefaultAcsClient(400, "SignatureDoesNotMatch", "signature does not conform to standards. server string to sign is:this is string to sign info");

            Exception invalidException = Assert.Throws<ClientException>(() =>
            {
                var result = instance.GetAcsResponse<AcsResponse>(request, "cn-hangzhou", credentials);
            });

            Assert.Equal("SDK.InvalidAccessKeySecret : Specified Access Key Secret is not valid.", invalidException.Message);
        }

        [Fact]
        public void TestIncompleteSignature()
        {
            DefaultAcsClient instance = this.MockDefaultAcsClient(400, "IncompleteSignature", "The request signature does not conform to Aliyun standards. server string to sign is:Error Signature");
            MockAcsRequestForDefaultAcsClient request = new MockAcsRequestForDefaultAcsClient();
            request.StringToSign = "this is string to sign info";
            Credential credentials = new Credential(AKID, AKSE);

            Exception signatureException = Assert.Throws<ClientException>(() =>
            {
                var result = instance.GetAcsResponse<AcsResponse>(request, "cn-hangzhou", credentials);
            });

            Assert.Equal("IncompleteSignature : The request signature does not conform to Aliyun standards. server string to sign is:Error Signature", signatureException.Message);

            instance = this.MockDefaultAcsClient(400, "IncompleteSignature", "The request signature does not conform to Aliyun standards. server string to sign is:this is string to sign info");

            Exception invalidException = Assert.Throws<ClientException>(() =>
            {
                var result = instance.GetAcsResponse<AcsResponse>(request, "cn-hangzhou", credentials);
            });

            Assert.Equal("SDK.InvalidAccessKeySecret : Specified Access Key Secret is not valid.", invalidException.Message);
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

        [Fact]
        public void DoAction1()
        {
            // When
            // request.AcceptFormat is null
            // request.ProductDomain is null
            // domain is null

            // Mock credential
            Credential credential = new Credential(AKID, AKSE);

            DefaultAcsClient instance = new DefaultAcsClient();

            // Mock AcsResquest
            MockAcsRequestForDefaultAcsClient request = new MockAcsRequestForDefaultAcsClient();

            // Mock AlibabaCloudCredentials
            var mockCredentials = new Mock<AlibabaCloudCredentials>();
            AlibabaCloudCredentials credentials = mockCredentials.Object;
            Signer signer = new HmacSHA1Signer();

            // When prodoctDomain is not exist
            Assert.Throws<ClientException>(
                () =>
                {
                    var response = instance.DoAction<AcsResponse>(request, true, 1, "cn-hangzhou", credentials, signer, FormatType.JSON, null);
                }
            );
        }

        [Fact]
        public void DoAction2()
        {
            // When
            // request.AcceptFormat is not null
            // request.ProductDomain is not null
            // domain is not null
            // response.Content is null

            // Mock response
            HttpResponse response = new HttpResponse();
            response.ContentType = FormatType.JSON;
            response.Content = null;
            response.Status = 200;

            var mockInstance = new Mock<DefaultAcsClient>() { CallBase = true };
            mockInstance.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            DefaultAcsClient instance = mockInstance.Object;

            // Mock AcsResquest
            MockAcsRequestForDefaultAcsClient request = new MockAcsRequestForDefaultAcsClient();
            request.AcceptFormat = FormatType.JSON;
            ProductDomain productDomain = new ProductDomain("productName", "productDomain");
            request.ProductDomain = productDomain;

            // Mock AlibabaCloudCredentials
            var mockCredentials = new Mock<AlibabaCloudCredentials>();
            AlibabaCloudCredentials credentials = mockCredentials.Object;

            // Mock Signer
            Signer signer = new HmacSHA1Signer();

            Assert.Throws<ClientException>(
                () =>
                {
                    var result = instance.DoAction<AcsResponse>(request, true, 1, "cn-hangzhou", credentials, signer, FormatType.JSON, null);
                }
            );
        }

        [Fact]
        public void DoAction3()
        {
            // When
            // request.AcceptFormat is not null
            // request.ProductDomain is not null
            // domain is not null
            // response.Content is not null
            // response.Status != 200

            // Mock response
            int status = 400;
            string code = "ThisIsCode";
            string message = "ThisIsMessage";
            string requestId = "ThisIsRequestId";
            HttpResponse response = new HttpResponse();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Code\":\"" + code + "\",\"Message\":\"" + message + "\",\"RequestId\":\"" + requestId + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;

            var mockInstance = new Mock<DefaultAcsClient>() { CallBase = true };
            mockInstance.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            DefaultAcsClient instance = mockInstance.Object;

            // Mock AcsResquest
            MockAcsRequestForDefaultAcsClient request = new MockAcsRequestForDefaultAcsClient();
            request.AcceptFormat = FormatType.JSON;
            ProductDomain productDomain = new ProductDomain("productName", "productDomain");
            request.ProductDomain = productDomain;

            // Mock AlibabaCloudCredentials
            var mockCredentials = new Mock<AlibabaCloudCredentials>();
            AlibabaCloudCredentials credentials = mockCredentials.Object;

            // Mock Signer
            Signer signer = new HmacSHA1Signer();

            var result = instance.DoAction<AcsResponse>(request, true, 1, "cn-hangzhou", credentials, signer, FormatType.JSON, null);
            Assert.NotNull(result);
            Assert.Equal(result.Status, response.Status);
        }

        [Fact]
        public void DoAction4()
        {
            // When
            // request.AcceptFormat is not null
            // request.ProductDomain is not null
            // domain is not null
            // response.Content is not null
            // response.Status != 200

            // Mock response
            int status = 200;
            string code = "ThisIsCode";
            string message = "ThisIsMessage";
            string requestId = "ThisIsRequestId";
            HttpResponse response = new HttpResponse();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Code\":\"" + code + "\",\"Message\":\"" + message + "\",\"RequestId\":\"" + requestId + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;

            var mockInstance = new Mock<DefaultAcsClient>() { CallBase = true };
            mockInstance.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            DefaultAcsClient instance = mockInstance.Object;

            // Mock AcsResquest
            MockAcsRequestForDefaultAcsClient request = new MockAcsRequestForDefaultAcsClient();
            request.AcceptFormat = FormatType.JSON;
            ProductDomain productDomain = new ProductDomain("productName", "productDomain");
            request.ProductDomain = productDomain;

            // Mock AlibabaCloudCredentials
            var mockCredentials = new Mock<AlibabaCloudCredentials>();
            AlibabaCloudCredentials credentials = mockCredentials.Object;

            // Mock Signer
            Signer signer = new HmacSHA1Signer();

            var result = instance.DoAction<AcsResponse>(request, true, 1, "cn-hangzhou", credentials, signer, FormatType.JSON, null);
            Assert.Equal(200, result.Status);
        }

        [Fact]
        public void DoAction5()
        {
            Environment.SetEnvironmentVariable("DEBUG", "sdk");
            int status = 200;
            string code = "ThisIsCode1";
            string message = "ThisIsMessage1";
            string requestId = "ThisIsRequestId1";
            HttpResponse response = new HttpResponse();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Code\":\"" + code + "\",\"Message\":\"" + message + "\",\"RequestId\":\"" + requestId + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;

            Dictionary<string, string> tmpHeaders = new Dictionary<string, string>
            { { "Content-MD5", "md5" },
                { "Content-Length", "length" },
                { "Content-Type", "text/json" }
            };

            response.Headers = tmpHeaders;

            var mockInstance = new Mock<DefaultAcsClient>() { CallBase = true };
            mockInstance.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            DefaultAcsClient instance = mockInstance.Object;

            // Mock AcsResquest
            MockAcsRequestForDefaultAcsClient request = new MockAcsRequestForDefaultAcsClient();
            request.AcceptFormat = FormatType.JSON;
            ProductDomain productDomain = new ProductDomain("productName1", "productDomain1");
            request.ProductDomain = productDomain;

            // Mock AlibabaCloudCredentials
            var mockCredentials = new Mock<AlibabaCloudCredentials>();
            AlibabaCloudCredentials credentials = mockCredentials.Object;

            // Mock Signer
            Signer signer = new HmacSHA1Signer();

            var result = instance.DoAction<AcsResponse>(request, true, 1, "cn-hangzhou", credentials, signer, FormatType.JSON, null);

            Assert.Null(Environment.GetEnvironmentVariable("DEBUG"));

            status = 500;
            result = instance.DoAction<AcsResponse>(request, true, 0, "cn-hangzhou", credentials, signer, FormatType.JSON, null);
            Assert.Null(Environment.GetEnvironmentVariable("DEBUG"));
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

        [Fact]
        public void UserAgentConfigTest()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            DefaultAcsClient client = new DefaultAcsClient(profile);

            client.AppendUserAgent("test", "1.1.2");
            client.AppendUserAgent("test", "1.1.3");
            client.AppendUserAgent("mock", "1.1.2");

            var userAgent = UserAgent.Resolve(null, client.GetUserAgentConfig());
            var resultStr = UserAgent.GetDefaultMessage() + " test/1.1.3" + " mock/1.1.2";

            Assert.Equal(resultStr, userAgent);
        }

        [Fact]
        public void SetConnectTimeoutTest()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            DefaultAcsClient client = new DefaultAcsClient(profile);
            client.SetConnectTimeoutInMilliSeconds(3000);

            Assert.Equal(3000, client.connectTimeout);
        }

        [Fact]
        public void SetReadTimeoutTest()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            DefaultAcsClient client = new DefaultAcsClient(profile);
            client.SetReadTimeoutInMilliSeconds(3000);

            Assert.Equal(3000, client.readTimeout);
        }

        [Fact]
        public void ResolveConnectTimeoutTest()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            DefaultAcsClient client = new DefaultAcsClient(profile);
            HttpRequest httpRequest = new HttpRequest();

            ///Case1: Client connect timeout is 1024 ms, Request connect timeout is 2048 ms
            ///Expect: the final connect timeout should be 2048 ms
            client.SetConnectTimeoutInMilliSeconds(1024);
            httpRequest.SetConnectTimeoutInMilliSeconds(2048);
            client.ResolveTimeout(httpRequest);
            Assert.Equal(2048, httpRequest.connectTimeout);

            ///Case2: Client connect timeout is 1024 ms, Request connect timeout is 0 ms
            ///Expect: the final connect timeout should be 1024 ms
            httpRequest.SetConnectTimeoutInMilliSeconds(0);
            client.ResolveTimeout(httpRequest);
            Assert.Equal(1024, httpRequest.connectTimeout);

            ///Case3: Client connect timeout is 0 ms, Request connect timeout is 2048 ms
            ///Expect: the final connect timeout should be 2048 ms
            client.SetConnectTimeoutInMilliSeconds(0);
            httpRequest.SetConnectTimeoutInMilliSeconds(2048);
            client.ResolveTimeout(httpRequest);
            Assert.Equal(2048, httpRequest.connectTimeout);
        }

        [Fact]
        public void ResolveReadTimeoutTest()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            DefaultAcsClient client = new DefaultAcsClient(profile);
            HttpRequest httpRequest = new HttpRequest();

            ///Case1: Client read timeout is 1024 ms, Request read timeout is 2048 ms
            ///Expect: the final read timeout should be 2048 ms
            client.SetReadTimeoutInMilliSeconds(1024);
            httpRequest.SetReadTimeoutInMilliSeconds(2048);
            client.ResolveTimeout(httpRequest);
            Assert.Equal(2048, httpRequest.readTimeout);

            ///Case2: Client read timeout is 1024 ms, Request read timeout is 0 ms
            ///Expect: the final read timeout should be 1024 ms
            httpRequest.SetReadTimeoutInMilliSeconds(0);
            client.ResolveTimeout(httpRequest);
            Assert.Equal(1024, httpRequest.readTimeout);

            ///Case3: Client read timeout is 0 ms, Request read timeout is 2048 ms
            ///Expect: the final read timeout should be 2048 ms
            client.SetReadTimeoutInMilliSeconds(0);
            httpRequest.SetReadTimeoutInMilliSeconds(2048);
            client.ResolveTimeout(httpRequest);
            Assert.Equal(2048, httpRequest.readTimeout);
        }

        [Fact]
        public void ClientIgnoreCertificateTest()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            DefaultAcsClient client = new DefaultAcsClient(profile);

            client.SetHttpsInsecure();
            Assert.False(client.IgnoreCertificate);

            client.SetHttpsInsecure(true);
            Assert.True(client.IgnoreCertificate);
        }
    }
}
