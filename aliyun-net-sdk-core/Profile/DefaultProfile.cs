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
using System.Linq;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Regions.Location;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Profile
{
    public class DefaultProfile : IClientProfile
    {
        private static DefaultProfile profile;
        private static List<Endpoint> endpoints;
        private readonly ICredentialProvider icredential;
        private readonly IEndpointsProvider iendpoints;
        private readonly string regionId;
        private readonly RemoteEndpointsParser remoteProvider;
        public FormatType acceptFormat;

        private Credential credential;
        private LocationConfig locationConfig;

        public DefaultProfile(bool mock)
        {
            locationConfig = new LocationConfig();
            iendpoints = new InternalEndpointsParser();
            remoteProvider = RemoteEndpointsParser.InitRemoteEndpointsParser();
        }

        private DefaultProfile()
        {
            locationConfig = new LocationConfig();
            iendpoints = new InternalEndpointsParser();
            remoteProvider = RemoteEndpointsParser.InitRemoteEndpointsParser();
        }

        private DefaultProfile(string regionId)
        {
            locationConfig = new LocationConfig();
            iendpoints = new InternalEndpointsParser();
            remoteProvider = RemoteEndpointsParser.InitRemoteEndpointsParser();
            this.regionId = regionId;
        }

        private DefaultProfile(string region, Credential creden)
        {
            iendpoints = new InternalEndpointsParser();
            remoteProvider = RemoteEndpointsParser.InitRemoteEndpointsParser();
            credential = creden;
            regionId = region;
            locationConfig = new LocationConfig();
        }

        private DefaultProfile(string region, ICredentialProvider icredential)
        {
            iendpoints = new InternalEndpointsParser();
            this.icredential = icredential;
            regionId = region;
            locationConfig = new LocationConfig();
            remoteProvider = RemoteEndpointsParser.InitRemoteEndpointsParser();
        }

        public string DefaultClientName { get; set; }

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

        public void SetLocationConfig(string regionId, string product, string endpoint)
        {
            locationConfig =
                LocationConfig.createLocationConfig(regionId, product, endpoint);
        }

        public List<Endpoint> GetEndpoints(string product, string regionId, string serviceCode, string endpointType)
        {
            try
            {
                if (product == null)
                {
                    return endpoints;
                }

                if (null == endpoints)
                {
                    Endpoint endpoint = null;
                    if (serviceCode != null)
                    {
                        endpoint = GetEndpointByRemoteProvider(regionId, product, serviceCode, endpointType);
                    }

                    if (endpoint == null)
                    {
                        endpoint = GetEndpointByIEndpoints(regionId, product);
                    }

                    if (endpoint != null)
                    {
                        endpoints = new List<Endpoint>
                        {
                            endpoint
                        };
                        CacheTimeHelper.AddLastClearTimePerProduct(product, regionId, DateTime.Now);
                    }
                    else
                    {
                        throw new ClientException("SDK.InvalidRegionId", "Can not find endpoint to access.");
                    }
                }
                else if (Endpoint.FindProductDomain(regionId, product, endpoints) == null ||
                         CacheTimeHelper.CheckCacheIsExpire(product, regionId))
                {
                    Endpoint endpoint = null;
                    if (serviceCode != null)
                    {
                        endpoint = GetEndpointByRemoteProvider(regionId, product, serviceCode, endpointType);
                    }

                    if (endpoint == null)
                    {
                        endpoint = GetEndpointByIEndpoints(regionId, product);
                    }

                    if (endpoint != null)
                    {
                        foreach (var region in endpoint.RegionIds)
                        foreach (var productDomain in endpoint.ProductDomains.ToList())
                        {
                            AddEndpoint(endpoint.Name, region, product, productDomain.DomianName, false);
                            CacheTimeHelper.AddLastClearTimePerProduct(product, region, DateTime.Now);
                        }
                    }
                }
            }
            catch (ClientException ex)
            {
                SerilogHelper.LogException(ex, ex.ErrorCode, ex.ErrorMessage);
                throw new ClientException(ex.ErrorCode, ex.ErrorMessage);
            }

            return endpoints;
        }

        public void SetCredentialsProvider(AlibabaCloudCredentialsProvider credentialsProvider)
        {
            if (credential != null)
            {
                return;
            }

            credential = new CredentialsBackupCompatibilityAdaptor(credentialsProvider);
        }

        public List<Endpoint> GetEndpoints(string regionId, string product)
        {
            if (null == endpoints)
            {
                var endpoint = GetEndpointByIEndpoints(regionId, product);
                if (endpoint != null)
                {
                    endpoints = new List<Endpoint> {endpoint};
                }
            }

            return endpoints;
        }

        public static DefaultProfile GetProfile()
        {
            if (null == profile)
            {
                profile = new DefaultProfile();
            }

            return profile;
        }

        public static DefaultProfile GetProfile(string regionId, ICredentialProvider icredential)
        {
            profile = new DefaultProfile(regionId, icredential);
            return profile;
        }

        public static DefaultProfile GetProfile(string regionId, string accessKeyId, string secret)
        {
            var creden = new Credential(accessKeyId, secret);
            profile = new DefaultProfile(regionId, creden);
            return profile;
        }

        public static DefaultProfile GetProfile(string regionId)
        {
            return new DefaultProfile(regionId);
        }

        public static void AddEndpoint(string endpointName, string regionId, string product, string domain)
        {
            AddEndpoint(endpointName, regionId, product, domain, true);
        }

        public static void AddEndpoint(string endpointName, string regionId, string product, string domain,
            bool isNeverExpire)
        {
            if (null == endpoints)
            {
                endpoints = GetProfile().GetEndpoints(regionId, product);
            }

            var endpoint = FindEndpointByRegionId(regionId);
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
                var date = DateTime.Now.AddYears(100);
                CacheTimeHelper.AddLastClearTimePerProduct(product, regionId, date);
            }
        }

        private static void AddEndpoint_(string endpointName, string regionId, string product, string domain)
        {
            ISet<string> regions = new HashSet<string>
            {
                regionId
            };

            var productDomains = new List<ProductDomain>
            {
                new ProductDomain(product, domain)
            };
            var endpoint = new Endpoint(endpointName, regions, productDomains);
            if (endpoints == null)
            {
                endpoints = new List<Endpoint>();
            }

            endpoints.Add(endpoint);
        }

        private static void UpdateEndpoint(string regionId, string product, string domain, Endpoint endpoint)
        {
            var regionIds = endpoint.RegionIds;
            regionIds.Add(regionId);

            var productDomains = endpoint.ProductDomains;
            var productDomain = FindProductDomain(productDomains, product);
            if (null == productDomain)
            {
                productDomains.Add(new ProductDomain(product, domain));
            }
            else
            {
                productDomain.DomianName = domain;
            }
        }

        private static Endpoint FindEndpointByRegionId(string regionId)
        {
            if (null == endpoints)
            {
                return null;
            }

            foreach (var endpoint in endpoints)
            {
                if (endpoint.RegionIds.Contains(regionId))
                {
                    return endpoint;
                }
            }

            return null;
        }

        private static ProductDomain FindProductDomain(List<ProductDomain> productDomains, string product)
        {
            foreach (var productDomain in productDomains)
            {
                if (productDomain.ProductName.Equals(product))
                {
                    return productDomain;
                }
            }

            return null;
        }

        public static void ClearDefaultProfile()
        {
            profile = null;
            endpoints = null;
        }

        public virtual Endpoint GetEndpointByRemoteProvider(string regionId, string product, string serviceCode,
            string endpointType)
        {
            return remoteProvider.GetEndpoint(regionId, product, serviceCode, endpointType, credential,
                locationConfig);
        }

        public virtual Endpoint GetEndpointByIEndpoints(string regionId, string product)
        {
            return iendpoints.GetEndpoint(regionId, product);
        }
    }
}
