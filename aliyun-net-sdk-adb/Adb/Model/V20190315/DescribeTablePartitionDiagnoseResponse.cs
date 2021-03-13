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
	public class DescribeTablePartitionDiagnoseResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private string dBClusterId;

		private long? suggestMaxRecordsPerPartition;

		private long? suggestMinRecordsPerPartition;

		private List<DescribeTablePartitionDiagnose_TablePartitionDiagnose> items;

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

		public long? SuggestMaxRecordsPerPartition
		{
			get
			{
				return suggestMaxRecordsPerPartition;
			}
			set	
			{
				suggestMaxRecordsPerPartition = value;
			}
		}

		public long? SuggestMinRecordsPerPartition
		{
			get
			{
				return suggestMinRecordsPerPartition;
			}
			set	
			{
				suggestMinRecordsPerPartition = value;
			}
		}

		public List<DescribeTablePartitionDiagnose_TablePartitionDiagnose> Items
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

		public class DescribeTablePartitionDiagnose_TablePartitionDiagnose
		{

			private string tableName;

			private int? partitionNumber;

			private string partitionDetail;

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

			public int? PartitionNumber
			{
				get
				{
					return partitionNumber;
				}
				set	
				{
					partitionNumber = value;
				}
			}

			public string PartitionDetail
			{
				get
				{
					return partitionDetail;
				}
				set	
				{
					partitionDetail = value;
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
