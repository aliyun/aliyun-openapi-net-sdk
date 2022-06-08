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
	public class DescribeSlowLogRecordsResponse : AcsResponse
	{

		private long? rowsAffectedCount;

		private int? pageRecordCount;

		private long? writesIOCount;

		private string sQLHash;

		private long? logicalIORead;

		private string requestId;

		private long? physicalIORead;

		private int? totalRecordCount;

		private string dBInstanceId;

		private string engine;

		private int? pageNumber;

		private long? cPUTime;

		private string userName;

		private long? lastRowsAffectedCount;

		private List<DescribeSlowLogRecords_SQLSlowRecord> items;

		[JsonProperty(PropertyName = "RowsAffectedCount")]
		public long? RowsAffectedCount
		{
			get
			{
				return rowsAffectedCount;
			}
			set	
			{
				rowsAffectedCount = value;
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

		[JsonProperty(PropertyName = "WritesIOCount")]
		public long? WritesIOCount
		{
			get
			{
				return writesIOCount;
			}
			set	
			{
				writesIOCount = value;
			}
		}

		[JsonProperty(PropertyName = "SQLHash")]
		public string SQLHash
		{
			get
			{
				return sQLHash;
			}
			set	
			{
				sQLHash = value;
			}
		}

		[JsonProperty(PropertyName = "LogicalIORead")]
		public long? LogicalIORead
		{
			get
			{
				return logicalIORead;
			}
			set	
			{
				logicalIORead = value;
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

		[JsonProperty(PropertyName = "PhysicalIORead")]
		public long? PhysicalIORead
		{
			get
			{
				return physicalIORead;
			}
			set	
			{
				physicalIORead = value;
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

		[JsonProperty(PropertyName = "CPUTime")]
		public long? CPUTime
		{
			get
			{
				return cPUTime;
			}
			set	
			{
				cPUTime = value;
			}
		}

		[JsonProperty(PropertyName = "UserName")]
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

		[JsonProperty(PropertyName = "LastRowsAffectedCount")]
		public long? LastRowsAffectedCount
		{
			get
			{
				return lastRowsAffectedCount;
			}
			set	
			{
				lastRowsAffectedCount = value;
			}
		}

		[JsonProperty(PropertyName = "Items")]
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

			private long? rowsAffectedCount;

			private long? queryTimes;

			private string sQLText;

			private long? cpuTime;

			private long? queryTimeMS;

			private string applicationName;

			private long? lockTimes;

			private string executionStartTime;

			private long? logicalIORead;

			private long? writeIOCount;

			private long? physicalIORead;

			private long? returnRowCounts;

			private long? parseRowCounts;

			private string dBName;

			private string clientHostName;

			private string userName;

			private long? lastRowsAffectedCount;

			[JsonProperty(PropertyName = "HostAddress")]
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

			[JsonProperty(PropertyName = "RowsAffectedCount")]
			public long? RowsAffectedCount
			{
				get
				{
					return rowsAffectedCount;
				}
				set	
				{
					rowsAffectedCount = value;
				}
			}

			[JsonProperty(PropertyName = "QueryTimes")]
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

			[JsonProperty(PropertyName = "CpuTime")]
			public long? CpuTime
			{
				get
				{
					return cpuTime;
				}
				set	
				{
					cpuTime = value;
				}
			}

			[JsonProperty(PropertyName = "QueryTimeMS")]
			public long? QueryTimeMS
			{
				get
				{
					return queryTimeMS;
				}
				set	
				{
					queryTimeMS = value;
				}
			}

			[JsonProperty(PropertyName = "ApplicationName")]
			public string ApplicationName
			{
				get
				{
					return applicationName;
				}
				set	
				{
					applicationName = value;
				}
			}

			[JsonProperty(PropertyName = "LockTimes")]
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

			[JsonProperty(PropertyName = "ExecutionStartTime")]
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

			[JsonProperty(PropertyName = "LogicalIORead")]
			public long? LogicalIORead
			{
				get
				{
					return logicalIORead;
				}
				set	
				{
					logicalIORead = value;
				}
			}

			[JsonProperty(PropertyName = "WriteIOCount")]
			public long? WriteIOCount
			{
				get
				{
					return writeIOCount;
				}
				set	
				{
					writeIOCount = value;
				}
			}

			[JsonProperty(PropertyName = "PhysicalIORead")]
			public long? PhysicalIORead
			{
				get
				{
					return physicalIORead;
				}
				set	
				{
					physicalIORead = value;
				}
			}

			[JsonProperty(PropertyName = "ReturnRowCounts")]
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

			[JsonProperty(PropertyName = "ParseRowCounts")]
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

			[JsonProperty(PropertyName = "ClientHostName")]
			public string ClientHostName
			{
				get
				{
					return clientHostName;
				}
				set	
				{
					clientHostName = value;
				}
			}

			[JsonProperty(PropertyName = "UserName")]
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

			[JsonProperty(PropertyName = "LastRowsAffectedCount")]
			public long? LastRowsAffectedCount
			{
				get
				{
					return lastRowsAffectedCount;
				}
				set	
				{
					lastRowsAffectedCount = value;
				}
			}
		}
	}
}
