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

			private string replacateId;

			private string instanceId;

			private string instanceName;

			private string searchKey;

			private string connectionDomain;

			private long? port;

			private string userName;

			private string instanceStatus;

			private string regionId;

			private long? capacity;

			private string instanceClass;

			private long? qPS;

			private long? bandwidth;

			private long? connections;

			private string zoneId;

			private string config;

			private string chargeType;

			private string networkType;

			private string vpcId;

			private string vSwitchId;

			private string privateIp;

			private string createTime;

			private string endTime;

			private bool? hasRenewChangeOrder;

			private bool? isRds;

			private string instanceType;

			private string architectureType;

			private string nodeType;

			private string packageType;

			private string engineVersion;

			private string destroyTime;

			private string connectionMode;

			private string vpcCloudInstanceId;

			private string resourceGroupId;

			private int? shardCount;

			private int? proxyCount;

			private List<DescribeInstances_Tag> tags;

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
