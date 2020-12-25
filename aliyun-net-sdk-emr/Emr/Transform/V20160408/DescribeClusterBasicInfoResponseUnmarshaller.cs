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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeClusterBasicInfoResponseUnmarshaller
    {
        public static DescribeClusterBasicInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClusterBasicInfoResponse describeClusterBasicInfoResponse = new DescribeClusterBasicInfoResponse();

			describeClusterBasicInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeClusterBasicInfoResponse.RequestId = _ctx.StringValue("DescribeClusterBasicInfo.RequestId");

			DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo clusterInfo = new DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo();
			clusterInfo.ClusterId = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.ClusterId");
			clusterInfo.RegionId = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.RegionId");
			clusterInfo.MachineType = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.MachineType");
			clusterInfo.DepositType = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.DepositType");
			clusterInfo.ZoneId = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.ZoneId");
			clusterInfo.Name = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.Name");
			clusterInfo.ExtraInfo = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.ExtraInfo");
			clusterInfo.RelateClusterId = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.RelateClusterId");
			clusterInfo.GatewayClusterIds = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.GatewayClusterIds");
			clusterInfo.CreateType = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.CreateType");
			clusterInfo.StartTime = _ctx.LongValue("DescribeClusterBasicInfo.ClusterInfo.StartTime");
			clusterInfo.ExpiredTime = _ctx.LongValue("DescribeClusterBasicInfo.ClusterInfo.ExpiredTime");
			clusterInfo.StopTime = _ctx.LongValue("DescribeClusterBasicInfo.ClusterInfo.StopTime");
			clusterInfo.LogEnable = _ctx.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.LogEnable");
			clusterInfo.LogPath = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.LogPath");
			clusterInfo.UserId = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.UserId");
			clusterInfo.Status = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.Status");
			clusterInfo.HighAvailabilityEnable = _ctx.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.HighAvailabilityEnable");
			clusterInfo.LocalMetaDb = _ctx.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.LocalMetaDb");
			clusterInfo.ChargeType = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.ChargeType");
			clusterInfo.Period = _ctx.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.Period");
			clusterInfo.RunningTime = _ctx.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.RunningTime");
			clusterInfo.MasterNodeTotal = _ctx.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.MasterNodeTotal");
			clusterInfo.MasterNodeInService = _ctx.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.MasterNodeInService");
			clusterInfo.CoreNodeTotal = _ctx.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.CoreNodeTotal");
			clusterInfo.CoreNodeInService = _ctx.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.CoreNodeInService");
			clusterInfo.TaskNodeTotal = _ctx.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.TaskNodeTotal");
			clusterInfo.TaskNodeInService = _ctx.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.TaskNodeInService");
			clusterInfo.ShowSoftwareInterface = _ctx.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.ShowSoftwareInterface");
			clusterInfo.CreateResource = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.CreateResource");
			clusterInfo.VpcId = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.VpcId");
			clusterInfo.VSwitchId = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.VSwitchId");
			clusterInfo.NetType = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.NetType");
			clusterInfo.UserDefinedEmrEcsRole = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.UserDefinedEmrEcsRole");
			clusterInfo.IoOptimized = _ctx.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.IoOptimized");
			clusterInfo.InstanceGeneration = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.InstanceGeneration");
			clusterInfo.ImageId = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.ImageId");
			clusterInfo.SecurityGroupId = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.SecurityGroupId");
			clusterInfo.SecurityGroupName = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.SecurityGroupName");
			clusterInfo.BootstrapFailed = _ctx.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.BootstrapFailed");
			clusterInfo.Configurations = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.Configurations");
			clusterInfo.EasEnable = _ctx.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.EasEnable");
			clusterInfo.AutoScalingVersion = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.AutoScalingVersion");
			clusterInfo.AutoScalingEnable = _ctx.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.AutoScalingEnable");
			clusterInfo.AutoScalingAllowed = _ctx.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.AutoScalingAllowed");
			clusterInfo.AutoScalingSpotWithLimitAllowed = _ctx.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.AutoScalingSpotWithLimitAllowed");
			clusterInfo.AutoScalingByLoadAllowed = _ctx.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.AutoScalingByLoadAllowed");
			clusterInfo.AutoScalingWithGraceAllowed = _ctx.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.AutoScalingWithGraceAllowed");
			clusterInfo.ResizeDiskEnable = _ctx.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.ResizeDiskEnable");
			clusterInfo.MetaStoreType = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.MetaStoreType");
			clusterInfo.K8sClusterId = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.K8sClusterId");
			clusterInfo.OperationId = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.OperationId");

			DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_RelateClusterInfo relateClusterInfo = new DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_RelateClusterInfo();
			relateClusterInfo.ClusterId = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.RelateClusterInfo.ClusterId");
			relateClusterInfo.ClusterName = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.RelateClusterInfo.ClusterName");
			relateClusterInfo.Status = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.RelateClusterInfo.Status");
			clusterInfo.RelateClusterInfo = relateClusterInfo;

			DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_HostPoolInfo hostPoolInfo = new DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_HostPoolInfo();
			hostPoolInfo.HpBizId = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.HostPoolInfo.HpBizId");
			hostPoolInfo.HpName = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.HostPoolInfo.HpName");
			clusterInfo.HostPoolInfo = hostPoolInfo;

			DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_FailReason failReason = new DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_FailReason();
			failReason.ErrorCode = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.FailReason.ErrorCode");
			failReason.ErrorMsg = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.FailReason.ErrorMsg");
			failReason.RequestId = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.FailReason.RequestId");
			clusterInfo.FailReason = failReason;

			DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_SoftwareInfo softwareInfo = new DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_SoftwareInfo();
			softwareInfo.EmrVer = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.SoftwareInfo.EmrVer");
			softwareInfo.ClusterType = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.SoftwareInfo.ClusterType");

			List<DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_SoftwareInfo.DescribeClusterBasicInfo_Software> softwareInfo_softwares = new List<DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_SoftwareInfo.DescribeClusterBasicInfo_Software>();
			for (int i = 0; i < _ctx.Length("DescribeClusterBasicInfo.ClusterInfo.SoftwareInfo.Softwares.Length"); i++) {
				DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_SoftwareInfo.DescribeClusterBasicInfo_Software software = new DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_SoftwareInfo.DescribeClusterBasicInfo_Software();
				software.DisplayName = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.SoftwareInfo.Softwares["+ i +"].DisplayName");
				software.Name = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.SoftwareInfo.Softwares["+ i +"].Name");
				software.OnlyDisplay = _ctx.BooleanValue("DescribeClusterBasicInfo.ClusterInfo.SoftwareInfo.Softwares["+ i +"].OnlyDisplay");
				software.StartTpe = _ctx.IntegerValue("DescribeClusterBasicInfo.ClusterInfo.SoftwareInfo.Softwares["+ i +"].StartTpe");
				software.Version = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.SoftwareInfo.Softwares["+ i +"].Version");

				softwareInfo_softwares.Add(software);
			}
			softwareInfo.Softwares = softwareInfo_softwares;
			clusterInfo.SoftwareInfo = softwareInfo;

			DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_AccessInfo accessInfo = new DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_AccessInfo();

			List<DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_AccessInfo.DescribeClusterBasicInfo_ZKLink> accessInfo_zKLinks = new List<DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_AccessInfo.DescribeClusterBasicInfo_ZKLink>();
			for (int i = 0; i < _ctx.Length("DescribeClusterBasicInfo.ClusterInfo.AccessInfo.ZKLinks.Length"); i++) {
				DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_AccessInfo.DescribeClusterBasicInfo_ZKLink zKLink = new DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_AccessInfo.DescribeClusterBasicInfo_ZKLink();
				zKLink.Link = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.AccessInfo.ZKLinks["+ i +"].Link");
				zKLink.Port = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.AccessInfo.ZKLinks["+ i +"].Port");

				accessInfo_zKLinks.Add(zKLink);
			}
			accessInfo.ZKLinks = accessInfo_zKLinks;
			clusterInfo.AccessInfo = accessInfo;

			List<DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_GatewayClusterInfo> clusterInfo_gatewayClusterInfoList = new List<DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_GatewayClusterInfo>();
			for (int i = 0; i < _ctx.Length("DescribeClusterBasicInfo.ClusterInfo.GatewayClusterInfoList.Length"); i++) {
				DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_GatewayClusterInfo gatewayClusterInfo = new DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_GatewayClusterInfo();
				gatewayClusterInfo.ClusterId = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.GatewayClusterInfoList["+ i +"].ClusterId");
				gatewayClusterInfo.ClusterName = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.GatewayClusterInfoList["+ i +"].ClusterName");
				gatewayClusterInfo.Status = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.GatewayClusterInfoList["+ i +"].Status");

				clusterInfo_gatewayClusterInfoList.Add(gatewayClusterInfo);
			}
			clusterInfo.GatewayClusterInfoList = clusterInfo_gatewayClusterInfoList;

			List<DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_BootstrapAction> clusterInfo_bootstrapActionList = new List<DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_BootstrapAction>();
			for (int i = 0; i < _ctx.Length("DescribeClusterBasicInfo.ClusterInfo.BootstrapActionList.Length"); i++) {
				DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_BootstrapAction bootstrapAction = new DescribeClusterBasicInfoResponse.DescribeClusterBasicInfo_ClusterInfo.DescribeClusterBasicInfo_BootstrapAction();
				bootstrapAction.Name = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.BootstrapActionList["+ i +"].Name");
				bootstrapAction.Path = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.BootstrapActionList["+ i +"].Path");
				bootstrapAction.Arg = _ctx.StringValue("DescribeClusterBasicInfo.ClusterInfo.BootstrapActionList["+ i +"].Arg");

				clusterInfo_bootstrapActionList.Add(bootstrapAction);
			}
			clusterInfo.BootstrapActionList = clusterInfo_bootstrapActionList;
			describeClusterBasicInfoResponse.ClusterInfo = clusterInfo;
        
			return describeClusterBasicInfoResponse;
        }
    }
}
