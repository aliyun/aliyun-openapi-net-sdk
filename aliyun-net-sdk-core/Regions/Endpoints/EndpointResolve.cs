using System;
using System.Collections.Generic;
using System.Linq;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Regions.Location;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Regions.Endpoints
{
    internal class EndpointResolve
    {
        private static List<Endpoint> _endpoints;
        private readonly IEndpointsProvider internalEndpointProvider;
        private readonly IEndpointsProvider remoteEndpointProvider;

        public EndpointResolve()
        {
            _endpoints = new List<Endpoint>();
            internalEndpointProvider = new InternalEndpointsParser();
            remoteEndpointProvider = new RemoteEndpointsParser();
        }

        public List<Endpoint> Resolve(string product, string regionId, string serviceCode, string endpointType,
            Credential credential, LocationConfig locationConfig)
        {
            try
            {
                if (product == null)
                {
                    return _endpoints;
                }

                if (_endpoints.FirstOrDefault(x => x.Name == product) != null)
                {
                    var endpoint = internalEndpointProvider.GetEndpoint(regionId, product);

                    if (serviceCode != null && endpoint == null)
                    {
                        endpoint = remoteEndpointProvider.GetEndpoint(regionId, product, serviceCode, endpointType,
                            credential, locationConfig);
                    }

                    if (endpoint != null)
                    {
                        foreach (var region in endpoint.RegionIds)
                        {
                            foreach (var productDomain in endpoint.ProductDomains.ToList())
                            {
                                AddEndpoint(endpoint.Name, region, product, productDomain.DomainName);
                                CacheTimeHelper.AddLastClearTimePerProduct(product, region, DateTime.UtcNow);
                            }
                        }
                    }
                    else
                    {
                        throw new ClientException("SDK.InvalidRegionId", "Can not find endpoint to access.");
                    }
                }
                else if (Endpoint.FindProductDomain(regionId, product, _endpoints) == null ||
                    CacheTimeHelper.CheckCacheIsExpire(product, regionId))
                {
                    var endpoint = internalEndpointProvider.GetEndpoint(regionId, product);

                    if (serviceCode != null && endpoint == null)
                    {
                        endpoint = remoteEndpointProvider.GetEndpoint(regionId, product, serviceCode, endpointType,
                            credential, locationConfig);
                    }

                    if (endpoint != null)
                    {
                        foreach (var region in endpoint.RegionIds)
                        {
                            foreach (var productDomain in endpoint.ProductDomains.ToList())
                            {
                                AddEndpoint(endpoint.Name, region, product, productDomain.DomainName);
                                CacheTimeHelper.AddLastClearTimePerProduct(product, region, DateTime.UtcNow);
                            }
                        }
                    }
                }
            }
            catch (ClientException ex)
            {
                CommonLog.LogException(ex, ex.ErrorCode, ex.ErrorMessage);
                throw new ClientException(ex.ErrorCode, ex.ErrorMessage);
            }

            return _endpoints;
        }

        public void AddEndpoint(string endpointName, string regionId, string product, string domain,
            bool isNeverExpire = false)
        {
            if (0 == _endpoints.Count)
            {
                _endpoints = GetEndpoints(regionId, product);
            }

            var endpoint = FindEndpointByRegionId(regionId);
            if (null == endpoint)
            {
                var regions = new HashSet<string> { regionId };

                var productDomains = new List<ProductDomain> { new ProductDomain(product, domain) };
                endpoint = new Endpoint(endpointName, regions, productDomains);
                if (_endpoints == null)
                {
                    _endpoints = new List<Endpoint>();
                }

                _endpoints.Add(endpoint);
            }
            else
            {
                UpdateEndpoint(regionId, product, domain, endpoint);
            }

            if (isNeverExpire)
            {
                var date = DateTime.UtcNow.AddYears(100);
                CacheTimeHelper.AddLastClearTimePerProduct(product, regionId, date);
            }
        }

        private static Endpoint FindEndpointByRegionId(string regionId)
        {
            if (0 == _endpoints.Count)
            {
                return null;
            }

            foreach (var endpoint in _endpoints.ToList())
            {
                if (endpoint.RegionIds.Contains(regionId))
                {
                    return endpoint;
                }
            }

            return null;
        }

        public List<Endpoint> GetEndpoints(string regionId, string product)
        {
            if (null == _endpoints)
            {
                var endpoint = internalEndpointProvider.GetEndpoint(regionId, product);
                if (endpoint != null)
                {
                    _endpoints = new List<Endpoint> { endpoint };
                }
            }

            return _endpoints;
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
                productDomain.DomainName = domain;
            }
        }

        private static ProductDomain FindProductDomain(List<ProductDomain> productDomains, string product)
        {
            foreach (var productDomain in productDomains.ToList())
            {
                if (productDomain.ProductName.Equals(product))
                {
                    return productDomain;
                }
            }

            return null;
        }
    }
}
