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
	public class DescribeClusterBasicInfoResponse : AcsResponse
	{

		private string requestId;

		private DescribeClusterBasicInfo_ClusterInfo clusterInfo;

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

		public DescribeClusterBasicInfo_ClusterInfo ClusterInfo
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

		public class DescribeClusterBasicInfo_ClusterInfo
		{

			private string clusterId;

			private string regionId;

			private string machineType;

			private string depositType;

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

			private string operationId;

			private List<DescribeClusterBasicInfo_GatewayClusterInfo> gatewayClusterInfoList;

			private List<DescribeClusterBasicInfo_BootstrapAction> bootstrapActionList;

			private DescribeClusterBasicInfo_RelateClusterInfo relateClusterInfo;

			private DescribeClusterBasicInfo_HostPoolInfo hostPoolInfo;

			private DescribeClusterBasicInfo_FailReason failReason;

			private DescribeClusterBasicInfo_SoftwareInfo softwareInfo;

			private DescribeClusterBasicInfo_AccessInfo accessInfo;

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

			public string OperationId
			{
				get
				{
					return operationId;
				}
				set	
				{
					operationId = value;
				}
			}

			public List<DescribeClusterBasicInfo_GatewayClusterInfo> GatewayClusterInfoList
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

			public List<DescribeClusterBasicInfo_BootstrapAction> BootstrapActionList
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

			public DescribeClusterBasicInfo_RelateClusterInfo RelateClusterInfo
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

			public DescribeClusterBasicInfo_HostPoolInfo HostPoolInfo
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

			public DescribeClusterBasicInfo_FailReason FailReason
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

			public DescribeClusterBasicInfo_SoftwareInfo SoftwareInfo
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

			public DescribeClusterBasicInfo_AccessInfo AccessInfo
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

			public class DescribeClusterBasicInfo_GatewayClusterInfo
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

			public class DescribeClusterBasicInfo_BootstrapAction
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

			public class DescribeClusterBasicInfo_RelateClusterInfo
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

			public class DescribeClusterBasicInfo_HostPoolInfo
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

			public class DescribeClusterBasicInfo_FailReason
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

			public class DescribeClusterBasicInfo_SoftwareInfo
			{

				private string emrVer;

				private string clusterType;

				private List<DescribeClusterBasicInfo_Software> softwares;

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

				public List<DescribeClusterBasicInfo_Software> Softwares
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

				public class DescribeClusterBasicInfo_Software
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

			public class DescribeClusterBasicInfo_AccessInfo
			{

				private List<DescribeClusterBasicInfo_ZKLink> zKLinks;

				public List<DescribeClusterBasicInfo_ZKLink> ZKLinks
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

				public class DescribeClusterBasicInfo_ZKLink
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
