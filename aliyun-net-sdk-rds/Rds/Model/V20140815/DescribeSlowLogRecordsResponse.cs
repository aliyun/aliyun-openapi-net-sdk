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
	public class DescribeSlowLogRecordsResponse : AcsResponse
	{

		private string requestId;

		private string dBInstanceId;

		private string engine;

		private int? totalRecordCount;

		private int? pageNumber;

		private int? pageRecordCount;

		private string sQLHash;

		private long? cPUTime;

		private long? logicalIORead;

		private long? physicalIORead;

		private long? writesIOCount;

		private long? rowsAffectedCount;

		private long? lastRowsAffectedCount;

		private string userName;

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

			private long? queryTimeMS;

			private long? cpuTime;

			private long? logicalIORead;

			private long? physicalIORead;

			private long? writeIOCount;

			private long? rowsAffectedCount;

			private long? lastRowsAffectedCount;

			private string userName;

			private string applicationName;

			private string clientHostName;

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
		}
	}
}
