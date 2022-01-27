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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeDBClusterAttributeResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDBClusterAttribute_DBCluster> items;

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

		public List<DescribeDBClusterAttribute_DBCluster> Items
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

		public class DescribeDBClusterAttribute_DBCluster
		{

			private string regionId;

			private string zoneId;

			private string dBClusterId;

			private string dBClusterType;

			private string dBClusterDescription;

			private string category;

			private string lockMode;

			private string lockReason;

			private string payType;

			private string dBVersion;

			private string dBClusterStatus;

			private long? dBNodeStorage;

			private string dBNodeClass;

			private long? dBNodeCount;

			private string creationTime;

			private string expireTime;

			private string expired;

			private string maintainTime;

			private string engine;

			private string vPCId;

			private string vSwitchId;

			private string vPCCloudInstanceId;

			private string commodityCode;

			private string dBClusterNetworkType;

			private string connectionString;

			private int? port;

			private string rdsInstanceId;

			private string dtsJobId;

			private string executorCount;

			private string diskType;

			private string computeResource;

			private string storageResource;

			private string mode;

			private string resourceGroupId;

			private int? elasticIOResource;

			private string engineVersion;

			private bool? userENIStatus;

			private bool? enableSpark;

			private bool? enableAirflow;

			private List<DescribeDBClusterAttribute_Tag> tags;

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

			public string DBClusterType
			{
				get
				{
					return dBClusterType;
				}
				set	
				{
					dBClusterType = value;
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

			public string VPCCloudInstanceId
			{
				get
				{
					return vPCCloudInstanceId;
				}
				set	
				{
					vPCCloudInstanceId = value;
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

			public string RdsInstanceId
			{
				get
				{
					return rdsInstanceId;
				}
				set	
				{
					rdsInstanceId = value;
				}
			}

			public string DtsJobId
			{
				get
				{
					return dtsJobId;
				}
				set	
				{
					dtsJobId = value;
				}
			}

			public string ExecutorCount
			{
				get
				{
					return executorCount;
				}
				set	
				{
					executorCount = value;
				}
			}

			public string DiskType
			{
				get
				{
					return diskType;
				}
				set	
				{
					diskType = value;
				}
			}

			public string ComputeResource
			{
				get
				{
					return computeResource;
				}
				set	
				{
					computeResource = value;
				}
			}

			public string StorageResource
			{
				get
				{
					return storageResource;
				}
				set	
				{
					storageResource = value;
				}
			}

			public string Mode
			{
				get
				{
					return mode;
				}
				set	
				{
					mode = value;
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

			public int? ElasticIOResource
			{
				get
				{
					return elasticIOResource;
				}
				set	
				{
					elasticIOResource = value;
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

			public bool? UserENIStatus
			{
				get
				{
					return userENIStatus;
				}
				set	
				{
					userENIStatus = value;
				}
			}

			public bool? EnableSpark
			{
				get
				{
					return enableSpark;
				}
				set	
				{
					enableSpark = value;
				}
			}

			public bool? EnableAirflow
			{
				get
				{
					return enableAirflow;
				}
				set	
				{
					enableAirflow = value;
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
		}
	}
}
