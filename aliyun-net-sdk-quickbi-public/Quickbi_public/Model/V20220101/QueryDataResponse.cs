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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class QueryDataResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private QueryData_Result result;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public QueryData_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class QueryData_Result
		{

			private string sql;

			private List<QueryData_HeadersItem> headers;

			private List<Dictionary<string, string>> values;

			public string Sql
			{
				get
				{
					return sql;
				}
				set	
				{
					sql = value;
				}
			}

			public List<QueryData_HeadersItem> Headers
			{
				get
				{
					return headers;
				}
				set	
				{
					headers = value;
				}
			}

			public List<Dictionary<string, string>> Values
			{
				get
				{
					return values;
				}
				set	
				{
					values = value;
				}
			}

			public class QueryData_HeadersItem
			{

				private string aggregator;

				private string column;

				private string dataType;

				private string granularity;

				private string label;

				private string type;

				public string Aggregator
				{
					get
					{
						return aggregator;
					}
					set	
					{
						aggregator = value;
					}
				}

				public string Column
				{
					get
					{
						return column;
					}
					set	
					{
						column = value;
					}
				}

				public string DataType
				{
					get
					{
						return dataType;
					}
					set	
					{
						dataType = value;
					}
				}

				public string Granularity
				{
					get
					{
						return granularity;
					}
					set	
					{
						granularity = value;
					}
				}

				public string Label
				{
					get
					{
						return label;
					}
					set	
					{
						label = value;
					}
				}

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
			}
		}
	}
}
