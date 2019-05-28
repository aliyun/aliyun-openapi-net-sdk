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
using System.Net;
using System.Text;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Tests.Mock;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class ECSMetadataServiceCredentialsFetcherTest
    {
        [Fact]
        public void Fetch1()
        {
            // When Success
            var mock = new Mock<ECSMetadataServiceCredentialsFetcher>
                {CallBase = true};

            var response = new HttpResponse();
            var content = Encoding.GetEncoding("UTF-8").GetBytes(
                "{\"Code\":\"Success\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" +
                DateTimeMock.getNowDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;

            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            var instance = mock.Object;

            var credentials = instance.Fetch();
            ;
            Assert.Equal("MockAccessKeyId", credentials.GetAccessKeyId());
        }

        [Fact]
        public void Fetch2()
        {
            // When Request Throw Exception
            var mock = new Mock<ECSMetadataServiceCredentialsFetcher>
                {CallBase = true};

            var response = new HttpResponse();
            var content = Encoding.GetEncoding("UTF-8").GetBytes(
                "{\"Code\":\"Success\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" +
                DateTimeMock.getNowDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;

            var e = new Exception();
            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Throws(e);

            var instance = mock.Object;

            Assert.Throws<ClientException>(
                () =>
                {
                    var credentials = instance.Fetch();
                    ;
                }
            );
        }

        [Fact]
        public void Fetch3()
        {
            // When Some Data is null => Code is null
            var mock = new Mock<ECSMetadataServiceCredentialsFetcher>
                {CallBase = true};

            var response = new HttpResponse();
            var content = Encoding.GetEncoding("UTF-8").GetBytes(
                "{\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" +
                DateTimeMock.getNowDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;

            var e = new Exception();
            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            var instance = mock.Object;

            Assert.Throws<ClientException>(
                () =>
                {
                    var credentials = instance.Fetch();
                    ;
                }
            );
        }

        [Fact]
        public void Fetch4()
        {
            // When Code != "Success"
            var mock = new Mock<ECSMetadataServiceCredentialsFetcher>
                {CallBase = true};

            var response = new HttpResponse();
            var content = Encoding.GetEncoding("UTF-8").GetBytes(
                "{\"Code\":\"NotSuccess\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" +
                DateTimeMock.getNowDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;

            var e = new Exception();
            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            var instance = mock.Object;

            Assert.Throws<ClientException>(
                () =>
                {
                    var credentials = instance.Fetch();
                    ;
                }
            );
        }

        [Fact]
        public void FetchRetry()
        {
            var mock = new Mock<ECSMetadataServiceCredentialsFetcher>
                {CallBase = true};

            var e = new Exception();
            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Throws(e);

            var instance = mock.Object;

            Assert.Throws<ClientException>(
                () =>
                {
                    var credentials = instance.Fetch(3);
                }
            );

            Action retryAction = () =>
            {
                var credentials = instance.Fetch(-1);
                ;
            };
            var exception = Record.Exception(retryAction);
            Assert.Equal("Failed to connect ECS Metadata Service: Max retry times exceeded.", exception.Message);
        }

        [Fact]
        public void getInstance()
        {
            var instance = new ECSMetadataServiceCredentialsFetcher();
            Assert.IsType<ECSMetadataServiceCredentialsFetcher>(instance);
        }

        [Fact]
        public void GetMetadata1()
        {
            var mock = new Mock<ECSMetadataServiceCredentialsFetcher>
                {CallBase = true};

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

            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            var instance = mock.Object;

            var result = instance.GetMetadata();
            Assert.Equal("{\"Code\":\"ThisIsCode\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\"}",
                result);
        }

        [Fact]
        public void GetMetadata2()
        {
            var mock = new Mock<ECSMetadataServiceCredentialsFetcher>
                {CallBase = true};

            var exception = new WebException("MockWebExceptionMessage");

            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Throws(exception);

            var instance = mock.Object;

            Assert.Throws<ClientException>(
                () =>
                {
                    var result = instance.GetMetadata();
                }
            );
        }

        [Fact]
        public void GetMetadata3()
        {
            var mock = new Mock<ECSMetadataServiceCredentialsFetcher>
                {CallBase = true};

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

            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            var instance = mock.Object;

            Assert.Throws<ClientException>(
                () =>
                {
                    var result = instance.GetMetadata();
                }
            );
        }

        [Fact]
        public void Set()
        {
            var instance = new ECSMetadataServiceCredentialsFetcher();

            Assert.Throws<ArgumentNullException>(
                () => { instance.SetRoleName(""); }
            );
            instance.WithECSMetadataServiceHost("host");
            instance.WithConnectionTimeout(100);
            instance.SetRoleName("roleName");

            Assert.Equal("roleName", instance.GetRoleName());
        }
    }
}
