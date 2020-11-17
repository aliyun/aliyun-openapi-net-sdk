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
using Aliyun.Acs.Config.Model.V20190108;

namespace Aliyun.Acs.Config.Transform.V20190108
{
    public class GetDiscoveredResourceCountsResponseUnmarshaller
    {
        public static GetDiscoveredResourceCountsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDiscoveredResourceCountsResponse getDiscoveredResourceCountsResponse = new GetDiscoveredResourceCountsResponse();

			getDiscoveredResourceCountsResponse.HttpResponse = _ctx.HttpResponse;
			getDiscoveredResourceCountsResponse.RequestId = _ctx.StringValue("GetDiscoveredResourceCounts.RequestId");

			GetDiscoveredResourceCountsResponse.GetDiscoveredResourceCounts_GroupedResourceCounts groupedResourceCounts = new GetDiscoveredResourceCountsResponse.GetDiscoveredResourceCounts_GroupedResourceCounts();
			groupedResourceCounts.GroupByKey = _ctx.StringValue("GetDiscoveredResourceCounts.GroupedResourceCounts.GroupByKey");

			List<GetDiscoveredResourceCountsResponse.GetDiscoveredResourceCounts_GroupedResourceCounts.GetDiscoveredResourceCounts_GroupedResourceCount> groupedResourceCounts_groupedResourceCountList = new List<GetDiscoveredResourceCountsResponse.GetDiscoveredResourceCounts_GroupedResourceCounts.GetDiscoveredResourceCounts_GroupedResourceCount>();
			for (int i = 0; i < _ctx.Length("GetDiscoveredResourceCounts.GroupedResourceCounts.GroupedResourceCountList.Length"); i++) {
				GetDiscoveredResourceCountsResponse.GetDiscoveredResourceCounts_GroupedResourceCounts.GetDiscoveredResourceCounts_GroupedResourceCount groupedResourceCount = new GetDiscoveredResourceCountsResponse.GetDiscoveredResourceCounts_GroupedResourceCounts.GetDiscoveredResourceCounts_GroupedResourceCount();
				groupedResourceCount.GroupName = _ctx.StringValue("GetDiscoveredResourceCounts.GroupedResourceCounts.GroupedResourceCountList["+ i +"].GroupName");
				groupedResourceCount.ResourceCount = _ctx.LongValue("GetDiscoveredResourceCounts.GroupedResourceCounts.GroupedResourceCountList["+ i +"].ResourceCount");

				groupedResourceCounts_groupedResourceCountList.Add(groupedResourceCount);
			}
			groupedResourceCounts.GroupedResourceCountList = groupedResourceCounts_groupedResourceCountList;
			getDiscoveredResourceCountsResponse.GroupedResourceCounts = groupedResourceCounts;
        
			return getDiscoveredResourceCountsResponse;
        }
    }
}
