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
        public static DescribeClusterMemberInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeClusterMemberInfoResponse describeClusterMemberInfoResponse = new DescribeClusterMemberInfoResponse();

			describeClusterMemberInfoResponse.HttpResponse = context.HttpResponse;
			describeClusterMemberInfoResponse.RequestId = context.StringValue("DescribeClusterMemberInfo.RequestId");

			List<DescribeClusterMemberInfoResponse.DescribeClusterMemberInfo_Children> describeClusterMemberInfoResponse_clusterChildren = new List<DescribeClusterMemberInfoResponse.DescribeClusterMemberInfo_Children>();
			for (int i = 0; i < context.Length("DescribeClusterMemberInfo.ClusterChildren.Length"); i++) {
				DescribeClusterMemberInfoResponse.DescribeClusterMemberInfo_Children children = new DescribeClusterMemberInfoResponse.DescribeClusterMemberInfo_Children();
				children.Id = context.LongValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Id");
				children.Name = context.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Name");
				children.BizType = context.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].BizType");
				children.ReplicaSize = context.IntegerValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].ReplicaSize");
				children.Modifier = context.IntegerValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Modifier");
				children.ServiceVersion = context.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].ServiceVersion");
				children.ConnType = context.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].ConnType");
				children.DiskSizeMB = context.IntegerValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].DiskSizeMB");
				children.InsType = context.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].InsType");
				children.Nickname = context.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Nickname");
				children.PrimaryInsName = context.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].PrimaryInsName");
				children.ClassCode = context.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].ClassCode");
				children.Creator = context.IntegerValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Creator");
				children.ResourceGroupName = context.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].ResourceGroupName");
				children.LockMode = context.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].LockMode");
				children.Health = context.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Health");
				children.BinlogRetentionDays = context.IntegerValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].BinlogRetentionDays");
				children.UserId = context.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].UserId");
				children.LockReason = context.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].LockReason");
				children.Service = context.StringValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Service");
				children.Capacity = context.LongValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Capacity");
				children.BandWidth = context.LongValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].BandWidth");
				children.Connections = context.LongValue("DescribeClusterMemberInfo.ClusterChildren["+ i +"].Connections");

				describeClusterMemberInfoResponse_clusterChildren.Add(children);
			}
			describeClusterMemberInfoResponse.ClusterChildren = describeClusterMemberInfoResponse_clusterChildren;
        
			return describeClusterMemberInfoResponse;
        }
    }
}
