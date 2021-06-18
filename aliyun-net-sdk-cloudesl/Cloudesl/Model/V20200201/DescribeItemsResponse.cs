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

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
	public class DescribeItemsResponse : AcsResponse
	{

		private string errorMessage;

		private string errorCode;

		private int? pageNumber;

		private string message;

		private int? pageSize;

		private string dynamicCode;

		private string code;

		private string dynamicMessage;

		private int? totalCount;

		private string requestId;

		private bool? success;

		private string templateSceneId;

		private List<DescribeItems_ItemInfo> items;

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
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

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
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

		public string TemplateSceneId
		{
			get
			{
				return templateSceneId;
			}
			set	
			{
				templateSceneId = value;
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

			private string categoryName;

			private string energyEfficiency;

			private string customizeFeatureO;

			private string manufacturer;

			private string customizeFeatureM;

			private string customizeFeatureN;

			private string customizeFeatureK;

			private string customizeFeatureL;

			private string promotionEnd;

			private int? originalPrice;

			private string customizeFeatureI;

			private string itemTitle;

			private string customizeFeatureJ;

			private string customizeFeatureG;

			private string saleSpec;

			private string customizeFeatureH;

			private string customizeFeatureE;

			private string customizeFeatureF;

			private string customizeFeatureC;

			private string customizeFeatureD;

			private string customizeFeatureA;

			private string customizeFeatureB;

			private string taxFee;

			private string promotionText;

			private int? memberPrice;

			private string supplierName;

			private string forestFirstId;

			private string modelNumber;

			private string itemShortTitle;

			private string material;

			private bool? bePromotion;

			private string forestSecondId;

			private bool? beSourceCode;

			private int? salesPrice;

			private string itemPicUrl;

			private string skuId;

			private int? suggestPrice;

			private string rank;

			private string sourceCode;

			private string productionPlace;

			private int? itemInfoIndex;

			private string inventoryStatus;

			private string priceUnit;

			private int? actionPrice;

			private string brandName;

			private string itemQrCode;

			private string promotionReason;

			private string itemBarCode;

			private string itemId;

			private string promotionStart;

			private string gmtCreate;

			private string gmtModified;

			private bool? beMember;

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

			public string CustomizeFeatureO
			{
				get
				{
					return customizeFeatureO;
				}
				set	
				{
					customizeFeatureO = value;
				}
			}

			public string Manufacturer
			{
				get
				{
					return manufacturer;
				}
				set	
				{
					manufacturer = value;
				}
			}

			public string CustomizeFeatureM
			{
				get
				{
					return customizeFeatureM;
				}
				set	
				{
					customizeFeatureM = value;
				}
			}

			public string CustomizeFeatureN
			{
				get
				{
					return customizeFeatureN;
				}
				set	
				{
					customizeFeatureN = value;
				}
			}

			public string CustomizeFeatureK
			{
				get
				{
					return customizeFeatureK;
				}
				set	
				{
					customizeFeatureK = value;
				}
			}

			public string CustomizeFeatureL
			{
				get
				{
					return customizeFeatureL;
				}
				set	
				{
					customizeFeatureL = value;
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

			public string TaxFee
			{
				get
				{
					return taxFee;
				}
				set	
				{
					taxFee = value;
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

			public string SupplierName
			{
				get
				{
					return supplierName;
				}
				set	
				{
					supplierName = value;
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

			public string Material
			{
				get
				{
					return material;
				}
				set	
				{
					material = value;
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

			public int? SalesPrice
			{
				get
				{
					return salesPrice;
				}
				set	
				{
					salesPrice = value;
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

			public int? ItemInfoIndex
			{
				get
				{
					return itemInfoIndex;
				}
				set	
				{
					itemInfoIndex = value;
				}
			}

			public string InventoryStatus
			{
				get
				{
					return inventoryStatus;
				}
				set	
				{
					inventoryStatus = value;
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

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public bool? BeMember
			{
				get
				{
					return beMember;
				}
				set	
				{
					beMember = value;
				}
			}
		}
	}
}
