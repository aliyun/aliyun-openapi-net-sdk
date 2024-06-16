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
	public class ListEventSubResponse : AcsResponse
	{

		private string requestId;

		private List<ListEventSub_Data> subscribers;

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

		[JsonProperty(PropertyName = "Subscribers")]
		public List<ListEventSub_Data> Subscribers
		{
			get
			{
				return subscribers;
			}
			set	
			{
				subscribers = value;
			}
		}

		public class ListEventSub_Data
		{

			private string subId;

			private string channelId;

			private string callbackUrl;

			private string createTime;

			private string modifyTime;

			private int? roles;

			private List<string> events;

			private List<string> users;

			[JsonProperty(PropertyName = "SubId")]
			public string SubId
			{
				get
				{
					return subId;
				}
				set	
				{
					subId = value;
				}
			}

			[JsonProperty(PropertyName = "ChannelId")]
			public string ChannelId
			{
				get
				{
					return channelId;
				}
				set	
				{
					channelId = value;
				}
			}

			[JsonProperty(PropertyName = "CallbackUrl")]
			public string CallbackUrl
			{
				get
				{
					return callbackUrl;
				}
				set	
				{
					callbackUrl = value;
				}
			}

			[JsonProperty(PropertyName = "CreateTime")]
			public string CreateTime
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

			[JsonProperty(PropertyName = "ModifyTime")]
			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			[JsonProperty(PropertyName = "Roles")]
			public int? Roles
			{
				get
				{
					return roles;
				}
				set	
				{
					roles = value;
				}
			}

			[JsonProperty(PropertyName = "Events")]
			public List<string> Events
			{
				get
				{
					return events;
				}
				set	
				{
					events = value;
				}
			}

			[JsonProperty(PropertyName = "Users")]
			public List<string> Users
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
		}
	}
}
