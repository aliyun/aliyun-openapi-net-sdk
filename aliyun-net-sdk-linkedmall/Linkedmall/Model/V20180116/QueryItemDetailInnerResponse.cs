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
	public class QueryItemDetailInnerResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private QueryItemDetailInner_Item item;

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

		public QueryItemDetailInner_Item Item
		{
			get
			{
				return item;
			}
			set	
			{
				item = value;
			}
		}

		public class QueryItemDetailInner_Item
		{

			private long? itemId;

			private string itemTitle;

			private string mainPicUrl;

			private string descPath;

			private long? minPrice;

			private long? minPoints;

			private long? reservePrice;

			private int? quantity;

			private bool? isSellerPayPostfee;

			private bool? isCanSell;

			private int? totalSoldQuantity;

			private string properties;

			private bool? canSell;

			private bool? sellerPayPostfee;

			private long? categoryId;

			private long? sellerId;

			private string tbShopName;

			private string lmItemCategory;

			private bool? centerInventory;

			private string province;

			private string city;

			private string descOption;

			private string sellerNick;

			private long? lmShopId;

			private List<QueryItemDetailInner_Sku> skus;

			private List<QueryItemDetailInner_SkuProperty> skuPropertys;

			private List<Dictionary<string, string>> iforestProps;

			private List<string> itemImages;

			private List<string> categoryIds;

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

			public string ItemTitle
			{
				get
				{
					return itemTitle;
				}
				set	
				{
					itemTitle = value;
				}
			}

			public string MainPicUrl
			{
				get
				{
					return mainPicUrl;
				}
				set	
				{
					mainPicUrl = value;
				}
			}

			public string DescPath
			{
				get
				{
					return descPath;
				}
				set	
				{
					descPath = value;
				}
			}

			public long? MinPrice
			{
				get
				{
					return minPrice;
				}
				set	
				{
					minPrice = value;
				}
			}

			public long? MinPoints
			{
				get
				{
					return minPoints;
				}
				set	
				{
					minPoints = value;
				}
			}

			public long? ReservePrice
			{
				get
				{
					return reservePrice;
				}
				set	
				{
					reservePrice = value;
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

			public bool? IsSellerPayPostfee
			{
				get
				{
					return isSellerPayPostfee;
				}
				set	
				{
					isSellerPayPostfee = value;
				}
			}

			public bool? IsCanSell
			{
				get
				{
					return isCanSell;
				}
				set	
				{
					isCanSell = value;
				}
			}

			public int? TotalSoldQuantity
			{
				get
				{
					return totalSoldQuantity;
				}
				set	
				{
					totalSoldQuantity = value;
				}
			}

			public string Properties
			{
				get
				{
					return properties;
				}
				set	
				{
					properties = value;
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

			public bool? SellerPayPostfee
			{
				get
				{
					return sellerPayPostfee;
				}
				set	
				{
					sellerPayPostfee = value;
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

			public string TbShopName
			{
				get
				{
					return tbShopName;
				}
				set	
				{
					tbShopName = value;
				}
			}

			public string LmItemCategory
			{
				get
				{
					return lmItemCategory;
				}
				set	
				{
					lmItemCategory = value;
				}
			}

			public bool? CenterInventory
			{
				get
				{
					return centerInventory;
				}
				set	
				{
					centerInventory = value;
				}
			}

			public string Province
			{
				get
				{
					return province;
				}
				set	
				{
					province = value;
				}
			}

			public string City
			{
				get
				{
					return city;
				}
				set	
				{
					city = value;
				}
			}

			public string DescOption
			{
				get
				{
					return descOption;
				}
				set	
				{
					descOption = value;
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

			public long? LmShopId
			{
				get
				{
					return lmShopId;
				}
				set	
				{
					lmShopId = value;
				}
			}

			public List<QueryItemDetailInner_Sku> Skus
			{
				get
				{
					return skus;
				}
				set	
				{
					skus = value;
				}
			}

			public List<QueryItemDetailInner_SkuProperty> SkuPropertys
			{
				get
				{
					return skuPropertys;
				}
				set	
				{
					skuPropertys = value;
				}
			}

			public List<Dictionary<string, string>> IforestProps
			{
				get
				{
					return iforestProps;
				}
				set	
				{
					iforestProps = value;
				}
			}

			public List<string> ItemImages
			{
				get
				{
					return itemImages;
				}
				set	
				{
					itemImages = value;
				}
			}

			public List<string> CategoryIds
			{
				get
				{
					return categoryIds;
				}
				set	
				{
					categoryIds = value;
				}
			}

			public class QueryItemDetailInner_Sku
			{

				private string extJson;

				private long? itemId;

				private long? skuId;

				private string skuPvs;

				private string skuPicUrl;

				private string skuTitle;

				private int? quantity;

				private long? priceCent;

				private long? points;

				private long? pointsAmount;

				private long? pointPrice;

				private long? reservePrice;

				private int? status;

				private string lmItemId;

				private string skuDesc;

				public string ExtJson
				{
					get
					{
						return extJson;
					}
					set	
					{
						extJson = value;
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

				public string SkuPvs
				{
					get
					{
						return skuPvs;
					}
					set	
					{
						skuPvs = value;
					}
				}

				public string SkuPicUrl
				{
					get
					{
						return skuPicUrl;
					}
					set	
					{
						skuPicUrl = value;
					}
				}

				public string SkuTitle
				{
					get
					{
						return skuTitle;
					}
					set	
					{
						skuTitle = value;
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

				public long? PriceCent
				{
					get
					{
						return priceCent;
					}
					set	
					{
						priceCent = value;
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

				public long? PointsAmount
				{
					get
					{
						return pointsAmount;
					}
					set	
					{
						pointsAmount = value;
					}
				}

				public long? PointPrice
				{
					get
					{
						return pointPrice;
					}
					set	
					{
						pointPrice = value;
					}
				}

				public long? ReservePrice
				{
					get
					{
						return reservePrice;
					}
					set	
					{
						reservePrice = value;
					}
				}

				public int? Status
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

				public string SkuDesc
				{
					get
					{
						return skuDesc;
					}
					set	
					{
						skuDesc = value;
					}
				}
			}

			public class QueryItemDetailInner_SkuProperty
			{

				private long? id;

				private string text;

				private List<QueryItemDetailInner__Value> values;

				public long? Id
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

				public string Text
				{
					get
					{
						return text;
					}
					set	
					{
						text = value;
					}
				}

				public List<QueryItemDetailInner__Value> Values
				{
					get
					{
						return values;
					}
					set	
					{
						values = value;
					}
				}

				public class QueryItemDetailInner__Value
				{

					private long? id;

					private string text;

					public long? Id
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

					public string Text
					{
						get
						{
							return text;
						}
						set	
						{
							text = value;
						}
					}
				}
			}
		}
	}
}
