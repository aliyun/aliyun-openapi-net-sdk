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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class DescribeInstanceResponse : AcsResponse
	{

		private string requestId;

		private DescribeInstance_Instance instance;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Instance")]
		public DescribeInstance_Instance Instance
		{
			get
			{
				return instance;
			}
			set	
			{
				instance = value;
			}
		}

		public class DescribeInstance_Instance
		{

			private string instanceId;

			private string instanceName;

			private string instanceClass;

			private string series;

			private string payType;

			private string createTime;

			private string expireTime;

			private string version;

			private string deployType;

			private string deployMode;

			private string diskType;

			private string maintainTime;

			private string dataMergeTime;

			private bool? autoRenewal;

			private bool? isTrustEcs;

			private string status;

			private bool? autoUpgradeObVersion;

			private string obRpmVersion;

			private bool? isLatestObVersion;

			private bool? enableUpgradeLogDisk;

			private string instanceRole;

			private string nodeNum;

			private string replicaMode;

			private bool? isolationOptimization;

			private bool? enableIsolationOptimization;

			private bool? inTempCapacityStatus;

			private bool? dataDiskAutoScale;

			private bool? enableProxyService;

			private string proxyServiceStatus;

			private string proxyClusterId;

			private string cpuArchitecture;

			private List<string> availableZones;

			private List<string> zones;

			private DescribeInstance_Resource resource;

			private DescribeInstance_TenantCreatable tenantCreatable;

			private DescribeInstance_DataDiskAutoScaleConfig dataDiskAutoScaleConfig;

			[JsonProperty(PropertyName = "InstanceId")]
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

			[JsonProperty(PropertyName = "InstanceName")]
			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceClass")]
			public string InstanceClass
			{
				get
				{
					return instanceClass;
				}
				set	
				{
					instanceClass = value;
				}
			}

			[JsonProperty(PropertyName = "Series")]
			public string Series
			{
				get
				{
					return series;
				}
				set	
				{
					series = value;
				}
			}

			[JsonProperty(PropertyName = "PayType")]
			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			[JsonProperty(PropertyName = "CreateTime")]
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

			[JsonProperty(PropertyName = "ExpireTime")]
			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			[JsonProperty(PropertyName = "Version")]
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

			[JsonProperty(PropertyName = "DeployType")]
			public string DeployType
			{
				get
				{
					return deployType;
				}
				set	
				{
					deployType = value;
				}
			}

			[JsonProperty(PropertyName = "DeployMode")]
			public string DeployMode
			{
				get
				{
					return deployMode;
				}
				set	
				{
					deployMode = value;
				}
			}

			[JsonProperty(PropertyName = "DiskType")]
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

			[JsonProperty(PropertyName = "MaintainTime")]
			public string MaintainTime
			{
				get
				{
					return maintainTime;
				}
				set	
				{
					maintainTime = value;
				}
			}

			[JsonProperty(PropertyName = "DataMergeTime")]
			public string DataMergeTime
			{
				get
				{
					return dataMergeTime;
				}
				set	
				{
					dataMergeTime = value;
				}
			}

			[JsonProperty(PropertyName = "AutoRenewal")]
			public bool? AutoRenewal
			{
				get
				{
					return autoRenewal;
				}
				set	
				{
					autoRenewal = value;
				}
			}

			[JsonProperty(PropertyName = "IsTrustEcs")]
			public bool? IsTrustEcs
			{
				get
				{
					return isTrustEcs;
				}
				set	
				{
					isTrustEcs = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "AutoUpgradeObVersion")]
			public bool? AutoUpgradeObVersion
			{
				get
				{
					return autoUpgradeObVersion;
				}
				set	
				{
					autoUpgradeObVersion = value;
				}
			}

			[JsonProperty(PropertyName = "ObRpmVersion")]
			public string ObRpmVersion
			{
				get
				{
					return obRpmVersion;
				}
				set	
				{
					obRpmVersion = value;
				}
			}

			[JsonProperty(PropertyName = "IsLatestObVersion")]
			public bool? IsLatestObVersion
			{
				get
				{
					return isLatestObVersion;
				}
				set	
				{
					isLatestObVersion = value;
				}
			}

			[JsonProperty(PropertyName = "EnableUpgradeLogDisk")]
			public bool? EnableUpgradeLogDisk
			{
				get
				{
					return enableUpgradeLogDisk;
				}
				set	
				{
					enableUpgradeLogDisk = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceRole")]
			public string InstanceRole
			{
				get
				{
					return instanceRole;
				}
				set	
				{
					instanceRole = value;
				}
			}

			[JsonProperty(PropertyName = "NodeNum")]
			public string NodeNum
			{
				get
				{
					return nodeNum;
				}
				set	
				{
					nodeNum = value;
				}
			}

			[JsonProperty(PropertyName = "ReplicaMode")]
			public string ReplicaMode
			{
				get
				{
					return replicaMode;
				}
				set	
				{
					replicaMode = value;
				}
			}

			[JsonProperty(PropertyName = "IsolationOptimization")]
			public bool? IsolationOptimization
			{
				get
				{
					return isolationOptimization;
				}
				set	
				{
					isolationOptimization = value;
				}
			}

			[JsonProperty(PropertyName = "EnableIsolationOptimization")]
			public bool? EnableIsolationOptimization
			{
				get
				{
					return enableIsolationOptimization;
				}
				set	
				{
					enableIsolationOptimization = value;
				}
			}

			[JsonProperty(PropertyName = "InTempCapacityStatus")]
			public bool? InTempCapacityStatus
			{
				get
				{
					return inTempCapacityStatus;
				}
				set	
				{
					inTempCapacityStatus = value;
				}
			}

			[JsonProperty(PropertyName = "DataDiskAutoScale")]
			public bool? DataDiskAutoScale
			{
				get
				{
					return dataDiskAutoScale;
				}
				set	
				{
					dataDiskAutoScale = value;
				}
			}

			[JsonProperty(PropertyName = "EnableProxyService")]
			public bool? EnableProxyService
			{
				get
				{
					return enableProxyService;
				}
				set	
				{
					enableProxyService = value;
				}
			}

			[JsonProperty(PropertyName = "ProxyServiceStatus")]
			public string ProxyServiceStatus
			{
				get
				{
					return proxyServiceStatus;
				}
				set	
				{
					proxyServiceStatus = value;
				}
			}

			[JsonProperty(PropertyName = "ProxyClusterId")]
			public string ProxyClusterId
			{
				get
				{
					return proxyClusterId;
				}
				set	
				{
					proxyClusterId = value;
				}
			}

			[JsonProperty(PropertyName = "CpuArchitecture")]
			public string CpuArchitecture
			{
				get
				{
					return cpuArchitecture;
				}
				set	
				{
					cpuArchitecture = value;
				}
			}

			[JsonProperty(PropertyName = "AvailableZones")]
			public List<string> AvailableZones
			{
				get
				{
					return availableZones;
				}
				set	
				{
					availableZones = value;
				}
			}

			[JsonProperty(PropertyName = "Zones")]
			public List<string> Zones
			{
				get
				{
					return zones;
				}
				set	
				{
					zones = value;
				}
			}

			[JsonProperty(PropertyName = "Resource")]
			public DescribeInstance_Resource Resource
			{
				get
				{
					return resource;
				}
				set	
				{
					resource = value;
				}
			}

			[JsonProperty(PropertyName = "TenantCreatable")]
			public DescribeInstance_TenantCreatable TenantCreatable
			{
				get
				{
					return tenantCreatable;
				}
				set	
				{
					tenantCreatable = value;
				}
			}

			[JsonProperty(PropertyName = "DataDiskAutoScaleConfig")]
			public DescribeInstance_DataDiskAutoScaleConfig DataDiskAutoScaleConfig
			{
				get
				{
					return dataDiskAutoScaleConfig;
				}
				set	
				{
					dataDiskAutoScaleConfig = value;
				}
			}

			public class DescribeInstance_Resource
			{

				private long? unitCount;

				private DescribeInstance_Cpu cpu;

				private DescribeInstance_Memory memory;

				private DescribeInstance_DiskSize diskSize;

				private DescribeInstance_LogDiskSize logDiskSize;

				private DescribeInstance_CapacityUnit capacityUnit;

				[JsonProperty(PropertyName = "UnitCount")]
				public long? UnitCount
				{
					get
					{
						return unitCount;
					}
					set	
					{
						unitCount = value;
					}
				}

				[JsonProperty(PropertyName = "Cpu")]
				public DescribeInstance_Cpu Cpu
				{
					get
					{
						return cpu;
					}
					set	
					{
						cpu = value;
					}
				}

				[JsonProperty(PropertyName = "Memory")]
				public DescribeInstance_Memory Memory
				{
					get
					{
						return memory;
					}
					set	
					{
						memory = value;
					}
				}

				[JsonProperty(PropertyName = "DiskSize")]
				public DescribeInstance_DiskSize DiskSize
				{
					get
					{
						return diskSize;
					}
					set	
					{
						diskSize = value;
					}
				}

				[JsonProperty(PropertyName = "LogDiskSize")]
				public DescribeInstance_LogDiskSize LogDiskSize
				{
					get
					{
						return logDiskSize;
					}
					set	
					{
						logDiskSize = value;
					}
				}

				[JsonProperty(PropertyName = "CapacityUnit")]
				public DescribeInstance_CapacityUnit CapacityUnit
				{
					get
					{
						return capacityUnit;
					}
					set	
					{
						capacityUnit = value;
					}
				}

				public class DescribeInstance_Cpu
				{

					private long? totalCpu;

					private long? usedCpu;

					private long? unitCpu;

					private long? originalTotalCpu;

					[JsonProperty(PropertyName = "TotalCpu")]
					public long? TotalCpu
					{
						get
						{
							return totalCpu;
						}
						set	
						{
							totalCpu = value;
						}
					}

					[JsonProperty(PropertyName = "UsedCpu")]
					public long? UsedCpu
					{
						get
						{
							return usedCpu;
						}
						set	
						{
							usedCpu = value;
						}
					}

					[JsonProperty(PropertyName = "UnitCpu")]
					public long? UnitCpu
					{
						get
						{
							return unitCpu;
						}
						set	
						{
							unitCpu = value;
						}
					}

					[JsonProperty(PropertyName = "OriginalTotalCpu")]
					public long? OriginalTotalCpu
					{
						get
						{
							return originalTotalCpu;
						}
						set	
						{
							originalTotalCpu = value;
						}
					}
				}

				public class DescribeInstance_Memory
				{

					private long? totalMemory;

					private long? usedMemory;

					private long? unitMemory;

					private long? originalTotalMemory;

					[JsonProperty(PropertyName = "TotalMemory")]
					public long? TotalMemory
					{
						get
						{
							return totalMemory;
						}
						set	
						{
							totalMemory = value;
						}
					}

					[JsonProperty(PropertyName = "UsedMemory")]
					public long? UsedMemory
					{
						get
						{
							return usedMemory;
						}
						set	
						{
							usedMemory = value;
						}
					}

					[JsonProperty(PropertyName = "UnitMemory")]
					public long? UnitMemory
					{
						get
						{
							return unitMemory;
						}
						set	
						{
							unitMemory = value;
						}
					}

					[JsonProperty(PropertyName = "OriginalTotalMemory")]
					public long? OriginalTotalMemory
					{
						get
						{
							return originalTotalMemory;
						}
						set	
						{
							originalTotalMemory = value;
						}
					}
				}

				public class DescribeInstance_DiskSize
				{

					private long? totalDiskSize;

					private long? usedDiskSize;

					private long? unitDiskSize;

					private double? dataUsedSize;

					private double? maxDiskUsedPercent;

					private long? originalTotalDiskSize;

					private double? maxDiskSize;

					private List<string> maxDiskUsedObServer;

					[JsonProperty(PropertyName = "TotalDiskSize")]
					public long? TotalDiskSize
					{
						get
						{
							return totalDiskSize;
						}
						set	
						{
							totalDiskSize = value;
						}
					}

					[JsonProperty(PropertyName = "UsedDiskSize")]
					public long? UsedDiskSize
					{
						get
						{
							return usedDiskSize;
						}
						set	
						{
							usedDiskSize = value;
						}
					}

					[JsonProperty(PropertyName = "UnitDiskSize")]
					public long? UnitDiskSize
					{
						get
						{
							return unitDiskSize;
						}
						set	
						{
							unitDiskSize = value;
						}
					}

					[JsonProperty(PropertyName = "DataUsedSize")]
					public double? DataUsedSize
					{
						get
						{
							return dataUsedSize;
						}
						set	
						{
							dataUsedSize = value;
						}
					}

					[JsonProperty(PropertyName = "MaxDiskUsedPercent")]
					public double? MaxDiskUsedPercent
					{
						get
						{
							return maxDiskUsedPercent;
						}
						set	
						{
							maxDiskUsedPercent = value;
						}
					}

					[JsonProperty(PropertyName = "OriginalTotalDiskSize")]
					public long? OriginalTotalDiskSize
					{
						get
						{
							return originalTotalDiskSize;
						}
						set	
						{
							originalTotalDiskSize = value;
						}
					}

					[JsonProperty(PropertyName = "MaxDiskSize")]
					public double? MaxDiskSize
					{
						get
						{
							return maxDiskSize;
						}
						set	
						{
							maxDiskSize = value;
						}
					}

					[JsonProperty(PropertyName = "MaxDiskUsedObServer")]
					public List<string> MaxDiskUsedObServer
					{
						get
						{
							return maxDiskUsedObServer;
						}
						set	
						{
							maxDiskUsedObServer = value;
						}
					}
				}

				public class DescribeInstance_LogDiskSize
				{

					private long? totalDiskSize;

					private long? unitDiskSize;

					private string logAssignedSize;

					private string maxLogAssignedPercent;

					private List<string> maxLogAssignedObServer;

					[JsonProperty(PropertyName = "TotalDiskSize")]
					public long? TotalDiskSize
					{
						get
						{
							return totalDiskSize;
						}
						set	
						{
							totalDiskSize = value;
						}
					}

					[JsonProperty(PropertyName = "UnitDiskSize")]
					public long? UnitDiskSize
					{
						get
						{
							return unitDiskSize;
						}
						set	
						{
							unitDiskSize = value;
						}
					}

					[JsonProperty(PropertyName = "LogAssignedSize")]
					public string LogAssignedSize
					{
						get
						{
							return logAssignedSize;
						}
						set	
						{
							logAssignedSize = value;
						}
					}

					[JsonProperty(PropertyName = "MaxLogAssignedPercent")]
					public string MaxLogAssignedPercent
					{
						get
						{
							return maxLogAssignedPercent;
						}
						set	
						{
							maxLogAssignedPercent = value;
						}
					}

					[JsonProperty(PropertyName = "MaxLogAssignedObServer")]
					public List<string> MaxLogAssignedObServer
					{
						get
						{
							return maxLogAssignedObServer;
						}
						set	
						{
							maxLogAssignedObServer = value;
						}
					}
				}

				public class DescribeInstance_CapacityUnit
				{

					private int? maxCapacityUnit;

					private int? minCapacityUnit;

					private string usedCapacityUnit;

					[JsonProperty(PropertyName = "MaxCapacityUnit")]
					public int? MaxCapacityUnit
					{
						get
						{
							return maxCapacityUnit;
						}
						set	
						{
							maxCapacityUnit = value;
						}
					}

					[JsonProperty(PropertyName = "MinCapacityUnit")]
					public int? MinCapacityUnit
					{
						get
						{
							return minCapacityUnit;
						}
						set	
						{
							minCapacityUnit = value;
						}
					}

					[JsonProperty(PropertyName = "UsedCapacityUnit")]
					public string UsedCapacityUnit
					{
						get
						{
							return usedCapacityUnit;
						}
						set	
						{
							usedCapacityUnit = value;
						}
					}
				}
			}

			public class DescribeInstance_TenantCreatable
			{

				private bool? enableCreateTenant;

				private string disableCreateTenantReason;

				[JsonProperty(PropertyName = "EnableCreateTenant")]
				public bool? EnableCreateTenant
				{
					get
					{
						return enableCreateTenant;
					}
					set	
					{
						enableCreateTenant = value;
					}
				}

				[JsonProperty(PropertyName = "DisableCreateTenantReason")]
				public string DisableCreateTenantReason
				{
					get
					{
						return disableCreateTenantReason;
					}
					set	
					{
						disableCreateTenantReason = value;
					}
				}
			}

			public class DescribeInstance_DataDiskAutoScaleConfig
			{

				private bool? autoScale;

				private long? upperbound;

				private long? upperThreshold;

				private long? upperMergeThreshold;

				private long? maxDiskSize;

				private long? scaleStepInNormal;

				private long? scaleStepInMerge;

				[JsonProperty(PropertyName = "AutoScale")]
				public bool? AutoScale
				{
					get
					{
						return autoScale;
					}
					set	
					{
						autoScale = value;
					}
				}

				[JsonProperty(PropertyName = "Upperbound")]
				public long? Upperbound
				{
					get
					{
						return upperbound;
					}
					set	
					{
						upperbound = value;
					}
				}

				[JsonProperty(PropertyName = "UpperThreshold")]
				public long? UpperThreshold
				{
					get
					{
						return upperThreshold;
					}
					set	
					{
						upperThreshold = value;
					}
				}

				[JsonProperty(PropertyName = "UpperMergeThreshold")]
				public long? UpperMergeThreshold
				{
					get
					{
						return upperMergeThreshold;
					}
					set	
					{
						upperMergeThreshold = value;
					}
				}

				[JsonProperty(PropertyName = "MaxDiskSize")]
				public long? MaxDiskSize
				{
					get
					{
						return maxDiskSize;
					}
					set	
					{
						maxDiskSize = value;
					}
				}

				[JsonProperty(PropertyName = "ScaleStepInNormal")]
				public long? ScaleStepInNormal
				{
					get
					{
						return scaleStepInNormal;
					}
					set	
					{
						scaleStepInNormal = value;
					}
				}

				[JsonProperty(PropertyName = "ScaleStepInMerge")]
				public long? ScaleStepInMerge
				{
					get
					{
						return scaleStepInMerge;
					}
					set	
					{
						scaleStepInMerge = value;
					}
				}
			}
		}
	}
}
