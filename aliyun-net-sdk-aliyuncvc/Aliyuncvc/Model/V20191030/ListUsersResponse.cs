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

namespace Aliyun.Acs.aliyuncvc.Model.V20191030
{
	public class ListUsersResponse : AcsResponse
	{

		private int? errorCode;

		private string message;

		private bool? success;

		private string requestId;

		private ListUsers_Data data;

		public int? ErrorCode
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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public ListUsers_Data Data
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

		public class ListUsers_Data
		{

			private int? totalCount;

			private int? pageSize;

			private int? pageNumber;

			private List<ListUsers_UserInfo> userInfos;

			public int? TotalCount
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

			public List<ListUsers_UserInfo> UserInfos
			{
				get
				{
					return userInfos;
				}
				set	
				{
					userInfos = value;
				}
			}

			public class ListUsers_UserInfo
			{

				private long? createTime;

				private string groupName;

				private string userName;

				private string groupId;

				private string departName;

				private string departId;

				private string userEmail;

				private string userTel;

				private string userMobile;

				private string userAvatarUrl;

				private string jobName;

				private string userId;

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

				public string GroupName
				{
					get
					{
						return groupName;
					}
					set	
					{
						groupName = value;
					}
				}

				public string UserName
				{
					get
					{
						return userName;
					}
					set	
					{
						userName = value;
					}
				}

				public string GroupId
				{
					get
					{
						return groupId;
					}
					set	
					{
						groupId = value;
					}
				}

				public string DepartName
				{
					get
					{
						return departName;
					}
					set	
					{
						departName = value;
					}
				}

				public string DepartId
				{
					get
					{
						return departId;
					}
					set	
					{
						departId = value;
					}
				}

				public string UserEmail
				{
					get
					{
						return userEmail;
					}
					set	
					{
						userEmail = value;
					}
				}

				public string UserTel
				{
					get
					{
						return userTel;
					}
					set	
					{
						userTel = value;
					}
				}

				public string UserMobile
				{
					get
					{
						return userMobile;
					}
					set	
					{
						userMobile = value;
					}
				}

				public string UserAvatarUrl
				{
					get
					{
						return userAvatarUrl;
					}
					set	
					{
						userAvatarUrl = value;
					}
				}

				public string JobName
				{
					get
					{
						return jobName;
					}
					set	
					{
						jobName = value;
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
			}
		}
	}
}
