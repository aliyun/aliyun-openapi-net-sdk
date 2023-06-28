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
using Aliyun.Acs.retailadvqa;
using Aliyun.Acs.retailadvqa.Transform;
using Aliyun.Acs.retailadvqa.Transform.V20230417;

namespace Aliyun.Acs.retailadvqa.Model.V20230417
{
    public class SyncCardInfoRequest : RpcAcsRequest<SyncCardInfoResponse>
    {
        public SyncCardInfoRequest()
            : base("retailadvqa", "2023-04-17", "SyncCardInfo")
        {
			Method = MethodType.POST;
        }

		private Body body_;

		[JsonProperty(PropertyName = "body")]
		public Body Body_
		{
			get
			{
				return body_;
			}

			set
			{
				body_ = value;
				DictionaryUtil.Add(QueryParameters, "body", JsonConvert.SerializeObject(value));

			}
		}

		public class Body
		{

			private string occurredAt;

			private string openMerchantId;

			private string transferredAt;

			private string orderId;

			private PresentDetail presentDetail_;

			private string transferId;

			private string buyerId;

			private string receivedAt;

			private Gifters gifters_;

			private string extra;

			private Recipient recipient_;

			private string theme;

			private string status;

			[JsonProperty(PropertyName = "OccurredAt")]
			public string OccurredAt
			{
				get
				{
					return occurredAt;
				}
				set	
				{
					occurredAt = value;
				}
			}

			[JsonProperty(PropertyName = "OpenMerchantId")]
			public string OpenMerchantId
			{
				get
				{
					return openMerchantId;
				}
				set	
				{
					openMerchantId = value;
				}
			}

			[JsonProperty(PropertyName = "TransferredAt")]
			public string TransferredAt
			{
				get
				{
					return transferredAt;
				}
				set	
				{
					transferredAt = value;
				}
			}

			[JsonProperty(PropertyName = "OrderId")]
			public string OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}

			[JsonProperty(PropertyName = "PresentDetail")]
			public PresentDetail PresentDetail_
			{
				get
				{
					return presentDetail_;
				}
				set	
				{
					presentDetail_ = value;
				}
			}

			[JsonProperty(PropertyName = "TransferId")]
			public string TransferId
			{
				get
				{
					return transferId;
				}
				set	
				{
					transferId = value;
				}
			}

			[JsonProperty(PropertyName = "BuyerId")]
			public string BuyerId
			{
				get
				{
					return buyerId;
				}
				set	
				{
					buyerId = value;
				}
			}

			[JsonProperty(PropertyName = "ReceivedAt")]
			public string ReceivedAt
			{
				get
				{
					return receivedAt;
				}
				set	
				{
					receivedAt = value;
				}
			}

			[JsonProperty(PropertyName = "Gifters")]
			public Gifters Gifters_
			{
				get
				{
					return gifters_;
				}
				set	
				{
					gifters_ = value;
				}
			}

			[JsonProperty(PropertyName = "Extra")]
			public string Extra
			{
				get
				{
					return extra;
				}
				set	
				{
					extra = value;
				}
			}

			[JsonProperty(PropertyName = "Recipient")]
			public Recipient Recipient_
			{
				get
				{
					return recipient_;
				}
				set	
				{
					recipient_ = value;
				}
			}

			[JsonProperty(PropertyName = "Theme")]
			public string Theme
			{
				get
				{
					return theme;
				}
				set	
				{
					theme = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public class PresentDetail
			{

				private string itemId;

				private double? price;

				private string name;

				private long? count;

				private string skuId;

				[JsonProperty(PropertyName = "ItemId")]
				public string ItemId
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

				[JsonProperty(PropertyName = "Price")]
				public double? Price
				{
					get
					{
						return price;
					}
					set	
					{
						price = value;
					}
				}

				[JsonProperty(PropertyName = "Name")]
				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				[JsonProperty(PropertyName = "Count")]
				public long? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				[JsonProperty(PropertyName = "SkuId")]
				public string SkuId
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

			public class Gifters
			{

				private string phone;

				private string openId;

				private string nickname;

				private string id;

				private string headerImg;

				[JsonProperty(PropertyName = "Phone")]
				public string Phone
				{
					get
					{
						return phone;
					}
					set	
					{
						phone = value;
					}
				}

				[JsonProperty(PropertyName = "OpenId")]
				public string OpenId
				{
					get
					{
						return openId;
					}
					set	
					{
						openId = value;
					}
				}

				[JsonProperty(PropertyName = "Nickname")]
				public string Nickname
				{
					get
					{
						return nickname;
					}
					set	
					{
						nickname = value;
					}
				}

				[JsonProperty(PropertyName = "Id")]
				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				[JsonProperty(PropertyName = "HeaderImg")]
				public string HeaderImg
				{
					get
					{
						return headerImg;
					}
					set	
					{
						headerImg = value;
					}
				}
			}

			public class Recipient
			{

				private string phone;

				private string openId;

				private string nickname;

				private string id;

				private string headerImg;

				[JsonProperty(PropertyName = "Phone")]
				public string Phone
				{
					get
					{
						return phone;
					}
					set	
					{
						phone = value;
					}
				}

				[JsonProperty(PropertyName = "OpenId")]
				public string OpenId
				{
					get
					{
						return openId;
					}
					set	
					{
						openId = value;
					}
				}

				[JsonProperty(PropertyName = "Nickname")]
				public string Nickname
				{
					get
					{
						return nickname;
					}
					set	
					{
						nickname = value;
					}
				}

				[JsonProperty(PropertyName = "Id")]
				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				[JsonProperty(PropertyName = "HeaderImg")]
				public string HeaderImg
				{
					get
					{
						return headerImg;
					}
					set	
					{
						headerImg = value;
					}
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SyncCardInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SyncCardInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
