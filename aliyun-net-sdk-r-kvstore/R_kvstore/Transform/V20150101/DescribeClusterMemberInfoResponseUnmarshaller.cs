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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeClusterMemberInfoResponseUnmarshaller
    {
        public static DescribeClusterMemberInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClusterMemberInfoResponse describeClusterMemberInfoResponse = new DescribeClusterMemberInfoResponse();

			describeClusterMemberInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeClusterMemberInfoResponse.RequestId = _ctx.StringValue("DescribeClusterMemberInfo.RequestId");
			describeClusterMemberInfoResponse.PageNumber = _ctx.IntegerValue("DescribeClusterMemberInfo.PageNumber");
			describeClusterMemberInfoResponse.PageSize = _ctx.IntegerValue("DescribeClusterMemberInfo.PageSize");
			describeClusterMemberInfoResponse.TotalCount = _ctx.IntegerValue("DescribeClusterMemberInfo.TotalCount");

			List<DescribeClusterMemberInfoResponse.DescribeClusterMemberInfo_Children> describeClusterMemberInfoResponse_clusterChildren = new List<DescribeClusterMemberInfoResponse.DescribeClusterMemberInfo_Children>();
			for (int i = 0; i < _ctx.Length("DescribeClusterMemberInfo.ClusterChildren.Length"); i++) {
				DescribeClusterMemberInfoResponse.DescribeClusterMemberInfo_Children children = new DescribeClusterMemberInfoResponse.DescribeClusterMemberInfo_Children();
				children.Id = _ctx.LongValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Id");
				children.Name = _ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Name");
				children.BizType = _ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].BizType");
				children.ReplicaSize = _ctx.IntegerValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].ReplicaSize");
				children.Modifier = _ctx.IntegerValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Modifier");
				children.ServiceVersion = _ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].ServiceVersion");
				children.DiskSizeMB = _ctx.IntegerValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].DiskSizeMB");
				children.Nickname = _ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Nickname");
				children.PrimaryInsName = _ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].PrimaryInsName");
				children.ClassCode = _ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].ClassCode");
				children.Creator = _ctx.IntegerValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Creator");
				children.ResourceGroupName = _ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].ResourceGroupName");
				children.Health = _ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Health");
				children.BinlogRetentionDays = _ctx.IntegerValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].BinlogRetentionDays");
				children.UserId = _ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].UserId");
				children.LockReason = _ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].LockReason");
				children.Service = _ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Service");
				children.Capacity = _ctx.LongValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Capacity");
				children.BandWidth = _ctx.LongValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].BandWidth");
				children.Connections = _ctx.LongValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Connections");
				children.CurrentBandWidth = _ctx.LongValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].CurrentBandWidth");

				List<DescribeClusterMemberInfoResponse.DescribeClusterMemberInfo_Children.DescribeClusterMemberInfo_Item> children_items = new List<DescribeClusterMemberInfoResponse.DescribeClusterMemberInfo_Children.DescribeClusterMemberInfo_Item>();
				for (int j = 0; j < _ctx.Length("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Items.Length"); j++) {
					DescribeClusterMemberInfoResponse.DescribeClusterMemberInfo_Children.DescribeClusterMemberInfo_Item item = new DescribeClusterMemberInfoResponse.DescribeClusterMemberInfo_Children.DescribeClusterMemberInfo_Item();
					item.Id = _ctx.IntegerValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Items["+ j +"].Id");
					item.HostName = _ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Items["+ j +"].HostName");
					item.Role = _ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Items["+ j +"].Role");
					item.Status = _ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Items["+ j +"].Status");
					item.ZoneId = _ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Items["+ j +"].ZoneId");
					item.Ip = _ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Items["+ j +"].Ip");

					List<string> item_ports = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Items["+ j +"].Ports.Length"); k++) {
						item_ports.Add(_ctx.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Items["+ j +"].Ports["+ k +"]"));
					}
					item.Ports = item_ports;

					children_items.Add(item);
				}
				children.Items = children_items;

				describeClusterMemberInfoResponse_clusterChildren.Add(children);
			}
			describeClusterMemberInfoResponse.ClusterChildren = describeClusterMemberInfoResponse_clusterChildren;
        
			return describeClusterMemberInfoResponse;
        }
    }
}
