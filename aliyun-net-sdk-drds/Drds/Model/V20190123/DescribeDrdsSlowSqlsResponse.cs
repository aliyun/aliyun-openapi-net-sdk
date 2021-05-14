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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeDrdsSlowSqlsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? total;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeDrdsSlowSqls_Item> items;

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

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
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

		public List<DescribeDrdsSlowSqls_Item> Items
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

		public class DescribeDrdsSlowSqls_Item
		{

			private string schema;

			private string sql;

			private long? sendTime;

			private long? responseTime;

			private string host;

			public string Schema
			{
				get
				{
					return schema;
				}
				set	
				{
					schema = value;
				}
			}

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

			public long? SendTime
			{
				get
				{
					return sendTime;
				}
				set	
				{
					sendTime = value;
				}
			}

			public long? ResponseTime
			{
				get
				{
					return responseTime;
				}
				set	
				{
					responseTime = value;
				}
			}

			public string Host
			{
				get
				{
					return host;
				}
				set	
				{
					host = value;
				}
			}
		}
	}
}
