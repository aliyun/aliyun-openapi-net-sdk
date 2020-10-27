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
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20180801;

namespace Aliyun.Acs.cloudesl.Model.V20180801
{
    public class DescribeItemsRequest : RpcAcsRequest<DescribeItemsResponse>
    {
        public DescribeItemsRequest()
            : base("cloudesl", "2018-08-01", "DescribeItems", "cloudesl", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string storeId;

		private int? pageNumber;

		private long? itemId;

		private int? pageSize;

		private string itemBarCode;

		private bool? bePromotion;

		private string itemTitle;

		private string skuId;

		public string StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
				DictionaryUtil.Add(QueryParameters, "StoreId", value);
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

		public long? ItemId
		{
			get
			{
				return itemId;
			}
			set	
			{
				itemId = value;
				DictionaryUtil.Add(QueryParameters, "ItemId", value.ToString());
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

		public string ItemBarCode
		{
			get
			{
				return itemBarCode;
			}
			set	
			{
				itemBarCode = value;
				DictionaryUtil.Add(QueryParameters, "ItemBarCode", value);
			}
		}

		public bool? BePromotion
		{
			get
			{
				return bePromotion;
			}
			set	
			{
				bePromotion = value;
				DictionaryUtil.Add(QueryParameters, "BePromotion", value.ToString());
			}
		}

		public string ItemTitle
		{
			get
			{
				return itemTitle;
			}
			set	
			{
				itemTitle = value;
				DictionaryUtil.Add(QueryParameters, "ItemTitle", value);
			}
		}

		public string SkuId
		{
			get
			{
				return skuId;
			}
			set	
			{
				skuId = value;
				DictionaryUtil.Add(QueryParameters, "SkuId", value);
			}
		}

        public override DescribeItemsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeItemsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
