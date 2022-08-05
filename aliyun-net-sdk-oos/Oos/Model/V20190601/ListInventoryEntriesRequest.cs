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
using Aliyun.Acs.oos.Transform;
using Aliyun.Acs.oos.Transform.V20190601;

namespace Aliyun.Acs.oos.Model.V20190601
{
    public class ListInventoryEntriesRequest : RpcAcsRequest<ListInventoryEntriesResponse>
    {
        public ListInventoryEntriesRequest()
            : base("oos", "2019-06-01", "ListInventoryEntries", "oos", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> filters = new List<string>(){ };

		private string instanceId;

		private string nextToken;

		private int? maxResults;

		private string typeName;

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

		[JsonProperty(PropertyName = "InstanceId")]
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

		[JsonProperty(PropertyName = "NextToken")]
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

		[JsonProperty(PropertyName = "MaxResults")]
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

		[JsonProperty(PropertyName = "TypeName")]
		public string TypeName
		{
			get
			{
				return typeName;
			}
			set	
			{
				typeName = value;
				DictionaryUtil.Add(QueryParameters, "TypeName", value);
			}
		}

		public class Filter
		{

			private string name;

			private List<string> values = new List<string>(){ };

			private string operator_;

			[JsonProperty(PropertyName = "Name")]
			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			[JsonProperty(PropertyName = "Value")]
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

			[JsonProperty(PropertyName = "Operator")]
			public string Operator_
			{
				get
				{
					return operator_;
				}
				set	
				{
					operator_ = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListInventoryEntriesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListInventoryEntriesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
