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
using Aliyun.Acs.WebsiteBuild;
using Aliyun.Acs.WebsiteBuild.Transform;
using Aliyun.Acs.WebsiteBuild.Transform.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Model.V20250429
{
    public class ListAppInstancesRequest : RpcAcsRequest<ListAppInstancesResponse>
    {
        public ListAppInstancesRequest()
            : base("WebsiteBuild", "2025-04-29", "ListAppInstances")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private List<string> statusList = new List<string>(){ };

		private int? pageNum;

		private string orderColumn;

		private string nextToken;

		private int? pageSize;

		private string endTimeBegin;

		private string query;

		private string extend;

		private string endTimeEnd;

		private string bizId;

		private int? maxResults;

		private string orderType;

		[JsonProperty(PropertyName = "StatusList")]
		public List<string> StatusList
		{
			get
			{
				return statusList;
			}

			set
			{
				statusList = value;
				if(statusList != null)
				{
					for (int depth1 = 0; depth1 < statusList.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"StatusList." + (depth1 + 1), statusList[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "PageNum")]
		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "OrderColumn")]
		public string OrderColumn
		{
			get
			{
				return orderColumn;
			}
			set	
			{
				orderColumn = value;
				DictionaryUtil.Add(QueryParameters, "OrderColumn", value);
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

		[JsonProperty(PropertyName = "EndTimeBegin")]
		public string EndTimeBegin
		{
			get
			{
				return endTimeBegin;
			}
			set	
			{
				endTimeBegin = value;
				DictionaryUtil.Add(QueryParameters, "EndTimeBegin", value);
			}
		}

		[JsonProperty(PropertyName = "Query")]
		public string Query
		{
			get
			{
				return query;
			}
			set	
			{
				query = value;
				DictionaryUtil.Add(QueryParameters, "Query", value);
			}
		}

		[JsonProperty(PropertyName = "Extend")]
		public string Extend
		{
			get
			{
				return extend;
			}
			set	
			{
				extend = value;
				DictionaryUtil.Add(QueryParameters, "Extend", value);
			}
		}

		[JsonProperty(PropertyName = "EndTimeEnd")]
		public string EndTimeEnd
		{
			get
			{
				return endTimeEnd;
			}
			set	
			{
				endTimeEnd = value;
				DictionaryUtil.Add(QueryParameters, "EndTimeEnd", value);
			}
		}

		[JsonProperty(PropertyName = "BizId")]
		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
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

		[JsonProperty(PropertyName = "OrderType")]
		public string OrderType
		{
			get
			{
				return orderType;
			}
			set	
			{
				orderType = value;
				DictionaryUtil.Add(QueryParameters, "OrderType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListAppInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListAppInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
