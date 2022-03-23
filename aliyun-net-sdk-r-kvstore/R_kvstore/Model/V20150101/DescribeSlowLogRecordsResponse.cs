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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeSlowLogRecordsResponse : AcsResponse
	{

		private string startTime;

		private string requestId;

		private int? pageRecordCount;

		private int? totalRecordCount;

		private int? pageSize;

		private string instanceId;

		private string engine;

		private int? pageNumber;

		private List<DescribeSlowLogRecords_LogRecords> items;

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
			}
		}

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

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
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

		public List<DescribeSlowLogRecords_LogRecords> Items
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

		public class DescribeSlowLogRecords_LogRecords
		{

			private string account;

			private long? elapsedTime;

			private string command;

			private string dBName;

			private string executeTime;

			private string dataBaseName;

			private string nodeId;

			private string accountName;

			private string iPAddress;

			public string Account
			{
				get
				{
					return account;
				}
				set	
				{
					account = value;
				}
			}

			public long? ElapsedTime
			{
				get
				{
					return elapsedTime;
				}
				set	
				{
					elapsedTime = value;
				}
			}

			public string Command
			{
				get
				{
					return command;
				}
				set	
				{
					command = value;
				}
			}

			public string DBName
			{
				get
				{
					return dBName;
				}
				set	
				{
					dBName = value;
				}
			}

			public string ExecuteTime
			{
				get
				{
					return executeTime;
				}
				set	
				{
					executeTime = value;
				}
			}

			public string DataBaseName
			{
				get
				{
					return dataBaseName;
				}
				set	
				{
					dataBaseName = value;
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

			public string AccountName
			{
				get
				{
					return accountName;
				}
				set	
				{
					accountName = value;
				}
			}

			public string IPAddress
			{
				get
				{
					return iPAddress;
				}
				set	
				{
					iPAddress = value;
				}
			}
		}
	}
}
