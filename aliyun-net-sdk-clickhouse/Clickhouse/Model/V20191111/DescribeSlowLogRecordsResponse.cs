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

namespace Aliyun.Acs.clickhouse.Model.V20191111
{
	public class DescribeSlowLogRecordsResponse : AcsResponse
	{

		private string requestId;

		private DescribeSlowLogRecords_SlowLogRecords slowLogRecords;

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

		public DescribeSlowLogRecords_SlowLogRecords SlowLogRecords
		{
			get
			{
				return slowLogRecords;
			}
			set	
			{
				slowLogRecords = value;
			}
		}

		public class DescribeSlowLogRecords_SlowLogRecords
		{

			private string rows;

			private string rowsBeforeLimitAtLeast;

			private List<DescribeSlowLogRecords_ResultSet> tableSchema;

			private List<DescribeSlowLogRecords_ResultSet1> data;

			private DescribeSlowLogRecords_Statistics statistics;

			public string Rows
			{
				get
				{
					return rows;
				}
				set	
				{
					rows = value;
				}
			}

			public string RowsBeforeLimitAtLeast
			{
				get
				{
					return rowsBeforeLimitAtLeast;
				}
				set	
				{
					rowsBeforeLimitAtLeast = value;
				}
			}

			public List<DescribeSlowLogRecords_ResultSet> TableSchema
			{
				get
				{
					return tableSchema;
				}
				set	
				{
					tableSchema = value;
				}
			}

			public List<DescribeSlowLogRecords_ResultSet1> Data
			{
				get
				{
					return data;
				}
				set	
				{
					data = value;
				}
			}

			public DescribeSlowLogRecords_Statistics Statistics
			{
				get
				{
					return statistics;
				}
				set	
				{
					statistics = value;
				}
			}

			public class DescribeSlowLogRecords_ResultSet
			{

				private string type;

				private string name;

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}
			}

			public class DescribeSlowLogRecords_ResultSet1
			{

				private string type;

				private string queryStartTime;

				private string query;

				private string readRows;

				private string initialAddress;

				private string memoryUsage;

				private string initialUser;

				private string initialQueryId;

				private string readBytes;

				private string queryDurationMs;

				private string resultBytes;

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string QueryStartTime
				{
					get
					{
						return queryStartTime;
					}
					set	
					{
						queryStartTime = value;
					}
				}

				public string Query
				{
					get
					{
						return query;
					}
					set	
					{
						query = value;
					}
				}

				public string ReadRows
				{
					get
					{
						return readRows;
					}
					set	
					{
						readRows = value;
					}
				}

				public string InitialAddress
				{
					get
					{
						return initialAddress;
					}
					set	
					{
						initialAddress = value;
					}
				}

				public string MemoryUsage
				{
					get
					{
						return memoryUsage;
					}
					set	
					{
						memoryUsage = value;
					}
				}

				public string InitialUser
				{
					get
					{
						return initialUser;
					}
					set	
					{
						initialUser = value;
					}
				}

				public string InitialQueryId
				{
					get
					{
						return initialQueryId;
					}
					set	
					{
						initialQueryId = value;
					}
				}

				public string ReadBytes
				{
					get
					{
						return readBytes;
					}
					set	
					{
						readBytes = value;
					}
				}

				public string QueryDurationMs
				{
					get
					{
						return queryDurationMs;
					}
					set	
					{
						queryDurationMs = value;
					}
				}

				public string ResultBytes
				{
					get
					{
						return resultBytes;
					}
					set	
					{
						resultBytes = value;
					}
				}
			}

			public class DescribeSlowLogRecords_Statistics
			{

				private int? rowsRead;

				private float? elapsedTime;

				private int? bytesRead;

				public int? RowsRead
				{
					get
					{
						return rowsRead;
					}
					set	
					{
						rowsRead = value;
					}
				}

				public float? ElapsedTime
				{
					get
					{
						return elapsedTime;
					}
					set	
					{
						elapsedTime = value;
					}
				}

				public int? BytesRead
				{
					get
					{
						return bytesRead;
					}
					set	
					{
						bytesRead = value;
					}
				}
			}
		}
	}
}
