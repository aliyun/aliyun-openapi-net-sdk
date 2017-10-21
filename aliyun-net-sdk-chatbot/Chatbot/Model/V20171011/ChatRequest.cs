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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Chatbot.Transform;
using Aliyun.Acs.Chatbot.Transform.V20171011;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Model.V20171011
{
    public class ChatRequest : RpcAcsRequest<ChatResponse>
    {
        public ChatRequest()
            : base("Chatbot", "2017-10-11", "Chat", "beebot", "openAPI")
        {
        }

		private string knowledgeId;

		private string senderId;

		private string instanceId;

		private string senderNick;

		private string action;

		private string sessionId;

		private string tag;

		private string utterance;

		private string accessKeyId;

		public string KnowledgeId
		{
			get
			{
				return knowledgeId;
			}
			set	
			{
				knowledgeId = value;
				DictionaryUtil.Add(QueryParameters, "KnowledgeId", value);
			}
		}

		public string SenderId
		{
			get
			{
				return senderId;
			}
			set	
			{
				senderId = value;
				DictionaryUtil.Add(QueryParameters, "SenderId", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string SenderNick
		{
			get
			{
				return senderNick;
			}
			set	
			{
				senderNick = value;
				DictionaryUtil.Add(QueryParameters, "SenderNick", value);
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
				DictionaryUtil.Add(QueryParameters, "Action", value);
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
				DictionaryUtil.Add(QueryParameters, "SessionId", value);
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
				DictionaryUtil.Add(QueryParameters, "Tag", value);
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
				DictionaryUtil.Add(QueryParameters, "Utterance", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ChatResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ChatResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}