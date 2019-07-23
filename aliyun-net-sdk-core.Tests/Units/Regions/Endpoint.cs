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

using System.Collections.Generic;

using Aliyun.Acs.Core.Regions;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Regions
{
    public class EndpointTest
    {
        [Fact]
        public void FindProductDomain1()
        {
            // endpoints is null
            List<Endpoint> endpoints = null;
            var result = Endpoint.FindProductDomain("regionId", "productName", endpoints);
            Assert.Null(result);
        }

        [Fact]
        public void FindProductDomain2()
        {
            // endpoints is not null , but empty
            var endpoints = new List<Endpoint>();
            var result = Endpoint.FindProductDomain("regionId", "productName", endpoints);
            Assert.Null(result);
        }

        [Fact]
        public void FindProductDomain3()
        {
            // endpoints is not null and not empty
            // regionIds is empty
            // productDomains is null
            var endpoints = new List<Endpoint>();
            ISet<string> regionIds = new HashSet<string>();
            var endpoint = new Endpoint("endpointName", regionIds, null);
            endpoints.Add(endpoint);
            var result = Endpoint.FindProductDomain("regionId", "productName", endpoints);
            Assert.Null(result);
        }

        [Fact]
        public void FindProductDomain4()
        {
            // endpoints is not null and not empty
            // regionIds is not empty
            // productDomains is null
            var endpoints = new List<Endpoint>();
            ISet<string> regionIds = new HashSet<string>();
            regionIds.Add("regionId");

            List<ProductDomain> productDomains = null;

            var endpoint = new Endpoint("endpointName", regionIds, productDomains);
            endpoints.Add(endpoint);

            var result = Endpoint.FindProductDomain("regionId", "productName", endpoints);
            Assert.Null(result);
        }

        [Fact]
        public void FindProductDomain5()
        {
            // endpoints is not null and not empty
            // regionIds is not empty
            // productDomains is not null but empty
            var endpoints = new List<Endpoint>();
            ISet<string> regionIds = new HashSet<string>();
            regionIds.Add("regionId");

            var productDomains = new List<ProductDomain>();

            var endpoint = new Endpoint("endpointName", regionIds, productDomains);
            endpoints.Add(endpoint);

            var result = Endpoint.FindProductDomain("regionId", "productName", endpoints);
            Assert.Null(result);
        }

        [Fact]
        public void FindProductDomain6()
        {
            // endpoints is not null and not empty
            // regionIds is not empty
            // productDomains is not empty
            var endpoints = new List<Endpoint>();
            ISet<string> regionIds = new HashSet<string>();
            regionIds.Add("regionId");

            var productDomains = new List<ProductDomain>();
            var productDomain = new ProductDomain("productName", "productDomain");
            productDomains.Add(productDomain);

            var endpoint = new Endpoint("endpointName", regionIds, productDomains);
            endpoints.Add(endpoint);

            // productName id not exist
            var result = Endpoint.FindProductDomain("regionId", "notExistProductName", endpoints);
            Assert.Null(result);

            // productName id exist
            result = Endpoint.FindProductDomain("regionId", "productName", endpoints);
            Assert.NotNull(result);
            Assert.Equal("productDomain", result.DomainName);
        }

        [Fact]
        public void Instance()
        {
            var endpoint = new Endpoint("endpointName", null, null);
            Assert.Equal("endpointName", endpoint.Name);
            Assert.Null(endpoint.RegionIds);
            Assert.Null(endpoint.ProductDomains);
        }
    }
}
