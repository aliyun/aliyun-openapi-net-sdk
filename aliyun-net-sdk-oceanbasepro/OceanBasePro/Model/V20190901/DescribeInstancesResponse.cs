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
	public class DescribeInstancesResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private List<DescribeInstances_Data> instances;

		[JsonProperty(PropertyName = "TotalCount")]
		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

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

		[JsonProperty(PropertyName = "Instances")]
		public List<DescribeInstances_Data> Instances
		{
			get
			{
				return instances;
			}
			set	
			{
				instances = value;
			}
		}

		public class DescribeInstances_Data
		{

			private string vpcId;

			private string commodityCode;

			private string expireTime;

			private string state;

			private string instanceClass;

			private string createTime;

			private string deployMode;

			private string cpuArchitecture;

			private string maintainTime;

			private string deployType;

			private string payType;

			private string diskSize;

			private string diskType;

			private string instanceId;

			private int? expireSeconds;

			private long? mem;

			private bool? enableUpgradeNodes;

			private int? cpu;

			private string version;

			private string instanceName;

			private string series;

			private long? usedDiskSize;

			private string resourceGroupId;

			private string instanceType;

			private string instanceRole;

			private bool? inTempCapacityStatus;

			private List<string> availableZones;

			private DescribeInstances_Resource resource;

			private DescribeInstances_DataDiskAutoScaleConfig dataDiskAutoScaleConfig;

			[JsonProperty(PropertyName = "VpcId")]
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

			[JsonProperty(PropertyName = "CommodityCode")]
			public string CommodityCode
			{
				get
				{
					return commodityCode;
				}
				set	
				{
					commodityCode = value;
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

			[JsonProperty(PropertyName = "State")]
			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
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

			[JsonProperty(PropertyName = "DiskSize")]
			public string DiskSize
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

			[JsonProperty(PropertyName = "ExpireSeconds")]
			public int? ExpireSeconds
			{
				get
				{
					return expireSeconds;
				}
				set	
				{
					expireSeconds = value;
				}
			}

			[JsonProperty(PropertyName = "Mem")]
			public long? Mem
			{
				get
				{
					return mem;
				}
				set	
				{
					mem = value;
				}
			}

			[JsonProperty(PropertyName = "EnableUpgradeNodes")]
			public bool? EnableUpgradeNodes
			{
				get
				{
					return enableUpgradeNodes;
				}
				set	
				{
					enableUpgradeNodes = value;
				}
			}

			[JsonProperty(PropertyName = "Cpu")]
			public int? Cpu
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

			[JsonProperty(PropertyName = "ResourceGroupId")]
			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceType")]
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

			[JsonProperty(PropertyName = "Resource")]
			public DescribeInstances_Resource Resource
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

			[JsonProperty(PropertyName = "DataDiskAutoScaleConfig")]
			public DescribeInstances_DataDiskAutoScaleConfig DataDiskAutoScaleConfig
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

			public class DescribeInstances_Resource
			{

				private long? unitCount;

				private DescribeInstances_Cpu cpu;

				private DescribeInstances_Memory memory;

				private DescribeInstances_DiskSize diskSize;

				private DescribeInstances_CapacityUnit capacityUnit;

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
				public DescribeInstances_Cpu Cpu
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
				public DescribeInstances_Memory Memory
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
				public DescribeInstances_DiskSize DiskSize
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

				[JsonProperty(PropertyName = "CapacityUnit")]
				public DescribeInstances_CapacityUnit CapacityUnit
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

				public class DescribeInstances_Cpu
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

				public class DescribeInstances_Memory
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

				public class DescribeInstances_DiskSize
				{

					private long? totalDiskSize;

					private long? usedDiskSize;

					private long? unitDiskSize;

					private long? originalTotalDiskSize;

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
				}

				public class DescribeInstances_CapacityUnit
				{

					private int? maxCapacityUnit;

					private int? minCapacityUnit;

					private int? usedCapacityUnit;

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
					public int? UsedCapacityUnit
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

			public class DescribeInstances_DataDiskAutoScaleConfig
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
