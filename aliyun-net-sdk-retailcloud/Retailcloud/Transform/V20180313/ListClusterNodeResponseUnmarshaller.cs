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
    public class ListClusterNodeResponseUnmarshaller
    {
        public static ListClusterNodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterNodeResponse listClusterNodeResponse = new ListClusterNodeResponse();

			listClusterNodeResponse.HttpResponse = _ctx.HttpResponse;
			listClusterNodeResponse.Code = _ctx.IntegerValue("ListClusterNode.Code");
			listClusterNodeResponse.ErrorMsg = _ctx.StringValue("ListClusterNode.ErrorMsg");
			listClusterNodeResponse.PageNumber = _ctx.IntegerValue("ListClusterNode.PageNumber");
			listClusterNodeResponse.PageSize = _ctx.IntegerValue("ListClusterNode.PageSize");
			listClusterNodeResponse.RequestId = _ctx.StringValue("ListClusterNode.RequestId");
			listClusterNodeResponse.TotalCount = _ctx.LongValue("ListClusterNode.TotalCount");

			List<ListClusterNodeResponse.ListClusterNode_ClusterNodeInfo> listClusterNodeResponse_data = new List<ListClusterNodeResponse.ListClusterNode_ClusterNodeInfo>();
			for (int i = 0; i < _ctx.Length("ListClusterNode.Data.Length"); i++) {
				ListClusterNodeResponse.ListClusterNode_ClusterNodeInfo clusterNodeInfo = new ListClusterNodeResponse.ListClusterNode_ClusterNodeInfo();
				clusterNodeInfo.OSName = _ctx.StringValue("ListClusterNode.Data["+ i +"].OSName");
				clusterNodeInfo.BusinessCode = _ctx.StringValue("ListClusterNode.Data["+ i +"].BusinessCode");
				clusterNodeInfo.EcsConfiguration = _ctx.StringValue("ListClusterNode.Data["+ i +"].EcsConfiguration");
				clusterNodeInfo.EcsCpu = _ctx.StringValue("ListClusterNode.Data["+ i +"].EcsCpu");
				clusterNodeInfo.EcsEip = _ctx.StringValue("ListClusterNode.Data["+ i +"].EcsEip");
				clusterNodeInfo.EcsExpiredTime = _ctx.StringValue("ListClusterNode.Data["+ i +"].EcsExpiredTime");
				clusterNodeInfo.EcsLocalStorageCapacity = _ctx.StringValue("ListClusterNode.Data["+ i +"].EcsLocalStorageCapacity");
				clusterNodeInfo.EcsMemory = _ctx.StringValue("ListClusterNode.Data["+ i +"].EcsMemory");
				clusterNodeInfo.EcsOsType = _ctx.StringValue("ListClusterNode.Data["+ i +"].EcsOsType");
				clusterNodeInfo.EcsPrivateIp = _ctx.StringValue("ListClusterNode.Data["+ i +"].EcsPrivateIp");
				clusterNodeInfo.EcsPublicIp = _ctx.StringValue("ListClusterNode.Data["+ i +"].EcsPublicIp");
				clusterNodeInfo.EcsZone = _ctx.StringValue("ListClusterNode.Data["+ i +"].EcsZone");
				clusterNodeInfo.InstanceId = _ctx.StringValue("ListClusterNode.Data["+ i +"].InstanceId");
				clusterNodeInfo.InstanceName = _ctx.StringValue("ListClusterNode.Data["+ i +"].InstanceName");
				clusterNodeInfo.InstanceNetworkType = _ctx.StringValue("ListClusterNode.Data["+ i +"].InstanceNetworkType");
				clusterNodeInfo.InstanceType = _ctx.StringValue("ListClusterNode.Data["+ i +"].InstanceType");
				clusterNodeInfo.InternetMaxBandwidthIn = _ctx.StringValue("ListClusterNode.Data["+ i +"].InternetMaxBandwidthIn");
				clusterNodeInfo.InternetMaxBandwidthOut = _ctx.StringValue("ListClusterNode.Data["+ i +"].InternetMaxBandwidthOut");
				clusterNodeInfo.RegionId = _ctx.StringValue("ListClusterNode.Data["+ i +"].RegionId");
				clusterNodeInfo.VpcId = _ctx.StringValue("ListClusterNode.Data["+ i +"].VpcId");

				listClusterNodeResponse_data.Add(clusterNodeInfo);
			}
			listClusterNodeResponse.Data = listClusterNodeResponse_data;
        
			return listClusterNodeResponse;
        }
    }
}
