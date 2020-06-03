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
using Aliyun.Acs.Cassandra.Model.V20190101;

namespace Aliyun.Acs.Cassandra.Transform.V20190101
{
    public class DescribeClusterResponseUnmarshaller
    {
        public static DescribeClusterResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeClusterResponse describeClusterResponse = new DescribeClusterResponse();

			describeClusterResponse.HttpResponse = context.HttpResponse;
			describeClusterResponse.RequestId = context.StringValue("DescribeCluster.RequestId");

			DescribeClusterResponse.DescribeCluster_Cluster cluster = new DescribeClusterResponse.DescribeCluster_Cluster();
			cluster.ClusterId = context.StringValue("DescribeCluster.Cluster.ClusterId");
			cluster.ClusterName = context.StringValue("DescribeCluster.Cluster.ClusterName");
			cluster.Status = context.StringValue("DescribeCluster.Cluster.Status");
			cluster.PayType = context.StringValue("DescribeCluster.Cluster.PayType");
			cluster.CreatedTime = context.StringValue("DescribeCluster.Cluster.CreatedTime");
			cluster.ExpireTime = context.StringValue("DescribeCluster.Cluster.ExpireTime");
			cluster.MajorVersion = context.StringValue("DescribeCluster.Cluster.MajorVersion");
			cluster.MinorVersion = context.StringValue("DescribeCluster.Cluster.MinorVersion");
			cluster.DataCenterCount = context.IntegerValue("DescribeCluster.Cluster.DataCenterCount");
			cluster.IsLatestVersion = context.BooleanValue("DescribeCluster.Cluster.IsLatestVersion");
			cluster.MaintainStartTime = context.StringValue("DescribeCluster.Cluster.MaintainStartTime");
			cluster.MaintainEndTime = context.StringValue("DescribeCluster.Cluster.MaintainEndTime");
			cluster.LockMode = context.StringValue("DescribeCluster.Cluster.LockMode");
			cluster.AutoRenewal = context.BooleanValue("DescribeCluster.Cluster.AutoRenewal");
			cluster.AutoRenewPeriod = context.IntegerValue("DescribeCluster.Cluster.AutoRenewPeriod");

			List<DescribeClusterResponse.DescribeCluster_Cluster.DescribeCluster_Tag> cluster_tags = new List<DescribeClusterResponse.DescribeCluster_Cluster.DescribeCluster_Tag>();
			for (int i = 0; i < context.Length("DescribeCluster.Cluster.Tags.Length"); i++) {
				DescribeClusterResponse.DescribeCluster_Cluster.DescribeCluster_Tag tag = new DescribeClusterResponse.DescribeCluster_Cluster.DescribeCluster_Tag();
				tag.Key = context.StringValue("DescribeCluster.Cluster.Tags["+ i +"].Key");
				tag._Value = context.StringValue("DescribeCluster.Cluster.Tags["+ i +"].Value");

				cluster_tags.Add(tag);
			}
			cluster.Tags = cluster_tags;
			describeClusterResponse.Cluster = cluster;
        
			return describeClusterResponse;
        }
    }
}
