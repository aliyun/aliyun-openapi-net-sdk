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
        public static DescribeClusterV2Response Unmarshall(UnmarshallerContext context)
        {
			DescribeClusterV2Response describeClusterV2Response = new DescribeClusterV2Response();

			describeClusterV2Response.HttpResponse = context.HttpResponse;
			describeClusterV2Response.RequestId = context.StringValue("DescribeClusterV2.RequestId");

			DescribeClusterV2Response.DescribeClusterV2_ClusterInfo clusterInfo = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo();
			clusterInfo.Id = context.StringValue("DescribeClusterV2.ClusterInfo.Id");
			clusterInfo.RegionId = context.StringValue("DescribeClusterV2.ClusterInfo.RegionId");
			clusterInfo.DepositType = context.StringValue("DescribeClusterV2.ClusterInfo.DepositType");
			clusterInfo.ZoneId = context.StringValue("DescribeClusterV2.ClusterInfo.ZoneId");
			clusterInfo.Name = context.StringValue("DescribeClusterV2.ClusterInfo.Name");
			clusterInfo.RelateClusterId = context.StringValue("DescribeClusterV2.ClusterInfo.RelateClusterId");
			clusterInfo.GatewayClusterIds = context.StringValue("DescribeClusterV2.ClusterInfo.GatewayClusterIds");
			clusterInfo.CreateType = context.StringValue("DescribeClusterV2.ClusterInfo.CreateType");
			clusterInfo.StartTime = context.LongValue("DescribeClusterV2.ClusterInfo.StartTime");
			clusterInfo.ExpiredTime = context.LongValue("DescribeClusterV2.ClusterInfo.ExpiredTime");
			clusterInfo.StopTime = context.LongValue("DescribeClusterV2.ClusterInfo.StopTime");
			clusterInfo.LogEnable = context.BooleanValue("DescribeClusterV2.ClusterInfo.LogEnable");
			clusterInfo.LogPath = context.StringValue("DescribeClusterV2.ClusterInfo.LogPath");
			clusterInfo.UserId = context.StringValue("DescribeClusterV2.ClusterInfo.UserId");
			clusterInfo.Status = context.StringValue("DescribeClusterV2.ClusterInfo.Status");
			clusterInfo.HighAvailabilityEnable = context.BooleanValue("DescribeClusterV2.ClusterInfo.HighAvailabilityEnable");
			clusterInfo.LocalMetaDb = context.BooleanValue("DescribeClusterV2.ClusterInfo.LocalMetaDb");
			clusterInfo.ChargeType = context.StringValue("DescribeClusterV2.ClusterInfo.ChargeType");
			clusterInfo.Period = context.IntegerValue("DescribeClusterV2.ClusterInfo.Period");
			clusterInfo.RunningTime = context.IntegerValue("DescribeClusterV2.ClusterInfo.RunningTime");
			clusterInfo.MasterNodeTotal = context.IntegerValue("DescribeClusterV2.ClusterInfo.MasterNodeTotal");
			clusterInfo.MasterNodeInService = context.IntegerValue("DescribeClusterV2.ClusterInfo.MasterNodeInService");
			clusterInfo.CoreNodeTotal = context.IntegerValue("DescribeClusterV2.ClusterInfo.CoreNodeTotal");
			clusterInfo.CoreNodeInService = context.IntegerValue("DescribeClusterV2.ClusterInfo.CoreNodeInService");
			clusterInfo.TaskNodeTotal = context.IntegerValue("DescribeClusterV2.ClusterInfo.TaskNodeTotal");
			clusterInfo.TaskNodeInService = context.IntegerValue("DescribeClusterV2.ClusterInfo.TaskNodeInService");
			clusterInfo.ShowSoftwareInterface = context.BooleanValue("DescribeClusterV2.ClusterInfo.ShowSoftwareInterface");
			clusterInfo.CreateResource = context.StringValue("DescribeClusterV2.ClusterInfo.CreateResource");
			clusterInfo.VpcId = context.StringValue("DescribeClusterV2.ClusterInfo.VpcId");
			clusterInfo.VSwitchId = context.StringValue("DescribeClusterV2.ClusterInfo.VSwitchId");
			clusterInfo.NetType = context.StringValue("DescribeClusterV2.ClusterInfo.NetType");
			clusterInfo.UserDefinedEmrEcsRole = context.StringValue("DescribeClusterV2.ClusterInfo.UserDefinedEmrEcsRole");
			clusterInfo.IoOptimized = context.BooleanValue("DescribeClusterV2.ClusterInfo.IoOptimized");
			clusterInfo.InstanceGeneration = context.StringValue("DescribeClusterV2.ClusterInfo.InstanceGeneration");
			clusterInfo.ImageId = context.StringValue("DescribeClusterV2.ClusterInfo.ImageId");
			clusterInfo.SecurityGroupId = context.StringValue("DescribeClusterV2.ClusterInfo.SecurityGroupId");
			clusterInfo.SecurityGroupName = context.StringValue("DescribeClusterV2.ClusterInfo.SecurityGroupName");
			clusterInfo.BootstrapFailed = context.BooleanValue("DescribeClusterV2.ClusterInfo.BootstrapFailed");
			clusterInfo.Configurations = context.StringValue("DescribeClusterV2.ClusterInfo.Configurations");
			clusterInfo.EasEnable = context.BooleanValue("DescribeClusterV2.ClusterInfo.EasEnable");
			clusterInfo.AutoScalingEnable = context.BooleanValue("DescribeClusterV2.ClusterInfo.AutoScalingEnable");
			clusterInfo.AutoScalingAllowed = context.BooleanValue("DescribeClusterV2.ClusterInfo.AutoScalingAllowed");
			clusterInfo.AutoScalingSpotWithLimitAllowed = context.BooleanValue("DescribeClusterV2.ClusterInfo.AutoScalingSpotWithLimitAllowed");
			clusterInfo.AutoScalingByLoadAllowed = context.BooleanValue("DescribeClusterV2.ClusterInfo.AutoScalingByLoadAllowed");
			clusterInfo.ResizeDiskEnable = context.BooleanValue("DescribeClusterV2.ClusterInfo.ResizeDiskEnable");

			DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_RelateClusterInfo relateClusterInfo = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_RelateClusterInfo();
			relateClusterInfo.ClusterId = context.StringValue("DescribeClusterV2.ClusterInfo.RelateClusterInfo.ClusterId");
			relateClusterInfo.ClusterName = context.StringValue("DescribeClusterV2.ClusterInfo.RelateClusterInfo.ClusterName");
			relateClusterInfo.Status = context.StringValue("DescribeClusterV2.ClusterInfo.RelateClusterInfo.Status");
			clusterInfo.RelateClusterInfo = relateClusterInfo;

			DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_FailReason failReason = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_FailReason();
			failReason.ErrorCode = context.StringValue("DescribeClusterV2.ClusterInfo.FailReason.ErrorCode");
			failReason.ErrorMsg = context.StringValue("DescribeClusterV2.ClusterInfo.FailReason.ErrorMsg");
			failReason.RequestId = context.StringValue("DescribeClusterV2.ClusterInfo.FailReason.RequestId");
			clusterInfo.FailReason = failReason;

			DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_SoftwareInfo softwareInfo = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_SoftwareInfo();
			softwareInfo.EmrVer = context.StringValue("DescribeClusterV2.ClusterInfo.SoftwareInfo.EmrVer");
			softwareInfo.ClusterType = context.StringValue("DescribeClusterV2.ClusterInfo.SoftwareInfo.ClusterType");

			List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_SoftwareInfo.DescribeClusterV2_Software> softwareInfo_softwares = new List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_SoftwareInfo.DescribeClusterV2_Software>();
			for (int i = 0; i < context.Length("DescribeClusterV2.ClusterInfo.SoftwareInfo.Softwares.Length"); i++) {
				DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_SoftwareInfo.DescribeClusterV2_Software software = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_SoftwareInfo.DescribeClusterV2_Software();
				software.DisplayName = context.StringValue("DescribeClusterV2.ClusterInfo.SoftwareInfo.Softwares["+ i +"].DisplayName");
				software.Name = context.StringValue("DescribeClusterV2.ClusterInfo.SoftwareInfo.Softwares["+ i +"].Name");
				software.OnlyDisplay = context.BooleanValue("DescribeClusterV2.ClusterInfo.SoftwareInfo.Softwares["+ i +"].OnlyDisplay");
				software.StartTpe = context.IntegerValue("DescribeClusterV2.ClusterInfo.SoftwareInfo.Softwares["+ i +"].StartTpe");
				software.Version = context.StringValue("DescribeClusterV2.ClusterInfo.SoftwareInfo.Softwares["+ i +"].Version");

				softwareInfo_softwares.Add(software);
			}
			softwareInfo.Softwares = softwareInfo_softwares;
			clusterInfo.SoftwareInfo = softwareInfo;

			DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_AccessInfo accessInfo = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_AccessInfo();

			List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_AccessInfo.DescribeClusterV2_ZKLink> accessInfo_zKLinks = new List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_AccessInfo.DescribeClusterV2_ZKLink>();
			for (int i = 0; i < context.Length("DescribeClusterV2.ClusterInfo.AccessInfo.ZKLinks.Length"); i++) {
				DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_AccessInfo.DescribeClusterV2_ZKLink zKLink = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_AccessInfo.DescribeClusterV2_ZKLink();
				zKLink.Link = context.StringValue("DescribeClusterV2.ClusterInfo.AccessInfo.ZKLinks["+ i +"].Link");
				zKLink.Port = context.StringValue("DescribeClusterV2.ClusterInfo.AccessInfo.ZKLinks["+ i +"].Port");

				accessInfo_zKLinks.Add(zKLink);
			}
			accessInfo.ZKLinks = accessInfo_zKLinks;
			clusterInfo.AccessInfo = accessInfo;

			List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_GatewayClusterInfo> clusterInfo_gatewayClusterInfoList = new List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_GatewayClusterInfo>();
			for (int i = 0; i < context.Length("DescribeClusterV2.ClusterInfo.GatewayClusterInfoList.Length"); i++) {
				DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_GatewayClusterInfo gatewayClusterInfo = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_GatewayClusterInfo();
				gatewayClusterInfo.ClusterId = context.StringValue("DescribeClusterV2.ClusterInfo.GatewayClusterInfoList["+ i +"].ClusterId");
				gatewayClusterInfo.ClusterName = context.StringValue("DescribeClusterV2.ClusterInfo.GatewayClusterInfoList["+ i +"].ClusterName");
				gatewayClusterInfo.Status = context.StringValue("DescribeClusterV2.ClusterInfo.GatewayClusterInfoList["+ i +"].Status");

				clusterInfo_gatewayClusterInfoList.Add(gatewayClusterInfo);
			}
			clusterInfo.GatewayClusterInfoList = clusterInfo_gatewayClusterInfoList;

			List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup> clusterInfo_hostGroupList = new List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup>();
			for (int i = 0; i < context.Length("DescribeClusterV2.ClusterInfo.HostGroupList.Length"); i++) {
				DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup hostGroup = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup();
				hostGroup.HostGroupId = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].HostGroupId");
				hostGroup.HostGroupName = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].HostGroupName");
				hostGroup.HostGroupType = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].HostGroupType");
				hostGroup.HostGroupSubType = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].HostGroupSubType");
				hostGroup.HostGroupChangeType = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].HostGroupChangeType");
				hostGroup.HostGroupChangeStatus = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].HostGroupChangeStatus");
				hostGroup.ChargeType = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].ChargeType");
				hostGroup.Period = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Period");
				hostGroup.NodeCount = context.IntegerValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].NodeCount");
				hostGroup.InstanceType = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].InstanceType");
				hostGroup.CpuCore = context.IntegerValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].CpuCore");
				hostGroup.MemoryCapacity = context.IntegerValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].MemoryCapacity");
				hostGroup.DiskType = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].DiskType");
				hostGroup.DiskCapacity = context.IntegerValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].DiskCapacity");
				hostGroup.DiskCount = context.IntegerValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].DiskCount");
				hostGroup.BandWidth = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].BandWidth");
				hostGroup.LockType = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].LockType");
				hostGroup.LockReason = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].LockReason");

				List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node> hostGroup_nodes = new List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node>();
				for (int j = 0; j < context.Length("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes.Length"); j++) {
					DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node node = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node();
					node.ZoneId = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].ZoneId");
					node.InstanceId = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].InstanceId");
					node.Status = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].Status");
					node.PubIp = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].PubIp");
					node.InnerIp = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].InnerIp");
					node.ExpiredTime = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].ExpiredTime");
					node.CreateTime = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].CreateTime");
					node.EmrExpiredTime = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].EmrExpiredTime");
					node.SupportIpV6 = context.BooleanValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].SupportIpV6");

					List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node.DescribeClusterV2_DaemonInfo> node_daemonInfos = new List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node.DescribeClusterV2_DaemonInfo>();
					for (int k = 0; k < context.Length("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].DaemonInfos.Length"); k++) {
						DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node.DescribeClusterV2_DaemonInfo daemonInfo = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node.DescribeClusterV2_DaemonInfo();
						daemonInfo.Name = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].DaemonInfos["+ k +"].Name");

						node_daemonInfos.Add(daemonInfo);
					}
					node.DaemonInfos = node_daemonInfos;

					List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node.DescribeClusterV2_DiskInfo> node_diskInfos = new List<DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node.DescribeClusterV2_DiskInfo>();
					for (int k = 0; k < context.Length("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].DiskInfos.Length"); k++) {
						DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node.DescribeClusterV2_DiskInfo diskInfo = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_HostGroup.DescribeClusterV2_Node.DescribeClusterV2_DiskInfo();
						diskInfo.Device = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].DiskInfos["+ k +"].Device");
						diskInfo.DiskName = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].DiskInfos["+ k +"].DiskName");
						diskInfo.DiskId = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].DiskInfos["+ k +"].DiskId");
						diskInfo.Type = context.StringValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].DiskInfos["+ k +"].Type");
						diskInfo.Size = context.IntegerValue("DescribeClusterV2.ClusterInfo.HostGroupList["+ i +"].Nodes["+ j +"].DiskInfos["+ k +"].Size");

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
			for (int i = 0; i < context.Length("DescribeClusterV2.ClusterInfo.BootstrapActionList.Length"); i++) {
				DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_BootstrapAction bootstrapAction = new DescribeClusterV2Response.DescribeClusterV2_ClusterInfo.DescribeClusterV2_BootstrapAction();
				bootstrapAction.Name = context.StringValue("DescribeClusterV2.ClusterInfo.BootstrapActionList["+ i +"].Name");
				bootstrapAction.Path = context.StringValue("DescribeClusterV2.ClusterInfo.BootstrapActionList["+ i +"].Path");
				bootstrapAction.Arg = context.StringValue("DescribeClusterV2.ClusterInfo.BootstrapActionList["+ i +"].Arg");

				clusterInfo_bootstrapActionList.Add(bootstrapAction);
			}
			clusterInfo.BootstrapActionList = clusterInfo_bootstrapActionList;
			describeClusterV2Response.ClusterInfo = clusterInfo;
        
			return describeClusterV2Response;
        }
    }
}
