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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Dds.Model.V20151201;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = context.HttpResponse;
			describeRegionsResponse.RequestId = context.StringValue("DescribeRegions.RequestId");

			List<DescribeRegionsResponse.DescribeRegions_DdsRegion> describeRegionsResponse_regions = new List<DescribeRegionsResponse.DescribeRegions_DdsRegion>();
			for (int i = 0; i < context.Length("DescribeRegions.Regions.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_DdsRegion ddsRegion = new DescribeRegionsResponse.DescribeRegions_DdsRegion();
				ddsRegion.RegionId = context.StringValue("DescribeRegions.Regions["+ i +"].RegionId");
				ddsRegion.ZoneIds = context.StringValue("DescribeRegions.Regions["+ i +"].ZoneIds");

				List<DescribeRegionsResponse.DescribeRegions_DdsRegion.DescribeRegions_Zone> ddsRegion_zones = new List<DescribeRegionsResponse.DescribeRegions_DdsRegion.DescribeRegions_Zone>();
				for (int j = 0; j < context.Length("DescribeRegions.Regions["+ i +"].Zones.Length"); j++) {
					DescribeRegionsResponse.DescribeRegions_DdsRegion.DescribeRegions_Zone zone = new DescribeRegionsResponse.DescribeRegions_DdsRegion.DescribeRegions_Zone();
					zone.ZoneId = context.StringValue("DescribeRegions.Regions["+ i +"].Zones["+ j +"].ZoneId");
					zone.VpcEnabled = context.BooleanValue("DescribeRegions.Regions["+ i +"].Zones["+ j +"].VpcEnabled");

					ddsRegion_zones.Add(zone);
				}
				ddsRegion.Zones = ddsRegion_zones;

				describeRegionsResponse_regions.Add(ddsRegion);
			}
			describeRegionsResponse.Regions = describeRegionsResponse_regions;
        
			return describeRegionsResponse;
        }
    }
}