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

namespace Aliyun.Acs.cloudesl.Model.V20180801
{
	public class DescribeItemsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string message;

		private string errorCode;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeItems_ItemInfo> items;

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

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public List<DescribeItems_ItemInfo> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeItems_ItemInfo
		{

			private string companyId;

			private string storeId;

			private string priceUnit;

			private int? actionPrice;

			private string itemBarCode;

			private string itemTitle;

			private long? itemId;

			private string modelNumber;

			private string brandName;

			private string saleSpec;

			private string categoryName;

			private string rank;

			private string energyEfficiency;

			private string skuId;

			private string promotionStart;

			private string promotionEnd;

			private string promotionText;

			private string promotionReason;

			private bool? bePromotion;

			private string itemQrCode;

			private int? originalPrice;

			private int? memberPrice;

			private int? suggestPrice;

			private string itemShortTitle;

			private string optionGroups;

			private string productionPlace;

			private string positionCode;

			private string extraAttribute;

			private bool? beSourceCode;

			private string sourceCode;

			private string forestFirstId;

			private string forestSecondId;

			private string customizeFeatureA;

			private string customizeFeatureB;

			private string customizeFeatureC;

			private string customizeFeatureD;

			private string customizeFeatureE;

			private string customizeFeatureF;

			private string customizeFeatureG;

			private string customizeFeatureH;

			private string customizeFeatureI;

			private string customizeFeatureJ;

			public string CompanyId
			{
				get
				{
					return companyId;
				}
				set	
				{
					companyId = value;
				}
			}

			public string StoreId
			{
				get
				{
					return storeId;
				}
				set	
				{
					storeId = value;
				}
			}

			public string PriceUnit
			{
				get
				{
					return priceUnit;
				}
				set	
				{
					priceUnit = value;
				}
			}

			public int? ActionPrice
			{
				get
				{
					return actionPrice;
				}
				set	
				{
					actionPrice = value;
				}
			}

			public string ItemBarCode
			{
				get
				{
					return itemBarCode;
				}
				set	
				{
					itemBarCode = value;
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

			public string ModelNumber
			{
				get
				{
					return modelNumber;
				}
				set	
				{
					modelNumber = value;
				}
			}

			public string BrandName
			{
				get
				{
					return brandName;
				}
				set	
				{
					brandName = value;
				}
			}

			public string SaleSpec
			{
				get
				{
					return saleSpec;
				}
				set	
				{
					saleSpec = value;
				}
			}

			public string CategoryName
			{
				get
				{
					return categoryName;
				}
				set	
				{
					categoryName = value;
				}
			}

			public string Rank
			{
				get
				{
					return rank;
				}
				set	
				{
					rank = value;
				}
			}

			public string EnergyEfficiency
			{
				get
				{
					return energyEfficiency;
				}
				set	
				{
					energyEfficiency = value;
				}
			}

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

			public string PromotionStart
			{
				get
				{
					return promotionStart;
				}
				set	
				{
					promotionStart = value;
				}
			}

			public string PromotionEnd
			{
				get
				{
					return promotionEnd;
				}
				set	
				{
					promotionEnd = value;
				}
			}

			public string PromotionText
			{
				get
				{
					return promotionText;
				}
				set	
				{
					promotionText = value;
				}
			}

			public string PromotionReason
			{
				get
				{
					return promotionReason;
				}
				set	
				{
					promotionReason = value;
				}
			}

			public bool? BePromotion
			{
				get
				{
					return bePromotion;
				}
				set	
				{
					bePromotion = value;
				}
			}

			public string ItemQrCode
			{
				get
				{
					return itemQrCode;
				}
				set	
				{
					itemQrCode = value;
				}
			}

			public int? OriginalPrice
			{
				get
				{
					return originalPrice;
				}
				set	
				{
					originalPrice = value;
				}
			}

			public int? MemberPrice
			{
				get
				{
					return memberPrice;
				}
				set	
				{
					memberPrice = value;
				}
			}

			public int? SuggestPrice
			{
				get
				{
					return suggestPrice;
				}
				set	
				{
					suggestPrice = value;
				}
			}

			public string ItemShortTitle
			{
				get
				{
					return itemShortTitle;
				}
				set	
				{
					itemShortTitle = value;
				}
			}

			public string OptionGroups
			{
				get
				{
					return optionGroups;
				}
				set	
				{
					optionGroups = value;
				}
			}

			public string ProductionPlace
			{
				get
				{
					return productionPlace;
				}
				set	
				{
					productionPlace = value;
				}
			}

			public string PositionCode
			{
				get
				{
					return positionCode;
				}
				set	
				{
					positionCode = value;
				}
			}

			public string ExtraAttribute
			{
				get
				{
					return extraAttribute;
				}
				set	
				{
					extraAttribute = value;
				}
			}

			public bool? BeSourceCode
			{
				get
				{
					return beSourceCode;
				}
				set	
				{
					beSourceCode = value;
				}
			}

			public string SourceCode
			{
				get
				{
					return sourceCode;
				}
				set	
				{
					sourceCode = value;
				}
			}

			public string ForestFirstId
			{
				get
				{
					return forestFirstId;
				}
				set	
				{
					forestFirstId = value;
				}
			}

			public string ForestSecondId
			{
				get
				{
					return forestSecondId;
				}
				set	
				{
					forestSecondId = value;
				}
			}

			public string CustomizeFeatureA
			{
				get
				{
					return customizeFeatureA;
				}
				set	
				{
					customizeFeatureA = value;
				}
			}

			public string CustomizeFeatureB
			{
				get
				{
					return customizeFeatureB;
				}
				set	
				{
					customizeFeatureB = value;
				}
			}

			public string CustomizeFeatureC
			{
				get
				{
					return customizeFeatureC;
				}
				set	
				{
					customizeFeatureC = value;
				}
			}

			public string CustomizeFeatureD
			{
				get
				{
					return customizeFeatureD;
				}
				set	
				{
					customizeFeatureD = value;
				}
			}

			public string CustomizeFeatureE
			{
				get
				{
					return customizeFeatureE;
				}
				set	
				{
					customizeFeatureE = value;
				}
			}

			public string CustomizeFeatureF
			{
				get
				{
					return customizeFeatureF;
				}
				set	
				{
					customizeFeatureF = value;
				}
			}

			public string CustomizeFeatureG
			{
				get
				{
					return customizeFeatureG;
				}
				set	
				{
					customizeFeatureG = value;
				}
			}

			public string CustomizeFeatureH
			{
				get
				{
					return customizeFeatureH;
				}
				set	
				{
					customizeFeatureH = value;
				}
			}

			public string CustomizeFeatureI
			{
				get
				{
					return customizeFeatureI;
				}
				set	
				{
					customizeFeatureI = value;
				}
			}

			public string CustomizeFeatureJ
			{
				get
				{
					return customizeFeatureJ;
				}
				set	
				{
					customizeFeatureJ = value;
				}
			}
		}
	}
}
