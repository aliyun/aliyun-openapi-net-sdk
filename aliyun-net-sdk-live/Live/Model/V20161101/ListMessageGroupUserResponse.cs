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
	public class ListMessageGroupUserResponse : AcsResponse
	{

		private string requestId;

		private ListMessageGroupUser_Result result;

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
		public ListMessageGroupUser_Result Result
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

		public class ListMessageGroupUser_Result
		{

			private bool? hasMore;

			private int? total;

			private List<ListMessageGroupUser_UserListItem> userList;

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

			[JsonProperty(PropertyName = "UserList")]
			public List<ListMessageGroupUser_UserListItem> UserList
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

			public class ListMessageGroupUser_UserListItem
			{

				private long? joinTime;

				private string userId;

				[JsonProperty(PropertyName = "JoinTime")]
				public long? JoinTime
				{
					get
					{
						return joinTime;
					}
					set	
					{
						joinTime = value;
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
			}
		}
	}
}
