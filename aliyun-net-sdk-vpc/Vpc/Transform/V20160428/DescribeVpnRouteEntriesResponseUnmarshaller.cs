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
    public class DescribeVpnRouteEntriesResponseUnmarshaller
    {
        public static DescribeVpnRouteEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVpnRouteEntriesResponse describeVpnRouteEntriesResponse = new DescribeVpnRouteEntriesResponse();

			describeVpnRouteEntriesResponse.HttpResponse = _ctx.HttpResponse;
			describeVpnRouteEntriesResponse.PageSize = _ctx.IntegerValue("DescribeVpnRouteEntries.PageSize");
			describeVpnRouteEntriesResponse.RequestId = _ctx.StringValue("DescribeVpnRouteEntries.RequestId");
			describeVpnRouteEntriesResponse.PageNumber = _ctx.IntegerValue("DescribeVpnRouteEntries.PageNumber");
			describeVpnRouteEntriesResponse.TotalCount = _ctx.IntegerValue("DescribeVpnRouteEntries.TotalCount");

			List<DescribeVpnRouteEntriesResponse.DescribeVpnRouteEntries_VpnRouteEntry> describeVpnRouteEntriesResponse_vpnRouteEntries = new List<DescribeVpnRouteEntriesResponse.DescribeVpnRouteEntries_VpnRouteEntry>();
			for (int i = 0; i < _ctx.Length("DescribeVpnRouteEntries.VpnRouteEntries.Length"); i++) {
				DescribeVpnRouteEntriesResponse.DescribeVpnRouteEntries_VpnRouteEntry vpnRouteEntry = new DescribeVpnRouteEntriesResponse.DescribeVpnRouteEntries_VpnRouteEntry();
				vpnRouteEntry.RouteEntryType = _ctx.StringValue("DescribeVpnRouteEntries.VpnRouteEntries["+ i +"].RouteEntryType");
				vpnRouteEntry.NextHop = _ctx.StringValue("DescribeVpnRouteEntries.VpnRouteEntries["+ i +"].NextHop");
				vpnRouteEntry.Weight = _ctx.IntegerValue("DescribeVpnRouteEntries.VpnRouteEntries["+ i +"].Weight");
				vpnRouteEntry.RouteDest = _ctx.StringValue("DescribeVpnRouteEntries.VpnRouteEntries["+ i +"].RouteDest");
				vpnRouteEntry.AsPath = _ctx.StringValue("DescribeVpnRouteEntries.VpnRouteEntries["+ i +"].AsPath");
				vpnRouteEntry.State = _ctx.StringValue("DescribeVpnRouteEntries.VpnRouteEntries["+ i +"].State");
				vpnRouteEntry.CreateTime = _ctx.LongValue("DescribeVpnRouteEntries.VpnRouteEntries["+ i +"].CreateTime");
				vpnRouteEntry.Community = _ctx.StringValue("DescribeVpnRouteEntries.VpnRouteEntries["+ i +"].Community");
				vpnRouteEntry.Source = _ctx.StringValue("DescribeVpnRouteEntries.VpnRouteEntries["+ i +"].Source");
				vpnRouteEntry.VpnInstanceId = _ctx.StringValue("DescribeVpnRouteEntries.VpnRouteEntries["+ i +"].VpnInstanceId");

				describeVpnRouteEntriesResponse_vpnRouteEntries.Add(vpnRouteEntry);
			}
			describeVpnRouteEntriesResponse.VpnRouteEntries = describeVpnRouteEntriesResponse_vpnRouteEntries;
        
			return describeVpnRouteEntriesResponse;
        }
    }
}
