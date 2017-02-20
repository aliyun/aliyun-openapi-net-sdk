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
using System.Linq;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Regions;

namespace Aliyun.Acs.Core.Profile
{
    public class DefaultProfile : IClientProfile
    {
        private static DefaultProfile _profile;
        private static List<Endpoint> _endpoints;
        private readonly ICredentialProvider _icredential;
        private readonly IEndpointsProvider _iendpoints;
        private readonly string _regionId;

        private Credential _credential;
        private ISigner _isigner;

        private DefaultProfile()
        {
            _iendpoints = new InternalEndpointsParser();
        }

        private DefaultProfile(string region, Credential creden)
        {
            _iendpoints = new InternalEndpointsParser();
            _credential = creden;
            _regionId = region;
        }

        private DefaultProfile(ICredentialProvider icredential)
        {
            _icredential = icredential;
            _iendpoints = new InternalEndpointsParser();
        }

        private DefaultProfile(string region, ICredentialProvider icredential)
        {
            _regionId = region;
            _icredential = icredential;
            _iendpoints = new InternalEndpointsParser();
        }

        private DefaultProfile(ICredentialProvider icredential, string region, FormatType format)
        {
            _regionId = region;
            AcceptFormat = format;
            _icredential = icredential;
            _iendpoints = new InternalEndpointsParser();
        }

        private FormatType AcceptFormat { get; }

        public ISigner GetSigner()
        {
            return _isigner ?? (_isigner = new ShaHmac1());
        }

        public string GetRegionId()
        {
            return _regionId;
        }

        public FormatType GetFormat()
        {
            return AcceptFormat;
        }

        public Credential GetCredential()
        {
            if (null == _credential && null != _icredential)
                _credential = _icredential.Fresh();
            return _credential;
        }

        public List<Endpoint> GetEndpoints()
        {
            return _endpoints ?? (_endpoints = _iendpoints.GetEndpoints());
        }

        public static DefaultProfile GetProfile()
        {
            return _profile ?? (_profile = new DefaultProfile());
        }

        public static DefaultProfile GetProfile(string regionId, ICredentialProvider icredential)
        {
            _profile = new DefaultProfile(regionId, icredential);
            return _profile;
        }

        public static DefaultProfile GetProfile(string regionId, string accessKeyId, string secret)
        {
            var creden = new Credential(accessKeyId, secret);
            _profile = new DefaultProfile(regionId, creden);
            return _profile;
        }

        public static void AddEndpoint(string endpointName, string regionId, string product, string domain)
        {
            if (null == _endpoints)
                _endpoints = GetProfile().GetEndpoints();
            var endpoint = FindEndpointByName(endpointName);
            if (null == endpoint)
                AddEndpoint_(endpointName, regionId, product, domain);
            else
                UpdateEndpoint(regionId, product, domain, endpoint);
        }

        private static void AddEndpoint_(string endpointName, string regionId, string product, string domain)
        {
            ISet<string> regions = new HashSet<string>
            {
                regionId
            };
            var productDomains = new List<ProductDomain> {new ProductDomain(product, domain)};
            var endpoint = new Endpoint(endpointName, regions, productDomains);
            _endpoints.Add(endpoint);
        }

        private static void UpdateEndpoint(string regionId, string product, string domain, Endpoint endpoint)
        {
            var regionIds = endpoint.RegionIds;
            regionIds.Add(regionId);

            var productDomains = endpoint.ProductDomains;
            var productDomain = FindProductDomain(productDomains, product);
            if (null == productDomain)
                productDomains.Add(new ProductDomain(product, domain));
            else
                productDomain.DomianName = domain;
        }

        private static Endpoint FindEndpointByName(string endpointName)
        {
            return _endpoints.FirstOrDefault(endpoint => endpoint.Name.Equals(endpointName));
        }

        private static ProductDomain FindProductDomain(List<ProductDomain> productDomains, string product)
        {
            return productDomains.FirstOrDefault(productDomain => productDomain.ProductName.Equals(product));
        }
    }
}