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
using Aliyun.Acs.Market;
using Aliyun.Acs.Market.Transform;
using Aliyun.Acs.Market.Transform.V20151101;

namespace Aliyun.Acs.Market.Model.V20151101
{
    public class DescribeProductsRequest : RpcAcsRequest<DescribeProductsResponse>
    {
        public DescribeProductsRequest()
            : base("Market", "2015-11-01", "DescribeProducts")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Market.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Market.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string searchTerm;

		private int? pageNumber;

		private List<string> filters = new List<string>(){ };

		private int? pageSize;

		[JsonProperty(PropertyName = "SearchTerm")]
		public string SearchTerm
		{
			get
			{
				return searchTerm;
			}
			set	
			{
				searchTerm = value;
				DictionaryUtil.Add(QueryParameters, "SearchTerm", value);
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Filter")]
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

		[JsonProperty(PropertyName = "PageSize")]
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

		public class Filter
		{

			private string value_;

			private string key;

			[JsonProperty(PropertyName = "Value")]
			public string Value_
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			[JsonProperty(PropertyName = "Key")]
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

        public override DescribeProductsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeProductsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
