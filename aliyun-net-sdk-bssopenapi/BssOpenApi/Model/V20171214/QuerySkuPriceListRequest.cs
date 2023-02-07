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
    public class QuerySkuPriceListRequest : RpcAcsRequest<QuerySkuPriceListResponse>
    {
        public QuerySkuPriceListRequest()
            : base("BssOpenApi", "2017-12-14", "QuerySkuPriceList", "bssopenapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
        }

		private string nextPageToken;

		private string commodityCode;

		private string priceFactorConditionMap;

		private string priceEntityCode;

		private int? pageSize;

		[JsonProperty(PropertyName = "NextPageToken")]
		public string NextPageToken
		{
			get
			{
				return nextPageToken;
			}
			set	
			{
				nextPageToken = value;
				DictionaryUtil.Add(QueryParameters, "NextPageToken", value);
			}
		}

		[JsonProperty(PropertyName = "CommodityCode")]
		public string CommodityCode
		{
			get
			{
				return commodityCode;
			}
			set	
			{
				commodityCode = value;
				DictionaryUtil.Add(QueryParameters, "CommodityCode", value);
			}
		}

		[JsonProperty(PropertyName = "PriceFactorConditionMap")]
		public string PriceFactorConditionMap
		{
			get
			{
				return priceFactorConditionMap;
			}
			set	
			{
				priceFactorConditionMap = value;
				DictionaryUtil.Add(QueryParameters, "PriceFactorConditionMap", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "PriceEntityCode")]
		public string PriceEntityCode
		{
			get
			{
				return priceEntityCode;
			}
			set	
			{
				priceEntityCode = value;
				DictionaryUtil.Add(QueryParameters, "PriceEntityCode", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QuerySkuPriceListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QuerySkuPriceListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
