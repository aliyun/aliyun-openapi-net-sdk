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
	public class GetMetaTableColumnResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private string errorCode;

		private GetMetaTableColumn_Data data;

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

		public GetMetaTableColumn_Data Data
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

		public class GetMetaTableColumn_Data
		{

			private int? pageNum;

			private int? pageSize;

			private long? totalCount;

			private List<GetMetaTableColumn_ColumnListItem> columnList;

			public int? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
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

			public List<GetMetaTableColumn_ColumnListItem> ColumnList
			{
				get
				{
					return columnList;
				}
				set	
				{
					columnList = value;
				}
			}

			public class GetMetaTableColumn_ColumnListItem
			{

				private string columnGuid;

				private string columnName;

				private bool? isPartitionColumn;

				private string comment;

				private string columnType;

				private bool? isPrimaryKey;

				private int? position;

				private string caption;

				private bool? isForeignKey;

				private long? relationCount;

				public string ColumnGuid
				{
					get
					{
						return columnGuid;
					}
					set	
					{
						columnGuid = value;
					}
				}

				public string ColumnName
				{
					get
					{
						return columnName;
					}
					set	
					{
						columnName = value;
					}
				}

				public bool? IsPartitionColumn
				{
					get
					{
						return isPartitionColumn;
					}
					set	
					{
						isPartitionColumn = value;
					}
				}

				public string Comment
				{
					get
					{
						return comment;
					}
					set	
					{
						comment = value;
					}
				}

				public string ColumnType
				{
					get
					{
						return columnType;
					}
					set	
					{
						columnType = value;
					}
				}

				public bool? IsPrimaryKey
				{
					get
					{
						return isPrimaryKey;
					}
					set	
					{
						isPrimaryKey = value;
					}
				}

				public int? Position
				{
					get
					{
						return position;
					}
					set	
					{
						position = value;
					}
				}

				public string Caption
				{
					get
					{
						return caption;
					}
					set	
					{
						caption = value;
					}
				}

				public bool? IsForeignKey
				{
					get
					{
						return isForeignKey;
					}
					set	
					{
						isForeignKey = value;
					}
				}

				public long? RelationCount
				{
					get
					{
						return relationCount;
					}
					set	
					{
						relationCount = value;
					}
				}
			}
		}
	}
}
