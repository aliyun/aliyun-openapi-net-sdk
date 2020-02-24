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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class ListConversationsWithUnrecognizedIntentsResponseUnmarshaller
    {
        public static ListConversationsWithUnrecognizedIntentsResponse Unmarshall(UnmarshallerContext context)
        {
			ListConversationsWithUnrecognizedIntentsResponse listConversationsWithUnrecognizedIntentsResponse = new ListConversationsWithUnrecognizedIntentsResponse();

			listConversationsWithUnrecognizedIntentsResponse.HttpResponse = context.HttpResponse;
			listConversationsWithUnrecognizedIntentsResponse.RequestId = context.StringValue("ListConversationsWithUnrecognizedIntents.RequestId");
			listConversationsWithUnrecognizedIntentsResponse.Success = context.BooleanValue("ListConversationsWithUnrecognizedIntents.Success");
			listConversationsWithUnrecognizedIntentsResponse.Code = context.StringValue("ListConversationsWithUnrecognizedIntents.Code");
			listConversationsWithUnrecognizedIntentsResponse.Message = context.StringValue("ListConversationsWithUnrecognizedIntents.Message");
			listConversationsWithUnrecognizedIntentsResponse.HttpStatusCode = context.IntegerValue("ListConversationsWithUnrecognizedIntents.HttpStatusCode");

			List<ListConversationsWithUnrecognizedIntentsResponse.ListConversationsWithUnrecognizedIntents_ConversationsWithUnrecognizedIntent> listConversationsWithUnrecognizedIntentsResponse_conversationsWithUnrecognizedIntents = new List<ListConversationsWithUnrecognizedIntentsResponse.ListConversationsWithUnrecognizedIntents_ConversationsWithUnrecognizedIntent>();
			for (int i = 0; i < context.Length("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents.Length"); i++) {
				ListConversationsWithUnrecognizedIntentsResponse.ListConversationsWithUnrecognizedIntents_ConversationsWithUnrecognizedIntent conversationsWithUnrecognizedIntent = new ListConversationsWithUnrecognizedIntentsResponse.ListConversationsWithUnrecognizedIntents_ConversationsWithUnrecognizedIntent();
				conversationsWithUnrecognizedIntent.ConversationsWithUnrecognizedIntentId = context.StringValue("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents["+ i +"].ConversationsWithUnrecognizedIntentId");
				conversationsWithUnrecognizedIntent.JobId = context.StringValue("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents["+ i +"].JobId");

				ListConversationsWithUnrecognizedIntentsResponse.ListConversationsWithUnrecognizedIntents_ConversationsWithUnrecognizedIntent.ListConversationsWithUnrecognizedIntents_Contact contact = new ListConversationsWithUnrecognizedIntentsResponse.ListConversationsWithUnrecognizedIntents_ConversationsWithUnrecognizedIntent.ListConversationsWithUnrecognizedIntents_Contact();
				contact.ContactId = context.StringValue("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents["+ i +"].Contact.ContactId");
				contact.ContactName = context.StringValue("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents["+ i +"].Contact.ContactName");
				contact.Honorific = context.StringValue("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents["+ i +"].Contact.Honorific");
				contact.Role = context.StringValue("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents["+ i +"].Contact.Role");
				contact.PhoneNumber = context.StringValue("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents["+ i +"].Contact.PhoneNumber");
				contact.State = context.StringValue("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents["+ i +"].Contact.State");
				contact.ReferenceId = context.StringValue("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents["+ i +"].Contact.ReferenceId");
				contact.JobId = context.StringValue("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents["+ i +"].Contact.JobId");
				conversationsWithUnrecognizedIntent.Contact = contact;

				List<ListConversationsWithUnrecognizedIntentsResponse.ListConversationsWithUnrecognizedIntents_ConversationsWithUnrecognizedIntent.ListConversationsWithUnrecognizedIntents_ConversationDetail> conversationsWithUnrecognizedIntent_conversation = new List<ListConversationsWithUnrecognizedIntentsResponse.ListConversationsWithUnrecognizedIntents_ConversationsWithUnrecognizedIntent.ListConversationsWithUnrecognizedIntents_ConversationDetail>();
				for (int j = 0; j < context.Length("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents["+ i +"].Conversation.Length"); j++) {
					ListConversationsWithUnrecognizedIntentsResponse.ListConversationsWithUnrecognizedIntents_ConversationsWithUnrecognizedIntent.ListConversationsWithUnrecognizedIntents_ConversationDetail conversationDetail = new ListConversationsWithUnrecognizedIntentsResponse.ListConversationsWithUnrecognizedIntents_ConversationsWithUnrecognizedIntent.ListConversationsWithUnrecognizedIntents_ConversationDetail();
					conversationDetail.Id = context.StringValue("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents["+ i +"].Conversation["+ j +"].Id");
					conversationDetail.Timestamp = context.LongValue("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents["+ i +"].Conversation["+ j +"].Timestamp");
					conversationDetail.Speaker = context.StringValue("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents["+ i +"].Conversation["+ j +"].Speaker");
					conversationDetail.Script = context.StringValue("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents["+ i +"].Conversation["+ j +"].Script");
					conversationDetail.NodeId = context.StringValue("ListConversationsWithUnrecognizedIntents.ConversationsWithUnrecognizedIntents["+ i +"].Conversation["+ j +"].NodeId");

					conversationsWithUnrecognizedIntent_conversation.Add(conversationDetail);
				}
				conversationsWithUnrecognizedIntent.Conversation = conversationsWithUnrecognizedIntent_conversation;

				listConversationsWithUnrecognizedIntentsResponse_conversationsWithUnrecognizedIntents.Add(conversationsWithUnrecognizedIntent);
			}
			listConversationsWithUnrecognizedIntentsResponse.ConversationsWithUnrecognizedIntents = listConversationsWithUnrecognizedIntentsResponse_conversationsWithUnrecognizedIntents;
        
			return listConversationsWithUnrecognizedIntentsResponse;
        }
    }
}
