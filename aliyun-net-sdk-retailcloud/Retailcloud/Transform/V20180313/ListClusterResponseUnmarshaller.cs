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
        public static ListClusterResponse Unmarshall(UnmarshallerContext context)
        {
			ListClusterResponse listClusterResponse = new ListClusterResponse();

			listClusterResponse.HttpResponse = context.HttpResponse;
			listClusterResponse.Code = context.IntegerValue("ListCluster.Code");
			listClusterResponse.ErrorMsg = context.StringValue("ListCluster.ErrorMsg");
			listClusterResponse.PageNumber = context.IntegerValue("ListCluster.PageNumber");
			listClusterResponse.PageSize = context.IntegerValue("ListCluster.PageSize");
			listClusterResponse.RequestId = context.StringValue("ListCluster.RequestId");
			listClusterResponse.TotalCount = context.LongValue("ListCluster.TotalCount");

			List<ListClusterResponse.ListCluster_ClusterInfo> listClusterResponse_data = new List<ListClusterResponse.ListCluster_ClusterInfo>();
			for (int i = 0; i < context.Length("ListCluster.Data.Length"); i++) {
				ListClusterResponse.ListCluster_ClusterInfo clusterInfo = new ListClusterResponse.ListCluster_ClusterInfo();
				clusterInfo.BusinessCode = context.StringValue("ListCluster.Data["+ i +"].BusinessCode");
				clusterInfo.ClusterTitle = context.StringValue("ListCluster.Data["+ i +"].ClusterTitle");
				clusterInfo.CreateStatus = context.StringValue("ListCluster.Data["+ i +"].CreateStatus");
				clusterInfo.EnvType = context.StringValue("ListCluster.Data["+ i +"].EnvType");
				clusterInfo.Id = context.LongValue("ListCluster.Data["+ i +"].Id");
				clusterInfo.InstanceId = context.StringValue("ListCluster.Data["+ i +"].InstanceId");
				clusterInfo.KeyPair = context.StringValue("ListCluster.Data["+ i +"].KeyPair");
				clusterInfo.NetPlug = context.StringValue("ListCluster.Data["+ i +"].NetPlug");
				clusterInfo.Password = context.StringValue("ListCluster.Data["+ i +"].Password");
				clusterInfo.PodCIDR = context.StringValue("ListCluster.Data["+ i +"].PodCIDR");
				clusterInfo.RegionId = context.StringValue("ListCluster.Data["+ i +"].RegionId");
				clusterInfo.RegionName = context.StringValue("ListCluster.Data["+ i +"].RegionName");
				clusterInfo.ServiceCIDR = context.StringValue("ListCluster.Data["+ i +"].ServiceCIDR");
				clusterInfo.Status = context.StringValue("ListCluster.Data["+ i +"].Status");
				clusterInfo.VpcId = context.StringValue("ListCluster.Data["+ i +"].VpcId");
				clusterInfo.WorkLoadCpu = context.StringValue("ListCluster.Data["+ i +"].WorkLoadCpu");
				clusterInfo.WorkLoadMem = context.StringValue("ListCluster.Data["+ i +"].WorkLoadMem");

				List<string> clusterInfo_ecsIds = new List<string>();
				for (int j = 0; j < context.Length("ListCluster.Data["+ i +"].EcsIds.Length"); j++) {
					clusterInfo_ecsIds.Add(context.StringValue("ListCluster.Data["+ i +"].EcsIds["+ j +"]"));
				}
				clusterInfo.EcsIds = clusterInfo_ecsIds;

				List<string> clusterInfo_vswitchIds = new List<string>();
				for (int j = 0; j < context.Length("ListCluster.Data["+ i +"].VswitchIds.Length"); j++) {
					clusterInfo_vswitchIds.Add(context.StringValue("ListCluster.Data["+ i +"].VswitchIds["+ j +"]"));
				}
				clusterInfo.VswitchIds = clusterInfo_vswitchIds;

				listClusterResponse_data.Add(clusterInfo);
			}
			listClusterResponse.Data = listClusterResponse_data;
        
			return listClusterResponse;
        }
    }
}
