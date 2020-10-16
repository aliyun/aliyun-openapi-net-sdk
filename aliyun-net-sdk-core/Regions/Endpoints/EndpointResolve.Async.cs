using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Regions.Location;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Regions.Endpoints
{
    internal partial class EndpointResolve
    {
        public async Task<List<Endpoint>> ResolveAsync(string product, string regionId, string serviceCode, string endpointType,
            Credential credential, LocationConfig locationConfig, CancellationToken cancellationToken)
        {
            try
            {
                if (product == null)
                {
                    return _endpoints;
                }

                if (_endpoints.FirstOrDefault(x => x.Name == product) != null)
                {
                    var endpoint = await internalEndpointProvider.GetEndpointAsync(regionId, product, cancellationToken).ConfigureAwait(false);

                    if (serviceCode != null && endpoint == null)
                    {
                        endpoint = await remoteEndpointProvider.GetEndpointAsync(regionId, product, serviceCode, endpointType,
                            credential, locationConfig, cancellationToken).ConfigureAwait(false);
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
                    var endpoint = await internalEndpointProvider.GetEndpointAsync(regionId, product, cancellationToken).ConfigureAwait(false);

                    if (serviceCode != null && endpoint == null)
                    {
                        endpoint = await remoteEndpointProvider.GetEndpointAsync(regionId, product, serviceCode, endpointType,
                            credential, locationConfig, cancellationToken).ConfigureAwait(false);
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

        public async Task AddEndpointAsync(string endpointName, string regionId, string product, string domain,
            bool isNeverExpire = false,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            if (0 == _endpoints.Count)
            {
                _endpoints = await GetEndpointsAsync(regionId, product, cancellationToken).ConfigureAwait(false);
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

        public async Task<List<Endpoint>> GetEndpointsAsync(string regionId, string product, CancellationToken cancellationToken)
        {
            if (null == _endpoints)
            {
                var endpoint = await internalEndpointProvider.GetEndpointAsync(regionId, product, cancellationToken).ConfigureAwait(false);
                if (endpoint != null)
                {
                    _endpoints = new List<Endpoint> { endpoint };
                }
            }

            return _endpoints;
        }
    }
}
