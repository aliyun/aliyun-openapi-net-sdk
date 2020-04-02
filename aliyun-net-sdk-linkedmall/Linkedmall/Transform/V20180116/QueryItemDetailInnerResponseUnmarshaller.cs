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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class QueryItemDetailInnerResponseUnmarshaller
    {
        public static QueryItemDetailInnerResponse Unmarshall(UnmarshallerContext context)
        {
			QueryItemDetailInnerResponse queryItemDetailInnerResponse = new QueryItemDetailInnerResponse();

			queryItemDetailInnerResponse.HttpResponse = context.HttpResponse;
			queryItemDetailInnerResponse.RequestId = context.StringValue("QueryItemDetailInner.RequestId");
			queryItemDetailInnerResponse.Code = context.StringValue("QueryItemDetailInner.Code");
			queryItemDetailInnerResponse.Message = context.StringValue("QueryItemDetailInner.Message");

			QueryItemDetailInnerResponse.QueryItemDetailInner_Item item = new QueryItemDetailInnerResponse.QueryItemDetailInner_Item();
			item.ItemId = context.LongValue("QueryItemDetailInner.Item.ItemId");
			item.ItemTitle = context.StringValue("QueryItemDetailInner.Item.ItemTitle");
			item.MainPicUrl = context.StringValue("QueryItemDetailInner.Item.MainPicUrl");
			item.DescPath = context.StringValue("QueryItemDetailInner.Item.DescPath");
			item.MinPrice = context.LongValue("QueryItemDetailInner.Item.MinPrice");
			item.MinPoints = context.LongValue("QueryItemDetailInner.Item.MinPoints");
			item.ReservePrice = context.LongValue("QueryItemDetailInner.Item.ReservePrice");
			item.Quantity = context.IntegerValue("QueryItemDetailInner.Item.Quantity");
			item.IsSellerPayPostfee = context.BooleanValue("QueryItemDetailInner.Item.IsSellerPayPostfee");
			item.IsCanSell = context.BooleanValue("QueryItemDetailInner.Item.IsCanSell");
			item.TotalSoldQuantity = context.IntegerValue("QueryItemDetailInner.Item.TotalSoldQuantity");
			item.Properties = context.StringValue("QueryItemDetailInner.Item.Properties");
			item.CanSell = context.BooleanValue("QueryItemDetailInner.Item.CanSell");
			item.SellerPayPostfee = context.BooleanValue("QueryItemDetailInner.Item.SellerPayPostfee");
			item.CategoryId = context.LongValue("QueryItemDetailInner.Item.CategoryId");
			item.SellerId = context.LongValue("QueryItemDetailInner.Item.SellerId");
			item.TbShopName = context.StringValue("QueryItemDetailInner.Item.TbShopName");
			item.LmItemCategory = context.StringValue("QueryItemDetailInner.Item.LmItemCategory");
			item.CenterInventory = context.BooleanValue("QueryItemDetailInner.Item.CenterInventory");
			item.Province = context.StringValue("QueryItemDetailInner.Item.Province");
			item.City = context.StringValue("QueryItemDetailInner.Item.City");
			item.DescOption = context.StringValue("QueryItemDetailInner.Item.DescOption");
			item.SellerNick = context.StringValue("QueryItemDetailInner.Item.SellerNick");
			item.LmShopId = context.LongValue("QueryItemDetailInner.Item.LmShopId");

			List<Dictionary<string, string>> item_iforestProps = new List<Dictionary<string, string>>();
			for (int i = 0; i < context.Length("QueryItemDetailInner.Item.IforestProps.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in context.ResponseDictionary){
					string prefix = "QueryItemDetailInner.Item.IforestProps["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					item_iforestProps.Add(tmp);
				}
			}
			item.IforestProps = item_iforestProps;

			List<string> item_itemImages = new List<string>();
			for (int i = 0; i < context.Length("QueryItemDetailInner.Item.ItemImages.Length"); i++) {
				item_itemImages.Add(context.StringValue("QueryItemDetailInner.Item.ItemImages["+ i +"]"));
			}
			item.ItemImages = item_itemImages;

			List<string> item_categoryIds = new List<string>();
			for (int i = 0; i < context.Length("QueryItemDetailInner.Item.CategoryIds.Length"); i++) {
				item_categoryIds.Add(context.StringValue("QueryItemDetailInner.Item.CategoryIds["+ i +"]"));
			}
			item.CategoryIds = item_categoryIds;

			List<QueryItemDetailInnerResponse.QueryItemDetailInner_Item.QueryItemDetailInner_Sku> item_skus = new List<QueryItemDetailInnerResponse.QueryItemDetailInner_Item.QueryItemDetailInner_Sku>();
			for (int i = 0; i < context.Length("QueryItemDetailInner.Item.Skus.Length"); i++) {
				QueryItemDetailInnerResponse.QueryItemDetailInner_Item.QueryItemDetailInner_Sku sku = new QueryItemDetailInnerResponse.QueryItemDetailInner_Item.QueryItemDetailInner_Sku();
				sku.ExtJson = context.StringValue("QueryItemDetailInner.Item.Skus["+ i +"].ExtJson");
				sku.ItemId = context.LongValue("QueryItemDetailInner.Item.Skus["+ i +"].ItemId");
				sku.SkuId = context.LongValue("QueryItemDetailInner.Item.Skus["+ i +"].SkuId");
				sku.SkuPvs = context.StringValue("QueryItemDetailInner.Item.Skus["+ i +"].SkuPvs");
				sku.SkuPicUrl = context.StringValue("QueryItemDetailInner.Item.Skus["+ i +"].SkuPicUrl");
				sku.SkuTitle = context.StringValue("QueryItemDetailInner.Item.Skus["+ i +"].SkuTitle");
				sku.Quantity = context.IntegerValue("QueryItemDetailInner.Item.Skus["+ i +"].Quantity");
				sku.PriceCent = context.LongValue("QueryItemDetailInner.Item.Skus["+ i +"].PriceCent");
				sku.Points = context.LongValue("QueryItemDetailInner.Item.Skus["+ i +"].Points");
				sku.PointsAmount = context.LongValue("QueryItemDetailInner.Item.Skus["+ i +"].PointsAmount");
				sku.PointPrice = context.LongValue("QueryItemDetailInner.Item.Skus["+ i +"].PointPrice");
				sku.ReservePrice = context.LongValue("QueryItemDetailInner.Item.Skus["+ i +"].ReservePrice");
				sku.Status = context.IntegerValue("QueryItemDetailInner.Item.Skus["+ i +"].Status");
				sku.LmItemId = context.StringValue("QueryItemDetailInner.Item.Skus["+ i +"].LmItemId");
				sku.SkuDesc = context.StringValue("QueryItemDetailInner.Item.Skus["+ i +"].SkuDesc");

				item_skus.Add(sku);
			}
			item.Skus = item_skus;

			List<QueryItemDetailInnerResponse.QueryItemDetailInner_Item.QueryItemDetailInner_SkuProperty> item_skuPropertys = new List<QueryItemDetailInnerResponse.QueryItemDetailInner_Item.QueryItemDetailInner_SkuProperty>();
			for (int i = 0; i < context.Length("QueryItemDetailInner.Item.SkuPropertys.Length"); i++) {
				QueryItemDetailInnerResponse.QueryItemDetailInner_Item.QueryItemDetailInner_SkuProperty skuProperty = new QueryItemDetailInnerResponse.QueryItemDetailInner_Item.QueryItemDetailInner_SkuProperty();
				skuProperty.Id = context.LongValue("QueryItemDetailInner.Item.SkuPropertys["+ i +"].Id");
				skuProperty.Text = context.StringValue("QueryItemDetailInner.Item.SkuPropertys["+ i +"].Text");

				List<QueryItemDetailInnerResponse.QueryItemDetailInner_Item.QueryItemDetailInner_SkuProperty.QueryItemDetailInner__Value> skuProperty_values = new List<QueryItemDetailInnerResponse.QueryItemDetailInner_Item.QueryItemDetailInner_SkuProperty.QueryItemDetailInner__Value>();
				for (int j = 0; j < context.Length("QueryItemDetailInner.Item.SkuPropertys["+ i +"].Values.Length"); j++) {
					QueryItemDetailInnerResponse.QueryItemDetailInner_Item.QueryItemDetailInner_SkuProperty.QueryItemDetailInner__Value _value = new QueryItemDetailInnerResponse.QueryItemDetailInner_Item.QueryItemDetailInner_SkuProperty.QueryItemDetailInner__Value();
					_value.Id = context.LongValue("QueryItemDetailInner.Item.SkuPropertys["+ i +"].Values["+ j +"].Id");
					_value.Text = context.StringValue("QueryItemDetailInner.Item.SkuPropertys["+ i +"].Values["+ j +"].Text");

					skuProperty_values.Add(_value);
				}
				skuProperty.Values = skuProperty_values;

				item_skuPropertys.Add(skuProperty);
			}
			item.SkuPropertys = item_skuPropertys;
			queryItemDetailInnerResponse.Item = item;
        
			return queryItemDetailInnerResponse;
        }
    }
}
