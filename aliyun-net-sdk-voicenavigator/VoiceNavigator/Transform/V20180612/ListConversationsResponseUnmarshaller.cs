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
        public static ListConversationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListConversationsResponse listConversationsResponse = new ListConversationsResponse();

			listConversationsResponse.HttpResponse = _ctx.HttpResponse;
			listConversationsResponse.TotalCount = _ctx.LongValue("ListConversations.TotalCount");
			listConversationsResponse.PageSize = _ctx.IntegerValue("ListConversations.PageSize");
			listConversationsResponse.RequestId = _ctx.StringValue("ListConversations.RequestId");
			listConversationsResponse.PageNumber = _ctx.IntegerValue("ListConversations.PageNumber");

			List<ListConversationsResponse.ListConversations_Conversation> listConversationsResponse_conversations = new List<ListConversationsResponse.ListConversations_Conversation>();
			for (int i = 0; i < _ctx.Length("ListConversations.Conversations.Length"); i++) {
				ListConversationsResponse.ListConversations_Conversation conversation = new ListConversationsResponse.ListConversations_Conversation();
				conversation.EndTime = _ctx.LongValue("ListConversations.Conversations["+ i +"].EndTime");
				conversation.HasToAgent = _ctx.BooleanValue("ListConversations.Conversations["+ i +"].HasToAgent");
				conversation.StartTime = _ctx.LongValue("ListConversations.Conversations["+ i +"].StartTime");
				conversation.SkillGroup = _ctx.StringValue("ListConversations.Conversations["+ i +"].SkillGroup");
				conversation.ConversationId = _ctx.StringValue("ListConversations.Conversations["+ i +"].ConversationId");
				conversation.CallingNumber = _ctx.StringValue("ListConversations.Conversations["+ i +"].CallingNumber");
				conversation.EndReason = _ctx.IntegerValue("ListConversations.Conversations["+ i +"].EndReason");
				conversation.Rounds = _ctx.IntegerValue("ListConversations.Conversations["+ i +"].Rounds");
				conversation.HasLastPlaybackCompleted = _ctx.BooleanValue("ListConversations.Conversations["+ i +"].HasLastPlaybackCompleted");
				conversation.SandBox = _ctx.BooleanValue("ListConversations.Conversations["+ i +"].SandBox");

				listConversationsResponse_conversations.Add(conversation);
			}
			listConversationsResponse.Conversations = listConversationsResponse_conversations;
        
			return listConversationsResponse;
        }
    }
}
