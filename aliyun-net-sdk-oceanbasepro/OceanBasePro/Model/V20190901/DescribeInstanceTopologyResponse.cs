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
	public class DescribeInstanceTopologyResponse : AcsResponse
	{

		private string requestId;

		private DescribeInstanceTopology_InstanceTopology instanceTopology;

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

		[JsonProperty(PropertyName = "InstanceTopology")]
		public DescribeInstanceTopology_InstanceTopology InstanceTopology
		{
			get
			{
				return instanceTopology;
			}
			set	
			{
				instanceTopology = value;
			}
		}

		public class DescribeInstanceTopology_InstanceTopology
		{

			private List<DescribeInstanceTopology_TenantsItem> tenants;

			private List<DescribeInstanceTopology_ZonesItem> zones;

			[JsonProperty(PropertyName = "Tenants")]
			public List<DescribeInstanceTopology_TenantsItem> Tenants
			{
				get
				{
					return tenants;
				}
				set	
				{
					tenants = value;
				}
			}

			[JsonProperty(PropertyName = "Zones")]
			public List<DescribeInstanceTopology_ZonesItem> Zones
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

			public class DescribeInstanceTopology_TenantsItem
			{

				private string tenantId;

				private string tenantName;

				private float? tenantCpu;

				private float? tenantMemory;

				private string tenantMode;

				private string tenantStatus;

				private string tenantDeployType;

				private int? tenantUnitNum;

				private string primaryZoneDeployType;

				private List<DescribeInstanceTopology_TenantZonesItem> tenantZones;

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

				[JsonProperty(PropertyName = "TenantCpu")]
				public float? TenantCpu
				{
					get
					{
						return tenantCpu;
					}
					set	
					{
						tenantCpu = value;
					}
				}

				[JsonProperty(PropertyName = "TenantMemory")]
				public float? TenantMemory
				{
					get
					{
						return tenantMemory;
					}
					set	
					{
						tenantMemory = value;
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

				[JsonProperty(PropertyName = "TenantStatus")]
				public string TenantStatus
				{
					get
					{
						return tenantStatus;
					}
					set	
					{
						tenantStatus = value;
					}
				}

				[JsonProperty(PropertyName = "TenantDeployType")]
				public string TenantDeployType
				{
					get
					{
						return tenantDeployType;
					}
					set	
					{
						tenantDeployType = value;
					}
				}

				[JsonProperty(PropertyName = "TenantUnitNum")]
				public int? TenantUnitNum
				{
					get
					{
						return tenantUnitNum;
					}
					set	
					{
						tenantUnitNum = value;
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

				[JsonProperty(PropertyName = "TenantZones")]
				public List<DescribeInstanceTopology_TenantZonesItem> TenantZones
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

				public class DescribeInstanceTopology_TenantZonesItem
				{

					private string tenantZoneRole;

					private string isPrimaryTenantZone;

					private string tenantZoneId;

					private List<DescribeInstanceTopology_UnitsItem> units;

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

					[JsonProperty(PropertyName = "IsPrimaryTenantZone")]
					public string IsPrimaryTenantZone
					{
						get
						{
							return isPrimaryTenantZone;
						}
						set	
						{
							isPrimaryTenantZone = value;
						}
					}

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

					[JsonProperty(PropertyName = "Units")]
					public List<DescribeInstanceTopology_UnitsItem> Units
					{
						get
						{
							return units;
						}
						set	
						{
							units = value;
						}
					}

					public class DescribeInstanceTopology_UnitsItem
					{

						private string unitId;

						private string unitStatus;

						private string nodeId;

						private float? unitCpu;

						private float? unitMemory;

						private bool? enableMigrateUnit;

						private bool? manualMigrate;

						private bool? enableCancelMigrateUnit;

						private long? unitDataSize;

						[JsonProperty(PropertyName = "UnitId")]
						public string UnitId
						{
							get
							{
								return unitId;
							}
							set	
							{
								unitId = value;
							}
						}

						[JsonProperty(PropertyName = "UnitStatus")]
						public string UnitStatus
						{
							get
							{
								return unitStatus;
							}
							set	
							{
								unitStatus = value;
							}
						}

						[JsonProperty(PropertyName = "NodeId")]
						public string NodeId
						{
							get
							{
								return nodeId;
							}
							set	
							{
								nodeId = value;
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

						[JsonProperty(PropertyName = "EnableMigrateUnit")]
						public bool? EnableMigrateUnit
						{
							get
							{
								return enableMigrateUnit;
							}
							set	
							{
								enableMigrateUnit = value;
							}
						}

						[JsonProperty(PropertyName = "ManualMigrate")]
						public bool? ManualMigrate
						{
							get
							{
								return manualMigrate;
							}
							set	
							{
								manualMigrate = value;
							}
						}

						[JsonProperty(PropertyName = "EnableCancelMigrateUnit")]
						public bool? EnableCancelMigrateUnit
						{
							get
							{
								return enableCancelMigrateUnit;
							}
							set	
							{
								enableCancelMigrateUnit = value;
							}
						}

						[JsonProperty(PropertyName = "UnitDataSize")]
						public long? UnitDataSize
						{
							get
							{
								return unitDataSize;
							}
							set	
							{
								unitDataSize = value;
							}
						}
					}
				}
			}

			public class DescribeInstanceTopology_ZonesItem
			{

				private string zoneId;

				private string region;

				private string zoneDisk;

				private List<DescribeInstanceTopology_NodesItem> nodes;

				private DescribeInstanceTopology_ZoneResource zoneResource;

				[JsonProperty(PropertyName = "ZoneId")]
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

				[JsonProperty(PropertyName = "ZoneDisk")]
				public string ZoneDisk
				{
					get
					{
						return zoneDisk;
					}
					set	
					{
						zoneDisk = value;
					}
				}

				[JsonProperty(PropertyName = "Nodes")]
				public List<DescribeInstanceTopology_NodesItem> Nodes
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

				[JsonProperty(PropertyName = "ZoneResource")]
				public DescribeInstanceTopology_ZoneResource ZoneResource
				{
					get
					{
						return zoneResource;
					}
					set	
					{
						zoneResource = value;
					}
				}

				public class DescribeInstanceTopology_NodesItem
				{

					private string nodeId;

					private long? nodeCopyId;

					private string nodeStatus;

					private List<DescribeInstanceTopology_NodeResourceItem> nodeResource;

					[JsonProperty(PropertyName = "NodeId")]
					public string NodeId
					{
						get
						{
							return nodeId;
						}
						set	
						{
							nodeId = value;
						}
					}

					[JsonProperty(PropertyName = "NodeCopyId")]
					public long? NodeCopyId
					{
						get
						{
							return nodeCopyId;
						}
						set	
						{
							nodeCopyId = value;
						}
					}

					[JsonProperty(PropertyName = "NodeStatus")]
					public string NodeStatus
					{
						get
						{
							return nodeStatus;
						}
						set	
						{
							nodeStatus = value;
						}
					}

					[JsonProperty(PropertyName = "NodeResource")]
					public List<DescribeInstanceTopology_NodeResourceItem> NodeResource
					{
						get
						{
							return nodeResource;
						}
						set	
						{
							nodeResource = value;
						}
					}

					public class DescribeInstanceTopology_NodeResourceItem
					{

						private DescribeInstanceTopology_Cpu cpu;

						private DescribeInstanceTopology_Memory memory;

						private DescribeInstanceTopology_DiskSize diskSize;

						[JsonProperty(PropertyName = "Cpu")]
						public DescribeInstanceTopology_Cpu Cpu
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
						public DescribeInstanceTopology_Memory Memory
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
						public DescribeInstanceTopology_DiskSize DiskSize
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

						public class DescribeInstanceTopology_Cpu
						{

							private float? usedCpu;

							private int? totalCpu;

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
							public int? TotalCpu
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
						}

						public class DescribeInstanceTopology_Memory
						{

							private float? usedMemory;

							private long? totalMemory;

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
						}

						public class DescribeInstanceTopology_DiskSize
						{

							private double? totalDiskSize;

							private double? usedDiskSize;

							[JsonProperty(PropertyName = "TotalDiskSize")]
							public double? TotalDiskSize
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
							public double? UsedDiskSize
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
					}
				}

				public class DescribeInstanceTopology_ZoneResource
				{

					private DescribeInstanceTopology_DiskSize1 diskSize1;

					[JsonProperty(PropertyName = "DiskSize1")]
					public DescribeInstanceTopology_DiskSize1 DiskSize1
					{
						get
						{
							return diskSize1;
						}
						set	
						{
							diskSize1 = value;
						}
					}

					public class DescribeInstanceTopology_DiskSize1
					{

						private double? maxDiskUsedPercent;

						private List<string> maxDiskUsedObServer;

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
				}
			}
		}
	}
}
