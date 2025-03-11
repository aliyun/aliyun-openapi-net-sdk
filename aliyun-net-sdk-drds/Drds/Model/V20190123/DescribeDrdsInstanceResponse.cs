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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeDrdsInstanceResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private DescribeDrdsInstance_Data data;

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

			private string type;

			private string status;

			private long? createTime;

			private string versionAction;

			private string storageType;

			private string networkType;

			private string label;

			private int? mysqlVersion;

			private string instanceSpec;

			private string vpcCloudInstanceId;

			private string description;

			private long? version;

			private long? expireDate;

			private string masterInstanceId;

			private string commodityCode;

			private string machineType;

			private string instanceSeries;

			private string productVersion;

			private string regionId;

			private string resourceGroupId;

			private string drdsInstanceId;

			private string zoneId;

			private string instRole;

			private string orderInstanceId;

			private List<DescribeDrdsInstance_Vip> vips;

			private List<string> readOnlyDBInstanceIds;

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

				private string type;

				private string vpcId;

				private string vswitchId;

				private string dns;

				private string port;

				private long? expireDays;

				private bool? removeWeight;

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

				public bool? RemoveWeight
				{
					get
					{
						return removeWeight;
					}
					set	
					{
						removeWeight = value;
					}
				}
			}
		}
	}
}
