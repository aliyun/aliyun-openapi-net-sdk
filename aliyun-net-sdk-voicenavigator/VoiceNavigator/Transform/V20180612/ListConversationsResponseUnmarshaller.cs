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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class ListConversationsResponseUnmarshaller
    {
        public static ListConversationsResponse Unmarshall(UnmarshallerContext context)
        {
			ListConversationsResponse listConversationsResponse = new ListConversationsResponse();

			listConversationsResponse.HttpResponse = context.HttpResponse;
			listConversationsResponse.RequestId = context.StringValue("ListConversations.RequestId");
			listConversationsResponse.TotalCount = context.LongValue("ListConversations.TotalCount");
			listConversationsResponse.PageNumber = context.IntegerValue("ListConversations.PageNumber");
			listConversationsResponse.PageSize = context.IntegerValue("ListConversations.PageSize");

			List<ListConversationsResponse.ListConversations_Conversation> listConversationsResponse_conversations = new List<ListConversationsResponse.ListConversations_Conversation>();
			for (int i = 0; i < context.Length("ListConversations.Conversations.Length"); i++) {
				ListConversationsResponse.ListConversations_Conversation conversation = new ListConversationsResponse.ListConversations_Conversation();
				conversation.CallingNumber = context.StringValue("ListConversations.Conversations["+ i +"].CallingNumber");
				conversation.BeginTime = context.LongValue("ListConversations.Conversations["+ i +"].BeginTime");
				conversation.EndTime = context.LongValue("ListConversations.Conversations["+ i +"].EndTime");
				conversation.TransferredToAgent = context.BooleanValue("ListConversations.Conversations["+ i +"].TransferredToAgent");
				conversation.SkillGroupId = context.StringValue("ListConversations.Conversations["+ i +"].SkillGroupId");
				conversation.UserUtteranceCount = context.IntegerValue("ListConversations.Conversations["+ i +"].UserUtteranceCount");
				conversation.EffectiveAnswerCount = context.IntegerValue("ListConversations.Conversations["+ i +"].EffectiveAnswerCount");
				conversation.ConversationId = context.StringValue("ListConversations.Conversations["+ i +"].ConversationId");

				listConversationsResponse_conversations.Add(conversation);
			}
			listConversationsResponse.Conversations = listConversationsResponse_conversations;
        
			return listConversationsResponse;
        }
    }
}
