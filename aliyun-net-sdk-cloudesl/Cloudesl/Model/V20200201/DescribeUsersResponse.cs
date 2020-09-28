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

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
	public class DescribeUsersResponse : AcsResponse
	{

		private string errorMessage;

		private string errorCode;

		private string message;

		private int? pageNumber;

		private string dynamicCode;

		private string code;

		private int? totalCount;

		private string dynamicMessage;

		private string requestId;

		private bool? success;

		private int? pageSize;

		private List<DescribeUsers_UserInfo> users;

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

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

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

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
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

		public List<DescribeUsers_UserInfo> Users
		{
			get
			{
				return users;
			}
			set	
			{
				users = value;
			}
		}

		public class DescribeUsers_UserInfo
		{

			private string stores;

			private string userName;

			private string userId;

			private string userType;

			private string ownerId;

			private string bid;

			private List<DescribeUsers_DingTalkInfo> dingTalkInfos;

			public string Stores
			{
				get
				{
					return stores;
				}
				set	
				{
					stores = value;
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

			public string UserType
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

			public string Bid
			{
				get
				{
					return bid;
				}
				set	
				{
					bid = value;
				}
			}

			public List<DescribeUsers_DingTalkInfo> DingTalkInfos
			{
				get
				{
					return dingTalkInfos;
				}
				set	
				{
					dingTalkInfos = value;
				}
			}

			public class DescribeUsers_DingTalkInfo
			{

				private string dingTalkCompanyId;

				private string dingTalkUserId;

				public string DingTalkCompanyId
				{
					get
					{
						return dingTalkCompanyId;
					}
					set	
					{
						dingTalkCompanyId = value;
					}
				}

				public string DingTalkUserId
				{
					get
					{
						return dingTalkUserId;
					}
					set	
					{
						dingTalkUserId = value;
					}
				}
			}
		}
	}
}
