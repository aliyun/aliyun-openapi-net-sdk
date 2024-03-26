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
using System.Threading;
using System.Threading.Tasks;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Regions.Location;

namespace Aliyun.Acs.Core.Regions
{
    internal class RemoteEndpointsParser : IEndpointsProvider
    {
        private DescribeEndpointService describeEndpointService;

        public RemoteEndpointsParser()
        {
            describeEndpointService = new DescribeEndpointServiceImpl();
        }

        public Endpoint GetEndpoint(string regionId, string product)
        {
            throw new NotSupportedException();
        }

        public Endpoint GetEndpoint(string regionId, string product, string serviceCode, string endpointType,
            Credential credential, LocationConfig locationConfig)
        {
            if (serviceCode == null)
            {
                return null;
            }

            var response = describeEndpointService.DescribeEndpoint(regionId, serviceCode, endpointType, credential, locationConfig);
            if (response == null)
            {
                return null;
            }

            ISet<string> regionIds = new HashSet<string>();
            regionIds.Add(regionId);

            var productDomainList = new List<ProductDomain>();
            productDomainList.Add(new ProductDomain(product, response.Endpoint));

            return new Endpoint(response.RegionId, regionIds, productDomainList);
        }

        public Task<Endpoint> GetEndpointAsync(string region, string product, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotSupportedException();
        }

        public async Task<Endpoint> GetEndpointAsync(string regionId, string product, string serviceCode, string endpointType,
            Credential credential, LocationConfig locationConfig,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            if (serviceCode == null)
            {
                return null;
            }

            var response = await describeEndpointService.DescribeEndpointAsync(regionId, serviceCode, endpointType, credential, locationConfig, cancellationToken).ConfigureAwait(false);
            if (response == null)
            {
                return null;
            }

            ISet<string> regionIds = new HashSet<string>();
            regionIds.Add(regionId);

            var productDomainList = new List<ProductDomain>();
            productDomainList.Add(new ProductDomain(product, response.Endpoint));

            return new Endpoint(response.RegionId, regionIds, productDomainList);
        }
    }
}
