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
	public class DescribeDBInstanceAttributeResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDBInstanceAttribute_DBInstanceAttribute> items;

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

			private string vpcId;

			private string creationTime;

			private string incrementSourceDBInstanceId;

			private string maintainTime;

			private string payType;

			private string availabilityValue;

			private string accountType;

			private string engineVersion;

			private string dedicatedHostGroupId;

			private int? insId;

			private string connectionString;

			private string superPermissionMode;

			private string instanceNetworkType;

			private string masterInstanceId;

			private string tempUpgradeRecoveryMaxConnections;

			private string autoUpgradeMinorVersion;

			private bool? multipleTempUpgrade;

			private string expireTime;

			private int? accountMaxQuantity;

			private string supportCreateSuperAccount;

			private string masterZone;

			private string guardDBInstanceId;

			private int? dBInstanceStorage;

			private string timeZone;

			private bool? canTempUpgrade;

			private string latestKernelVersion;

			private int? tipsLevel;

			private string zoneId;

			private int? maxConnections;

			private string dBInstanceId;

			private string tempUpgradeRecoveryTime;

			private string dispenseMode;

			private int? tempUpgradeRecoveryMemory;

			private string replicateId;

			private string tempDBInstanceId;

			private string supportUpgradeAccountType;

			private string advancedFeatures;

			private string dBInstanceStorageType;

			private long? dBInstanceMemory;

			private string iPType;

			private string readDelayTime;

			private string consoleVersion;

			private string connectionMode;

			private string port;

			private string lockMode;

			private string generalGroupName;

			private string originConfiguration;

			private string vpcCloudInstanceId;

			private string collation;

			private int? maxIOPS;

			private int? maxIOMBPS;

			private string tips;

			private string securityIPList;

			private string securityIPMode;

			private string dBInstanceClassType;

			private string guardDBInstanceName;

			private string dBInstanceDiskUsed;

			private int? proxyType;

			private string currentKernelVersion;

			private string dBInstanceDescription;

			private string tempUpgradeRecoveryClass;

			private string tempUpgradeTimeStart;

			private string dBInstanceCPU;

			private string dBInstanceNetType;

			private string dBInstanceType;

			private string tempUpgradeRecoveryMaxIOPS;

			private string lockReason;

			private string dBInstanceStatus;

			private int? dBMaxQuantity;

			private string regionId;

			private string readonlyInstanceSQLDelayedTime;

			private string tempUpgradeTimeEnd;

			private string vSwitchId;

			private string resourceGroupId;

			private string category;

			private int? tempUpgradeRecoveryCpu;

			private string dBInstanceClass;

			private string engine;

			private bool? deletionProtection;

			private string kindCode;

			private string instructionSetArch;

			private bool? burstingEnabled;

			private string bpeEnabled;

			private List<DescribeDBInstanceAttribute_SlaveZone> slaveZones;

			private List<DescribeDBInstanceAttribute_ReadOnlyDBInstanceId> readOnlyDBInstanceIds;

			private List<DescribeDBInstanceAttribute_DBClusterNode> dBClusterNodes;

			private DescribeDBInstanceAttribute_Extra extra;

			private DescribeDBInstanceAttribute_ServerlessConfig serverlessConfig;

			private DescribeDBInstanceAttribute_BabelfishConfig babelfishConfig;

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

			[JsonProperty(PropertyName = "SuperPermissionMode")]
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

			[JsonProperty(PropertyName = "TempUpgradeRecoveryMaxConnections")]
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

			[JsonProperty(PropertyName = "MultipleTempUpgrade")]
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

			[JsonProperty(PropertyName = "SupportCreateSuperAccount")]
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

			[JsonProperty(PropertyName = "MasterZone")]
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

			[JsonProperty(PropertyName = "TimeZone")]
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

			[JsonProperty(PropertyName = "CanTempUpgrade")]
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

			[JsonProperty(PropertyName = "LatestKernelVersion")]
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

			[JsonProperty(PropertyName = "TempUpgradeRecoveryTime")]
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

			[JsonProperty(PropertyName = "DispenseMode")]
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

			[JsonProperty(PropertyName = "TempUpgradeRecoveryMemory")]
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

			[JsonProperty(PropertyName = "AdvancedFeatures")]
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

			[JsonProperty(PropertyName = "IPType")]
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

			[JsonProperty(PropertyName = "ConsoleVersion")]
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

			[JsonProperty(PropertyName = "OriginConfiguration")]
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

			[JsonProperty(PropertyName = "MaxIOMBPS")]
			public int? MaxIOMBPS
			{
				get
				{
					return maxIOMBPS;
				}
				set	
				{
					maxIOMBPS = value;
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

			[JsonProperty(PropertyName = "SecurityIPMode")]
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

			[JsonProperty(PropertyName = "GuardDBInstanceName")]
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

			[JsonProperty(PropertyName = "DBInstanceDiskUsed")]
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

			[JsonProperty(PropertyName = "ProxyType")]
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

			[JsonProperty(PropertyName = "CurrentKernelVersion")]
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

			[JsonProperty(PropertyName = "TempUpgradeRecoveryClass")]
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

			[JsonProperty(PropertyName = "TempUpgradeTimeStart")]
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

			[JsonProperty(PropertyName = "TempUpgradeRecoveryMaxIOPS")]
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

			[JsonProperty(PropertyName = "ReadonlyInstanceSQLDelayedTime")]
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

			[JsonProperty(PropertyName = "TempUpgradeTimeEnd")]
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

			[JsonProperty(PropertyName = "TempUpgradeRecoveryCpu")]
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

			[JsonProperty(PropertyName = "KindCode")]
			public string KindCode
			{
				get
				{
					return kindCode;
				}
				set	
				{
					kindCode = value;
				}
			}

			[JsonProperty(PropertyName = "InstructionSetArch")]
			public string InstructionSetArch
			{
				get
				{
					return instructionSetArch;
				}
				set	
				{
					instructionSetArch = value;
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

			[JsonProperty(PropertyName = "SlaveZones")]
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

			[JsonProperty(PropertyName = "ReadOnlyDBInstanceIds")]
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

			[JsonProperty(PropertyName = "DBClusterNodes")]
			public List<DescribeDBInstanceAttribute_DBClusterNode> DBClusterNodes
			{
				get
				{
					return dBClusterNodes;
				}
				set	
				{
					dBClusterNodes = value;
				}
			}

			[JsonProperty(PropertyName = "Extra")]
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

			[JsonProperty(PropertyName = "ServerlessConfig")]
			public DescribeDBInstanceAttribute_ServerlessConfig ServerlessConfig
			{
				get
				{
					return serverlessConfig;
				}
				set	
				{
					serverlessConfig = value;
				}
			}

			[JsonProperty(PropertyName = "BabelfishConfig")]
			public DescribeDBInstanceAttribute_BabelfishConfig BabelfishConfig
			{
				get
				{
					return babelfishConfig;
				}
				set	
				{
					babelfishConfig = value;
				}
			}

			public class DescribeDBInstanceAttribute_SlaveZone
			{

				private string zoneId;

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
			}

			public class DescribeDBInstanceAttribute_ReadOnlyDBInstanceId
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

			public class DescribeDBInstanceAttribute_DBClusterNode
			{

				private string nodeRegionId;

				private string nodeZoneId;

				private string nodeId;

				private string nodeRole;

				private string classCode;

				[JsonProperty(PropertyName = "NodeRegionId")]
				public string NodeRegionId
				{
					get
					{
						return nodeRegionId;
					}
					set	
					{
						nodeRegionId = value;
					}
				}

				[JsonProperty(PropertyName = "NodeZoneId")]
				public string NodeZoneId
				{
					get
					{
						return nodeZoneId;
					}
					set	
					{
						nodeZoneId = value;
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

				[JsonProperty(PropertyName = "NodeRole")]
				public string NodeRole
				{
					get
					{
						return nodeRole;
					}
					set	
					{
						nodeRole = value;
					}
				}

				[JsonProperty(PropertyName = "ClassCode")]
				public string ClassCode
				{
					get
					{
						return classCode;
					}
					set	
					{
						classCode = value;
					}
				}
			}

			public class DescribeDBInstanceAttribute_Extra
			{

				private string replicaGroupStatus;

				private string activeReplicaDBInstanceID;

				private string replicaGroupID;

				private List<string> dBInstanceIds;

				[JsonProperty(PropertyName = "ReplicaGroupStatus")]
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

				[JsonProperty(PropertyName = "ActiveReplicaDBInstanceID")]
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

				[JsonProperty(PropertyName = "ReplicaGroupID")]
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

				[JsonProperty(PropertyName = "DBInstanceIds")]
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

			public class DescribeDBInstanceAttribute_ServerlessConfig
			{

				private double? scaleMin;

				private double? scaleMax;

				private bool? autoPause;

				private bool? switchForce;

				[JsonProperty(PropertyName = "ScaleMin")]
				public double? ScaleMin
				{
					get
					{
						return scaleMin;
					}
					set	
					{
						scaleMin = value;
					}
				}

				[JsonProperty(PropertyName = "ScaleMax")]
				public double? ScaleMax
				{
					get
					{
						return scaleMax;
					}
					set	
					{
						scaleMax = value;
					}
				}

				[JsonProperty(PropertyName = "AutoPause")]
				public bool? AutoPause
				{
					get
					{
						return autoPause;
					}
					set	
					{
						autoPause = value;
					}
				}

				[JsonProperty(PropertyName = "SwitchForce")]
				public bool? SwitchForce
				{
					get
					{
						return switchForce;
					}
					set	
					{
						switchForce = value;
					}
				}
			}

			public class DescribeDBInstanceAttribute_BabelfishConfig
			{

				private string babelfishEnabled;

				private string migrationMode;

				[JsonProperty(PropertyName = "BabelfishEnabled")]
				public string BabelfishEnabled
				{
					get
					{
						return babelfishEnabled;
					}
					set	
					{
						babelfishEnabled = value;
					}
				}

				[JsonProperty(PropertyName = "MigrationMode")]
				public string MigrationMode
				{
					get
					{
						return migrationMode;
					}
					set	
					{
						migrationMode = value;
					}
				}
			}
		}
	}
}
