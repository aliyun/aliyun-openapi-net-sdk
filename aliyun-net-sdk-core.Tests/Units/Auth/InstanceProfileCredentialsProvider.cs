using System;
using System.Reflection;
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
            HttpResponse response = new HttpResponse();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Code\":\"Success\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" + DateTimeMock.getNotExpiredDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;

            // Mock Credentials
            var mockCredentials = new Mock<InstanceProfileCredentials>("MockAccessKeyId", "MockAccessKeySecret", "MockSecurityToken", DateTimeMock.getNotExpiredDateTimeString(), 100000) { CallBase = true };
            mockCredentials.Setup(foo => foo.RemainTicks()).Returns(15 * 1000 * 1000 * 10);
            InstanceProfileCredentials instanceProfileCredentials = mockCredentials.Object;

            // Mock Fetcher
            var mockFetcher = new Mock<ECSMetadataServiceCredentialsFetcher>() { CallBase = true };
            mockFetcher.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);
            mockFetcher.Setup(foo => foo.Fetch()).Returns(instanceProfileCredentials);
            ECSMetadataServiceCredentialsFetcher fetcher = mockFetcher.Object;

            string roleName = ACKMock.GetRoleName(true);
            InstanceProfileCredentialsProvider instance = new InstanceProfileCredentialsProvider(roleName);
            instance.withFetcher(fetcher);
            AlibabaCloudCredentialsProvider provider = instance;

            AlibabaCloudCredentials credentials = provider.GetCredentials();
            Assert.Equal("MockAccessKeyId", credentials.GetAccessKeyId());
        }

        [Fact]
        public void GetCredentials2()
        {
            // When Credentials is Expired

            // Mock Response
            HttpResponse response = new HttpResponse();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Code\":\"Success\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" + DateTimeMock.getExpiredDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;

            // Mock Fetcher
            var mockFetcher = new Mock<ECSMetadataServiceCredentialsFetcher>() { CallBase = true };
            mockFetcher.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);
            ECSMetadataServiceCredentialsFetcher fetcher = mockFetcher.Object;

            string roleName = ACKMock.GetRoleName(true);
            InstanceProfileCredentialsProvider instance = new InstanceProfileCredentialsProvider(roleName);
            AlibabaCloudCredentialsProvider provider = instance;
            instance.withFetcher(fetcher);

            Assert.Throws<ClientException>(() =>
            {
                AlibabaCloudCredentials credentials = provider.GetCredentials(); // 进行有效期判断，已失效则抛出异常
            });
        }

        [Fact]
        public void GetCredentials3()
        {
            // When Credentials will Expired

            // Mock Response
            HttpResponse response = new HttpResponse();
            string ExpiredDatetime = DateTime.Now.AddMilliseconds(800).ToString();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Code\":\"Success\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" + ExpiredDatetime + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;

            // Mock Credentials
            var mockCredentials = new Mock<InstanceProfileCredentials>("MockAccessKeyId", "", "", ExpiredDatetime, 100000) { CallBase = true };
            mockCredentials.Setup(foo => foo.RemainTicks()).Returns(15 * 1000 * 1000 * 10);
            InstanceProfileCredentials instanceProfileCredentials = mockCredentials.Object;

            // Mock Fetcher
            var mockFetcher = new Mock<ECSMetadataServiceCredentialsFetcher>() { CallBase = true };
            mockFetcher.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);
            mockFetcher.Setup(foo => foo.Fetch()).Returns(instanceProfileCredentials);
            ECSMetadataServiceCredentialsFetcher fetcher = mockFetcher.Object;

            string roleName = ACKMock.GetRoleName(true);
            InstanceProfileCredentialsProvider instance = new InstanceProfileCredentialsProvider(roleName);
            AlibabaCloudCredentialsProvider provider = instance;
            instance.withFetcher(fetcher);
            AlibabaCloudCredentials credentials = provider.GetCredentials(); // 进行有效期判断，即将失效则刷新有效时间

            // When Fetcher throw ClientException
            mockFetcher = new Mock<ECSMetadataServiceCredentialsFetcher>() { CallBase = true };
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
            HttpResponse response = new HttpResponse();
            string ExpiredDatetime = DateTime.Now.AddMilliseconds(800).ToString();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Code\":\"Success\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" + ExpiredDatetime + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;

            // Mock Credentials
            var mockCredentials = new Mock<InstanceProfileCredentials>("MockAccessKeyId", "", "", ExpiredDatetime, 100000) { CallBase = true };
            mockCredentials.Setup(foo => foo.RemainTicks()).Returns(15 * 1000 * 1000 * 10);
            InstanceProfileCredentials instanceProfileCredentials = mockCredentials.Object;
            instanceProfileCredentials.SetLastFailedRefreshTime();

            // Mock Fetcher
            var mockFetcher = new Mock<ECSMetadataServiceCredentialsFetcher>() { CallBase = true };
            mockFetcher.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);
            mockFetcher.Setup(foo => foo.Fetch()).Returns(instanceProfileCredentials);
            ECSMetadataServiceCredentialsFetcher fetcher = mockFetcher.Object;

            string roleName = ACKMock.GetRoleName(true);
            InstanceProfileCredentialsProvider instance = new InstanceProfileCredentialsProvider(roleName);
            AlibabaCloudCredentialsProvider provider = instance;
            instance.withFetcher(fetcher);

            //  Credentials will Expired at first. No Throw Exception (15000 >= 10000)
            AlibabaCloudCredentials credentials = provider.GetCredentials();
            Assert.Equal("MockAccessKeyId", credentials.GetAccessKeyId());

            //  Credentials will Expired at Second. Throws Exception  (5000 < 10000)
            mockCredentials.Setup(foo => foo.RemainTicks()).Returns(5000);
            instanceProfileCredentials = mockCredentials.Object;
            instanceProfileCredentials.SetLastFailedRefreshTime();
            mockFetcher.Setup(foo => foo.Fetch()).Returns(instanceProfileCredentials);
            fetcher = mockFetcher.Object;
            instance.withFetcher(fetcher);

            Assert.Throws<ClientException>(() =>
            {
                credentials = provider.GetCredentials();
            });
        }

        [Fact]
        public void withFetcher()
        {
            string roleName = ACKMock.GetRoleName(true);
            InstanceProfileCredentialsProvider instance = new InstanceProfileCredentialsProvider(roleName);
            ECSMetadataServiceCredentialsFetcher fetcher = new ECSMetadataServiceCredentialsFetcher();

            instance.withFetcher(fetcher);
        }
    }
}
