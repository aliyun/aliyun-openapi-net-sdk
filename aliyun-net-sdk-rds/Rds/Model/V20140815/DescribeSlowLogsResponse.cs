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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeSlowLogsResponse : AcsResponse
	{

		private string requestId;

		private string dBInstanceId;

		private string engine;

		private string startTime;

		private string endTime;

		private int? totalRecordCount;

		private int? pageNumber;

		private int? pageRecordCount;

		private List<DescribeSlowLogs_SQLSlowLog> items;

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

			private long? slowLogId;

			private string sQLHASH;

			private string sQLIdStr;

			private string dBName;

			private string sQLText;

			private long? mySQLTotalExecutionCounts;

			private long? mySQLTotalExecutionTimes;

			private long? totalLockTimes;

			private long? maxLockTime;

			private long? parseTotalRowCounts;

			private long? parseMaxRowCount;

			private long? returnTotalRowCounts;

			private long? returnMaxRowCount;

			private string createTime;

			private long? sQLServerTotalExecutionCounts;

			private long? sQLServerTotalExecutionTimes;

			private long? totalLogicalReadCounts;

			private long? totalPhysicalReadCounts;

			private string reportTime;

			private long? maxExecutionTime;

			private long? avgExecutionTime;

			public long? SlowLogId
			{
				get
				{
					return slowLogId;
				}
				set	
				{
					slowLogId = value;
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

			public string SQLIdStr
			{
				get
				{
					return sQLIdStr;
				}
				set	
				{
					sQLIdStr = value;
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

			public long? MySQLTotalExecutionCounts
			{
				get
				{
					return mySQLTotalExecutionCounts;
				}
				set	
				{
					mySQLTotalExecutionCounts = value;
				}
			}

			public long? MySQLTotalExecutionTimes
			{
				get
				{
					return mySQLTotalExecutionTimes;
				}
				set	
				{
					mySQLTotalExecutionTimes = value;
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

			public long? SQLServerTotalExecutionCounts
			{
				get
				{
					return sQLServerTotalExecutionCounts;
				}
				set	
				{
					sQLServerTotalExecutionCounts = value;
				}
			}

			public long? SQLServerTotalExecutionTimes
			{
				get
				{
					return sQLServerTotalExecutionTimes;
				}
				set	
				{
					sQLServerTotalExecutionTimes = value;
				}
			}

			public long? TotalLogicalReadCounts
			{
				get
				{
					return totalLogicalReadCounts;
				}
				set	
				{
					totalLogicalReadCounts = value;
				}
			}

			public long? TotalPhysicalReadCounts
			{
				get
				{
					return totalPhysicalReadCounts;
				}
				set	
				{
					totalPhysicalReadCounts = value;
				}
			}

			public string ReportTime
			{
				get
				{
					return reportTime;
				}
				set	
				{
					reportTime = value;
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

			public long? AvgExecutionTime
			{
				get
				{
					return avgExecutionTime;
				}
				set	
				{
					avgExecutionTime = value;
				}
			}
		}
	}
}