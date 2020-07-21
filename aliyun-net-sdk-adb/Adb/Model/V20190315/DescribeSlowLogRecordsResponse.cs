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
	public class DescribeSlowLogRecordsResponse : AcsResponse
	{

		private string requestId;

		private string totalCount;

		private string pageNumber;

		private string pageSize;

		private string dBClusterId;

		private List<DescribeSlowLogRecords_SlowLogRecord> items;

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

		public List<DescribeSlowLogRecords_SlowLogRecord> Items
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

		public class DescribeSlowLogRecords_SlowLogRecord
		{

			private string hostAddress;

			private string dBName;

			private string sQLText;

			private long? queryTime;

			private long? returnRowCounts;

			private string executionStartTime;

			private long? parseRowCounts;

			private string processID;

			private string userName;

			private string scanSize;

			private string peakMemoryUsage;

			private long? queueTime;

			private string state;

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

			public long? QueryTime
			{
				get
				{
					return queryTime;
				}
				set	
				{
					queryTime = value;
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

			public string ScanSize
			{
				get
				{
					return scanSize;
				}
				set	
				{
					scanSize = value;
				}
			}

			public string PeakMemoryUsage
			{
				get
				{
					return peakMemoryUsage;
				}
				set	
				{
					peakMemoryUsage = value;
				}
			}

			public long? QueueTime
			{
				get
				{
					return queueTime;
				}
				set	
				{
					queueTime = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}
		}
	}
}
