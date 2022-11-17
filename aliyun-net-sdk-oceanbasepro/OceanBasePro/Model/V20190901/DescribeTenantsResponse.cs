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
	public class DescribeTenantsResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private List<DescribeTenants_Data> tenants;

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

		[JsonProperty(PropertyName = "Tenants")]
		public List<DescribeTenants_Data> Tenants
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

		public class DescribeTenants_Data
		{

			private string vpcId;

			private string status;

			private string primaryZone;

			private string deployType;

			private string deployMode;

			private string createTime;

			private string tenantName;

			private int? mem;

			private int? cpu;

			private string description;

			private string tenantMode;

			private string tenantId;

			private int? unitCpu;

			private int? unitMem;

			private int? unitNum;

			private double? usedDiskSize;

			private string charset;

			private string collation;

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

			[JsonProperty(PropertyName = "Mem")]
			public int? Mem
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

			[JsonProperty(PropertyName = "UnitCpu")]
			public int? UnitCpu
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

			[JsonProperty(PropertyName = "UnitMem")]
			public int? UnitMem
			{
				get
				{
					return unitMem;
				}
				set	
				{
					unitMem = value;
				}
			}

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
		}
	}
}
