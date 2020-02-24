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
using Aliyun.Acs.VoiceNavigator.Transform;
using Aliyun.Acs.VoiceNavigator.Transform.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Model.V20180612
{
    public class DialogueRequest : RpcAcsRequest<DialogueResponse>
    {
        public DialogueRequest()
            : base("VoiceNavigator", "2018-06-12", "Dialogue", "voicebot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string conversationId;

		private string callingNumber;

		private string instanceId;

		private string calledNumber;

		private string additionalContext;

		private string utterance;

		public string ConversationId
		{
			get
			{
				return conversationId;
			}
			set	
			{
				conversationId = value;
				DictionaryUtil.Add(QueryParameters, "ConversationId", value);
			}
		}

		public string CallingNumber
		{
			get
			{
				return callingNumber;
			}
			set	
			{
				callingNumber = value;
				DictionaryUtil.Add(QueryParameters, "CallingNumber", value);
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

		public string CalledNumber
		{
			get
			{
				return calledNumber;
			}
			set	
			{
				calledNumber = value;
				DictionaryUtil.Add(QueryParameters, "CalledNumber", value);
			}
		}

		public string AdditionalContext
		{
			get
			{
				return additionalContext;
			}
			set	
			{
				additionalContext = value;
				DictionaryUtil.Add(QueryParameters, "AdditionalContext", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DialogueResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DialogueResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
