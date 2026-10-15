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
    public class ListAuthConfigByResourceRequest : RpcAcsRequest<ListAuthConfigByResourceResponse>
    {
        public ListAuthConfigByResourceRequest()
            : base("quickbi-public", "2022-01-01", "ListAuthConfigByResource", "QuickBI", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private bool? hasAuth;

		private string keyword;

		private string resourceId;

		private string worksType;

		private int? shareToType;

		public bool? HasAuth
		{
			get
			{
				return hasAuth;
			}
			set	
			{
				hasAuth = value;
				DictionaryUtil.Add(QueryParameters, "HasAuth", value.ToString());
			}
		}

		public string Keyword
		{
			get
			{
				return keyword;
			}
			set	
			{
				keyword = value;
				DictionaryUtil.Add(QueryParameters, "Keyword", value);
			}
		}

		public string ResourceId
		{
			get
			{
				return resourceId;
			}
			set	
			{
				resourceId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId", value);
			}
		}

		public string WorksType
		{
			get
			{
				return worksType;
			}
			set	
			{
				worksType = value;
				DictionaryUtil.Add(QueryParameters, "WorksType", value);
			}
		}

		public int? ShareToType
		{
			get
			{
				return shareToType;
			}
			set	
			{
				shareToType = value;
				DictionaryUtil.Add(QueryParameters, "ShareToType", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListAuthConfigByResourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListAuthConfigByResourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
