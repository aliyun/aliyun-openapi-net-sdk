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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = _ctx.HttpResponse;
			describeRegionsResponse.RequestId = _ctx.StringValue("DescribeRegions.RequestId");

			List<DescribeRegionsResponse.DescribeRegions_DdsRegion> describeRegionsResponse_regions = new List<DescribeRegionsResponse.DescribeRegions_DdsRegion>();
			for (int i = 0; i < _ctx.Length("DescribeRegions.Regions.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_DdsRegion ddsRegion = new DescribeRegionsResponse.DescribeRegions_DdsRegion();
				ddsRegion.RegionId = _ctx.StringValue("DescribeRegions.Regions["+ i +"].RegionId");
				ddsRegion.ZoneIds = _ctx.StringValue("DescribeRegions.Regions["+ i +"].ZoneIds");

				List<DescribeRegionsResponse.DescribeRegions_DdsRegion.DescribeRegions_Zone> ddsRegion_zones = new List<DescribeRegionsResponse.DescribeRegions_DdsRegion.DescribeRegions_Zone>();
				for (int j = 0; j < _ctx.Length("DescribeRegions.Regions["+ i +"].Zones.Length"); j++) {
					DescribeRegionsResponse.DescribeRegions_DdsRegion.DescribeRegions_Zone zone = new DescribeRegionsResponse.DescribeRegions_DdsRegion.DescribeRegions_Zone();
					zone.ZoneId = _ctx.StringValue("DescribeRegions.Regions["+ i +"].Zones["+ j +"].ZoneId");
					zone.VpcEnabled = _ctx.BooleanValue("DescribeRegions.Regions["+ i +"].Zones["+ j +"].VpcEnabled");
					zone.ZoneName = _ctx.StringValue("DescribeRegions.Regions["+ i +"].Zones["+ j +"].ZoneName");

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
