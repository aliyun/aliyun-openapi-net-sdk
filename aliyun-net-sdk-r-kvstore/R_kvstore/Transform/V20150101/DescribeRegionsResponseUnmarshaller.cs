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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = _ctx.HttpResponse;
			describeRegionsResponse.RequestId = _ctx.StringValue("DescribeRegions.RequestId");

			List<DescribeRegionsResponse.DescribeRegions_KVStoreRegion> describeRegionsResponse_regionIds = new List<DescribeRegionsResponse.DescribeRegions_KVStoreRegion>();
			for (int i = 0; i < _ctx.Length("DescribeRegions.RegionIds.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_KVStoreRegion kVStoreRegion = new DescribeRegionsResponse.DescribeRegions_KVStoreRegion();
				kVStoreRegion.RegionId = _ctx.StringValue("DescribeRegions.RegionIds["+ i +"].RegionId");
				kVStoreRegion.ZoneIds = _ctx.StringValue("DescribeRegions.RegionIds["+ i +"].ZoneIds");
				kVStoreRegion.LocalName = _ctx.StringValue("DescribeRegions.RegionIds["+ i +"].LocalName");
				kVStoreRegion.RegionEndpoint = _ctx.StringValue("DescribeRegions.RegionIds["+ i +"].RegionEndpoint");

				List<string> kVStoreRegion_zoneIdList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeRegions.RegionIds["+ i +"].ZoneIdList.Length"); j++) {
					kVStoreRegion_zoneIdList.Add(_ctx.StringValue("DescribeRegions.RegionIds["+ i +"].ZoneIdList["+ j +"]"));
				}
				kVStoreRegion.ZoneIdList = kVStoreRegion_zoneIdList;

				describeRegionsResponse_regionIds.Add(kVStoreRegion);
			}
			describeRegionsResponse.RegionIds = describeRegionsResponse_regionIds;
        
			return describeRegionsResponse;
        }
    }
}
