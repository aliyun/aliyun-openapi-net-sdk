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
    public class DescribeVpnPbrRouteEntriesResponseUnmarshaller
    {
        public static DescribeVpnPbrRouteEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVpnPbrRouteEntriesResponse describeVpnPbrRouteEntriesResponse = new DescribeVpnPbrRouteEntriesResponse();

			describeVpnPbrRouteEntriesResponse.HttpResponse = _ctx.HttpResponse;
			describeVpnPbrRouteEntriesResponse.RequestId = _ctx.StringValue("DescribeVpnPbrRouteEntries.RequestId");
			describeVpnPbrRouteEntriesResponse.TotalCount = _ctx.IntegerValue("DescribeVpnPbrRouteEntries.TotalCount");
			describeVpnPbrRouteEntriesResponse.PageNumber = _ctx.IntegerValue("DescribeVpnPbrRouteEntries.PageNumber");
			describeVpnPbrRouteEntriesResponse.PageSize = _ctx.IntegerValue("DescribeVpnPbrRouteEntries.PageSize");

			List<DescribeVpnPbrRouteEntriesResponse.DescribeVpnPbrRouteEntries_VpnPbrRouteEntry> describeVpnPbrRouteEntriesResponse_vpnPbrRouteEntries = new List<DescribeVpnPbrRouteEntriesResponse.DescribeVpnPbrRouteEntries_VpnPbrRouteEntry>();
			for (int i = 0; i < _ctx.Length("DescribeVpnPbrRouteEntries.VpnPbrRouteEntries.Length"); i++) {
				DescribeVpnPbrRouteEntriesResponse.DescribeVpnPbrRouteEntries_VpnPbrRouteEntry vpnPbrRouteEntry = new DescribeVpnPbrRouteEntriesResponse.DescribeVpnPbrRouteEntries_VpnPbrRouteEntry();
				vpnPbrRouteEntry.VpnInstanceId = _ctx.StringValue("DescribeVpnPbrRouteEntries.VpnPbrRouteEntries["+ i +"].VpnInstanceId");
				vpnPbrRouteEntry.RouteSource = _ctx.StringValue("DescribeVpnPbrRouteEntries.VpnPbrRouteEntries["+ i +"].RouteSource");
				vpnPbrRouteEntry.RouteDest = _ctx.StringValue("DescribeVpnPbrRouteEntries.VpnPbrRouteEntries["+ i +"].RouteDest");
				vpnPbrRouteEntry.NextHop = _ctx.StringValue("DescribeVpnPbrRouteEntries.VpnPbrRouteEntries["+ i +"].NextHop");
				vpnPbrRouteEntry.Weight = _ctx.IntegerValue("DescribeVpnPbrRouteEntries.VpnPbrRouteEntries["+ i +"].Weight");
				vpnPbrRouteEntry.CreateTime = _ctx.LongValue("DescribeVpnPbrRouteEntries.VpnPbrRouteEntries["+ i +"].CreateTime");
				vpnPbrRouteEntry.State = _ctx.StringValue("DescribeVpnPbrRouteEntries.VpnPbrRouteEntries["+ i +"].State");

				describeVpnPbrRouteEntriesResponse_vpnPbrRouteEntries.Add(vpnPbrRouteEntry);
			}
			describeVpnPbrRouteEntriesResponse.VpnPbrRouteEntries = describeVpnPbrRouteEntriesResponse_vpnPbrRouteEntries;
        
			return describeVpnPbrRouteEntriesResponse;
        }
    }
}
