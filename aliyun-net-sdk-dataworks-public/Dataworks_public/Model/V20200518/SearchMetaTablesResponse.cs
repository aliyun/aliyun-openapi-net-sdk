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
	public class SearchMetaTablesResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private string errorCode;

		private SearchMetaTables_Data data;

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

		public SearchMetaTables_Data Data
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

		public class SearchMetaTables_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private long? totalCount;

			private List<SearchMetaTables_DataEntityListItem> dataEntityList;

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

			public List<SearchMetaTables_DataEntityListItem> DataEntityList
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

			public class SearchMetaTables_DataEntityListItem
			{

				private string tableName;

				private string databaseName;

				private int? entityType;

				private string projectName;

				private long? projectId;

				private string tableGuid;

				private string ownerId;

				private string clusterId;

				private int? envType;

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

				public int? EntityType
				{
					get
					{
						return entityType;
					}
					set	
					{
						entityType = value;
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
}
