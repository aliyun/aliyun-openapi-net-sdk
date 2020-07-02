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
	public class GetMetaTableFullInfoResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private int? httpStatusCode;

		private bool? success;

		private GetMetaTableFullInfo_Data data;

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

		public GetMetaTableFullInfo_Data Data
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

		public class GetMetaTableFullInfo_Data
		{

			private string tableName;

			private string tableGuid;

			private string ownerId;

			private long? tenantId;

			private long? projectId;

			private long? createTime;

			private long? lastModifyTime;

			private int? lifeCycle;

			private int? isVisible;

			private string projectName;

			private long? dataSize;

			private int? envType;

			private string comment;

			private long? totalColumnCount;

			private long? lastDdlTime;

			private long? lastAccessTime;

			private List<GetMetaTableFullInfo_ColumnListItem> columnList;

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

			public string OwnerId
			{
				get
				{
					return ownerId;
				}
				set	
				{
					ownerId = value;
				}
			}

			public long? TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public long? ProjectId
			{
				get
				{
					return projectId;
				}
				set	
				{
					projectId = value;
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

			public long? LastModifyTime
			{
				get
				{
					return lastModifyTime;
				}
				set	
				{
					lastModifyTime = value;
				}
			}

			public int? LifeCycle
			{
				get
				{
					return lifeCycle;
				}
				set	
				{
					lifeCycle = value;
				}
			}

			public int? IsVisible
			{
				get
				{
					return isVisible;
				}
				set	
				{
					isVisible = value;
				}
			}

			public string ProjectName
			{
				get
				{
					return projectName;
				}
				set	
				{
					projectName = value;
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

			public int? EnvType
			{
				get
				{
					return envType;
				}
				set	
				{
					envType = value;
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

			public long? TotalColumnCount
			{
				get
				{
					return totalColumnCount;
				}
				set	
				{
					totalColumnCount = value;
				}
			}

			public long? LastDdlTime
			{
				get
				{
					return lastDdlTime;
				}
				set	
				{
					lastDdlTime = value;
				}
			}

			public long? LastAccessTime
			{
				get
				{
					return lastAccessTime;
				}
				set	
				{
					lastAccessTime = value;
				}
			}

			public List<GetMetaTableFullInfo_ColumnListItem> ColumnList
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

			public class GetMetaTableFullInfo_ColumnListItem
			{

				private string columnGuid;

				private string columnName;

				private string columnType;

				private bool? isPrimaryKey;

				private string comment;

				private bool? isPartitionColumn;

				private bool? isForeignKey;

				private string caption;

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
			}
		}
	}
}
