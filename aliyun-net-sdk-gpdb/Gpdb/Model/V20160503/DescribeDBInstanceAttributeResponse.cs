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

namespace Aliyun.Acs.gpdb.Model.V20160503
{
	public class DescribeDBInstanceAttributeResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDBInstanceAttribute_DBInstanceAttribute> items;

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

		public List<DescribeDBInstanceAttribute_DBInstanceAttribute> Items
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

		public class DescribeDBInstanceAttribute_DBInstanceAttribute
		{

			private string vpcId;

			private string creationTime;

			private int? dBInstanceCpuCores;

			private int? segmentCounts;

			private int? storagePerNode;

			private long? dBInstanceMemory;

			private string hostType;

			private string payType;

			private string storageType;

			private string availabilityValue;

			private string readDelayTime;

			private int? cpuCoresPerNode;

			private string port;

			private string connectionMode;

			private string lockMode;

			private string engineVersion;

			private string storageUnit;

			private int? memoryPerNode;

			private string connectionString;

			private string instanceNetworkType;

			private string securityIPList;

			private string memoryUnit;

			private string dBInstanceClassType;

			private string dBInstanceDescription;

			private string dBInstanceGroupCount;

			private string expireTime;

			private string dBInstanceNetType;

			private string maintainStartTime;

			private string maintainEndTime;

			private string lockReason;

			private string dBInstanceStatus;

			private string regionId;

			private long? dBInstanceDiskMBPS;

			private long? dBInstanceStorage;

			private string zoneId;

			private int? maxConnections;

			private string dBInstanceId;

			private string dBInstanceClass;

			private string engine;

			private string dBInstanceCategory;

			private int? cpuCores;

			private long? memorySize;

			private long? storageSize;

			private int? segNodeNum;

			private int? masterNodeNum;

			private string dBInstanceMode;

			private string minorVersion;

			private bool? supportRestore;

			private string vSwitchId;

			private string encryptionKey;

			private string encryptionType;

			private List<DescribeDBInstanceAttribute_Tag> tags;

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

			public int? DBInstanceCpuCores
			{
				get
				{
					return dBInstanceCpuCores;
				}
				set	
				{
					dBInstanceCpuCores = value;
				}
			}

			public int? SegmentCounts
			{
				get
				{
					return segmentCounts;
				}
				set	
				{
					segmentCounts = value;
				}
			}

			public int? StoragePerNode
			{
				get
				{
					return storagePerNode;
				}
				set	
				{
					storagePerNode = value;
				}
			}

			public long? DBInstanceMemory
			{
				get
				{
					return dBInstanceMemory;
				}
				set	
				{
					dBInstanceMemory = value;
				}
			}

			public string HostType
			{
				get
				{
					return hostType;
				}
				set	
				{
					hostType = value;
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

			public string ReadDelayTime
			{
				get
				{
					return readDelayTime;
				}
				set	
				{
					readDelayTime = value;
				}
			}

			public int? CpuCoresPerNode
			{
				get
				{
					return cpuCoresPerNode;
				}
				set	
				{
					cpuCoresPerNode = value;
				}
			}

			public string Port
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

			public string StorageUnit
			{
				get
				{
					return storageUnit;
				}
				set	
				{
					storageUnit = value;
				}
			}

			public int? MemoryPerNode
			{
				get
				{
					return memoryPerNode;
				}
				set	
				{
					memoryPerNode = value;
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

			public string InstanceNetworkType
			{
				get
				{
					return instanceNetworkType;
				}
				set	
				{
					instanceNetworkType = value;
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

			public string MemoryUnit
			{
				get
				{
					return memoryUnit;
				}
				set	
				{
					memoryUnit = value;
				}
			}

			public string DBInstanceClassType
			{
				get
				{
					return dBInstanceClassType;
				}
				set	
				{
					dBInstanceClassType = value;
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

			public string DBInstanceGroupCount
			{
				get
				{
					return dBInstanceGroupCount;
				}
				set	
				{
					dBInstanceGroupCount = value;
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

			public string DBInstanceNetType
			{
				get
				{
					return dBInstanceNetType;
				}
				set	
				{
					dBInstanceNetType = value;
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

			public long? DBInstanceDiskMBPS
			{
				get
				{
					return dBInstanceDiskMBPS;
				}
				set	
				{
					dBInstanceDiskMBPS = value;
				}
			}

			public long? DBInstanceStorage
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

			public string DBInstanceCategory
			{
				get
				{
					return dBInstanceCategory;
				}
				set	
				{
					dBInstanceCategory = value;
				}
			}

			public int? CpuCores
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

			public long? MemorySize
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

			public long? StorageSize
			{
				get
				{
					return storageSize;
				}
				set	
				{
					storageSize = value;
				}
			}

			public int? SegNodeNum
			{
				get
				{
					return segNodeNum;
				}
				set	
				{
					segNodeNum = value;
				}
			}

			public int? MasterNodeNum
			{
				get
				{
					return masterNodeNum;
				}
				set	
				{
					masterNodeNum = value;
				}
			}

			public string DBInstanceMode
			{
				get
				{
					return dBInstanceMode;
				}
				set	
				{
					dBInstanceMode = value;
				}
			}

			public string MinorVersion
			{
				get
				{
					return minorVersion;
				}
				set	
				{
					minorVersion = value;
				}
			}

			public bool? SupportRestore
			{
				get
				{
					return supportRestore;
				}
				set	
				{
					supportRestore = value;
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

			public string EncryptionKey
			{
				get
				{
					return encryptionKey;
				}
				set	
				{
					encryptionKey = value;
				}
			}

			public string EncryptionType
			{
				get
				{
					return encryptionType;
				}
				set	
				{
					encryptionType = value;
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
		}
	}
}
