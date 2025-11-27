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
	public class RemoveUsersResponse : AcsResponse
	{

		private string requestId;

		private RemoveUsers_RemoveUsersResult removeUsersResult;

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

		[JsonProperty(PropertyName = "RemoveUsersResult")]
		public RemoveUsers_RemoveUsersResult RemoveUsersResult
		{
			get
			{
				return removeUsersResult;
			}
			set	
			{
				removeUsersResult = value;
			}
		}

		public class RemoveUsers_RemoveUsersResult
		{

			private List<RemoveUsers_FailedUsersItem> failedUsers;

			private List<string> removedUsers;

			[JsonProperty(PropertyName = "FailedUsers")]
			public List<RemoveUsers_FailedUsersItem> FailedUsers
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

			[JsonProperty(PropertyName = "RemovedUsers")]
			public List<string> RemovedUsers
			{
				get
				{
					return removedUsers;
				}
				set	
				{
					removedUsers = value;
				}
			}

			public class RemoveUsers_FailedUsersItem
			{

				private string endUserId;

				private string errorCode;

				private string errorMessage;

				[JsonProperty(PropertyName = "EndUserId")]
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
			}
		}
	}
}
