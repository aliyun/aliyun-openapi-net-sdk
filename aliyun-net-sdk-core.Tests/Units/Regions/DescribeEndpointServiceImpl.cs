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

using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Regions.Location;
using Aliyun.Acs.Core.Tests.Mock;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Regions
{
    public class DescribeEndpointServiceImplTest
    {
        private string JsonSerializer<T>(T t)
        {
            var ser = new DataContractJsonSerializer(typeof(T));
            var ms = new MemoryStream();
            ser.WriteObject(ms, t);
            var jsonString = Encoding.UTF8.GetString(ms.ToArray());
            ms.Close();
            return jsonString;
        }

        [Fact]
        public void DescribeEndpoint1()
        {
            var instance = new DescribeEndpointServiceImpl();
            var credential = new Credential();
            var locationConfig = new LocationConfig();

            // When serviceCode is null or empty
            var result = instance.DescribeEndpoint(
                "regionId", null, "endpointType", credential, locationConfig
            );
            Assert.Null(result);
        }

        [Fact]
        public void DescribeEndpoint2()
        {
            var mock = new Mock<DescribeEndpointServiceImpl>();

            var response = new HttpResponse();
            var content = Encoding.GetEncoding("UTF-8").GetBytes(
                "{\"Code\":\"Success\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" +
                DateTimeMock.getNowDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = 200;
            response.Encoding = "UTF-8";

            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            var instance = mock.Object;

            var credential = new Credential();
            var locationConfig = new LocationConfig();

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

            var status = 200;

            var response = new HttpResponse();
            var content = Encoding.GetEncoding("UTF-8").GetBytes(
                "{\"Code\":\"Success\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" +
                DateTimeMock.getNowDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;
            response.Encoding = "UTF-8";

            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            var instance = mock.Object;

            var credential = new Credential();
            var locationConfig = new LocationConfig();

            var result = instance.DescribeEndpoint(
                "regionId", "serviceCode", "endpointType", credential, locationConfig
            );
            Assert.Null(result);
        }

        [Fact]
        public void DescribeEndpoint4()
        {
            var mock = new Mock<DescribeEndpointServiceImpl>();

            var status = 500;

            var response = new HttpResponse();
            var content = Encoding.GetEncoding("UTF-8").GetBytes(
                "{\"Code\":\"ServiceError\",\"Message\":\"ThisIsMessage\",\"RequestId\":\"ThisIsRequestId\",\"AccessKeyId\":\"MockAccessKeyId\",\"AccessKeySecret\":\"\",\"SecurityToken\":\"\",\"Expiration\":\"" +
                DateTimeMock.getNowDateTimeString() + "\"}");
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;
            response.Encoding = null;

            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            var instance = mock.Object;

            var credential = new Credential();
            var locationConfig = new LocationConfig();

            var result = instance.DescribeEndpoint(
                "regionId", "serviceCode", "endpointType", credential, locationConfig
            );
            Assert.Null(result);
        }

        [Fact]
        public void DescribeEndpoint5()
        {
            var mock = new Mock<DescribeEndpointServiceImpl>();

            var status = 200;

            var jsonContent =
                "{\"RequestId\":\"RequestId\",\"Endpoints\":{\"Endpoint\":[{\"Id\":\"Id\",\"Endpoint\":\"Endpoint\",\"ServiceCode\":\"ServiceCode\"},{\"Id\":\"Id\",\"Endpoint\":\"Endpoint\",\"ServiceCode\":\"ServiceCode\",\"Type\":\"endpointType\"}]}}";

            var response = new HttpResponse();
            var content = Encoding.GetEncoding("UTF-8").GetBytes(jsonContent);
            response.ContentType = FormatType.JSON;
            response.Content = content;
            response.Status = status;
            response.Encoding = null;

            mock.Setup(foo => foo.GetResponse(
                It.IsAny<HttpRequest>()
            )).Returns(response);

            var instance = mock.Object;

            var credential = new Credential();
            var locationConfig = new LocationConfig();

            var result = instance.DescribeEndpoint(
                "regionId", "serviceCode", "endpointType", credential, locationConfig
            );
            Assert.NotNull(result);
            Assert.Equal("Endpoint", result.Endpoint);
            Assert.Equal("RequestId", result.RequestId);
        }
    }
}
