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

			private string dBInstanceId;

			private string payType;

			private string dBInstanceClassType;

			private string regionId;

			private string connectionString;

			private string port;

			private string engine;

			private string engineVersion;

			private string dBInstanceClass;

			private int? dBInstanceCpuCores;

			private long? dBInstanceMemory;

			private long? dBInstanceStorage;

			private long? dBInstanceDiskMBPS;

			private string hostType;

			private string dBInstanceGroupCount;

			private string dBInstanceNetType;

			private string dBInstanceStatus;

			private string dBInstanceDescription;

			private string lockMode;

			private string lockReason;

			private string readDelayTime;

			private string creationTime;

			private string expireTime;

			private string maintainStartTime;

			private string maintainEndTime;

			private string availabilityValue;

			private int? maxConnections;

			private string securityIPList;

			private string zoneId;

			private string instanceNetworkType;

			private string vpcId;

			private string connectionMode;

			private List<DescribeDBInstanceAttribute_Tag> tags;

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
