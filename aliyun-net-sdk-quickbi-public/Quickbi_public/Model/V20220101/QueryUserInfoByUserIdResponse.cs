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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class QueryUserInfoByUserIdResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private QueryUserInfoByUserId_Result result;

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

		public QueryUserInfoByUserId_Result Result
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

		public class QueryUserInfoByUserId_Result
		{

			private bool? isDeleted;

			private string accountId;

			private string email;

			private string phone;

			private string userId;

			private bool? adminUser;

			private string nickName;

			private int? userType;

			private bool? authAdminUser;

			private string accountName;

			private List<string> roleIdList;

			private List<string> copilotModules;

			public bool? IsDeleted
			{
				get
				{
					return isDeleted;
				}
				set	
				{
					isDeleted = value;
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

			public List<string> RoleIdList
			{
				get
				{
					return roleIdList;
				}
				set	
				{
					roleIdList = value;
				}
			}

			public List<string> CopilotModules
			{
				get
				{
					return copilotModules;
				}
				set	
				{
					copilotModules = value;
				}
			}
		}
	}
}
