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
        public static DescribeDeletedClustersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDeletedClustersResponse describeDeletedClustersResponse = new DescribeDeletedClustersResponse();

			describeDeletedClustersResponse.HttpResponse = _ctx.HttpResponse;
			describeDeletedClustersResponse.RequestId = _ctx.StringValue("DescribeDeletedClusters.RequestId");
			describeDeletedClustersResponse.TotalCount = _ctx.LongValue("DescribeDeletedClusters.TotalCount");
			describeDeletedClustersResponse.PageNumber = _ctx.IntegerValue("DescribeDeletedClusters.PageNumber");
			describeDeletedClustersResponse.PageSize = _ctx.IntegerValue("DescribeDeletedClusters.PageSize");

			List<DescribeDeletedClustersResponse.DescribeDeletedClusters_Cluster> describeDeletedClustersResponse_clusters = new List<DescribeDeletedClustersResponse.DescribeDeletedClusters_Cluster>();
			for (int i = 0; i < _ctx.Length("DescribeDeletedClusters.Clusters.Length"); i++) {
				DescribeDeletedClustersResponse.DescribeDeletedClusters_Cluster cluster = new DescribeDeletedClustersResponse.DescribeDeletedClusters_Cluster();
				cluster.ClusterId = _ctx.StringValue("DescribeDeletedClusters.Clusters["+ i +"].ClusterId");
				cluster.ClusterName = _ctx.StringValue("DescribeDeletedClusters.Clusters["+ i +"].ClusterName");
				cluster.Status = _ctx.StringValue("DescribeDeletedClusters.Clusters["+ i +"].Status");
				cluster.PayType = _ctx.StringValue("DescribeDeletedClusters.Clusters["+ i +"].PayType");
				cluster.CreatedTime = _ctx.StringValue("DescribeDeletedClusters.Clusters["+ i +"].CreatedTime");
				cluster.ExpireTime = _ctx.StringValue("DescribeDeletedClusters.Clusters["+ i +"].ExpireTime");
				cluster.MajorVersion = _ctx.StringValue("DescribeDeletedClusters.Clusters["+ i +"].MajorVersion");
				cluster.MinorVersion = _ctx.StringValue("DescribeDeletedClusters.Clusters["+ i +"].MinorVersion");
				cluster.DataCenterCount = _ctx.IntegerValue("DescribeDeletedClusters.Clusters["+ i +"].DataCenterCount");

				describeDeletedClustersResponse_clusters.Add(cluster);
			}
			describeDeletedClustersResponse.Clusters = describeDeletedClustersResponse_clusters;
        
			return describeDeletedClustersResponse;
        }
    }
}
