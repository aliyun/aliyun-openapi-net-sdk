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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Chatbot.Model.V20171011;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Transform.V20171011
{
    public class ChatResponseUnmarshaller
    {
        public static ChatResponse Unmarshall(UnmarshallerContext context)
        {
			ChatResponse chatResponse = new ChatResponse();

			chatResponse.HttpResponse = context.HttpResponse;
			chatResponse.RequestId = context.StringValue("Chat.RequestId");
			chatResponse.SessionId = context.StringValue("Chat.SessionId");
			chatResponse.MessageId = context.StringValue("Chat.MessageId");
			chatResponse.Tag = context.StringValue("Chat.Tag");

			List<ChatResponse.Chat_Message> chatResponse_messages = new List<ChatResponse.Chat_Message>();
			for (int i = 0; i < context.Length("Chat.Messages.Length"); i++) {
				ChatResponse.Chat_Message message = new ChatResponse.Chat_Message();
				message.Type = context.StringValue("Chat.Messages["+ i +"].Type");

				ChatResponse.Chat_Message.Chat_Text text = new ChatResponse.Chat_Message.Chat_Text();
				text.Content = context.StringValue("Chat.Messages["+ i +"].Text.Content");
				text.AnswerSource = context.StringValue("Chat.Messages["+ i +"].Text.AnswerSource");
				message.Text = text;

				ChatResponse.Chat_Message.Chat_Knowledge knowledge = new ChatResponse.Chat_Message.Chat_Knowledge();
				knowledge.Id = context.StringValue("Chat.Messages["+ i +"].Knowledge.Id");
				knowledge.Title = context.StringValue("Chat.Messages["+ i +"].Knowledge.Title");
				knowledge.Summary = context.StringValue("Chat.Messages["+ i +"].Knowledge.Summary");
				knowledge.Content = context.StringValue("Chat.Messages["+ i +"].Knowledge.Content");
				knowledge.AnswerSource = context.StringValue("Chat.Messages["+ i +"].Knowledge.AnswerSource");
				message.Knowledge = knowledge;

				List<ChatResponse.Chat_Message.Chat_Recommend> message_recommends = new List<ChatResponse.Chat_Message.Chat_Recommend>();
				for (int j = 0; j < context.Length("Chat.Messages["+ i +"].Recommends.Length"); j++) {
					ChatResponse.Chat_Message.Chat_Recommend recommend = new ChatResponse.Chat_Message.Chat_Recommend();
					recommend.KnowledgeId = context.StringValue("Chat.Messages["+ i +"].Recommends["+ j +"].KnowledgeId");
					recommend.Title = context.StringValue("Chat.Messages["+ i +"].Recommends["+ j +"].Title");
					recommend.AnswerSource = context.StringValue("Chat.Messages["+ i +"].Recommends["+ j +"].AnswerSource");

					message_recommends.Add(recommend);
				}
				message.Recommends = message_recommends;

				chatResponse_messages.Add(message);
			}
			chatResponse.Messages = chatResponse_messages;
        
			return chatResponse;
        }
    }
}