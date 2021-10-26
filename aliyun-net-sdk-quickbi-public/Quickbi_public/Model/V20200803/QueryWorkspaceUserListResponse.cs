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
	public class QueryWorkspaceUserListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private QueryWorkspaceUserList_Result result;

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

		public QueryWorkspaceUserList_Result Result
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

		public class QueryWorkspaceUserList_Result
		{

			private int? totalNum;

			private int? totalPages;

			private int? pageSize;

			private int? pageNum;

			private List<QueryWorkspaceUserList_DataItem> data;

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

			public List<QueryWorkspaceUserList_DataItem> Data
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

			public class QueryWorkspaceUserList_DataItem
			{

				private string userId;

				private string accountName;

				private string phone;

				private string nickName;

				private string email;

				private string accountId;

				private QueryWorkspaceUserList_Role role;

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public string AccountName
				{
					get
					{
						return accountName;
					}
					set	
					{
						accountName = value;
					}
				}

				public string Phone
				{
					get
					{
						return phone;
					}
					set	
					{
						phone = value;
					}
				}

				public string NickName
				{
					get
					{
						return nickName;
					}
					set	
					{
						nickName = value;
					}
				}

				public string Email
				{
					get
					{
						return email;
					}
					set	
					{
						email = value;
					}
				}

				public string AccountId
				{
					get
					{
						return accountId;
					}
					set	
					{
						accountId = value;
					}
				}

				public QueryWorkspaceUserList_Role Role
				{
					get
					{
						return role;
					}
					set	
					{
						role = value;
					}
				}

				public class QueryWorkspaceUserList_Role
				{

					private string roleName;

					private long? roleId;

					private string roleCode;

					public string RoleName
					{
						get
						{
							return roleName;
						}
						set	
						{
							roleName = value;
						}
					}

					public long? RoleId
					{
						get
						{
							return roleId;
						}
						set	
						{
							roleId = value;
						}
					}

					public string RoleCode
					{
						get
						{
							return roleCode;
						}
						set	
						{
							roleCode = value;
						}
					}
				}
			}
		}
	}
}
