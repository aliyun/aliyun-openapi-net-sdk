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

			private List<string> availableZones;

			private DescribeInstance_Resource resource;

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

			public class DescribeInstance_Resource
			{

				private long? unitCount;

				private DescribeInstance_Cpu cpu;

				private DescribeInstance_Memory memory;

				private DescribeInstance_DiskSize diskSize;

				private DescribeInstance_LogDiskSize logDiskSize;

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

				public class DescribeInstance_Cpu
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

				public class DescribeInstance_Memory
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

				public class DescribeInstance_DiskSize
				{

					private long? totalDiskSize;

					private long? usedDiskSize;

					private long? unitDiskSize;

					private double? dataUsedSize;

					private double? maxDiskUsedPercent;

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
				}
			}
		}
	}
}
