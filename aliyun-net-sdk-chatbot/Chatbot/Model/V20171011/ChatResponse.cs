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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Model.V20171011
{
	public class ChatResponse : AcsResponse
	{

		private string requestId;

		private string sessionId;

		private string messageId;

		private string tag;

		private List<Chat_Message> messages;

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

		public string SessionId
		{
			get
			{
				return sessionId;
			}
			set	
			{
				sessionId = value;
			}
		}

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

		public string Tag
		{
			get
			{
				return tag;
			}
			set	
			{
				tag = value;
			}
		}

		public List<Chat_Message> Messages
		{
			get
			{
				return messages;
			}
			set	
			{
				messages = value;
			}
		}

		public class Chat_Message
		{

			private string type;

			private List<Chat_Recommend> recommends;

			private Chat_Text text;

			private Chat_Knowledge knowledge;

			public string Type
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

			public List<Chat_Recommend> Recommends
			{
				get
				{
					return recommends;
				}
				set	
				{
					recommends = value;
				}
			}

			public Chat_Text Text
			{
				get
				{
					return text;
				}
				set	
				{
					text = value;
				}
			}

			public Chat_Knowledge Knowledge
			{
				get
				{
					return knowledge;
				}
				set	
				{
					knowledge = value;
				}
			}

			public class Chat_Recommend
			{

				private string knowledgeId;

				private string title;

				private string answerSource;

				public string KnowledgeId
				{
					get
					{
						return knowledgeId;
					}
					set	
					{
						knowledgeId = value;
					}
				}

				public string Title
				{
					get
					{
						return title;
					}
					set	
					{
						title = value;
					}
				}

				public string AnswerSource
				{
					get
					{
						return answerSource;
					}
					set	
					{
						answerSource = value;
					}
				}
			}

			public class Chat_Text
			{

				private string content;

				private string answerSource;

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}

				public string AnswerSource
				{
					get
					{
						return answerSource;
					}
					set	
					{
						answerSource = value;
					}
				}
			}

			public class Chat_Knowledge
			{

				private string id;

				private string title;

				private string summary;

				private string content;

				private string answerSource;

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string Title
				{
					get
					{
						return title;
					}
					set	
					{
						title = value;
					}
				}

				public string Summary
				{
					get
					{
						return summary;
					}
					set	
					{
						summary = value;
					}
				}

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}

				public string AnswerSource
				{
					get
					{
						return answerSource;
					}
					set	
					{
						answerSource = value;
					}
				}
			}
		}
	}
}