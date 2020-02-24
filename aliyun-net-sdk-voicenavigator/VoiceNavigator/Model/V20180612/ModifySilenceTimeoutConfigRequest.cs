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
    public class ModifySilenceTimeoutConfigRequest : RpcAcsRequest<ModifySilenceTimeoutConfigResponse>
    {
        public ModifySilenceTimeoutConfigRequest()
            : base("VoiceNavigator", "2018-06-12", "ModifySilenceTimeoutConfig", "voicebot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string finalAction;

		private string finalPrompt;

		private int? threshold;

		private string intentTrigger;

		private long? timeout;

		private string instanceId;

		private string sourceType;

		private string finalActionParams;

		private string prompt;

		public string FinalAction
		{
			get
			{
				return finalAction;
			}
			set	
			{
				finalAction = value;
				DictionaryUtil.Add(QueryParameters, "FinalAction", value);
			}
		}

		public string FinalPrompt
		{
			get
			{
				return finalPrompt;
			}
			set	
			{
				finalPrompt = value;
				DictionaryUtil.Add(QueryParameters, "FinalPrompt", value);
			}
		}

		public int? Threshold
		{
			get
			{
				return threshold;
			}
			set	
			{
				threshold = value;
				DictionaryUtil.Add(QueryParameters, "Threshold", value.ToString());
			}
		}

		public string IntentTrigger
		{
			get
			{
				return intentTrigger;
			}
			set	
			{
				intentTrigger = value;
				DictionaryUtil.Add(QueryParameters, "IntentTrigger", value);
			}
		}

		public long? Timeout
		{
			get
			{
				return timeout;
			}
			set	
			{
				timeout = value;
				DictionaryUtil.Add(QueryParameters, "Timeout", value.ToString());
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

		public string SourceType
		{
			get
			{
				return sourceType;
			}
			set	
			{
				sourceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceType", value);
			}
		}

		public string FinalActionParams
		{
			get
			{
				return finalActionParams;
			}
			set	
			{
				finalActionParams = value;
				DictionaryUtil.Add(QueryParameters, "FinalActionParams", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifySilenceTimeoutConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifySilenceTimeoutConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
