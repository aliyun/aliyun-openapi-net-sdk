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
	public class QueryItemDetailResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private string subCode;

		private string subMessage;

		private bool? success;

		private QueryItemDetail_Item item;

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

		public QueryItemDetail_Item Item
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

		public class QueryItemDetail_Item
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

			private string extJson;

			private string propertiesJson;

			private string iforestPropsJson;

			private string descOption;

			private string iforestProps;

			private long? sellerId;

			private string tbShopName;

			private string lmItemCategory;

			private bool? centerInventory;

			private string customizedAttributeMap;

			private string lmItemId;

			private List<QueryItemDetail_Sku> skus;

			private List<string> itemImages;

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

			public string PropertiesJson
			{
				get
				{
					return propertiesJson;
				}
				set	
				{
					propertiesJson = value;
				}
			}

			public string IforestPropsJson
			{
				get
				{
					return iforestPropsJson;
				}
				set	
				{
					iforestPropsJson = value;
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

			public string IforestProps
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

			public string CustomizedAttributeMap
			{
				get
				{
					return customizedAttributeMap;
				}
				set	
				{
					customizedAttributeMap = value;
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

			public List<QueryItemDetail_Sku> Skus
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

			public class QueryItemDetail_Sku
			{

				private string extJson;

				private long? itemId;

				private long? skuId;

				private string skuProperties;

				private string skuPicUrl;

				private string skuTitle;

				private int? quantity;

				private long? priceCent;

				private long? points;

				private long? pointsAmount;

				private long? pointPrice;

				private string skuPropertiesJson;

				private long? reservePrice;

				private bool? canSell;

				private string customizedAttributeMap;

				private string lmItemId;

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

				public string SkuProperties
				{
					get
					{
						return skuProperties;
					}
					set	
					{
						skuProperties = value;
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

				public string SkuPropertiesJson
				{
					get
					{
						return skuPropertiesJson;
					}
					set	
					{
						skuPropertiesJson = value;
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

				public string CustomizedAttributeMap
				{
					get
					{
						return customizedAttributeMap;
					}
					set	
					{
						customizedAttributeMap = value;
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
			}
		}
	}
}
