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

namespace Aliyun.Acs.companyreg.Model.V20200306
{
	public class BindProduceAuthorizationResponse : AcsResponse
	{

		private string requestId;

		private string errorMsg;

		private string errorCode;

		private BindProduceAuthorization_Data data;

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

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
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

		public BindProduceAuthorization_Data Data
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

		public class BindProduceAuthorization_Data
		{

			private bool? success;

			private string message;

			private List<BindProduceAuthorization_AuthorizedUserListItem> authorizedUserList;

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

			public List<BindProduceAuthorization_AuthorizedUserListItem> AuthorizedUserList
			{
				get
				{
					return authorizedUserList;
				}
				set	
				{
					authorizedUserList = value;
				}
			}

			public class BindProduceAuthorization_AuthorizedUserListItem
			{

				private string userId;

				private string userName;

				private int? accountValidType;

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

				public int? AccountValidType
				{
					get
					{
						return accountValidType;
					}
					set	
					{
						accountValidType = value;
					}
				}
			}
		}
	}
}
