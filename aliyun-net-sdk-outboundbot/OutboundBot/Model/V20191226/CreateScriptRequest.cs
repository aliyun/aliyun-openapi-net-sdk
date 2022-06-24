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
    public class CreateScriptRequest : RpcAcsRequest<CreateScriptResponse>
    {
        public CreateScriptRequest()
            : base("OutboundBot", "2019-12-26", "CreateScript", "outboundbot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string ttsConfig;

		private string industry;

		private string scriptName;

		private string scene;

		private List<string> scriptWaveforms = new List<string>(){ };

		private string asrConfig;

		private bool? newBargeInEnable;

		private bool? miniPlaybackEnable;

		private string chatbotId;

		private string instanceId;

		private string scriptDescription;

		private bool? longWaitEnable;

		private List<string> scriptContents = new List<string>(){ };

		public string TtsConfig
		{
			get
			{
				return ttsConfig;
			}
			set	
			{
				ttsConfig = value;
				DictionaryUtil.Add(QueryParameters, "TtsConfig", value);
			}
		}

		public string Industry
		{
			get
			{
				return industry;
			}
			set	
			{
				industry = value;
				DictionaryUtil.Add(QueryParameters, "Industry", value);
			}
		}

		public string ScriptName
		{
			get
			{
				return scriptName;
			}
			set	
			{
				scriptName = value;
				DictionaryUtil.Add(QueryParameters, "ScriptName", value);
			}
		}

		public string Scene
		{
			get
			{
				return scene;
			}
			set	
			{
				scene = value;
				DictionaryUtil.Add(QueryParameters, "Scene", value);
			}
		}

		public List<string> ScriptWaveforms
		{
			get
			{
				return scriptWaveforms;
			}

			set
			{
				scriptWaveforms = value;
			}
		}

		public string AsrConfig
		{
			get
			{
				return asrConfig;
			}
			set	
			{
				asrConfig = value;
				DictionaryUtil.Add(QueryParameters, "AsrConfig", value);
			}
		}

		public bool? NewBargeInEnable
		{
			get
			{
				return newBargeInEnable;
			}
			set	
			{
				newBargeInEnable = value;
				DictionaryUtil.Add(QueryParameters, "NewBargeInEnable", value.ToString());
			}
		}

		public bool? MiniPlaybackEnable
		{
			get
			{
				return miniPlaybackEnable;
			}
			set	
			{
				miniPlaybackEnable = value;
				DictionaryUtil.Add(QueryParameters, "MiniPlaybackEnable", value.ToString());
			}
		}

		public string ChatbotId
		{
			get
			{
				return chatbotId;
			}
			set	
			{
				chatbotId = value;
				DictionaryUtil.Add(QueryParameters, "ChatbotId", value);
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

		public string ScriptDescription
		{
			get
			{
				return scriptDescription;
			}
			set	
			{
				scriptDescription = value;
				DictionaryUtil.Add(QueryParameters, "ScriptDescription", value);
			}
		}

		public bool? LongWaitEnable
		{
			get
			{
				return longWaitEnable;
			}
			set	
			{
				longWaitEnable = value;
				DictionaryUtil.Add(QueryParameters, "LongWaitEnable", value.ToString());
			}
		}

		public List<string> ScriptContents
		{
			get
			{
				return scriptContents;
			}

			set
			{
				scriptContents = value;
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateScriptResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateScriptResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
