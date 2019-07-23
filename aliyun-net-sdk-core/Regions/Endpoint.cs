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

namespace Aliyun.Acs.Core.Regions
{
    public class Endpoint
    {
        public Endpoint(string name, ISet<string> regionIds, List<ProductDomain> productDomains)
        {
            Name = name;
            RegionIds = regionIds;
            ProductDomains = productDomains;
        }

        public string Name { get; private set; }
        public ISet<string> RegionIds { get; private set; }
        public List<ProductDomain> ProductDomains { get; private set; }

        public static ProductDomain FindProductDomain(string regionId, string product, List<Endpoint> endpoints)
        {
            if (null == regionId || null == product || null == endpoints)
            {
                return null;
            }

            foreach (var endpoint in endpoints)
            {
                if (endpoint.RegionIds.Contains(regionId))
                {
                    var domain = FindProductDomainByProduct(endpoint.ProductDomains, product);
                    return domain;
                }
            }

            return null;
        }

        private static ProductDomain FindProductDomainByProduct(List<ProductDomain> productDomains, string product)
        {
            if (null == productDomains)
            {
                return null;
            }

            foreach (var productDomain in productDomains)
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
