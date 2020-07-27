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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstanceAttributeResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDBInstanceAttribute_DBInstanceAttribute> items;

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

		public List<DescribeDBInstanceAttribute_DBInstanceAttribute> Items
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

		public class DescribeDBInstanceAttribute_DBInstanceAttribute
		{

			private string iPType;

			private string dBInstanceDiskUsed;

			private string guardDBInstanceName;

			private bool? canTempUpgrade;

			private string tempUpgradeTimeStart;

			private string tempUpgradeTimeEnd;

			private string tempUpgradeRecoveryTime;

			private string tempUpgradeRecoveryClass;

			private int? tempUpgradeRecoveryCpu;

			private int? tempUpgradeRecoveryMemory;

			private string tempUpgradeRecoveryMaxIOPS;

			private string tempUpgradeRecoveryMaxConnections;

			private int? insId;

			private string dBInstanceId;

			private string payType;

			private string dBInstanceClassType;

			private string dBInstanceType;

			private string regionId;

			private string connectionString;

			private string port;

			private string engine;

			private string engineVersion;

			private string dBInstanceClass;

			private long? dBInstanceMemory;

			private int? dBInstanceStorage;

			private string vpcCloudInstanceId;

			private string dBInstanceNetType;

			private string dBInstanceStatus;

			private string dBInstanceDescription;

			private string lockMode;

			private string lockReason;

			private string readDelayTime;

			private int? dBMaxQuantity;

			private int? accountMaxQuantity;

			private string creationTime;

			private string expireTime;

			private string maintainTime;

			private string availabilityValue;

			private int? maxIOPS;

			private int? maxConnections;

			private string masterInstanceId;

			private string dBInstanceCPU;

			private string incrementSourceDBInstanceId;

			private string guardDBInstanceId;

			private string replicateId;

			private string tempDBInstanceId;

			private string securityIPList;

			private string zoneId;

			private string instanceNetworkType;

			private string dBInstanceStorageType;

			private string advancedFeatures;

			private string category;

			private string accountType;

			private string supportUpgradeAccountType;

			private string supportCreateSuperAccount;

			private string vpcId;

			private string vSwitchId;

			private string connectionMode;

			private string currentKernelVersion;

			private string latestKernelVersion;

			private string resourceGroupId;

			private string readonlyInstanceSQLDelayedTime;

			private string securityIPMode;

			private string timeZone;

			private string collation;

			private string dispenseMode;

			private string masterZone;

			private string autoUpgradeMinorVersion;

			private int? proxyType;

			private string consoleVersion;

			private bool? multipleTempUpgrade;

			private string originConfiguration;

			private string dedicatedHostGroupId;

			private string superPermissionMode;

			private List<DescribeDBInstanceAttribute_SlaveZone> slaveZones;

			private List<DescribeDBInstanceAttribute_ReadOnlyDBInstanceId> readOnlyDBInstanceIds;

			private DescribeDBInstanceAttribute_Extra extra;

			public string IPType
			{
				get
				{
					return iPType;
				}
				set	
				{
					iPType = value;
				}
			}

			public string DBInstanceDiskUsed
			{
				get
				{
					return dBInstanceDiskUsed;
				}
				set	
				{
					dBInstanceDiskUsed = value;
				}
			}

			public string GuardDBInstanceName
			{
				get
				{
					return guardDBInstanceName;
				}
				set	
				{
					guardDBInstanceName = value;
				}
			}

			public bool? CanTempUpgrade
			{
				get
				{
					return canTempUpgrade;
				}
				set	
				{
					canTempUpgrade = value;
				}
			}

			public string TempUpgradeTimeStart
			{
				get
				{
					return tempUpgradeTimeStart;
				}
				set	
				{
					tempUpgradeTimeStart = value;
				}
			}

			public string TempUpgradeTimeEnd
			{
				get
				{
					return tempUpgradeTimeEnd;
				}
				set	
				{
					tempUpgradeTimeEnd = value;
				}
			}

			public string TempUpgradeRecoveryTime
			{
				get
				{
					return tempUpgradeRecoveryTime;
				}
				set	
				{
					tempUpgradeRecoveryTime = value;
				}
			}

			public string TempUpgradeRecoveryClass
			{
				get
				{
					return tempUpgradeRecoveryClass;
				}
				set	
				{
					tempUpgradeRecoveryClass = value;
				}
			}

			public int? TempUpgradeRecoveryCpu
			{
				get
				{
					return tempUpgradeRecoveryCpu;
				}
				set	
				{
					tempUpgradeRecoveryCpu = value;
				}
			}

			public int? TempUpgradeRecoveryMemory
			{
				get
				{
					return tempUpgradeRecoveryMemory;
				}
				set	
				{
					tempUpgradeRecoveryMemory = value;
				}
			}

			public string TempUpgradeRecoveryMaxIOPS
			{
				get
				{
					return tempUpgradeRecoveryMaxIOPS;
				}
				set	
				{
					tempUpgradeRecoveryMaxIOPS = value;
				}
			}

			public string TempUpgradeRecoveryMaxConnections
			{
				get
				{
					return tempUpgradeRecoveryMaxConnections;
				}
				set	
				{
					tempUpgradeRecoveryMaxConnections = value;
				}
			}

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

			public string AdvancedFeatures
			{
				get
				{
					return advancedFeatures;
				}
				set	
				{
					advancedFeatures = value;
				}
			}

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

			public string SupportCreateSuperAccount
			{
				get
				{
					return supportCreateSuperAccount;
				}
				set	
				{
					supportCreateSuperAccount = value;
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

			public string CurrentKernelVersion
			{
				get
				{
					return currentKernelVersion;
				}
				set	
				{
					currentKernelVersion = value;
				}
			}

			public string LatestKernelVersion
			{
				get
				{
					return latestKernelVersion;
				}
				set	
				{
					latestKernelVersion = value;
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

			public string ReadonlyInstanceSQLDelayedTime
			{
				get
				{
					return readonlyInstanceSQLDelayedTime;
				}
				set	
				{
					readonlyInstanceSQLDelayedTime = value;
				}
			}

			public string SecurityIPMode
			{
				get
				{
					return securityIPMode;
				}
				set	
				{
					securityIPMode = value;
				}
			}

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

			public string DispenseMode
			{
				get
				{
					return dispenseMode;
				}
				set	
				{
					dispenseMode = value;
				}
			}

			public string MasterZone
			{
				get
				{
					return masterZone;
				}
				set	
				{
					masterZone = value;
				}
			}

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

			public int? ProxyType
			{
				get
				{
					return proxyType;
				}
				set	
				{
					proxyType = value;
				}
			}

			public string ConsoleVersion
			{
				get
				{
					return consoleVersion;
				}
				set	
				{
					consoleVersion = value;
				}
			}

			public bool? MultipleTempUpgrade
			{
				get
				{
					return multipleTempUpgrade;
				}
				set	
				{
					multipleTempUpgrade = value;
				}
			}

			public string OriginConfiguration
			{
				get
				{
					return originConfiguration;
				}
				set	
				{
					originConfiguration = value;
				}
			}

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

			public string SuperPermissionMode
			{
				get
				{
					return superPermissionMode;
				}
				set	
				{
					superPermissionMode = value;
				}
			}

			public List<DescribeDBInstanceAttribute_SlaveZone> SlaveZones
			{
				get
				{
					return slaveZones;
				}
				set	
				{
					slaveZones = value;
				}
			}

			public List<DescribeDBInstanceAttribute_ReadOnlyDBInstanceId> ReadOnlyDBInstanceIds
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

			public DescribeDBInstanceAttribute_Extra Extra
			{
				get
				{
					return extra;
				}
				set	
				{
					extra = value;
				}
			}

			public class DescribeDBInstanceAttribute_SlaveZone
			{

				private string zoneId;

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
			}

			public class DescribeDBInstanceAttribute_ReadOnlyDBInstanceId
			{

				private string dBInstanceId;

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

			public class DescribeDBInstanceAttribute_Extra
			{

				private string replicaGroupID;

				private string replicaGroupStatus;

				private string activeReplicaDBInstanceID;

				private List<string> dBInstanceIds;

				public string ReplicaGroupID
				{
					get
					{
						return replicaGroupID;
					}
					set	
					{
						replicaGroupID = value;
					}
				}

				public string ReplicaGroupStatus
				{
					get
					{
						return replicaGroupStatus;
					}
					set	
					{
						replicaGroupStatus = value;
					}
				}

				public string ActiveReplicaDBInstanceID
				{
					get
					{
						return activeReplicaDBInstanceID;
					}
					set	
					{
						activeReplicaDBInstanceID = value;
					}
				}

				public List<string> DBInstanceIds
				{
					get
					{
						return dBInstanceIds;
					}
					set	
					{
						dBInstanceIds = value;
					}
				}
			}
		}
	}
}
