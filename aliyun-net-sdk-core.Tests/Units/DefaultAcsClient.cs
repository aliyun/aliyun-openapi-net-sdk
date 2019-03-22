using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Auth.Sts;
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
            HttpRequest httpRequest = new HttpRequest();
            int connectTimeout = 1024;

            object[] resolveTimeoutArgs = { httpRequest };
            object[] connectTimeoutArgs = { connectTimeout };

            var type = typeof(DefaultAcsClient);
            var resolveTimeoutMethodInfo = type.GetMethod("ResolveTimeout", BindingFlags.NonPublic | BindingFlags.Instance);
            var setConnectTimeoutMethodInfo = type.GetMethod("SetConnectTimeoutInMilliSeconds", BindingFlags.Public | BindingFlags.Instance);

            var resolveTimeout = Activator.CreateInstance(type, profile);

            ///Case1: Client connect timeout is 1024 ms, Request connect timeout is 2048 ms
            ///Expect: the final connect timeout should be 2048 ms
            setConnectTimeoutMethodInfo.Invoke(resolveTimeout, connectTimeoutArgs);
            httpRequest.SetConnectTimeoutInMilliSeconds(2048);
            resolveTimeoutMethodInfo.Invoke(resolveTimeout, resolveTimeoutArgs);
            Assert.Equal(2048, httpRequest.connectTimeout);

            ///Case2: Client connect timeout is 1024 ms, Request connect timeout is 0 ms
            ///Expect: the final connect timeout should be 1024 ms
            httpRequest.SetConnectTimeoutInMilliSeconds(0);
            resolveTimeoutMethodInfo.Invoke(resolveTimeout, resolveTimeoutArgs);
            Assert.Equal(1024, httpRequest.connectTimeout);

            ///Case3: Client connect timeout is 0 ms, Request connect timeout is 2048 ms
            ///Expect: the final connect timeout should be 2048 ms
            connectTimeout = 0;
            setConnectTimeoutMethodInfo.Invoke(resolveTimeout, connectTimeoutArgs);
            httpRequest.SetConnectTimeoutInMilliSeconds(2048);
            resolveTimeoutMethodInfo.Invoke(resolveTimeout, resolveTimeoutArgs);
            Assert.Equal(2048, httpRequest.connectTimeout);
        }

        [Fact]
        public void ResolveReadTimeoutTest()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            HttpRequest httpRequest = new HttpRequest();

            int readTimeout = 1024;

            object[] resolveTimeoutArgs = { httpRequest };
            object[] readTimeoutArgs = { readTimeout };

            var type = typeof(DefaultAcsClient);
            var resolveTimeoutMethodInfo = type.GetMethod("ResolveTimeout", BindingFlags.NonPublic | BindingFlags.Instance);
            var setReadTimeoutMethodInfo = type.GetMethod("SetReadTimeoutInMilliSeconds", BindingFlags.Public | BindingFlags.Instance);

            var resolveTimeout = Activator.CreateInstance(type, profile);

            ///Case1: Client read timeout is 1024 ms, Request read timeout is 2048 ms
            ///Expect: the final read timeout should be 2048 ms
            setReadTimeoutMethodInfo.Invoke(resolveTimeout, readTimeoutArgs);
            httpRequest.SetReadTimeoutInMilliSeconds(2048);
            resolveTimeoutMethodInfo.Invoke(resolveTimeout, resolveTimeoutArgs);
            Assert.Equal(2048, httpRequest.readTimeout);

            ///Case2: Client read timeout is 1024 ms, Request read timeout is 0 ms
            ///Expect: the final read timeout should be 1024 ms
            httpRequest.SetReadTimeoutInMilliSeconds(0);
            resolveTimeoutMethodInfo.Invoke(resolveTimeout, resolveTimeoutArgs);
            Assert.Equal(1024, httpRequest.readTimeout);

            ///Case3: Client read timeout is 0 ms, Request read timeout is 2048 ms
            ///Expect: the final read timeout should be 2048 ms
            readTimeout = 0;
            setReadTimeoutMethodInfo.Invoke(resolveTimeout, readTimeoutArgs);
            httpRequest.SetReadTimeoutInMilliSeconds(2048);
            resolveTimeoutMethodInfo.Invoke(resolveTimeout, resolveTimeoutArgs);
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

        [Fact]
        public void SetGetHttpProxy()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            var client = new DefaultAcsClient(profile);
            client.SetHttpProxy("http://localhost.com");

            Assert.Equal("http://localhost.com", client.GetHttpProxy());

            client.SetHttpProxy(null);
            Environment.SetEnvironmentVariable("HTTP_PROXY", "http_proxy_1");
            Assert.Equal("http_proxy_1", client.GetHttpProxy());
            Environment.SetEnvironmentVariable("HTTP_PROXY", null);

            client.SetHttpProxy(null);
            Environment.SetEnvironmentVariable("http_proxy", "http_proxy_2");
            Assert.Equal("http_proxy_2", client.GetHttpProxy());
            Environment.SetEnvironmentVariable("http_proxy", null);

            client.SetHttpProxy("http://localhost.com");
            Environment.SetEnvironmentVariable("HTTP_PROXY", "http_proxy_1");
            Environment.SetEnvironmentVariable("http_proxy", "http_proxy_2");
            Assert.Equal("http://localhost.com", client.GetHttpProxy());
            Environment.SetEnvironmentVariable("http_proxy", null);
            Environment.SetEnvironmentVariable("HTTP_PROXY", null);
            client.SetHttpProxy(null);
        }

        [Fact]
        public void SetGetHttpsProxy()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            var client = new DefaultAcsClient(profile);
            client.SetHttpsProxy("https://localhost.com");

            Assert.Equal("https://localhost.com", client.GetHttpsProxy());

            client.SetHttpsProxy(null);
            Environment.SetEnvironmentVariable("HTTPS_PROXY", "https_proxy_1");
            Assert.Equal("https_proxy_1", client.GetHttpsProxy());
            Environment.SetEnvironmentVariable("HTTPS_PROXY", null);

            client.SetHttpsProxy(null);
            Environment.SetEnvironmentVariable("https_proxy", "https_proxy_2");
            Assert.Equal("https_proxy_2", client.GetHttpsProxy());
            Environment.SetEnvironmentVariable("https_proxy", null);

            client.SetHttpsProxy("https://localhost.com");
            Environment.SetEnvironmentVariable("HTTPS_PROXY", "https_proxy_1");
            Environment.SetEnvironmentVariable("https_proxy", "https_proxy_2");
            Assert.Equal("https://localhost.com", client.GetHttpsProxy());
            Environment.SetEnvironmentVariable("https_proxy", null);
            Environment.SetEnvironmentVariable("HTTPS_PROXY", null);
            client.SetHttpsProxy(null);
        }

        [Fact]
        public void SetGetNoProxy()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            var client = new DefaultAcsClient(profile);
            client.SetNoProxy("localhost.com,localtest.com");

            Assert.Equal("localhost.com,localtest.com", client.GetNoProxy());

            client.SetNoProxy(null);
            Environment.SetEnvironmentVariable("NO_PROXY", "no_proxy_1");
            Assert.Equal("no_proxy_1", client.GetNoProxy());
            Environment.SetEnvironmentVariable("NO_PROXY", null);

            client.SetNoProxy(null);
            Environment.SetEnvironmentVariable("no_proxy", "no_proxy_2");
            Assert.Equal("no_proxy_2", client.GetNoProxy());
            Environment.SetEnvironmentVariable("no_proxy", null);

            client.SetNoProxy("localhost.com,localtest.com");
            Environment.SetEnvironmentVariable("NO_PROXY", "no_proxy_1");
            Environment.SetEnvironmentVariable("no_proxy", "no_proxy_2");
            Assert.Equal("localhost.com,localtest.com", client.GetNoProxy());
            Environment.SetEnvironmentVariable("no_proxy", null);
            Environment.SetEnvironmentVariable("NO_PROXY", null);
            client.SetNoProxy(null);
        }

        [Fact]
        public void ResolveProxy()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            HttpRequest httpRequest = new HttpRequest("urls", new Dictionary<string, string>());

            var acsRequest = new AssumeRoleRequest();

            Type type = typeof(DefaultAcsClient);
            var resolveProxy = Activator.CreateInstance(type, profile);
            MethodInfo methodInfo = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(x => x.Name == "ResolveProxy" && x.IsPrivate)
                .First();

            MethodInfo genericMethod = methodInfo.MakeGenericMethod(typeof(AssumeRoleResponse));

            object[] parameters = { httpRequest, acsRequest };
            genericMethod.Invoke(resolveProxy, parameters);

            acsRequest.Protocol = ProtocolType.HTTP;
            Environment.SetEnvironmentVariable("HTTP_PROXY", "http://username:password@192.168.16.1:10");
            Environment.SetEnvironmentVariable("no_proxy", "localhost,127.0.0.1,localaddress,.localdomain.com");

            genericMethod.Invoke(resolveProxy, parameters);
            Assert.True(httpRequest.Headers.ContainsKey("Authorization"));
            Environment.SetEnvironmentVariable("HTTP_PROXY", null);
            httpRequest.Headers.Remove("Authorization");

            acsRequest.Protocol = ProtocolType.HTTPS;
            Environment.SetEnvironmentVariable("HTTPS_PROXY", "https://username:password@192.168.16.1:10");
            genericMethod.Invoke(resolveProxy, parameters);
            Assert.True(httpRequest.Headers.ContainsKey("Authorization"));
            Environment.SetEnvironmentVariable("HTTPS_PROXY", null);
            httpRequest.Headers.Remove("Authorization");

            Environment.SetEnvironmentVariable("HTTPS_PROXY", "https://192.168.16.1:10");
            genericMethod.Invoke(resolveProxy, parameters);
            Assert.False(httpRequest.Headers.ContainsKey("Authorization"));

            Environment.SetEnvironmentVariable("HTTPS_PROXY", null);
            Environment.SetEnvironmentVariable("HTTP_PROXY", null);
            Environment.SetEnvironmentVariable("no_proxy", null);
            httpRequest.Headers.Remove("Authorization");
        }
    }
}
