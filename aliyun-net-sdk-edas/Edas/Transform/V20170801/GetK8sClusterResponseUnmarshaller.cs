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
    public class GetK8sClusterResponseUnmarshaller
    {
        public static GetK8sClusterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetK8sClusterResponse getK8sClusterResponse = new GetK8sClusterResponse();

			getK8sClusterResponse.HttpResponse = _ctx.HttpResponse;
			getK8sClusterResponse.RequestId = _ctx.StringValue("GetK8sCluster.RequestId");
			getK8sClusterResponse.Code = _ctx.IntegerValue("GetK8sCluster.Code");
			getK8sClusterResponse.Message = _ctx.StringValue("GetK8sCluster.Message");

			GetK8sClusterResponse.GetK8sCluster_ClusterPage clusterPage = new GetK8sClusterResponse.GetK8sCluster_ClusterPage();
			clusterPage.CurrentPage = _ctx.IntegerValue("GetK8sCluster.ClusterPage.CurrentPage");
			clusterPage.PageSize = _ctx.IntegerValue("GetK8sCluster.ClusterPage.PageSize");
			clusterPage.TotalSize = _ctx.IntegerValue("GetK8sCluster.ClusterPage.TotalSize");

			List<GetK8sClusterResponse.GetK8sCluster_ClusterPage.GetK8sCluster_Cluster> clusterPage_clusterList = new List<GetK8sClusterResponse.GetK8sCluster_ClusterPage.GetK8sCluster_Cluster>();
			for (int i = 0; i < _ctx.Length("GetK8sCluster.ClusterPage.ClusterList.Length"); i++) {
				GetK8sClusterResponse.GetK8sCluster_ClusterPage.GetK8sCluster_Cluster cluster = new GetK8sClusterResponse.GetK8sCluster_ClusterPage.GetK8sCluster_Cluster();
				cluster.ClusterId = _ctx.StringValue("GetK8sCluster.ClusterPage.ClusterList["+ i +"].ClusterId");
				cluster.ClusterImportStatus = _ctx.IntegerValue("GetK8sCluster.ClusterPage.ClusterList["+ i +"].ClusterImportStatus");
				cluster.ClusterName = _ctx.StringValue("GetK8sCluster.ClusterPage.ClusterList["+ i +"].ClusterName");
				cluster.ClusterStatus = _ctx.IntegerValue("GetK8sCluster.ClusterPage.ClusterList["+ i +"].ClusterStatus");
				cluster.ClusterType = _ctx.IntegerValue("GetK8sCluster.ClusterPage.ClusterList["+ i +"].ClusterType");
				cluster.RegionId = _ctx.StringValue("GetK8sCluster.ClusterPage.ClusterList["+ i +"].RegionId");
				cluster.VpcId = _ctx.StringValue("GetK8sCluster.ClusterPage.ClusterList["+ i +"].VpcId");
				cluster.VswitchId = _ctx.StringValue("GetK8sCluster.ClusterPage.ClusterList["+ i +"].VswitchId");
				cluster.SubNetCidr = _ctx.StringValue("GetK8sCluster.ClusterPage.ClusterList["+ i +"].SubNetCidr");
				cluster.CsClusterStatus = _ctx.StringValue("GetK8sCluster.ClusterPage.ClusterList["+ i +"].CsClusterStatus");
				cluster.CsClusterId = _ctx.StringValue("GetK8sCluster.ClusterPage.ClusterList["+ i +"].CsClusterId");
				cluster.Description = _ctx.StringValue("GetK8sCluster.ClusterPage.ClusterList["+ i +"].Description");
				cluster.NodeNum = _ctx.IntegerValue("GetK8sCluster.ClusterPage.ClusterList["+ i +"].NodeNum");
				cluster.Cpu = _ctx.IntegerValue("GetK8sCluster.ClusterPage.ClusterList["+ i +"].Cpu");
				cluster.Mem = _ctx.IntegerValue("GetK8sCluster.ClusterPage.ClusterList["+ i +"].Mem");
				cluster.NetworkMode = _ctx.IntegerValue("GetK8sCluster.ClusterPage.ClusterList["+ i +"].NetworkMode");

				clusterPage_clusterList.Add(cluster);
			}
			clusterPage.ClusterList = clusterPage_clusterList;
			getK8sClusterResponse.ClusterPage = clusterPage;
        
			return getK8sClusterResponse;
        }
    }
}
