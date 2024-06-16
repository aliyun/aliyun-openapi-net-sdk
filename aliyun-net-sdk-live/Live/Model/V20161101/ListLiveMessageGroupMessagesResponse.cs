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
	public class ListLiveMessageGroupMessagesResponse : AcsResponse
	{

		private string requestId;

		private string groupId;

		private long? nextPageToken;

		private bool? hasmore;

		private List<ListLiveMessageGroupMessages_Messages> messageList;

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

		[JsonProperty(PropertyName = "MessageList")]
		public List<ListLiveMessageGroupMessages_Messages> MessageList
		{
			get
			{
				return messageList;
			}
			set	
			{
				messageList = value;
			}
		}

		public class ListLiveMessageGroupMessages_Messages
		{

			private string body;

			private long? timestamp;

			private string msgTid;

			private long? msgType;

			private long? seqNumber;

			private long? totalMessages;

			private ListLiveMessageGroupMessages_Sender sender;

			[JsonProperty(PropertyName = "Body")]
			public string Body
			{
				get
				{
					return body;
				}
				set	
				{
					body = value;
				}
			}

			[JsonProperty(PropertyName = "Timestamp")]
			public long? Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
				}
			}

			[JsonProperty(PropertyName = "MsgTid")]
			public string MsgTid
			{
				get
				{
					return msgTid;
				}
				set	
				{
					msgTid = value;
				}
			}

			[JsonProperty(PropertyName = "MsgType")]
			public long? MsgType
			{
				get
				{
					return msgType;
				}
				set	
				{
					msgType = value;
				}
			}

			[JsonProperty(PropertyName = "SeqNumber")]
			public long? SeqNumber
			{
				get
				{
					return seqNumber;
				}
				set	
				{
					seqNumber = value;
				}
			}

			[JsonProperty(PropertyName = "TotalMessages")]
			public long? TotalMessages
			{
				get
				{
					return totalMessages;
				}
				set	
				{
					totalMessages = value;
				}
			}

			[JsonProperty(PropertyName = "Sender")]
			public ListLiveMessageGroupMessages_Sender Sender
			{
				get
				{
					return sender;
				}
				set	
				{
					sender = value;
				}
			}

			public class ListLiveMessageGroupMessages_Sender
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
}
