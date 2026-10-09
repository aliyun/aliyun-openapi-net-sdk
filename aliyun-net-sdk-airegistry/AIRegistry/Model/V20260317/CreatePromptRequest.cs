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
using Aliyun.Acs.AIRegistry.Transform;
using Aliyun.Acs.AIRegistry.Transform.V20260317;

namespace Aliyun.Acs.AIRegistry.Model.V20260317
{
    public class CreatePromptRequest : RpcAcsRequest<CreatePromptResponse>
    {
        public CreatePromptRequest()
            : base("AIRegistry", "2026-03-17", "CreatePrompt", "AIRegistry", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string promptKey;

		private string bizTags;

		private string namespaceId;

		private string targetVersion;

		private string template;

		private string description;

		private string variables;

		private string commitMsg;

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

		public string BizTags
		{
			get
			{
				return bizTags;
			}
			set	
			{
				bizTags = value;
				DictionaryUtil.Add(QueryParameters, "BizTags", value);
			}
		}

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

		public string TargetVersion
		{
			get
			{
				return targetVersion;
			}
			set	
			{
				targetVersion = value;
				DictionaryUtil.Add(QueryParameters, "TargetVersion", value);
			}
		}

		public string Template
		{
			get
			{
				return template;
			}
			set	
			{
				template = value;
				DictionaryUtil.Add(QueryParameters, "Template", value);
			}
		}

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

		public string Variables
		{
			get
			{
				return variables;
			}
			set	
			{
				variables = value;
				DictionaryUtil.Add(QueryParameters, "Variables", value);
			}
		}

		public string CommitMsg
		{
			get
			{
				return commitMsg;
			}
			set	
			{
				commitMsg = value;
				DictionaryUtil.Add(QueryParameters, "CommitMsg", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreatePromptResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreatePromptResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
