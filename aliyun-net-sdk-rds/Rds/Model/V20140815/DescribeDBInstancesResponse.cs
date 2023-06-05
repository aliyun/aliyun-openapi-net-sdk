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
	public class DescribeDBInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageRecordCount;

		private int? totalRecordCount;

		private string nextToken;

		private List<DescribeDBInstances_DBInstance> items;

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

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "PageRecordCount")]
		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		[JsonProperty(PropertyName = "TotalRecordCount")]
		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		[JsonProperty(PropertyName = "NextToken")]
		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeDBInstances_DBInstance> Items
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

		public class DescribeDBInstances_DBInstance
		{

			private string vpcId;

			private string dedicatedHostIdForLog;

			private string createTime;

			private string payType;

			private string dedicatedHostNameForLog;

			private bool? mutriORsignle;

			private string dedicatedHostGroupName;

			private string engineVersion;

			private string dedicatedHostGroupId;

			private string vpcName;

			private string dedicatedHostZoneIdForMaster;

			private int? insId;

			private string connectionString;

			private string instanceNetworkType;

			private string masterInstanceId;

			private string autoUpgradeMinorVersion;

			private string expireTime;

			private string destroyTime;

			private string guardDBInstanceId;

			private string dedicatedHostNameForMaster;

			private string zoneId;

			private int? tipsLevel;

			private string dBInstanceId;

			private string dedicatedHostIdForMaster;

			private string replicateId;

			private string tempDBInstanceId;

			private string dBInstanceStorageType;

			private string connectionMode;

			private string lockMode;

			private string generalGroupName;

			private string vpcCloudInstanceId;

			private string dedicatedHostZoneIdForSlave;

			private string tips;

			private string dedicatedHostZoneIdForLog;

			private string dedicatedHostNameForSlave;

			private string dBInstanceDescription;

			private string dBInstanceNetType;

			private string dBInstanceType;

			private string lockReason;

			private string dBInstanceStatus;

			private string regionId;

			private string vSwitchId;

			private string dedicatedHostIdForSlave;

			private string resourceGroupId;

			private string category;

			private string engine;

			private string dBInstanceClass;

			private int? switchWeight;

			private bool? deletionProtection;

			private bool? burstingEnabled;

			private string bpeEnabled;

			private List<DescribeDBInstances_ReadOnlyDBInstanceId> readOnlyDBInstanceIds;

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

			[JsonProperty(PropertyName = "DedicatedHostIdForLog")]
			public string DedicatedHostIdForLog
			{
				get
				{
					return dedicatedHostIdForLog;
				}
				set	
				{
					dedicatedHostIdForLog = value;
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

			[JsonProperty(PropertyName = "DedicatedHostNameForLog")]
			public string DedicatedHostNameForLog
			{
				get
				{
					return dedicatedHostNameForLog;
				}
				set	
				{
					dedicatedHostNameForLog = value;
				}
			}

			[JsonProperty(PropertyName = "MutriORsignle")]
			public bool? MutriORsignle
			{
				get
				{
					return mutriORsignle;
				}
				set	
				{
					mutriORsignle = value;
				}
			}

			[JsonProperty(PropertyName = "DedicatedHostGroupName")]
			public string DedicatedHostGroupName
			{
				get
				{
					return dedicatedHostGroupName;
				}
				set	
				{
					dedicatedHostGroupName = value;
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

			[JsonProperty(PropertyName = "DedicatedHostGroupId")]
			public string DedicatedHostGroupId
			{
				get
				{
					return dedicatedHostGroupId;
				}
				set	
				{
					dedicatedHostGroupId = value;
				}
			}

			[JsonProperty(PropertyName = "VpcName")]
			public string VpcName
			{
				get
				{
					return vpcName;
				}
				set	
				{
					vpcName = value;
				}
			}

			[JsonProperty(PropertyName = "DedicatedHostZoneIdForMaster")]
			public string DedicatedHostZoneIdForMaster
			{
				get
				{
					return dedicatedHostZoneIdForMaster;
				}
				set	
				{
					dedicatedHostZoneIdForMaster = value;
				}
			}

			[JsonProperty(PropertyName = "InsId")]
			public int? InsId
			{
				get
				{
					return insId;
				}
				set	
				{
					insId = value;
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

			[JsonProperty(PropertyName = "AutoUpgradeMinorVersion")]
			public string AutoUpgradeMinorVersion
			{
				get
				{
					return autoUpgradeMinorVersion;
				}
				set	
				{
					autoUpgradeMinorVersion = value;
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

			[JsonProperty(PropertyName = "DestroyTime")]
			public string DestroyTime
			{
				get
				{
					return destroyTime;
				}
				set	
				{
					destroyTime = value;
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

			[JsonProperty(PropertyName = "DedicatedHostNameForMaster")]
			public string DedicatedHostNameForMaster
			{
				get
				{
					return dedicatedHostNameForMaster;
				}
				set	
				{
					dedicatedHostNameForMaster = value;
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

			[JsonProperty(PropertyName = "TipsLevel")]
			public int? TipsLevel
			{
				get
				{
					return tipsLevel;
				}
				set	
				{
					tipsLevel = value;
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

			[JsonProperty(PropertyName = "DedicatedHostIdForMaster")]
			public string DedicatedHostIdForMaster
			{
				get
				{
					return dedicatedHostIdForMaster;
				}
				set	
				{
					dedicatedHostIdForMaster = value;
				}
			}

			[JsonProperty(PropertyName = "ReplicateId")]
			public string ReplicateId
			{
				get
				{
					return replicateId;
				}
				set	
				{
					replicateId = value;
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

			[JsonProperty(PropertyName = "DBInstanceStorageType")]
			public string DBInstanceStorageType
			{
				get
				{
					return dBInstanceStorageType;
				}
				set	
				{
					dBInstanceStorageType = value;
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

			[JsonProperty(PropertyName = "GeneralGroupName")]
			public string GeneralGroupName
			{
				get
				{
					return generalGroupName;
				}
				set	
				{
					generalGroupName = value;
				}
			}

			[JsonProperty(PropertyName = "VpcCloudInstanceId")]
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

			[JsonProperty(PropertyName = "DedicatedHostZoneIdForSlave")]
			public string DedicatedHostZoneIdForSlave
			{
				get
				{
					return dedicatedHostZoneIdForSlave;
				}
				set	
				{
					dedicatedHostZoneIdForSlave = value;
				}
			}

			[JsonProperty(PropertyName = "Tips")]
			public string Tips
			{
				get
				{
					return tips;
				}
				set	
				{
					tips = value;
				}
			}

			[JsonProperty(PropertyName = "DedicatedHostZoneIdForLog")]
			public string DedicatedHostZoneIdForLog
			{
				get
				{
					return dedicatedHostZoneIdForLog;
				}
				set	
				{
					dedicatedHostZoneIdForLog = value;
				}
			}

			[JsonProperty(PropertyName = "DedicatedHostNameForSlave")]
			public string DedicatedHostNameForSlave
			{
				get
				{
					return dedicatedHostNameForSlave;
				}
				set	
				{
					dedicatedHostNameForSlave = value;
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

			[JsonProperty(PropertyName = "DedicatedHostIdForSlave")]
			public string DedicatedHostIdForSlave
			{
				get
				{
					return dedicatedHostIdForSlave;
				}
				set	
				{
					dedicatedHostIdForSlave = value;
				}
			}

			[JsonProperty(PropertyName = "ResourceGroupId")]
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

			[JsonProperty(PropertyName = "SwitchWeight")]
			public int? SwitchWeight
			{
				get
				{
					return switchWeight;
				}
				set	
				{
					switchWeight = value;
				}
			}

			[JsonProperty(PropertyName = "DeletionProtection")]
			public bool? DeletionProtection
			{
				get
				{
					return deletionProtection;
				}
				set	
				{
					deletionProtection = value;
				}
			}

			[JsonProperty(PropertyName = "BurstingEnabled")]
			public bool? BurstingEnabled
			{
				get
				{
					return burstingEnabled;
				}
				set	
				{
					burstingEnabled = value;
				}
			}

			[JsonProperty(PropertyName = "BpeEnabled")]
			public string BpeEnabled
			{
				get
				{
					return bpeEnabled;
				}
				set	
				{
					bpeEnabled = value;
				}
			}

			[JsonProperty(PropertyName = "ReadOnlyDBInstanceIds")]
			public List<DescribeDBInstances_ReadOnlyDBInstanceId> ReadOnlyDBInstanceIds
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

			public class DescribeDBInstances_ReadOnlyDBInstanceId
			{

				private string dBInstanceId;

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
			}
		}
	}
}
