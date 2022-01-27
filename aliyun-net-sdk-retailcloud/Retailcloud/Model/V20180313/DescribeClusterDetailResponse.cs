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

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
	public class DescribeClusterDetailResponse : AcsResponse
	{

		private int? code;

		private string errMsg;

		private string requestId;

		private bool? success;

		private DescribeClusterDetail_Result result;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string ErrMsg
		{
			get
			{
				return errMsg;
			}
			set	
			{
				errMsg = value;
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public DescribeClusterDetail_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeClusterDetail_Result
		{

			private List<DescribeClusterDetail_ClusterNodeWorkLoad> nodeWorkLoadList;

			private DescribeClusterDetail_BasicInfo basicInfo;

			private DescribeClusterDetail_InstanceInfo instanceInfo;

			private DescribeClusterDetail_NetInfo netInfo;

			private DescribeClusterDetail_WorkLoad workLoad;

			public List<DescribeClusterDetail_ClusterNodeWorkLoad> NodeWorkLoadList
			{
				get
				{
					return nodeWorkLoadList;
				}
				set	
				{
					nodeWorkLoadList = value;
				}
			}

			public DescribeClusterDetail_BasicInfo BasicInfo
			{
				get
				{
					return basicInfo;
				}
				set	
				{
					basicInfo = value;
				}
			}

			public DescribeClusterDetail_InstanceInfo InstanceInfo
			{
				get
				{
					return instanceInfo;
				}
				set	
				{
					instanceInfo = value;
				}
			}

			public DescribeClusterDetail_NetInfo NetInfo
			{
				get
				{
					return netInfo;
				}
				set	
				{
					netInfo = value;
				}
			}

			public DescribeClusterDetail_WorkLoad WorkLoad
			{
				get
				{
					return workLoad;
				}
				set	
				{
					workLoad = value;
				}
			}

			public class DescribeClusterDetail_ClusterNodeWorkLoad
			{

				private int? appPodCount;

				private string cpuRequest;

				private string cpuTotal;

				private string cpuUse;

				private string instanceId;

				private string memRequest;

				private string memTotal;

				private string memUse;

				private string nodeName;

				private int? podCount;

				private bool? ready;

				private bool? unschedulable;

				public int? AppPodCount
				{
					get
					{
						return appPodCount;
					}
					set	
					{
						appPodCount = value;
					}
				}

				public string CpuRequest
				{
					get
					{
						return cpuRequest;
					}
					set	
					{
						cpuRequest = value;
					}
				}

				public string CpuTotal
				{
					get
					{
						return cpuTotal;
					}
					set	
					{
						cpuTotal = value;
					}
				}

				public string CpuUse
				{
					get
					{
						return cpuUse;
					}
					set	
					{
						cpuUse = value;
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

				public string MemRequest
				{
					get
					{
						return memRequest;
					}
					set	
					{
						memRequest = value;
					}
				}

				public string MemTotal
				{
					get
					{
						return memTotal;
					}
					set	
					{
						memTotal = value;
					}
				}

				public string MemUse
				{
					get
					{
						return memUse;
					}
					set	
					{
						memUse = value;
					}
				}

				public string NodeName
				{
					get
					{
						return nodeName;
					}
					set	
					{
						nodeName = value;
					}
				}

				public int? PodCount
				{
					get
					{
						return podCount;
					}
					set	
					{
						podCount = value;
					}
				}

				public bool? Ready
				{
					get
					{
						return ready;
					}
					set	
					{
						ready = value;
					}
				}

				public bool? Unschedulable
				{
					get
					{
						return unschedulable;
					}
					set	
					{
						unschedulable = value;
					}
				}
			}

			public class DescribeClusterDetail_BasicInfo
			{

				private string businessCode;

				private long? clusterId;

				private string clusterInstanceId;

				private string clusterName;

				private string envType;

				private bool? hasInstallArmsPilot;

				private bool? hasInstallLogController;

				private bool? installArmsInProcess;

				private bool? installLogInProcess;

				private string mainUserId;

				private string regionId;

				private string regionName;

				private string userNick;

				private string vpcId;

				private List<string> ecsIds;

				private List<string> vswitchs;

				public string BusinessCode
				{
					get
					{
						return businessCode;
					}
					set	
					{
						businessCode = value;
					}
				}

				public long? ClusterId
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

				public string ClusterInstanceId
				{
					get
					{
						return clusterInstanceId;
					}
					set	
					{
						clusterInstanceId = value;
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

				public string EnvType
				{
					get
					{
						return envType;
					}
					set	
					{
						envType = value;
					}
				}

				public bool? HasInstallArmsPilot
				{
					get
					{
						return hasInstallArmsPilot;
					}
					set	
					{
						hasInstallArmsPilot = value;
					}
				}

				public bool? HasInstallLogController
				{
					get
					{
						return hasInstallLogController;
					}
					set	
					{
						hasInstallLogController = value;
					}
				}

				public bool? InstallArmsInProcess
				{
					get
					{
						return installArmsInProcess;
					}
					set	
					{
						installArmsInProcess = value;
					}
				}

				public bool? InstallLogInProcess
				{
					get
					{
						return installLogInProcess;
					}
					set	
					{
						installLogInProcess = value;
					}
				}

				public string MainUserId
				{
					get
					{
						return mainUserId;
					}
					set	
					{
						mainUserId = value;
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

				public string RegionName
				{
					get
					{
						return regionName;
					}
					set	
					{
						regionName = value;
					}
				}

				public string UserNick
				{
					get
					{
						return userNick;
					}
					set	
					{
						userNick = value;
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

				public List<string> EcsIds
				{
					get
					{
						return ecsIds;
					}
					set	
					{
						ecsIds = value;
					}
				}

				public List<string> Vswitchs
				{
					get
					{
						return vswitchs;
					}
					set	
					{
						vswitchs = value;
					}
				}
			}

			public class DescribeClusterDetail_InstanceInfo
			{

				private int? allocatePodCount;

				private int? appCount;

				private List<DescribeClusterDetail_AllocatedPodInstanceInfo> allocatedPodInfoList;

				private List<DescribeClusterDetail_AvailablePodInstanceInfo> availablePodInfoList;

				public int? AllocatePodCount
				{
					get
					{
						return allocatePodCount;
					}
					set	
					{
						allocatePodCount = value;
					}
				}

				public int? AppCount
				{
					get
					{
						return appCount;
					}
					set	
					{
						appCount = value;
					}
				}

				public List<DescribeClusterDetail_AllocatedPodInstanceInfo> AllocatedPodInfoList
				{
					get
					{
						return allocatedPodInfoList;
					}
					set	
					{
						allocatedPodInfoList = value;
					}
				}

				public List<DescribeClusterDetail_AvailablePodInstanceInfo> AvailablePodInfoList
				{
					get
					{
						return availablePodInfoList;
					}
					set	
					{
						availablePodInfoList = value;
					}
				}

				public class DescribeClusterDetail_AllocatedPodInstanceInfo
				{

					private long? appId;

					private string appName;

					private string cupRequest;

					private long? envId;

					private string envName;

					private string memRequest;

					private int? podCount;

					public long? AppId
					{
						get
						{
							return appId;
						}
						set	
						{
							appId = value;
						}
					}

					public string AppName
					{
						get
						{
							return appName;
						}
						set	
						{
							appName = value;
						}
					}

					public string CupRequest
					{
						get
						{
							return cupRequest;
						}
						set	
						{
							cupRequest = value;
						}
					}

					public long? EnvId
					{
						get
						{
							return envId;
						}
						set	
						{
							envId = value;
						}
					}

					public string EnvName
					{
						get
						{
							return envName;
						}
						set	
						{
							envName = value;
						}
					}

					public string MemRequest
					{
						get
						{
							return memRequest;
						}
						set	
						{
							memRequest = value;
						}
					}

					public int? PodCount
					{
						get
						{
							return podCount;
						}
						set	
						{
							podCount = value;
						}
					}
				}

				public class DescribeClusterDetail_AvailablePodInstanceInfo
				{

					private int? availablePodCount;

					private string cupRequest;

					private string memRequest;

					public int? AvailablePodCount
					{
						get
						{
							return availablePodCount;
						}
						set	
						{
							availablePodCount = value;
						}
					}

					public string CupRequest
					{
						get
						{
							return cupRequest;
						}
						set	
						{
							cupRequest = value;
						}
					}

					public string MemRequest
					{
						get
						{
							return memRequest;
						}
						set	
						{
							memRequest = value;
						}
					}
				}
			}

			public class DescribeClusterDetail_NetInfo
			{

				private string netPlugType;

				private string prodCIDR;

				private string serviceCIDR;

				public string NetPlugType
				{
					get
					{
						return netPlugType;
					}
					set	
					{
						netPlugType = value;
					}
				}

				public string ProdCIDR
				{
					get
					{
						return prodCIDR;
					}
					set	
					{
						prodCIDR = value;
					}
				}

				public string ServiceCIDR
				{
					get
					{
						return serviceCIDR;
					}
					set	
					{
						serviceCIDR = value;
					}
				}
			}

			public class DescribeClusterDetail_WorkLoad
			{

				private int? allNodeCount;

				private int? allocateAllPodCount;

				private int? allocateAppPodCount;

				private string cpuCapacityTotal;

				private string cpuLevel;

				private string cpuRequest;

				private string cpuRequestPercent;

				private string cpuTotal;

				private string cpuUse;

				private string cpuUsePercent;

				private string memCapacityTotal;

				private string memLevel;

				private string memRequest;

				private string memRequestPercent;

				private string memTotal;

				private string memUse;

				private string memUsePercent;

				public int? AllNodeCount
				{
					get
					{
						return allNodeCount;
					}
					set	
					{
						allNodeCount = value;
					}
				}

				public int? AllocateAllPodCount
				{
					get
					{
						return allocateAllPodCount;
					}
					set	
					{
						allocateAllPodCount = value;
					}
				}

				public int? AllocateAppPodCount
				{
					get
					{
						return allocateAppPodCount;
					}
					set	
					{
						allocateAppPodCount = value;
					}
				}

				public string CpuCapacityTotal
				{
					get
					{
						return cpuCapacityTotal;
					}
					set	
					{
						cpuCapacityTotal = value;
					}
				}

				public string CpuLevel
				{
					get
					{
						return cpuLevel;
					}
					set	
					{
						cpuLevel = value;
					}
				}

				public string CpuRequest
				{
					get
					{
						return cpuRequest;
					}
					set	
					{
						cpuRequest = value;
					}
				}

				public string CpuRequestPercent
				{
					get
					{
						return cpuRequestPercent;
					}
					set	
					{
						cpuRequestPercent = value;
					}
				}

				public string CpuTotal
				{
					get
					{
						return cpuTotal;
					}
					set	
					{
						cpuTotal = value;
					}
				}

				public string CpuUse
				{
					get
					{
						return cpuUse;
					}
					set	
					{
						cpuUse = value;
					}
				}

				public string CpuUsePercent
				{
					get
					{
						return cpuUsePercent;
					}
					set	
					{
						cpuUsePercent = value;
					}
				}

				public string MemCapacityTotal
				{
					get
					{
						return memCapacityTotal;
					}
					set	
					{
						memCapacityTotal = value;
					}
				}

				public string MemLevel
				{
					get
					{
						return memLevel;
					}
					set	
					{
						memLevel = value;
					}
				}

				public string MemRequest
				{
					get
					{
						return memRequest;
					}
					set	
					{
						memRequest = value;
					}
				}

				public string MemRequestPercent
				{
					get
					{
						return memRequestPercent;
					}
					set	
					{
						memRequestPercent = value;
					}
				}

				public string MemTotal
				{
					get
					{
						return memTotal;
					}
					set	
					{
						memTotal = value;
					}
				}

				public string MemUse
				{
					get
					{
						return memUse;
					}
					set	
					{
						memUse = value;
					}
				}

				public string MemUsePercent
				{
					get
					{
						return memUsePercent;
					}
					set	
					{
						memUsePercent = value;
					}
				}
			}
		}
	}
}
