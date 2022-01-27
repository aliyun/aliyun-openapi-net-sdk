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
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20200201;

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
    public class BatchInsertItemsRequest : RpcAcsRequest<BatchInsertItemsResponse>
    {
        public BatchInsertItemsRequest()
            : base("cloudesl", "2020-02-01", "BatchInsertItems", "cloudesl", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string extraParams;

		private string storeId;

		private bool? syncByItemId;

		private List<ItemInfo> itemInfos = new List<ItemInfo>(){ };

		public string ExtraParams
		{
			get
			{
				return extraParams;
			}
			set	
			{
				extraParams = value;
				DictionaryUtil.Add(BodyParameters, "ExtraParams", value);
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
				DictionaryUtil.Add(BodyParameters, "StoreId", value);
			}
		}

		public bool? SyncByItemId
		{
			get
			{
				return syncByItemId;
			}
			set	
			{
				syncByItemId = value;
				DictionaryUtil.Add(BodyParameters, "SyncByItemId", value.ToString());
			}
		}

		public List<ItemInfo> ItemInfos
		{
			get
			{
				return itemInfos;
			}

			set
			{
				itemInfos = value;
				for (int i = 0; i < itemInfos.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".MemberPrice", itemInfos[i].MemberPrice);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ActionPrice", itemInfos[i].ActionPrice);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".BeSourceCode", itemInfos[i].BeSourceCode);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".BrandName", itemInfos[i].BrandName);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".PromotionStart", itemInfos[i].PromotionStart);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".PriceUnit", itemInfos[i].PriceUnit);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".Rank", itemInfos[i].Rank);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ItemInfoIndex", itemInfos[i].ItemInfoIndex);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ItemBarCode", itemInfos[i].ItemBarCode);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureK", itemInfos[i].CustomizeFeatureK);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureL", itemInfos[i].CustomizeFeatureL);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureM", itemInfos[i].CustomizeFeatureM);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".BePromotion", itemInfos[i].BePromotion);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureN", itemInfos[i].CustomizeFeatureN);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureO", itemInfos[i].CustomizeFeatureO);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".PromotionEnd", itemInfos[i].PromotionEnd);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ItemTitle", itemInfos[i].ItemTitle);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureC", itemInfos[i].CustomizeFeatureC);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureD", itemInfos[i].CustomizeFeatureD);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ItemQrCode", itemInfos[i].ItemQrCode);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureE", itemInfos[i].CustomizeFeatureE);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".InventoryStatus", itemInfos[i].InventoryStatus);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".PromotionReason", itemInfos[i].PromotionReason);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureF", itemInfos[i].CustomizeFeatureF);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureG", itemInfos[i].CustomizeFeatureG);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureH", itemInfos[i].CustomizeFeatureH);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureI", itemInfos[i].CustomizeFeatureI);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureJ", itemInfos[i].CustomizeFeatureJ);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureA", itemInfos[i].CustomizeFeatureA);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureB", itemInfos[i].CustomizeFeatureB);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".SuggestPrice", itemInfos[i].SuggestPrice);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ForestFirstId", itemInfos[i].ForestFirstId);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ProductionPlace", itemInfos[i].ProductionPlace);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".Manufacturer", itemInfos[i].Manufacturer);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".SourceCode", itemInfos[i].SourceCode);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ItemId", itemInfos[i].ItemId);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".BeMember", itemInfos[i].BeMember);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".TemplateSceneId", itemInfos[i].TemplateSceneId);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".SalesPrice", itemInfos[i].SalesPrice);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".OriginalPrice", itemInfos[i].OriginalPrice);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ItemShortTitle", itemInfos[i].ItemShortTitle);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ForestSecondId", itemInfos[i].ForestSecondId);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ItemPicUrl", itemInfos[i].ItemPicUrl);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".SupplierName", itemInfos[i].SupplierName);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".Material", itemInfos[i].Material);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ModelNumber", itemInfos[i].ModelNumber);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".SaleSpec", itemInfos[i].SaleSpec);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CategoryName", itemInfos[i].CategoryName);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".TaxFee", itemInfos[i].TaxFee);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".EnergyEfficiency", itemInfos[i].EnergyEfficiency);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".PromotionText", itemInfos[i].PromotionText);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".SkuId", itemInfos[i].SkuId);
				}
			}
		}

		public class ItemInfo
		{

			private int? memberPrice;

			private int? actionPrice;

			private bool? beSourceCode;

			private string brandName;

			private string promotionStart;

			private string priceUnit;

			private string rank;

			private int? itemInfoIndex;

			private string itemBarCode;

			private string customizeFeatureK;

			private string customizeFeatureL;

			private string customizeFeatureM;

			private bool? bePromotion;

			private string customizeFeatureN;

			private string customizeFeatureO;

			private string promotionEnd;

			private string itemTitle;

			private string customizeFeatureC;

			private string customizeFeatureD;

			private string itemQrCode;

			private string customizeFeatureE;

			private string inventoryStatus;

			private string promotionReason;

			private string customizeFeatureF;

			private string customizeFeatureG;

			private string customizeFeatureH;

			private string customizeFeatureI;

			private string customizeFeatureJ;

			private string customizeFeatureA;

			private string customizeFeatureB;

			private int? suggestPrice;

			private string forestFirstId;

			private string productionPlace;

			private string manufacturer;

			private string sourceCode;

			private string itemId;

			private bool? beMember;

			private string templateSceneId;

			private int? salesPrice;

			private int? originalPrice;

			private string itemShortTitle;

			private string forestSecondId;

			private string itemPicUrl;

			private string supplierName;

			private string material;

			private string modelNumber;

			private string saleSpec;

			private string categoryName;

			private string taxFee;

			private string energyEfficiency;

			private string promotionText;

			private string skuId;

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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override BatchInsertItemsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BatchInsertItemsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
