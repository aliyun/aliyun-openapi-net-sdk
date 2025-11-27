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

namespace Aliyun.Acs.clickhouse.Model.V20191111
{
	public class DescribeDBClustersResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private List<DescribeDBClusters_DBCluster> dBClusters;

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
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

		public List<DescribeDBClusters_DBCluster> DBClusters
		{
			get
			{
				return dBClusters;
			}
			set	
			{
				dBClusters = value;
			}
		}

		public class DescribeDBClusters_DBCluster
		{

			private string vpcId;

			private long? dBNodeCount;

			private string createTime;

			private string payType;

			private string storageType;

			private int? port;

			private string lockMode;

			private string bid;

			private string isExpired;

			private string vpcCloudInstanceId;

			private string scaleOutDisableWriteWindows;

			private string dBClusterId;

			private string connectionString;

			private string commodityCode;

			private string expireTime;

			private long? dBNodeStorage;

			private string dBNodeClass;

			private string aliUid;

			private string lockReason;

			private string regionId;

			private string vSwitchId;

			private string dBClusterStatus;

			private string dBClusterDescription;

			private string dBClusterNetworkType;

			private string zoneId;

			private string category;

			private string controlVersion;

			private string extStorageType;

			private int? extStorageSize;

			private string resourceGroupId;

			private string dbVersion;

			private List<DescribeDBClusters_Tag> tags;

			private DescribeDBClusters_ScaleOutStatus scaleOutStatus;

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

			public long? DBNodeCount
			{
				get
				{
					return dBNodeCount;
				}
				set	
				{
					dBNodeCount = value;
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

			public int? Port
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

			public string Bid
			{
				get
				{
					return bid;
				}
				set	
				{
					bid = value;
				}
			}

			public string IsExpired
			{
				get
				{
					return isExpired;
				}
				set	
				{
					isExpired = value;
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

			public string ScaleOutDisableWriteWindows
			{
				get
				{
					return scaleOutDisableWriteWindows;
				}
				set	
				{
					scaleOutDisableWriteWindows = value;
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

			public long? DBNodeStorage
			{
				get
				{
					return dBNodeStorage;
				}
				set	
				{
					dBNodeStorage = value;
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

			public string AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
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

			public string ControlVersion
			{
				get
				{
					return controlVersion;
				}
				set	
				{
					controlVersion = value;
				}
			}

			public string ExtStorageType
			{
				get
				{
					return extStorageType;
				}
				set	
				{
					extStorageType = value;
				}
			}

			public int? ExtStorageSize
			{
				get
				{
					return extStorageSize;
				}
				set	
				{
					extStorageSize = value;
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

			public string DbVersion
			{
				get
				{
					return dbVersion;
				}
				set	
				{
					dbVersion = value;
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

			public DescribeDBClusters_ScaleOutStatus ScaleOutStatus
			{
				get
				{
					return scaleOutStatus;
				}
				set	
				{
					scaleOutStatus = value;
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

			public class DescribeDBClusters_ScaleOutStatus
			{

				private string progress;

				private string ratio;

				public string Progress
				{
					get
					{
						return progress;
					}
					set	
					{
						progress = value;
					}
				}

				public string Ratio
				{
					get
					{
						return ratio;
					}
					set	
					{
						ratio = value;
					}
				}
			}
		}
	}
}
