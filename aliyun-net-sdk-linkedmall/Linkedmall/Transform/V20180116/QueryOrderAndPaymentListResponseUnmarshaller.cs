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
    public class QueryOrderAndPaymentListResponseUnmarshaller
    {
        public static QueryOrderAndPaymentListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryOrderAndPaymentListResponse queryOrderAndPaymentListResponse = new QueryOrderAndPaymentListResponse();

			queryOrderAndPaymentListResponse.HttpResponse = context.HttpResponse;
			queryOrderAndPaymentListResponse.RequestId = context.StringValue("QueryOrderAndPaymentList.RequestId");
			queryOrderAndPaymentListResponse.Code = context.StringValue("QueryOrderAndPaymentList.Code");
			queryOrderAndPaymentListResponse.Message = context.StringValue("QueryOrderAndPaymentList.Message");
			queryOrderAndPaymentListResponse.TotalCount = context.LongValue("QueryOrderAndPaymentList.TotalCount");
			queryOrderAndPaymentListResponse.PageSize = context.IntegerValue("QueryOrderAndPaymentList.PageSize");
			queryOrderAndPaymentListResponse.PageNumber = context.IntegerValue("QueryOrderAndPaymentList.PageNumber");

			QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_PostFee postFee = new QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_PostFee();
			postFee.FundAmount = context.LongValue("QueryOrderAndPaymentList.PostFee.FundAmount");
			postFee.FundAmountMoney = context.LongValue("QueryOrderAndPaymentList.PostFee.FundAmountMoney");
			postFee.FundType = context.StringValue("QueryOrderAndPaymentList.PostFee.FundType");
			queryOrderAndPaymentListResponse.PostFee = postFee;

			List<QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem> queryOrderAndPaymentListResponse_lmOrderList = new List<QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem>();
			for (int i = 0; i < context.Length("QueryOrderAndPaymentList.LmOrderList.Length"); i++) {
				QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem lmOrderListItem = new QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem();
				lmOrderListItem.CreateDate = context.StringValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].CreateDate");
				lmOrderListItem.LmOrderId = context.LongValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].LmOrderId");
				lmOrderListItem.OrderAmount = context.LongValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].OrderAmount");
				lmOrderListItem.OrderStatus = context.IntegerValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].OrderStatus");
				lmOrderListItem.ExtJson = context.StringValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].ExtJson");
				lmOrderListItem.ShopName = context.StringValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].ShopName");
				lmOrderListItem.LogisticsStatus = context.IntegerValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].LogisticsStatus");
				lmOrderListItem.EnableStatus = context.IntegerValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].EnableStatus");
				lmOrderListItem.TbOrderId = context.LongValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].TbOrderId");
				lmOrderListItem.LmPaymentId = context.StringValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].LmPaymentId");

				QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem.QueryOrderAndPaymentList_PostFee1 postFee1 = new QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem.QueryOrderAndPaymentList_PostFee1();
				postFee1.FundAmount = context.LongValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].PostFee.FundAmount");
				postFee1.FundAmountMoney = context.LongValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].PostFee.FundAmountMoney");
				postFee1.FundType = context.StringValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].PostFee.FundType");
				lmOrderListItem.PostFee1 = postFee1;

				List<QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem.QueryOrderAndPaymentList_FundStructureModelsItem> lmOrderListItem_fundStructureModels = new List<QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem.QueryOrderAndPaymentList_FundStructureModelsItem>();
				for (int j = 0; j < context.Length("QueryOrderAndPaymentList.LmOrderList["+ i +"].FundStructureModels.Length"); j++) {
					QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem.QueryOrderAndPaymentList_FundStructureModelsItem fundStructureModelsItem = new QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem.QueryOrderAndPaymentList_FundStructureModelsItem();
					fundStructureModelsItem.FundAmount = context.LongValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].FundStructureModels["+ j +"].FundAmount");
					fundStructureModelsItem.FundAmountMoney = context.LongValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].FundStructureModels["+ j +"].FundAmountMoney");
					fundStructureModelsItem.FundType = context.StringValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].FundStructureModels["+ j +"].FundType");

					lmOrderListItem_fundStructureModels.Add(fundStructureModelsItem);
				}
				lmOrderListItem.FundStructureModels = lmOrderListItem_fundStructureModels;

				List<QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem.QueryOrderAndPaymentList_SubOrderListItem> lmOrderListItem_subOrderList = new List<QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem.QueryOrderAndPaymentList_SubOrderListItem>();
				for (int j = 0; j < context.Length("QueryOrderAndPaymentList.LmOrderList["+ i +"].SubOrderList.Length"); j++) {
					QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem.QueryOrderAndPaymentList_SubOrderListItem subOrderListItem = new QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem.QueryOrderAndPaymentList_SubOrderListItem();
					subOrderListItem.ItemId = context.LongValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].SubOrderList["+ j +"].ItemId");
					subOrderListItem.ItemPic = context.StringValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].SubOrderList["+ j +"].ItemPic");
					subOrderListItem.ItemTitle = context.StringValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].SubOrderList["+ j +"].ItemTitle");
					subOrderListItem.Number = context.LongValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].SubOrderList["+ j +"].Number");
					subOrderListItem.SkuId = context.LongValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].SubOrderList["+ j +"].SkuId");
					subOrderListItem.SkuName = context.StringValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].SubOrderList["+ j +"].SkuName");
					subOrderListItem.LmOrderId = context.LongValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].SubOrderList["+ j +"].LmOrderId");
					subOrderListItem.OrderStatus = context.IntegerValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].SubOrderList["+ j +"].OrderStatus");
					subOrderListItem.EnableStatus = context.IntegerValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].SubOrderList["+ j +"].EnableStatus");
					subOrderListItem.TbOrderId = context.LongValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].SubOrderList["+ j +"].TbOrderId");
					subOrderListItem.LmItemId = context.StringValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].SubOrderList["+ j +"].LmItemId");

					List<QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem.QueryOrderAndPaymentList_SubOrderListItem.QueryOrderAndPaymentList_ItemPriceListItem> subOrderListItem_itemPriceList = new List<QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem.QueryOrderAndPaymentList_SubOrderListItem.QueryOrderAndPaymentList_ItemPriceListItem>();
					for (int k = 0; k < context.Length("QueryOrderAndPaymentList.LmOrderList["+ i +"].SubOrderList["+ j +"].ItemPriceList.Length"); k++) {
						QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem.QueryOrderAndPaymentList_SubOrderListItem.QueryOrderAndPaymentList_ItemPriceListItem itemPriceListItem = new QueryOrderAndPaymentListResponse.QueryOrderAndPaymentList_LmOrderListItem.QueryOrderAndPaymentList_SubOrderListItem.QueryOrderAndPaymentList_ItemPriceListItem();
						itemPriceListItem.FundAmount = context.LongValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].SubOrderList["+ j +"].ItemPriceList["+ k +"].FundAmount");
						itemPriceListItem.FundAmountMoney = context.LongValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].SubOrderList["+ j +"].ItemPriceList["+ k +"].FundAmountMoney");
						itemPriceListItem.FundType = context.StringValue("QueryOrderAndPaymentList.LmOrderList["+ i +"].SubOrderList["+ j +"].ItemPriceList["+ k +"].FundType");

						subOrderListItem_itemPriceList.Add(itemPriceListItem);
					}
					subOrderListItem.ItemPriceList = subOrderListItem_itemPriceList;

					lmOrderListItem_subOrderList.Add(subOrderListItem);
				}
				lmOrderListItem.SubOrderList = lmOrderListItem_subOrderList;

				queryOrderAndPaymentListResponse_lmOrderList.Add(lmOrderListItem);
			}
			queryOrderAndPaymentListResponse.LmOrderList = queryOrderAndPaymentListResponse_lmOrderList;
        
			return queryOrderAndPaymentListResponse;
        }
    }
}
