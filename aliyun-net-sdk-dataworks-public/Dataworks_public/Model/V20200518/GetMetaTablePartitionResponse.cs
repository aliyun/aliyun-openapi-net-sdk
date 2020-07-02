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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetMetaTablePartitionResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private int? httpStatusCode;

		private bool? success;

		private GetMetaTablePartition_Data data;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public GetMetaTablePartition_Data Data
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

		public class GetMetaTablePartition_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private long? totalCount;

			private List<GetMetaTablePartition_DataEntityListItem> dataEntityList;

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

			public long? TotalCount
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

			public List<GetMetaTablePartition_DataEntityListItem> DataEntityList
			{
				get
				{
					return dataEntityList;
				}
				set	
				{
					dataEntityList = value;
				}
			}

			public class GetMetaTablePartition_DataEntityListItem
			{

				private string partitionGuid;

				private string partitionName;

				private long? createTime;

				private long? dataSize;

				private long? recordCount;

				private long? modifiedTime;

				private string tableGuid;

				public string PartitionGuid
				{
					get
					{
						return partitionGuid;
					}
					set	
					{
						partitionGuid = value;
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

				public long? CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
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

				public long? RecordCount
				{
					get
					{
						return recordCount;
					}
					set	
					{
						recordCount = value;
					}
				}

				public long? ModifiedTime
				{
					get
					{
						return modifiedTime;
					}
					set	
					{
						modifiedTime = value;
					}
				}

				public string TableGuid
				{
					get
					{
						return tableGuid;
					}
					set	
					{
						tableGuid = value;
					}
				}
			}
		}
	}
}
