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

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
	public class RenderOrderResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private string subCode;

		private string subMessage;

		private string logsId;

		private bool? success;

		private long? totalCount;

		private RenderOrder_Model model;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public string SubCode
		{
			get
			{
				return subCode;
			}
			set	
			{
				subCode = value;
			}
		}

		public string SubMessage
		{
			get
			{
				return subMessage;
			}
			set	
			{
				subMessage = value;
			}
		}

		public string LogsId
		{
			get
			{
				return logsId;
			}
			set	
			{
				logsId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public RenderOrder_Model Model
		{
			get
			{
				return model;
			}
			set	
			{
				model = value;
			}
		}

		public class RenderOrder_Model
		{

			private List<RenderOrder_RenderOrderInfosItem> renderOrderInfos;

			public List<RenderOrder_RenderOrderInfosItem> RenderOrderInfos
			{
				get
				{
					return renderOrderInfos;
				}
				set	
				{
					renderOrderInfos = value;
				}
			}

			public class RenderOrder_RenderOrderInfosItem
			{

				private string extInfo;

				private List<RenderOrder_LmItemInfosItem> lmItemInfos;

				private List<RenderOrder_DeliveryInfosItem> deliveryInfos;

				public string ExtInfo
				{
					get
					{
						return extInfo;
					}
					set	
					{
						extInfo = value;
					}
				}

				public List<RenderOrder_LmItemInfosItem> LmItemInfos
				{
					get
					{
						return lmItemInfos;
					}
					set	
					{
						lmItemInfos = value;
					}
				}

				public List<RenderOrder_DeliveryInfosItem> DeliveryInfos
				{
					get
					{
						return deliveryInfos;
					}
					set	
					{
						deliveryInfos = value;
					}
				}

				public class RenderOrder_LmItemInfosItem
				{

					private long? itemId;

					private long? skuId;

					private int? quantity;

					private bool? canSell;

					private string message;

					private string itemName;

					private string skuName;

					private string lmItemId;

					private long? sellerId;

					private string sellerNick;

					private long? cash;

					private long? points;

					private long? actualPrice;

					private string itemPicUrl;

					private string message1;

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

					public bool? CanSell
					{
						get
						{
							return canSell;
						}
						set	
						{
							canSell = value;
						}
					}

					public string Message
					{
						get
						{
							return message;
						}
						set	
						{
							message = value;
						}
					}

					public string ItemName
					{
						get
						{
							return itemName;
						}
						set	
						{
							itemName = value;
						}
					}

					public string SkuName
					{
						get
						{
							return skuName;
						}
						set	
						{
							skuName = value;
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

					public long? SellerId
					{
						get
						{
							return sellerId;
						}
						set	
						{
							sellerId = value;
						}
					}

					public string SellerNick
					{
						get
						{
							return sellerNick;
						}
						set	
						{
							sellerNick = value;
						}
					}

					public long? Cash
					{
						get
						{
							return cash;
						}
						set	
						{
							cash = value;
						}
					}

					public long? Points
					{
						get
						{
							return points;
						}
						set	
						{
							points = value;
						}
					}

					public long? ActualPrice
					{
						get
						{
							return actualPrice;
						}
						set	
						{
							actualPrice = value;
						}
					}

					public string ItemPicUrl
					{
						get
						{
							return itemPicUrl;
						}
						set	
						{
							itemPicUrl = value;
						}
					}

					public string Message1
					{
						get
						{
							return message1;
						}
						set	
						{
							message1 = value;
						}
					}
				}

				public class RenderOrder_DeliveryInfosItem
				{

					private string id;

					private string displayName;

					private long? postFee;

					private long? serviceType;

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

					public string DisplayName
					{
						get
						{
							return displayName;
						}
						set	
						{
							displayName = value;
						}
					}

					public long? PostFee
					{
						get
						{
							return postFee;
						}
						set	
						{
							postFee = value;
						}
					}

					public long? ServiceType
					{
						get
						{
							return serviceType;
						}
						set	
						{
							serviceType = value;
						}
					}
				}
			}
		}
	}
}
