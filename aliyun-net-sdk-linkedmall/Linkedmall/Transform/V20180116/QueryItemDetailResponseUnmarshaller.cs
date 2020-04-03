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
    public class QueryItemDetailResponseUnmarshaller
    {
        public static QueryItemDetailResponse Unmarshall(UnmarshallerContext context)
        {
			QueryItemDetailResponse queryItemDetailResponse = new QueryItemDetailResponse();

			queryItemDetailResponse.HttpResponse = context.HttpResponse;
			queryItemDetailResponse.RequestId = context.StringValue("QueryItemDetail.RequestId");
			queryItemDetailResponse.Code = context.StringValue("QueryItemDetail.Code");
			queryItemDetailResponse.Message = context.StringValue("QueryItemDetail.Message");
			queryItemDetailResponse.SubCode = context.StringValue("QueryItemDetail.SubCode");
			queryItemDetailResponse.SubMessage = context.StringValue("QueryItemDetail.SubMessage");
			queryItemDetailResponse.Success = context.BooleanValue("QueryItemDetail.Success");

			QueryItemDetailResponse.QueryItemDetail_Item item = new QueryItemDetailResponse.QueryItemDetail_Item();
			item.ItemId = context.LongValue("QueryItemDetail.Item.ItemId");
			item.ItemTitle = context.StringValue("QueryItemDetail.Item.ItemTitle");
			item.MainPicUrl = context.StringValue("QueryItemDetail.Item.MainPicUrl");
			item.DescPath = context.StringValue("QueryItemDetail.Item.DescPath");
			item.MinPrice = context.LongValue("QueryItemDetail.Item.MinPrice");
			item.MinPoints = context.LongValue("QueryItemDetail.Item.MinPoints");
			item.ReservePrice = context.LongValue("QueryItemDetail.Item.ReservePrice");
			item.Quantity = context.IntegerValue("QueryItemDetail.Item.Quantity");
			item.IsSellerPayPostfee = context.BooleanValue("QueryItemDetail.Item.IsSellerPayPostfee");
			item.IsCanSell = context.BooleanValue("QueryItemDetail.Item.IsCanSell");
			item.TotalSoldQuantity = context.IntegerValue("QueryItemDetail.Item.TotalSoldQuantity");
			item.Properties = context.StringValue("QueryItemDetail.Item.Properties");
			item.CanSell = context.BooleanValue("QueryItemDetail.Item.CanSell");
			item.SellerPayPostfee = context.BooleanValue("QueryItemDetail.Item.SellerPayPostfee");
			item.CategoryId = context.LongValue("QueryItemDetail.Item.CategoryId");
			item.ExtJson = context.StringValue("QueryItemDetail.Item.ExtJson");
			item.PropertiesJson = context.StringValue("QueryItemDetail.Item.PropertiesJson");
			item.IforestPropsJson = context.StringValue("QueryItemDetail.Item.IforestPropsJson");
			item.DescOption = context.StringValue("QueryItemDetail.Item.DescOption");
			item.IforestProps = context.StringValue("QueryItemDetail.Item.IforestProps");
			item.SellerId = context.LongValue("QueryItemDetail.Item.SellerId");
			item.TbShopName = context.StringValue("QueryItemDetail.Item.TbShopName");
			item.LmItemCategory = context.StringValue("QueryItemDetail.Item.LmItemCategory");
			item.CenterInventory = context.BooleanValue("QueryItemDetail.Item.CenterInventory");
			item.CustomizedAttributeMap = context.StringValue("QueryItemDetail.Item.CustomizedAttributeMap");
			item.LmItemId = context.StringValue("QueryItemDetail.Item.LmItemId");

			List<string> item_itemImages = new List<string>();
			for (int i = 0; i < context.Length("QueryItemDetail.Item.ItemImages.Length"); i++) {
				item_itemImages.Add(context.StringValue("QueryItemDetail.Item.ItemImages["+ i +"]"));
			}
			item.ItemImages = item_itemImages;

			List<QueryItemDetailResponse.QueryItemDetail_Item.QueryItemDetail_Sku> item_skus = new List<QueryItemDetailResponse.QueryItemDetail_Item.QueryItemDetail_Sku>();
			for (int i = 0; i < context.Length("QueryItemDetail.Item.Skus.Length"); i++) {
				QueryItemDetailResponse.QueryItemDetail_Item.QueryItemDetail_Sku sku = new QueryItemDetailResponse.QueryItemDetail_Item.QueryItemDetail_Sku();
				sku.ExtJson = context.StringValue("QueryItemDetail.Item.Skus["+ i +"].ExtJson");
				sku.ItemId = context.LongValue("QueryItemDetail.Item.Skus["+ i +"].ItemId");
				sku.SkuId = context.LongValue("QueryItemDetail.Item.Skus["+ i +"].SkuId");
				sku.SkuProperties = context.StringValue("QueryItemDetail.Item.Skus["+ i +"].SkuProperties");
				sku.SkuPicUrl = context.StringValue("QueryItemDetail.Item.Skus["+ i +"].SkuPicUrl");
				sku.SkuTitle = context.StringValue("QueryItemDetail.Item.Skus["+ i +"].SkuTitle");
				sku.Quantity = context.IntegerValue("QueryItemDetail.Item.Skus["+ i +"].Quantity");
				sku.PriceCent = context.LongValue("QueryItemDetail.Item.Skus["+ i +"].PriceCent");
				sku.Points = context.LongValue("QueryItemDetail.Item.Skus["+ i +"].Points");
				sku.PointsAmount = context.LongValue("QueryItemDetail.Item.Skus["+ i +"].PointsAmount");
				sku.PointPrice = context.LongValue("QueryItemDetail.Item.Skus["+ i +"].PointPrice");
				sku.SkuPropertiesJson = context.StringValue("QueryItemDetail.Item.Skus["+ i +"].SkuPropertiesJson");
				sku.ReservePrice = context.LongValue("QueryItemDetail.Item.Skus["+ i +"].ReservePrice");
				sku.CanSell = context.BooleanValue("QueryItemDetail.Item.Skus["+ i +"].CanSell");
				sku.CustomizedAttributeMap = context.StringValue("QueryItemDetail.Item.Skus["+ i +"].CustomizedAttributeMap");
				sku.LmItemId = context.StringValue("QueryItemDetail.Item.Skus["+ i +"].LmItemId");

				item_skus.Add(sku);
			}
			item.Skus = item_skus;
			queryItemDetailResponse.Item = item;
        
			return queryItemDetailResponse;
        }
    }
}
