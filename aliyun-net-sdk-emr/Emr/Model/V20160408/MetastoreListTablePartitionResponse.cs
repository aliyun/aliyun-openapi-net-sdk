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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class MetastoreListTablePartitionResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<MetastoreListTablePartition_Partition> partitionList;

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

		public List<MetastoreListTablePartition_Partition> PartitionList
		{
			get
			{
				return partitionList;
			}
			set	
			{
				partitionList = value;
			}
		}

		public class MetastoreListTablePartition_Partition
		{

			private string databaseId;

			private string tableId;

			private string partitionName;

			private string partitionType;

			private string partitionComment;

			private string location;

			private string partitionPath;

			private int? bucketNum;

			private long? gmtCreate;

			private long? gmtModified;

			public string DatabaseId
			{
				get
				{
					return databaseId;
				}
				set	
				{
					databaseId = value;
				}
			}

			public string TableId
			{
				get
				{
					return tableId;
				}
				set	
				{
					tableId = value;
				}
			}

			public string PartitionName
			{
				get
				{
					return partitionName;
				}
				set	
				{
					partitionName = value;
				}
			}

			public string PartitionType
			{
				get
				{
					return partitionType;
				}
				set	
				{
					partitionType = value;
				}
			}

			public string PartitionComment
			{
				get
				{
					return partitionComment;
				}
				set	
				{
					partitionComment = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string PartitionPath
			{
				get
				{
					return partitionPath;
				}
				set	
				{
					partitionPath = value;
				}
			}

			public int? BucketNum
			{
				get
				{
					return bucketNum;
				}
				set	
				{
					bucketNum = value;
				}
			}

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}
		}
	}
}
