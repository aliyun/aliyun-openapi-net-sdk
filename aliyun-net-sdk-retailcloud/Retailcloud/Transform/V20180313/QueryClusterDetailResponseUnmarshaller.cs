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
        public static QueryClusterDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryClusterDetailResponse queryClusterDetailResponse = new QueryClusterDetailResponse();

			queryClusterDetailResponse.HttpResponse = _ctx.HttpResponse;
			queryClusterDetailResponse.Code = _ctx.IntegerValue("QueryClusterDetail.Code");
			queryClusterDetailResponse.ErrMsg = _ctx.StringValue("QueryClusterDetail.ErrMsg");
			queryClusterDetailResponse.RequestId = _ctx.StringValue("QueryClusterDetail.RequestId");
			queryClusterDetailResponse.Success = _ctx.BooleanValue("QueryClusterDetail.Success");

			QueryClusterDetailResponse.QueryClusterDetail_Result result = new QueryClusterDetailResponse.QueryClusterDetail_Result();

			List<string> result_nodeWorkLoadList = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryClusterDetail.Result.NodeWorkLoadList.Length"); i++) {
				result_nodeWorkLoadList.Add(_ctx.StringValue("QueryClusterDetail.Result.NodeWorkLoadList["+ i +"]"));
			}
			result.NodeWorkLoadList = result_nodeWorkLoadList;

			QueryClusterDetailResponse.QueryClusterDetail_Result.QueryClusterDetail_BasicInfo basicInfo = new QueryClusterDetailResponse.QueryClusterDetail_Result.QueryClusterDetail_BasicInfo();
			basicInfo.BusinessCode = _ctx.StringValue("QueryClusterDetail.Result.BasicInfo.BusinessCode");
			basicInfo.ClusterId = _ctx.LongValue("QueryClusterDetail.Result.BasicInfo.ClusterId");
			basicInfo.ClusterInstanceId = _ctx.StringValue("QueryClusterDetail.Result.BasicInfo.ClusterInstanceId");
			basicInfo.ClusterName = _ctx.StringValue("QueryClusterDetail.Result.BasicInfo.ClusterName");
			basicInfo.EnvType = _ctx.StringValue("QueryClusterDetail.Result.BasicInfo.EnvType");
			basicInfo.HasInstallArmsPilot = _ctx.BooleanValue("QueryClusterDetail.Result.BasicInfo.HasInstallArmsPilot");
			basicInfo.HasInstallLogController = _ctx.BooleanValue("QueryClusterDetail.Result.BasicInfo.HasInstallLogController");
			basicInfo.InstallArmsInProcess = _ctx.BooleanValue("QueryClusterDetail.Result.BasicInfo.InstallArmsInProcess");
			basicInfo.InstallLogInProcess = _ctx.BooleanValue("QueryClusterDetail.Result.BasicInfo.InstallLogInProcess");
			basicInfo.MainUserId = _ctx.StringValue("QueryClusterDetail.Result.BasicInfo.MainUserId");
			basicInfo.RegionId = _ctx.StringValue("QueryClusterDetail.Result.BasicInfo.RegionId");
			basicInfo.RegionName = _ctx.StringValue("QueryClusterDetail.Result.BasicInfo.RegionName");
			basicInfo.UserNick = _ctx.StringValue("QueryClusterDetail.Result.BasicInfo.UserNick");
			basicInfo.VpcId = _ctx.StringValue("QueryClusterDetail.Result.BasicInfo.VpcId");

			List<string> basicInfo_ecsIds = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryClusterDetail.Result.BasicInfo.EcsIds.Length"); i++) {
				basicInfo_ecsIds.Add(_ctx.StringValue("QueryClusterDetail.Result.BasicInfo.EcsIds["+ i +"]"));
			}
			basicInfo.EcsIds = basicInfo_ecsIds;

			List<string> basicInfo_vswitchs = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryClusterDetail.Result.BasicInfo.Vswitchs.Length"); i++) {
				basicInfo_vswitchs.Add(_ctx.StringValue("QueryClusterDetail.Result.BasicInfo.Vswitchs["+ i +"]"));
			}
			basicInfo.Vswitchs = basicInfo_vswitchs;
			result.BasicInfo = basicInfo;

			QueryClusterDetailResponse.QueryClusterDetail_Result.QueryClusterDetail_InstanceInfo instanceInfo = new QueryClusterDetailResponse.QueryClusterDetail_Result.QueryClusterDetail_InstanceInfo();
			instanceInfo.AllocatePodCount = _ctx.IntegerValue("QueryClusterDetail.Result.InstanceInfo.AllocatePodCount");
			instanceInfo.AppCount = _ctx.IntegerValue("QueryClusterDetail.Result.InstanceInfo.AppCount");

			List<string> instanceInfo_allocatedPodInfoList = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryClusterDetail.Result.InstanceInfo.AllocatedPodInfoList.Length"); i++) {
				instanceInfo_allocatedPodInfoList.Add(_ctx.StringValue("QueryClusterDetail.Result.InstanceInfo.AllocatedPodInfoList["+ i +"]"));
			}
			instanceInfo.AllocatedPodInfoList = instanceInfo_allocatedPodInfoList;

			List<string> instanceInfo_availablePodInfoList = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryClusterDetail.Result.InstanceInfo.AvailablePodInfoList.Length"); i++) {
				instanceInfo_availablePodInfoList.Add(_ctx.StringValue("QueryClusterDetail.Result.InstanceInfo.AvailablePodInfoList["+ i +"]"));
			}
			instanceInfo.AvailablePodInfoList = instanceInfo_availablePodInfoList;
			result.InstanceInfo = instanceInfo;

			QueryClusterDetailResponse.QueryClusterDetail_Result.QueryClusterDetail_NetInfo netInfo = new QueryClusterDetailResponse.QueryClusterDetail_Result.QueryClusterDetail_NetInfo();
			netInfo.NetPlugType = _ctx.StringValue("QueryClusterDetail.Result.NetInfo.NetPlugType");
			netInfo.ProdCIDR = _ctx.StringValue("QueryClusterDetail.Result.NetInfo.ProdCIDR");
			netInfo.ServiceCIDR = _ctx.StringValue("QueryClusterDetail.Result.NetInfo.ServiceCIDR");
			result.NetInfo = netInfo;

			QueryClusterDetailResponse.QueryClusterDetail_Result.QueryClusterDetail_WorkLoad workLoad = new QueryClusterDetailResponse.QueryClusterDetail_Result.QueryClusterDetail_WorkLoad();
			workLoad.AllNodeCount = _ctx.IntegerValue("QueryClusterDetail.Result.WorkLoad.AllNodeCount");
			workLoad.AllocateAllPodCount = _ctx.IntegerValue("QueryClusterDetail.Result.WorkLoad.AllocateAllPodCount");
			workLoad.AllocateAppPodCount = _ctx.IntegerValue("QueryClusterDetail.Result.WorkLoad.AllocateAppPodCount");
			workLoad.CpuCapacityTotal = _ctx.StringValue("QueryClusterDetail.Result.WorkLoad.CpuCapacityTotal");
			workLoad.CpuLevel = _ctx.StringValue("QueryClusterDetail.Result.WorkLoad.CpuLevel");
			workLoad.CpuRequest = _ctx.StringValue("QueryClusterDetail.Result.WorkLoad.CpuRequest");
			workLoad.CpuRequestPercent = _ctx.StringValue("QueryClusterDetail.Result.WorkLoad.CpuRequestPercent");
			workLoad.CpuTotal = _ctx.StringValue("QueryClusterDetail.Result.WorkLoad.CpuTotal");
			workLoad.CpuUse = _ctx.StringValue("QueryClusterDetail.Result.WorkLoad.CpuUse");
			workLoad.CpuUsePercent = _ctx.StringValue("QueryClusterDetail.Result.WorkLoad.CpuUsePercent");
			workLoad.MemCapacityTotal = _ctx.StringValue("QueryClusterDetail.Result.WorkLoad.MemCapacityTotal");
			workLoad.MemLevel = _ctx.StringValue("QueryClusterDetail.Result.WorkLoad.MemLevel");
			workLoad.MemRequest = _ctx.StringValue("QueryClusterDetail.Result.WorkLoad.MemRequest");
			workLoad.MemRequestPercent = _ctx.StringValue("QueryClusterDetail.Result.WorkLoad.MemRequestPercent");
			workLoad.MemTotal = _ctx.StringValue("QueryClusterDetail.Result.WorkLoad.MemTotal");
			workLoad.MemUse = _ctx.StringValue("QueryClusterDetail.Result.WorkLoad.MemUse");
			workLoad.MemUsePercent = _ctx.StringValue("QueryClusterDetail.Result.WorkLoad.MemUsePercent");
			result.WorkLoad = workLoad;
			queryClusterDetailResponse.Result = result;
        
			return queryClusterDetailResponse;
        }
    }
}
