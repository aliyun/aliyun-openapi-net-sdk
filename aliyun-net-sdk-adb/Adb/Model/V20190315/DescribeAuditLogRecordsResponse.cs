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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeAuditLogRecordsResponse : AcsResponse
	{

		private string requestId;

		private string totalCount;

		private string pageNumber;

		private string pageSize;

		private string dBClusterId;

		private List<DescribeAuditLogRecords_SlowLogRecord> items;

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

		public string TotalCount
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

		public string PageNumber
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

		public string PageSize
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

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
			}
		}

		public List<DescribeAuditLogRecords_SlowLogRecord> Items
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

		public class DescribeAuditLogRecords_SlowLogRecord
		{

			private string hostAddress;

			private string dBName;

			private string sQLText;

			private string sQLType;

			private string connId;

			private string executeTime;

			private string succeed;

			private string totalTime;

			private string processID;

			public string HostAddress
			{
				get
				{
					return hostAddress;
				}
				set	
				{
					hostAddress = value;
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

			public string SQLText
			{
				get
				{
					return sQLText;
				}
				set	
				{
					sQLText = value;
				}
			}

			public string SQLType
			{
				get
				{
					return sQLType;
				}
				set	
				{
					sQLType = value;
				}
			}

			public string ConnId
			{
				get
				{
					return connId;
				}
				set	
				{
					connId = value;
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

			public string Succeed
			{
				get
				{
					return succeed;
				}
				set	
				{
					succeed = value;
				}
			}

			public string TotalTime
			{
				get
				{
					return totalTime;
				}
				set	
				{
					totalTime = value;
				}
			}

			public string ProcessID
			{
				get
				{
					return processID;
				}
				set	
				{
					processID = value;
				}
			}
		}
	}
}
