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
using System.Linq;
using System.Reflection;
using System.Text;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units
{
    public class DefaultAcsClientTest
    {
        private static readonly string AKID = "accessKeyId";

        private static readonly string AKSE = "accessKeySecret";

        public DefaultAcsClient MockDefaultAcsClient(
            int status = 200,
            string code = "ThisIsCode",
            string message = "ThisIsMessage",
            string requestId = "ThisIsRequestId"
        )
        {
            // Mock RegionIds
            ISet<string> regionIds = new HashSet<string>();
            regionIds.Add("cn-hangzhou");

            // Mock productDomains
            var productDomains = new List<ProductDomain>();
            var productDomain = new ProductDomain("Ess", "ess.aliyuncs.com");
            productDomains.Add(productDomain);

            // Mock endpoint
            var endpoint = new Endpoint("cn-hangzhou", regionIds, productDomains);

            // Mock endpoints
            var endpoints = new List<Endpoint>();
            endpoints.Add(endpoint);

            // Mock response
            var response = new HttpResponse();
            var content = Encoding.GetEncoding("UTF-8")
                .GetBytes("{\"Code\":\"" + code + "\",\"Message\":\"" + message + "\",\"RequestId\":\"" + requestId +
                          "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;

            // Mock credential
            var credential = new Credential(AKID, AKSE);

            // Mock Profile
            var mockProfile = new Mock<IClientProfile>();
            mockProfile.Setup(foo => foo.GetCredential()).Returns(credential);
            var profile = mockProfile.Object;

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
            var instance = mockDefaultAcsClient.Object;

            return instance;
        }

        public sealed class MockAcsRequestForDefaultAcsClient : AcsRequest<AcsResponse>
        {
            public MockAcsRequestForDefaultAcsClient(string urlStr = null) : base(urlStr)
            {
            }

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

            public override AcsResponse GetResponse(UnmarshallerContext unmarshallerContext)
            {
                var response = new CommonResponse();
                return response;
            }
        }

        [Fact]
        public void ClientIgnoreCertificateTest()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            var client = new DefaultAcsClient(profile);

            client.SetHttpsInsecure();
            Assert.False(client.IgnoreCertificate);

            client.SetHttpsInsecure(true);
            Assert.True(client.IgnoreCertificate);
        }

        [Fact]
        public void DoAction1()
        {
            // When
            // request.AcceptFormat is null
            // request.ProductDomain is null
            // domain is null

            // Mock credential
            var credential = new Credential(AKID, AKSE);

            var instance = new DefaultAcsClient();

            // Mock AcsResquest
            var request = new MockAcsRequestForDefaultAcsClient();

            // Mock AlibabaCloudCredentials
            var mockCredentials = new Mock<AlibabaCloudCredentials>();
            var credentials = mockCredentials.Object;
            Signer signer = new HmacSHA1Signer();

            // When prodoctDomain is not exist
            Assert.Throws<ClientException>(
                () =>
                {
                    var response = instance.DoAction(request, true, 1, "cn-hangzhou", credentials, signer,
                        FormatType.JSON, null);
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
            var response = new HttpResponse();
            response.ContentType = FormatType.JSON;
            response.Content = null;
            response.Status = 200;

            var mockInstance = new Mock<DefaultAcsClient>
            { CallBase = true };
            mockInstance.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            var instance = mockInstance.Object;

            // Mock AcsResquest
            var request = new MockAcsRequestForDefaultAcsClient();
            request.AcceptFormat = FormatType.JSON;
            var productDomain = new ProductDomain("productName", "productDomain");
            request.ProductDomain = productDomain;

            // Mock AlibabaCloudCredentials
            var mockCredentials = new Mock<AlibabaCloudCredentials>();
            var credentials = mockCredentials.Object;

            // Mock Signer
            Signer signer = new HmacSHA1Signer();

            var result = instance.DoAction(request, true, 1, "cn-hangzhou", credentials, signer, FormatType.JSON, null);

            Assert.Equal(result, response);
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
            var status = 400;
            var code = "ThisIsCode";
            var message = "ThisIsMessage";
            var requestId = "ThisIsRequestId";
            var response = new HttpResponse();
            var content = Encoding.GetEncoding("UTF-8")
                .GetBytes("{\"Code\":\"" + code + "\",\"Message\":\"" + message + "\",\"RequestId\":\"" + requestId +
                          "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;

            var mockInstance = new Mock<DefaultAcsClient>
            { CallBase = true };
            mockInstance.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            var instance = mockInstance.Object;

            // Mock AcsResquest
            var request = new MockAcsRequestForDefaultAcsClient();
            request.AcceptFormat = FormatType.JSON;
            var productDomain = new ProductDomain("productName", "productDomain");
            request.ProductDomain = productDomain;

            // Mock AlibabaCloudCredentials
            var mockCredentials = new Mock<AlibabaCloudCredentials>();
            var credentials = mockCredentials.Object;

            // Mock Signer
            Signer signer = new HmacSHA1Signer();

            var result = instance.DoAction(request, true, 1, "cn-hangzhou", credentials, signer, FormatType.JSON, null);
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
            var status = 200;
            var code = "ThisIsCode";
            var message = "ThisIsMessage";
            var requestId = "ThisIsRequestId";
            var response = new HttpResponse();
            var content = Encoding.GetEncoding("UTF-8")
                .GetBytes("{\"Code\":\"" + code + "\",\"Message\":\"" + message + "\",\"RequestId\":\"" + requestId +
                          "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;

            var mockInstance = new Mock<DefaultAcsClient>
            { CallBase = true };
            mockInstance.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            var instance = mockInstance.Object;

            // Mock AcsResquest
            var request = new MockAcsRequestForDefaultAcsClient();
            request.AcceptFormat = FormatType.JSON;
            var productDomain = new ProductDomain("productName", "productDomain");
            request.ProductDomain = productDomain;

            // Mock AlibabaCloudCredentials
            var mockCredentials = new Mock<AlibabaCloudCredentials>();
            var credentials = mockCredentials.Object;

            // Mock Signer
            Signer signer = new HmacSHA1Signer();

            var result = instance.DoAction(request, true, 1, "cn-hangzhou", credentials, signer, FormatType.JSON, null);
            Assert.Equal(200, result.Status);
        }

        [Fact]
        public void DoAction5()
        {
            Environment.SetEnvironmentVariable("DEBUG", "sdk");
            var status = 200;
            var code = "ThisIsCode1";
            var message = "ThisIsMessage1";
            var requestId = "ThisIsRequestId1";
            var response = new HttpResponse();
            var content = Encoding.GetEncoding("UTF-8")
                .GetBytes("{\"Code\":\"" + code + "\",\"Message\":\"" + message + "\",\"RequestId\":\"" + requestId +
                          "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;

            var tmpHeaders = new Dictionary<string, string>
            {
                {"Content-MD5", "md5"},
                {"Content-Length", "length"},
                {"Content-Type", "text/json"}
            };

            response.Headers = tmpHeaders;

            var mockInstance = new Mock<DefaultAcsClient>
            { CallBase = true };
            mockInstance.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            var instance = mockInstance.Object;

            // Mock AcsResquest
            var request = new MockAcsRequestForDefaultAcsClient();
            request.AcceptFormat = FormatType.JSON;
            var productDomain = new ProductDomain("productName1", "productDomain1");
            request.ProductDomain = productDomain;

            // Mock AlibabaCloudCredentials
            var mockCredentials = new Mock<AlibabaCloudCredentials>();
            var credentials = mockCredentials.Object;

            // Mock Signer
            Signer signer = new HmacSHA1Signer();

            var result = instance.DoAction(request, true, 1, "cn-hangzhou", credentials, signer, FormatType.JSON, null);

            Assert.Null(Environment.GetEnvironmentVariable("DEBUG"));

            status = 500;
            result = instance.DoAction(request, true, 0, "cn-hangzhou", credentials, signer, FormatType.JSON, null);
            Assert.Null(Environment.GetEnvironmentVariable("DEBUG"));
        }

        [Fact]
        public void GetAcsResponse1()
        {
            var instance = MockDefaultAcsClient();

            // Mock AcsResquest
            var request = new MockAcsRequestForDefaultAcsClient();
            request.RegionId = "cn-hangzhou";
            request.Product = "Ess";
            request.LocationProduct = "ess";
            request.LocationEndpointType = "openAPI";

            var result = instance.GetAcsResponse(request);
            Assert.IsType<CommonResponse>(result);

            var mockIClientProfile = new Mock<IClientProfile>();
            var iClientProfile = mockIClientProfile.Object;
            result = instance.GetAcsResponse(request, iClientProfile);
            Assert.IsType<CommonResponse>(result);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetAcsResponse2()
        {
            var instance = MockDefaultAcsClient();

            // Mock AcsResquest
            var request = new MockAcsRequestForDefaultAcsClient();
            request.RegionId = "cn-hangzhou";
            request.Product = "Ess";
            request.LocationProduct = "ess";
            request.LocationEndpointType = "openAPI";

            var result = instance.GetAcsResponse(request, true, 3);
            Assert.True(instance.AutoRetry);
            Assert.Equal(3, instance.MaxRetryNumber);
        }

        [Fact]
        public void GetAcsResponse3()
        {
            var instance = MockDefaultAcsClient();

            // Mock AcsResquest
            var request = new MockAcsRequestForDefaultAcsClient();
            request.RegionId = "cn-hangzhou";
            request.Product = "Ess";
            request.LocationProduct = "ess";
            request.LocationEndpointType = "openAPI";

            // Mock credentials
            var credentials = new Credential(AKID, AKSE);

            var result = instance.GetAcsResponse(request, "cn-hangzhou", credentials);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetAcsResponseWhenStatusIsNotSuccess()
        {
            // 400 Error
            var instance = MockDefaultAcsClient(400);

            // Mock AcsResquest
            var request = new MockAcsRequestForDefaultAcsClient();
            request.RegionId = "cn-hangzhou";
            request.Product = "Ess";
            request.LocationProduct = "ess";
            request.LocationEndpointType = "openAPI";

            // Mock credentials
            var credentials = new Credential(AKID, AKSE);

            Action testCode400 = () =>
            {
                var result = instance.GetAcsResponse(request, "cn-hangzhou", credentials);
            };
            var ex = Record.Exception(testCode400);
            Assert.NotNull(ex);
            Assert.IsType<ClientException>(ex);
            Assert.Contains("ThisIsCode : ThisIsMessage", ex.Message);

            // 502 Error
            instance = MockDefaultAcsClient(502);
            Action testCode502 = () =>
            {
                var result = instance.GetAcsResponse(request, "cn-hangzhou", credentials);
            };
            ex = Record.Exception(testCode400);
            Assert.NotNull(ex);
            Assert.IsType<ServerException>(ex);
            Assert.Contains("ThisIsCode : ThisIsMessage, the request url is empty, the RequestId is ThisIsRequestId.", ex.Message);
        }

        [Fact]
        public void GetAcsResponseWithLogInfoSuccess()
        {
            var instance = MockDefaultAcsClient();

            DefaultAcsClient.EnableLogger();

            // Mock AcsResquest
            var request = new MockAcsRequestForDefaultAcsClient();
            request.RegionId = "cn-hangzhou";
            request.Product = "Ess";
            request.LocationProduct = "ess";
            request.LocationEndpointType = "openAPI";

            var result = instance.GetAcsResponse(request);
            Assert.IsType<CommonResponse>(result);

            DefaultAcsClient.DisableLogger();
        }

        [Fact]
        public void GetAndSet()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            var instance = new DefaultAcsClient(profile);

            // MaxRetryNumber
            instance.MaxRetryNumber = 3;
            Assert.Equal(3, instance.MaxRetryNumber);

            // AutoRetry
            instance.AutoRetry = true;
            Assert.True(instance.AutoRetry);
        }

        [Fact]
        public void GetCommonResponse()
        {
            var status = 200;
            var code = "ThisIsCode";
            var message = "ThisIsMessage";
            var requestId = "ThisIsRequestId";

            // Mock RegionIds
            ISet<string> regionIds = new HashSet<string>();
            regionIds.Add("cn-hangzhou");

            // Mock productDomains
            var productDomains = new List<ProductDomain>();
            var productDomain = new ProductDomain("Ess", "ess.aliyuncs.com");
            productDomains.Add(productDomain);

            // Mock endpoint
            var endpoint = new Endpoint("cn-hangzhou", regionIds, productDomains);

            // Mock endpoints
            var endpoints = new List<Endpoint>();
            endpoints.Add(endpoint);

            // Mock response
            var response = new HttpResponse();
            var content = Encoding.GetEncoding("UTF-8")
                .GetBytes("{\"Code\":\"" + code + "\",\"Message\":\"" + message + "\",\"RequestId\":\"" + requestId +
                          "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;

            // Mock credential
            var credential = new Credential(AKID, AKSE);

            // Mock Profile
            var mockProfile = new Mock<IClientProfile>();
            mockProfile.Setup(foo => foo.GetCredential()).Returns(credential);
            var profile = mockProfile.Object;

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
            var instance = mockDefaultAcsClient.Object;
            // DefaultAcsClient instance = this.MockDefaultAcsClient();

            // Mock AcsResquest
            var request = new CommonRequest();
            request.RegionId = "cn-hangzhou";
            request.Product = "Ess";
            request.LocationProduct = "ess";
            request.LocationEndpointType = "openAPI";

            var commonResponse = instance.GetCommonResponse(request);
            Assert.NotNull(commonResponse);
            Assert.Equal(200, commonResponse.HttpStatus);
        }

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
            var alibabaCloudCredentials = mock.Object;
            instance = new DefaultAcsClient(profile, mock.Object);
            Assert.Equal("cn-hangzhou", profile.GetRegionId());
            Assert.Equal(AKID, profile.GetCredential().AccessKeyId);
            Assert.Equal(AKSE, profile.GetCredential().AccessSecret);

            var mockProvider = new Mock<AlibabaCloudCredentialsProvider>();
            var alibabaCloudCredentialsProvider = mockProvider.Object;
            instance = new DefaultAcsClient(profile, mock.Object);
            Assert.Equal("cn-hangzhou", profile.GetRegionId());
            Assert.Equal(AKID, profile.GetCredential().AccessKeyId);
            Assert.Equal(AKSE, profile.GetCredential().AccessSecret);
        }

        [Fact]
        public void ResolveConnectTimeoutTest()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            var httpRequest = new HttpRequest();
            var connectTimeout = 1024;

            object[] resolveTimeoutArgs = { httpRequest, "ecs", "2014-05-10", "DescribeInstaces" };
            object[] connectTimeoutArgs = { connectTimeout };

            var type = typeof(DefaultAcsClient);
            var resolveTimeoutMethodInfo =
                type.GetMethod("ResolveTimeout", BindingFlags.NonPublic | BindingFlags.Instance);
            var setConnectTimeoutMethodInfo = type.GetMethod("SetConnectTimeoutInMilliSeconds",
                BindingFlags.Public | BindingFlags.Instance);

            var resolveTimeout = Activator.CreateInstance(type, profile);

            //Case1: Client connect timeout is 1024 ms, Request connect timeout is 2048 ms
            //Expect: the final connect timeout should be 2048 ms
            setConnectTimeoutMethodInfo.Invoke(resolveTimeout, connectTimeoutArgs);
            httpRequest.SetConnectTimeoutInMilliSeconds(2048);
            resolveTimeoutMethodInfo.Invoke(resolveTimeout, resolveTimeoutArgs);
            Assert.Equal(2048, httpRequest.ConnectTimeout);

            //Case2: Client connect timeout is 1024 ms, Request connect timeout is 0 ms
            //Expect: the final connect timeout should be 1024 ms
            httpRequest.SetConnectTimeoutInMilliSeconds(0);
            resolveTimeoutMethodInfo.Invoke(resolveTimeout, resolveTimeoutArgs);
            Assert.Equal(1024, httpRequest.ConnectTimeout);

            //Case3: Client connect timeout is 0 ms, Request connect timeout is 2048 ms
            //Expect: the final connect timeout should be 2048 ms

            connectTimeout = 0;
            setConnectTimeoutMethodInfo.Invoke(resolveTimeout, connectTimeoutArgs);
            httpRequest.SetConnectTimeoutInMilliSeconds(2048);
            resolveTimeoutMethodInfo.Invoke(resolveTimeout, resolveTimeoutArgs);
            Assert.Equal(2048, httpRequest.ConnectTimeout);
        }

        [Fact]
        public void ResolveProxy()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            var httpRequest = new HttpRequest("urls", new Dictionary<string, string>());

            var acsRequest = new AssumeRoleRequest();

            var type = typeof(DefaultAcsClient);
            var resolveProxy = Activator.CreateInstance(type, profile);
            var methodInfo = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(x => x.Name == "ResolveProxy" && x.IsPrivate)
                .First();

            var genericMethod = methodInfo.MakeGenericMethod(typeof(AssumeRoleResponse));

            object[] parameters = { httpRequest, acsRequest };
            genericMethod.Invoke(resolveProxy, parameters);

            acsRequest.Protocol = ProtocolType.HTTP;
            Environment.SetEnvironmentVariable("HTTP_PROXY", "http://username:password@192.168.16.1:10");
            Environment.SetEnvironmentVariable("no_proxy", "localhost,127.0.0.1,localaddress,.localdomain.com");

            genericMethod.Invoke(resolveProxy, parameters);
            Assert.True(httpRequest.Headers.ContainsKey("Authorization"));
            Environment.SetEnvironmentVariable("HTTP_PROXY", null);

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

        [Fact]
        public void ResolveReadTimeoutTest()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            var httpRequest = new HttpRequest();

            var readTimeout = 1024;

            object[] resolveTimeoutArgs = { httpRequest, "ecs", "2014-05-26", "DescribeInstances" };
            object[] readTimeoutArgs = { readTimeout };

            var type = typeof(DefaultAcsClient);
            var resolveTimeoutMethodInfo =
                type.GetMethod("ResolveTimeout", BindingFlags.NonPublic | BindingFlags.Instance);
            var setReadTimeoutMethodInfo =
                type.GetMethod("SetReadTimeoutInMilliSeconds", BindingFlags.Public | BindingFlags.Instance);

            var resolveTimeout = Activator.CreateInstance(type, profile);

            // Case1: Client read timeout is 1024 ms, Request read timeout is 2048 ms
            // Expect: the final read timeout should be 2048 ms
            setReadTimeoutMethodInfo.Invoke(resolveTimeout, readTimeoutArgs);
            httpRequest.SetReadTimeoutInMilliSeconds(2048);
            resolveTimeoutMethodInfo.Invoke(resolveTimeout, resolveTimeoutArgs);
            Assert.Equal(2048, httpRequest.ReadTimeout);

            // Case2: Client read timeout is 1024 ms, Request read timeout is 0 ms
            // Expect: the final read timeout should be 1024 ms
            httpRequest.SetReadTimeoutInMilliSeconds(0);
            resolveTimeoutMethodInfo.Invoke(resolveTimeout, resolveTimeoutArgs);
            Assert.Equal(1024, httpRequest.ReadTimeout);

            // Case3: Client read timeout is 0 ms, Request read timeout is 2048 ms
            // Expect: the final read timeout should be 2048 ms
            readTimeout = 0;
            object[] readTimeoutArgs2 = {readTimeout};
            setReadTimeoutMethodInfo.Invoke(resolveTimeout, readTimeoutArgs2);
            httpRequest.SetReadTimeoutInMilliSeconds(2048);
            resolveTimeoutMethodInfo.Invoke(resolveTimeout, resolveTimeoutArgs);
            Assert.Equal(2048, httpRequest.ReadTimeout);

            // Case4: Client read timeout is 0ms, request read timeout is 0ms,
            // Expect: the final read timeout should be specific api read timeout value.
            readTimeout = 0;
            object[] readTimeoutArgs3 = { readTimeout };
            setReadTimeoutMethodInfo.Invoke(resolveTimeout, readTimeoutArgs3);
            httpRequest.SetReadTimeoutInMilliSeconds(0);
            resolveTimeoutMethodInfo.Invoke(resolveTimeout, resolveTimeoutArgs);
            Assert.Equal(10000, httpRequest.ReadTimeout);
        }

        [Fact]
        public void SetConnectTimeoutTest()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            var client = new DefaultAcsClient(profile);
            client.SetConnectTimeoutInMilliSeconds(3000);

            Assert.Equal(3000, client.ConnectTimeout);
        }

        [Fact]
        public void SetGetHttpProxy()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            var client = new DefaultAcsClient(profile);
            client.SetHttpProxy("http://localhost.com");

            Assert.Equal("http://localhost.com", client.GetHttpProxy());

            client.SetHttpProxy(null);
            Environment.SetEnvironmentVariable("HTTP_PROXY", "http_proxy_upper");
            Assert.Equal("http_proxy_upper", client.GetHttpProxy());
            Environment.SetEnvironmentVariable("HTTP_PROXY", null);

            client.SetHttpProxy(null);
            Environment.SetEnvironmentVariable("http_proxy", "http_proxy_lower");
            Assert.Equal("http_proxy_lower", client.GetHttpProxy());
            Environment.SetEnvironmentVariable("http_proxy", null);

            client.SetHttpProxy("http://localhost.com");
            Environment.SetEnvironmentVariable("HTTP_PROXY", "http_proxy_upper");
            Environment.SetEnvironmentVariable("http_proxy", "http_proxy_lower");
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
            Environment.SetEnvironmentVariable("HTTPS_PROXY", "https_proxy_upper");
            Assert.Equal("https_proxy_upper", client.GetHttpsProxy());
            Environment.SetEnvironmentVariable("HTTPS_PROXY", null);

            client.SetHttpsProxy(null);
            Environment.SetEnvironmentVariable("https_proxy", "https_proxy_lower");
            Assert.Equal("https_proxy_lower", client.GetHttpsProxy());
            Environment.SetEnvironmentVariable("https_proxy", null);

            client.SetHttpsProxy("https://localhost.com");
            Environment.SetEnvironmentVariable("HTTPS_PROXY", "https_proxy_upper");
            Environment.SetEnvironmentVariable("https_proxy", "https_proxy_lower");
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
            Environment.SetEnvironmentVariable("NO_PROXY", "no_proxy_upper");
            Assert.Equal("no_proxy_upper", client.GetNoProxy());
            Environment.SetEnvironmentVariable("NO_PROXY", null);

            client.SetNoProxy(null);
            Environment.SetEnvironmentVariable("no_proxy", "no_proxy_lower");
            Assert.Equal("no_proxy_lower", client.GetNoProxy());
            Environment.SetEnvironmentVariable("no_proxy", null);

            client.SetNoProxy("localhost.com,localtest.com");
            Environment.SetEnvironmentVariable("NO_PROXY", "no_proxy_upper");
            Environment.SetEnvironmentVariable("no_proxy", "no_proxy_lower");
            Assert.Equal("localhost.com,localtest.com", client.GetNoProxy());

            Environment.SetEnvironmentVariable("no_proxy", null);
            Environment.SetEnvironmentVariable("NO_PROXY", null);
            client.SetNoProxy(null);
        }

        [Fact]
        public void SetLoggerTest()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            var client = new DefaultAcsClient(profile);

            // Use Invalid Path will set the default user home path
            DefaultAcsClient.EnableLogger();
            Assert.True(CommonLog.GetEnableLoggerStatus());

            DefaultAcsClient.DisableLogger();
            Assert.False(CommonLog.GetEnableLoggerStatus());
        }

        [Fact]
        public void SetReadTimeoutTest()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            var client = new DefaultAcsClient(profile);
            client.SetReadTimeoutInMilliSeconds(3000);

            Assert.Equal(3000, client.ReadTimeout);
        }

        [Fact]
        public void TestIncompleteSignature()
        {
            var instance = MockDefaultAcsClient(400, "IncompleteSignature",
                "The request signature does not conform to Aliyun standards. server string to sign is:Error Signature");
            var request = new MockAcsRequestForDefaultAcsClient();
            request.StringToSign = "this is string to sign info";
            var credentials = new Credential(AKID, AKSE);

            Exception signatureException = Assert.Throws<ClientException>(() =>
            {
                var result = instance.GetAcsResponse(request, "cn-hangzhou", credentials);
            });

            Assert.Contains(
                "IncompleteSignature : The request signature does not conform to Aliyun standards. server string to sign is:Error Signature",
                signatureException.Message);

            instance = MockDefaultAcsClient(400, "IncompleteSignature",
                "The request signature does not conform to Aliyun standards. server string to sign is:this is string to sign info");

            Exception invalidException = Assert.Throws<ClientException>(() =>
            {
                var result = instance.GetAcsResponse(request, "cn-hangzhou", credentials);
            });

            Assert.Contains("SDK.InvalidAccessKeySecret : Specified Access Key Secret is not valid.",
                invalidException.Message);
        }

        [Fact]
        public void TestSignatureDoesNotMatch()
        {
            var instance = MockDefaultAcsClient(400, "SignatureDoesNotMatch",
                "signature does not conform to standards. server string to sign is:Error Signature");
            var request = new MockAcsRequestForDefaultAcsClient();
            request.StringToSign = "this is string to sign info";
            var credentials = new Credential(AKID, AKSE);

            Exception signatureException = Assert.Throws<ClientException>(() =>
            {
                var result = instance.GetAcsResponse(request, "cn-hangzhou", credentials);
            });

            Assert.Contains(
                "SignatureDoesNotMatch : signature does not conform to standards. server string to sign is:Error Signature",
                signatureException.Message);

            instance = MockDefaultAcsClient(400, "SignatureDoesNotMatch",
                "signature does not conform to standards. server string to sign is:this is string to sign info");

            Exception invalidException = Assert.Throws<ClientException>(() =>
            {
                var result = instance.GetAcsResponse(request, "cn-hangzhou", credentials);
            });

            Assert.Contains("SDK.InvalidAccessKeySecret : Specified Access Key Secret is not valid.",
                invalidException.Message);
        }

        [Fact]
        public void UserAgentConfigTest()
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", AKID, AKSE);
            var client = new DefaultAcsClient(profile);

            client.AppendUserAgent("test", "1.1.2");
            client.AppendUserAgent("test", "1.1.3");
            client.AppendUserAgent("mock", "1.1.2");

            var userAgent = UserAgent.Resolve(null, client.GetUserAgentConfig());
            var resultStr = UserAgent.GetDefaultMessage() + " test/1.1.3" + " mock/1.1.2";

            Assert.Equal(resultStr, userAgent);
        }
    }
}
