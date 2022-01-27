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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class ListClusterResponseUnmarshaller
    {
        public static ListClusterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterResponse listClusterResponse = new ListClusterResponse();

			listClusterResponse.HttpResponse = _ctx.HttpResponse;
			listClusterResponse.Code = _ctx.IntegerValue("ListCluster.Code");
			listClusterResponse.ErrorMsg = _ctx.StringValue("ListCluster.ErrorMsg");
			listClusterResponse.PageNumber = _ctx.IntegerValue("ListCluster.PageNumber");
			listClusterResponse.PageSize = _ctx.IntegerValue("ListCluster.PageSize");
			listClusterResponse.RequestId = _ctx.StringValue("ListCluster.RequestId");
			listClusterResponse.TotalCount = _ctx.LongValue("ListCluster.TotalCount");

			List<ListClusterResponse.ListCluster_ClusterInfo> listClusterResponse_data = new List<ListClusterResponse.ListCluster_ClusterInfo>();
			for (int i = 0; i < _ctx.Length("ListCluster.Data.Length"); i++) {
				ListClusterResponse.ListCluster_ClusterInfo clusterInfo = new ListClusterResponse.ListCluster_ClusterInfo();
				clusterInfo.BusinessCode = _ctx.StringValue("ListCluster.Data["+ i +"].BusinessCode");
				clusterInfo.ClusterTitle = _ctx.StringValue("ListCluster.Data["+ i +"].ClusterTitle");
				clusterInfo.CreateStatus = _ctx.StringValue("ListCluster.Data["+ i +"].CreateStatus");
				clusterInfo.EnvType = _ctx.StringValue("ListCluster.Data["+ i +"].EnvType");
				clusterInfo.Id = _ctx.LongValue("ListCluster.Data["+ i +"].Id");
				clusterInfo.InstanceId = _ctx.StringValue("ListCluster.Data["+ i +"].InstanceId");
				clusterInfo.KeyPair = _ctx.StringValue("ListCluster.Data["+ i +"].KeyPair");
				clusterInfo.NetPlug = _ctx.StringValue("ListCluster.Data["+ i +"].NetPlug");
				clusterInfo.Password = _ctx.StringValue("ListCluster.Data["+ i +"].Password");
				clusterInfo.PodCIDR = _ctx.StringValue("ListCluster.Data["+ i +"].PodCIDR");
				clusterInfo.RegionId = _ctx.StringValue("ListCluster.Data["+ i +"].RegionId");
				clusterInfo.RegionName = _ctx.StringValue("ListCluster.Data["+ i +"].RegionName");
				clusterInfo.ServiceCIDR = _ctx.StringValue("ListCluster.Data["+ i +"].ServiceCIDR");
				clusterInfo.Status = _ctx.StringValue("ListCluster.Data["+ i +"].Status");
				clusterInfo.VpcId = _ctx.StringValue("ListCluster.Data["+ i +"].VpcId");
				clusterInfo.WorkLoadCpu = _ctx.StringValue("ListCluster.Data["+ i +"].WorkLoadCpu");
				clusterInfo.WorkLoadMem = _ctx.StringValue("ListCluster.Data["+ i +"].WorkLoadMem");

				List<string> clusterInfo_ecsIds = new List<string>();
				for (int j = 0; j < _ctx.Length("ListCluster.Data["+ i +"].EcsIds.Length"); j++) {
					clusterInfo_ecsIds.Add(_ctx.StringValue("ListCluster.Data["+ i +"].EcsIds["+ j +"]"));
				}
				clusterInfo.EcsIds = clusterInfo_ecsIds;

				List<string> clusterInfo_vswitchIds = new List<string>();
				for (int j = 0; j < _ctx.Length("ListCluster.Data["+ i +"].VswitchIds.Length"); j++) {
					clusterInfo_vswitchIds.Add(_ctx.StringValue("ListCluster.Data["+ i +"].VswitchIds["+ j +"]"));
				}
				clusterInfo.VswitchIds = clusterInfo_vswitchIds;

				listClusterResponse_data.Add(clusterInfo);
			}
			listClusterResponse.Data = listClusterResponse_data;
        
			return listClusterResponse;
        }
    }
}
