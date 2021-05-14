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

			private string drdsInstanceId;

			private string type;

			private string regionId;

			private string zoneId;

			private string description;

			private string networkType;

			private string status;

			private long? createTime;

			private long? version;

			private string commodityCode;

			private string instRole;

			private string instanceSeries;

			private string instanceSpec;

			private string masterInstanceId;

			private string vpcCloudInstanceId;

			private string vpcId;

			private long? expireDate;

			private string versionAction;

			private string label;

			private string machineType;

			private string orderInstanceId;

			private string resourceGroupId;

			private string productVersion;

			private List<DescribeDrdsInstances_Vip> vips;

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

				private string iP;

				private string port;

				private string type;

				private string vpcId;

				private string vswitchId;

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
