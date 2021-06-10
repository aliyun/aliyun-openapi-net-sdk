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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeRouteEntryListResponseUnmarshaller
    {
        public static DescribeRouteEntryListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRouteEntryListResponse describeRouteEntryListResponse = new DescribeRouteEntryListResponse();

			describeRouteEntryListResponse.HttpResponse = _ctx.HttpResponse;
			describeRouteEntryListResponse.RequestId = _ctx.StringValue("DescribeRouteEntryList.RequestId");
			describeRouteEntryListResponse.NextToken = _ctx.StringValue("DescribeRouteEntryList.NextToken");

			List<DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry> describeRouteEntryListResponse_routeEntrys = new List<DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry>();
			for (int i = 0; i < _ctx.Length("DescribeRouteEntryList.RouteEntrys.Length"); i++) {
				DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry routeEntry = new DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry();
				routeEntry.RouteTableId = _ctx.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].RouteTableId");
				routeEntry.DestinationCidrBlock = _ctx.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].DestinationCidrBlock");
				routeEntry.Type = _ctx.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].Type");
				routeEntry.RouteEntryId = _ctx.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].RouteEntryId");
				routeEntry.RouteEntryName = _ctx.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].RouteEntryName");
				routeEntry.Description = _ctx.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].Description");
				routeEntry.Status = _ctx.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].Status");
				routeEntry.IpVersion = _ctx.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].IpVersion");

				List<DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry.DescribeRouteEntryList_NextHop> routeEntry_nextHops = new List<DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry.DescribeRouteEntryList_NextHop>();
				for (int j = 0; j < _ctx.Length("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops.Length"); j++) {
					DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry.DescribeRouteEntryList_NextHop nextHop = new DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry.DescribeRouteEntryList_NextHop();
					nextHop.NextHopType = _ctx.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops["+ j +"].NextHopType");
					nextHop.NextHopId = _ctx.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops["+ j +"].NextHopId");
					nextHop.Enabled = _ctx.IntegerValue("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops["+ j +"].Enabled");
					nextHop.Weight = _ctx.IntegerValue("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops["+ j +"].Weight");
					nextHop.NextHopRegionId = _ctx.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops["+ j +"].NextHopRegionId");

					DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry.DescribeRouteEntryList_NextHop.DescribeRouteEntryList_NextHopRelatedInfo nextHopRelatedInfo = new DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry.DescribeRouteEntryList_NextHop.DescribeRouteEntryList_NextHopRelatedInfo();
					nextHopRelatedInfo.InstanceType = _ctx.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops["+ j +"].NextHopRelatedInfo.InstanceType");
					nextHopRelatedInfo.RegionId = _ctx.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops["+ j +"].NextHopRelatedInfo.RegionId");
					nextHopRelatedInfo.InstanceId = _ctx.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops["+ j +"].NextHopRelatedInfo.InstanceId");
					nextHop.NextHopRelatedInfo = nextHopRelatedInfo;

					routeEntry_nextHops.Add(nextHop);
				}
				routeEntry.NextHops = routeEntry_nextHops;

				describeRouteEntryListResponse_routeEntrys.Add(routeEntry);
			}
			describeRouteEntryListResponse.RouteEntrys = describeRouteEntryListResponse_routeEntrys;
        
			return describeRouteEntryListResponse;
        }
    }
}
