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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListClusterResponseUnmarshaller
    {
        public static ListClusterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterResponse listClusterResponse = new ListClusterResponse();

			listClusterResponse.HttpResponse = _ctx.HttpResponse;
			listClusterResponse.Code = _ctx.IntegerValue("ListCluster.Code");
			listClusterResponse.Message = _ctx.StringValue("ListCluster.Message");
			listClusterResponse.RequestId = _ctx.StringValue("ListCluster.RequestId");

			List<ListClusterResponse.ListCluster_Cluster> listClusterResponse_clusterList = new List<ListClusterResponse.ListCluster_Cluster>();
			for (int i = 0; i < _ctx.Length("ListCluster.ClusterList.Length"); i++) {
				ListClusterResponse.ListCluster_Cluster cluster = new ListClusterResponse.ListCluster_Cluster();
				cluster.ClusterId = _ctx.StringValue("ListCluster.ClusterList["+ i +"].ClusterId");
				cluster.RegionId = _ctx.StringValue("ListCluster.ClusterList["+ i +"].RegionId");
				cluster.Description = _ctx.StringValue("ListCluster.ClusterList["+ i +"].Description");
				cluster.ClusterName = _ctx.StringValue("ListCluster.ClusterList["+ i +"].ClusterName");
				cluster.ClusterType = _ctx.IntegerValue("ListCluster.ClusterList["+ i +"].ClusterType");
				cluster.OversoldFactor = _ctx.IntegerValue("ListCluster.ClusterList["+ i +"].OversoldFactor");
				cluster.NetworkMode = _ctx.IntegerValue("ListCluster.ClusterList["+ i +"].NetworkMode");
				cluster.VpcId = _ctx.StringValue("ListCluster.ClusterList["+ i +"].VpcId");
				cluster.NodeNum = _ctx.IntegerValue("ListCluster.ClusterList["+ i +"].NodeNum");
				cluster.Cpu = _ctx.IntegerValue("ListCluster.ClusterList["+ i +"].Cpu");
				cluster.Mem = _ctx.IntegerValue("ListCluster.ClusterList["+ i +"].Mem");
				cluster.CpuUsed = _ctx.IntegerValue("ListCluster.ClusterList["+ i +"].CpuUsed");
				cluster.MemUsed = _ctx.IntegerValue("ListCluster.ClusterList["+ i +"].MemUsed");
				cluster.CreateTime = _ctx.LongValue("ListCluster.ClusterList["+ i +"].CreateTime");
				cluster.UpdateTime = _ctx.LongValue("ListCluster.ClusterList["+ i +"].UpdateTime");
				cluster.IaasProvider = _ctx.StringValue("ListCluster.ClusterList["+ i +"].IaasProvider");
				cluster.CsClusterId = _ctx.StringValue("ListCluster.ClusterList["+ i +"].CsClusterId");
				cluster.ResourceGroupId = _ctx.StringValue("ListCluster.ClusterList["+ i +"].ResourceGroupId");

				listClusterResponse_clusterList.Add(cluster);
			}
			listClusterResponse.ClusterList = listClusterResponse_clusterList;
        
			return listClusterResponse;
        }
    }
}
