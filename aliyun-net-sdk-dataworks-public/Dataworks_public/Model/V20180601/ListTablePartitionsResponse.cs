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

namespace Aliyun.Acs.dataworks_public.Model.V20180601
{
	public class ListTablePartitionsResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private ListTablePartitions_Data data;

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public ListTablePartitions_Data Data
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

		public class ListTablePartitions_Data
		{

			private int? pageSize;

			private int? totalCount;

			private List<ListTablePartitions_TablePartitions> pagedData;

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

			public List<ListTablePartitions_TablePartitions> PagedData
			{
				get
				{
					return pagedData;
				}
				set	
				{
					pagedData = value;
				}
			}

			public class ListTablePartitions_TablePartitions
			{

				private long? gmtCreate;

				private long? gmtModified;

				private string location;

				private string partitionName;

				private string partitionPath;

				private string partitionType;

				private string partitionComment;

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
			}
		}
	}
}
