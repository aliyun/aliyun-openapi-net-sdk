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
using Aliyun.Acs.BssOpenApi;
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class QueryEvaluateListRequest : RpcAcsRequest<QueryEvaluateListResponse>
    {
        public QueryEvaluateListRequest()
            : base("BssOpenApi", "2017-12-14", "QueryEvaluateList")
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

		public List<string> BizTypeLists
		{
			get
			{
				return bizTypeLists;
			}

			set
			{
				bizTypeLists = value;
				for (int i = 0; i < bizTypeLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"BizTypeList." + (i + 1) , bizTypeLists[i]);
				}
			}
		}

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
