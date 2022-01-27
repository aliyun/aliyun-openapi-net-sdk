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
	public class GetMetaTableBasicInfoResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private int? httpStatusCode;

		private bool? success;

		private GetMetaTableBasicInfo_Data data;

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

		public GetMetaTableBasicInfo_Data Data
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

		public class GetMetaTableBasicInfo_Data
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

			private long? lastDdlTime;

			private long? lastAccessTime;

			private int? envType;

			private long? dataSize;

			private string comment;

			private string projectName;

			private string databaseName;

			private string partitionKeys;

			private string location;

			private string clusterId;

			private string caption;

			private bool? isPartitionTable;

			private long? readCount;

			private long? viewCount;

			private long? favoriteCount;

			private bool? isView;

			private int? columnCount;

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

			public string DatabaseName
			{
				get
				{
					return databaseName;
				}
				set	
				{
					databaseName = value;
				}
			}

			public string PartitionKeys
			{
				get
				{
					return partitionKeys;
				}
				set	
				{
					partitionKeys = value;
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

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
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

			public bool? IsPartitionTable
			{
				get
				{
					return isPartitionTable;
				}
				set	
				{
					isPartitionTable = value;
				}
			}

			public long? ReadCount
			{
				get
				{
					return readCount;
				}
				set	
				{
					readCount = value;
				}
			}

			public long? ViewCount
			{
				get
				{
					return viewCount;
				}
				set	
				{
					viewCount = value;
				}
			}

			public long? FavoriteCount
			{
				get
				{
					return favoriteCount;
				}
				set	
				{
					favoriteCount = value;
				}
			}

			public bool? IsView
			{
				get
				{
					return isView;
				}
				set	
				{
					isView = value;
				}
			}

			public int? ColumnCount
			{
				get
				{
					return columnCount;
				}
				set	
				{
					columnCount = value;
				}
			}
		}
	}
}
