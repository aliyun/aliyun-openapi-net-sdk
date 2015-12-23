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
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Regions;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Core.Profile
{
    public class DefaultProfile : IClientProfile
    {

        private static DefaultProfile profile = null;
        private static List<Endpoint> endpoints = null;

        private Credential credential;
        private String regionId;
        private ISigner isigner = null;
        private IEndpointsProvider iendpoints = null;
        private ICredentialProvider icredential = null;

        private FormatType AcceptFormat { get; set; }

        private DefaultProfile()
        {
            this.iendpoints = new InternalEndpointsParser();
        }

        private DefaultProfile(String region, Credential creden)
        {
            iendpoints = new InternalEndpointsParser();
            credential = creden;
            this.regionId = region;
        }

        private DefaultProfile(ICredentialProvider icredential)
        {
            this.icredential = icredential;
            this.iendpoints = new InternalEndpointsParser();
        }

        private DefaultProfile(String region, ICredentialProvider icredential)
        {
            this.regionId = region;
            this.icredential = icredential;
            this.iendpoints = new InternalEndpointsParser();
        }

        private DefaultProfile(ICredentialProvider icredential, String region, FormatType format)
        {
            this.regionId = region;
            this.AcceptFormat = format;
            this.icredential = icredential;
            this.iendpoints = new InternalEndpointsParser();
        }

        public static DefaultProfile GetProfile()
        {
            if (null == profile)
                profile = new DefaultProfile();

            return profile;
        }

        public static DefaultProfile GetProfile(String regionId, ICredentialProvider icredential)
        {
            profile = new DefaultProfile(regionId, icredential);
            return profile;
        }

        public static DefaultProfile GetProfile(String regionId, String accessKeyId, String secret)
        {
            Credential creden = new Credential(accessKeyId, secret);
            profile = new DefaultProfile(regionId, creden);
            return profile;
        }

        public static void AddEndpoint(String endpointName, String regionId, String product, String domain)
        {
            if (null == endpoints)
            {
                endpoints = GetProfile().GetEndpoints();
            }
            Endpoint endpoint = FindEndpointByName(endpointName);
            if (null == endpoint)
            {
                AddEndpoint_(endpointName, regionId, product, domain);
            }
            else
            {
                UpdateEndpoint(regionId, product, domain, endpoint);
            }
        }

        private static void AddEndpoint_(String endpointName, String regionId, String product, String domain)
        {
            ISet<String> regions = new HashSet<String>();
            regions.Add(regionId);

            List<ProductDomain> productDomains = new List<ProductDomain>();
            productDomains.Add(new ProductDomain(product, domain));
            Endpoint endpoint = new Endpoint(endpointName, regions, productDomains);
            endpoints.Add(endpoint);
        }

        private static void UpdateEndpoint(String regionId, String product, String domain, Endpoint endpoint)
        {
            ISet<String> regionIds = endpoint.RegionIds;
            regionIds.Add(regionId);

            List<ProductDomain> productDomains = endpoint.ProductDomains;
            ProductDomain productDomain = FindProductDomain(productDomains, product);
            if (null == productDomain)
            {
                productDomains.Add(new ProductDomain(product, domain));
            }
            else
            {
                productDomain.DomianName = domain;
            }
        }

        private static Endpoint FindEndpointByName(String endpointName)
        {

            foreach (Endpoint endpoint in endpoints)
            {
                if (endpoint.Name.Equals(endpointName))
                {
                    return endpoint;
                }
            }
            return null;
        }

        private static ProductDomain FindProductDomain(List<ProductDomain> productDomains, String product)
        {
            foreach (ProductDomain productDomain in productDomains)
            {
                if (productDomain.ProductName.Equals(product))
                {
                    return productDomain;
                }
            }
            return null;
        }

        public ISigner GetSigner()
        {
            if (null == isigner)
            {
                isigner = new ShaHmac1();
            }
            return isigner;
        }

        public string GetRegionId()
        {
            return regionId;
        }

        public FormatType GetFormat()
        {
            return AcceptFormat;
        }

        public Credential GetCredential()
        {
            if (null == credential && null != icredential)
            {
                credential = icredential.Fresh();
            }
            return credential;
        }

        public List<Endpoint> GetEndpoints()
        {
            if (null == endpoints)
            {
                endpoints = iendpoints.GetEndpoints();
            }
            return endpoints;
        }
    }
}
