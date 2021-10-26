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

namespace Aliyun.Acs.quickbi_public.Model.V20200801
{
	public class QueryUserListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private QueryUserList_Result result;

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

		public QueryUserList_Result Result
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

		public class QueryUserList_Result
		{

			private int? pageNum;

			private int? pageSize;

			private int? totalNum;

			private int? totalPages;

			private List<QueryUserList_DataItem> data;

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

			public List<QueryUserList_DataItem> Data
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

			public class QueryUserList_DataItem
			{

				private string accountId;

				private string accountName;

				private bool? adminUser;

				private bool? authAdminUser;

				private string email;

				private string nickName;

				private string phone;

				private string userId;

				private int? userType;

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

				public bool? AdminUser
				{
					get
					{
						return adminUser;
					}
					set	
					{
						adminUser = value;
					}
				}

				public bool? AuthAdminUser
				{
					get
					{
						return authAdminUser;
					}
					set	
					{
						authAdminUser = value;
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

				public int? UserType
				{
					get
					{
						return userType;
					}
					set	
					{
						userType = value;
					}
				}
			}
		}
	}
}
