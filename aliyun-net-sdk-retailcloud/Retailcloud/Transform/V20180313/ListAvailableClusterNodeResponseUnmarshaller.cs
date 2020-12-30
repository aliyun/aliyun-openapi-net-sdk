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
    public class ListAvailableClusterNodeResponseUnmarshaller
    {
        public static ListAvailableClusterNodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAvailableClusterNodeResponse listAvailableClusterNodeResponse = new ListAvailableClusterNodeResponse();

			listAvailableClusterNodeResponse.HttpResponse = _ctx.HttpResponse;
			listAvailableClusterNodeResponse.Code = _ctx.IntegerValue("ListAvailableClusterNode.Code");
			listAvailableClusterNodeResponse.ErrorMsg = _ctx.StringValue("ListAvailableClusterNode.ErrorMsg");
			listAvailableClusterNodeResponse.PageNumber = _ctx.IntegerValue("ListAvailableClusterNode.PageNumber");
			listAvailableClusterNodeResponse.PageSize = _ctx.IntegerValue("ListAvailableClusterNode.PageSize");
			listAvailableClusterNodeResponse.RequestId = _ctx.StringValue("ListAvailableClusterNode.RequestId");
			listAvailableClusterNodeResponse.TotalCount = _ctx.LongValue("ListAvailableClusterNode.TotalCount");

			List<ListAvailableClusterNodeResponse.ListAvailableClusterNode_ClusterNodeInfo> listAvailableClusterNodeResponse_data = new List<ListAvailableClusterNodeResponse.ListAvailableClusterNode_ClusterNodeInfo>();
			for (int i = 0; i < _ctx.Length("ListAvailableClusterNode.Data.Length"); i++) {
				ListAvailableClusterNodeResponse.ListAvailableClusterNode_ClusterNodeInfo clusterNodeInfo = new ListAvailableClusterNodeResponse.ListAvailableClusterNode_ClusterNodeInfo();
				clusterNodeInfo.OSName = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].OSName");
				clusterNodeInfo.BusinessCode = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].BusinessCode");
				clusterNodeInfo.EcsConfiguration = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsConfiguration");
				clusterNodeInfo.EcsCpu = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsCpu");
				clusterNodeInfo.EcsEip = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsEip");
				clusterNodeInfo.EcsExpiredTime = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsExpiredTime");
				clusterNodeInfo.EcsLocalStorageCapacity = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsLocalStorageCapacity");
				clusterNodeInfo.EcsMemory = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsMemory");
				clusterNodeInfo.EcsOsType = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsOsType");
				clusterNodeInfo.EcsPrivateIp = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsPrivateIp");
				clusterNodeInfo.EcsPublicIp = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsPublicIp");
				clusterNodeInfo.EcsZone = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsZone");
				clusterNodeInfo.InstanceId = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].InstanceId");
				clusterNodeInfo.InstanceName = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].InstanceName");
				clusterNodeInfo.InstanceNetworkType = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].InstanceNetworkType");
				clusterNodeInfo.InstanceType = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].InstanceType");
				clusterNodeInfo.InternetMaxBandwidthIn = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].InternetMaxBandwidthIn");
				clusterNodeInfo.InternetMaxBandwidthOut = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].InternetMaxBandwidthOut");
				clusterNodeInfo.RegionId = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].RegionId");
				clusterNodeInfo.VpcId = _ctx.StringValue("ListAvailableClusterNode.Data["+ i +"].VpcId");

				listAvailableClusterNodeResponse_data.Add(clusterNodeInfo);
			}
			listAvailableClusterNodeResponse.Data = listAvailableClusterNodeResponse_data;
        
			return listAvailableClusterNodeResponse;
        }
    }
}
