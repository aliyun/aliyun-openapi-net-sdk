using System;
using System.Net;
using System.Text;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Tests.Mock;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class ECSMetadataServiceCredentialsFetcherTest
    {
        [Fact]
        public void getInstance()
        {
            ECSMetadataServiceCredentialsFetcher instance = new ECSMetadataServiceCredentialsFetcher();
            Assert.IsType<ECSMetadataServiceCredentialsFetcher>(instance);
        }

        [Fact]
        public void Set()
        {
            ECSMetadataServiceCredentialsFetcher instance = new ECSMetadataServiceCredentialsFetcher();

            Assert.Throws<ArgumentNullException>(
                () =>
                {
                    instance.SetRoleName("");
                }
            );
            instance.WithECSMetadataServiceHost("host");
            instance.WithConnectionTimeout(100);
            instance.SetRoleName("roleName");

            Assert.Equal("roleName", instance.GetRoleName());
        }

        [Fact]
        public void GetMetadata1()
        {
            var mock = new Mock<ECSMetadataServiceCredentialsFetcher>() { CallBase = true };

            int status = 200;
            string code = "ThisIsCode";
            string message = "ThisIsMessage";
            string requestId = "ThisIsRequestId";

            HttpResponse response = new HttpResponse();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Code\":\"" + code + "\",\"Message\":\"" + message + "\",\"RequestId\":\"" + requestId + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;

            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            ECSMetadataServiceCredentialsFetcher instance = mock.Object;

            string result = instance.GetMetadata();
            Assert.Equal("{\"Code\":\"ThisIsCode\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\"}", result);
        }

        [Fact]
        public void GetMetadata2()
        {
            var mock = new Mock<ECSMetadataServiceCredentialsFetcher>() { CallBase = true };

            WebException exception = new WebException("MockWebExceptionMessage");

            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Throws(exception);

            ECSMetadataServiceCredentialsFetcher instance = mock.Object;

            Assert.Throws<ClientException>(
                () =>
                {
                    string result = instance.GetMetadata();
                }
            );
        }

        [Fact]
        public void GetMetadata3()
        {
            var mock = new Mock<ECSMetadataServiceCredentialsFetcher>() { CallBase = true };

            int status = 400;
            string code = "ThisIsCode";
            string message = "ThisIsMessage";
            string requestId = "ThisIsRequestId";

            HttpResponse response = new HttpResponse();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Code\":\"" + code + "\",\"Message\":\"" + message + "\",\"RequestId\":\"" + requestId + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;

            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            ECSMetadataServiceCredentialsFetcher instance = mock.Object;

            Assert.Throws<ClientException>(
                () =>
                {
                    string result = instance.GetMetadata();
                }
            );
        }

        [Fact]
        public void Fetch1()
        {
            // When Success
            var mock = new Mock<ECSMetadataServiceCredentialsFetcher>() { CallBase = true };

            HttpResponse response = new HttpResponse();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Code\":\"Success\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" + DateTimeMock.getNowDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;

            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            ECSMetadataServiceCredentialsFetcher instance = mock.Object;

            EcsRamRoleCredential credentials = instance.Fetch();
            ;
            Assert.Equal("MockAccessKeyId", credentials.GetAccessKeyId());
        }

        [Fact]
        public void Fetch2()
        {
            // When Request Throw Exception
            var mock = new Mock<ECSMetadataServiceCredentialsFetcher>() { CallBase = true };

            HttpResponse response = new HttpResponse();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Code\":\"Success\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" + DateTimeMock.getNowDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;

            Exception e = new Exception();
            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Throws(e);

            ECSMetadataServiceCredentialsFetcher instance = mock.Object;

            Assert.Throws<ClientException>(
                () =>
                {
                    EcsRamRoleCredential credentials = instance.Fetch();
                    ;
                }
            );
        }

        [Fact]
        public void Fetch3()
        {
            // When Some Data is null => Code is null
            var mock = new Mock<ECSMetadataServiceCredentialsFetcher>() { CallBase = true };

            HttpResponse response = new HttpResponse();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" + DateTimeMock.getNowDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;

            Exception e = new Exception();
            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            ECSMetadataServiceCredentialsFetcher instance = mock.Object;

            Assert.Throws<ClientException>(
                () =>
                {
                    EcsRamRoleCredential credentials = instance.Fetch();
                    ;
                }
            );
        }

        [Fact]
        public void Fetch4()
        {
            // When Code != "Success"
            var mock = new Mock<ECSMetadataServiceCredentialsFetcher>() { CallBase = true };

            HttpResponse response = new HttpResponse();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Code\":\"NotSuccess\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" + DateTimeMock.getNowDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;

            Exception e = new Exception();
            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            ECSMetadataServiceCredentialsFetcher instance = mock.Object;

            Assert.Throws<ClientException>(
                () =>
                {
                    EcsRamRoleCredential credentials = instance.Fetch();
                    ;
                }
            );
        }

        [Fact]
        public void FetchRetry()
        {
            var mock = new Mock<ECSMetadataServiceCredentialsFetcher>() { CallBase = true };

            Exception e = new Exception();
            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Throws(e);

            ECSMetadataServiceCredentialsFetcher instance = mock.Object;

            Assert.Throws<ClientException>(
                () =>
                {
                    EcsRamRoleCredential credentials = instance.Fetch(3);
                }
            );

            Action retryAction = () =>
            {
                EcsRamRoleCredential credentials = instance.Fetch(-1);
                ;
            };
            var exception = Record.Exception(retryAction);
            Assert.Equal("Failed to connect ECS Metadata Service: Max retry times exceeded.", exception.Message);
        }
    }
}
