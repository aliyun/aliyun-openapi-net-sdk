using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Reader;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Regions.Location;
using Aliyun.Acs.Core.Regions.Location.Model;
using Aliyun.Acs.Core.Tests.Mock;
using Aliyun.Acs.Core.Transform;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Regions
{
    public class DescribeEndpointServiceImplTest
    {
        [Fact]
        public void DescribeEndpoint1()
        {
            DescribeEndpointServiceImpl instance = new DescribeEndpointServiceImpl();
            Credential credential = new Credential();
            LocationConfig locationConfig = new LocationConfig();

            // When serviceCode is null or empty
            var result = instance.DescribeEndpoint(
                "regionId", null, "endpointType", credential, locationConfig
            );
            Assert.Null(result);
        }

        [Fact]
        public void DescribeEndpoint2()
        {
            DescribeEndpointServiceImpl instance = new DescribeEndpointServiceImpl();
            Credential credential = new Credential();
            LocationConfig locationConfig = new LocationConfig();

            // When endpointType is null or empty
            var result = instance.DescribeEndpoint(
                "regionId", "serviceCode", null, credential, locationConfig
            );
            Assert.Null(result);
        }

        [Fact]
        public void DescribeEndpoint3()
        {
            var mock = new Mock<DescribeEndpointServiceImpl>();

            int status = 200;

            HttpResponse response = new HttpResponse();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Code\":\"Success\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" + DateTimeMock.getNowDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;
            response.Encoding = "UTF-8";

            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            DescribeEndpointServiceImpl instance = mock.Object;

            Credential credential = new Credential();
            LocationConfig locationConfig = new LocationConfig();

            var result = instance.DescribeEndpoint(
                "regionId", "serviceCode", "endpointType", credential, locationConfig
            );
            Assert.Null(result);
        }

        [Fact]
        public void DescribeEndpoint4()
        {
            var mock = new Mock<DescribeEndpointServiceImpl>();

            int status = 500;

            HttpResponse response = new HttpResponse();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes("{\"Code\":\"ServiceError\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" + DateTimeMock.getNowDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;
            response.Encoding = null;

            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            DescribeEndpointServiceImpl instance = mock.Object;

            Credential credential = new Credential();
            LocationConfig locationConfig = new LocationConfig();

            var result = instance.DescribeEndpoint(
                "regionId", "serviceCode", "endpointType", credential, locationConfig
            );
            Assert.Null(result);
        }

        [Fact]
        public void DescribeEndpoint5()
        {
            var mock = new Mock<DescribeEndpointServiceImpl>();

            int status = 200;

            string jsonContent = "{\"RequestId\":\"RequestId\",\"Endpoints\":{\"Endpoint\":[{\"Id\":\"Id\",\"Endpoint\":\"Endpoint\",\"ServiceCode\":\"ServiceCode\"},{\"Id\":\"Id\",\"Endpoint\":\"Endpoint\",\"ServiceCode\":\"ServiceCode\",\"Type\":\"endpointType\"}]}}";

            HttpResponse response = new HttpResponse();
            byte[] content = Encoding.GetEncoding("UTF-8").GetBytes(jsonContent);
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;
            response.Encoding = null;

            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            DescribeEndpointServiceImpl instance = mock.Object;

            Credential credential = new Credential();
            LocationConfig locationConfig = new LocationConfig();

            var result = instance.DescribeEndpoint(
                "regionId", "serviceCode", "endpointType", credential, locationConfig
            );
            Assert.NotNull(result);
            Assert.Equal("Endpoint", result.Endpoint);
            Assert.Equal("RequestId", result.RequestId);
        }

        private string JsonSerializer<T>(T t)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            ser.WriteObject(ms, t);
            string jsonString = Encoding.UTF8.GetString(ms.ToArray());
            ms.Close();
            return jsonString;
        }
    }
}
