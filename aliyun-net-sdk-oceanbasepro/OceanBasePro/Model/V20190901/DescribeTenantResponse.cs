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

			private List<DescribeTenant_TenantConnectionsItem> tenantConnections;

			private List<DescribeTenant_TenantZonesItem> tenantZones;

			private DescribeTenant_TenantResource tenantResource;

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

			public class DescribeTenant_TenantConnectionsItem
			{

				private string connectionRole;

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

				private List<string> connectionZones;

				[JsonProperty(PropertyName = "ConnectionRole")]
				public string ConnectionRole
				{
					get
					{
						return connectionRole;
					}
					set	
					{
						connectionRole = value;
					}
				}

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
			}

			public class DescribeTenant_TenantResource
			{

				private int? unitNum;

				private DescribeTenant_Cpu cpu;

				private DescribeTenant_Memory memory;

				private DescribeTenant_DiskSize diskSize;

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
			}
		}
	}
}
