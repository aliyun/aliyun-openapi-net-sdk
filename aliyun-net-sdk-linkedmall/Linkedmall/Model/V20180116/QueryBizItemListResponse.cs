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
	public class QueryBizItemListResponse : AcsResponse
	{

		private string code;

		private string message;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private List<QueryBizItemList_Item> itemList;

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

		public int? TotalCount
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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
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
			}
		}

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

		public List<QueryBizItemList_Item> ItemList
		{
			get
			{
				return itemList;
			}
			set	
			{
				itemList = value;
			}
		}

		public class QueryBizItemList_Item
		{

			private long? itemId;

			private string itemTitle;

			private string customizedItemName;

			private string mainPicUrl;

			private long? reservePrice;

			private long? categoryId;

			private bool? canSell;

			private string taobaoShopName;

			private string extJson;

			private long? sellerId;

			private string lmItemId;

			private List<QueryBizItemList_Sku> skuList;

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

			public string CustomizedItemName
			{
				get
				{
					return customizedItemName;
				}
				set	
				{
					customizedItemName = value;
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

			public string TaobaoShopName
			{
				get
				{
					return taobaoShopName;
				}
				set	
				{
					taobaoShopName = value;
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

			public List<QueryBizItemList_Sku> SkuList
			{
				get
				{
					return skuList;
				}
				set	
				{
					skuList = value;
				}
			}

			public class QueryBizItemList_Sku
			{

				private long? skuId;

				private string skuPicUrl;

				private string skuTitle;

				private long? priceCent;

				private long? points;

				private long? pointsAmount;

				private string benefitId;

				private bool? canSell;

				private string customizedAttributeMap;

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

				public string BenefitId
				{
					get
					{
						return benefitId;
					}
					set	
					{
						benefitId = value;
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
			}
		}
	}
}
