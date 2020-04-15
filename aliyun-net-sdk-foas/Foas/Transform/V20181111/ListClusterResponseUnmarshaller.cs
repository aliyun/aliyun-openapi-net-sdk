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
using Aliyun.Acs.foas.Model.V20181111;

namespace Aliyun.Acs.foas.Transform.V20181111
{
    public class ListClusterResponseUnmarshaller
    {
        public static ListClusterResponse Unmarshall(UnmarshallerContext context)
        {
			ListClusterResponse listClusterResponse = new ListClusterResponse();

			listClusterResponse.HttpResponse = context.HttpResponse;
			listClusterResponse.RequestId = context.StringValue("ListCluster.RequestId");
			listClusterResponse.TotalCount = context.LongValue("ListCluster.TotalCount");
			listClusterResponse.TotalPage = context.IntegerValue("ListCluster.TotalPage");
			listClusterResponse.PageIndex = context.IntegerValue("ListCluster.PageIndex");
			listClusterResponse.PageSize = context.IntegerValue("ListCluster.PageSize");

			List<ListClusterResponse.ListCluster_Cluster> listClusterResponse_clusters = new List<ListClusterResponse.ListCluster_Cluster>();
			for (int i = 0; i < context.Length("ListCluster.Clusters.Length"); i++) {
				ListClusterResponse.ListCluster_Cluster cluster = new ListClusterResponse.ListCluster_Cluster();
				cluster.ClusterId = context.StringValue("ListCluster.Clusters["+ i +"].ClusterId");
				cluster.RegionId = context.StringValue("ListCluster.Clusters["+ i +"].RegionId");
				cluster.ZoneId = context.StringValue("ListCluster.Clusters["+ i +"].ZoneId");
				cluster.State = context.StringValue("ListCluster.Clusters["+ i +"].State");
				cluster.OwnerId = context.StringValue("ListCluster.Clusters["+ i +"].OwnerId");
				cluster._Operator = context.StringValue("ListCluster.Clusters["+ i +"].Operator");
				cluster.DisplayName = context.StringValue("ListCluster.Clusters["+ i +"].DisplayName");
				cluster.Description = context.StringValue("ListCluster.Clusters["+ i +"].Description");
				cluster.GmtCreate = context.LongValue("ListCluster.Clusters["+ i +"].GmtCreate");
				cluster.GmtModified = context.LongValue("ListCluster.Clusters["+ i +"].GmtModified");

				listClusterResponse_clusters.Add(cluster);
			}
			listClusterResponse.Clusters = listClusterResponse_clusters;
        
			return listClusterResponse;
        }
    }
}
