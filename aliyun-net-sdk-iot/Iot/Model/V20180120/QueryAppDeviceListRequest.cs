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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class QueryAppDeviceListRequest : RpcAcsRequest<QueryAppDeviceListResponse>
    {
        public QueryAppDeviceListRequest()
            : base("Iot", "2018-01-20", "QueryAppDeviceList", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? currentPage;

		private List<TagList> tagLists = new List<TagList>(){ };

		private List<string> productKeyLists = new List<string>(){ };

		private List<string> categoryKeyLists = new List<string>(){ };

		private string iotInstanceId;

		private int? pageSize;

		private string appKey;

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
			}
		}

		public List<TagList> TagLists
		{
			get
			{
				return tagLists;
			}

			set
			{
				tagLists = value;
				for (int i = 0; i < tagLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TagList." + (i + 1) + ".TagName", tagLists[i].TagName);
					DictionaryUtil.Add(QueryParameters,"TagList." + (i + 1) + ".TagValue", tagLists[i].TagValue);
				}
			}
		}

		public List<string> ProductKeyLists
		{
			get
			{
				return productKeyLists;
			}

			set
			{
				productKeyLists = value;
				for (int i = 0; i < productKeyLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ProductKeyList." + (i + 1) , productKeyLists[i]);
				}
			}
		}

		public List<string> CategoryKeyLists
		{
			get
			{
				return categoryKeyLists;
			}

			set
			{
				categoryKeyLists = value;
				for (int i = 0; i < categoryKeyLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"CategoryKeyList." + (i + 1) , categoryKeyLists[i]);
				}
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
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

		public string AppKey
		{
			get
			{
				return appKey;
			}
			set	
			{
				appKey = value;
				DictionaryUtil.Add(QueryParameters, "AppKey", value);
			}
		}

		public class TagList
		{

			private string tagName;

			private string tagValue;

			public string TagName
			{
				get
				{
					return tagName;
				}
				set	
				{
					tagName = value;
				}
			}

			public string TagValue
			{
				get
				{
					return tagValue;
				}
				set	
				{
					tagValue = value;
				}
			}
		}

        public override QueryAppDeviceListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryAppDeviceListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
