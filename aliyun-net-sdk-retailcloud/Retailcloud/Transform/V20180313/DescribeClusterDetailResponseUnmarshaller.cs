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
    public class DescribeClusterDetailResponseUnmarshaller
    {
        public static DescribeClusterDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClusterDetailResponse describeClusterDetailResponse = new DescribeClusterDetailResponse();

			describeClusterDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeClusterDetailResponse.Code = _ctx.IntegerValue("DescribeClusterDetail.Code");
			describeClusterDetailResponse.ErrMsg = _ctx.StringValue("DescribeClusterDetail.ErrMsg");
			describeClusterDetailResponse.RequestId = _ctx.StringValue("DescribeClusterDetail.RequestId");
			describeClusterDetailResponse.Success = _ctx.BooleanValue("DescribeClusterDetail.Success");

			DescribeClusterDetailResponse.DescribeClusterDetail_Result result = new DescribeClusterDetailResponse.DescribeClusterDetail_Result();

			DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_BasicInfo basicInfo = new DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_BasicInfo();
			basicInfo.BusinessCode = _ctx.StringValue("DescribeClusterDetail.Result.BasicInfo.BusinessCode");
			basicInfo.ClusterId = _ctx.LongValue("DescribeClusterDetail.Result.BasicInfo.ClusterId");
			basicInfo.ClusterInstanceId = _ctx.StringValue("DescribeClusterDetail.Result.BasicInfo.ClusterInstanceId");
			basicInfo.ClusterName = _ctx.StringValue("DescribeClusterDetail.Result.BasicInfo.ClusterName");
			basicInfo.EnvType = _ctx.StringValue("DescribeClusterDetail.Result.BasicInfo.EnvType");
			basicInfo.HasInstallArmsPilot = _ctx.BooleanValue("DescribeClusterDetail.Result.BasicInfo.HasInstallArmsPilot");
			basicInfo.HasInstallLogController = _ctx.BooleanValue("DescribeClusterDetail.Result.BasicInfo.HasInstallLogController");
			basicInfo.InstallArmsInProcess = _ctx.BooleanValue("DescribeClusterDetail.Result.BasicInfo.InstallArmsInProcess");
			basicInfo.InstallLogInProcess = _ctx.BooleanValue("DescribeClusterDetail.Result.BasicInfo.InstallLogInProcess");
			basicInfo.MainUserId = _ctx.StringValue("DescribeClusterDetail.Result.BasicInfo.MainUserId");
			basicInfo.RegionId = _ctx.StringValue("DescribeClusterDetail.Result.BasicInfo.RegionId");
			basicInfo.RegionName = _ctx.StringValue("DescribeClusterDetail.Result.BasicInfo.RegionName");
			basicInfo.UserNick = _ctx.StringValue("DescribeClusterDetail.Result.BasicInfo.UserNick");
			basicInfo.VpcId = _ctx.StringValue("DescribeClusterDetail.Result.BasicInfo.VpcId");

			List<string> basicInfo_ecsIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeClusterDetail.Result.BasicInfo.EcsIds.Length"); i++) {
				basicInfo_ecsIds.Add(_ctx.StringValue("DescribeClusterDetail.Result.BasicInfo.EcsIds["+ i +"]"));
			}
			basicInfo.EcsIds = basicInfo_ecsIds;

			List<string> basicInfo_vswitchs = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeClusterDetail.Result.BasicInfo.Vswitchs.Length"); i++) {
				basicInfo_vswitchs.Add(_ctx.StringValue("DescribeClusterDetail.Result.BasicInfo.Vswitchs["+ i +"]"));
			}
			basicInfo.Vswitchs = basicInfo_vswitchs;
			result.BasicInfo = basicInfo;

			DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_InstanceInfo instanceInfo = new DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_InstanceInfo();
			instanceInfo.AllocatePodCount = _ctx.IntegerValue("DescribeClusterDetail.Result.InstanceInfo.AllocatePodCount");
			instanceInfo.AppCount = _ctx.IntegerValue("DescribeClusterDetail.Result.InstanceInfo.AppCount");

			List<DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_InstanceInfo.DescribeClusterDetail_AllocatedPodInstanceInfo> instanceInfo_allocatedPodInfoList = new List<DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_InstanceInfo.DescribeClusterDetail_AllocatedPodInstanceInfo>();
			for (int i = 0; i < _ctx.Length("DescribeClusterDetail.Result.InstanceInfo.AllocatedPodInfoList.Length"); i++) {
				DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_InstanceInfo.DescribeClusterDetail_AllocatedPodInstanceInfo allocatedPodInstanceInfo = new DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_InstanceInfo.DescribeClusterDetail_AllocatedPodInstanceInfo();
				allocatedPodInstanceInfo.AppId = _ctx.LongValue("DescribeClusterDetail.Result.InstanceInfo.AllocatedPodInfoList["+ i +"].AppId");
				allocatedPodInstanceInfo.AppName = _ctx.StringValue("DescribeClusterDetail.Result.InstanceInfo.AllocatedPodInfoList["+ i +"].AppName");
				allocatedPodInstanceInfo.CupRequest = _ctx.StringValue("DescribeClusterDetail.Result.InstanceInfo.AllocatedPodInfoList["+ i +"].CupRequest");
				allocatedPodInstanceInfo.EnvId = _ctx.LongValue("DescribeClusterDetail.Result.InstanceInfo.AllocatedPodInfoList["+ i +"].EnvId");
				allocatedPodInstanceInfo.EnvName = _ctx.StringValue("DescribeClusterDetail.Result.InstanceInfo.AllocatedPodInfoList["+ i +"].EnvName");
				allocatedPodInstanceInfo.MemRequest = _ctx.StringValue("DescribeClusterDetail.Result.InstanceInfo.AllocatedPodInfoList["+ i +"].MemRequest");
				allocatedPodInstanceInfo.PodCount = _ctx.IntegerValue("DescribeClusterDetail.Result.InstanceInfo.AllocatedPodInfoList["+ i +"].PodCount");

				instanceInfo_allocatedPodInfoList.Add(allocatedPodInstanceInfo);
			}
			instanceInfo.AllocatedPodInfoList = instanceInfo_allocatedPodInfoList;

			List<DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_InstanceInfo.DescribeClusterDetail_AvailablePodInstanceInfo> instanceInfo_availablePodInfoList = new List<DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_InstanceInfo.DescribeClusterDetail_AvailablePodInstanceInfo>();
			for (int i = 0; i < _ctx.Length("DescribeClusterDetail.Result.InstanceInfo.AvailablePodInfoList.Length"); i++) {
				DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_InstanceInfo.DescribeClusterDetail_AvailablePodInstanceInfo availablePodInstanceInfo = new DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_InstanceInfo.DescribeClusterDetail_AvailablePodInstanceInfo();
				availablePodInstanceInfo.AvailablePodCount = _ctx.IntegerValue("DescribeClusterDetail.Result.InstanceInfo.AvailablePodInfoList["+ i +"].AvailablePodCount");
				availablePodInstanceInfo.CupRequest = _ctx.StringValue("DescribeClusterDetail.Result.InstanceInfo.AvailablePodInfoList["+ i +"].CupRequest");
				availablePodInstanceInfo.MemRequest = _ctx.StringValue("DescribeClusterDetail.Result.InstanceInfo.AvailablePodInfoList["+ i +"].MemRequest");

				instanceInfo_availablePodInfoList.Add(availablePodInstanceInfo);
			}
			instanceInfo.AvailablePodInfoList = instanceInfo_availablePodInfoList;
			result.InstanceInfo = instanceInfo;

			DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_NetInfo netInfo = new DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_NetInfo();
			netInfo.NetPlugType = _ctx.StringValue("DescribeClusterDetail.Result.NetInfo.NetPlugType");
			netInfo.ProdCIDR = _ctx.StringValue("DescribeClusterDetail.Result.NetInfo.ProdCIDR");
			netInfo.ServiceCIDR = _ctx.StringValue("DescribeClusterDetail.Result.NetInfo.ServiceCIDR");
			result.NetInfo = netInfo;

			DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_WorkLoad workLoad = new DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_WorkLoad();
			workLoad.AllNodeCount = _ctx.IntegerValue("DescribeClusterDetail.Result.WorkLoad.AllNodeCount");
			workLoad.AllocateAllPodCount = _ctx.IntegerValue("DescribeClusterDetail.Result.WorkLoad.AllocateAllPodCount");
			workLoad.AllocateAppPodCount = _ctx.IntegerValue("DescribeClusterDetail.Result.WorkLoad.AllocateAppPodCount");
			workLoad.CpuCapacityTotal = _ctx.StringValue("DescribeClusterDetail.Result.WorkLoad.CpuCapacityTotal");
			workLoad.CpuLevel = _ctx.StringValue("DescribeClusterDetail.Result.WorkLoad.CpuLevel");
			workLoad.CpuRequest = _ctx.StringValue("DescribeClusterDetail.Result.WorkLoad.CpuRequest");
			workLoad.CpuRequestPercent = _ctx.StringValue("DescribeClusterDetail.Result.WorkLoad.CpuRequestPercent");
			workLoad.CpuTotal = _ctx.StringValue("DescribeClusterDetail.Result.WorkLoad.CpuTotal");
			workLoad.CpuUse = _ctx.StringValue("DescribeClusterDetail.Result.WorkLoad.CpuUse");
			workLoad.CpuUsePercent = _ctx.StringValue("DescribeClusterDetail.Result.WorkLoad.CpuUsePercent");
			workLoad.MemCapacityTotal = _ctx.StringValue("DescribeClusterDetail.Result.WorkLoad.MemCapacityTotal");
			workLoad.MemLevel = _ctx.StringValue("DescribeClusterDetail.Result.WorkLoad.MemLevel");
			workLoad.MemRequest = _ctx.StringValue("DescribeClusterDetail.Result.WorkLoad.MemRequest");
			workLoad.MemRequestPercent = _ctx.StringValue("DescribeClusterDetail.Result.WorkLoad.MemRequestPercent");
			workLoad.MemTotal = _ctx.StringValue("DescribeClusterDetail.Result.WorkLoad.MemTotal");
			workLoad.MemUse = _ctx.StringValue("DescribeClusterDetail.Result.WorkLoad.MemUse");
			workLoad.MemUsePercent = _ctx.StringValue("DescribeClusterDetail.Result.WorkLoad.MemUsePercent");
			result.WorkLoad = workLoad;

			List<DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_ClusterNodeWorkLoad> result_nodeWorkLoadList = new List<DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_ClusterNodeWorkLoad>();
			for (int i = 0; i < _ctx.Length("DescribeClusterDetail.Result.NodeWorkLoadList.Length"); i++) {
				DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_ClusterNodeWorkLoad clusterNodeWorkLoad = new DescribeClusterDetailResponse.DescribeClusterDetail_Result.DescribeClusterDetail_ClusterNodeWorkLoad();
				clusterNodeWorkLoad.AppPodCount = _ctx.IntegerValue("DescribeClusterDetail.Result.NodeWorkLoadList["+ i +"].AppPodCount");
				clusterNodeWorkLoad.CpuRequest = _ctx.StringValue("DescribeClusterDetail.Result.NodeWorkLoadList["+ i +"].CpuRequest");
				clusterNodeWorkLoad.CpuTotal = _ctx.StringValue("DescribeClusterDetail.Result.NodeWorkLoadList["+ i +"].CpuTotal");
				clusterNodeWorkLoad.CpuUse = _ctx.StringValue("DescribeClusterDetail.Result.NodeWorkLoadList["+ i +"].CpuUse");
				clusterNodeWorkLoad.InstanceId = _ctx.StringValue("DescribeClusterDetail.Result.NodeWorkLoadList["+ i +"].InstanceId");
				clusterNodeWorkLoad.MemRequest = _ctx.StringValue("DescribeClusterDetail.Result.NodeWorkLoadList["+ i +"].MemRequest");
				clusterNodeWorkLoad.MemTotal = _ctx.StringValue("DescribeClusterDetail.Result.NodeWorkLoadList["+ i +"].MemTotal");
				clusterNodeWorkLoad.MemUse = _ctx.StringValue("DescribeClusterDetail.Result.NodeWorkLoadList["+ i +"].MemUse");
				clusterNodeWorkLoad.NodeName = _ctx.StringValue("DescribeClusterDetail.Result.NodeWorkLoadList["+ i +"].NodeName");
				clusterNodeWorkLoad.PodCount = _ctx.IntegerValue("DescribeClusterDetail.Result.NodeWorkLoadList["+ i +"].PodCount");
				clusterNodeWorkLoad.Ready = _ctx.BooleanValue("DescribeClusterDetail.Result.NodeWorkLoadList["+ i +"].Ready");
				clusterNodeWorkLoad.Unschedulable = _ctx.BooleanValue("DescribeClusterDetail.Result.NodeWorkLoadList["+ i +"].Unschedulable");

				result_nodeWorkLoadList.Add(clusterNodeWorkLoad);
			}
			result.NodeWorkLoadList = result_nodeWorkLoadList;
			describeClusterDetailResponse.Result = result;
        
			return describeClusterDetailResponse;
        }
    }
}
