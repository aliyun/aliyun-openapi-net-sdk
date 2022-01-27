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

namespace Aliyun.Acs.polardbx.Model.V20200202
{
	public class DescribeDBInstanceAttributeResponse : AcsResponse
	{

		private string requestId;

		private DescribeDBInstanceAttribute_DBInstance dBInstance;

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

		public DescribeDBInstanceAttribute_DBInstance DBInstance
		{
			get
			{
				return dBInstance;
			}
			set	
			{
				dBInstance = value;
			}
		}

		public class DescribeDBInstanceAttribute_DBInstance
		{

			private string status;

			private string description;

			private string zoneId;

			private string vPCId;

			private string createTime;

			private string expired;

			private string payType;

			private string dBType;

			private string lockMode;

			private string storageUsed;

			private string dBVersion;

			private string network;

			private string regionId;

			private string engine;

			private string id;

			private string connectionString;

			private string port;

			private string minorVersion;

			private string latestMinorVersion;

			private int? dBNodeCount;

			private string dBInstanceType;

			private string maintainStartTime;

			private string maintainEndTime;

			private string vSwitchId;

			private string commodityCode;

			private string expireDate;

			private string type;

			private string dBNodeClass;

			private List<DescribeDBInstanceAttribute_DBNode> dBNodes;

			private List<DescribeDBInstanceAttribute_ConnAddr> connAddrs;

			private List<string> readDBInstances;

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

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
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

			public string StorageUsed
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

			public string Network
			{
				get
				{
					return network;
				}
				set	
				{
					network = value;
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

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
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

			public string LatestMinorVersion
			{
				get
				{
					return latestMinorVersion;
				}
				set	
				{
					latestMinorVersion = value;
				}
			}

			public int? DBNodeCount
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

			public string ExpireDate
			{
				get
				{
					return expireDate;
				}
				set	
				{
					expireDate = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
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

			public List<DescribeDBInstanceAttribute_DBNode> DBNodes
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

			public List<DescribeDBInstanceAttribute_ConnAddr> ConnAddrs
			{
				get
				{
					return connAddrs;
				}
				set	
				{
					connAddrs = value;
				}
			}

			public List<string> ReadDBInstances
			{
				get
				{
					return readDBInstances;
				}
				set	
				{
					readDBInstances = value;
				}
			}

			public class DescribeDBInstanceAttribute_DBNode
			{

				private string id;

				private string nodeClass;

				private string regionId;

				private string zoneId;

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
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
			}

			public class DescribeDBInstanceAttribute_ConnAddr
			{

				private string connectionString;

				private string port;

				private string type;

				private string vPCId;

				private string vSwitchId;

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

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
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
			}
		}
	}
}
