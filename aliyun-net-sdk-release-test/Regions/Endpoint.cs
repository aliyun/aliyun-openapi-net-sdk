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
using Aliyun.Acs.Core.Regions.Location.Model;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Core.Regions
{
    public class Endpoint
    {
        public string Name { get; set; }
        public ISet<string> RegionIds { get; set; }
        public List<ProductDomain> ProductDomains { get; set; }

        public Endpoint(String name, ISet<string> regionIds, List<ProductDomain> productDomains)
        {
            this.Name = name;
            this.RegionIds = regionIds;
            this.ProductDomains = productDomains;
        }

        public static ProductDomain FindProductDomain(String regionId, String product,
                List<Endpoint> endpoints, IAcsClient acsClient)
        {
            if (null == regionId || null == product || null == endpoints)
            {
                return null;
            }
            foreach (Endpoint endpoint in endpoints)
            {
                if (endpoint.RegionIds.Contains(regionId))
                {
                    ProductDomain domain = FindProductDomainByProduct(endpoint.ProductDomains, product);
                    return domain;
                }
            }
            if ("Location".Equals(product))
            {
                return new ProductDomain("Location", "location.aliyuncs.com");
            }
            return null;
        }

        private static ProductDomain FindProductDomainByProduct(List<ProductDomain> productDomains, String product)
        {
            if (null == productDomains)
            {
                return null;
            }
            foreach (ProductDomain productDomain in productDomains)
            {
                if (product.Equals(productDomain.ProductName))
                {
                    return productDomain;
                }
            }
            return null;
        }
    }
}
