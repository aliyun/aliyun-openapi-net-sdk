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
    public class DescribeVcoRouteEntriesResponseUnmarshaller
    {
        public static DescribeVcoRouteEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVcoRouteEntriesResponse describeVcoRouteEntriesResponse = new DescribeVcoRouteEntriesResponse();

			describeVcoRouteEntriesResponse.HttpResponse = _ctx.HttpResponse;
			describeVcoRouteEntriesResponse.TotalCount = _ctx.IntegerValue("DescribeVcoRouteEntries.TotalCount");
			describeVcoRouteEntriesResponse.PageNumber = _ctx.IntegerValue("DescribeVcoRouteEntries.PageNumber");
			describeVcoRouteEntriesResponse.PageSize = _ctx.IntegerValue("DescribeVcoRouteEntries.PageSize");
			describeVcoRouteEntriesResponse.RequestId = _ctx.StringValue("DescribeVcoRouteEntries.RequestId");

			List<DescribeVcoRouteEntriesResponse.DescribeVcoRouteEntries_VcoRouteEntrie> describeVcoRouteEntriesResponse_vcoRouteEntries = new List<DescribeVcoRouteEntriesResponse.DescribeVcoRouteEntries_VcoRouteEntrie>();
			for (int i = 0; i < _ctx.Length("DescribeVcoRouteEntries.VcoRouteEntries.Length"); i++) {
				DescribeVcoRouteEntriesResponse.DescribeVcoRouteEntries_VcoRouteEntrie vcoRouteEntrie = new DescribeVcoRouteEntriesResponse.DescribeVcoRouteEntries_VcoRouteEntrie();
				vcoRouteEntrie.VpnConnectionId = _ctx.StringValue("DescribeVcoRouteEntries.VcoRouteEntries["+ i +"].VpnConnectionId");
				vcoRouteEntrie.RouteDest = _ctx.StringValue("DescribeVcoRouteEntries.VcoRouteEntries["+ i +"].RouteDest");
				vcoRouteEntrie.NextHop = _ctx.StringValue("DescribeVcoRouteEntries.VcoRouteEntries["+ i +"].NextHop");
				vcoRouteEntrie.Weight = _ctx.IntegerValue("DescribeVcoRouteEntries.VcoRouteEntries["+ i +"].Weight");
				vcoRouteEntrie.State = _ctx.StringValue("DescribeVcoRouteEntries.VcoRouteEntries["+ i +"].State");
				vcoRouteEntrie.RouteEntryType = _ctx.StringValue("DescribeVcoRouteEntries.VcoRouteEntries["+ i +"].RouteEntryType");
				vcoRouteEntrie.CreateTime = _ctx.LongValue("DescribeVcoRouteEntries.VcoRouteEntries["+ i +"].CreateTime");
				vcoRouteEntrie.AsPath = _ctx.StringValue("DescribeVcoRouteEntries.VcoRouteEntries["+ i +"].AsPath");
				vcoRouteEntrie.Community = _ctx.StringValue("DescribeVcoRouteEntries.VcoRouteEntries["+ i +"].Community");
				vcoRouteEntrie.Source = _ctx.StringValue("DescribeVcoRouteEntries.VcoRouteEntries["+ i +"].Source");

				describeVcoRouteEntriesResponse_vcoRouteEntries.Add(vcoRouteEntrie);
			}
			describeVcoRouteEntriesResponse.VcoRouteEntries = describeVcoRouteEntriesResponse_vcoRouteEntries;
        
			return describeVcoRouteEntriesResponse;
        }
    }
}
