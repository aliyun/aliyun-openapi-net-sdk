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

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeDBClusterAvailableResourcesResponseUnmarshaller
    {
        public static DescribeDBClusterAvailableResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterAvailableResourcesResponse describeDBClusterAvailableResourcesResponse = new DescribeDBClusterAvailableResourcesResponse();

			describeDBClusterAvailableResourcesResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterAvailableResourcesResponse.RequestId = _ctx.StringValue("DescribeDBClusterAvailableResources.RequestId");

			List<DescribeDBClusterAvailableResourcesResponse.DescribeDBClusterAvailableResources_AvailableZone> describeDBClusterAvailableResourcesResponse_availableZones = new List<DescribeDBClusterAvailableResourcesResponse.DescribeDBClusterAvailableResources_AvailableZone>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterAvailableResources.AvailableZones.Length"); i++) {
				DescribeDBClusterAvailableResourcesResponse.DescribeDBClusterAvailableResources_AvailableZone availableZone = new DescribeDBClusterAvailableResourcesResponse.DescribeDBClusterAvailableResources_AvailableZone();
				availableZone.RegionId = _ctx.StringValue("DescribeDBClusterAvailableResources.AvailableZones["+ i +"].RegionId");
				availableZone.ZoneId = _ctx.StringValue("DescribeDBClusterAvailableResources.AvailableZones["+ i +"].ZoneId");

				List<DescribeDBClusterAvailableResourcesResponse.DescribeDBClusterAvailableResources_AvailableZone.DescribeDBClusterAvailableResources_SupportedEngine> availableZone_supportedEngines = new List<DescribeDBClusterAvailableResourcesResponse.DescribeDBClusterAvailableResources_AvailableZone.DescribeDBClusterAvailableResources_SupportedEngine>();
				for (int j = 0; j < _ctx.Length("DescribeDBClusterAvailableResources.AvailableZones["+ i +"].SupportedEngines.Length"); j++) {
					DescribeDBClusterAvailableResourcesResponse.DescribeDBClusterAvailableResources_AvailableZone.DescribeDBClusterAvailableResources_SupportedEngine supportedEngine = new DescribeDBClusterAvailableResourcesResponse.DescribeDBClusterAvailableResources_AvailableZone.DescribeDBClusterAvailableResources_SupportedEngine();
					supportedEngine.Engine = _ctx.StringValue("DescribeDBClusterAvailableResources.AvailableZones["+ i +"].SupportedEngines["+ j +"].Engine");

					List<DescribeDBClusterAvailableResourcesResponse.DescribeDBClusterAvailableResources_AvailableZone.DescribeDBClusterAvailableResources_SupportedEngine.DescribeDBClusterAvailableResources_AvailableResource> supportedEngine_availableResources = new List<DescribeDBClusterAvailableResourcesResponse.DescribeDBClusterAvailableResources_AvailableZone.DescribeDBClusterAvailableResources_SupportedEngine.DescribeDBClusterAvailableResources_AvailableResource>();
					for (int k = 0; k < _ctx.Length("DescribeDBClusterAvailableResources.AvailableZones["+ i +"].SupportedEngines["+ j +"].AvailableResources.Length"); k++) {
						DescribeDBClusterAvailableResourcesResponse.DescribeDBClusterAvailableResources_AvailableZone.DescribeDBClusterAvailableResources_SupportedEngine.DescribeDBClusterAvailableResources_AvailableResource availableResource = new DescribeDBClusterAvailableResourcesResponse.DescribeDBClusterAvailableResources_AvailableZone.DescribeDBClusterAvailableResources_SupportedEngine.DescribeDBClusterAvailableResources_AvailableResource();
						availableResource.DBNodeClass = _ctx.StringValue("DescribeDBClusterAvailableResources.AvailableZones["+ i +"].SupportedEngines["+ j +"].AvailableResources["+ k +"].DBNodeClass");
						availableResource.Category = _ctx.StringValue("DescribeDBClusterAvailableResources.AvailableZones["+ i +"].SupportedEngines["+ j +"].AvailableResources["+ k +"].Category");

						supportedEngine_availableResources.Add(availableResource);
					}
					supportedEngine.AvailableResources = supportedEngine_availableResources;

					availableZone_supportedEngines.Add(supportedEngine);
				}
				availableZone.SupportedEngines = availableZone_supportedEngines;

				describeDBClusterAvailableResourcesResponse_availableZones.Add(availableZone);
			}
			describeDBClusterAvailableResourcesResponse.AvailableZones = describeDBClusterAvailableResourcesResponse_availableZones;
        
			return describeDBClusterAvailableResourcesResponse;
        }
    }
}
