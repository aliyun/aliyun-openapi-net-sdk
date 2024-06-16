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
	public class ListMessageGroupUserByIdResponse : AcsResponse
	{

		private string requestId;

		private ListMessageGroupUserById_Result result;

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
		public ListMessageGroupUserById_Result Result
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

		public class ListMessageGroupUserById_Result
		{

			private bool? hasMore;

			private int? total;

			private List<ListMessageGroupUserById_UserListItem> userList;

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
			public List<ListMessageGroupUserById_UserListItem> UserList
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

			public class ListMessageGroupUserById_UserListItem
			{

				private bool? isMute;

				private string userAvatar;

				private string userExtension;

				private string userId;

				private string userNick;

				private List<string> muteBy;

				[JsonProperty(PropertyName = "IsMute")]
				public bool? IsMute
				{
					get
					{
						return isMute;
					}
					set	
					{
						isMute = value;
					}
				}

				[JsonProperty(PropertyName = "UserAvatar")]
				public string UserAvatar
				{
					get
					{
						return userAvatar;
					}
					set	
					{
						userAvatar = value;
					}
				}

				[JsonProperty(PropertyName = "UserExtension")]
				public string UserExtension
				{
					get
					{
						return userExtension;
					}
					set	
					{
						userExtension = value;
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

				[JsonProperty(PropertyName = "UserNick")]
				public string UserNick
				{
					get
					{
						return userNick;
					}
					set	
					{
						userNick = value;
					}
				}

				[JsonProperty(PropertyName = "MuteBy")]
				public List<string> MuteBy
				{
					get
					{
						return muteBy;
					}
					set	
					{
						muteBy = value;
					}
				}
			}
		}
	}
}
