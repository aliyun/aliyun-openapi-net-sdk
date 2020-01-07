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
    public class QueryClusterDetailResponseUnmarshaller
    {
        public static QueryClusterDetailResponse Unmarshall(UnmarshallerContext context)
        {
			QueryClusterDetailResponse queryClusterDetailResponse = new QueryClusterDetailResponse();

			queryClusterDetailResponse.HttpResponse = context.HttpResponse;
			queryClusterDetailResponse.Code = context.IntegerValue("QueryClusterDetail.Code");
			queryClusterDetailResponse.ErrMsg = context.StringValue("QueryClusterDetail.ErrMsg");
			queryClusterDetailResponse.RequestId = context.StringValue("QueryClusterDetail.RequestId");
			queryClusterDetailResponse.Success = context.BooleanValue("QueryClusterDetail.Success");

			QueryClusterDetailResponse.QueryClusterDetail_Result result = new QueryClusterDetailResponse.QueryClusterDetail_Result();

			List<string> result_nodeWorkLoadList = new List<string>();
			for (int i = 0; i < context.Length("QueryClusterDetail.Result.NodeWorkLoadList.Length"); i++) {
				result_nodeWorkLoadList.Add(context.StringValue("QueryClusterDetail.Result.NodeWorkLoadList["+ i +"]"));
			}
			result.NodeWorkLoadList = result_nodeWorkLoadList;

			QueryClusterDetailResponse.QueryClusterDetail_Result.QueryClusterDetail_BasicInfo basicInfo = new QueryClusterDetailResponse.QueryClusterDetail_Result.QueryClusterDetail_BasicInfo();
			basicInfo.BusinessCode = context.StringValue("QueryClusterDetail.Result.BasicInfo.BusinessCode");
			basicInfo.ClusterId = context.LongValue("QueryClusterDetail.Result.BasicInfo.ClusterId");
			basicInfo.ClusterInstanceId = context.StringValue("QueryClusterDetail.Result.BasicInfo.ClusterInstanceId");
			basicInfo.ClusterName = context.StringValue("QueryClusterDetail.Result.BasicInfo.ClusterName");
			basicInfo.EnvType = context.StringValue("QueryClusterDetail.Result.BasicInfo.EnvType");
			basicInfo.HasInstallArmsPilot = context.BooleanValue("QueryClusterDetail.Result.BasicInfo.HasInstallArmsPilot");
			basicInfo.HasInstallLogController = context.BooleanValue("QueryClusterDetail.Result.BasicInfo.HasInstallLogController");
			basicInfo.InstallArmsInProcess = context.BooleanValue("QueryClusterDetail.Result.BasicInfo.InstallArmsInProcess");
			basicInfo.InstallLogInProcess = context.BooleanValue("QueryClusterDetail.Result.BasicInfo.InstallLogInProcess");
			basicInfo.MainUserId = context.StringValue("QueryClusterDetail.Result.BasicInfo.MainUserId");
			basicInfo.RegionId = context.StringValue("QueryClusterDetail.Result.BasicInfo.RegionId");
			basicInfo.RegionName = context.StringValue("QueryClusterDetail.Result.BasicInfo.RegionName");
			basicInfo.UserNick = context.StringValue("QueryClusterDetail.Result.BasicInfo.UserNick");
			basicInfo.VpcId = context.StringValue("QueryClusterDetail.Result.BasicInfo.VpcId");

			List<string> basicInfo_ecsIds = new List<string>();
			for (int i = 0; i < context.Length("QueryClusterDetail.Result.BasicInfo.EcsIds.Length"); i++) {
				basicInfo_ecsIds.Add(context.StringValue("QueryClusterDetail.Result.BasicInfo.EcsIds["+ i +"]"));
			}
			basicInfo.EcsIds = basicInfo_ecsIds;

			List<string> basicInfo_vswitchs = new List<string>();
			for (int i = 0; i < context.Length("QueryClusterDetail.Result.BasicInfo.Vswitchs.Length"); i++) {
				basicInfo_vswitchs.Add(context.StringValue("QueryClusterDetail.Result.BasicInfo.Vswitchs["+ i +"]"));
			}
			basicInfo.Vswitchs = basicInfo_vswitchs;
			result.BasicInfo = basicInfo;

			QueryClusterDetailResponse.QueryClusterDetail_Result.QueryClusterDetail_InstanceInfo instanceInfo = new QueryClusterDetailResponse.QueryClusterDetail_Result.QueryClusterDetail_InstanceInfo();
			instanceInfo.AllocatePodCount = context.IntegerValue("QueryClusterDetail.Result.InstanceInfo.AllocatePodCount");
			instanceInfo.AppCount = context.IntegerValue("QueryClusterDetail.Result.InstanceInfo.AppCount");

			List<string> instanceInfo_allocatedPodInfoList = new List<string>();
			for (int i = 0; i < context.Length("QueryClusterDetail.Result.InstanceInfo.AllocatedPodInfoList.Length"); i++) {
				instanceInfo_allocatedPodInfoList.Add(context.StringValue("QueryClusterDetail.Result.InstanceInfo.AllocatedPodInfoList["+ i +"]"));
			}
			instanceInfo.AllocatedPodInfoList = instanceInfo_allocatedPodInfoList;

			List<string> instanceInfo_availablePodInfoList = new List<string>();
			for (int i = 0; i < context.Length("QueryClusterDetail.Result.InstanceInfo.AvailablePodInfoList.Length"); i++) {
				instanceInfo_availablePodInfoList.Add(context.StringValue("QueryClusterDetail.Result.InstanceInfo.AvailablePodInfoList["+ i +"]"));
			}
			instanceInfo.AvailablePodInfoList = instanceInfo_availablePodInfoList;
			result.InstanceInfo = instanceInfo;

			QueryClusterDetailResponse.QueryClusterDetail_Result.QueryClusterDetail_NetInfo netInfo = new QueryClusterDetailResponse.QueryClusterDetail_Result.QueryClusterDetail_NetInfo();
			netInfo.NetPlugType = context.StringValue("QueryClusterDetail.Result.NetInfo.NetPlugType");
			netInfo.ProdCIDR = context.StringValue("QueryClusterDetail.Result.NetInfo.ProdCIDR");
			netInfo.ServiceCIDR = context.StringValue("QueryClusterDetail.Result.NetInfo.ServiceCIDR");
			result.NetInfo = netInfo;

			QueryClusterDetailResponse.QueryClusterDetail_Result.QueryClusterDetail_WorkLoad workLoad = new QueryClusterDetailResponse.QueryClusterDetail_Result.QueryClusterDetail_WorkLoad();
			workLoad.AllNodeCount = context.IntegerValue("QueryClusterDetail.Result.WorkLoad.AllNodeCount");
			workLoad.AllocateAllPodCount = context.IntegerValue("QueryClusterDetail.Result.WorkLoad.AllocateAllPodCount");
			workLoad.AllocateAppPodCount = context.IntegerValue("QueryClusterDetail.Result.WorkLoad.AllocateAppPodCount");
			workLoad.CpuCapacityTotal = context.StringValue("QueryClusterDetail.Result.WorkLoad.CpuCapacityTotal");
			workLoad.CpuLevel = context.StringValue("QueryClusterDetail.Result.WorkLoad.CpuLevel");
			workLoad.CpuRequest = context.StringValue("QueryClusterDetail.Result.WorkLoad.CpuRequest");
			workLoad.CpuRequestPercent = context.StringValue("QueryClusterDetail.Result.WorkLoad.CpuRequestPercent");
			workLoad.CpuTotal = context.StringValue("QueryClusterDetail.Result.WorkLoad.CpuTotal");
			workLoad.CpuUse = context.StringValue("QueryClusterDetail.Result.WorkLoad.CpuUse");
			workLoad.CpuUsePercent = context.StringValue("QueryClusterDetail.Result.WorkLoad.CpuUsePercent");
			workLoad.MemCapacityTotal = context.StringValue("QueryClusterDetail.Result.WorkLoad.MemCapacityTotal");
			workLoad.MemLevel = context.StringValue("QueryClusterDetail.Result.WorkLoad.MemLevel");
			workLoad.MemRequest = context.StringValue("QueryClusterDetail.Result.WorkLoad.MemRequest");
			workLoad.MemRequestPercent = context.StringValue("QueryClusterDetail.Result.WorkLoad.MemRequestPercent");
			workLoad.MemTotal = context.StringValue("QueryClusterDetail.Result.WorkLoad.MemTotal");
			workLoad.MemUse = context.StringValue("QueryClusterDetail.Result.WorkLoad.MemUse");
			workLoad.MemUsePercent = context.StringValue("QueryClusterDetail.Result.WorkLoad.MemUsePercent");
			result.WorkLoad = workLoad;
			queryClusterDetailResponse.Result = result;
        
			return queryClusterDetailResponse;
        }
    }
}
