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
using Aliyun.Acs.Smartag.Transform;
using Aliyun.Acs.Smartag.Transform.V20180313;

namespace Aliyun.Acs.Smartag.Model.V20180313
{
    public class UnicomOrderConfirmRequest : RpcAcsRequest<UnicomOrderConfirmResponse>
    {
        public UnicomOrderConfirmRequest()
            : base("Smartag", "2018-03-13", "UnicomOrderConfirm", "smartag", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string tmsCode;

		private List<OrderItem> orderItems = new List<OrderItem>(){ };

		private long? orderPostFee;

		private string tradeId;

		private string ownerUserId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string tmsOrderCode;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string TmsCode
		{
			get
			{
				return tmsCode;
			}
			set	
			{
				tmsCode = value;
				DictionaryUtil.Add(QueryParameters, "TmsCode", value);
			}
		}

		public List<OrderItem> OrderItems
		{
			get
			{
				return orderItems;
			}

			set
			{
				orderItems = value;
				for (int i = 0; i < orderItems.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"OrderItem." + (i + 1) + ".ScItemName", orderItems[i].ScItemName);
					DictionaryUtil.Add(QueryParameters,"OrderItem." + (i + 1) + ".ItemAmount", orderItems[i].ItemAmount);
					for (int j = 0; j < orderItems[i].SnLists.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"OrderItem." + (i + 1) + ".SnList." +(j + 1), orderItems[i].SnLists[j]);
					}
					DictionaryUtil.Add(QueryParameters,"OrderItem." + (i + 1) + ".OrderItemId", orderItems[i].OrderItemId);
					DictionaryUtil.Add(QueryParameters,"OrderItem." + (i + 1) + ".ScItemCode", orderItems[i].ScItemCode);
					DictionaryUtil.Add(QueryParameters,"OrderItem." + (i + 1) + ".ItemQuantity", orderItems[i].ItemQuantity);
					DictionaryUtil.Add(QueryParameters,"OrderItem." + (i + 1) + ".TradeId", orderItems[i].TradeId);
					DictionaryUtil.Add(QueryParameters,"OrderItem." + (i + 1) + ".TradeItemId", orderItems[i].TradeItemId);
				}
			}
		}

		public long? OrderPostFee
		{
			get
			{
				return orderPostFee;
			}
			set	
			{
				orderPostFee = value;
				DictionaryUtil.Add(QueryParameters, "OrderPostFee", value.ToString());
			}
		}

		public string TradeId
		{
			get
			{
				return tradeId;
			}
			set	
			{
				tradeId = value;
				DictionaryUtil.Add(QueryParameters, "TradeId", value);
			}
		}

		public string OwnerUserId
		{
			get
			{
				return ownerUserId;
			}
			set	
			{
				ownerUserId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerUserId", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
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

		public string TmsOrderCode
		{
			get
			{
				return tmsOrderCode;
			}
			set	
			{
				tmsOrderCode = value;
				DictionaryUtil.Add(QueryParameters, "TmsOrderCode", value);
			}
		}

		public class OrderItem
		{

			private string scItemName;

			private string itemAmount;

			private List<string> snLists = new List<string>(){ };

			private string orderItemId;

			private string scItemCode;

			private int? itemQuantity;

			private string tradeId;

			private string tradeItemId;

			public string ScItemName
			{
				get
				{
					return scItemName;
				}
				set	
				{
					scItemName = value;
				}
			}

			public string ItemAmount
			{
				get
				{
					return itemAmount;
				}
				set	
				{
					itemAmount = value;
				}
			}

			public List<string> SnLists
			{
				get
				{
					return snLists;
				}
				set	
				{
					snLists = value;
				}
			}

			public string OrderItemId
			{
				get
				{
					return orderItemId;
				}
				set	
				{
					orderItemId = value;
				}
			}

			public string ScItemCode
			{
				get
				{
					return scItemCode;
				}
				set	
				{
					scItemCode = value;
				}
			}

			public int? ItemQuantity
			{
				get
				{
					return itemQuantity;
				}
				set	
				{
					itemQuantity = value;
				}
			}

			public string TradeId
			{
				get
				{
					return tradeId;
				}
				set	
				{
					tradeId = value;
				}
			}

			public string TradeItemId
			{
				get
				{
					return tradeItemId;
				}
				set	
				{
					tradeItemId = value;
				}
			}
		}

        public override UnicomOrderConfirmResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UnicomOrderConfirmResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
