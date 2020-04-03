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
    public class CreateVirtualProductOrderRequest : RpcAcsRequest<CreateVirtualProductOrderResponse>
    {
        public CreateVirtualProductOrderRequest()
            : base("linkedmall", "2018-01-16", "CreateVirtualProductOrder", "linkedmall", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? quantity;

		private string bizUid;

		private string extJson;

		private string accountType;

		private bool? useAnonymousTbAccount;

		private long? orderExpireTime;

		private string lmItemId;

		private List<ItemList> itemLists = new List<ItemList>(){ };

		private long? itemId;

		private long? totalAmount;

		private string thirdPartyUserId;

		private string bizId;

		private string outTradeId;

		private string deliveryAddress;

		public long? Quantity
		{
			get
			{
				return quantity;
			}
			set	
			{
				quantity = value;
				DictionaryUtil.Add(QueryParameters, "Quantity", value.ToString());
			}
		}

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

		public string AccountType
		{
			get
			{
				return accountType;
			}
			set	
			{
				accountType = value;
				DictionaryUtil.Add(QueryParameters, "AccountType", value);
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

		public long? OrderExpireTime
		{
			get
			{
				return orderExpireTime;
			}
			set	
			{
				orderExpireTime = value;
				DictionaryUtil.Add(QueryParameters, "OrderExpireTime", value.ToString());
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

		public long? TotalAmount
		{
			get
			{
				return totalAmount;
			}
			set	
			{
				totalAmount = value;
				DictionaryUtil.Add(QueryParameters, "TotalAmount", value.ToString());
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

		public string OutTradeId
		{
			get
			{
				return outTradeId;
			}
			set	
			{
				outTradeId = value;
				DictionaryUtil.Add(QueryParameters, "OutTradeId", value);
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

        public override CreateVirtualProductOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateVirtualProductOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
