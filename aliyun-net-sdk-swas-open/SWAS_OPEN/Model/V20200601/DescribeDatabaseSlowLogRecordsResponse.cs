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

namespace Aliyun.Acs.SWAS_OPEN.Model.V20200601
{
	public class DescribeDatabaseSlowLogRecordsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private long? physicalIORead;

		private string engine;

		private List<DescribeDatabaseSlowLogRecords_SlowLog> slowLogs;

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

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
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

		[JsonProperty(PropertyName = "TotalCount")]
		public int? TotalCount
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

		[JsonProperty(PropertyName = "SlowLogs")]
		public List<DescribeDatabaseSlowLogRecords_SlowLog> SlowLogs
		{
			get
			{
				return slowLogs;
			}
			set	
			{
				slowLogs = value;
			}
		}

		public class DescribeDatabaseSlowLogRecords_SlowLog
		{

			private string hostAddress;

			private long? queryTimes;

			private string sQLText;

			private long? queryTimeMS;

			private long? lockTimes;

			private string executionStartTime;

			private long? returnRowCounts;

			private long? parseRowCounts;

			private string dBName;

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
		}
	}
}
