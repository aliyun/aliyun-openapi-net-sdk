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
    public class EndpointUserConfigTest
    {
        [Fact]
        public void TestAddEndpoint()
        {
            string productId = "product_id";
            string regionId = "region_id";
            string domain = "mock_domain";
            EndpointUserConfig.AddEndpoint(productId, regionId, domain);
            ProductDomain productDomain = EndpointUserConfig.GetProductDomain(productId, regionId);
            Assert.Equal(domain, productDomain.DomainName);
            Assert.Equal(productId, productDomain.ProductName);
        }

        [Fact]
        public void TestGetNotExistEndpoint()
        {
            ProductDomain productDomain = EndpointUserConfig.GetProductDomain("not_exist_product", "region_id");
            Assert.Null(productDomain);
        }

        [Fact]
        public void TestAddEndpointWithNullParam()
        {
            string productId = "mock_product_id";
            string regionId = "mock_region_id";
            EndpointUserConfig.AddEndpoint(productId, regionId, null);
            ProductDomain productDomain = EndpointUserConfig.GetProductDomain(productId, regionId);
            Assert.Null(productDomain);
        }
    }
}
