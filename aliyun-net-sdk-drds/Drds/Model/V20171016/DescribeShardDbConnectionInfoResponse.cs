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

namespace Aliyun.Acs.Drds.Model.V20171016
{
	public class DescribeShardDbConnectionInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private DescribeShardDbConnectionInfo_ConnectionInfo connectionInfo;

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

		public DescribeShardDbConnectionInfo_ConnectionInfo ConnectionInfo
		{
			get
			{
				return connectionInfo;
			}
			set	
			{
				connectionInfo = value;
			}
		}

		public class DescribeShardDbConnectionInfo_ConnectionInfo
		{

			private string instanceName;

			private string instanceUrl;

			private string subDbName;

			private string dbStatus;

			private string dbType;

			private int? minPoolSize;

			private int? maxPoolSize;

			private int? idleTimeOut;

			private int? blockingTimeout;

			private string connectionProperties;

			private int? preparedStatementCacheSize;

			private string userName;

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

			public string InstanceUrl
			{
				get
				{
					return instanceUrl;
				}
				set	
				{
					instanceUrl = value;
				}
			}

			public string SubDbName
			{
				get
				{
					return subDbName;
				}
				set	
				{
					subDbName = value;
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
		}
	}
}