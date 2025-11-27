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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBClusterAttributeResponse : AcsResponse
	{

		private int? deletionLock;

		private string category;

		private string resourceGroupId;

		private long? dataLevel1BackupChainSize;

		private string dBClusterId;

		private string dBType;

		private string dBClusterNetworkType;

		private bool? isLatestVersion;

		private bool? hasCompleteStandbyRes;

		private string hotStandbyClusterStatus;

		private string hotStandbyCluster;

		private string dataSyncMode;

		private string standbyHAMode;

		private string compressStorageMode;

		private long? storageMax;

		private string dBVersion;

		private string zoneIds;

		private string maintainTime;

		private string engine;

		private string requestId;

		private string vPCId;

		private string dBClusterStatus;

		private string vSwitchId;

		private string dBClusterDescription;

		private string expired;

		private string payType;

		private string storagePayType;

		private string lockMode;

		private long? storageUsed;

		private long? compressStorageUsed;

		private long? storageSpace;

		private string dBVersionStatus;

		private string creationTime;

		private long? sQLSize;

		private long? inodeTotal;

		private long? inodeUsed;

		private long? blktagTotal;

		private long? blktagUsed;

		private string regionId;

		private string expireTime;

		private string subCategory;

		private string deployUnit;

		private bool? isProxyLatestVersion;

		private string storageType;

		private string serverlessType;

		private string strictConsistency;

		private string proxyCpuCores;

		private string proxyStandardCpuCores;

		private string proxyType;

		private string proxyStatus;

		private string featureHTAPSupported;

		private string proxyServerlessType;

		private string architecture;

		private string aiType;

		private string provisionedIops;

		private bool? hotStandbyHealthy;

		private bool? hotStandbyWhiteListSwitch;

		private bool? storageTypeWhiteListSwitch;

		private string aiFreeMode;

		private string aiCreatingTime;

		private string supportInstantSwitchWithImci;

		private string orca;

		private string sourceDBCluster;

		private string restoreType;

		private string restoreDataPoint;

		private string sourceRegionId;

		private string imciAutoIndex;

		private string osVersion;

		private string autoUpgradeMinorVersion;

		private string burstingEnabled;

		private string rowCompression;

		private string imperceptibleSwitch;

		private int? cnNodeCount;

		private int? dnNodeCount;

		private string documentDB;

		private string backupDowngradeLevel;

		private string relativeAICluster;

		private List<DescribeDBClusterAttribute_DBNode> dBNodes;

		private List<DescribeDBClusterAttribute_Tag> tags;

		private DescribeDBClusterAttribute_RelatedAPInstance relatedAPInstance;

		public int? DeletionLock
		{
			get
			{
				return deletionLock;
			}
			set	
			{
				deletionLock = value;
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

		public long? DataLevel1BackupChainSize
		{
			get
			{
				return dataLevel1BackupChainSize;
			}
			set	
			{
				dataLevel1BackupChainSize = value;
			}
		}

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
			}
		}

		public string DBType
		{
			get
			{
				return dBType;
			}
			set	
			{
				dBType = value;
			}
		}

		public string DBClusterNetworkType
		{
			get
			{
				return dBClusterNetworkType;
			}
			set	
			{
				dBClusterNetworkType = value;
			}
		}

		public bool? IsLatestVersion
		{
			get
			{
				return isLatestVersion;
			}
			set	
			{
				isLatestVersion = value;
			}
		}

		public bool? HasCompleteStandbyRes
		{
			get
			{
				return hasCompleteStandbyRes;
			}
			set	
			{
				hasCompleteStandbyRes = value;
			}
		}

		public string HotStandbyClusterStatus
		{
			get
			{
				return hotStandbyClusterStatus;
			}
			set	
			{
				hotStandbyClusterStatus = value;
			}
		}

		public string HotStandbyCluster
		{
			get
			{
				return hotStandbyCluster;
			}
			set	
			{
				hotStandbyCluster = value;
			}
		}

		public string DataSyncMode
		{
			get
			{
				return dataSyncMode;
			}
			set	
			{
				dataSyncMode = value;
			}
		}

		public string StandbyHAMode
		{
			get
			{
				return standbyHAMode;
			}
			set	
			{
				standbyHAMode = value;
			}
		}

		public string CompressStorageMode
		{
			get
			{
				return compressStorageMode;
			}
			set	
			{
				compressStorageMode = value;
			}
		}

		public long? StorageMax
		{
			get
			{
				return storageMax;
			}
			set	
			{
				storageMax = value;
			}
		}

		public string DBVersion
		{
			get
			{
				return dBVersion;
			}
			set	
			{
				dBVersion = value;
			}
		}

		public string ZoneIds
		{
			get
			{
				return zoneIds;
			}
			set	
			{
				zoneIds = value;
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

		public string VPCId
		{
			get
			{
				return vPCId;
			}
			set	
			{
				vPCId = value;
			}
		}

		public string DBClusterStatus
		{
			get
			{
				return dBClusterStatus;
			}
			set	
			{
				dBClusterStatus = value;
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

		public string DBClusterDescription
		{
			get
			{
				return dBClusterDescription;
			}
			set	
			{
				dBClusterDescription = value;
			}
		}

		public string Expired
		{
			get
			{
				return expired;
			}
			set	
			{
				expired = value;
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

		public string StoragePayType
		{
			get
			{
				return storagePayType;
			}
			set	
			{
				storagePayType = value;
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

		public long? StorageUsed
		{
			get
			{
				return storageUsed;
			}
			set	
			{
				storageUsed = value;
			}
		}

		public long? CompressStorageUsed
		{
			get
			{
				return compressStorageUsed;
			}
			set	
			{
				compressStorageUsed = value;
			}
		}

		public long? StorageSpace
		{
			get
			{
				return storageSpace;
			}
			set	
			{
				storageSpace = value;
			}
		}

		public string DBVersionStatus
		{
			get
			{
				return dBVersionStatus;
			}
			set	
			{
				dBVersionStatus = value;
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

		public long? SQLSize
		{
			get
			{
				return sQLSize;
			}
			set	
			{
				sQLSize = value;
			}
		}

		public long? InodeTotal
		{
			get
			{
				return inodeTotal;
			}
			set	
			{
				inodeTotal = value;
			}
		}

		public long? InodeUsed
		{
			get
			{
				return inodeUsed;
			}
			set	
			{
				inodeUsed = value;
			}
		}

		public long? BlktagTotal
		{
			get
			{
				return blktagTotal;
			}
			set	
			{
				blktagTotal = value;
			}
		}

		public long? BlktagUsed
		{
			get
			{
				return blktagUsed;
			}
			set	
			{
				blktagUsed = value;
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

		public string SubCategory
		{
			get
			{
				return subCategory;
			}
			set	
			{
				subCategory = value;
			}
		}

		public string DeployUnit
		{
			get
			{
				return deployUnit;
			}
			set	
			{
				deployUnit = value;
			}
		}

		public bool? IsProxyLatestVersion
		{
			get
			{
				return isProxyLatestVersion;
			}
			set	
			{
				isProxyLatestVersion = value;
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

		public string ServerlessType
		{
			get
			{
				return serverlessType;
			}
			set	
			{
				serverlessType = value;
			}
		}

		public string StrictConsistency
		{
			get
			{
				return strictConsistency;
			}
			set	
			{
				strictConsistency = value;
			}
		}

		public string ProxyCpuCores
		{
			get
			{
				return proxyCpuCores;
			}
			set	
			{
				proxyCpuCores = value;
			}
		}

		public string ProxyStandardCpuCores
		{
			get
			{
				return proxyStandardCpuCores;
			}
			set	
			{
				proxyStandardCpuCores = value;
			}
		}

		public string ProxyType
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

		public string ProxyStatus
		{
			get
			{
				return proxyStatus;
			}
			set	
			{
				proxyStatus = value;
			}
		}

		public string FeatureHTAPSupported
		{
			get
			{
				return featureHTAPSupported;
			}
			set	
			{
				featureHTAPSupported = value;
			}
		}

		public string ProxyServerlessType
		{
			get
			{
				return proxyServerlessType;
			}
			set	
			{
				proxyServerlessType = value;
			}
		}

		public string Architecture
		{
			get
			{
				return architecture;
			}
			set	
			{
				architecture = value;
			}
		}

		public string AiType
		{
			get
			{
				return aiType;
			}
			set	
			{
				aiType = value;
			}
		}

		public string ProvisionedIops
		{
			get
			{
				return provisionedIops;
			}
			set	
			{
				provisionedIops = value;
			}
		}

		public bool? HotStandbyHealthy
		{
			get
			{
				return hotStandbyHealthy;
			}
			set	
			{
				hotStandbyHealthy = value;
			}
		}

		public bool? HotStandbyWhiteListSwitch
		{
			get
			{
				return hotStandbyWhiteListSwitch;
			}
			set	
			{
				hotStandbyWhiteListSwitch = value;
			}
		}

		public bool? StorageTypeWhiteListSwitch
		{
			get
			{
				return storageTypeWhiteListSwitch;
			}
			set	
			{
				storageTypeWhiteListSwitch = value;
			}
		}

		public string AiFreeMode
		{
			get
			{
				return aiFreeMode;
			}
			set	
			{
				aiFreeMode = value;
			}
		}

		public string AiCreatingTime
		{
			get
			{
				return aiCreatingTime;
			}
			set	
			{
				aiCreatingTime = value;
			}
		}

		public string SupportInstantSwitchWithImci
		{
			get
			{
				return supportInstantSwitchWithImci;
			}
			set	
			{
				supportInstantSwitchWithImci = value;
			}
		}

		public string Orca
		{
			get
			{
				return orca;
			}
			set	
			{
				orca = value;
			}
		}

		public string SourceDBCluster
		{
			get
			{
				return sourceDBCluster;
			}
			set	
			{
				sourceDBCluster = value;
			}
		}

		public string RestoreType
		{
			get
			{
				return restoreType;
			}
			set	
			{
				restoreType = value;
			}
		}

		public string RestoreDataPoint
		{
			get
			{
				return restoreDataPoint;
			}
			set	
			{
				restoreDataPoint = value;
			}
		}

		public string SourceRegionId
		{
			get
			{
				return sourceRegionId;
			}
			set	
			{
				sourceRegionId = value;
			}
		}

		public string ImciAutoIndex
		{
			get
			{
				return imciAutoIndex;
			}
			set	
			{
				imciAutoIndex = value;
			}
		}

		public string OsVersion
		{
			get
			{
				return osVersion;
			}
			set	
			{
				osVersion = value;
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

		public string BurstingEnabled
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

		public string RowCompression
		{
			get
			{
				return rowCompression;
			}
			set	
			{
				rowCompression = value;
			}
		}

		public string ImperceptibleSwitch
		{
			get
			{
				return imperceptibleSwitch;
			}
			set	
			{
				imperceptibleSwitch = value;
			}
		}

		public int? CnNodeCount
		{
			get
			{
				return cnNodeCount;
			}
			set	
			{
				cnNodeCount = value;
			}
		}

		public int? DnNodeCount
		{
			get
			{
				return dnNodeCount;
			}
			set	
			{
				dnNodeCount = value;
			}
		}

		public string DocumentDB
		{
			get
			{
				return documentDB;
			}
			set	
			{
				documentDB = value;
			}
		}

		public string BackupDowngradeLevel
		{
			get
			{
				return backupDowngradeLevel;
			}
			set	
			{
				backupDowngradeLevel = value;
			}
		}

		public string RelativeAICluster
		{
			get
			{
				return relativeAICluster;
			}
			set	
			{
				relativeAICluster = value;
			}
		}

		public List<DescribeDBClusterAttribute_DBNode> DBNodes
		{
			get
			{
				return dBNodes;
			}
			set	
			{
				dBNodes = value;
			}
		}

		public List<DescribeDBClusterAttribute_Tag> Tags
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

		public DescribeDBClusterAttribute_RelatedAPInstance RelatedAPInstance
		{
			get
			{
				return relatedAPInstance;
			}
			set	
			{
				relatedAPInstance = value;
			}
		}

		public class DescribeDBClusterAttribute_DBNode
		{

			private string creationTime;

			private int? failoverPriority;

			private int? maxIOPS;

			private string dBNodeClass;

			private string cpuCores;

			private string memorySize;

			private string dBNodeRole;

			private string zoneId;

			private int? maxConnections;

			private string dBNodeStatus;

			private string dBNodeId;

			private string imciSwitch;

			private string hotReplicaMode;

			private string addedCpuCores;

			private string masterId;

			private string sccMode;

			private string serverWeight;

			private string serverlessType;

			private string subCluster;

			private string tair;

			private string remoteMemorySize;

			private string orca;

			private string osVersion;

			private string multiMasterLocalStandby;

			private string multiMasterPrimaryNode;

			private string dBNodeDescription;

			private string subGroupType;

			private string subGroupName;

			private bool? isPrimaryCN;

			private string standbyZoneIds;

			private long? storageMax;

			private long? storageUsed;

			private long? inodeUsed;

			private long? inodeTotal;

			private long? blktagTotal;

			private long? blktagUsed;

			private string subGroupDescription;

			private string mirrorInsName;

			private string architecture;

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

			public int? FailoverPriority
			{
				get
				{
					return failoverPriority;
				}
				set	
				{
					failoverPriority = value;
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

			public string DBNodeClass
			{
				get
				{
					return dBNodeClass;
				}
				set	
				{
					dBNodeClass = value;
				}
			}

			public string CpuCores
			{
				get
				{
					return cpuCores;
				}
				set	
				{
					cpuCores = value;
				}
			}

			public string MemorySize
			{
				get
				{
					return memorySize;
				}
				set	
				{
					memorySize = value;
				}
			}

			public string DBNodeRole
			{
				get
				{
					return dBNodeRole;
				}
				set	
				{
					dBNodeRole = value;
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

			public string DBNodeStatus
			{
				get
				{
					return dBNodeStatus;
				}
				set	
				{
					dBNodeStatus = value;
				}
			}

			public string DBNodeId
			{
				get
				{
					return dBNodeId;
				}
				set	
				{
					dBNodeId = value;
				}
			}

			public string ImciSwitch
			{
				get
				{
					return imciSwitch;
				}
				set	
				{
					imciSwitch = value;
				}
			}

			public string HotReplicaMode
			{
				get
				{
					return hotReplicaMode;
				}
				set	
				{
					hotReplicaMode = value;
				}
			}

			public string AddedCpuCores
			{
				get
				{
					return addedCpuCores;
				}
				set	
				{
					addedCpuCores = value;
				}
			}

			public string MasterId
			{
				get
				{
					return masterId;
				}
				set	
				{
					masterId = value;
				}
			}

			public string SccMode
			{
				get
				{
					return sccMode;
				}
				set	
				{
					sccMode = value;
				}
			}

			public string ServerWeight
			{
				get
				{
					return serverWeight;
				}
				set	
				{
					serverWeight = value;
				}
			}

			public string ServerlessType
			{
				get
				{
					return serverlessType;
				}
				set	
				{
					serverlessType = value;
				}
			}

			public string SubCluster
			{
				get
				{
					return subCluster;
				}
				set	
				{
					subCluster = value;
				}
			}

			public string Tair
			{
				get
				{
					return tair;
				}
				set	
				{
					tair = value;
				}
			}

			public string RemoteMemorySize
			{
				get
				{
					return remoteMemorySize;
				}
				set	
				{
					remoteMemorySize = value;
				}
			}

			public string Orca
			{
				get
				{
					return orca;
				}
				set	
				{
					orca = value;
				}
			}

			public string OsVersion
			{
				get
				{
					return osVersion;
				}
				set	
				{
					osVersion = value;
				}
			}

			public string MultiMasterLocalStandby
			{
				get
				{
					return multiMasterLocalStandby;
				}
				set	
				{
					multiMasterLocalStandby = value;
				}
			}

			public string MultiMasterPrimaryNode
			{
				get
				{
					return multiMasterPrimaryNode;
				}
				set	
				{
					multiMasterPrimaryNode = value;
				}
			}

			public string DBNodeDescription
			{
				get
				{
					return dBNodeDescription;
				}
				set	
				{
					dBNodeDescription = value;
				}
			}

			public string SubGroupType
			{
				get
				{
					return subGroupType;
				}
				set	
				{
					subGroupType = value;
				}
			}

			public string SubGroupName
			{
				get
				{
					return subGroupName;
				}
				set	
				{
					subGroupName = value;
				}
			}

			public bool? IsPrimaryCN
			{
				get
				{
					return isPrimaryCN;
				}
				set	
				{
					isPrimaryCN = value;
				}
			}

			public string StandbyZoneIds
			{
				get
				{
					return standbyZoneIds;
				}
				set	
				{
					standbyZoneIds = value;
				}
			}

			public long? StorageMax
			{
				get
				{
					return storageMax;
				}
				set	
				{
					storageMax = value;
				}
			}

			public long? StorageUsed
			{
				get
				{
					return storageUsed;
				}
				set	
				{
					storageUsed = value;
				}
			}

			public long? InodeUsed
			{
				get
				{
					return inodeUsed;
				}
				set	
				{
					inodeUsed = value;
				}
			}

			public long? InodeTotal
			{
				get
				{
					return inodeTotal;
				}
				set	
				{
					inodeTotal = value;
				}
			}

			public long? BlktagTotal
			{
				get
				{
					return blktagTotal;
				}
				set	
				{
					blktagTotal = value;
				}
			}

			public long? BlktagUsed
			{
				get
				{
					return blktagUsed;
				}
				set	
				{
					blktagUsed = value;
				}
			}

			public string SubGroupDescription
			{
				get
				{
					return subGroupDescription;
				}
				set	
				{
					subGroupDescription = value;
				}
			}

			public string MirrorInsName
			{
				get
				{
					return mirrorInsName;
				}
				set	
				{
					mirrorInsName = value;
				}
			}

			public string Architecture
			{
				get
				{
					return architecture;
				}
				set	
				{
					architecture = value;
				}
			}
		}

		public class DescribeDBClusterAttribute_Tag
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class DescribeDBClusterAttribute_RelatedAPInstance
		{

			private string name;

			private string classCode;

			private string ossStorageUsed;

			private string totalAPNodes;

			private float? storageUsedMB;

			private string aPNodeStatus;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

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

			public string OssStorageUsed
			{
				get
				{
					return ossStorageUsed;
				}
				set	
				{
					ossStorageUsed = value;
				}
			}

			public string TotalAPNodes
			{
				get
				{
					return totalAPNodes;
				}
				set	
				{
					totalAPNodes = value;
				}
			}

			public float? StorageUsedMB
			{
				get
				{
					return storageUsedMB;
				}
				set	
				{
					storageUsedMB = value;
				}
			}

			public string APNodeStatus
			{
				get
				{
					return aPNodeStatus;
				}
				set	
				{
					aPNodeStatus = value;
				}
			}
		}
	}
}
