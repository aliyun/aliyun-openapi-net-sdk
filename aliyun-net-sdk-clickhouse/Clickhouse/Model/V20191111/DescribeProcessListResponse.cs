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
	public class DescribeProcessListResponse : AcsResponse
	{

		private string requestId;

		private DescribeProcessList_ProcessList processList;

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

		public DescribeProcessList_ProcessList ProcessList
		{
			get
			{
				return processList;
			}
			set	
			{
				processList = value;
			}
		}

		public class DescribeProcessList_ProcessList
		{

			private string rows;

			private string rowsBeforeLimitAtLeast;

			private List<DescribeProcessList_ResultSet> tableSchema;

			private List<DescribeProcessList_ResultSet1> data;

			private DescribeProcessList_Statistics statistics;

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

			public List<DescribeProcessList_ResultSet> TableSchema
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

			public List<DescribeProcessList_ResultSet1> Data
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

			public DescribeProcessList_Statistics Statistics
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

			public class DescribeProcessList_ResultSet
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

			public class DescribeProcessList_ResultSet1
			{

				private string queryStartTime;

				private string query;

				private string initialAddress;

				private string initialQueryId;

				private string initialUser;

				private string queryDurationMs;

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
			}

			public class DescribeProcessList_Statistics
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
