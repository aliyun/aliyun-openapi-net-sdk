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

			private List<string> availableZones;

			private List<string> securityIps;

			private DescribeInstances_Resource resource;

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

			[JsonProperty(PropertyName = "SecurityIps")]
			public List<string> SecurityIps
			{
				get
				{
					return securityIps;
				}
				set	
				{
					securityIps = value;
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

			public class DescribeInstances_Resource
			{

				private long? unitCount;

				private DescribeInstances_Cpu cpu;

				private DescribeInstances_Memory memory;

				private DescribeInstances_DiskSize diskSize;

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

				public class DescribeInstances_Cpu
				{

					private long? totalCpu;

					private long? usedCpu;

					private long? unitCpu;

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
				}

				public class DescribeInstances_Memory
				{

					private long? totalMemory;

					private long? usedMemory;

					private long? unitMemory;

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
				}

				public class DescribeInstances_DiskSize
				{

					private long? totalDiskSize;

					private long? usedDiskSize;

					private long? unitDiskSize;

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
				}
			}
		}
	}
}
