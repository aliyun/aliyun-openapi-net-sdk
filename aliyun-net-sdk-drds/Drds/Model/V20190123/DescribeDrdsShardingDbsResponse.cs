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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeDrdsShardingDbsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<DescribeDrdsShardingDbs_ShardingDb> shardingDbs;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<DescribeDrdsShardingDbs_ShardingDb> ShardingDbs
		{
			get
			{
				return shardingDbs;
			}
			set	
			{
				shardingDbs = value;
			}
		}

		public class DescribeDrdsShardingDbs_ShardingDb
		{

			private string shardingDbName;

			private string dbInstanceId;

			private string groupName;

			private string dbStatus;

			private string dbType;

			private int? minPoolSize;

			private int? maxPoolSize;

			private int? idleTimeOut;

			private int? blockingTimeout;

			private string connectionProperties;

			private int? preparedStatementCacheSize;

			private string userName;

			private string connectUrl;

			public string ShardingDbName
			{
				get
				{
					return shardingDbName;
				}
				set	
				{
					shardingDbName = value;
				}
			}

			public string DbInstanceId
			{
				get
				{
					return dbInstanceId;
				}
				set	
				{
					dbInstanceId = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}

			public string DbStatus
			{
				get
				{
					return dbStatus;
				}
				set	
				{
					dbStatus = value;
				}
			}

			public string DbType
			{
				get
				{
					return dbType;
				}
				set	
				{
					dbType = value;
				}
			}

			public int? MinPoolSize
			{
				get
				{
					return minPoolSize;
				}
				set	
				{
					minPoolSize = value;
				}
			}

			public int? MaxPoolSize
			{
				get
				{
					return maxPoolSize;
				}
				set	
				{
					maxPoolSize = value;
				}
			}

			public int? IdleTimeOut
			{
				get
				{
					return idleTimeOut;
				}
				set	
				{
					idleTimeOut = value;
				}
			}

			public int? BlockingTimeout
			{
				get
				{
					return blockingTimeout;
				}
				set	
				{
					blockingTimeout = value;
				}
			}

			public string ConnectionProperties
			{
				get
				{
					return connectionProperties;
				}
				set	
				{
					connectionProperties = value;
				}
			}

			public int? PreparedStatementCacheSize
			{
				get
				{
					return preparedStatementCacheSize;
				}
				set	
				{
					preparedStatementCacheSize = value;
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

			public string ConnectUrl
			{
				get
				{
					return connectUrl;
				}
				set	
				{
					connectUrl = value;
				}
			}
		}
	}
}
