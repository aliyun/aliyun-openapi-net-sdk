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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstancesAsCsvResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDBInstancesAsCsv_DBInstanceAttribute> items;

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

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeDBInstancesAsCsv_DBInstanceAttribute> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeDBInstancesAsCsv_DBInstanceAttribute
		{

			private string vpcId;

			private string creationTime;

			private string tempDBInstanceId;

			private string supportUpgradeAccountType;

			private string incrementSourceDBInstanceId;

			private long? dBInstanceMemory;

			private string maintainTime;

			private string payType;

			private string tags;

			private string availabilityValue;

			private string readDelayTime;

			private string connectionMode;

			private string port;

			private string accountType;

			private string lockMode;

			private string engineVersion;

			private int? maxIOPS;

			private string connectionString;

			private string instanceNetworkType;

			private string securityIPList;

			private string masterInstanceId;

			private string dBInstanceClassType;

			private string dBInstanceDescription;

			private string dBInstanceCPU;

			private string expireTime;

			private string dBInstanceNetType;

			private string dBInstanceType;

			private int? accountMaxQuantity;

			private string lockReason;

			private string dBInstanceStatus;

			private int? dBMaxQuantity;

			private string guardDBInstanceId;

			private string regionId;

			private int? dBInstanceStorage;

			private string vSwitchId;

			private string zoneId;

			private string category;

			private int? maxConnections;

			private string dBInstanceId;

			private string dBInstanceClass;

			private string engine;

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

			[JsonProperty(PropertyName = "CreationTime")]
			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			[JsonProperty(PropertyName = "TempDBInstanceId")]
			public string TempDBInstanceId
			{
				get
				{
					return tempDBInstanceId;
				}
				set	
				{
					tempDBInstanceId = value;
				}
			}

			[JsonProperty(PropertyName = "SupportUpgradeAccountType")]
			public string SupportUpgradeAccountType
			{
				get
				{
					return supportUpgradeAccountType;
				}
				set	
				{
					supportUpgradeAccountType = value;
				}
			}

			[JsonProperty(PropertyName = "IncrementSourceDBInstanceId")]
			public string IncrementSourceDBInstanceId
			{
				get
				{
					return incrementSourceDBInstanceId;
				}
				set	
				{
					incrementSourceDBInstanceId = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceMemory")]
			public long? DBInstanceMemory
			{
				get
				{
					return dBInstanceMemory;
				}
				set	
				{
					dBInstanceMemory = value;
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

			[JsonProperty(PropertyName = "Tags")]
			public string Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			[JsonProperty(PropertyName = "AvailabilityValue")]
			public string AvailabilityValue
			{
				get
				{
					return availabilityValue;
				}
				set	
				{
					availabilityValue = value;
				}
			}

			[JsonProperty(PropertyName = "ReadDelayTime")]
			public string ReadDelayTime
			{
				get
				{
					return readDelayTime;
				}
				set	
				{
					readDelayTime = value;
				}
			}

			[JsonProperty(PropertyName = "ConnectionMode")]
			public string ConnectionMode
			{
				get
				{
					return connectionMode;
				}
				set	
				{
					connectionMode = value;
				}
			}

			[JsonProperty(PropertyName = "Port")]
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

			[JsonProperty(PropertyName = "AccountType")]
			public string AccountType
			{
				get
				{
					return accountType;
				}
				set	
				{
					accountType = value;
				}
			}

			[JsonProperty(PropertyName = "LockMode")]
			public string LockMode
			{
				get
				{
					return lockMode;
				}
				set	
				{
					lockMode = value;
				}
			}

			[JsonProperty(PropertyName = "EngineVersion")]
			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
				}
			}

			[JsonProperty(PropertyName = "MaxIOPS")]
			public int? MaxIOPS
			{
				get
				{
					return maxIOPS;
				}
				set	
				{
					maxIOPS = value;
				}
			}

			[JsonProperty(PropertyName = "ConnectionString")]
			public string ConnectionString
			{
				get
				{
					return connectionString;
				}
				set	
				{
					connectionString = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceNetworkType")]
			public string InstanceNetworkType
			{
				get
				{
					return instanceNetworkType;
				}
				set	
				{
					instanceNetworkType = value;
				}
			}

			[JsonProperty(PropertyName = "SecurityIPList")]
			public string SecurityIPList
			{
				get
				{
					return securityIPList;
				}
				set	
				{
					securityIPList = value;
				}
			}

			[JsonProperty(PropertyName = "MasterInstanceId")]
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

			[JsonProperty(PropertyName = "DBInstanceClassType")]
			public string DBInstanceClassType
			{
				get
				{
					return dBInstanceClassType;
				}
				set	
				{
					dBInstanceClassType = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceDescription")]
			public string DBInstanceDescription
			{
				get
				{
					return dBInstanceDescription;
				}
				set	
				{
					dBInstanceDescription = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceCPU")]
			public string DBInstanceCPU
			{
				get
				{
					return dBInstanceCPU;
				}
				set	
				{
					dBInstanceCPU = value;
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

			[JsonProperty(PropertyName = "DBInstanceNetType")]
			public string DBInstanceNetType
			{
				get
				{
					return dBInstanceNetType;
				}
				set	
				{
					dBInstanceNetType = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceType")]
			public string DBInstanceType
			{
				get
				{
					return dBInstanceType;
				}
				set	
				{
					dBInstanceType = value;
				}
			}

			[JsonProperty(PropertyName = "AccountMaxQuantity")]
			public int? AccountMaxQuantity
			{
				get
				{
					return accountMaxQuantity;
				}
				set	
				{
					accountMaxQuantity = value;
				}
			}

			[JsonProperty(PropertyName = "LockReason")]
			public string LockReason
			{
				get
				{
					return lockReason;
				}
				set	
				{
					lockReason = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceStatus")]
			public string DBInstanceStatus
			{
				get
				{
					return dBInstanceStatus;
				}
				set	
				{
					dBInstanceStatus = value;
				}
			}

			[JsonProperty(PropertyName = "DBMaxQuantity")]
			public int? DBMaxQuantity
			{
				get
				{
					return dBMaxQuantity;
				}
				set	
				{
					dBMaxQuantity = value;
				}
			}

			[JsonProperty(PropertyName = "GuardDBInstanceId")]
			public string GuardDBInstanceId
			{
				get
				{
					return guardDBInstanceId;
				}
				set	
				{
					guardDBInstanceId = value;
				}
			}

			[JsonProperty(PropertyName = "RegionId")]
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

			[JsonProperty(PropertyName = "DBInstanceStorage")]
			public int? DBInstanceStorage
			{
				get
				{
					return dBInstanceStorage;
				}
				set	
				{
					dBInstanceStorage = value;
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

			[JsonProperty(PropertyName = "Category")]
			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			[JsonProperty(PropertyName = "MaxConnections")]
			public int? MaxConnections
			{
				get
				{
					return maxConnections;
				}
				set	
				{
					maxConnections = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceId")]
			public string DBInstanceId
			{
				get
				{
					return dBInstanceId;
				}
				set	
				{
					dBInstanceId = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceClass")]
			public string DBInstanceClass
			{
				get
				{
					return dBInstanceClass;
				}
				set	
				{
					dBInstanceClass = value;
				}
			}

			[JsonProperty(PropertyName = "Engine")]
			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
				}
			}
		}
	}
}
