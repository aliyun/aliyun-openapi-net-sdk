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
    public class DescribeClusterV2ResponseUnmarshaller
    {
        public static DescribeClusterV2Response Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClusterV2Response describeClusterV2Response = new DescribeClusterV2Response();

			describeClusterV2Response.HttpResponse = _ctx.HttpResponse;
			describeClusterV2Response.RequestId = _ctx.StringValue("DescribeClusterV2.RequestId");

			DescribeClusterV2Response.DescribeClusterV2_ClusterInfo clusterInfo = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo();
			clusterInfo.Id = _ctx.StringValue("DescribeClusterV2.ClusterInfo.Id");
			clusterInfo.RegionId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.RegionId");
			clusterInfo.DepositType = _ctx.StringValue("DescribeClusterV2.ClusterInfo.DepositType");
			clusterInfo.MachineType = _ctx.StringValue("DescribeClusterV2.ClusterInfo.MachineType");
			clusterInfo.ZoneId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.ZoneId");
			clusterInfo.Name = _ctx.StringValue("DescribeClusterV2.ClusterInfo.Name");
			clusterInfo.ExtraInfo = _ctx.StringValue("DescribeClusterV2.ClusterInfo.ExtraInfo");
			clusterInfo.RelateClusterId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.RelateClusterId");
			clusterInfo.GatewayClusterIds = _ctx.StringValue("DescribeClusterV2.ClusterInfo.GatewayClusterIds");
			clusterInfo.CreateType = _ctx.StringValue("DescribeClusterV2.ClusterInfo.CreateType");
			clusterInfo.StartTime = _ctx.LongValue("DescribeClusterV2.ClusterInfo.StartTime");
			clusterInfo.ExpiredTime = _ctx.LongValue("DescribeClusterV2.ClusterInfo.ExpiredTime");
			clusterInfo.StopTime = _ctx.LongValue("DescribeClusterV2.ClusterInfo.StopTime");
			clusterInfo.LogEnable = _ctx.BooleanValue("DescribeClusterV2.ClusterInfo.LogEnable");
			clusterInfo.LogPath = _ctx.StringValue("DescribeClusterV2.ClusterInfo.LogPath");
			clusterInfo.UserId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.UserId");
			clusterInfo.Status = _ctx.StringValue("DescribeClusterV2.ClusterInfo.Status");
			clusterInfo.HighAvailabilityEnable = _ctx.BooleanValue("DescribeClusterV2.ClusterInfo.HighAvailabilityEnable");
			clusterInfo.LocalMetaDb = _ctx.BooleanValue("DescribeClusterV2.ClusterInfo.LocalMetaDb");
			clusterInfo.ChargeType = _ctx.StringValue("DescribeClusterV2.ClusterInfo.ChargeType");
			clusterInfo.Period = _ctx.IntegerValue("DescribeClusterV2.ClusterInfo.Period");
			clusterInfo.RunningTime = _ctx.IntegerValue("DescribeClusterV2.ClusterInfo.RunningTime");
			clusterInfo.MasterNodeTotal = _ctx.IntegerValue("DescribeClusterV2.ClusterInfo.MasterNodeTotal");
			clusterInfo.MasterNodeInService = _ctx.IntegerValue("DescribeClusterV2.ClusterInfo.MasterNodeInService");
			clusterInfo.CoreNodeTotal = _ctx.IntegerValue("DescribeClusterV2.ClusterInfo.CoreNodeTotal");
			clusterInfo.CoreNodeInService = _ctx.IntegerValue("DescribeClusterV2.ClusterInfo.CoreNodeInService");
			clusterInfo.TaskNodeTotal = _ctx.IntegerValue("DescribeClusterV2.ClusterInfo.TaskNodeTotal");
			clusterInfo.TaskNodeInService = _ctx.IntegerValue("DescribeClusterV2.ClusterInfo.TaskNodeInService");
			clusterInfo.ShowSoftwareInterface = _ctx.BooleanValue("DescribeClusterV2.ClusterInfo.ShowSoftwareInterface");
			clusterInfo.CreateResource = _ctx.StringValue("DescribeClusterV2.ClusterInfo.CreateResource");
			clusterInfo.VpcId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.VpcId");
			clusterInfo.VSwitchId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.VSwitchId");
			clusterInfo.NetType = _ctx.StringValue("DescribeClusterV2.ClusterInfo.NetType");
			clusterInfo.UserDefinedEmrEcsRole = _ctx.StringValue("DescribeClusterV2.ClusterInfo.UserDefinedEmrEcsRole");
			clusterInfo.IoOptimized = _ctx.BooleanValue("DescribeClusterV2.ClusterInfo.IoOptimized");
			clusterInfo.InstanceGeneration = _ctx.StringValue("DescribeClusterV2.ClusterInfo.InstanceGeneration");
			clusterInfo.ImageId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.ImageId");
			clusterInfo.SecurityGroupId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.SecurityGroupId");
			clusterInfo.SecurityGroupName = _ctx.StringValue("DescribeClusterV2.ClusterInfo.SecurityGroupName");
			clusterInfo.BootstrapFailed = _ctx.BooleanValue("DescribeClusterV2.ClusterInfo.BootstrapFailed");
			clusterInfo.Configurations = _ctx.StringValue("DescribeClusterV2.ClusterInfo.Configurations");
			clusterInfo.EasEnable = _ctx.BooleanValue("DescribeClusterV2.ClusterInfo.EasEnable");
			clusterInfo.AutoScalingVersion = _ctx.StringValue("DescribeClusterV2.ClusterInfo.AutoScalingVersion");
			clusterInfo.AutoScalingEnable = _ctx.BooleanValue("DescribeClusterV2.ClusterInfo.AutoScalingEnable");
			clusterInfo.AutoScalingAllowed = _ctx.BooleanValue("DescribeClusterV2.ClusterInfo.AutoScalingAllowed");
			clusterInfo.AutoScalingSpotWithLimitAllowed = _ctx.BooleanValue("DescribeClusterV2.ClusterInfo.AutoScalingSpotWithLimitAllowed");
			clusterInfo.AutoScalingByLoadAllowed = _ctx.BooleanValue("DescribeClusterV2.ClusterInfo.AutoScalingByLoadAllowed");
			clusterInfo.AutoScalingWithGraceAllowed = _ctx.BooleanValue("DescribeClusterV2.ClusterInfo.AutoScalingWithGraceAllowed");
			clusterInfo.ResizeDiskEnable = _ctx.BooleanValue("DescribeClusterV2.ClusterInfo.ResizeDiskEnable");
			clusterInfo.MetaStoreType = _ctx.StringValue("DescribeClusterV2.ClusterInfo.MetaStoreType");
			clusterInfo.K8sClusterId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.K8sClusterId");

			DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_RelateClusterInfo relateClusterInfo = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_RelateClusterInfo();
			relateClusterInfo.ClusterId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.RelateClusterInfo.ClusterId");
			relateClusterInfo.ClusterName = _ctx.StringValue("DescribeClusterV2.ClusterInfo.RelateClusterInfo.ClusterName");
			relateClusterInfo.Status = _ctx.StringValue("DescribeClusterV2.ClusterInfo.RelateClusterInfo.Status");
			clusterInfo.RelateClusterInfo = relateClusterInfo;

			DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostPoolInfo hostPoolInfo = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostPoolInfo();
			hostPoolInfo.HpBizId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostPoolInfo.HpBizId");
			hostPoolInfo.HpName = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostPoolInfo.HpName");
			clusterInfo.HostPoolInfo = hostPoolInfo;

			DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_FailReason failReason = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_FailReason();
			failReason.ErrorCode = _ctx.StringValue("DescribeClusterV2.ClusterInfo.FailReason.ErrorCode");
			failReason.ErrorMsg = _ctx.StringValue("DescribeClusterV2.ClusterInfo.FailReason.ErrorMsg");
			failReason.RequestId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.FailReason.RequestId");
			clusterInfo.FailReason = failReason;

			DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_SoftwareInfo softwareInfo = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_SoftwareInfo();
			softwareInfo.EmrVer = _ctx.StringValue("DescribeClusterV2.ClusterInfo.SoftwareInfo.EmrVer");
			softwareInfo.ClusterType = _ctx.StringValue("DescribeClusterV2.ClusterInfo.SoftwareInfo.ClusterType");

			List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_SoftwareInfo.DescribeClusterV2_Software> softwareInfo_softwares = new List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_SoftwareInfo.DescribeClusterV2_Software>();
			for (int i = 0; i < _ctx.Length("DescribeClusterV2.ClusterInfo.SoftwareInfo.Softwares.Length"); i++) {
				DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_SoftwareInfo.DescribeClusterV2_Software software = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_SoftwareInfo.DescribeClusterV2_Software();
				software.DisplayName = _ctx.StringValue("DescribeClusterV2.ClusterInfo.SoftwareInfo.Softwares["+ i +"].DisplayName");
				software.Name = _ctx.StringValue("DescribeClusterV2.ClusterInfo.SoftwareInfo.Softwares["+ i +"].Name");
				software.OnlyDisplay = _ctx.BooleanValue("DescribeClusterV2.ClusterInfo.SoftwareInfo.Softwares["+ i +"].OnlyDisplay");
				software.StartTpe = _ctx.IntegerValue("DescribeClusterV2.ClusterInfo.SoftwareInfo.Softwares["+ i +"].StartTpe");
				software.Version = _ctx.StringValue("DescribeClusterV2.ClusterInfo.SoftwareInfo.Softwares["+ i +"].Version");

				softwareInfo_softwares.Add(software);
			}
			softwareInfo.Softwares = softwareInfo_softwares;
			clusterInfo.SoftwareInfo = softwareInfo;

			DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_AccessInfo accessInfo = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_AccessInfo();

			List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_AccessInfo.DescribeClusterV2_ZKLink> accessInfo_zKLinks = new List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_AccessInfo.DescribeClusterV2_ZKLink>();
			for (int i = 0; i < _ctx.Length("DescribeClusterV2.ClusterInfo.AccessInfo.ZKLinks.Length"); i++) {
				DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_AccessInfo.DescribeClusterV2_ZKLink zKLink = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_AccessInfo.DescribeClusterV2_ZKLink();
				zKLink.Link = _ctx.StringValue("DescribeClusterV2.ClusterInfo.AccessInfo.ZKLinks["+ i +"].Link");
				zKLink.Port = _ctx.StringValue("DescribeClusterV2.ClusterInfo.AccessInfo.ZKLinks["+ i +"].Port");

				accessInfo_zKLinks.Add(zKLink);
			}
			accessInfo.ZKLinks = accessInfo_zKLinks;
			clusterInfo.AccessInfo = accessInfo;

			List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_GatewayClusterInfo> clusterInfo_gatewayClusterInfoList = new List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_GatewayClusterInfo>();
			for (int i = 0; i < _ctx.Length("DescribeClusterV2.ClusterInfo.GatewayClusterInfoList.Length"); i++) {
				DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_GatewayClusterInfo gatewayClusterInfo = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_GatewayClusterInfo();
				gatewayClusterInfo.ClusterId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.GatewayClusterInfoList["+ i +"].ClusterId");
				gatewayClusterInfo.ClusterName = _ctx.StringValue("DescribeClusterV2.ClusterInfo.GatewayClusterInfoList["+ i +"].ClusterName");
				gatewayClusterInfo.Status = _ctx.StringValue("DescribeClusterV2.ClusterInfo.GatewayClusterInfoList["+ i +"].Status");

				clusterInfo_gatewayClusterInfoList.Add(gatewayClusterInfo);
			}
			clusterInfo.GatewayClusterInfoList = clusterInfo_gatewayClusterInfoList;

			List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup> clusterInfo_hostGroupList = new List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup>();
			for (int i = 0; i < _ctx.Length("DescribeClusterV2.ClusterInfo.HostGroupList.Length"); i++) {
				DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup hostGroup = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup();
				hostGroup.HostGroupId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].HostGroupId");
				hostGroup.HostGroupName = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].HostGroupName");
				hostGroup.HostGroupType = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].HostGroupType");
				hostGroup.HostGroupSubType = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].HostGroupSubType");
				hostGroup.HostGroupChangeType = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].HostGroupChangeType");
				hostGroup.HostGroupChangeStatus = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].HostGroupChangeStatus");
				hostGroup.ChargeType = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].ChargeType");
				hostGroup.Period = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Period");
				hostGroup.NodeCount = _ctx.IntegerValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].NodeCount");
				hostGroup.InstanceType = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].InstanceType");
				hostGroup.CpuCore = _ctx.IntegerValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].CpuCore");
				hostGroup.MemoryCapacity = _ctx.IntegerValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].MemoryCapacity");
				hostGroup.DiskType = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].DiskType");
				hostGroup.DiskCapacity = _ctx.IntegerValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].DiskCapacity");
				hostGroup.DiskCount = _ctx.IntegerValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].DiskCount");
				hostGroup.BandWidth = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].BandWidth");
				hostGroup.LockType = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].LockType");
				hostGroup.LockReason = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].LockReason");

				List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node> hostGroup_nodes = new List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node>();
				for (int j = 0; j < _ctx.Length("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes.Length"); j++) {
					DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node node = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node();
					node.ZoneId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].ZoneId");
					node.InstanceId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].InstanceId");
					node.Status = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].Status");
					node.PubIp = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].PubIp");
					node.InnerIp = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].InnerIp");
					node.ExpiredTime = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].ExpiredTime");
					node.CreateTime = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].CreateTime");
					node.EmrExpiredTime = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].EmrExpiredTime");
					node.SupportIpV6 = _ctx.BooleanValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].SupportIpV6");

					List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node.DescribeClusterV2_DaemonInfo> node_daemonInfos = new List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node.DescribeClusterV2_DaemonInfo>();
					for (int k = 0; k < _ctx.Length("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].DaemonInfos.Length"); k++) {
						DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node.DescribeClusterV2_DaemonInfo daemonInfo = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node.DescribeClusterV2_DaemonInfo();
						daemonInfo.Name = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].DaemonInfos["+ k +"].Name");

						node_daemonInfos.Add(daemonInfo);
					}
					node.DaemonInfos = node_daemonInfos;

					List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node.DescribeClusterV2_DiskInfo> node_diskInfos = new List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node.DescribeClusterV2_DiskInfo>();
					for (int k = 0; k < _ctx.Length("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].DiskInfos.Length"); k++) {
						DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node.DescribeClusterV2_DiskInfo diskInfo = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node.DescribeClusterV2_DiskInfo();
						diskInfo.Device = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].DiskInfos["+ k +"].Device");
						diskInfo.DiskName = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].DiskInfos["+ k +"].DiskName");
						diskInfo.DiskId = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].DiskInfos["+ k +"].DiskId");
						diskInfo.Type = _ctx.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].DiskInfos["+ k +"].Type");
						diskInfo.Size = _ctx.IntegerValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].DiskInfos["+ k +"].Size");

						node_diskInfos.Add(diskInfo);
					}
					node.DiskInfos = node_diskInfos;

					hostGroup_nodes.Add(node);
				}
				hostGroup.Nodes = hostGroup_nodes;

				clusterInfo_hostGroupList.Add(hostGroup);
			}
			clusterInfo.HostGroupList = clusterInfo_hostGroupList;

			List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_BootstrapAction> clusterInfo_bootstrapActionList = new List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_BootstrapAction>();
			for (int i = 0; i < _ctx.Length("DescribeClusterV2.ClusterInfo.BootstrapActionList.Length"); i++) {
				DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_BootstrapAction bootstrapAction = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_BootstrapAction();
				bootstrapAction.Name = _ctx.StringValue("DescribeClusterV2.ClusterInfo.BootstrapActionList["+ i +"].Name");
				bootstrapAction.Path = _ctx.StringValue("DescribeClusterV2.ClusterInfo.BootstrapActionList["+ i +"].Path");
				bootstrapAction.Arg = _ctx.StringValue("DescribeClusterV2.ClusterInfo.BootstrapActionList["+ i +"].Arg");

				clusterInfo_bootstrapActionList.Add(bootstrapAction);
			}
			clusterInfo.BootstrapActionList = clusterInfo_bootstrapActionList;
			describeClusterV2Response.ClusterInfo = clusterInfo;
        
			return describeClusterV2Response;
        }
    }
}
