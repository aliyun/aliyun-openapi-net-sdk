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
using Aliyun.Acs.R_kvstore.Model.V20150101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = context.HttpResponse;
			describeRegionsResponse.RequestId = context.StringValue("DescribeRegions.RequestId");

			List<DescribeRegionsResponse.DescribeRegions_KVStoreRegion> describeRegionsResponse_regionIds = new List<DescribeRegionsResponse.DescribeRegions_KVStoreRegion>();
			for (int i = 0; i < context.Length("DescribeRegions.RegionIds.Length"); i++) {
				DescribeRegionsResponse.DescribeRegions_KVStoreRegion kVStoreRegion = new DescribeRegionsResponse.DescribeRegions_KVStoreRegion();
				kVStoreRegion.RegionId = context.StringValue("DescribeRegions.RegionIds["+ i +"].RegionId");
				kVStoreRegion.ZoneIds = context.StringValue("DescribeRegions.RegionIds["+ i +"].ZoneIds");
				kVStoreRegion.LocalName = context.StringValue("DescribeRegions.RegionIds["+ i +"].LocalName");

				describeRegionsResponse_regionIds.Add(kVStoreRegion);
			}
			describeRegionsResponse.RegionIds = describeRegionsResponse_regionIds;
        
			return describeRegionsResponse;
        }
    }
}