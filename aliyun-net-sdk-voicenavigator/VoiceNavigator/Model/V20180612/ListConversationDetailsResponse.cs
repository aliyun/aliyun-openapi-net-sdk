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
	public class ListConversationDetailsResponse : AcsResponse
	{

		private string requestId;

		private List<ListConversationDetails_ConversationDetail> conversationDetails;

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

		public List<ListConversationDetails_ConversationDetail> ConversationDetails
		{
			get
			{
				return conversationDetails;
			}
			set	
			{
				conversationDetails = value;
			}
		}

		public class ListConversationDetails_ConversationDetail
		{

			private string conversationId;

			private string speaker;

			private string utterance;

			private string action;

			private string actionParams;

			private long? createTime;

			private string sequenceId;

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

			public string Speaker
			{
				get
				{
					return speaker;
				}
				set	
				{
					speaker = value;
				}
			}

			public string Utterance
			{
				get
				{
					return utterance;
				}
				set	
				{
					utterance = value;
				}
			}

			public string Action
			{
				get
				{
					return action;
				}
				set	
				{
					action = value;
				}
			}

			public string ActionParams
			{
				get
				{
					return actionParams;
				}
				set	
				{
					actionParams = value;
				}
			}

			public long? CreateTime
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

			public string SequenceId
			{
				get
				{
					return sequenceId;
				}
				set	
				{
					sequenceId = value;
				}
			}
		}
	}
}
