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
    public class QueryOrderListResponseUnmarshaller
    {
        public static QueryOrderListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryOrderListResponse queryOrderListResponse = new QueryOrderListResponse();

			queryOrderListResponse.HttpResponse = context.HttpResponse;
			queryOrderListResponse.RequestId = context.StringValue("QueryOrderList.RequestId");
			queryOrderListResponse.Code = context.StringValue("QueryOrderList.Code");
			queryOrderListResponse.Message = context.StringValue("QueryOrderList.Message");
			queryOrderListResponse.TotalCount = context.LongValue("QueryOrderList.TotalCount");
			queryOrderListResponse.PageSize = context.IntegerValue("QueryOrderList.PageSize");
			queryOrderListResponse.PageNumber = context.IntegerValue("QueryOrderList.PageNumber");

			QueryOrderListResponse.QueryOrderList_PostFee postFee = new QueryOrderListResponse.QueryOrderList_PostFee();
			postFee.FundAmount = context.LongValue("QueryOrderList.PostFee.FundAmount");
			postFee.FundAmountMoney = context.LongValue("QueryOrderList.PostFee.FundAmountMoney");
			postFee.FundType = context.StringValue("QueryOrderList.PostFee.FundType");
			queryOrderListResponse.PostFee = postFee;

			List<QueryOrderListResponse.QueryOrderList_LmOrderListItem> queryOrderListResponse_lmOrderList = new List<QueryOrderListResponse.QueryOrderList_LmOrderListItem>();
			for (int i = 0; i < context.Length("QueryOrderList.LmOrderList.Length"); i++) {
				QueryOrderListResponse.QueryOrderList_LmOrderListItem lmOrderListItem = new QueryOrderListResponse.QueryOrderList_LmOrderListItem();
				lmOrderListItem.CreateDate = context.StringValue("QueryOrderList.LmOrderList["+ i +"].CreateDate");
				lmOrderListItem.LmOrderId = context.LongValue("QueryOrderList.LmOrderList["+ i +"].LmOrderId");
				lmOrderListItem.OrderAmount = context.LongValue("QueryOrderList.LmOrderList["+ i +"].OrderAmount");
				lmOrderListItem.OrderStatus = context.IntegerValue("QueryOrderList.LmOrderList["+ i +"].OrderStatus");
				lmOrderListItem.ExtJson = context.StringValue("QueryOrderList.LmOrderList["+ i +"].ExtJson");
				lmOrderListItem.ShopName = context.StringValue("QueryOrderList.LmOrderList["+ i +"].ShopName");
				lmOrderListItem.LogisticsStatus = context.IntegerValue("QueryOrderList.LmOrderList["+ i +"].LogisticsStatus");
				lmOrderListItem.EnableStatus = context.IntegerValue("QueryOrderList.LmOrderList["+ i +"].EnableStatus");
				lmOrderListItem.TbOrderId = context.LongValue("QueryOrderList.LmOrderList["+ i +"].TbOrderId");

				QueryOrderListResponse.QueryOrderList_LmOrderListItem.QueryOrderList_PostFee1 postFee1 = new QueryOrderListResponse.QueryOrderList_LmOrderListItem.QueryOrderList_PostFee1();
				postFee1.FundAmount = context.LongValue("QueryOrderList.LmOrderList["+ i +"].PostFee.FundAmount");
				postFee1.FundAmountMoney = context.LongValue("QueryOrderList.LmOrderList["+ i +"].PostFee.FundAmountMoney");
				postFee1.FundType = context.StringValue("QueryOrderList.LmOrderList["+ i +"].PostFee.FundType");
				lmOrderListItem.PostFee1 = postFee1;

				List<QueryOrderListResponse.QueryOrderList_LmOrderListItem.QueryOrderList_FundStructureModelsItem> lmOrderListItem_fundStructureModels = new List<QueryOrderListResponse.QueryOrderList_LmOrderListItem.QueryOrderList_FundStructureModelsItem>();
				for (int j = 0; j < context.Length("QueryOrderList.LmOrderList["+ i +"].FundStructureModels.Length"); j++) {
					QueryOrderListResponse.QueryOrderList_LmOrderListItem.QueryOrderList_FundStructureModelsItem fundStructureModelsItem = new QueryOrderListResponse.QueryOrderList_LmOrderListItem.QueryOrderList_FundStructureModelsItem();
					fundStructureModelsItem.FundAmount = context.LongValue("QueryOrderList.LmOrderList["+ i +"].FundStructureModels["+ j +"].FundAmount");
					fundStructureModelsItem.FundAmountMoney = context.LongValue("QueryOrderList.LmOrderList["+ i +"].FundStructureModels["+ j +"].FundAmountMoney");
					fundStructureModelsItem.FundType = context.StringValue("QueryOrderList.LmOrderList["+ i +"].FundStructureModels["+ j +"].FundType");

					lmOrderListItem_fundStructureModels.Add(fundStructureModelsItem);
				}
				lmOrderListItem.FundStructureModels = lmOrderListItem_fundStructureModels;

				List<QueryOrderListResponse.QueryOrderList_LmOrderListItem.QueryOrderList_SubOrderListItem> lmOrderListItem_subOrderList = new List<QueryOrderListResponse.QueryOrderList_LmOrderListItem.QueryOrderList_SubOrderListItem>();
				for (int j = 0; j < context.Length("QueryOrderList.LmOrderList["+ i +"].SubOrderList.Length"); j++) {
					QueryOrderListResponse.QueryOrderList_LmOrderListItem.QueryOrderList_SubOrderListItem subOrderListItem = new QueryOrderListResponse.QueryOrderList_LmOrderListItem.QueryOrderList_SubOrderListItem();
					subOrderListItem.ItemId = context.LongValue("QueryOrderList.LmOrderList["+ i +"].SubOrderList["+ j +"].ItemId");
					subOrderListItem.ItemPic = context.StringValue("QueryOrderList.LmOrderList["+ i +"].SubOrderList["+ j +"].ItemPic");
					subOrderListItem.ItemTitle = context.StringValue("QueryOrderList.LmOrderList["+ i +"].SubOrderList["+ j +"].ItemTitle");
					subOrderListItem.Number = context.LongValue("QueryOrderList.LmOrderList["+ i +"].SubOrderList["+ j +"].Number");
					subOrderListItem.SkuId = context.LongValue("QueryOrderList.LmOrderList["+ i +"].SubOrderList["+ j +"].SkuId");
					subOrderListItem.SkuName = context.StringValue("QueryOrderList.LmOrderList["+ i +"].SubOrderList["+ j +"].SkuName");
					subOrderListItem.LmOrderId = context.LongValue("QueryOrderList.LmOrderList["+ i +"].SubOrderList["+ j +"].LmOrderId");
					subOrderListItem.OrderStatus = context.IntegerValue("QueryOrderList.LmOrderList["+ i +"].SubOrderList["+ j +"].OrderStatus");
					subOrderListItem.EnableStatus = context.IntegerValue("QueryOrderList.LmOrderList["+ i +"].SubOrderList["+ j +"].EnableStatus");
					subOrderListItem.TbOrderId = context.LongValue("QueryOrderList.LmOrderList["+ i +"].SubOrderList["+ j +"].TbOrderId");
					subOrderListItem.LmItemId = context.StringValue("QueryOrderList.LmOrderList["+ i +"].SubOrderList["+ j +"].LmItemId");

					List<QueryOrderListResponse.QueryOrderList_LmOrderListItem.QueryOrderList_SubOrderListItem.QueryOrderList_ItemPriceListItem> subOrderListItem_itemPriceList = new List<QueryOrderListResponse.QueryOrderList_LmOrderListItem.QueryOrderList_SubOrderListItem.QueryOrderList_ItemPriceListItem>();
					for (int k = 0; k < context.Length("QueryOrderList.LmOrderList["+ i +"].SubOrderList["+ j +"].ItemPriceList.Length"); k++) {
						QueryOrderListResponse.QueryOrderList_LmOrderListItem.QueryOrderList_SubOrderListItem.QueryOrderList_ItemPriceListItem itemPriceListItem = new QueryOrderListResponse.QueryOrderList_LmOrderListItem.QueryOrderList_SubOrderListItem.QueryOrderList_ItemPriceListItem();
						itemPriceListItem.FundAmount = context.LongValue("QueryOrderList.LmOrderList["+ i +"].SubOrderList["+ j +"].ItemPriceList["+ k +"].FundAmount");
						itemPriceListItem.FundAmountMoney = context.LongValue("QueryOrderList.LmOrderList["+ i +"].SubOrderList["+ j +"].ItemPriceList["+ k +"].FundAmountMoney");
						itemPriceListItem.FundType = context.StringValue("QueryOrderList.LmOrderList["+ i +"].SubOrderList["+ j +"].ItemPriceList["+ k +"].FundType");

						subOrderListItem_itemPriceList.Add(itemPriceListItem);
					}
					subOrderListItem.ItemPriceList = subOrderListItem_itemPriceList;

					lmOrderListItem_subOrderList.Add(subOrderListItem);
				}
				lmOrderListItem.SubOrderList = lmOrderListItem_subOrderList;

				queryOrderListResponse_lmOrderList.Add(lmOrderListItem);
			}
			queryOrderListResponse.LmOrderList = queryOrderListResponse_lmOrderList;
        
			return queryOrderListResponse;
        }
    }
}
