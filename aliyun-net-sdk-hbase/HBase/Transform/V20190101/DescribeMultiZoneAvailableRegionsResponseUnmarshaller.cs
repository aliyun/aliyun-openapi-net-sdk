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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class DescribeMultiZoneAvailableRegionsResponseUnmarshaller
    {
        public static DescribeMultiZoneAvailableRegionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMultiZoneAvailableRegionsResponse describeMultiZoneAvailableRegionsResponse = new DescribeMultiZoneAvailableRegionsResponse();

			describeMultiZoneAvailableRegionsResponse.HttpResponse = context.HttpResponse;
			describeMultiZoneAvailableRegionsResponse.RequestId = context.StringValue("DescribeMultiZoneAvailableRegions.RequestId");

			List<DescribeMultiZoneAvailableRegionsResponse.DescribeMultiZoneAvailableRegions_Region> describeMultiZoneAvailableRegionsResponse_regions = new List<DescribeMultiZoneAvailableRegionsResponse.DescribeMultiZoneAvailableRegions_Region>();
			for (int i = 0; i < context.Length("DescribeMultiZoneAvailableRegions.Regions.Length"); i++) {
				DescribeMultiZoneAvailableRegionsResponse.DescribeMultiZoneAvailableRegions_Region region = new DescribeMultiZoneAvailableRegionsResponse.DescribeMultiZoneAvailableRegions_Region();
				region.LocalName = context.StringValue("DescribeMultiZoneAvailableRegions.Regions["+ i +"].LocalName");
				region.RegionEndpoint = context.StringValue("DescribeMultiZoneAvailableRegions.Regions["+ i +"].RegionEndpoint");
				region.RegionId = context.StringValue("DescribeMultiZoneAvailableRegions.Regions["+ i +"].RegionId");

				List<DescribeMultiZoneAvailableRegionsResponse.DescribeMultiZoneAvailableRegions_Region.DescribeMultiZoneAvailableRegions_AvailableCombine> region_availableCombines = new List<DescribeMultiZoneAvailableRegionsResponse.DescribeMultiZoneAvailableRegions_Region.DescribeMultiZoneAvailableRegions_AvailableCombine>();
				for (int j = 0; j < context.Length("DescribeMultiZoneAvailableRegions.Regions["+ i +"].AvailableCombines.Length"); j++) {
					DescribeMultiZoneAvailableRegionsResponse.DescribeMultiZoneAvailableRegions_Region.DescribeMultiZoneAvailableRegions_AvailableCombine availableCombine = new DescribeMultiZoneAvailableRegionsResponse.DescribeMultiZoneAvailableRegions_Region.DescribeMultiZoneAvailableRegions_AvailableCombine();
					availableCombine.Id = context.StringValue("DescribeMultiZoneAvailableRegions.Regions["+ i +"].AvailableCombines["+ j +"].Id");

					List<string> availableCombine_zones = new List<string>();
					for (int k = 0; k < context.Length("DescribeMultiZoneAvailableRegions.Regions["+ i +"].AvailableCombines["+ j +"].Zones.Length"); k++) {
						availableCombine_zones.Add(context.StringValue("DescribeMultiZoneAvailableRegions.Regions["+ i +"].AvailableCombines["+ j +"].Zones["+ k +"]"));
					}
					availableCombine.Zones = availableCombine_zones;

					region_availableCombines.Add(availableCombine);
				}
				region.AvailableCombines = region_availableCombines;

				describeMultiZoneAvailableRegionsResponse_regions.Add(region);
			}
			describeMultiZoneAvailableRegionsResponse.Regions = describeMultiZoneAvailableRegionsResponse_regions;
        
			return describeMultiZoneAvailableRegionsResponse;
        }
    }
}
