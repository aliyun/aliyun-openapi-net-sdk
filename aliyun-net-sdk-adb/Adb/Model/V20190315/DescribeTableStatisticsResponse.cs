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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeTableStatisticsResponse : AcsResponse
	{

		private string totalCount;

		private string requestId;

		private string pageSize;

		private string pageNumber;

		private string dBClusterId;

		private List<DescribeTableStatistics_TableStatisticRecords> items;

		public string TotalCount
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

		public string PageSize
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

		public string PageNumber
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

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
			}
		}

		public List<DescribeTableStatistics_TableStatisticRecords> Items
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

		public class DescribeTableStatistics_TableStatisticRecords
		{

			private string tableName;

			private long? coldDataSize;

			private long? dataSize;

			private long? primaryKeyIndexSize;

			private long? indexSize;

			private long? rowCount;

			private long? partitionCount;

			private string schemaName;

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

			public long? ColdDataSize
			{
				get
				{
					return coldDataSize;
				}
				set	
				{
					coldDataSize = value;
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

			public long? PrimaryKeyIndexSize
			{
				get
				{
					return primaryKeyIndexSize;
				}
				set	
				{
					primaryKeyIndexSize = value;
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

			public long? RowCount
			{
				get
				{
					return rowCount;
				}
				set	
				{
					rowCount = value;
				}
			}

			public long? PartitionCount
			{
				get
				{
					return partitionCount;
				}
				set	
				{
					partitionCount = value;
				}
			}

			public string SchemaName
			{
				get
				{
					return schemaName;
				}
				set	
				{
					schemaName = value;
				}
			}
		}
	}
}
