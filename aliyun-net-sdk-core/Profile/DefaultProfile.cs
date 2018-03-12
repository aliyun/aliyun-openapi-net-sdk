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
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Regions.Location;
using Aliyun.Acs.Core.Utils;
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
        private IEndpointsProvider iendpoints = null;
        private ICredentialProvider icredential = null;
        private RemoteEndpointsParser remoteProvider = null;
        private LocationConfig locationConfig = null;
        private FormatType acceptFormat;

        private DefaultProfile()
        {
            this.locationConfig = new LocationConfig();
            this.iendpoints = new InternalEndpointsParser();
            this.remoteProvider = RemoteEndpointsParser.InitRemoteEndpointsParser();
        }

        private DefaultProfile(String regionId)
        {
            this.locationConfig = new LocationConfig();
            this.iendpoints = new InternalEndpointsParser();
            this.remoteProvider = RemoteEndpointsParser.InitRemoteEndpointsParser();
            this.regionId = regionId;
        }

        private DefaultProfile(String region, Credential creden)
        {
            iendpoints = new InternalEndpointsParser();
            this.remoteProvider = RemoteEndpointsParser.InitRemoteEndpointsParser();
            credential = creden;
            this.regionId = region;
            this.locationConfig = new LocationConfig();
        }

        private DefaultProfile(String region, Credential creden, IEndpointsProvider provider)
        {
            this.iendpoints = provider;
            this.credential = creden;
            this.regionId = region;
            this.locationConfig = new LocationConfig();
            this.remoteProvider = RemoteEndpointsParser.InitRemoteEndpointsParser();
        }

        private DefaultProfile(ICredentialProvider icredential)
        {
            this.icredential = icredential;
            this.iendpoints = new InternalEndpointsParser();
            this.remoteProvider = RemoteEndpointsParser.InitRemoteEndpointsParser();
            this.locationConfig = new LocationConfig();
        }

        private DefaultProfile(String region, ICredentialProvider icredential)
        {
            this.iendpoints = new InternalEndpointsParser();
            this.icredential = icredential;
            this.regionId = region;
            this.locationConfig = new LocationConfig();
            this.remoteProvider = RemoteEndpointsParser.InitRemoteEndpointsParser();
        }

        private DefaultProfile(ICredentialProvider icredential, String region, FormatType format)
        {
            this.regionId = region;
            this.acceptFormat = format;
            this.icredential = icredential;
            this.iendpoints = new InternalEndpointsParser();
            this.remoteProvider = RemoteEndpointsParser.InitRemoteEndpointsParser();
            this.locationConfig = new LocationConfig();
        }

        public string GetRegionId()
        {
            return regionId;
        }

        public FormatType GetFormat()
        {
            return acceptFormat;
        }

        public Credential GetCredential()
        {
            if (null == credential && null != icredential)
            {
                credential = icredential.Fresh();
            }
            return credential;
        }

        [Obsolete]
        public ISigner GetSigner()
        {
            return null;
        }

        public void SetLocationConfig(String regionId, String product, String endpoint)
        {
            this.locationConfig = LocationConfig.createLocationConfig(regionId, product, endpoint);
        }

        public List<Endpoint> GetEndpoints(String regionId, String product)
        {
            if (null == endpoints)
            {
                Endpoint endpoint = iendpoints.GetEndpoint(regionId, product);
                if (endpoint != null)
                {
                    endpoints = new List<Endpoint>();
                    endpoints.Add(endpoint);
                }
            }
            return endpoints;
        }

        public List<Endpoint> GetEndpoints(String product, String regionId, String serviceCode, String endpointType)
        {
            if (product == null)
                return endpoints;

            if (null == endpoints)
            {
                Endpoint endpoint = null;
                if (serviceCode != null)
                {
                    endpoint = remoteProvider.GetEndpoint(regionId, product, serviceCode, endpointType, credential, locationConfig);
                }
                if (endpoint == null)
                {
                    endpoint = iendpoints.GetEndpoint(regionId, product);
                }
                if (endpoint != null)
                {
                    endpoints = new List<Endpoint>();
                    endpoints.Add(endpoint);
                    CacheTimeHelper.AddLastClearTimePerProduct(product, regionId, DateTime.Now);
                }
                else
                {
                    throw new ClientException("SDK.InvalidRegionId", "Can not find endpoint to access.");
                }
            }
            else if (Endpoint.FindProductDomain(regionId, product, endpoints) == null || CacheTimeHelper.CheckCacheIsExpire(product, regionId))
            {
                Endpoint endpoint = null;
                if (serviceCode != null)
                {
                    endpoint = remoteProvider.GetEndpoint(regionId, product, serviceCode, endpointType, credential, locationConfig);
                }
                if (endpoint == null)
                {
                    endpoint = iendpoints.GetEndpoint(regionId, product);
                }
                if (endpoint != null)
                {
                    foreach (String region in endpoint.RegionIds)
                    {
                        foreach (ProductDomain productDomain in endpoint.ProductDomains)
                        {
                            AddEndpoint(endpoint.Name, region, product, productDomain.DomianName, false);
                            CacheTimeHelper.AddLastClearTimePerProduct(product, region, DateTime.Now);
                        }
                    }
                }
            }
            return endpoints;
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

        public static DefaultProfile GetProfile(String regionId)
        {
            return new DefaultProfile(regionId);
        }

        public static void AddEndpoint(String endpointName, String regionId, String product, String domain)
        {
            AddEndpoint(endpointName, regionId, product, domain, true);
        }

        public static void AddEndpoint(String endpointName, String regionId, String product, String domain, bool isNeverExpire)
        {
            if (null == endpoints)
            {
                endpoints = GetProfile().GetEndpoints(regionId, product);
            }

            Endpoint endpoint = FindEndpointByRegionId(regionId);
            if (null == endpoint)
            {
                AddEndpoint_(endpointName, regionId, product, domain);
            }
            else
            {
                UpdateEndpoint(regionId, product, domain, endpoint);
            }

            if (isNeverExpire)
            {
                DateTime date = DateTime.Now.AddYears(100);
                CacheTimeHelper.AddLastClearTimePerProduct(product, regionId, date);
            }
        }

        private static void AddEndpoint_(String endpointName, String regionId, String product, String domain)
        {
            ISet<String> regions = new HashSet<String>();
            regions.Add(regionId);

            List<ProductDomain> productDomains = new List<ProductDomain>();
            productDomains.Add(new ProductDomain(product, domain));
            Endpoint endpoint = new Endpoint(endpointName, regions, productDomains);
            if (endpoints == null)
            {
                endpoints = new List<Endpoint>();
            }
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

        private static Endpoint FindEndpointByRegionId(String regionId)
        {
            if (null == endpoints)
                return null;

            foreach (Endpoint endpoint in endpoints)
            {
                if (endpoint.RegionIds.Contains(regionId))
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

        public void SetCredentialsProvider(AlibabaCloudCredentialsProvider credentialsProvider)
        {
            if (credential != null)
            {
                return;
            }
            credential = new CredentialsBackupCompatibilityAdaptor(credentialsProvider);
        }
    }
}
