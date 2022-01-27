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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeDrdsInstanceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private DescribeDrdsInstance_Data data;

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

		public DescribeDrdsInstance_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeDrdsInstance_Data
		{

			private string drdsInstanceId;

			private string type;

			private string regionId;

			private string zoneId;

			private string description;

			private string networkType;

			private string status;

			private long? createTime;

			private long? version;

			private string instanceSeries;

			private string instanceSpec;

			private string vpcCloudInstanceId;

			private string instRole;

			private string commodityCode;

			private long? expireDate;

			private string versionAction;

			private string label;

			private string masterInstanceId;

			private string machineType;

			private string orderInstanceId;

			private int? mysqlVersion;

			private string storageType;

			private string resourceGroupId;

			private string productVersion;

			private List<DescribeDrdsInstance_Vip> vips;

			private List<string> readOnlyDBInstanceIds;

			public string DrdsInstanceId
			{
				get
				{
					return drdsInstanceId;
				}
				set	
				{
					drdsInstanceId = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
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

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
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

			public long? CreateTime
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

			public long? Version
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

			public string InstanceSeries
			{
				get
				{
					return instanceSeries;
				}
				set	
				{
					instanceSeries = value;
				}
			}

			public string InstanceSpec
			{
				get
				{
					return instanceSpec;
				}
				set	
				{
					instanceSpec = value;
				}
			}

			public string VpcCloudInstanceId
			{
				get
				{
					return vpcCloudInstanceId;
				}
				set	
				{
					vpcCloudInstanceId = value;
				}
			}

			public string InstRole
			{
				get
				{
					return instRole;
				}
				set	
				{
					instRole = value;
				}
			}

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

			public long? ExpireDate
			{
				get
				{
					return expireDate;
				}
				set	
				{
					expireDate = value;
				}
			}

			public string VersionAction
			{
				get
				{
					return versionAction;
				}
				set	
				{
					versionAction = value;
				}
			}

			public string Label
			{
				get
				{
					return label;
				}
				set	
				{
					label = value;
				}
			}

			public string MasterInstanceId
			{
				get
				{
					return masterInstanceId;
				}
				set	
				{
					masterInstanceId = value;
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

			public string OrderInstanceId
			{
				get
				{
					return orderInstanceId;
				}
				set	
				{
					orderInstanceId = value;
				}
			}

			public int? MysqlVersion
			{
				get
				{
					return mysqlVersion;
				}
				set	
				{
					mysqlVersion = value;
				}
			}

			public string StorageType
			{
				get
				{
					return storageType;
				}
				set	
				{
					storageType = value;
				}
			}

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

			public string ProductVersion
			{
				get
				{
					return productVersion;
				}
				set	
				{
					productVersion = value;
				}
			}

			public List<DescribeDrdsInstance_Vip> Vips
			{
				get
				{
					return vips;
				}
				set	
				{
					vips = value;
				}
			}

			public List<string> ReadOnlyDBInstanceIds
			{
				get
				{
					return readOnlyDBInstanceIds;
				}
				set	
				{
					readOnlyDBInstanceIds = value;
				}
			}

			public class DescribeDrdsInstance_Vip
			{

				private string dns;

				private long? expireDays;

				private string port;

				private string type;

				private string vpcId;

				private string vswitchId;

				public string Dns
				{
					get
					{
						return dns;
					}
					set	
					{
						dns = value;
					}
				}

				public long? ExpireDays
				{
					get
					{
						return expireDays;
					}
					set	
					{
						expireDays = value;
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

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
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

				public string VswitchId
				{
					get
					{
						return vswitchId;
					}
					set	
					{
						vswitchId = value;
					}
				}
			}
		}
	}
}
