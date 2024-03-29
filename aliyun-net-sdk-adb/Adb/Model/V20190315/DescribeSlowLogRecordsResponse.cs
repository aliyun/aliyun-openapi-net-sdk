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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeSlowLogRecordsResponse : AcsResponse
	{

		private string totalCount;

		private string pageSize;

		private string requestId;

		private string pageNumber;

		private string dBClusterId;

		private List<DescribeSlowLogRecords_SlowLogRecord> items;

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

			private long? scanTime;

			private string sQLText;

			private string outputSize;

			private string peakMemoryUsage;

			private string state;

			private long? wallTime;

			private string scanSize;

			private string executionStartTime;

			private long? queryTime;

			private long? returnRowCounts;

			private long? scanRows;

			private long? parseRowCounts;

			private string dBName;

			private long? planningTime;

			private long? queueTime;

			private string userName;

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

			public long? ScanTime
			{
				get
				{
					return scanTime;
				}
				set	
				{
					scanTime = value;
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

			public string OutputSize
			{
				get
				{
					return outputSize;
				}
				set	
				{
					outputSize = value;
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

			public long? WallTime
			{
				get
				{
					return wallTime;
				}
				set	
				{
					wallTime = value;
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

			public long? ScanRows
			{
				get
				{
					return scanRows;
				}
				set	
				{
					scanRows = value;
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

			public long? PlanningTime
			{
				get
				{
					return planningTime;
				}
				set	
				{
					planningTime = value;
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
