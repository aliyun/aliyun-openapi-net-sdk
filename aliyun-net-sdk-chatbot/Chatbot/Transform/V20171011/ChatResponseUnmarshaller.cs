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
            ChatResponse chatResponse = new ChatResponse
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("Chat.RequestId"),
                SessionId = context.StringValue("Chat.SessionId"),
                MessageId = context.StringValue("Chat.MessageId"),
                Tag = context.StringValue("Chat.Tag")
            };

            List<ChatResponse.Chat_Message> chatResponse_messages = new List<ChatResponse.Chat_Message>();
			for (int i = 0; i < context.Length("Chat.Messages.Length"); i++) {
                ChatResponse.Chat_Message message = new ChatResponse.Chat_Message
                {
                    Type = context.StringValue("Chat.Messages[" + i + "].Type")
                };

                ChatResponse.Chat_Message.Chat_Text text = new ChatResponse.Chat_Message.Chat_Text
                {
                    Content = context.StringValue("Chat.Messages[" + i + "].Text.Content"),
                    AnswerSource = context.StringValue("Chat.Messages[" + i + "].Text.AnswerSource"),
                    MetaData = context.StringValue("Chat.Messages[" + i + "].Text.MetaData")
                };
                message.Text = text;

                ChatResponse.Chat_Message.Chat_Knowledge knowledge = new ChatResponse.Chat_Message.Chat_Knowledge
                {
                    Id = context.StringValue("Chat.Messages[" + i + "].Knowledge.Id"),
                    Title = context.StringValue("Chat.Messages[" + i + "].Knowledge.Title"),
                    Summary = context.StringValue("Chat.Messages[" + i + "].Knowledge.Summary"),
                    Content = context.StringValue("Chat.Messages[" + i + "].Knowledge.Content"),
                    AnswerSource = context.StringValue("Chat.Messages[" + i + "].Knowledge.AnswerSource")
                };
                message.Knowledge = knowledge;

				List<ChatResponse.Chat_Message.Chat_Recommend> message_recommends = new List<ChatResponse.Chat_Message.Chat_Recommend>();
				for (int j = 0; j < context.Length("Chat.Messages["+ i +"].Recommends.Length"); j++) {
                    ChatResponse.Chat_Message.Chat_Recommend recommend = new ChatResponse.Chat_Message.Chat_Recommend
                    {
                        KnowledgeId = context.StringValue("Chat.Messages[" + i + "].Recommends[" + j + "].KnowledgeId"),
                        Title = context.StringValue("Chat.Messages[" + i + "].Recommends[" + j + "].Title"),
                        AnswerSource = context.StringValue("Chat.Messages[" + i + "].Recommends[" + j + "].AnswerSource"),
                        Summary = context.StringValue("Chat.Messages[" + i + "].Recommends[" + j + "].Summary"),
                        Content = context.StringValue("Chat.Messages[" + i + "].Recommends[" + j + "].Content")
                    };

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