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
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeRouteTablesResponseUnmarshaller
    {
        public static DescribeRouteTablesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeRouteTablesResponse describeRouteTablesResponse = new DescribeRouteTablesResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeRouteTables.RequestId"),
                TotalCount = context.IntegerValue("DescribeRouteTables.TotalCount"),
                PageNumber = context.IntegerValue("DescribeRouteTables.PageNumber"),
                PageSize = context.IntegerValue("DescribeRouteTables.PageSize")
            };
            List<DescribeRouteTablesResponse.RouteTable> routeTables = new List<DescribeRouteTablesResponse.RouteTable>();
			for (int i = 0; i < context.Length("DescribeRouteTables.RouteTables.Length"); i++) {
                DescribeRouteTablesResponse.RouteTable routeTable = new DescribeRouteTablesResponse.RouteTable()
                {
                    VRouterId = context.StringValue($"DescribeRouteTables.RouteTables[{i}].VRouterId"),
                    RouteTableId = context.StringValue($"DescribeRouteTables.RouteTables[{i}].RouteTableId"),
                    RouteTableType = context.StringValue($"DescribeRouteTables.RouteTables[{i}].RouteTableType"),
                    CreationTime = context.StringValue($"DescribeRouteTables.RouteTables[{i}].CreationTime")
                };
                List<DescribeRouteTablesResponse.RouteTable.RouteEntry> routeEntrys = new List<DescribeRouteTablesResponse.RouteTable.RouteEntry>();
				for (int j = 0; j < context.Length($"DescribeRouteTables.RouteTables[{i}].RouteEntrys.Length"); j++) {
                    DescribeRouteTablesResponse.RouteTable.RouteEntry routeEntry = new DescribeRouteTablesResponse.RouteTable.RouteEntry()
                    {
                        RouteTableId = context.StringValue($"DescribeRouteTables.RouteTables[{i}].RouteEntrys[{j}].RouteTableId"),
                        DestinationCidrBlock = context.StringValue($"DescribeRouteTables.RouteTables[{i}].RouteEntrys[{j}].DestinationCidrBlock"),
                        Type = context.StringValue($"DescribeRouteTables.RouteTables[{i}].RouteEntrys[{j}].Type"),
                        Status = context.StringValue($"DescribeRouteTables.RouteTables[{i}].RouteEntrys[{j}].Status"),
                        InstanceId = context.StringValue($"DescribeRouteTables.RouteTables[{i}].RouteEntrys[{j}].InstanceId"),
                        NextHopType = context.StringValue($"DescribeRouteTables.RouteTables[{i}].RouteEntrys[{j}].NextHopType")
                    };
                    List<DescribeRouteTablesResponse.RouteTable.RouteEntry.NextHop> nextHops = new List<DescribeRouteTablesResponse.RouteTable.RouteEntry.NextHop>();
					for (int k = 0; k < context.Length($"DescribeRouteTables.RouteTables[{i}].RouteEntrys[{j}].NextHops.Length"); k++) {
                        DescribeRouteTablesResponse.RouteTable.RouteEntry.NextHop nextHop = new DescribeRouteTablesResponse.RouteTable.RouteEntry.NextHop()
                        {
                            NextHopType = context.StringValue($"DescribeRouteTables.RouteTables[{i}].RouteEntrys[{j}].NextHops[" + k + "].NextHopType"),
                            NextHopId = context.StringValue($"DescribeRouteTables.RouteTables[{i}].RouteEntrys[{j}].NextHops[" + k + "].NextHopId")
                        };
                        nextHops.Add(nextHop);
					}
					routeEntry.NextHops = nextHops;

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