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
        public new string RequestId { get; set; }

        public string SessionId { get; set; }

        public string MessageId { get; set; }

        public string Tag { get; set; }

        public List<Chat_Message> Messages { get; set; }

        public class Chat_Message
		{
            public string Type { get; set; }

            public List<Chat_Recommend> Recommends { get; set; }

            public Chat_Text Text { get; set; }

            public Chat_Knowledge Knowledge { get; set; }

            public class Chat_Recommend
			{
                public string KnowledgeId { get; set; }

                public string Title { get; set; }

                public string AnswerSource { get; set; }

                public string Summary { get; set; }

                public string Content { get; set; }
            }

			public class Chat_Text
			{
                public string Content { get; set; }

                public string AnswerSource { get; set; }

                public string MetaData { get; set; }
            }

			public class Chat_Knowledge
			{
                public string Id { get; set; }

                public string Title { get; set; }

                public string Summary { get; set; }

                public string Content { get; set; }

                public string AnswerSource { get; set; }
            }
		}
	}
}