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
	public class DescribeTenantResponse : AcsResponse
	{

		private string requestId;

		private DescribeTenant_Tenant tenant;

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

		[JsonProperty(PropertyName = "Tenant")]
		public DescribeTenant_Tenant Tenant
		{
			get
			{
				return tenant;
			}
			set	
			{
				tenant = value;
			}
		}

		public class DescribeTenant_Tenant
		{

			private string tenantId;

			private string tenantName;

			private string tenantMode;

			private string vpcId;

			private string status;

			private bool? enableInternetAddressService;

			private string primaryZone;

			private string deployType;

			private string deployMode;

			private string description;

			private string createTime;

			private string clogServiceStatus;

			private bool? enableClogService;

			private string charset;

			private string collation;

			private string primaryZoneDeployType;

			private string masterIntranetAddressZone;

			private string payType;

			private string instanceType;

			private string series;

			private string diskType;

			private bool? enableReadWriteSplit;

			private bool? enableParallelQuery;

			private long? maxParallelQueryDegree;

			private bool? enableBinlogService;

			private string timeZone;

			private string dataMergeTime;

			private List<DescribeTenant_TenantConnectionsItem> tenantConnections;

			private List<DescribeTenant_TenantZonesItem> tenantZones;

			private List<string> availableZones;

			private DescribeTenant_TenantResource tenantResource;

			private DescribeTenant_ReadOnlyResource readOnlyResource;

			[JsonProperty(PropertyName = "TenantId")]
			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			[JsonProperty(PropertyName = "TenantName")]
			public string TenantName
			{
				get
				{
					return tenantName;
				}
				set	
				{
					tenantName = value;
				}
			}

			[JsonProperty(PropertyName = "TenantMode")]
			public string TenantMode
			{
				get
				{
					return tenantMode;
				}
				set	
				{
					tenantMode = value;
				}
			}

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

			[JsonProperty(PropertyName = "EnableInternetAddressService")]
			public bool? EnableInternetAddressService
			{
				get
				{
					return enableInternetAddressService;
				}
				set	
				{
					enableInternetAddressService = value;
				}
			}

			[JsonProperty(PropertyName = "PrimaryZone")]
			public string PrimaryZone
			{
				get
				{
					return primaryZone;
				}
				set	
				{
					primaryZone = value;
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

			[JsonProperty(PropertyName = "Description")]
			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
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

			[JsonProperty(PropertyName = "ClogServiceStatus")]
			public string ClogServiceStatus
			{
				get
				{
					return clogServiceStatus;
				}
				set	
				{
					clogServiceStatus = value;
				}
			}

			[JsonProperty(PropertyName = "EnableClogService")]
			public bool? EnableClogService
			{
				get
				{
					return enableClogService;
				}
				set	
				{
					enableClogService = value;
				}
			}

			[JsonProperty(PropertyName = "Charset")]
			public string Charset
			{
				get
				{
					return charset;
				}
				set	
				{
					charset = value;
				}
			}

			[JsonProperty(PropertyName = "Collation")]
			public string Collation
			{
				get
				{
					return collation;
				}
				set	
				{
					collation = value;
				}
			}

			[JsonProperty(PropertyName = "PrimaryZoneDeployType")]
			public string PrimaryZoneDeployType
			{
				get
				{
					return primaryZoneDeployType;
				}
				set	
				{
					primaryZoneDeployType = value;
				}
			}

			[JsonProperty(PropertyName = "MasterIntranetAddressZone")]
			public string MasterIntranetAddressZone
			{
				get
				{
					return masterIntranetAddressZone;
				}
				set	
				{
					masterIntranetAddressZone = value;
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

			[JsonProperty(PropertyName = "EnableReadWriteSplit")]
			public bool? EnableReadWriteSplit
			{
				get
				{
					return enableReadWriteSplit;
				}
				set	
				{
					enableReadWriteSplit = value;
				}
			}

			[JsonProperty(PropertyName = "EnableParallelQuery")]
			public bool? EnableParallelQuery
			{
				get
				{
					return enableParallelQuery;
				}
				set	
				{
					enableParallelQuery = value;
				}
			}

			[JsonProperty(PropertyName = "MaxParallelQueryDegree")]
			public long? MaxParallelQueryDegree
			{
				get
				{
					return maxParallelQueryDegree;
				}
				set	
				{
					maxParallelQueryDegree = value;
				}
			}

			[JsonProperty(PropertyName = "EnableBinlogService")]
			public bool? EnableBinlogService
			{
				get
				{
					return enableBinlogService;
				}
				set	
				{
					enableBinlogService = value;
				}
			}

			[JsonProperty(PropertyName = "TimeZone")]
			public string TimeZone
			{
				get
				{
					return timeZone;
				}
				set	
				{
					timeZone = value;
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

			[JsonProperty(PropertyName = "TenantConnections")]
			public List<DescribeTenant_TenantConnectionsItem> TenantConnections
			{
				get
				{
					return tenantConnections;
				}
				set	
				{
					tenantConnections = value;
				}
			}

			[JsonProperty(PropertyName = "TenantZones")]
			public List<DescribeTenant_TenantZonesItem> TenantZones
			{
				get
				{
					return tenantZones;
				}
				set	
				{
					tenantZones = value;
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

			[JsonProperty(PropertyName = "TenantResource")]
			public DescribeTenant_TenantResource TenantResource
			{
				get
				{
					return tenantResource;
				}
				set	
				{
					tenantResource = value;
				}
			}

			[JsonProperty(PropertyName = "ReadOnlyResource")]
			public DescribeTenant_ReadOnlyResource ReadOnlyResource
			{
				get
				{
					return readOnlyResource;
				}
				set	
				{
					readOnlyResource = value;
				}
			}

			public class DescribeTenant_TenantConnectionsItem
			{

				private string intranetAddress;

				private int? intranetPort;

				private string internetAddress;

				private int? internetPort;

				private string vpcId;

				private string vSwitchId;

				private string intranetAddressMasterZoneId;

				private string intranetAddressSlaveZoneId;

				private string intranetAddressStatus;

				private string internetAddressStatus;

				private bool? transactionSplit;

				private string addressType;

				private bool? enableTransactionSplit;

				private long? parallelQueryDegree;

				private string tenantEndpointId;

				private long? maxConnectionNum;

				private string connectionReplicaType;

				private List<string> connectionZones;

				[JsonProperty(PropertyName = "IntranetAddress")]
				public string IntranetAddress
				{
					get
					{
						return intranetAddress;
					}
					set	
					{
						intranetAddress = value;
					}
				}

				[JsonProperty(PropertyName = "IntranetPort")]
				public int? IntranetPort
				{
					get
					{
						return intranetPort;
					}
					set	
					{
						intranetPort = value;
					}
				}

				[JsonProperty(PropertyName = "InternetAddress")]
				public string InternetAddress
				{
					get
					{
						return internetAddress;
					}
					set	
					{
						internetAddress = value;
					}
				}

				[JsonProperty(PropertyName = "InternetPort")]
				public int? InternetPort
				{
					get
					{
						return internetPort;
					}
					set	
					{
						internetPort = value;
					}
				}

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

				[JsonProperty(PropertyName = "VSwitchId")]
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

				[JsonProperty(PropertyName = "IntranetAddressMasterZoneId")]
				public string IntranetAddressMasterZoneId
				{
					get
					{
						return intranetAddressMasterZoneId;
					}
					set	
					{
						intranetAddressMasterZoneId = value;
					}
				}

				[JsonProperty(PropertyName = "IntranetAddressSlaveZoneId")]
				public string IntranetAddressSlaveZoneId
				{
					get
					{
						return intranetAddressSlaveZoneId;
					}
					set	
					{
						intranetAddressSlaveZoneId = value;
					}
				}

				[JsonProperty(PropertyName = "IntranetAddressStatus")]
				public string IntranetAddressStatus
				{
					get
					{
						return intranetAddressStatus;
					}
					set	
					{
						intranetAddressStatus = value;
					}
				}

				[JsonProperty(PropertyName = "InternetAddressStatus")]
				public string InternetAddressStatus
				{
					get
					{
						return internetAddressStatus;
					}
					set	
					{
						internetAddressStatus = value;
					}
				}

				[JsonProperty(PropertyName = "TransactionSplit")]
				public bool? TransactionSplit
				{
					get
					{
						return transactionSplit;
					}
					set	
					{
						transactionSplit = value;
					}
				}

				[JsonProperty(PropertyName = "AddressType")]
				public string AddressType
				{
					get
					{
						return addressType;
					}
					set	
					{
						addressType = value;
					}
				}

				[JsonProperty(PropertyName = "EnableTransactionSplit")]
				public bool? EnableTransactionSplit
				{
					get
					{
						return enableTransactionSplit;
					}
					set	
					{
						enableTransactionSplit = value;
					}
				}

				[JsonProperty(PropertyName = "ParallelQueryDegree")]
				public long? ParallelQueryDegree
				{
					get
					{
						return parallelQueryDegree;
					}
					set	
					{
						parallelQueryDegree = value;
					}
				}

				[JsonProperty(PropertyName = "TenantEndpointId")]
				public string TenantEndpointId
				{
					get
					{
						return tenantEndpointId;
					}
					set	
					{
						tenantEndpointId = value;
					}
				}

				[JsonProperty(PropertyName = "MaxConnectionNum")]
				public long? MaxConnectionNum
				{
					get
					{
						return maxConnectionNum;
					}
					set	
					{
						maxConnectionNum = value;
					}
				}

				[JsonProperty(PropertyName = "ConnectionReplicaType")]
				public string ConnectionReplicaType
				{
					get
					{
						return connectionReplicaType;
					}
					set	
					{
						connectionReplicaType = value;
					}
				}

				[JsonProperty(PropertyName = "ConnectionZones")]
				public List<string> ConnectionZones
				{
					get
					{
						return connectionZones;
					}
					set	
					{
						connectionZones = value;
					}
				}
			}

			public class DescribeTenant_TenantZonesItem
			{

				private string tenantZoneId;

				private string region;

				private string tenantZoneRole;

				private List<DescribeTenant_TenantZoneReplicasItem> tenantZoneReplicas;

				[JsonProperty(PropertyName = "TenantZoneId")]
				public string TenantZoneId
				{
					get
					{
						return tenantZoneId;
					}
					set	
					{
						tenantZoneId = value;
					}
				}

				[JsonProperty(PropertyName = "Region")]
				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				[JsonProperty(PropertyName = "TenantZoneRole")]
				public string TenantZoneRole
				{
					get
					{
						return tenantZoneRole;
					}
					set	
					{
						tenantZoneRole = value;
					}
				}

				[JsonProperty(PropertyName = "TenantZoneReplicas")]
				public List<DescribeTenant_TenantZoneReplicasItem> TenantZoneReplicas
				{
					get
					{
						return tenantZoneReplicas;
					}
					set	
					{
						tenantZoneReplicas = value;
					}
				}

				public class DescribeTenant_TenantZoneReplicasItem
				{

					private string zoneReplicaType;

					private string zoneNodes;

					private string logicZoneName;

					private int? zoneCopyId;

					private int? fullCopyId;

					private string readOnlyCopyId;

					[JsonProperty(PropertyName = "ZoneReplicaType")]
					public string ZoneReplicaType
					{
						get
						{
							return zoneReplicaType;
						}
						set	
						{
							zoneReplicaType = value;
						}
					}

					[JsonProperty(PropertyName = "ZoneNodes")]
					public string ZoneNodes
					{
						get
						{
							return zoneNodes;
						}
						set	
						{
							zoneNodes = value;
						}
					}

					[JsonProperty(PropertyName = "LogicZoneName")]
					public string LogicZoneName
					{
						get
						{
							return logicZoneName;
						}
						set	
						{
							logicZoneName = value;
						}
					}

					[JsonProperty(PropertyName = "ZoneCopyId")]
					public int? ZoneCopyId
					{
						get
						{
							return zoneCopyId;
						}
						set	
						{
							zoneCopyId = value;
						}
					}

					[JsonProperty(PropertyName = "FullCopyId")]
					public int? FullCopyId
					{
						get
						{
							return fullCopyId;
						}
						set	
						{
							fullCopyId = value;
						}
					}

					[JsonProperty(PropertyName = "ReadOnlyCopyId")]
					public string ReadOnlyCopyId
					{
						get
						{
							return readOnlyCopyId;
						}
						set	
						{
							readOnlyCopyId = value;
						}
					}
				}
			}

			public class DescribeTenant_TenantResource
			{

				private int? unitNum;

				private DescribeTenant_Cpu cpu;

				private DescribeTenant_Memory memory;

				private DescribeTenant_DiskSize diskSize;

				private DescribeTenant_CapacityUnit capacityUnit;

				private DescribeTenant_LogDiskSize logDiskSize;

				[JsonProperty(PropertyName = "UnitNum")]
				public int? UnitNum
				{
					get
					{
						return unitNum;
					}
					set	
					{
						unitNum = value;
					}
				}

				[JsonProperty(PropertyName = "Cpu")]
				public DescribeTenant_Cpu Cpu
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
				public DescribeTenant_Memory Memory
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
				public DescribeTenant_DiskSize DiskSize
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
				public DescribeTenant_CapacityUnit CapacityUnit
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

				[JsonProperty(PropertyName = "LogDiskSize")]
				public DescribeTenant_LogDiskSize LogDiskSize
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

				public class DescribeTenant_Cpu
				{

					private float? usedCpu;

					private float? totalCpu;

					private float? unitCpu;

					[JsonProperty(PropertyName = "UsedCpu")]
					public float? UsedCpu
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

					[JsonProperty(PropertyName = "TotalCpu")]
					public float? TotalCpu
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

					[JsonProperty(PropertyName = "UnitCpu")]
					public float? UnitCpu
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

				public class DescribeTenant_Memory
				{

					private float? usedMemory;

					private float? totalMemory;

					private float? unitMemory;

					[JsonProperty(PropertyName = "UsedMemory")]
					public float? UsedMemory
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

					[JsonProperty(PropertyName = "TotalMemory")]
					public float? TotalMemory
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

					[JsonProperty(PropertyName = "UnitMemory")]
					public float? UnitMemory
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

				public class DescribeTenant_DiskSize
				{

					private float? usedDiskSize;

					[JsonProperty(PropertyName = "UsedDiskSize")]
					public float? UsedDiskSize
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
				}

				public class DescribeTenant_CapacityUnit
				{

					private int? maxCapacityUnit;

					private int? minCapacityUnit;

					private int? usedCapacit;

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

					[JsonProperty(PropertyName = "UsedCapacit")]
					public int? UsedCapacit
					{
						get
						{
							return usedCapacit;
						}
						set	
						{
							usedCapacit = value;
						}
					}
				}

				public class DescribeTenant_LogDiskSize
				{

					private int? totalLogDisk;

					private int? unitLogDisk;

					[JsonProperty(PropertyName = "TotalLogDisk")]
					public int? TotalLogDisk
					{
						get
						{
							return totalLogDisk;
						}
						set	
						{
							totalLogDisk = value;
						}
					}

					[JsonProperty(PropertyName = "UnitLogDisk")]
					public int? UnitLogDisk
					{
						get
						{
							return unitLogDisk;
						}
						set	
						{
							unitLogDisk = value;
						}
					}
				}
			}

			public class DescribeTenant_ReadOnlyResource
			{

				private int? unitNum;

				private DescribeTenant_Cpu1 cpu1;

				private DescribeTenant_Memory2 memory2;

				private DescribeTenant_DiskSize3 diskSize3;

				private DescribeTenant_CapacityUnit4 capacityUnit4;

				private DescribeTenant_LogDiskSize5 logDiskSize5;

				[JsonProperty(PropertyName = "UnitNum")]
				public int? UnitNum
				{
					get
					{
						return unitNum;
					}
					set	
					{
						unitNum = value;
					}
				}

				[JsonProperty(PropertyName = "Cpu1")]
				public DescribeTenant_Cpu1 Cpu1
				{
					get
					{
						return cpu1;
					}
					set	
					{
						cpu1 = value;
					}
				}

				[JsonProperty(PropertyName = "Memory2")]
				public DescribeTenant_Memory2 Memory2
				{
					get
					{
						return memory2;
					}
					set	
					{
						memory2 = value;
					}
				}

				[JsonProperty(PropertyName = "DiskSize3")]
				public DescribeTenant_DiskSize3 DiskSize3
				{
					get
					{
						return diskSize3;
					}
					set	
					{
						diskSize3 = value;
					}
				}

				[JsonProperty(PropertyName = "CapacityUnit4")]
				public DescribeTenant_CapacityUnit4 CapacityUnit4
				{
					get
					{
						return capacityUnit4;
					}
					set	
					{
						capacityUnit4 = value;
					}
				}

				[JsonProperty(PropertyName = "LogDiskSize5")]
				public DescribeTenant_LogDiskSize5 LogDiskSize5
				{
					get
					{
						return logDiskSize5;
					}
					set	
					{
						logDiskSize5 = value;
					}
				}

				public class DescribeTenant_Cpu1
				{

					private float? usedCpu;

					private float? totalCpu;

					private float? unitCpu;

					[JsonProperty(PropertyName = "UsedCpu")]
					public float? UsedCpu
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

					[JsonProperty(PropertyName = "TotalCpu")]
					public float? TotalCpu
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

					[JsonProperty(PropertyName = "UnitCpu")]
					public float? UnitCpu
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

				public class DescribeTenant_Memory2
				{

					private float? usedMemory;

					private float? totalMemory;

					private float? unitMemory;

					[JsonProperty(PropertyName = "UsedMemory")]
					public float? UsedMemory
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

					[JsonProperty(PropertyName = "TotalMemory")]
					public float? TotalMemory
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

					[JsonProperty(PropertyName = "UnitMemory")]
					public float? UnitMemory
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

				public class DescribeTenant_DiskSize3
				{

					private float? usedDiskSize;

					[JsonProperty(PropertyName = "UsedDiskSize")]
					public float? UsedDiskSize
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
				}

				public class DescribeTenant_CapacityUnit4
				{

					private int? maxCapacityUnit;

					private int? minCapacityUnit;

					private int? usedCapacit;

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

					[JsonProperty(PropertyName = "UsedCapacit")]
					public int? UsedCapacit
					{
						get
						{
							return usedCapacit;
						}
						set	
						{
							usedCapacit = value;
						}
					}
				}

				public class DescribeTenant_LogDiskSize5
				{

					private int? totalLogDisk;

					private int? unitLogDisk;

					[JsonProperty(PropertyName = "TotalLogDisk")]
					public int? TotalLogDisk
					{
						get
						{
							return totalLogDisk;
						}
						set	
						{
							totalLogDisk = value;
						}
					}

					[JsonProperty(PropertyName = "UnitLogDisk")]
					public int? UnitLogDisk
					{
						get
						{
							return unitLogDisk;
						}
						set	
						{
							unitLogDisk = value;
						}
					}
				}
			}
		}
	}
}
