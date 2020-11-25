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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeRouteTablesResponseUnmarshaller
    {
        public static DescribeRouteTablesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRouteTablesResponse describeRouteTablesResponse = new DescribeRouteTablesResponse();

			describeRouteTablesResponse.HttpResponse = _ctx.HttpResponse;
			describeRouteTablesResponse.RequestId = _ctx.StringValue("DescribeRouteTables.RequestId");
			describeRouteTablesResponse.TotalCount = _ctx.IntegerValue("DescribeRouteTables.TotalCount");
			describeRouteTablesResponse.PageNumber = _ctx.IntegerValue("DescribeRouteTables.PageNumber");
			describeRouteTablesResponse.PageSize = _ctx.IntegerValue("DescribeRouteTables.PageSize");

			List<DescribeRouteTablesResponse.DescribeRouteTables_RouteTable> describeRouteTablesResponse_routeTables = new List<DescribeRouteTablesResponse.DescribeRouteTables_RouteTable>();
			for (int i = 0; i < _ctx.Length("DescribeRouteTables.RouteTables.Length"); i++) {
				DescribeRouteTablesResponse.DescribeRouteTables_RouteTable routeTable = new DescribeRouteTablesResponse.DescribeRouteTables_RouteTable();
				routeTable.VRouterId = _ctx.StringValue("DescribeRouteTables.RouteTables["+ i +"].VRouterId");
				routeTable.RouteTableId = _ctx.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteTableId");
				routeTable.RouteTableType = _ctx.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteTableType");
				routeTable.CreationTime = _ctx.StringValue("DescribeRouteTables.RouteTables["+ i +"].CreationTime");
				routeTable.ResourceGroupId = _ctx.StringValue("DescribeRouteTables.RouteTables["+ i +"].ResourceGroupId");

				List<DescribeRouteTablesResponse.DescribeRouteTables_RouteTable.DescribeRouteTables_RouteEntry> routeTable_routeEntrys = new List<DescribeRouteTablesResponse.DescribeRouteTables_RouteTable.DescribeRouteTables_RouteEntry>();
				for (int j = 0; j < _ctx.Length("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys.Length"); j++) {
					DescribeRouteTablesResponse.DescribeRouteTables_RouteTable.DescribeRouteTables_RouteEntry routeEntry = new DescribeRouteTablesResponse.DescribeRouteTables_RouteTable.DescribeRouteTables_RouteEntry();
					routeEntry.RouteTableId = _ctx.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys["+ j +"].RouteTableId");
					routeEntry.DestinationCidrBlock = _ctx.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys["+ j +"].DestinationCidrBlock");
					routeEntry.Type = _ctx.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys["+ j +"].Type");
					routeEntry.Status = _ctx.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys["+ j +"].Status");
					routeEntry.InstanceId = _ctx.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys["+ j +"].InstanceId");
					routeEntry.NextHopType = _ctx.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys["+ j +"].NextHopType");

					List<DescribeRouteTablesResponse.DescribeRouteTables_RouteTable.DescribeRouteTables_RouteEntry.DescribeRouteTables_NextHop> routeEntry_nextHops = new List<DescribeRouteTablesResponse.DescribeRouteTables_RouteTable.DescribeRouteTables_RouteEntry.DescribeRouteTables_NextHop>();
					for (int k = 0; k < _ctx.Length("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys["+ j +"].NextHops.Length"); k++) {
						DescribeRouteTablesResponse.DescribeRouteTables_RouteTable.DescribeRouteTables_RouteEntry.DescribeRouteTables_NextHop nextHop = new DescribeRouteTablesResponse.DescribeRouteTables_RouteTable.DescribeRouteTables_RouteEntry.DescribeRouteTables_NextHop();
						nextHop.NextHopType = _ctx.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys["+ j +"].NextHops["+ k +"].NextHopType");
						nextHop.NextHopId = _ctx.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys["+ j +"].NextHops["+ k +"].NextHopId");
						nextHop.Enabled = _ctx.IntegerValue("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys["+ j +"].NextHops["+ k +"].Enabled");
						nextHop.Weight = _ctx.IntegerValue("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys["+ j +"].NextHops["+ k +"].Weight");

						routeEntry_nextHops.Add(nextHop);
					}
					routeEntry.NextHops = routeEntry_nextHops;

					routeTable_routeEntrys.Add(routeEntry);
				}
				routeTable.RouteEntrys = routeTable_routeEntrys;

				describeRouteTablesResponse_routeTables.Add(routeTable);
			}
			describeRouteTablesResponse.RouteTables = describeRouteTablesResponse_routeTables;
        
			return describeRouteTablesResponse;
        }
    }
}
