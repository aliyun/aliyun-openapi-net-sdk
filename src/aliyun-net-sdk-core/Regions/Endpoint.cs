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
using Aliyun.Acs.Core.Regions.Location.Model;

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

        public string Name { get; set; }
        public ISet<string> RegionIds { get; set; }
        public List<ProductDomain> ProductDomains { get; set; }

        public static ProductDomain FindProductDomain(string regionId, string product,
            List<Endpoint> endpoints, IAcsClient acsClient)
        {
            if (null == regionId || null == product || null == endpoints)
                return null;
            foreach (var endpoint in endpoints)
                if (endpoint.RegionIds.Contains(regionId))
                {
                    var domain = FindProductDomainByProduct(endpoint.ProductDomains, product);
                    return domain;
                }
            if ("Location".Equals(product))
                return new ProductDomain("Location", "location.aliyuncs.com");
            return GetEndpointByLocation(regionId, product, endpoints, acsClient);
        }

        private static ProductDomain FindProductDomainByProduct(List<ProductDomain> productDomains, string product)
        {
            if (null == productDomains)
                return null;
            foreach (var productDomain in productDomains)
                if (product.Equals(productDomain.ProductName))
                    return productDomain;
            return null;
        }

        private static ProductDomain GetEndpointByLocation(string regionId, string product,
            List<Endpoint> endpoints, IAcsClient acsClient)
        {
            var productDomain = GetProductDomainByLocation(regionId, product, acsClient);

            foreach (var endpoint in endpoints)
                if (endpoint.RegionIds.Contains(regionId))
                {
                    endpoint.ProductDomains.Add(productDomain);
                    return productDomain;
                }

            ISet<string> regionIds = new HashSet<string>();
            regionIds.Add(regionId);
            var productDomains = new List<ProductDomain>
            {
                productDomain
            };

            endpoints.Add(new Endpoint(regionId, regionIds, productDomains));
            return productDomain;
        }

        private static ProductDomain GetProductDomainByLocation(string regionId,
            string product, IAcsClient acsClient)
        {
            var describeEndpointRequest = new DescribeEndpointRequest
            {
                RegionId = regionId
            };
            describeEndpointRequest.SetService(product.ToLower());
            //DescribeEndpointResponse describeEndpointResponse = acsClient.getAcsResponse(describeEndpointRequest);
            //ProductDomain productDomain = new ProductDomain(product, describeEndpointResponse.Endpoint);
            //return productDomain;
            return null;
        }
    }
}