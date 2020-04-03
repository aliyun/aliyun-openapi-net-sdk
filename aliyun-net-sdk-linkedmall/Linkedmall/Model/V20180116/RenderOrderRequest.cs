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
    public class RenderOrderRequest : RpcAcsRequest<RenderOrderResponse>
    {
        public RenderOrderRequest()
            : base("linkedmall", "2018-01-16", "RenderOrder", "linkedmall", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string bizUid;

		private string extJson;

		private bool? useAnonymousTbAccount;

		private string lmItemId;

		private List<ItemList> itemLists = new List<ItemList>(){ };

		private string thirdPartyUserId;

		private string bizId;

		private string deliveryAddress;

		public string BizUid
		{
			get
			{
				return bizUid;
			}
			set	
			{
				bizUid = value;
				DictionaryUtil.Add(QueryParameters, "BizUid", value);
			}
		}

		public string ExtJson
		{
			get
			{
				return extJson;
			}
			set	
			{
				extJson = value;
				DictionaryUtil.Add(QueryParameters, "ExtJson", value);
			}
		}

		public bool? UseAnonymousTbAccount
		{
			get
			{
				return useAnonymousTbAccount;
			}
			set	
			{
				useAnonymousTbAccount = value;
				DictionaryUtil.Add(QueryParameters, "UseAnonymousTbAccount", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "LmItemId", value);
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
					DictionaryUtil.Add(QueryParameters,"ItemList." + (i + 1) + ".Quantity", itemLists[i].Quantity);
					DictionaryUtil.Add(QueryParameters,"ItemList." + (i + 1) + ".LmItemId", itemLists[i].LmItemId);
					DictionaryUtil.Add(QueryParameters,"ItemList." + (i + 1) + ".SkuId", itemLists[i].SkuId);
				}
			}
		}

		public string ThirdPartyUserId
		{
			get
			{
				return thirdPartyUserId;
			}
			set	
			{
				thirdPartyUserId = value;
				DictionaryUtil.Add(QueryParameters, "ThirdPartyUserId", value);
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

		public string DeliveryAddress
		{
			get
			{
				return deliveryAddress;
			}
			set	
			{
				deliveryAddress = value;
				DictionaryUtil.Add(QueryParameters, "DeliveryAddress", value);
			}
		}

		public class ItemList
		{

			private long? itemId;

			private int? quantity;

			private string lmItemId;

			private long? skuId;

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

			public int? Quantity
			{
				get
				{
					return quantity;
				}
				set	
				{
					quantity = value;
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

			public long? SkuId
			{
				get
				{
					return skuId;
				}
				set	
				{
					skuId = value;
				}
			}
		}

        public override RenderOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RenderOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
