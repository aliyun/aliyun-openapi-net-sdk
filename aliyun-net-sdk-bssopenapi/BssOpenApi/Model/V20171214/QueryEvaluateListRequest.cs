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
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class QueryEvaluateListRequest : RpcAcsRequest<QueryEvaluateListResponse>
    {
        public QueryEvaluateListRequest()
            : base("BssOpenApi", "2017-12-14", "QueryEvaluateList", "bssopenapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string endSearchTime;

		private string outBizId;

		private int? sortType;

		private int? type;

		private int? pageNum;

		private int? pageSize;

		private long? endAmount;

		private string billCycle;

		private List<string> bizTypeLists = new List<string>(){ };

		private long? ownerId;

		private string startSearchTime;

		private string endBizTime;

		private long? startAmount;

		private string startBizTime;

		[JsonProperty(PropertyName = "EndSearchTime")]
		public string EndSearchTime
		{
			get
			{
				return endSearchTime;
			}
			set	
			{
				endSearchTime = value;
				DictionaryUtil.Add(QueryParameters, "EndSearchTime", value);
			}
		}

		[JsonProperty(PropertyName = "OutBizId")]
		public string OutBizId
		{
			get
			{
				return outBizId;
			}
			set	
			{
				outBizId = value;
				DictionaryUtil.Add(QueryParameters, "OutBizId", value);
			}
		}

		[JsonProperty(PropertyName = "SortType")]
		public int? SortType
		{
			get
			{
				return sortType;
			}
			set	
			{
				sortType = value;
				DictionaryUtil.Add(QueryParameters, "SortType", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Type")]
		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value.ToString());
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

		[JsonProperty(PropertyName = "EndAmount")]
		public long? EndAmount
		{
			get
			{
				return endAmount;
			}
			set	
			{
				endAmount = value;
				DictionaryUtil.Add(QueryParameters, "EndAmount", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "BillCycle")]
		public string BillCycle
		{
			get
			{
				return billCycle;
			}
			set	
			{
				billCycle = value;
				DictionaryUtil.Add(QueryParameters, "BillCycle", value);
			}
		}

		[JsonProperty(PropertyName = "BizTypeList")]
		public List<string> BizTypeLists
		{
			get
			{
				return bizTypeLists;
			}

			set
			{
				bizTypeLists = value;
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "StartSearchTime")]
		public string StartSearchTime
		{
			get
			{
				return startSearchTime;
			}
			set	
			{
				startSearchTime = value;
				DictionaryUtil.Add(QueryParameters, "StartSearchTime", value);
			}
		}

		[JsonProperty(PropertyName = "EndBizTime")]
		public string EndBizTime
		{
			get
			{
				return endBizTime;
			}
			set	
			{
				endBizTime = value;
				DictionaryUtil.Add(QueryParameters, "EndBizTime", value);
			}
		}

		[JsonProperty(PropertyName = "StartAmount")]
		public long? StartAmount
		{
			get
			{
				return startAmount;
			}
			set	
			{
				startAmount = value;
				DictionaryUtil.Add(QueryParameters, "StartAmount", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "StartBizTime")]
		public string StartBizTime
		{
			get
			{
				return startBizTime;
			}
			set	
			{
				startBizTime = value;
				DictionaryUtil.Add(QueryParameters, "StartBizTime", value);
			}
		}

        public override QueryEvaluateListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryEvaluateListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
