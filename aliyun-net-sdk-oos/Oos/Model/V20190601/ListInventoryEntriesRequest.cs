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
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<Filter> filters = new List<Filter>(){ };

		private string instanceId;

		private string nextToken;

		private int? maxResults;

		private string typeName;

		public List<Filter> Filters
		{
			get
			{
				return filters;
			}

			set
			{
				filters = value;
				for (int i = 0; i < filters.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Filter." + (i + 1) + ".Name", filters[i].Name);
					for (int j = 0; j < filters[i].Values.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"Filter." + (i + 1) + ".Value." +(j + 1), filters[i].Values[j]);
					}
					DictionaryUtil.Add(QueryParameters,"Filter." + (i + 1) + ".Operator", filters[i].Operator);
				}
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

			public string Operator
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
