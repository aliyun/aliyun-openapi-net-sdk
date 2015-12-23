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
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeRouteTablesResponseUnmarshaller
    {
        public static DescribeRouteTablesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRouteTablesResponse describeRouteTablesResponse = new DescribeRouteTablesResponse();

			describeRouteTablesResponse.HttpResponse = context.HttpResponse;
			describeRouteTablesResponse.RequestId = context.StringValue("DescribeRouteTables.RequestId");
			describeRouteTablesResponse.TotalCount = context.IntegerValue("DescribeRouteTables.TotalCount");
			describeRouteTablesResponse.PageNumber = context.IntegerValue("DescribeRouteTables.PageNumber");
			describeRouteTablesResponse.PageSize = context.IntegerValue("DescribeRouteTables.PageSize");

			List<DescribeRouteTablesResponse.RouteTable> routeTables = new List<DescribeRouteTablesResponse.RouteTable>();
			for (int i = 0; i < context.Length("DescribeRouteTables.RouteTables.Length"); i++) {
				DescribeRouteTablesResponse.RouteTable routeTable = new DescribeRouteTablesResponse.RouteTable();
				routeTable.VRouterId = context.StringValue("DescribeRouteTables.RouteTables["+ i +"].VRouterId");
				routeTable.RouteTableId = context.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteTableId");
				routeTable.RouteTableType = context.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteTableType");
				routeTable.CreationTime = context.StringValue("DescribeRouteTables.RouteTables["+ i +"].CreationTime");

				List<DescribeRouteTablesResponse.RouteTable.RouteEntry> routeEntrys = new List<DescribeRouteTablesResponse.RouteTable.RouteEntry>();
				for (int j = 0; j < context.Length("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys.Length"); j++) {
					DescribeRouteTablesResponse.RouteTable.RouteEntry routeEntry = new DescribeRouteTablesResponse.RouteTable.RouteEntry();
					routeEntry.RouteTableId = context.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys["+ j +"].RouteTableId");
					routeEntry.DestinationCidrBlock = context.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys["+ j +"].DestinationCidrBlock");
					routeEntry.Type = context.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys["+ j +"].Type");
					routeEntry.Status = context.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys["+ j +"].Status");
					routeEntry.InstanceId = context.StringValue("DescribeRouteTables.RouteTables["+ i +"].RouteEntrys["+ j +"].InstanceId");

					routeEntrys.Add(routeEntry);
				}
				routeTable.RouteEntrys = routeEntrys;

				routeTables.Add(routeTable);
			}
			describeRouteTablesResponse.RouteTables = routeTables;
        
			return describeRouteTablesResponse;
        }
    }
}