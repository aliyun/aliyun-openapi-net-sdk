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
	public class QueryActivityItemsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<QueryActivityItems_LmActivityItemModel> lmActivityItemModelList;

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

		public long? PageNumber
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

		public long? PageSize
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

		public List<QueryActivityItems_LmActivityItemModel> LmActivityItemModelList
		{
			get
			{
				return lmActivityItemModelList;
			}
			set	
			{
				lmActivityItemModelList = value;
			}
		}

		public class QueryActivityItems_LmActivityItemModel
		{

			private string lmItemId;

			private long? itemId;

			private string itemTitle;

			private long? lmActivityId;

			private string mainPicUrl;

			private long? tbSellerId;

			private long? tbShopId;

			private string lmShopId;

			private string tbShopName;

			private int? itemActivityQuantity;

			private int? sellableQuantity;

			private string itemActivityStatus;

			private bool? canSell;

			private string tips;

			private List<QueryActivityItems_LmActivityItemSkuModel> skuModelList;

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

			public long? LmActivityId
			{
				get
				{
					return lmActivityId;
				}
				set	
				{
					lmActivityId = value;
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

			public long? TbSellerId
			{
				get
				{
					return tbSellerId;
				}
				set	
				{
					tbSellerId = value;
				}
			}

			public long? TbShopId
			{
				get
				{
					return tbShopId;
				}
				set	
				{
					tbShopId = value;
				}
			}

			public string LmShopId
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

			public int? ItemActivityQuantity
			{
				get
				{
					return itemActivityQuantity;
				}
				set	
				{
					itemActivityQuantity = value;
				}
			}

			public int? SellableQuantity
			{
				get
				{
					return sellableQuantity;
				}
				set	
				{
					sellableQuantity = value;
				}
			}

			public string ItemActivityStatus
			{
				get
				{
					return itemActivityStatus;
				}
				set	
				{
					itemActivityStatus = value;
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

			public string Tips
			{
				get
				{
					return tips;
				}
				set	
				{
					tips = value;
				}
			}

			public List<QueryActivityItems_LmActivityItemSkuModel> SkuModelList
			{
				get
				{
					return skuModelList;
				}
				set	
				{
					skuModelList = value;
				}
			}

			public class QueryActivityItems_LmActivityItemSkuModel
			{

				private string bizId;

				private long? skuId;

				private string skuTitle;

				private string skuPicUrl;

				private long? reservedPrice;

				private long? activityPrice;

				private string activityStatus;

				private string tips;

				private string lmItemId;

				private long? itemId;

				private long? lmActivityId;

				public string BizId
				{
					get
					{
						return bizId;
					}
					set	
					{
						bizId = value;
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

				public long? ReservedPrice
				{
					get
					{
						return reservedPrice;
					}
					set	
					{
						reservedPrice = value;
					}
				}

				public long? ActivityPrice
				{
					get
					{
						return activityPrice;
					}
					set	
					{
						activityPrice = value;
					}
				}

				public string ActivityStatus
				{
					get
					{
						return activityStatus;
					}
					set	
					{
						activityStatus = value;
					}
				}

				public string Tips
				{
					get
					{
						return tips;
					}
					set	
					{
						tips = value;
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

				public long? LmActivityId
				{
					get
					{
						return lmActivityId;
					}
					set	
					{
						lmActivityId = value;
					}
				}
			}
		}
	}
}
