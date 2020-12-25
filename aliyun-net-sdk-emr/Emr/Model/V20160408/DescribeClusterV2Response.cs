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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class DescribeClusterV2Response : AcsResponse
	{

		private string requestId;

		private DescribeClusterV2_ClusterInfo clusterInfo;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public DescribeClusterV2_ClusterInfo ClusterInfo
		{
			get
			{
				return clusterInfo;
			}
			set	
			{
				clusterInfo = value;
			}
		}

		public class DescribeClusterV2_ClusterInfo
		{

			private string id;

			private string regionId;

			private string depositType;

			private string machineType;

			private string zoneId;

			private string name;

			private string extraInfo;

			private string relateClusterId;

			private string gatewayClusterIds;

			private string createType;

			private long? startTime;

			private long? expiredTime;

			private long? stopTime;

			private bool? logEnable;

			private string logPath;

			private string userId;

			private string status;

			private bool? highAvailabilityEnable;

			private bool? localMetaDb;

			private string chargeType;

			private int? period;

			private int? runningTime;

			private int? masterNodeTotal;

			private int? masterNodeInService;

			private int? coreNodeTotal;

			private int? coreNodeInService;

			private int? taskNodeTotal;

			private int? taskNodeInService;

			private bool? showSoftwareInterface;

			private string createResource;

			private string vpcId;

			private string vSwitchId;

			private string netType;

			private string userDefinedEmrEcsRole;

			private bool? ioOptimized;

			private string instanceGeneration;

			private string imageId;

			private string securityGroupId;

			private string securityGroupName;

			private bool? bootstrapFailed;

			private string configurations;

			private bool? easEnable;

			private string autoScalingVersion;

			private bool? autoScalingEnable;

			private bool? autoScalingAllowed;

			private bool? autoScalingSpotWithLimitAllowed;

			private bool? autoScalingByLoadAllowed;

			private bool? autoScalingWithGraceAllowed;

			private bool? resizeDiskEnable;

			private string metaStoreType;

			private string k8sClusterId;

			private List<DescribeClusterV2_GatewayClusterInfo> gatewayClusterInfoList;

			private List<DescribeClusterV2_HostGroup> hostGroupList;

			private List<DescribeClusterV2_BootstrapAction> bootstrapActionList;

			private DescribeClusterV2_RelateClusterInfo relateClusterInfo;

			private DescribeClusterV2_HostPoolInfo hostPoolInfo;

			private DescribeClusterV2_FailReason failReason;

			private DescribeClusterV2_SoftwareInfo softwareInfo;

			private DescribeClusterV2_AccessInfo accessInfo;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string DepositType
			{
				get
				{
					return depositType;
				}
				set	
				{
					depositType = value;
				}
			}

			public string MachineType
			{
				get
				{
					return machineType;
				}
				set	
				{
					machineType = value;
				}
			}

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string ExtraInfo
			{
				get
				{
					return extraInfo;
				}
				set	
				{
					extraInfo = value;
				}
			}

			public string RelateClusterId
			{
				get
				{
					return relateClusterId;
				}
				set	
				{
					relateClusterId = value;
				}
			}

			public string GatewayClusterIds
			{
				get
				{
					return gatewayClusterIds;
				}
				set	
				{
					gatewayClusterIds = value;
				}
			}

			public string CreateType
			{
				get
				{
					return createType;
				}
				set	
				{
					createType = value;
				}
			}

			public long? StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public long? ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
				}
			}

			public long? StopTime
			{
				get
				{
					return stopTime;
				}
				set	
				{
					stopTime = value;
				}
			}

			public bool? LogEnable
			{
				get
				{
					return logEnable;
				}
				set	
				{
					logEnable = value;
				}
			}

			public string LogPath
			{
				get
				{
					return logPath;
				}
				set	
				{
					logPath = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public bool? HighAvailabilityEnable
			{
				get
				{
					return highAvailabilityEnable;
				}
				set	
				{
					highAvailabilityEnable = value;
				}
			}

			public bool? LocalMetaDb
			{
				get
				{
					return localMetaDb;
				}
				set	
				{
					localMetaDb = value;
				}
			}

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			public int? Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
				}
			}

			public int? RunningTime
			{
				get
				{
					return runningTime;
				}
				set	
				{
					runningTime = value;
				}
			}

			public int? MasterNodeTotal
			{
				get
				{
					return masterNodeTotal;
				}
				set	
				{
					masterNodeTotal = value;
				}
			}

			public int? MasterNodeInService
			{
				get
				{
					return masterNodeInService;
				}
				set	
				{
					masterNodeInService = value;
				}
			}

			public int? CoreNodeTotal
			{
				get
				{
					return coreNodeTotal;
				}
				set	
				{
					coreNodeTotal = value;
				}
			}

			public int? CoreNodeInService
			{
				get
				{
					return coreNodeInService;
				}
				set	
				{
					coreNodeInService = value;
				}
			}

			public int? TaskNodeTotal
			{
				get
				{
					return taskNodeTotal;
				}
				set	
				{
					taskNodeTotal = value;
				}
			}

			public int? TaskNodeInService
			{
				get
				{
					return taskNodeInService;
				}
				set	
				{
					taskNodeInService = value;
				}
			}

			public bool? ShowSoftwareInterface
			{
				get
				{
					return showSoftwareInterface;
				}
				set	
				{
					showSoftwareInterface = value;
				}
			}

			public string CreateResource
			{
				get
				{
					return createResource;
				}
				set	
				{
					createResource = value;
				}
			}

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
				}
			}

			public string NetType
			{
				get
				{
					return netType;
				}
				set	
				{
					netType = value;
				}
			}

			public string UserDefinedEmrEcsRole
			{
				get
				{
					return userDefinedEmrEcsRole;
				}
				set	
				{
					userDefinedEmrEcsRole = value;
				}
			}

			public bool? IoOptimized
			{
				get
				{
					return ioOptimized;
				}
				set	
				{
					ioOptimized = value;
				}
			}

			public string InstanceGeneration
			{
				get
				{
					return instanceGeneration;
				}
				set	
				{
					instanceGeneration = value;
				}
			}

			public string ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
				}
			}

			public string SecurityGroupId
			{
				get
				{
					return securityGroupId;
				}
				set	
				{
					securityGroupId = value;
				}
			}

			public string SecurityGroupName
			{
				get
				{
					return securityGroupName;
				}
				set	
				{
					securityGroupName = value;
				}
			}

			public bool? BootstrapFailed
			{
				get
				{
					return bootstrapFailed;
				}
				set	
				{
					bootstrapFailed = value;
				}
			}

			public string Configurations
			{
				get
				{
					return configurations;
				}
				set	
				{
					configurations = value;
				}
			}

			public bool? EasEnable
			{
				get
				{
					return easEnable;
				}
				set	
				{
					easEnable = value;
				}
			}

			public string AutoScalingVersion
			{
				get
				{
					return autoScalingVersion;
				}
				set	
				{
					autoScalingVersion = value;
				}
			}

			public bool? AutoScalingEnable
			{
				get
				{
					return autoScalingEnable;
				}
				set	
				{
					autoScalingEnable = value;
				}
			}

			public bool? AutoScalingAllowed
			{
				get
				{
					return autoScalingAllowed;
				}
				set	
				{
					autoScalingAllowed = value;
				}
			}

			public bool? AutoScalingSpotWithLimitAllowed
			{
				get
				{
					return autoScalingSpotWithLimitAllowed;
				}
				set	
				{
					autoScalingSpotWithLimitAllowed = value;
				}
			}

			public bool? AutoScalingByLoadAllowed
			{
				get
				{
					return autoScalingByLoadAllowed;
				}
				set	
				{
					autoScalingByLoadAllowed = value;
				}
			}

			public bool? AutoScalingWithGraceAllowed
			{
				get
				{
					return autoScalingWithGraceAllowed;
				}
				set	
				{
					autoScalingWithGraceAllowed = value;
				}
			}

			public bool? ResizeDiskEnable
			{
				get
				{
					return resizeDiskEnable;
				}
				set	
				{
					resizeDiskEnable = value;
				}
			}

			public string MetaStoreType
			{
				get
				{
					return metaStoreType;
				}
				set	
				{
					metaStoreType = value;
				}
			}

			public string K8sClusterId
			{
				get
				{
					return k8sClusterId;
				}
				set	
				{
					k8sClusterId = value;
				}
			}

			public List<DescribeClusterV2_GatewayClusterInfo> GatewayClusterInfoList
			{
				get
				{
					return gatewayClusterInfoList;
				}
				set	
				{
					gatewayClusterInfoList = value;
				}
			}

			public List<DescribeClusterV2_HostGroup> HostGroupList
			{
				get
				{
					return hostGroupList;
				}
				set	
				{
					hostGroupList = value;
				}
			}

			public List<DescribeClusterV2_BootstrapAction> BootstrapActionList
			{
				get
				{
					return bootstrapActionList;
				}
				set	
				{
					bootstrapActionList = value;
				}
			}

			public DescribeClusterV2_RelateClusterInfo RelateClusterInfo
			{
				get
				{
					return relateClusterInfo;
				}
				set	
				{
					relateClusterInfo = value;
				}
			}

			public DescribeClusterV2_HostPoolInfo HostPoolInfo
			{
				get
				{
					return hostPoolInfo;
				}
				set	
				{
					hostPoolInfo = value;
				}
			}

			public DescribeClusterV2_FailReason FailReason
			{
				get
				{
					return failReason;
				}
				set	
				{
					failReason = value;
				}
			}

			public DescribeClusterV2_SoftwareInfo SoftwareInfo
			{
				get
				{
					return softwareInfo;
				}
				set	
				{
					softwareInfo = value;
				}
			}

			public DescribeClusterV2_AccessInfo AccessInfo
			{
				get
				{
					return accessInfo;
				}
				set	
				{
					accessInfo = value;
				}
			}

			public class DescribeClusterV2_GatewayClusterInfo
			{

				private string clusterId;

				private string clusterName;

				private string status;

				public string ClusterId
				{
					get
					{
						return clusterId;
					}
					set	
					{
						clusterId = value;
					}
				}

				public string ClusterName
				{
					get
					{
						return clusterName;
					}
					set	
					{
						clusterName = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeClusterV2_HostGroup
			{

				private string hostGroupId;

				private string hostGroupName;

				private string hostGroupType;

				private string hostGroupSubType;

				private string hostGroupChangeType;

				private string hostGroupChangeStatus;

				private string chargeType;

				private string period;

				private int? nodeCount;

				private string instanceType;

				private int? cpuCore;

				private int? memoryCapacity;

				private string diskType;

				private int? diskCapacity;

				private int? diskCount;

				private string bandWidth;

				private string lockType;

				private string lockReason;

				private List<DescribeClusterV2_Node> nodes;

				public string HostGroupId
				{
					get
					{
						return hostGroupId;
					}
					set	
					{
						hostGroupId = value;
					}
				}

				public string HostGroupName
				{
					get
					{
						return hostGroupName;
					}
					set	
					{
						hostGroupName = value;
					}
				}

				public string HostGroupType
				{
					get
					{
						return hostGroupType;
					}
					set	
					{
						hostGroupType = value;
					}
				}

				public string HostGroupSubType
				{
					get
					{
						return hostGroupSubType;
					}
					set	
					{
						hostGroupSubType = value;
					}
				}

				public string HostGroupChangeType
				{
					get
					{
						return hostGroupChangeType;
					}
					set	
					{
						hostGroupChangeType = value;
					}
				}

				public string HostGroupChangeStatus
				{
					get
					{
						return hostGroupChangeStatus;
					}
					set	
					{
						hostGroupChangeStatus = value;
					}
				}

				public string ChargeType
				{
					get
					{
						return chargeType;
					}
					set	
					{
						chargeType = value;
					}
				}

				public string Period
				{
					get
					{
						return period;
					}
					set	
					{
						period = value;
					}
				}

				public int? NodeCount
				{
					get
					{
						return nodeCount;
					}
					set	
					{
						nodeCount = value;
					}
				}

				public string InstanceType
				{
					get
					{
						return instanceType;
					}
					set	
					{
						instanceType = value;
					}
				}

				public int? CpuCore
				{
					get
					{
						return cpuCore;
					}
					set	
					{
						cpuCore = value;
					}
				}

				public int? MemoryCapacity
				{
					get
					{
						return memoryCapacity;
					}
					set	
					{
						memoryCapacity = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}

				public int? DiskCapacity
				{
					get
					{
						return diskCapacity;
					}
					set	
					{
						diskCapacity = value;
					}
				}

				public int? DiskCount
				{
					get
					{
						return diskCount;
					}
					set	
					{
						diskCount = value;
					}
				}

				public string BandWidth
				{
					get
					{
						return bandWidth;
					}
					set	
					{
						bandWidth = value;
					}
				}

				public string LockType
				{
					get
					{
						return lockType;
					}
					set	
					{
						lockType = value;
					}
				}

				public string LockReason
				{
					get
					{
						return lockReason;
					}
					set	
					{
						lockReason = value;
					}
				}

				public List<DescribeClusterV2_Node> Nodes
				{
					get
					{
						return nodes;
					}
					set	
					{
						nodes = value;
					}
				}

				public class DescribeClusterV2_Node
				{

					private string zoneId;

					private string instanceId;

					private string status;

					private string pubIp;

					private string innerIp;

					private string expiredTime;

					private string createTime;

					private string emrExpiredTime;

					private bool? supportIpV6;

					private List<DescribeClusterV2_DaemonInfo> daemonInfos;

					private List<DescribeClusterV2_DiskInfo> diskInfos;

					public string ZoneId
					{
						get
						{
							return zoneId;
						}
						set	
						{
							zoneId = value;
						}
					}

					public string InstanceId
					{
						get
						{
							return instanceId;
						}
						set	
						{
							instanceId = value;
						}
					}

					public string Status
					{
						get
						{
							return status;
						}
						set	
						{
							status = value;
						}
					}

					public string PubIp
					{
						get
						{
							return pubIp;
						}
						set	
						{
							pubIp = value;
						}
					}

					public string InnerIp
					{
						get
						{
							return innerIp;
						}
						set	
						{
							innerIp = value;
						}
					}

					public string ExpiredTime
					{
						get
						{
							return expiredTime;
						}
						set	
						{
							expiredTime = value;
						}
					}

					public string CreateTime
					{
						get
						{
							return createTime;
						}
						set	
						{
							createTime = value;
						}
					}

					public string EmrExpiredTime
					{
						get
						{
							return emrExpiredTime;
						}
						set	
						{
							emrExpiredTime = value;
						}
					}

					public bool? SupportIpV6
					{
						get
						{
							return supportIpV6;
						}
						set	
						{
							supportIpV6 = value;
						}
					}

					public List<DescribeClusterV2_DaemonInfo> DaemonInfos
					{
						get
						{
							return daemonInfos;
						}
						set	
						{
							daemonInfos = value;
						}
					}

					public List<DescribeClusterV2_DiskInfo> DiskInfos
					{
						get
						{
							return diskInfos;
						}
						set	
						{
							diskInfos = value;
						}
					}

					public class DescribeClusterV2_DaemonInfo
					{

						private string name;

						public string Name
						{
							get
							{
								return name;
							}
							set	
							{
								name = value;
							}
						}
					}

					public class DescribeClusterV2_DiskInfo
					{

						private string device;

						private string diskName;

						private string diskId;

						private string type;

						private int? size;

						public string Device
						{
							get
							{
								return device;
							}
							set	
							{
								device = value;
							}
						}

						public string DiskName
						{
							get
							{
								return diskName;
							}
							set	
							{
								diskName = value;
							}
						}

						public string DiskId
						{
							get
							{
								return diskId;
							}
							set	
							{
								diskId = value;
							}
						}

						public string Type
						{
							get
							{
								return type;
							}
							set	
							{
								type = value;
							}
						}

						public int? Size
						{
							get
							{
								return size;
							}
							set	
							{
								size = value;
							}
						}
					}
				}
			}

			public class DescribeClusterV2_BootstrapAction
			{

				private string name;

				private string path;

				private string arg;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string Path
				{
					get
					{
						return path;
					}
					set	
					{
						path = value;
					}
				}

				public string Arg
				{
					get
					{
						return arg;
					}
					set	
					{
						arg = value;
					}
				}
			}

			public class DescribeClusterV2_RelateClusterInfo
			{

				private string clusterId;

				private string clusterName;

				private string status;

				public string ClusterId
				{
					get
					{
						return clusterId;
					}
					set	
					{
						clusterId = value;
					}
				}

				public string ClusterName
				{
					get
					{
						return clusterName;
					}
					set	
					{
						clusterName = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeClusterV2_HostPoolInfo
			{

				private string hpBizId;

				private string hpName;

				public string HpBizId
				{
					get
					{
						return hpBizId;
					}
					set	
					{
						hpBizId = value;
					}
				}

				public string HpName
				{
					get
					{
						return hpName;
					}
					set	
					{
						hpName = value;
					}
				}
			}

			public class DescribeClusterV2_FailReason
			{

				private string errorCode;

				private string errorMsg;

				private string requestId;

				public string ErrorCode
				{
					get
					{
						return errorCode;
					}
					set	
					{
						errorCode = value;
					}
				}

				public string ErrorMsg
				{
					get
					{
						return errorMsg;
					}
					set	
					{
						errorMsg = value;
					}
				}

				public string RequestId
				{
					get
					{
						return requestId;
					}
					set	
					{
						requestId = value;
					}
				}
			}

			public class DescribeClusterV2_SoftwareInfo
			{

				private string emrVer;

				private string clusterType;

				private List<DescribeClusterV2_Software> softwares;

				public string EmrVer
				{
					get
					{
						return emrVer;
					}
					set	
					{
						emrVer = value;
					}
				}

				public string ClusterType
				{
					get
					{
						return clusterType;
					}
					set	
					{
						clusterType = value;
					}
				}

				public List<DescribeClusterV2_Software> Softwares
				{
					get
					{
						return softwares;
					}
					set	
					{
						softwares = value;
					}
				}

				public class DescribeClusterV2_Software
				{

					private string displayName;

					private string name;

					private bool? onlyDisplay;

					private int? startTpe;

					private string version;

					public string DisplayName
					{
						get
						{
							return displayName;
						}
						set	
						{
							displayName = value;
						}
					}

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public bool? OnlyDisplay
					{
						get
						{
							return onlyDisplay;
						}
						set	
						{
							onlyDisplay = value;
						}
					}

					public int? StartTpe
					{
						get
						{
							return startTpe;
						}
						set	
						{
							startTpe = value;
						}
					}

					public string Version
					{
						get
						{
							return version;
						}
						set	
						{
							version = value;
						}
					}
				}
			}

			public class DescribeClusterV2_AccessInfo
			{

				private List<DescribeClusterV2_ZKLink> zKLinks;

				public List<DescribeClusterV2_ZKLink> ZKLinks
				{
					get
					{
						return zKLinks;
					}
					set	
					{
						zKLinks = value;
					}
				}

				public class DescribeClusterV2_ZKLink
				{

					private string link;

					private string port;

					public string Link
					{
						get
						{
							return link;
						}
						set	
						{
							link = value;
						}
					}

					public string Port
					{
						get
						{
							return port;
						}
						set	
						{
							port = value;
						}
					}
				}
			}
		}
	}
}
