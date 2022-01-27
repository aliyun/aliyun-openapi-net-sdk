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

			private long? totalPhysicalReadCounts1;

			private long? avgPhysicalReadCounts;

			private long? maxPhysicalReadCounts;

			private long? minPhysicalReadCounts;

			private long? avgLogicalReadCounts;

			private long? maxLogicalReadCounts;

			private long? minLogicalReadCounts;

			private long? totalIOWriteCounts;

			private long? avgIOWriteCounts;

			private long? maxIOWriteCounts;

			private long? minIOWriteCounts;

			private long? totalRowsAffectedCounts;

			private long? avgRowsAffectedCounts;

			private long? maxRowsAffectedCounts;

			private long? minRowsAffectedCounts;

			private long? totalLastRowsAffectedCounts;

			private long? avgLastRowsAffectedCounts;

			private long? maxLastRowsAffectedCounts;

			private long? minLastRowsAffectedCounts;

			private long? sQLServerMinExecutionTime;

			private long? sQLServerAvgExecutionTime;

			private long? sQLServerTotalCpuTime;

			private long? sQLServerAvgCpuTime;

			private long? sQLServerMaxCpuTime;

			private long? sQLServerMinCpuTime;

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

			public long? TotalPhysicalReadCounts1
			{
				get
				{
					return totalPhysicalReadCounts1;
				}
				set	
				{
					totalPhysicalReadCounts1 = value;
				}
			}

			public long? AvgPhysicalReadCounts
			{
				get
				{
					return avgPhysicalReadCounts;
				}
				set	
				{
					avgPhysicalReadCounts = value;
				}
			}

			public long? MaxPhysicalReadCounts
			{
				get
				{
					return maxPhysicalReadCounts;
				}
				set	
				{
					maxPhysicalReadCounts = value;
				}
			}

			public long? MinPhysicalReadCounts
			{
				get
				{
					return minPhysicalReadCounts;
				}
				set	
				{
					minPhysicalReadCounts = value;
				}
			}

			public long? AvgLogicalReadCounts
			{
				get
				{
					return avgLogicalReadCounts;
				}
				set	
				{
					avgLogicalReadCounts = value;
				}
			}

			public long? MaxLogicalReadCounts
			{
				get
				{
					return maxLogicalReadCounts;
				}
				set	
				{
					maxLogicalReadCounts = value;
				}
			}

			public long? MinLogicalReadCounts
			{
				get
				{
					return minLogicalReadCounts;
				}
				set	
				{
					minLogicalReadCounts = value;
				}
			}

			public long? TotalIOWriteCounts
			{
				get
				{
					return totalIOWriteCounts;
				}
				set	
				{
					totalIOWriteCounts = value;
				}
			}

			public long? AvgIOWriteCounts
			{
				get
				{
					return avgIOWriteCounts;
				}
				set	
				{
					avgIOWriteCounts = value;
				}
			}

			public long? MaxIOWriteCounts
			{
				get
				{
					return maxIOWriteCounts;
				}
				set	
				{
					maxIOWriteCounts = value;
				}
			}

			public long? MinIOWriteCounts
			{
				get
				{
					return minIOWriteCounts;
				}
				set	
				{
					minIOWriteCounts = value;
				}
			}

			public long? TotalRowsAffectedCounts
			{
				get
				{
					return totalRowsAffectedCounts;
				}
				set	
				{
					totalRowsAffectedCounts = value;
				}
			}

			public long? AvgRowsAffectedCounts
			{
				get
				{
					return avgRowsAffectedCounts;
				}
				set	
				{
					avgRowsAffectedCounts = value;
				}
			}

			public long? MaxRowsAffectedCounts
			{
				get
				{
					return maxRowsAffectedCounts;
				}
				set	
				{
					maxRowsAffectedCounts = value;
				}
			}

			public long? MinRowsAffectedCounts
			{
				get
				{
					return minRowsAffectedCounts;
				}
				set	
				{
					minRowsAffectedCounts = value;
				}
			}

			public long? TotalLastRowsAffectedCounts
			{
				get
				{
					return totalLastRowsAffectedCounts;
				}
				set	
				{
					totalLastRowsAffectedCounts = value;
				}
			}

			public long? AvgLastRowsAffectedCounts
			{
				get
				{
					return avgLastRowsAffectedCounts;
				}
				set	
				{
					avgLastRowsAffectedCounts = value;
				}
			}

			public long? MaxLastRowsAffectedCounts
			{
				get
				{
					return maxLastRowsAffectedCounts;
				}
				set	
				{
					maxLastRowsAffectedCounts = value;
				}
			}

			public long? MinLastRowsAffectedCounts
			{
				get
				{
					return minLastRowsAffectedCounts;
				}
				set	
				{
					minLastRowsAffectedCounts = value;
				}
			}

			public long? SQLServerMinExecutionTime
			{
				get
				{
					return sQLServerMinExecutionTime;
				}
				set	
				{
					sQLServerMinExecutionTime = value;
				}
			}

			public long? SQLServerAvgExecutionTime
			{
				get
				{
					return sQLServerAvgExecutionTime;
				}
				set	
				{
					sQLServerAvgExecutionTime = value;
				}
			}

			public long? SQLServerTotalCpuTime
			{
				get
				{
					return sQLServerTotalCpuTime;
				}
				set	
				{
					sQLServerTotalCpuTime = value;
				}
			}

			public long? SQLServerAvgCpuTime
			{
				get
				{
					return sQLServerAvgCpuTime;
				}
				set	
				{
					sQLServerAvgCpuTime = value;
				}
			}

			public long? SQLServerMaxCpuTime
			{
				get
				{
					return sQLServerMaxCpuTime;
				}
				set	
				{
					sQLServerMaxCpuTime = value;
				}
			}

			public long? SQLServerMinCpuTime
			{
				get
				{
					return sQLServerMinCpuTime;
				}
				set	
				{
					sQLServerMinCpuTime = value;
				}
			}
		}
	}
}
