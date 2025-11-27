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
	public class DescribeDrdsInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? total;

		private List<DescribeDrdsInstances_Instance> instances;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<DescribeDrdsInstances_Instance> Instances
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

		public class DescribeDrdsInstances_Instance
		{

			private string vpcId;

			private string status;

			private string type;

			private string commodityCode;

			private string machineType;

			private long? createTime;

			private string versionAction;

			private string instanceSeries;

			private string networkType;

			private string label;

			private string productVersion;

			private string instanceSpec;

			private string regionId;

			private string vpcCloudInstanceId;

			private string description;

			private long? version;

			private string resourceGroupId;

			private string zoneId;

			private string drdsInstanceId;

			private long? expireDate;

			private string masterInstanceId;

			private string orderInstanceId;

			private string instRole;

			private string series;

			private List<DescribeDrdsInstances_Vip> vips;

			private List<string> readOnlyDBInstanceIds;

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

			public List<DescribeDrdsInstances_Vip> Vips
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

			public class DescribeDrdsInstances_Vip
			{

				private string vpcId;

				private string type;

				private string vswitchId;

				private string port;

				private string iP;

				private string dns;

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

				public string IP
				{
					get
					{
						return iP;
					}
					set	
					{
						iP = value;
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
			}
		}
	}
}
