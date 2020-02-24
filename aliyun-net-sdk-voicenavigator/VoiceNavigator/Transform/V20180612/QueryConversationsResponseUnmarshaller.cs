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
    public class QueryConversationsResponseUnmarshaller
    {
        public static QueryConversationsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryConversationsResponse queryConversationsResponse = new QueryConversationsResponse();

			queryConversationsResponse.HttpResponse = context.HttpResponse;
			queryConversationsResponse.RequestId = context.StringValue("QueryConversations.RequestId");
			queryConversationsResponse.TotalCount = context.LongValue("QueryConversations.TotalCount");
			queryConversationsResponse.PageNumber = context.IntegerValue("QueryConversations.PageNumber");
			queryConversationsResponse.PageSize = context.IntegerValue("QueryConversations.PageSize");

			List<QueryConversationsResponse.QueryConversations_Conversation> queryConversationsResponse_conversations = new List<QueryConversationsResponse.QueryConversations_Conversation>();
			for (int i = 0; i < context.Length("QueryConversations.Conversations.Length"); i++) {
				QueryConversationsResponse.QueryConversations_Conversation conversation = new QueryConversationsResponse.QueryConversations_Conversation();
				conversation.CallingNumber = context.StringValue("QueryConversations.Conversations["+ i +"].CallingNumber");
				conversation.BeginTime = context.LongValue("QueryConversations.Conversations["+ i +"].BeginTime");
				conversation.EndTime = context.LongValue("QueryConversations.Conversations["+ i +"].EndTime");
				conversation.TransferredToAgent = context.BooleanValue("QueryConversations.Conversations["+ i +"].TransferredToAgent");
				conversation.SkillGroupId = context.StringValue("QueryConversations.Conversations["+ i +"].SkillGroupId");
				conversation.UserUtteranceCount = context.IntegerValue("QueryConversations.Conversations["+ i +"].UserUtteranceCount");
				conversation.EffectiveAnswerCount = context.IntegerValue("QueryConversations.Conversations["+ i +"].EffectiveAnswerCount");
				conversation.ConversationId = context.StringValue("QueryConversations.Conversations["+ i +"].ConversationId");

				queryConversationsResponse_conversations.Add(conversation);
			}
			queryConversationsResponse.Conversations = queryConversationsResponse_conversations;
        
			return queryConversationsResponse;
        }
    }
}
