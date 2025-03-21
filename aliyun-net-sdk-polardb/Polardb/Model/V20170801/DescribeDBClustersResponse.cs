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
	public class DescribeDBClustersResponse : AcsResponse
	{

		private int? totalRecordCount;

		private int? pageRecordCount;

		private string requestId;

		private int? pageNumber;

		private List<DescribeDBClusters_DBCluster> items;

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

		public List<DescribeDBClusters_DBCluster> Items
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

		public class DescribeDBClusters_DBCluster
		{

			private string vpcId;

			private string vswitchId;

			private string expireTime;

			private string expired;

			private int? dBNodeNumber;

			private string createTime;

			private string payType;

			private string storagePayType;

			private string serverlessType;

			private string strictConsistency;

			private string dBNodeClass;

			private string dBType;

			private string lockMode;

			private string regionId;

			private int? deletionLock;

			private string dBVersion;

			private string dBClusterId;

			private string dBClusterStatus;

			private string resourceGroupId;

			private long? storageUsed;

			private long? compressStorageUsed;

			private long? storageSpace;

			private string dBClusterNetworkType;

			private string dBClusterDescription;

			private string zoneId;

			private string engine;

			private string category;

			private string aiType;

			private string cpuCores;

			private string memorySize;

			private string remoteMemorySize;

			private string cpuArch;

			private string deployUnit;

			private string storageType;

			private string hotStandbyCluster;

			private string engineMigrationStatus;

			private int? cnNodeCount;

			private int? dnNodeCount;

			private string cnClass;

			private string dnClass;

			private string cloudInstanceIp;

			private string subCategory;

			private List<DescribeDBClusters_Tag> tags;

			private List<DescribeDBClusters_DBNode> dBNodes;

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

			public int? DBNodeNumber
			{
				get
				{
					return dBNodeNumber;
				}
				set	
				{
					dBNodeNumber = value;
				}
			}

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

			public string CpuArch
			{
				get
				{
					return cpuArch;
				}
				set	
				{
					cpuArch = value;
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

			public string EngineMigrationStatus
			{
				get
				{
					return engineMigrationStatus;
				}
				set	
				{
					engineMigrationStatus = value;
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

			public string CnClass
			{
				get
				{
					return cnClass;
				}
				set	
				{
					cnClass = value;
				}
			}

			public string DnClass
			{
				get
				{
					return dnClass;
				}
				set	
				{
					dnClass = value;
				}
			}

			public string CloudInstanceIp
			{
				get
				{
					return cloudInstanceIp;
				}
				set	
				{
					cloudInstanceIp = value;
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

			public List<DescribeDBClusters_Tag> Tags
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

			public List<DescribeDBClusters_DBNode> DBNodes
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

			public class DescribeDBClusters_Tag
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

			public class DescribeDBClusters_DBNode
			{

				private string dBNodeClass;

				private string zoneId;

				private string dBNodeRole;

				private string dBNodeId;

				private string regionId;

				private string serverless;

				private string imciSwitch;

				private string hotReplicaMode;

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

				public string Serverless
				{
					get
					{
						return serverless;
					}
					set	
					{
						serverless = value;
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
			}
		}
	}
}
