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
	public class DescribeTablesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? pageNumber;

		private int? pageSize;

		private int? total;

		private List<DescribeTables_ListItem> list;

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

		public List<DescribeTables_ListItem> List
		{
			get
			{
				return list;
			}
			set	
			{
				list = value;
			}
		}

		public class DescribeTables_ListItem
		{

			private string table;

			private string shardKey;

			private bool? isShard;

			private bool? isLocked;

			private int? dbInstType;

			private bool? broadcast;

			private bool? allowFullTableScan;

			private int? status;

			public string Table
			{
				get
				{
					return table;
				}
				set	
				{
					table = value;
				}
			}

			public string ShardKey
			{
				get
				{
					return shardKey;
				}
				set	
				{
					shardKey = value;
				}
			}

			public bool? IsShard
			{
				get
				{
					return isShard;
				}
				set	
				{
					isShard = value;
				}
			}

			public bool? IsLocked
			{
				get
				{
					return isLocked;
				}
				set	
				{
					isLocked = value;
				}
			}

			public int? DbInstType
			{
				get
				{
					return dbInstType;
				}
				set	
				{
					dbInstType = value;
				}
			}

			public bool? Broadcast
			{
				get
				{
					return broadcast;
				}
				set	
				{
					broadcast = value;
				}
			}

			public bool? AllowFullTableScan
			{
				get
				{
					return allowFullTableScan;
				}
				set	
				{
					allowFullTableScan = value;
				}
			}

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}
		}
	}
}
