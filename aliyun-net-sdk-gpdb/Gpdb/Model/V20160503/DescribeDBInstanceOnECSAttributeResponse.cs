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
	public class DescribeDBInstanceOnECSAttributeResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDBInstanceOnECSAttribute_DBInstanceAttribute> items;

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

		public List<DescribeDBInstanceOnECSAttribute_DBInstanceAttribute> Items
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

		public class DescribeDBInstanceOnECSAttribute_DBInstanceAttribute
		{

			private string creationTime;

			private string vpcId;

			private string encryptionType;

			private string instanceDeployType;

			private string payType;

			private string storageType;

			private string connectionMode;

			private string port;

			private string lockMode;

			private string engineVersion;

			private int? memorySize;

			private int? segNodeNum;

			private string connectionString;

			private string instanceNetworkType;

			private string encryptionKey;

			private string dBInstanceDescription;

			private int? cpuCores;

			private string expireTime;

			private string dBInstanceStatus;

			private int? storageSize;

			private string regionId;

			private string vSwitchId;

			private string zoneId;

			private string dBInstanceId;

			private string engine;

			private string dBInstanceClass;

			private bool? supportRestore;

			private string minorVersion;

			private int? masterNodeNum;

			private string dBInstanceCategory;

			private List<DescribeDBInstanceOnECSAttribute_Tag> tags;

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

			public string InstanceDeployType
			{
				get
				{
					return instanceDeployType;
				}
				set	
				{
					instanceDeployType = value;
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

			public int? MemorySize
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

			public int? StorageSize
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

			public List<DescribeDBInstanceOnECSAttribute_Tag> Tags
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

			public class DescribeDBInstanceOnECSAttribute_Tag
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
