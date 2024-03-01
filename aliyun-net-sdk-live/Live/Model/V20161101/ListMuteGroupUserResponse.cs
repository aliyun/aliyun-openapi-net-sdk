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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class ListMuteGroupUserResponse : AcsResponse
	{

		private string requestId;

		private ListMuteGroupUser_Result result;

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

		[JsonProperty(PropertyName = "Result")]
		public ListMuteGroupUser_Result Result
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

		public class ListMuteGroupUser_Result
		{

			private int? total;

			private bool? hasMore;

			private List<ListMuteGroupUser_UserListItem> userList;

			[JsonProperty(PropertyName = "Total")]
			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			[JsonProperty(PropertyName = "HasMore")]
			public bool? HasMore
			{
				get
				{
					return hasMore;
				}
				set	
				{
					hasMore = value;
				}
			}

			[JsonProperty(PropertyName = "UserList")]
			public List<ListMuteGroupUser_UserListItem> UserList
			{
				get
				{
					return userList;
				}
				set	
				{
					userList = value;
				}
			}

			public class ListMuteGroupUser_UserListItem
			{

				private string userId;

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
			}
		}
	}
}
