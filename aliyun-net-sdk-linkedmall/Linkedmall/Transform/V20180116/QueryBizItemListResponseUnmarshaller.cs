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
    public class QueryBizItemListResponseUnmarshaller
    {
        public static QueryBizItemListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryBizItemListResponse queryBizItemListResponse = new QueryBizItemListResponse();

			queryBizItemListResponse.HttpResponse = context.HttpResponse;
			queryBizItemListResponse.Code = context.StringValue("QueryBizItemList.Code");
			queryBizItemListResponse.Message = context.StringValue("QueryBizItemList.Message");
			queryBizItemListResponse.TotalCount = context.IntegerValue("QueryBizItemList.TotalCount");
			queryBizItemListResponse.PageNumber = context.IntegerValue("QueryBizItemList.PageNumber");
			queryBizItemListResponse.PageSize = context.IntegerValue("QueryBizItemList.PageSize");
			queryBizItemListResponse.RequestId = context.StringValue("QueryBizItemList.RequestId");

			List<QueryBizItemListResponse.QueryBizItemList_Item> queryBizItemListResponse_itemList = new List<QueryBizItemListResponse.QueryBizItemList_Item>();
			for (int i = 0; i < context.Length("QueryBizItemList.ItemList.Length"); i++) {
				QueryBizItemListResponse.QueryBizItemList_Item item = new QueryBizItemListResponse.QueryBizItemList_Item();
				item.ItemId = context.LongValue("QueryBizItemList.ItemList["+ i +"].ItemId");
				item.ItemTitle = context.StringValue("QueryBizItemList.ItemList["+ i +"].ItemTitle");
				item.CustomizedItemName = context.StringValue("QueryBizItemList.ItemList["+ i +"].CustomizedItemName");
				item.MainPicUrl = context.StringValue("QueryBizItemList.ItemList["+ i +"].MainPicUrl");
				item.ReservePrice = context.LongValue("QueryBizItemList.ItemList["+ i +"].ReservePrice");
				item.CategoryId = context.LongValue("QueryBizItemList.ItemList["+ i +"].CategoryId");
				item.CanSell = context.BooleanValue("QueryBizItemList.ItemList["+ i +"].CanSell");
				item.TaobaoShopName = context.StringValue("QueryBizItemList.ItemList["+ i +"].TaobaoShopName");
				item.ExtJson = context.StringValue("QueryBizItemList.ItemList["+ i +"].ExtJson");
				item.SellerId = context.LongValue("QueryBizItemList.ItemList["+ i +"].SellerId");
				item.LmItemId = context.StringValue("QueryBizItemList.ItemList["+ i +"].LmItemId");

				List<QueryBizItemListResponse.QueryBizItemList_Item.QueryBizItemList_Sku> item_skuList = new List<QueryBizItemListResponse.QueryBizItemList_Item.QueryBizItemList_Sku>();
				for (int j = 0; j < context.Length("QueryBizItemList.ItemList["+ i +"].SkuList.Length"); j++) {
					QueryBizItemListResponse.QueryBizItemList_Item.QueryBizItemList_Sku sku = new QueryBizItemListResponse.QueryBizItemList_Item.QueryBizItemList_Sku();
					sku.SkuId = context.LongValue("QueryBizItemList.ItemList["+ i +"].SkuList["+ j +"].SkuId");
					sku.SkuPicUrl = context.StringValue("QueryBizItemList.ItemList["+ i +"].SkuList["+ j +"].SkuPicUrl");
					sku.SkuTitle = context.StringValue("QueryBizItemList.ItemList["+ i +"].SkuList["+ j +"].SkuTitle");
					sku.PriceCent = context.LongValue("QueryBizItemList.ItemList["+ i +"].SkuList["+ j +"].PriceCent");
					sku.Points = context.LongValue("QueryBizItemList.ItemList["+ i +"].SkuList["+ j +"].Points");
					sku.PointsAmount = context.LongValue("QueryBizItemList.ItemList["+ i +"].SkuList["+ j +"].PointsAmount");
					sku.BenefitId = context.StringValue("QueryBizItemList.ItemList["+ i +"].SkuList["+ j +"].BenefitId");
					sku.CanSell = context.BooleanValue("QueryBizItemList.ItemList["+ i +"].SkuList["+ j +"].CanSell");
					sku.CustomizedAttributeMap = context.StringValue("QueryBizItemList.ItemList["+ i +"].SkuList["+ j +"].CustomizedAttributeMap");

					item_skuList.Add(sku);
				}
				item.SkuList = item_skuList;

				queryBizItemListResponse_itemList.Add(item);
			}
			queryBizItemListResponse.ItemList = queryBizItemListResponse_itemList;
        
			return queryBizItemListResponse;
        }
    }
}
