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
    public class FeedbackRequest : RpcAcsRequest<FeedbackResponse>
    {
        public FeedbackRequest()
            : base("Chatbot", "2017-10-11", "Feedback", "beebot", "openAPI")
        {
        }

		private string feedback;

		private string instanceId;

		private string messageId;

		private string sessionId;

		public string Feedback
		{
			get
			{
				return feedback;
			}
			set	
			{
				feedback = value;
				DictionaryUtil.Add(QueryParameters, "Feedback", value);
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

		public string MessageId
		{
			get
			{
				return messageId;
			}
			set	
			{
				messageId = value;
				DictionaryUtil.Add(QueryParameters, "MessageId", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override FeedbackResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return FeedbackResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}