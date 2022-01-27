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

namespace Aliyun.Acs.quickbi_public.Model.V20200803
{
	public class QueryOrganizationWorkspaceListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private QueryOrganizationWorkspaceList_Result result;

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

		public QueryOrganizationWorkspaceList_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class QueryOrganizationWorkspaceList_Result
		{

			private int? totalNum;

			private int? totalPages;

			private int? pageNum;

			private int? pageSize;

			private List<QueryOrganizationWorkspaceList_DataItem> data;

			public int? TotalNum
			{
				get
				{
					return totalNum;
				}
				set	
				{
					totalNum = value;
				}
			}

			public int? TotalPages
			{
				get
				{
					return totalPages;
				}
				set	
				{
					totalPages = value;
				}
			}

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

			public List<QueryOrganizationWorkspaceList_DataItem> Data
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

			public class QueryOrganizationWorkspaceList_DataItem
			{

				private string workspaceId;

				private string workspaceName;

				private string workspaceDescription;

				private string organizationId;

				private string owner;

				private string ownerAccountName;

				private string createUser;

				private string createUserAccountName;

				private string modifyUser;

				private string modifyUserAccountName;

				private string createTime;

				private string modifiedTime;

				private bool? allowShareOperation;

				private bool? allowPublishOperation;

				public string WorkspaceId
				{
					get
					{
						return workspaceId;
					}
					set	
					{
						workspaceId = value;
					}
				}

				public string WorkspaceName
				{
					get
					{
						return workspaceName;
					}
					set	
					{
						workspaceName = value;
					}
				}

				public string WorkspaceDescription
				{
					get
					{
						return workspaceDescription;
					}
					set	
					{
						workspaceDescription = value;
					}
				}

				public string OrganizationId
				{
					get
					{
						return organizationId;
					}
					set	
					{
						organizationId = value;
					}
				}

				public string Owner
				{
					get
					{
						return owner;
					}
					set	
					{
						owner = value;
					}
				}

				public string OwnerAccountName
				{
					get
					{
						return ownerAccountName;
					}
					set	
					{
						ownerAccountName = value;
					}
				}

				public string CreateUser
				{
					get
					{
						return createUser;
					}
					set	
					{
						createUser = value;
					}
				}

				public string CreateUserAccountName
				{
					get
					{
						return createUserAccountName;
					}
					set	
					{
						createUserAccountName = value;
					}
				}

				public string ModifyUser
				{
					get
					{
						return modifyUser;
					}
					set	
					{
						modifyUser = value;
					}
				}

				public string ModifyUserAccountName
				{
					get
					{
						return modifyUserAccountName;
					}
					set	
					{
						modifyUserAccountName = value;
					}
				}

				public string CreateTime
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

				public string ModifiedTime
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

				public bool? AllowShareOperation
				{
					get
					{
						return allowShareOperation;
					}
					set	
					{
						allowShareOperation = value;
					}
				}

				public bool? AllowPublishOperation
				{
					get
					{
						return allowPublishOperation;
					}
					set	
					{
						allowPublishOperation = value;
					}
				}
			}
		}
	}
}
