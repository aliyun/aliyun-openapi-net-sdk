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
using Aliyun.Acs.OceanBasePro.Transform;
using Aliyun.Acs.OceanBasePro.Transform.V20190901;

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
    public class ListDataSourceRequest : RpcAcsRequest<ListDataSourceResponse>
    {
        public ListDataSourceRequest()
            : base("OceanBasePro", "2019-09-01", "ListDataSource", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> types = new List<string>(){ };

		private string searchKey;

		private string pageNumber;

		private string pageSize;

		private string sortField;

		private string order;

		[JsonProperty(PropertyName = "Types")]
		public List<string> Types
		{
			get
			{
				return types;
			}

			set
			{
				types = value;
				if(types != null)
				{
					for (int depth1 = 0; depth1 < types.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"Types." + (depth1 + 1), types[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "SearchKey")]
		public string SearchKey
		{
			get
			{
				return searchKey;
			}
			set	
			{
				searchKey = value;
				DictionaryUtil.Add(BodyParameters, "SearchKey", value);
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
		public string PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value);
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
		public string PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value);
			}
		}

		[JsonProperty(PropertyName = "SortField")]
		public string SortField
		{
			get
			{
				return sortField;
			}
			set	
			{
				sortField = value;
				DictionaryUtil.Add(BodyParameters, "SortField", value);
			}
		}

		[JsonProperty(PropertyName = "Order")]
		public string Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
				DictionaryUtil.Add(BodyParameters, "Order", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListDataSourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListDataSourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
