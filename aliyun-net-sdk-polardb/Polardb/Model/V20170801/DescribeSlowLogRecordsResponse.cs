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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeSlowLogRecordsResponse : AcsResponse
	{

		private string requestId;

		private string dBClusterId;

		private string engine;

		private int? totalRecordCount;

		private int? pageNumber;

		private int? pageRecordCount;

		private List<DescribeSlowLogRecords_SQLSlowRecord> items;

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

		public List<DescribeSlowLogRecords_SQLSlowRecord> Items
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

		public class DescribeSlowLogRecords_SQLSlowRecord
		{

			private string hostAddress;

			private string dBName;

			private string sQLText;

			private long? queryTimes;

			private long? lockTimes;

			private long? parseRowCounts;

			private long? returnRowCounts;

			private string executionStartTime;

			private string dBNodeId;

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

			public long? QueryTimes
			{
				get
				{
					return queryTimes;
				}
				set	
				{
					queryTimes = value;
				}
			}

			public long? LockTimes
			{
				get
				{
					return lockTimes;
				}
				set	
				{
					lockTimes = value;
				}
			}

			public long? ParseRowCounts
			{
				get
				{
					return parseRowCounts;
				}
				set	
				{
					parseRowCounts = value;
				}
			}

			public long? ReturnRowCounts
			{
				get
				{
					return returnRowCounts;
				}
				set	
				{
					returnRowCounts = value;
				}
			}

			public string ExecutionStartTime
			{
				get
				{
					return executionStartTime;
				}
				set	
				{
					executionStartTime = value;
				}
			}

			public string DBNodeId
			{
				get
				{
					return dBNodeId;
				}
				set	
				{
					dBNodeId = value;
				}
			}
		}
	}
}
