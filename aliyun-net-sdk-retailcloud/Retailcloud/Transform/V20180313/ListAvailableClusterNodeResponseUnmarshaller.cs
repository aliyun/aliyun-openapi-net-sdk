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
        public static ListAvailableClusterNodeResponse Unmarshall(UnmarshallerContext context)
        {
			ListAvailableClusterNodeResponse listAvailableClusterNodeResponse = new ListAvailableClusterNodeResponse();

			listAvailableClusterNodeResponse.HttpResponse = context.HttpResponse;
			listAvailableClusterNodeResponse.Code = context.IntegerValue("ListAvailableClusterNode.Code");
			listAvailableClusterNodeResponse.ErrorMsg = context.StringValue("ListAvailableClusterNode.ErrorMsg");
			listAvailableClusterNodeResponse.PageNumber = context.IntegerValue("ListAvailableClusterNode.PageNumber");
			listAvailableClusterNodeResponse.PageSize = context.IntegerValue("ListAvailableClusterNode.PageSize");
			listAvailableClusterNodeResponse.RequestId = context.StringValue("ListAvailableClusterNode.RequestId");
			listAvailableClusterNodeResponse.TotalCount = context.LongValue("ListAvailableClusterNode.TotalCount");

			List<ListAvailableClusterNodeResponse.ListAvailableClusterNode_ClusterNodeInfo> listAvailableClusterNodeResponse_data = new List<ListAvailableClusterNodeResponse.ListAvailableClusterNode_ClusterNodeInfo>();
			for (int i = 0; i < context.Length("ListAvailableClusterNode.Data.Length"); i++) {
				ListAvailableClusterNodeResponse.ListAvailableClusterNode_ClusterNodeInfo clusterNodeInfo = new ListAvailableClusterNodeResponse.ListAvailableClusterNode_ClusterNodeInfo();
				clusterNodeInfo.OSName = context.StringValue("ListAvailableClusterNode.Data["+ i +"].OSName");
				clusterNodeInfo.BusinessCode = context.StringValue("ListAvailableClusterNode.Data["+ i +"].BusinessCode");
				clusterNodeInfo.EcsConfiguration = context.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsConfiguration");
				clusterNodeInfo.EcsCpu = context.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsCpu");
				clusterNodeInfo.EcsEip = context.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsEip");
				clusterNodeInfo.EcsExpiredTime = context.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsExpiredTime");
				clusterNodeInfo.EcsLocalStorageCapacity = context.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsLocalStorageCapacity");
				clusterNodeInfo.EcsMemory = context.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsMemory");
				clusterNodeInfo.EcsOsType = context.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsOsType");
				clusterNodeInfo.EcsPrivateIp = context.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsPrivateIp");
				clusterNodeInfo.EcsPublicIp = context.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsPublicIp");
				clusterNodeInfo.EcsZone = context.StringValue("ListAvailableClusterNode.Data["+ i +"].EcsZone");
				clusterNodeInfo.InstanceId = context.StringValue("ListAvailableClusterNode.Data["+ i +"].InstanceId");
				clusterNodeInfo.InstanceName = context.StringValue("ListAvailableClusterNode.Data["+ i +"].InstanceName");
				clusterNodeInfo.InstanceNetworkType = context.StringValue("ListAvailableClusterNode.Data["+ i +"].InstanceNetworkType");
				clusterNodeInfo.InstanceType = context.StringValue("ListAvailableClusterNode.Data["+ i +"].InstanceType");
				clusterNodeInfo.InternetMaxBandwidthIn = context.StringValue("ListAvailableClusterNode.Data["+ i +"].InternetMaxBandwidthIn");
				clusterNodeInfo.InternetMaxBandwidthOut = context.StringValue("ListAvailableClusterNode.Data["+ i +"].InternetMaxBandwidthOut");
				clusterNodeInfo.RegionId = context.StringValue("ListAvailableClusterNode.Data["+ i +"].RegionId");
				clusterNodeInfo.VpcId = context.StringValue("ListAvailableClusterNode.Data["+ i +"].VpcId");

				listAvailableClusterNodeResponse_data.Add(clusterNodeInfo);
			}
			listAvailableClusterNodeResponse.Data = listAvailableClusterNodeResponse_data;
        
			return listAvailableClusterNodeResponse;
        }
    }
}
