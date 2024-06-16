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
	public class ListLiveMessageGroupUsersResponse : AcsResponse
	{

		private string requestId;

		private string groupId;

		private long? nextPageToken;

		private bool? hasmore;

		private List<ListLiveMessageGroupUsers_Users> userList;

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

		[JsonProperty(PropertyName = "GroupId")]
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

		[JsonProperty(PropertyName = "NextPageToken")]
		public long? NextPageToken
		{
			get
			{
				return nextPageToken;
			}
			set	
			{
				nextPageToken = value;
			}
		}

		[JsonProperty(PropertyName = "Hasmore")]
		public bool? Hasmore
		{
			get
			{
				return hasmore;
			}
			set	
			{
				hasmore = value;
			}
		}

		[JsonProperty(PropertyName = "UserList")]
		public List<ListLiveMessageGroupUsers_Users> UserList
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

		public class ListLiveMessageGroupUsers_Users
		{

			private string userId;

			private string userInfo;

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

			[JsonProperty(PropertyName = "UserInfo")]
			public string UserInfo
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
		}
	}
}
