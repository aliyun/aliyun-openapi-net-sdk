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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = _ctx.HttpResponse;
			describeRegionsResponse.Message = _ctx.StringValue("DescribeRegions.Message");
			describeRegionsResponse.RequestId = _ctx.StringValue("DescribeRegions.RequestId");
			describeRegionsResponse.Code = _ctx.IntegerValue("DescribeRegions.Code");

			List<DescribeRegionsResponse.DescribeRegions_Region> describeRegionsResponse_regions = new List<DescribeRegionsResponse.DescribeRegions_Region>();
			for (int i = 0; i < _ctx.Length("DescribeRegions.Regions.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_Region region = new DescribeRegionsResponse.DescribeRegions_Region();
				region.LocalName = _ctx.StringValue("DescribeRegions.Regions["+ i +"].LocalName");
				region.RegionEndpoint = _ctx.StringValue("DescribeRegions.Regions["+ i +"].RegionEndpoint");
				region.RegionId = _ctx.StringValue("DescribeRegions.Regions["+ i +"].RegionId");

				List<string> region_recommendZones = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeRegions.Regions["+ i +"].RecommendZones.Length"); j++) {
					region_recommendZones.Add(_ctx.StringValue("DescribeRegions.Regions["+ i +"].RecommendZones["+ j +"]"));
				}
				region.RecommendZones = region_recommendZones;

				describeRegionsResponse_regions.Add(region);
			}
			describeRegionsResponse.Regions = describeRegionsResponse_regions;
        
			return describeRegionsResponse;
        }
    }
}
