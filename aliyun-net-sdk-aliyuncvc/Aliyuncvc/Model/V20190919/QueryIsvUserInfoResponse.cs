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

namespace Aliyun.Acs.aliyuncvc.Model.V20190919
{
	public class QueryIsvUserInfoResponse : AcsResponse
	{

		private int? errorCode;

		private string message;

		private bool? success;

		private string requestId;

		private QueryIsvUserInfo_UserInfo userInfo;

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

		public QueryIsvUserInfo_UserInfo UserInfo
		{
			get
			{
				return userInfo;
			}
			set	
			{
				userInfo = value;
			}
		}

		public class QueryIsvUserInfo_UserInfo
		{

			private string userName;

			private long? createTime;

			private string groupId;

			private string groupName;

			private string userId;

			private string userTel;

			private string userEmail;

			private string userMobile;

			private string userAvatarUrl;

			private string departId;

			private string departName;

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
		}
	}
}
