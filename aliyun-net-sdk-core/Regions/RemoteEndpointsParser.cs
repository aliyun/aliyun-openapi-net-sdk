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
using System.Text;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Regions.Location;
using Aliyun.Acs.Core.Regions.Location.Model;

namespace Aliyun.Acs.Core.Regions
{
    class RemoteEndpointsParser : IEndpointsProvider
    {
        private DescribeEndpointService describeEndpointService;

        public void SetDescribeEndpointService(DescribeEndpointService describeEndpointService)
        {
            this.describeEndpointService = describeEndpointService;
        }

        public static RemoteEndpointsParser InitRemoteEndpointsParser()
        {
            RemoteEndpointsParser parser = new RemoteEndpointsParser();
            parser.SetDescribeEndpointService(new DescribeEndpointServiceImpl());
            return parser;
        }

        public Endpoint GetEndpoint(String regionId, String product)
        {
            throw new NotSupportedException();
        }

        public Endpoint GetEndpoint(String regionId, String product, String serviceCode, String endpointType,
                                Credential credential, LocationConfig locationConfig)
        {
            if (serviceCode == null)
            {
                return null;
            }
            Endpoint endpoint = null;

            DescribeEndpointResponse response = describeEndpointService.DescribeEndpoint(regionId, serviceCode,
                endpointType, credential, locationConfig);
            if (response == null)
            {
                return endpoint;
            }
            ISet<String> regionIds = new HashSet<String>();
            regionIds.Add(regionId);

            List<ProductDomain> productDomainList = new List<ProductDomain>();
            productDomainList.Add(new ProductDomain(product, response.Endpoint));

            endpoint = new Endpoint(response.RegionId, regionIds, productDomainList);
            return endpoint;
        }
    }
}
