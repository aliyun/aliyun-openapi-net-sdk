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
using Aliyun.Acs.linkedmall.Transform;
using Aliyun.Acs.linkedmall.Transform.V20180116;

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
    public class AddSupplierNewItemsRequest : RpcAcsRequest<AddSupplierNewItemsResponse>
    {
        public AddSupplierNewItemsRequest()
            : base("linkedmall", "2018-01-16", "AddSupplierNewItems", "linkedmall", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string bizId;

		private List<ItemList> itemLists = new List<ItemList>(){ };

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

		public List<ItemList> ItemLists
		{
			get
			{
				return itemLists;
			}

			set
			{
				itemLists = value;
				for (int i = 0; i < itemLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ItemList." + (i + 1) + ".ItemId", itemLists[i].ItemId);
					DictionaryUtil.Add(QueryParameters,"ItemList." + (i + 1) + ".LmItemId", itemLists[i].LmItemId);
					for (int j = 0; j < itemLists[i].SkuLists.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"ItemList." + (i + 1) + ".SkuList." +(j + 1), itemLists[i].SkuLists[j]);
					}
				}
			}
		}

		public class ItemList
		{

			private long? itemId;

			private string lmItemId;

			private List<long?> skuLists = new List<long?>(){ };

			public long? ItemId
			{
				get
				{
					return itemId;
				}
				set	
				{
					itemId = value;
				}
			}

			public string LmItemId
			{
				get
				{
					return lmItemId;
				}
				set	
				{
					lmItemId = value;
				}
			}

			public List<long?> SkuLists
			{
				get
				{
					return skuLists;
				}
				set	
				{
					skuLists = value;
				}
			}
		}

        public override AddSupplierNewItemsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddSupplierNewItemsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
