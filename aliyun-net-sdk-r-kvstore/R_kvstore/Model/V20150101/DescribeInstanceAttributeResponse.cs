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
	public class DescribeInstanceAttributeResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeInstanceAttribute_DBInstanceAttribute> instances;

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

		public List<DescribeInstanceAttribute_DBInstanceAttribute> Instances
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

		public class DescribeInstanceAttribute_DBInstanceAttribute
		{

			private string vpcId;

			private string privateIp;

			private long? capacity;

			private string createTime;

			private string connectionDomain;

			private bool? isRds;

			private string chargeType;

			private string storageType;

			private string vpcAuthMode;

			private string architectureType;

			private string availabilityValue;

			private string networkType;

			private long? port;

			private string secondaryZoneId;

			private string packageType;

			private string engineVersion;

			private string config;

			private string vpcCloudInstanceId;

			private long? bandwidth;

			private string instanceName;

			private string securityIPList;

			private int? shardCount;

			private string globalInstanceId;

			private long? qPS;

			private string auditLogRetention;

			private string zoneType;

			private string maintainStartTime;

			private string instanceClass;

			private string maintainEndTime;

			private string instanceId;

			private string instanceType;

			private string hasRenewChangeOrder;

			private bool? instanceReleaseProtection;

			private string replicationMode;

			private string regionId;

			private string endTime;

			private string vSwitchId;

			private string replicaId;

			private string nodeType;

			private long? connections;

			private string backupLogStartTime;

			private string resourceGroupId;

			private string zoneId;

			private string instanceStatus;

			private string engine;

			private string storage;

			private string cloudType;

			private List<DescribeInstanceAttribute_Tag> tags;

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

			public string VpcAuthMode
			{
				get
				{
					return vpcAuthMode;
				}
				set	
				{
					vpcAuthMode = value;
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

			public string AuditLogRetention
			{
				get
				{
					return auditLogRetention;
				}
				set	
				{
					auditLogRetention = value;
				}
			}

			public string ZoneType
			{
				get
				{
					return zoneType;
				}
				set	
				{
					zoneType = value;
				}
			}

			public string MaintainStartTime
			{
				get
				{
					return maintainStartTime;
				}
				set	
				{
					maintainStartTime = value;
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

			public string MaintainEndTime
			{
				get
				{
					return maintainEndTime;
				}
				set	
				{
					maintainEndTime = value;
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

			public string HasRenewChangeOrder
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

			public bool? InstanceReleaseProtection
			{
				get
				{
					return instanceReleaseProtection;
				}
				set	
				{
					instanceReleaseProtection = value;
				}
			}

			public string ReplicationMode
			{
				get
				{
					return replicationMode;
				}
				set	
				{
					replicationMode = value;
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

			public string ReplicaId
			{
				get
				{
					return replicaId;
				}
				set	
				{
					replicaId = value;
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

			public string BackupLogStartTime
			{
				get
				{
					return backupLogStartTime;
				}
				set	
				{
					backupLogStartTime = value;
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

			public string Storage
			{
				get
				{
					return storage;
				}
				set	
				{
					storage = value;
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

			public List<DescribeInstanceAttribute_Tag> Tags
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

			public class DescribeInstanceAttribute_Tag
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
