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
using System.Text;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Tests.Mock;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class InstanceProfileCredentialsProviderTest
    {
        [Fact]
        public void GetCredentials1()
        {
            // When Success Get Credentials

            // Mock Response
            var response = new HttpResponse();
            var content = Encoding.GetEncoding("UTF-8").GetBytes(
                "{\"Code\":\"Success\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" +
                DateTimeMock.getNotExpiredDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;

            // Mock Credentials
            var mockCredentials = new Mock<InstanceProfileCredentials>("MockAccessKeyId", "MockAccessKeySecret",
                "MockSecurityToken", DateTimeMock.getNotExpiredDateTimeString(), 100000) { CallBase = true };
            mockCredentials.Setup(foo => foo.RemainTicks()).Returns(15 * 1000 * 1000 * 10);
            var instanceProfileCredentials = mockCredentials.Object;

            // Mock Fetcher
            var mockFetcher = new Mock<ECSMetadataServiceCredentialsFetcher> { CallBase = true };
            mockFetcher.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);
            mockFetcher.Setup(foo => foo.Fetch()).Returns(instanceProfileCredentials);
            var fetcher = mockFetcher.Object;

            var roleName = ACKMock.GetRoleName(true);
            var instance = new InstanceProfileCredentialsProvider(roleName);
            instance.withFetcher(fetcher);
            AlibabaCloudCredentialsProvider provider = instance;

            var credentials = provider.GetCredentials();
            Assert.Equal("MockAccessKeyId", credentials.GetAccessKeyId());
        }

        [Fact]
        public void GetCredentials2()
        {
            // When Credentials is Expired

            // Mock Response
            var response = new HttpResponse();
            var content = Encoding.GetEncoding("UTF-8").GetBytes(
                "{\"Code\":\"Success\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" +
                DateTimeMock.getExpiredDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;

            // Mock Fetcher
            var mockFetcher = new Mock<ECSMetadataServiceCredentialsFetcher> { CallBase = true };
            mockFetcher.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);
            var fetcher = mockFetcher.Object;

            var roleName = ACKMock.GetRoleName(true);
            var instance = new InstanceProfileCredentialsProvider(roleName);
            AlibabaCloudCredentialsProvider provider = instance;
            instance.withFetcher(fetcher);

            // Throw exception if the date is invalid
            Assert.Throws<ClientException>(() =>
            {
                var credentials = provider.GetCredentials();
            });
        }

        [Fact]
        public void GetCredentials3()
        {
            // When Credentials will Expired

            // Mock Response
            var response = new HttpResponse();
            var ExpiredDatetime = DateTime.UtcNow.AddMilliseconds(800).ToString();
            var content = Encoding.GetEncoding("UTF-8").GetBytes(
                "{\"Code\":\"Success\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" +
                ExpiredDatetime + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;

            // Mock Credentials
            var mockCredentials =
                new Mock<InstanceProfileCredentials>("MockAccessKeyId", "", "", ExpiredDatetime, 100000) { CallBase = true };
            mockCredentials.Setup(foo => foo.RemainTicks()).Returns(15 * 1000 * 1000 * 10);
            var instanceProfileCredentials = mockCredentials.Object;

            // Mock Fetcher
            var mockFetcher = new Mock<ECSMetadataServiceCredentialsFetcher> { CallBase = true };
            mockFetcher.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);
            mockFetcher.Setup(foo => foo.Fetch()).Returns(instanceProfileCredentials);
            var fetcher = mockFetcher.Object;

            var roleName = ACKMock.GetRoleName(true);
            var instance = new InstanceProfileCredentialsProvider(roleName);
            AlibabaCloudCredentialsProvider provider = instance;
            instance.withFetcher(fetcher);

            // Throw exception if the date is invalid
            var credentials = provider.GetCredentials();

            // When Fetcher throw ClientException
            mockFetcher = new Mock<ECSMetadataServiceCredentialsFetcher> { CallBase = true };
            var ex = new ClientException("MockClientExceptionCode", "MockClinetExceptionMessage");
            mockFetcher.Setup(foo => foo.Fetch()).Throws(ex);
            fetcher = mockFetcher.Object;
            instance.withFetcher(fetcher);

            credentials = provider.GetCredentials();
            Assert.Equal("MockAccessKeyId", credentials.GetAccessKeyId());
        }

        [Fact]
        public void GetCredentials4()
        {
            // When Credentials will Expired

            // Mock Response
            var response = new HttpResponse();
            var ExpiredDatetime = DateTime.UtcNow.AddMilliseconds(800).ToString();
            var content = Encoding.GetEncoding("UTF-8").GetBytes(
                "{\"Code\":\"Success\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" +
                ExpiredDatetime + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;

            // Mock Credentials
            var mockCredentials =
                new Mock<InstanceProfileCredentials>("MockAccessKeyId", "", "", ExpiredDatetime, 100000) { CallBase = true };
            mockCredentials.Setup(foo => foo.RemainTicks()).Returns(15 * 1000 * 1000 * 10);
            var instanceProfileCredentials = mockCredentials.Object;
            instanceProfileCredentials.SetLastFailedRefreshTime();

            // Mock Fetcher
            var mockFetcher = new Mock<ECSMetadataServiceCredentialsFetcher> { CallBase = true };
            mockFetcher.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);
            mockFetcher.Setup(foo => foo.Fetch()).Returns(instanceProfileCredentials);
            var fetcher = mockFetcher.Object;

            var roleName = ACKMock.GetRoleName(true);
            var instance = new InstanceProfileCredentialsProvider(roleName);
            AlibabaCloudCredentialsProvider provider = instance;
            instance.withFetcher(fetcher);

            // Credentials will Expired at first. No Throw Exception (15000 >= 10000)
            var credentials = provider.GetCredentials();
            Assert.Equal("MockAccessKeyId", credentials.GetAccessKeyId());

            // Credentials will Expired at Second. Throws Exception  (5000 < 10000)
            mockCredentials.Setup(foo => foo.RemainTicks()).Returns(5000);
            instanceProfileCredentials = mockCredentials.Object;
            instanceProfileCredentials.SetLastFailedRefreshTime();
            mockFetcher.Setup(foo => foo.Fetch()).Returns(instanceProfileCredentials);
            fetcher = mockFetcher.Object;
            instance.withFetcher(fetcher);

            Assert.Throws<ClientException>(() => { credentials = provider.GetCredentials(); });
        }

        [Fact]
        public void withFetcher()
        {
            var roleName = ACKMock.GetRoleName(true);
            var instance = new InstanceProfileCredentialsProvider(roleName);
            var fetcher = new ECSMetadataServiceCredentialsFetcher();

            instance.withFetcher(fetcher);
        }
    }
}
