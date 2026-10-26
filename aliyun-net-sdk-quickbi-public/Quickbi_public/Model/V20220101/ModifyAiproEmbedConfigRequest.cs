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
using Aliyun.Acs.quickbi_public.Transform;
using Aliyun.Acs.quickbi_public.Transform.V20220101;

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
    public class ModifyAiproEmbedConfigRequest : RpcAcsRequest<ModifyAiproEmbedConfigResponse>
    {
        public ModifyAiproEmbedConfigRequest()
            : base("quickbi-public", "2022-01-01", "ModifyAiproEmbedConfig", "QuickBI", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private int? uploadEnabled;

		private string showName;

		private string aiProId;

		private int? chatHistoryStatus;

		private int? memoryEnabled;

		private string agentName;

		private string config;

		public int? UploadEnabled
		{
			get
			{
				return uploadEnabled;
			}
			set	
			{
				uploadEnabled = value;
				DictionaryUtil.Add(QueryParameters, "UploadEnabled", value.ToString());
			}
		}

		public string ShowName
		{
			get
			{
				return showName;
			}
			set	
			{
				showName = value;
				DictionaryUtil.Add(QueryParameters, "ShowName", value);
			}
		}

		public string AiProId
		{
			get
			{
				return aiProId;
			}
			set	
			{
				aiProId = value;
				DictionaryUtil.Add(QueryParameters, "AiProId", value);
			}
		}

		public int? ChatHistoryStatus
		{
			get
			{
				return chatHistoryStatus;
			}
			set	
			{
				chatHistoryStatus = value;
				DictionaryUtil.Add(QueryParameters, "ChatHistoryStatus", value.ToString());
			}
		}

		public int? MemoryEnabled
		{
			get
			{
				return memoryEnabled;
			}
			set	
			{
				memoryEnabled = value;
				DictionaryUtil.Add(QueryParameters, "MemoryEnabled", value.ToString());
			}
		}

		public string AgentName
		{
			get
			{
				return agentName;
			}
			set	
			{
				agentName = value;
				DictionaryUtil.Add(QueryParameters, "AgentName", value);
			}
		}

		public string Config
		{
			get
			{
				return config;
			}
			set	
			{
				config = value;
				DictionaryUtil.Add(QueryParameters, "Config", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyAiproEmbedConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyAiproEmbedConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
