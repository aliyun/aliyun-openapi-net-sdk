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
    public class ModifyAskingBackConfigRequest : RpcAcsRequest<ModifyAskingBackConfigResponse>
    {
        public ModifyAskingBackConfigRequest()
            : base("VoiceNavigator", "2018-06-12", "ModifyAskingBackConfig", "voicebot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string negativeFeedbackPrompt;

		private string negativeFeedbackAction;

		private bool? enabled;

		private bool? enableNegativeFeedback;

		private string instanceId;

		private string prompt;

		private List<string> negativeFeedbackUtterancess = new List<string>(){ };

		private string negativeFeedbackActionParams;

		public string NegativeFeedbackPrompt
		{
			get
			{
				return negativeFeedbackPrompt;
			}
			set	
			{
				negativeFeedbackPrompt = value;
				DictionaryUtil.Add(QueryParameters, "NegativeFeedbackPrompt", value);
			}
		}

		public string NegativeFeedbackAction
		{
			get
			{
				return negativeFeedbackAction;
			}
			set	
			{
				negativeFeedbackAction = value;
				DictionaryUtil.Add(QueryParameters, "NegativeFeedbackAction", value);
			}
		}

		public bool? Enabled
		{
			get
			{
				return enabled;
			}
			set	
			{
				enabled = value;
				DictionaryUtil.Add(QueryParameters, "Enabled", value.ToString());
			}
		}

		public bool? EnableNegativeFeedback
		{
			get
			{
				return enableNegativeFeedback;
			}
			set	
			{
				enableNegativeFeedback = value;
				DictionaryUtil.Add(QueryParameters, "EnableNegativeFeedback", value.ToString());
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

		public string Prompt
		{
			get
			{
				return prompt;
			}
			set	
			{
				prompt = value;
				DictionaryUtil.Add(QueryParameters, "Prompt", value);
			}
		}

		public List<string> NegativeFeedbackUtterancess
		{
			get
			{
				return negativeFeedbackUtterancess;
			}

			set
			{
				negativeFeedbackUtterancess = value;
				for (int i = 0; i < negativeFeedbackUtterancess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"NegativeFeedbackUtterances." + (i + 1) , negativeFeedbackUtterancess[i]);
				}
			}
		}

		public string NegativeFeedbackActionParams
		{
			get
			{
				return negativeFeedbackActionParams;
			}
			set	
			{
				negativeFeedbackActionParams = value;
				DictionaryUtil.Add(QueryParameters, "NegativeFeedbackActionParams", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyAskingBackConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyAskingBackConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
