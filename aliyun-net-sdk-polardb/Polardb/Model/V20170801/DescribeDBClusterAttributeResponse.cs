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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBClusterAttributeResponse : AcsResponse
	{

		private int? deletionLock;

		private string category;

		private string resourceGroupId;

		private long? dataLevel1BackupChainSize;

		private string dBClusterId;

		private string dBClusterNetworkType;

		private string dBType;

		private bool? isLatestVersion;

		private string dBVersion;

		private long? storageMax;

		private string zoneIds;

		private string maintainTime;

		private string engine;

		private string requestId;

		private string vPCId;

		private string dBClusterStatus;

		private string vSwitchId;

		private string dBClusterDescription;

		private string expired;

		private string lockMode;

		private string payType;

		private long? storageUsed;

		private string dBVersionStatus;

		private string subCategory;

		private string creationTime;

		private string regionId;

		private long? sQLSize;

		private string expireTime;

		private List<DescribeDBClusterAttribute_DBNode> dBNodes;

		private List<DescribeDBClusterAttribute_Tag> tags;

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

		public class DescribeDBClusterAttribute_DBNode
		{

			private string dBNodeStatus;

			private int? maxConnections;

			private string zoneId;

			private string dBNodeRole;

			private string creationTime;

			private string dBNodeId;

			private int? failoverPriority;

			private string dBNodeClass;

			private int? maxIOPS;

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
		}

		public class DescribeDBClusterAttribute_Tag
		{

			private string _value;

			private string key;

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
		}
	}
}
