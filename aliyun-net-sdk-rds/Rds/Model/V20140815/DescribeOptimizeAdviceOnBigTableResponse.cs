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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeOptimizeAdviceOnBigTableResponse : AcsResponse
	{

		private string requestId;

		private int? totalRecordsCount;

		private int? pageNumber;

		private int? pageRecordCount;

		private List<DescribeOptimizeAdviceOnBigTable_AdviceOnBigTable> items;

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

		public int? TotalRecordsCount
		{
			get
			{
				return totalRecordsCount;
			}
			set	
			{
				totalRecordsCount = value;
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

		public List<DescribeOptimizeAdviceOnBigTable_AdviceOnBigTable> Items
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

		public class DescribeOptimizeAdviceOnBigTable_AdviceOnBigTable
		{

			private string dBName;

			private string tableName;

			private long? tableSize;

			private long? dataSize;

			private long? indexSize;

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

			public string TableName
			{
				get
				{
					return tableName;
				}
				set	
				{
					tableName = value;
				}
			}

			public long? TableSize
			{
				get
				{
					return tableSize;
				}
				set	
				{
					tableSize = value;
				}
			}

			public long? DataSize
			{
				get
				{
					return dataSize;
				}
				set	
				{
					dataSize = value;
				}
			}

			public long? IndexSize
			{
				get
				{
					return indexSize;
				}
				set	
				{
					indexSize = value;
				}
			}
		}
	}
}