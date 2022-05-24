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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeSlowLogsResponse : AcsResponse
	{

		private string endTime;

		private string startTime;

		private string requestId;

		private int? pageRecordCount;

		private int? totalRecordCount;

		private string dBInstanceId;

		private int? pageNumber;

		private string engine;

		private List<DescribeSlowLogs_SQLSlowLog> items;

		[JsonProperty(PropertyName = "EndTime")]
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

		[JsonProperty(PropertyName = "StartTime")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "PageRecordCount")]
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

		[JsonProperty(PropertyName = "TotalRecordCount")]
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

		[JsonProperty(PropertyName = "DBInstanceId")]
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

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "Engine")]
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

		[JsonProperty(PropertyName = "Items")]
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

			private long? maxLastRowsAffectedCounts;

			private long? returnMaxRowCount;

			private string sQLText;

			private long? sQLServerMaxCpuTime;

			private string createTime;

			private long? avgLastRowsAffectedCounts;

			private long? minLastRowsAffectedCounts;

			private long? parseTotalRowCounts;

			private long? totalLockTimes;

			private long? mySQLTotalExecutionCounts;

			private long? sQLServerMinCpuTime;

			private string sQLHASH;

			private long? minIOWriteCounts;

			private long? parseMaxRowCount;

			private long? maxLogicalReadCounts;

			private long? mySQLTotalExecutionTimes;

			private long? sQLServerTotalExecutionCounts;

			private long? returnTotalRowCounts;

			private long? maxLockTime;

			private string dBName;

			private long? minRowsAffectedCounts;

			private long? totalLogicalReadCounts;

			private long? totalPhysicalReadCounts;

			private string reportTime;

			private long? maxPhysicalReadCounts;

			private long? sQLServerTotalCpuTime;

			private long? totalIOWriteCounts;

			private long? maxRowsAffectedCounts;

			private long? avgIOWriteCounts;

			private long? minPhysicalReadCounts;

			private long? slowLogId;

			private long? maxExecutionTime;

			private long? avgExecutionTime;

			private long? sQLServerAvgExecutionTime;

			private long? maxIOWriteCounts;

			private long? sQLServerAvgCpuTime;

			private long? totalLastRowsAffectedCounts;

			private long? avgLogicalReadCounts;

			private long? sQLServerMinExecutionTime;

			private string sQLIdStr;

			private long? sQLServerTotalExecutionTimes;

			private long? avgRowsAffectedCounts;

			private long? totalRowsAffectedCounts;

			private long? avgPhysicalReadCounts;

			private long? minLogicalReadCounts;

			[JsonProperty(PropertyName = "MaxLastRowsAffectedCounts")]
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

			[JsonProperty(PropertyName = "ReturnMaxRowCount")]
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

			[JsonProperty(PropertyName = "SQLText")]
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

			[JsonProperty(PropertyName = "SQLServerMaxCpuTime")]
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

			[JsonProperty(PropertyName = "CreateTime")]
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

			[JsonProperty(PropertyName = "AvgLastRowsAffectedCounts")]
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

			[JsonProperty(PropertyName = "MinLastRowsAffectedCounts")]
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

			[JsonProperty(PropertyName = "ParseTotalRowCounts")]
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

			[JsonProperty(PropertyName = "TotalLockTimes")]
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

			[JsonProperty(PropertyName = "MySQLTotalExecutionCounts")]
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

			[JsonProperty(PropertyName = "SQLServerMinCpuTime")]
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

			[JsonProperty(PropertyName = "SQLHASH")]
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

			[JsonProperty(PropertyName = "MinIOWriteCounts")]
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

			[JsonProperty(PropertyName = "ParseMaxRowCount")]
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

			[JsonProperty(PropertyName = "MaxLogicalReadCounts")]
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

			[JsonProperty(PropertyName = "MySQLTotalExecutionTimes")]
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

			[JsonProperty(PropertyName = "SQLServerTotalExecutionCounts")]
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

			[JsonProperty(PropertyName = "ReturnTotalRowCounts")]
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

			[JsonProperty(PropertyName = "MaxLockTime")]
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

			[JsonProperty(PropertyName = "DBName")]
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

			[JsonProperty(PropertyName = "MinRowsAffectedCounts")]
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

			[JsonProperty(PropertyName = "TotalLogicalReadCounts")]
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

			[JsonProperty(PropertyName = "TotalPhysicalReadCounts")]
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

			[JsonProperty(PropertyName = "ReportTime")]
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

			[JsonProperty(PropertyName = "MaxPhysicalReadCounts")]
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

			[JsonProperty(PropertyName = "SQLServerTotalCpuTime")]
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

			[JsonProperty(PropertyName = "TotalIOWriteCounts")]
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

			[JsonProperty(PropertyName = "MaxRowsAffectedCounts")]
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

			[JsonProperty(PropertyName = "AvgIOWriteCounts")]
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

			[JsonProperty(PropertyName = "MinPhysicalReadCounts")]
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

			[JsonProperty(PropertyName = "SlowLogId")]
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

			[JsonProperty(PropertyName = "MaxExecutionTime")]
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

			[JsonProperty(PropertyName = "AvgExecutionTime")]
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

			[JsonProperty(PropertyName = "SQLServerAvgExecutionTime")]
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

			[JsonProperty(PropertyName = "MaxIOWriteCounts")]
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

			[JsonProperty(PropertyName = "SQLServerAvgCpuTime")]
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

			[JsonProperty(PropertyName = "TotalLastRowsAffectedCounts")]
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

			[JsonProperty(PropertyName = "AvgLogicalReadCounts")]
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

			[JsonProperty(PropertyName = "SQLServerMinExecutionTime")]
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

			[JsonProperty(PropertyName = "SQLIdStr")]
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

			[JsonProperty(PropertyName = "SQLServerTotalExecutionTimes")]
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

			[JsonProperty(PropertyName = "AvgRowsAffectedCounts")]
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

			[JsonProperty(PropertyName = "TotalRowsAffectedCounts")]
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

			[JsonProperty(PropertyName = "AvgPhysicalReadCounts")]
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

			[JsonProperty(PropertyName = "MinLogicalReadCounts")]
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
		}
	}
}
