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

		private int? httpStatusCode;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private string errorCode;

		private GetMetaTableBasicInfo_Data data;

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

			private long? favoriteCount;

			private string comment;

			private int? columnCount;

			private long? createTime;

			private long? projectId;

			private string ownerId;

			private int? envType;

			private string databaseName;

			private int? isVisible;

			private string tableGuid;

			private long? readCount;

			private string clusterId;

			private bool? isPartitionTable;

			private bool? isView;

			private int? lifeCycle;

			private string projectName;

			private long? viewCount;

			private long? lastAccessTime;

			private long? dataSize;

			private long? lastModifyTime;

			private long? lastDdlTime;

			private string partitionKeys;

			private string location;

			private string caption;

			private long? tenantId;

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
		}
	}
}
