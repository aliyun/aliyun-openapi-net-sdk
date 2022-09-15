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
	public class ListMessageResponse : AcsResponse
	{

		private string requestId;

		private ListMessage_Result result;

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
		public ListMessage_Result Result
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

		public class ListMessage_Result
		{

			private bool? hasMore;

			private List<ListMessage_MessageListItem> messageList;

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

			[JsonProperty(PropertyName = "MessageList")]
			public List<ListMessage_MessageListItem> MessageList
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

			public class ListMessage_MessageListItem
			{

				private string groupId;

				private string messageId;

				private int? type;

				private string senderId;

				private string data;

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

				[JsonProperty(PropertyName = "MessageId")]
				public string MessageId
				{
					get
					{
						return messageId;
					}
					set	
					{
						messageId = value;
					}
				}

				[JsonProperty(PropertyName = "Type")]
				public int? Type
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

				[JsonProperty(PropertyName = "SenderId")]
				public string SenderId
				{
					get
					{
						return senderId;
					}
					set	
					{
						senderId = value;
					}
				}

				[JsonProperty(PropertyName = "Data")]
				public string Data
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
			}
		}
	}
}
