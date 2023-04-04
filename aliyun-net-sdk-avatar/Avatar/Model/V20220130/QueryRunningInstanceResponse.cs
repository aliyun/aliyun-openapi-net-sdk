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

namespace Aliyun.Acs.avatar.Model.V20220130
{
	public class QueryRunningInstanceResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private bool? success;

		private List<QueryRunningInstance_DataItem> data;

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

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "Data")]
		public List<QueryRunningInstance_DataItem> Data
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

		public class QueryRunningInstance_DataItem
		{

			private string sessionId;

			private QueryRunningInstance_Channel channel;

			private QueryRunningInstance_User user;

			[JsonProperty(PropertyName = "SessionId")]
			public string SessionId
			{
				get
				{
					return sessionId;
				}
				set	
				{
					sessionId = value;
				}
			}

			[JsonProperty(PropertyName = "Channel")]
			public QueryRunningInstance_Channel Channel
			{
				get
				{
					return channel;
				}
				set	
				{
					channel = value;
				}
			}

			[JsonProperty(PropertyName = "User")]
			public QueryRunningInstance_User User
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

			public class QueryRunningInstance_Channel
			{

				private string channelId;

				private string token;

				private string type;

				private string expiredTime;

				private string nonce;

				private string userId;

				private string appId;

				private string userInfoInChannel;

				private List<string> gslb;

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

				[JsonProperty(PropertyName = "Token")]
				public string Token
				{
					get
					{
						return token;
					}
					set	
					{
						token = value;
					}
				}

				[JsonProperty(PropertyName = "Type")]
				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				[JsonProperty(PropertyName = "ExpiredTime")]
				public string ExpiredTime
				{
					get
					{
						return expiredTime;
					}
					set	
					{
						expiredTime = value;
					}
				}

				[JsonProperty(PropertyName = "Nonce")]
				public string Nonce
				{
					get
					{
						return nonce;
					}
					set	
					{
						nonce = value;
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

				[JsonProperty(PropertyName = "AppId")]
				public string AppId
				{
					get
					{
						return appId;
					}
					set	
					{
						appId = value;
					}
				}

				[JsonProperty(PropertyName = "UserInfoInChannel")]
				public string UserInfoInChannel
				{
					get
					{
						return userInfoInChannel;
					}
					set	
					{
						userInfoInChannel = value;
					}
				}

				[JsonProperty(PropertyName = "Gslb")]
				public List<string> Gslb
				{
					get
					{
						return gslb;
					}
					set	
					{
						gslb = value;
					}
				}
			}

			public class QueryRunningInstance_User
			{

				private string userId;

				private string userName;

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

				[JsonProperty(PropertyName = "UserName")]
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
			}
		}
	}
}
