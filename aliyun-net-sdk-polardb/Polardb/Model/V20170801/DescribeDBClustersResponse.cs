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

			private string expireTime;

			private string expired;

			private int? dBNodeNumber;

			private string createTime;

			private string payType;

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

			private string dBClusterNetworkType;

			private string dBClusterDescription;

			private string zoneId;

			private string engine;

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
			}
		}
	}
}
