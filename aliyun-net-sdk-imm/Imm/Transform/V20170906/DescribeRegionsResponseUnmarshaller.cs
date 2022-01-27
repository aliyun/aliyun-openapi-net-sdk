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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = _ctx.HttpResponse;
			describeRegionsResponse.RequestId = _ctx.StringValue("DescribeRegions.RequestId");

			DescribeRegionsResponse.DescribeRegions_Regions regions = new DescribeRegionsResponse.DescribeRegions_Regions();

			List<DescribeRegionsResponse.DescribeRegions_Regions.DescribeRegions_RegionItem> regions_region = new List<DescribeRegionsResponse.DescribeRegions_Regions.DescribeRegions_RegionItem>();
			for (int i = 0; i < _ctx.Length("DescribeRegions.Regions.Region.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_Regions.DescribeRegions_RegionItem regionItem = new DescribeRegionsResponse.DescribeRegions_Regions.DescribeRegions_RegionItem();
				regionItem.RegionId = _ctx.StringValue("DescribeRegions.Regions.Region["+ i +"].RegionId");

				List<string> regionItem_projectTypes = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeRegions.Regions.Region["+ i +"].ProjectTypes.Length"); j++) {
					regionItem_projectTypes.Add(_ctx.StringValue("DescribeRegions.Regions.Region["+ i +"].ProjectTypes["+ j +"]"));
				}
				regionItem.ProjectTypes = regionItem_projectTypes;

				regions_region.Add(regionItem);
			}
			regions.Region = regions_region;
			describeRegionsResponse.Regions = regions;
        
			return describeRegionsResponse;
        }
    }
}
