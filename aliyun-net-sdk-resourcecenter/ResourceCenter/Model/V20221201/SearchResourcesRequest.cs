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
    public class SearchResourcesRequest : RpcAcsRequest<SearchResourcesResponse>
    {
        public SearchResourcesRequest()
            : base("ResourceCenter", "2022-12-01", "SearchResources")
        {
			Method = MethodType.POST;
        }

		private string resourceGroupId;

		private string nextToken;

		private SortCriterion sortCriterion_;

		private List<string> filters = new List<string>(){ };

		private int? maxResults;

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

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

		public SortCriterion SortCriterion_
		{
			get
			{
				return sortCriterion_;
			}

			set
			{
				sortCriterion_ = value;
				if(sortCriterion_ != null)
				{

					DictionaryUtil.Add(QueryParameters,"SortCriterion.Key", sortCriterion_.Key);
					DictionaryUtil.Add(QueryParameters,"SortCriterion.Order", sortCriterion_.Order);
				}
			}
		}

		public List<string> Filters
		{
			get
			{
				return filters;
			}

			set
			{
				filters = value;
				if(filters != null)
				{
					for (int depth1 = 0; depth1 < filters.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Filter." + (depth1 + 1), filters[depth1]);
						DictionaryUtil.Add(QueryParameters,"Filter." + (depth1 + 1), filters[depth1]);
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

		public class SortCriterion
		{

			private string key;

			private string order;

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

			public string Order
			{
				get
				{
					return order;
				}
				set	
				{
					order = value;
				}
			}
		}

		public class Filter
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

        public override SearchResourcesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SearchResourcesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
