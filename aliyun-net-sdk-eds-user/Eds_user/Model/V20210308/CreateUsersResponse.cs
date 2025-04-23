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

namespace Aliyun.Acs.eds_user.Model.V20210308
{
	public class CreateUsersResponse : AcsResponse
	{

		private string requestId;

		private CreateUsers_CreateResult createResult;

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

		public CreateUsers_CreateResult CreateResult
		{
			get
			{
				return createResult;
			}
			set	
			{
				createResult = value;
			}
		}

		public class CreateUsers_CreateResult
		{

			private List<CreateUsers_CreatedUsersItem> createdUsers;

			private List<CreateUsers_FailedUsersItem> failedUsers;

			public List<CreateUsers_CreatedUsersItem> CreatedUsers
			{
				get
				{
					return createdUsers;
				}
				set	
				{
					createdUsers = value;
				}
			}

			public List<CreateUsers_FailedUsersItem> FailedUsers
			{
				get
				{
					return failedUsers;
				}
				set	
				{
					failedUsers = value;
				}
			}

			public class CreateUsers_CreatedUsersItem
			{

				private string endUserId;

				private string email;

				private string phone;

				private string remark;

				private string realNickName;

				public string EndUserId
				{
					get
					{
						return endUserId;
					}
					set	
					{
						endUserId = value;
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

				public string Remark
				{
					get
					{
						return remark;
					}
					set	
					{
						remark = value;
					}
				}

				public string RealNickName
				{
					get
					{
						return realNickName;
					}
					set	
					{
						realNickName = value;
					}
				}
			}

			public class CreateUsers_FailedUsersItem
			{

				private string endUserId;

				private string email;

				private string phone;

				private string errorCode;

				private string errorMessage;

				public string EndUserId
				{
					get
					{
						return endUserId;
					}
					set	
					{
						endUserId = value;
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
			}
		}
	}
}
