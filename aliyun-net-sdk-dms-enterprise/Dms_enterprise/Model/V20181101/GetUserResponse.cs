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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class GetUserResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private GetUser_User user;

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

		public GetUser_User User
		{
			get
			{
				return user;
			}
			set	
			{
				user = value;
			}
		}

		public class GetUser_User
		{

			private string userId;

			private string uid;

			private string nickName;

			private string mobile;

			private long? parentUid;

			private string state;

			private string lastLoginTime;

			private long? curExecuteCount;

			private long? curResultCount;

			private long? maxExecuteCount;

			private long? maxResultCount;

			private List<string> roleIdList;

			private List<string> roleNameList;

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

			public string Uid
			{
				get
				{
					return uid;
				}
				set	
				{
					uid = value;
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

			public string Mobile
			{
				get
				{
					return mobile;
				}
				set	
				{
					mobile = value;
				}
			}

			public long? ParentUid
			{
				get
				{
					return parentUid;
				}
				set	
				{
					parentUid = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string LastLoginTime
			{
				get
				{
					return lastLoginTime;
				}
				set	
				{
					lastLoginTime = value;
				}
			}

			public long? CurExecuteCount
			{
				get
				{
					return curExecuteCount;
				}
				set	
				{
					curExecuteCount = value;
				}
			}

			public long? CurResultCount
			{
				get
				{
					return curResultCount;
				}
				set	
				{
					curResultCount = value;
				}
			}

			public long? MaxExecuteCount
			{
				get
				{
					return maxExecuteCount;
				}
				set	
				{
					maxExecuteCount = value;
				}
			}

			public long? MaxResultCount
			{
				get
				{
					return maxResultCount;
				}
				set	
				{
					maxResultCount = value;
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

			public List<string> RoleNameList
			{
				get
				{
					return roleNameList;
				}
				set	
				{
					roleNameList = value;
				}
			}
		}
	}
}
