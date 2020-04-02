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
using Aliyun.Acs.linkedmall.Transform;
using Aliyun.Acs.linkedmall.Transform.V20180116;

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
    public class QueryBizItemListRequest : RpcAcsRequest<QueryBizItemListResponse>
    {
        public QueryBizItemListRequest()
            : base("linkedmall", "2018-01-16", "QueryBizItemList", "linkedmall", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private List<object> lmItemIds;

		private List<object> itemIds;

		private string userId;

		private int? pageNumber;

		private string bizId;

		private int? pageSize;

		private long? categoryId;

		private string subBizId;

		public List<object> LmItemIds
		{
			get
			{
				return lmItemIds;
			}
			set	
			{
				lmItemIds = value;
				DictionaryUtil.Add(QueryParameters, "LmItemIds", JsonConvert.SerializeObject(value));
			}
		}

		public List<object> ItemIds
		{
			get
			{
				return itemIds;
			}
			set	
			{
				itemIds = value;
				DictionaryUtil.Add(QueryParameters, "ItemIds", JsonConvert.SerializeObject(value));
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
			}
		}

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

		public long? CategoryId
		{
			get
			{
				return categoryId;
			}
			set	
			{
				categoryId = value;
				DictionaryUtil.Add(QueryParameters, "CategoryId", value.ToString());
			}
		}

		public string SubBizId
		{
			get
			{
				return subBizId;
			}
			set	
			{
				subBizId = value;
				DictionaryUtil.Add(QueryParameters, "SubBizId", value);
			}
		}

        public override QueryBizItemListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryBizItemListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
