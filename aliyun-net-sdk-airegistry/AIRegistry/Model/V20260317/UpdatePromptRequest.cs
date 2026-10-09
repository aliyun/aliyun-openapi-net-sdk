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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.AIRegistry.Transform;
using Aliyun.Acs.AIRegistry.Transform.V20260317;

namespace Aliyun.Acs.AIRegistry.Model.V20260317
{
    public class UpdatePromptRequest : RpcAcsRequest<UpdatePromptResponse>
    {
        public UpdatePromptRequest()
            : base("AIRegistry", "2026-03-17", "UpdatePrompt", "AIRegistry", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string promptKey;

		private List<string> bizTags = new List<string>(){ };

		private string namespaceId;

		private string labels;

		private string description;

		[JsonProperty(PropertyName = "PromptKey")]
		public string PromptKey
		{
			get
			{
				return promptKey;
			}
			set	
			{
				promptKey = value;
				DictionaryUtil.Add(QueryParameters, "PromptKey", value);
			}
		}

		[JsonProperty(PropertyName = "BizTags")]
		public List<string> BizTags
		{
			get
			{
				return bizTags;
			}

			set
			{
				bizTags = value;
				if(bizTags != null)
				{
					for (int depth1 = 0; depth1 < bizTags.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"BizTags." + (depth1 + 1), bizTags[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "NamespaceId")]
		public string NamespaceId
		{
			get
			{
				return namespaceId;
			}
			set	
			{
				namespaceId = value;
				DictionaryUtil.Add(QueryParameters, "NamespaceId", value);
			}
		}

		[JsonProperty(PropertyName = "Labels")]
		public string Labels
		{
			get
			{
				return labels;
			}
			set	
			{
				labels = value;
				DictionaryUtil.Add(QueryParameters, "Labels", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdatePromptResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdatePromptResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
