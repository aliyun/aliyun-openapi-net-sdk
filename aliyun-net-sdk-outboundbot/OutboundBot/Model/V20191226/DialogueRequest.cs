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
using Aliyun.Acs.OutboundBot.Transform;
using Aliyun.Acs.OutboundBot.Transform.V20191226;

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
    public class DialogueRequest : RpcAcsRequest<DialogueResponse>
    {
        public DialogueRequest()
            : base("OutboundBot", "2019-12-26", "Dialogue", "outboundbot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string callId;

		private string calledNumber;

		private string callType;

		private string scenarioId;

		private string taskId;

		private string utterance;

		private string actionParams;

		private string callingNumber;

		private string instanceId;

		private string actionKey;

		public string CallId
		{
			get
			{
				return callId;
			}
			set	
			{
				callId = value;
				DictionaryUtil.Add(QueryParameters, "CallId", value);
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

		public string CallType
		{
			get
			{
				return callType;
			}
			set	
			{
				callType = value;
				DictionaryUtil.Add(QueryParameters, "CallType", value);
			}
		}

		public string ScenarioId
		{
			get
			{
				return scenarioId;
			}
			set	
			{
				scenarioId = value;
				DictionaryUtil.Add(QueryParameters, "ScenarioId", value);
			}
		}

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(QueryParameters, "TaskId", value);
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

		public string ActionParams
		{
			get
			{
				return actionParams;
			}
			set	
			{
				actionParams = value;
				DictionaryUtil.Add(QueryParameters, "ActionParams", value);
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

		public string ActionKey
		{
			get
			{
				return actionKey;
			}
			set	
			{
				actionKey = value;
				DictionaryUtil.Add(QueryParameters, "ActionKey", value);
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
