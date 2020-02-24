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

namespace Aliyun.Acs.VoiceNavigator.Model.V20180612
{
	public class ListConversationsResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<ListConversations_Conversation> conversations;

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

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<ListConversations_Conversation> Conversations
		{
			get
			{
				return conversations;
			}
			set	
			{
				conversations = value;
			}
		}

		public class ListConversations_Conversation
		{

			private string callingNumber;

			private long? beginTime;

			private long? endTime;

			private bool? transferredToAgent;

			private string skillGroupId;

			private int? userUtteranceCount;

			private int? effectiveAnswerCount;

			private string conversationId;

			public string CallingNumber
			{
				get
				{
					return callingNumber;
				}
				set	
				{
					callingNumber = value;
				}
			}

			public long? BeginTime
			{
				get
				{
					return beginTime;
				}
				set	
				{
					beginTime = value;
				}
			}

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public bool? TransferredToAgent
			{
				get
				{
					return transferredToAgent;
				}
				set	
				{
					transferredToAgent = value;
				}
			}

			public string SkillGroupId
			{
				get
				{
					return skillGroupId;
				}
				set	
				{
					skillGroupId = value;
				}
			}

			public int? UserUtteranceCount
			{
				get
				{
					return userUtteranceCount;
				}
				set	
				{
					userUtteranceCount = value;
				}
			}

			public int? EffectiveAnswerCount
			{
				get
				{
					return effectiveAnswerCount;
				}
				set	
				{
					effectiveAnswerCount = value;
				}
			}

			public string ConversationId
			{
				get
				{
					return conversationId;
				}
				set	
				{
					conversationId = value;
				}
			}
		}
	}
}
