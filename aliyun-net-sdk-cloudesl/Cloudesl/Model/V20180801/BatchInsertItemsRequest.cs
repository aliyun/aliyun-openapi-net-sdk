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
using Aliyun.Acs.cloudesl.Transform.V20180801;

namespace Aliyun.Acs.cloudesl.Model.V20180801
{
    public class BatchInsertItemsRequest : RpcAcsRequest<BatchInsertItemsResponse>
    {
        public BatchInsertItemsRequest()
            : base("cloudesl", "2018-08-01", "BatchInsertItems", "cloudesl", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string storeId;

		private List<ItemInfo> itemInfos = new List<ItemInfo>(){ };

		public string StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
				DictionaryUtil.Add(QueryParameters, "StoreId", value);
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
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ProductionPlace", itemInfos[i].ProductionPlace);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".BeSourceCode", itemInfos[i].BeSourceCode);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".StoreId", itemInfos[i].StoreId);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".BrandName", itemInfos[i].BrandName);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".PromotionStart", itemInfos[i].PromotionStart);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".SourceCode", itemInfos[i].SourceCode);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ItemId", itemInfos[i].ItemId);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ExtraAttribute", itemInfos[i].ExtraAttribute);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CompanyId", itemInfos[i].CompanyId);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".PriceUnit", itemInfos[i].PriceUnit);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".Rank", itemInfos[i].Rank);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ItemBarCode", itemInfos[i].ItemBarCode);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".BePromotion", itemInfos[i].BePromotion);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".PromotionEnd", itemInfos[i].PromotionEnd);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ItemTitle", itemInfos[i].ItemTitle);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".OriginalPrice", itemInfos[i].OriginalPrice);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ItemShortTitle", itemInfos[i].ItemShortTitle);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureC", itemInfos[i].CustomizeFeatureC);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ItemQrCode", itemInfos[i].ItemQrCode);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureD", itemInfos[i].CustomizeFeatureD);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".PromotionReason", itemInfos[i].PromotionReason);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureE", itemInfos[i].CustomizeFeatureE);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureF", itemInfos[i].CustomizeFeatureF);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ForestSecondId", itemInfos[i].ForestSecondId);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureG", itemInfos[i].CustomizeFeatureG);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureH", itemInfos[i].CustomizeFeatureH);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureI", itemInfos[i].CustomizeFeatureI);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureJ", itemInfos[i].CustomizeFeatureJ);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".OptionGroups", itemInfos[i].OptionGroups);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ModelNumber", itemInfos[i].ModelNumber);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".SaleSpec", itemInfos[i].SaleSpec);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureA", itemInfos[i].CustomizeFeatureA);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CustomizeFeatureB", itemInfos[i].CustomizeFeatureB);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".SuggestPrice", itemInfos[i].SuggestPrice);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".ForestFirstId", itemInfos[i].ForestFirstId);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".CategoryName", itemInfos[i].CategoryName);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".EnergyEfficiency", itemInfos[i].EnergyEfficiency);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".SkuId", itemInfos[i].SkuId);
					DictionaryUtil.Add(BodyParameters,"ItemInfo." + (i + 1) + ".PromotionText", itemInfos[i].PromotionText);
				}
			}
		}

		public class ItemInfo
		{

			private int? memberPrice;

			private int? actionPrice;

			private string productionPlace;

			private bool? beSourceCode;

			private string storeId;

			private string brandName;

			private string promotionStart;

			private string sourceCode;

			private long? itemId;

			private string extraAttribute;

			private string companyId;

			private string priceUnit;

			private string rank;

			private string itemBarCode;

			private bool? bePromotion;

			private string promotionEnd;

			private string itemTitle;

			private int? originalPrice;

			private string itemShortTitle;

			private string customizeFeatureC;

			private string itemQrCode;

			private string customizeFeatureD;

			private string promotionReason;

			private string customizeFeatureE;

			private string customizeFeatureF;

			private string forestSecondId;

			private string customizeFeatureG;

			private string customizeFeatureH;

			private string customizeFeatureI;

			private string customizeFeatureJ;

			private string optionGroups;

			private string modelNumber;

			private string saleSpec;

			private string customizeFeatureA;

			private string customizeFeatureB;

			private int? suggestPrice;

			private string forestFirstId;

			private string categoryName;

			private string energyEfficiency;

			private string skuId;

			private string promotionText;

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
		}

        public override BatchInsertItemsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BatchInsertItemsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
