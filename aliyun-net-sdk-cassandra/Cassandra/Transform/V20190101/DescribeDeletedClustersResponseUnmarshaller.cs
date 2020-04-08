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
    public class DescribeDeletedClustersResponseUnmarshaller
    {
        public static DescribeDeletedClustersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDeletedClustersResponse describeDeletedClustersResponse = new DescribeDeletedClustersResponse();

			describeDeletedClustersResponse.HttpResponse = context.HttpResponse;
			describeDeletedClustersResponse.RequestId = context.StringValue("DescribeDeletedClusters.RequestId");
			describeDeletedClustersResponse.TotalCount = context.LongValue("DescribeDeletedClusters.TotalCount");
			describeDeletedClustersResponse.PageNumber = context.IntegerValue("DescribeDeletedClusters.PageNumber");
			describeDeletedClustersResponse.PageSize = context.IntegerValue("DescribeDeletedClusters.PageSize");

			List<DescribeDeletedClustersResponse.DescribeDeletedClusters_Cluster> describeDeletedClustersResponse_clusters = new List<DescribeDeletedClustersResponse.DescribeDeletedClusters_Cluster>();
			for (int i = 0; i < context.Length("DescribeDeletedClusters.Clusters.Length"); i++) {
				DescribeDeletedClustersResponse.DescribeDeletedClusters_Cluster cluster = new DescribeDeletedClustersResponse.DescribeDeletedClusters_Cluster();
				cluster.ClusterId = context.StringValue("DescribeDeletedClusters.Clusters["+ i +"].ClusterId");
				cluster.ClusterName = context.StringValue("DescribeDeletedClusters.Clusters["+ i +"].ClusterName");
				cluster.Status = context.StringValue("DescribeDeletedClusters.Clusters["+ i +"].Status");
				cluster.PayType = context.StringValue("DescribeDeletedClusters.Clusters["+ i +"].PayType");
				cluster.CreatedTime = context.StringValue("DescribeDeletedClusters.Clusters["+ i +"].CreatedTime");
				cluster.ExpireTime = context.StringValue("DescribeDeletedClusters.Clusters["+ i +"].ExpireTime");
				cluster.MajorVersion = context.StringValue("DescribeDeletedClusters.Clusters["+ i +"].MajorVersion");
				cluster.MinorVersion = context.StringValue("DescribeDeletedClusters.Clusters["+ i +"].MinorVersion");
				cluster.DataCenterCount = context.IntegerValue("DescribeDeletedClusters.Clusters["+ i +"].DataCenterCount");

				describeDeletedClustersResponse_clusters.Add(cluster);
			}
			describeDeletedClustersResponse.Clusters = describeDeletedClustersResponse_clusters;
        
			return describeDeletedClustersResponse;
        }
    }
}
