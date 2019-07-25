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

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Regions.Location;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Regions
{
    public class InternalEndpointsParserTest
    {
        [Fact]
        public void GetEndpoint1()
        {
            // Not Supported Action
            var instance = new InternalEndpointsParser();

            Assert.Throws<NotSupportedException>(
                () =>
                {
                    var credential = new Credential();
                    var locationConfig = new LocationConfig();
                    instance.GetEndpoint("", "", "", "", credential, locationConfig);
                }
            );
        }

        [Fact]
        public void GetEndpoint2()
        {
            // When Product List is empty

            // Mock Product List
            var productList = new List<InternalEndpointsParser.Product>();

            // Mock InternalEndpointsParser
            var mockInstance = new Mock<InternalEndpointsParser>();
            var instance = mockInstance.Object;

            var result = instance.GetEndpoint("regionIdKey", "ProductCode");
            Assert.Null(result);
        }

        [Fact]
        public void TestCreateProduct()
        {
            var product = new InternalEndpointsParser.Product()
            {
                Code = "ecs",
                LocationServiceCode = "ecs",
                DocumentId = "12546",
                RegionalEndpoints = new Dictionary<string, string>(),
                GlobalEndpoint = "test.aliyuncs.com",
                RegionalEndpointPattern = "[a-zA-Z0-9].aliyuncs.com"
            };
        }
    }
}
