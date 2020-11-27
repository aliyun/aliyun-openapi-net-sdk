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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = _ctx.HttpResponse;
			describeRegionsResponse.RequestId = _ctx.StringValue("DescribeRegions.RequestId");
			describeRegionsResponse.Code = _ctx.IntegerValue("DescribeRegions.Code");
			describeRegionsResponse.ErrorCode = _ctx.IntegerValue("DescribeRegions.ErrorCode");
			describeRegionsResponse.Success = _ctx.BooleanValue("DescribeRegions.Success");
			describeRegionsResponse.Message = _ctx.StringValue("DescribeRegions.Message");

			List<DescribeRegionsResponse.DescribeRegions_Region> describeRegionsResponse_regions = new List<DescribeRegionsResponse.DescribeRegions_Region>();
			for (int i = 0; i < _ctx.Length("DescribeRegions.Regions.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_Region region = new DescribeRegionsResponse.DescribeRegions_Region();
				region.RegionId = _ctx.StringValue("DescribeRegions.Regions["+ i +"].RegionId");
				region.SupportPolarx20 = _ctx.BooleanValue("DescribeRegions.Regions["+ i +"].SupportPolarx20");

				List<DescribeRegionsResponse.DescribeRegions_Region.DescribeRegions_Zone> region_zones = new List<DescribeRegionsResponse.DescribeRegions_Region.DescribeRegions_Zone>();
				for (int j = 0; j < _ctx.Length("DescribeRegions.Regions["+ i +"].Zones.Length"); j++) {
					DescribeRegionsResponse.DescribeRegions_Region.DescribeRegions_Zone zone = new DescribeRegionsResponse.DescribeRegions_Region.DescribeRegions_Zone();
					zone.ZoneId = _ctx.StringValue("DescribeRegions.Regions["+ i +"].Zones["+ j +"].ZoneId");
					zone.VpcEnabled = _ctx.BooleanValue("DescribeRegions.Regions["+ i +"].Zones["+ j +"].VpcEnabled");

					region_zones.Add(zone);
				}
				region.Zones = region_zones;

				describeRegionsResponse_regions.Add(region);
			}
			describeRegionsResponse.Regions = describeRegionsResponse_regions;
        
			return describeRegionsResponse;
        }
    }
}
