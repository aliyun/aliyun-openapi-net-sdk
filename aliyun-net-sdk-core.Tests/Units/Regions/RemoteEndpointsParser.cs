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

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Regions.Location;
using Aliyun.Acs.Core.Regions.Location.Model;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Regions
{
    public class RemoteEndpointsParserTest
    {
        [Fact]
        public void GetEndpoint()
        {
            var instance = new RemoteEndpointsParser();

            Assert.Throws<NotSupportedException>(
                () => { instance.GetEndpoint("", ""); }
            );
        }

        [Fact]
        public void GetEndpointWhenResponseIsNotNull()
        {
            var response = new DescribeEndpointResponse();
            response.RegionId = "RegionId";
            response.Endpoint = "Endpoint";

            var mock = new Mock<DescribeEndpointService>();

            mock.Setup(foo => foo.DescribeEndpoint(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<Credential>(),
                It.IsAny<LocationConfig>()
            )).Returns(response);

            var instance = new RemoteEndpointsParser();

            var credential = new Credential();
            var locationConfig = new LocationConfig();
            var result = instance.GetEndpoint("regionId", "product", "serviceCode", "endpointType", credential,
                locationConfig);

            Assert.Null(result);
        }

        [Fact]
        public void GetEndpointWhenResponseIsNull()
        {
            DescribeEndpointResponse response = null;

            var mock = new Mock<DescribeEndpointService>();
            // String regionId, String serviceCode, String endpointType,Credential credential,LocationConfig locationConfig
            mock.Setup(foo => foo.DescribeEndpoint(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<Credential>(),
                It.IsAny<LocationConfig>()
            )).Returns(response);

            var describeEndpointService = mock.Object;
            var instance = new RemoteEndpointsParser();

            var credential = new Credential();
            var locationConfig = new LocationConfig();
            var result = instance.GetEndpoint("regionId", "product", "serviceCode", "endpointType", credential,
                locationConfig);
            Assert.Null(result);
        }

        [Fact]
        public void GetEndpointWhenServiceCodeIsNull()
        {
            var instance = new RemoteEndpointsParser();
            var credential = new Credential();
            var locationConfig = new LocationConfig();
            var result = instance.GetEndpoint("regionId", "product", null, "endpointType", credential, locationConfig);
            Assert.Null(result);
        }
    }
}
