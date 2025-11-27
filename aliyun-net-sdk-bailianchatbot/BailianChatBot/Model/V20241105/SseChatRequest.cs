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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.BailianChatBot;
using Aliyun.Acs.BailianChatBot.Transform;
using Aliyun.Acs.BailianChatBot.Transform.V20241105;

namespace Aliyun.Acs.BailianChatBot.Model.V20241105
{
    public class SseChatRequest : RpcAcsRequest<SseChatResponse>
    {
        public SseChatRequest()
            : base("BailianChatBot", "2024-11-05", "SseChat")
        {
			Method = MethodType.POST;
        }

		private string sessionId;

		private string command;

		private string vendorParam;

		private string senderId;

		private string appId;

		private string senderNick;

		private string utterance;

		private string workspaceId;

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

		public string Command
		{
			get
			{
				return command;
			}
			set	
			{
				command = value;
				DictionaryUtil.Add(QueryParameters, "Command", value);
			}
		}

		public string VendorParam
		{
			get
			{
				return vendorParam;
			}
			set	
			{
				vendorParam = value;
				DictionaryUtil.Add(QueryParameters, "VendorParam", value);
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

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
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

		public string WorkspaceId
		{
			get
			{
				return workspaceId;
			}
			set	
			{
				workspaceId = value;
				DictionaryUtil.Add(QueryParameters, "WorkspaceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SseChatResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SseChatResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
