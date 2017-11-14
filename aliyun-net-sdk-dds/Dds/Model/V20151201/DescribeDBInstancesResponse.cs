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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeDBInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeDBInstances_DBInstance> dBInstances;

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

		public List<DescribeDBInstances_DBInstance> DBInstances
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

		public class DescribeDBInstances_DBInstance
		{

			private string dBInstanceId;

			private string dBInstanceDescription;

			private string regionId;

			private string zoneId;

			private string engine;

			private string engineVersion;

			private string dBInstanceClass;

			private int? dBInstanceStorage;

			private string dBInstanceStatus;

			private string lockMode;

			private string chargeType;

			private string networkType;

			private string creationTime;

			private string expireTime;

			private string dBInstanceType;

			private int? lastDowngradeTime;

			private List<DescribeDBInstances_MongosAttribute> mongosList;

			private List<DescribeDBInstances_ShardAttribute> shardList;

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

			public int? LastDowngradeTime
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

			public List<DescribeDBInstances_MongosAttribute> MongosList
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

			public List<DescribeDBInstances_ShardAttribute> ShardList
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

			public class DescribeDBInstances_MongosAttribute
			{

				private string nodeId;

				private string nodeDescription;

				private string nodeClass;

				private string connectSting;

				private int? port;

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
			}

			public class DescribeDBInstances_ShardAttribute
			{

				private string nodeId;

				private string nodeDescription;

				private string nodeClass;

				private int? nodeStorage;

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
			}
		}
	}
}