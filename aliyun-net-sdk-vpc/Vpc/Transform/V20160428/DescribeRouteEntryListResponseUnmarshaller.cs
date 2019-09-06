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
        public static DescribeRouteEntryListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRouteEntryListResponse describeRouteEntryListResponse = new DescribeRouteEntryListResponse();

			describeRouteEntryListResponse.HttpResponse = context.HttpResponse;
			describeRouteEntryListResponse.RequestId = context.StringValue("DescribeRouteEntryList.RequestId");
			describeRouteEntryListResponse.NextToken = context.StringValue("DescribeRouteEntryList.NextToken");

			List<DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry> describeRouteEntryListResponse_routeEntrys = new List<DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry>();
			for (int i = 0; i < context.Length("DescribeRouteEntryList.RouteEntrys.Length"); i++) {
				DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry routeEntry = new DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry();
				routeEntry.RouteTableId = context.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].RouteTableId");
				routeEntry.DestinationCidrBlock = context.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].DestinationCidrBlock");
				routeEntry.Type = context.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].Type");
				routeEntry.RouteEntryId = context.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].RouteEntryId");
				routeEntry.RouteEntryName = context.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].RouteEntryName");
				routeEntry.Status = context.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].Status");
				routeEntry.IpVersion = context.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].IpVersion");

				List<DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry.DescribeRouteEntryList_NextHop> routeEntry_nextHops = new List<DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry.DescribeRouteEntryList_NextHop>();
				for (int j = 0; j < context.Length("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops.Length"); j++) {
					DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry.DescribeRouteEntryList_NextHop nextHop = new DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry.DescribeRouteEntryList_NextHop();
					nextHop.NextHopType = context.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops["+ j +"].NextHopType");
					nextHop.NextHopId = context.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops["+ j +"].NextHopId");
					nextHop.Enabled = context.IntegerValue("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops["+ j +"].Enabled");
					nextHop.Weight = context.IntegerValue("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops["+ j +"].Weight");
					nextHop.NextHopRegionId = context.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops["+ j +"].NextHopRegionId");

					DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry.DescribeRouteEntryList_NextHop.DescribeRouteEntryList_NextHopRelatedInfo nextHopRelatedInfo = new DescribeRouteEntryListResponse.DescribeRouteEntryList_RouteEntry.DescribeRouteEntryList_NextHop.DescribeRouteEntryList_NextHopRelatedInfo();
					nextHopRelatedInfo.InstanceType = context.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops["+ j +"].NextHopRelatedInfo.InstanceType");
					nextHopRelatedInfo.RegionId = context.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops["+ j +"].NextHopRelatedInfo.RegionId");
					nextHopRelatedInfo.InstanceId = context.StringValue("DescribeRouteEntryList.RouteEntrys["+ i +"].NextHops["+ j +"].NextHopRelatedInfo.InstanceId");
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
