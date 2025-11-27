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
using Aliyun.Acs.ResourceCenter;
using Aliyun.Acs.ResourceCenter.Transform;
using Aliyun.Acs.ResourceCenter.Transform.V20221201;

namespace Aliyun.Acs.ResourceCenter.Model.V20221201
{
    public class ListMultiAccountResourceRelationshipsRequest : RpcAcsRequest<ListMultiAccountResourceRelationshipsResponse>
    {
        public ListMultiAccountResourceRelationshipsRequest()
            : base("ResourceCenter", "2022-12-01", "ListMultiAccountResourceRelationships")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string nextToken;

		private string scope;

		private string resourceId;

		private string resourceType;

		private List<string> relatedResourceFilters = new List<string>(){ };

		private int? maxResults;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		public string Scope
		{
			get
			{
				return scope;
			}
			set	
			{
				scope = value;
				DictionaryUtil.Add(QueryParameters, "Scope", value);
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

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		public List<string> RelatedResourceFilters
		{
			get
			{
				return relatedResourceFilters;
			}

			set
			{
				relatedResourceFilters = value;
				if(relatedResourceFilters != null)
				{
					for (int depth1 = 0; depth1 < relatedResourceFilters.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"RelatedResourceFilter." + (depth1 + 1), relatedResourceFilters[depth1]);
						DictionaryUtil.Add(QueryParameters,"RelatedResourceFilter." + (depth1 + 1), relatedResourceFilters[depth1]);
					}
				}
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
			}
		}

		public class RelatedResourceFilter
		{

			private string matchType;

			private List<string> values = new List<string>(){ };

			private string key;

			public string MatchType
			{
				get
				{
					return matchType;
				}
				set	
				{
					matchType = value;
				}
			}

			public List<string> Values
			{
				get
				{
					return values;
				}
				set	
				{
					values = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListMultiAccountResourceRelationshipsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListMultiAccountResourceRelationshipsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
