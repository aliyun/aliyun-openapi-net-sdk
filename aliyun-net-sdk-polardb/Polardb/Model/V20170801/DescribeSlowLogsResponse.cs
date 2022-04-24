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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeSlowLogsResponse : AcsResponse
	{

		private int? totalRecordCount;

		private int? pageRecordCount;

		private string endTime;

		private string requestId;

		private int? pageNumber;

		private string startTime;

		private string dBClusterId;

		private string engine;

		private List<DescribeSlowLogs_SQLSlowLog> items;

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

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
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

		public List<DescribeSlowLogs_SQLSlowLog> Items
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

		public class DescribeSlowLogs_SQLSlowLog
		{

			private string sQLText;

			private long? returnMaxRowCount;

			private string createTime;

			private long? maxExecutionTime;

			private long? parseTotalRowCounts;

			private long? totalLockTimes;

			private long? totalExecutionTimes;

			private string dBNodeId;

			private string sQLHASH;

			private long? parseMaxRowCount;

			private long? maxLockTime;

			private long? returnTotalRowCounts;

			private string dBName;

			private long? totalExecutionCounts;

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

			public long? ReturnMaxRowCount
			{
				get
				{
					return returnMaxRowCount;
				}
				set	
				{
					returnMaxRowCount = value;
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

			public long? MaxExecutionTime
			{
				get
				{
					return maxExecutionTime;
				}
				set	
				{
					maxExecutionTime = value;
				}
			}

			public long? ParseTotalRowCounts
			{
				get
				{
					return parseTotalRowCounts;
				}
				set	
				{
					parseTotalRowCounts = value;
				}
			}

			public long? TotalLockTimes
			{
				get
				{
					return totalLockTimes;
				}
				set	
				{
					totalLockTimes = value;
				}
			}

			public long? TotalExecutionTimes
			{
				get
				{
					return totalExecutionTimes;
				}
				set	
				{
					totalExecutionTimes = value;
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

			public string SQLHASH
			{
				get
				{
					return sQLHASH;
				}
				set	
				{
					sQLHASH = value;
				}
			}

			public long? ParseMaxRowCount
			{
				get
				{
					return parseMaxRowCount;
				}
				set	
				{
					parseMaxRowCount = value;
				}
			}

			public long? MaxLockTime
			{
				get
				{
					return maxLockTime;
				}
				set	
				{
					maxLockTime = value;
				}
			}

			public long? ReturnTotalRowCounts
			{
				get
				{
					return returnTotalRowCounts;
				}
				set	
				{
					returnTotalRowCounts = value;
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

			public long? TotalExecutionCounts
			{
				get
				{
					return totalExecutionCounts;
				}
				set	
				{
					totalExecutionCounts = value;
				}
			}
		}
	}
}
