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

using Aliyun.Acs.Core.Regions.Location;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Regions.Location
{
    public class LocationConfigTest
    {
        [Fact]
        public void createLocationConfig()
        {
            var instance = LocationConfig.createLocationConfig("RegionId", "Product", "Endpoint");
            Assert.IsType<LocationConfig>(instance);
            Assert.Equal("RegionId", instance.RegionId);
            Assert.Equal("Product", instance.Product);
            Assert.Equal("Endpoint", instance.Endpoint);
        }

        [Fact]
        public void Endpoint()
        {
            var instance = LocationConfig.createLocationConfig("RegionId", "Product", "Endpoint");
            instance.Endpoint = "setEndpoint";
            Assert.Equal("setEndpoint", instance.Endpoint);
        }

        [Fact]
        public void Product()
        {
            var instance = LocationConfig.createLocationConfig("RegionId", "Product", "Endpoint");
            instance.Product = "setProduct";
            Assert.Equal("setProduct", instance.Product);
        }

        [Fact]
        public void RegionId()
        {
            var instance = LocationConfig.createLocationConfig("RegionId", "Product", "Endpoint");
            instance.RegionId = "setRegionId";
            Assert.Equal("setRegionId", instance.RegionId);
        }
    }
}
