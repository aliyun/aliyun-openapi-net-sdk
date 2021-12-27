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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeDBInstanceAttributeResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDBInstanceAttribute_DBInstance> dBInstances;

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

		public List<DescribeDBInstanceAttribute_DBInstance> DBInstances
		{
			get
			{
				return dBInstances;
			}
			set	
			{
				dBInstances = value;
			}
		}

		public class DescribeDBInstanceAttribute_DBInstance
		{

			private string creationTime;

			private string replacateId;

			private string chargeType;

			private string vpcAuthMode;

			private string networkType;

			private string lockMode;

			private string engineVersion;

			private int? maxIOPS;

			private string vPCCloudInstanceIds;

			private string protocolType;

			private string dBInstanceDescription;

			private string currentKernelVersion;

			private bool? dBInstanceReleaseProtection;

			private string expireTime;

			private string maintainStartTime;

			private string dBInstanceType;

			private string lastDowngradeTime;

			private string maintainEndTime;

			private string dBInstanceStatus;

			private string vPCId;

			private string regionId;

			private int? dBInstanceStorage;

			private string replicaSetName;

			private string vSwitchId;

			private string storageEngine;

			private string resourceGroupId;

			private string zoneId;

			private int? maxConnections;

			private string dBInstanceId;

			private string dBInstanceClass;

			private string engine;

			private string readonlyReplicas;

			private string replicationFactor;

			private string kindCode;

			private string capacityUnit;

			private string cloudType;

			private List<DescribeDBInstanceAttribute_ReplicaSet> replicaSets;

			private List<DescribeDBInstanceAttribute_Tag> tags;

			private List<DescribeDBInstanceAttribute_MongosAttribute> mongosList;

			private List<DescribeDBInstanceAttribute_ShardAttribute> shardList;

			private List<DescribeDBInstanceAttribute_ConfigserverAttribute> configserverList;

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

			public string VPCCloudInstanceIds
			{
				get
				{
					return vPCCloudInstanceIds;
				}
				set	
				{
					vPCCloudInstanceIds = value;
				}
			}

			public string ProtocolType
			{
				get
				{
					return protocolType;
				}
				set	
				{
					protocolType = value;
				}
			}

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

			public bool? DBInstanceReleaseProtection
			{
				get
				{
					return dBInstanceReleaseProtection;
				}
				set	
				{
					dBInstanceReleaseProtection = value;
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

			public string LastDowngradeTime
			{
				get
				{
					return lastDowngradeTime;
				}
				set	
				{
					lastDowngradeTime = value;
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

			public string ReplicaSetName
			{
				get
				{
					return replicaSetName;
				}
				set	
				{
					replicaSetName = value;
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

			public string StorageEngine
			{
				get
				{
					return storageEngine;
				}
				set	
				{
					storageEngine = value;
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

			public string ReadonlyReplicas
			{
				get
				{
					return readonlyReplicas;
				}
				set	
				{
					readonlyReplicas = value;
				}
			}

			public string ReplicationFactor
			{
				get
				{
					return replicationFactor;
				}
				set	
				{
					replicationFactor = value;
				}
			}

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

			public string CapacityUnit
			{
				get
				{
					return capacityUnit;
				}
				set	
				{
					capacityUnit = value;
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

			public List<DescribeDBInstanceAttribute_ReplicaSet> ReplicaSets
			{
				get
				{
					return replicaSets;
				}
				set	
				{
					replicaSets = value;
				}
			}

			public List<DescribeDBInstanceAttribute_Tag> Tags
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

			public List<DescribeDBInstanceAttribute_MongosAttribute> MongosList
			{
				get
				{
					return mongosList;
				}
				set	
				{
					mongosList = value;
				}
			}

			public List<DescribeDBInstanceAttribute_ShardAttribute> ShardList
			{
				get
				{
					return shardList;
				}
				set	
				{
					shardList = value;
				}
			}

			public List<DescribeDBInstanceAttribute_ConfigserverAttribute> ConfigserverList
			{
				get
				{
					return configserverList;
				}
				set	
				{
					configserverList = value;
				}
			}

			public class DescribeDBInstanceAttribute_ReplicaSet
			{

				private string vSwitchId;

				private string connectionPort;

				private string replicaSetRole;

				private string connectionDomain;

				private string vPCCloudInstanceId;

				private string networkType;

				private string vPCId;

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

				public string ConnectionPort
				{
					get
					{
						return connectionPort;
					}
					set	
					{
						connectionPort = value;
					}
				}

				public string ReplicaSetRole
				{
					get
					{
						return replicaSetRole;
					}
					set	
					{
						replicaSetRole = value;
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
			}

			public class DescribeDBInstanceAttribute_Tag
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

			public class DescribeDBInstanceAttribute_MongosAttribute
			{

				private string vpcCloudInstanceId;

				private int? maxIOPS;

				private string vSwitchId;

				private string nodeClass;

				private int? maxConnections;

				private int? port;

				private string vPCId;

				private string connectSting;

				private string nodeDescription;

				private string nodeId;

				private string status;

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

				public string NodeClass
				{
					get
					{
						return nodeClass;
					}
					set	
					{
						nodeClass = value;
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

				public string ConnectSting
				{
					get
					{
						return connectSting;
					}
					set	
					{
						connectSting = value;
					}
				}

				public string NodeDescription
				{
					get
					{
						return nodeDescription;
					}
					set	
					{
						nodeDescription = value;
					}
				}

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

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDBInstanceAttribute_ShardAttribute
			{

				private int? maxIOPS;

				private string connectString;

				private string nodeClass;

				private int? maxConnections;

				private int? port;

				private string nodeDescription;

				private string nodeId;

				private int? nodeStorage;

				private int? readonlyReplicas;

				private string status;

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

				public string ConnectString
				{
					get
					{
						return connectString;
					}
					set	
					{
						connectString = value;
					}
				}

				public string NodeClass
				{
					get
					{
						return nodeClass;
					}
					set	
					{
						nodeClass = value;
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

				public string NodeDescription
				{
					get
					{
						return nodeDescription;
					}
					set	
					{
						nodeDescription = value;
					}
				}

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

				public int? NodeStorage
				{
					get
					{
						return nodeStorage;
					}
					set	
					{
						nodeStorage = value;
					}
				}

				public int? ReadonlyReplicas
				{
					get
					{
						return readonlyReplicas;
					}
					set	
					{
						readonlyReplicas = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}

			public class DescribeDBInstanceAttribute_ConfigserverAttribute
			{

				private int? maxIOPS;

				private string connectString;

				private string nodeClass;

				private int? maxConnections;

				private int? port;

				private string nodeDescription;

				private string nodeId;

				private int? nodeStorage;

				private string status;

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

				public string ConnectString
				{
					get
					{
						return connectString;
					}
					set	
					{
						connectString = value;
					}
				}

				public string NodeClass
				{
					get
					{
						return nodeClass;
					}
					set	
					{
						nodeClass = value;
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

				public string NodeDescription
				{
					get
					{
						return nodeDescription;
					}
					set	
					{
						nodeDescription = value;
					}
				}

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

				public int? NodeStorage
				{
					get
					{
						return nodeStorage;
					}
					set	
					{
						nodeStorage = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}
		}
	}
}
