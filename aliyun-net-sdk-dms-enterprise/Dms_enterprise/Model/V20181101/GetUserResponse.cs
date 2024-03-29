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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class GetUserResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private GetUser_User user;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "ErrorCode")]
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

		[JsonProperty(PropertyName = "ErrorMessage")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "User")]
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

			private string state;

			private long? curResultCount;

			private string userId;

			private string lastLoginTime;

			private long? maxResultCount;

			private long? parentUid;

			private string nickName;

			private long? maxExecuteCount;

			private long? curExecuteCount;

			private string mobile;

			private string uid;

			private string email;

			private string dingRobot;

			private string webhook;

			private string signatureMethod;

			private string notificationMode;

			private List<string> roleIdList;

			private List<string> roleNameList;

			[JsonProperty(PropertyName = "State")]
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

			[JsonProperty(PropertyName = "CurResultCount")]
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

			[JsonProperty(PropertyName = "UserId")]
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

			[JsonProperty(PropertyName = "LastLoginTime")]
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

			[JsonProperty(PropertyName = "MaxResultCount")]
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

			[JsonProperty(PropertyName = "ParentUid")]
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

			[JsonProperty(PropertyName = "NickName")]
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

			[JsonProperty(PropertyName = "MaxExecuteCount")]
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

			[JsonProperty(PropertyName = "CurExecuteCount")]
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

			[JsonProperty(PropertyName = "Mobile")]
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

			[JsonProperty(PropertyName = "Uid")]
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

			[JsonProperty(PropertyName = "Email")]
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

			[JsonProperty(PropertyName = "DingRobot")]
			public string DingRobot
			{
				get
				{
					return dingRobot;
				}
				set	
				{
					dingRobot = value;
				}
			}

			[JsonProperty(PropertyName = "Webhook")]
			public string Webhook
			{
				get
				{
					return webhook;
				}
				set	
				{
					webhook = value;
				}
			}

			[JsonProperty(PropertyName = "SignatureMethod")]
			public string SignatureMethod
			{
				get
				{
					return signatureMethod;
				}
				set	
				{
					signatureMethod = value;
				}
			}

			[JsonProperty(PropertyName = "NotificationMode")]
			public string NotificationMode
			{
				get
				{
					return notificationMode;
				}
				set	
				{
					notificationMode = value;
				}
			}

			[JsonProperty(PropertyName = "RoleIdList")]
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

			[JsonProperty(PropertyName = "RoleNameList")]
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
