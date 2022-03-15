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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeInstances_KVStoreInstance> instances;

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

		public List<DescribeInstances_KVStoreInstance> Instances
		{
			get
			{
				return instances;
			}
			set	
			{
				instances = value;
			}
		}

		public class DescribeInstances_KVStoreInstance
		{

			private string vpcId;

			private string privateIp;

			private long? capacity;

			private string replacateId;

			private string createTime;

			private string connectionDomain;

			private bool? isRds;

			private string chargeType;

			private string architectureType;

			private string networkType;

			private string connectionMode;

			private long? port;

			private string secondaryZoneId;

			private string engineVersion;

			private string packageType;

			private string config;

			private string vpcCloudInstanceId;

			private long? bandwidth;

			private string instanceName;

			private int? shardCount;

			private string userName;

			private string globalInstanceId;

			private long? qPS;

			private string instanceClass;

			private string destroyTime;

			private string instanceId;

			private string instanceType;

			private bool? hasRenewChangeOrder;

			private string regionId;

			private string searchKey;

			private string endTime;

			private string vSwitchId;

			private string nodeType;

			private long? connections;

			private string resourceGroupId;

			private string zoneId;

			private string instanceStatus;

			private int? proxyCount;

			private string cloudType;

			private List<DescribeInstances_Tag> tags;

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

			public string PrivateIp
			{
				get
				{
					return privateIp;
				}
				set	
				{
					privateIp = value;
				}
			}

			public long? Capacity
			{
				get
				{
					return capacity;
				}
				set	
				{
					capacity = value;
				}
			}

			public string ReplacateId
			{
				get
				{
					return replacateId;
				}
				set	
				{
					replacateId = value;
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

			public string ConnectionDomain
			{
				get
				{
					return connectionDomain;
				}
				set	
				{
					connectionDomain = value;
				}
			}

			public bool? IsRds
			{
				get
				{
					return isRds;
				}
				set	
				{
					isRds = value;
				}
			}

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			public string ArchitectureType
			{
				get
				{
					return architectureType;
				}
				set	
				{
					architectureType = value;
				}
			}

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
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

			public long? Port
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

			public string SecondaryZoneId
			{
				get
				{
					return secondaryZoneId;
				}
				set	
				{
					secondaryZoneId = value;
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

			public string PackageType
			{
				get
				{
					return packageType;
				}
				set	
				{
					packageType = value;
				}
			}

			public string Config
			{
				get
				{
					return config;
				}
				set	
				{
					config = value;
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

			public long? Bandwidth
			{
				get
				{
					return bandwidth;
				}
				set	
				{
					bandwidth = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public int? ShardCount
			{
				get
				{
					return shardCount;
				}
				set	
				{
					shardCount = value;
				}
			}

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}

			public string GlobalInstanceId
			{
				get
				{
					return globalInstanceId;
				}
				set	
				{
					globalInstanceId = value;
				}
			}

			public long? QPS
			{
				get
				{
					return qPS;
				}
				set	
				{
					qPS = value;
				}
			}

			public string InstanceClass
			{
				get
				{
					return instanceClass;
				}
				set	
				{
					instanceClass = value;
				}
			}

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

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public bool? HasRenewChangeOrder
			{
				get
				{
					return hasRenewChangeOrder;
				}
				set	
				{
					hasRenewChangeOrder = value;
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

			public string SearchKey
			{
				get
				{
					return searchKey;
				}
				set	
				{
					searchKey = value;
				}
			}

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
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

			public string NodeType
			{
				get
				{
					return nodeType;
				}
				set	
				{
					nodeType = value;
				}
			}

			public long? Connections
			{
				get
				{
					return connections;
				}
				set	
				{
					connections = value;
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

			public string InstanceStatus
			{
				get
				{
					return instanceStatus;
				}
				set	
				{
					instanceStatus = value;
				}
			}

			public int? ProxyCount
			{
				get
				{
					return proxyCount;
				}
				set	
				{
					proxyCount = value;
				}
			}

			public string CloudType
			{
				get
				{
					return cloudType;
				}
				set	
				{
					cloudType = value;
				}
			}

			public List<DescribeInstances_Tag> Tags
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

			public class DescribeInstances_Tag
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
