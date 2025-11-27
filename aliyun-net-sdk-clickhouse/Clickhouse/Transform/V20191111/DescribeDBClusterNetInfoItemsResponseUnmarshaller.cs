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
using Aliyun.Acs.clickhouse.Model.V20191111;

namespace Aliyun.Acs.clickhouse.Transform.V20191111
{
    public class DescribeDBClusterNetInfoItemsResponseUnmarshaller
    {
        public static DescribeDBClusterNetInfoItemsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterNetInfoItemsResponse describeDBClusterNetInfoItemsResponse = new DescribeDBClusterNetInfoItemsResponse();

			describeDBClusterNetInfoItemsResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterNetInfoItemsResponse.ClusterNetworkType = _ctx.StringValue("DescribeDBClusterNetInfoItems.ClusterNetworkType");
			describeDBClusterNetInfoItemsResponse.RequestId = _ctx.StringValue("DescribeDBClusterNetInfoItems.RequestId");
			describeDBClusterNetInfoItemsResponse.EnableSLB = _ctx.BooleanValue("DescribeDBClusterNetInfoItems.EnableSLB");

			List<DescribeDBClusterNetInfoItemsResponse.DescribeDBClusterNetInfoItems_NetInfoItem> describeDBClusterNetInfoItemsResponse_netInfoItems = new List<DescribeDBClusterNetInfoItemsResponse.DescribeDBClusterNetInfoItems_NetInfoItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterNetInfoItems.NetInfoItems.Length"); i++) {
				DescribeDBClusterNetInfoItemsResponse.DescribeDBClusterNetInfoItems_NetInfoItem netInfoItem = new DescribeDBClusterNetInfoItemsResponse.DescribeDBClusterNetInfoItems_NetInfoItem();
				netInfoItem.VpcId = _ctx.StringValue("DescribeDBClusterNetInfoItems.NetInfoItems["+ i +"].VpcId");
				netInfoItem.VSwitchId = _ctx.StringValue("DescribeDBClusterNetInfoItems.NetInfoItems["+ i +"].VSwitchId");
				netInfoItem.ConnectionString = _ctx.StringValue("DescribeDBClusterNetInfoItems.NetInfoItems["+ i +"].ConnectionString");
				netInfoItem.JdbcPort = _ctx.StringValue("DescribeDBClusterNetInfoItems.NetInfoItems["+ i +"].JdbcPort");
				netInfoItem.NetType = _ctx.StringValue("DescribeDBClusterNetInfoItems.NetInfoItems["+ i +"].NetType");
				netInfoItem.HttpPort = _ctx.StringValue("DescribeDBClusterNetInfoItems.NetInfoItems["+ i +"].HttpPort");
				netInfoItem.IPAddress = _ctx.StringValue("DescribeDBClusterNetInfoItems.NetInfoItems["+ i +"].IPAddress");
				netInfoItem.HttpsPort = _ctx.StringValue("DescribeDBClusterNetInfoItems.NetInfoItems["+ i +"].HttpsPort");
				netInfoItem.MySQLPort = _ctx.StringValue("DescribeDBClusterNetInfoItems.NetInfoItems["+ i +"].MySQLPort");

				describeDBClusterNetInfoItemsResponse_netInfoItems.Add(netInfoItem);
			}
			describeDBClusterNetInfoItemsResponse.NetInfoItems = describeDBClusterNetInfoItemsResponse_netInfoItems;
        
			return describeDBClusterNetInfoItemsResponse;
        }
    }
}
