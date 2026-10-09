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
    public class ListPromptsRequest : RpcAcsRequest<ListPromptsResponse>
    {
        public ListPromptsRequest()
            : base("AIRegistry", "2026-03-17", "ListPrompts", "AIRegistry", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string promptKey;

		private string bizTags;

		private string namespaceId;

		private int? pageNo;

		private string search;

		private int? pageSize;

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

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
				DictionaryUtil.Add(QueryParameters, "PageNo", value.ToString());
			}
		}

		public string Search
		{
			get
			{
				return search;
			}
			set	
			{
				search = value;
				DictionaryUtil.Add(QueryParameters, "Search", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListPromptsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListPromptsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
