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
    public class GetClusterResponseUnmarshaller
    {
        public static GetClusterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetClusterResponse getClusterResponse = new GetClusterResponse();

			getClusterResponse.HttpResponse = _ctx.HttpResponse;
			getClusterResponse.RequestId = _ctx.StringValue("GetCluster.RequestId");
			getClusterResponse.Code = _ctx.IntegerValue("GetCluster.Code");
			getClusterResponse.Message = _ctx.StringValue("GetCluster.Message");

			GetClusterResponse.GetCluster_Cluster cluster = new GetClusterResponse.GetCluster_Cluster();
			cluster.ClusterId = _ctx.StringValue("GetCluster.Cluster.ClusterId");
			cluster.RegionId = _ctx.StringValue("GetCluster.Cluster.RegionId");
			cluster.Description = _ctx.StringValue("GetCluster.Cluster.Description");
			cluster.ClusterName = _ctx.StringValue("GetCluster.Cluster.ClusterName");
			cluster.ClusterType = _ctx.IntegerValue("GetCluster.Cluster.ClusterType");
			cluster.OversoldFactor = _ctx.IntegerValue("GetCluster.Cluster.OversoldFactor");
			cluster.NetworkMode = _ctx.IntegerValue("GetCluster.Cluster.NetworkMode");
			cluster.VpcId = _ctx.StringValue("GetCluster.Cluster.VpcId");
			cluster.NodeNum = _ctx.IntegerValue("GetCluster.Cluster.NodeNum");
			cluster.Cpu = _ctx.IntegerValue("GetCluster.Cluster.Cpu");
			cluster.Mem = _ctx.IntegerValue("GetCluster.Cluster.Mem");
			cluster.CpuUsed = _ctx.IntegerValue("GetCluster.Cluster.CpuUsed");
			cluster.MemUsed = _ctx.IntegerValue("GetCluster.Cluster.MemUsed");
			cluster.CreateTime = _ctx.LongValue("GetCluster.Cluster.CreateTime");
			cluster.UpdateTime = _ctx.LongValue("GetCluster.Cluster.UpdateTime");
			cluster.IaasProvider = _ctx.StringValue("GetCluster.Cluster.IaasProvider");
			cluster.CsClusterId = _ctx.StringValue("GetCluster.Cluster.CsClusterId");
			cluster.ClusterImportStatus = _ctx.IntegerValue("GetCluster.Cluster.ClusterImportStatus");
			getClusterResponse.Cluster = cluster;
        
			return getClusterResponse;
        }
    }
}
