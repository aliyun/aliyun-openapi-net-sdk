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
    public class QueryOrderDetailInnerResponseUnmarshaller
    {
        public static QueryOrderDetailInnerResponse Unmarshall(UnmarshallerContext context)
        {
			QueryOrderDetailInnerResponse queryOrderDetailInnerResponse = new QueryOrderDetailInnerResponse();

			queryOrderDetailInnerResponse.HttpResponse = context.HttpResponse;
			queryOrderDetailInnerResponse.Code = context.StringValue("QueryOrderDetailInner.Code");
			queryOrderDetailInnerResponse.Message = context.StringValue("QueryOrderDetailInner.Message");
			queryOrderDetailInnerResponse.RequestId = context.StringValue("QueryOrderDetailInner.RequestId");

			QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model model = new QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model();

			QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model.QueryOrderDetailInner_Order order = new QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model.QueryOrderDetailInner_Order();
			order.LmOrderId = context.LongValue("QueryOrderDetailInner.Model.Order.LmOrderId");
			order.ChannelCode = context.StringValue("QueryOrderDetailInner.Model.Order.ChannelCode");
			order.ChannelOrderId = context.StringValue("QueryOrderDetailInner.Model.Order.ChannelOrderId");
			order.ChannelBizType = context.StringValue("QueryOrderDetailInner.Model.Order.ChannelBizType");
			order.OrderPayInfo = context.StringValue("QueryOrderDetailInner.Model.Order.OrderPayInfo");
			order.SellerId = context.LongValue("QueryOrderDetailInner.Model.Order.SellerId");
			order.SellerNick = context.StringValue("QueryOrderDetailInner.Model.Order.SellerNick");
			order.ShopName = context.StringValue("QueryOrderDetailInner.Model.Order.ShopName");
			order.CreateDate = context.StringValue("QueryOrderDetailInner.Model.Order.CreateDate");
			order.PayStatus = context.IntegerValue("QueryOrderDetailInner.Model.Order.PayStatus");
			order.PayWaterStatus = context.IntegerValue("QueryOrderDetailInner.Model.Order.PayWaterStatus");
			order.RefundStatus = context.IntegerValue("QueryOrderDetailInner.Model.Order.RefundStatus");
			order.LogisticsStatus = context.IntegerValue("QueryOrderDetailInner.Model.Order.LogisticsStatus");
			order.LogisticsStatusDesc = context.StringValue("QueryOrderDetailInner.Model.Order.LogisticsStatusDesc");
			order.LogisticsAddress = context.StringValue("QueryOrderDetailInner.Model.Order.LogisticsAddress");
			order.LogisticsUserName = context.StringValue("QueryOrderDetailInner.Model.Order.LogisticsUserName");
			order.LogisticsMobilePhone = context.StringValue("QueryOrderDetailInner.Model.Order.LogisticsMobilePhone");
			order.LogisticsNo = context.StringValue("QueryOrderDetailInner.Model.Order.LogisticsNo");
			order.OrderAmount = context.LongValue("QueryOrderDetailInner.Model.Order.OrderAmount");
			order.LogisticsCompName = context.StringValue("QueryOrderDetailInner.Model.Order.LogisticsCompName");
			order.ResExtInfo = context.StringValue("QueryOrderDetailInner.Model.Order.ResExtInfo");
			order.EndTime = context.LongValue("QueryOrderDetailInner.Model.Order.EndTime");
			order.Shipping = context.StringValue("QueryOrderDetailInner.Model.Order.Shipping");
			order.Eticket = context.BooleanValue("QueryOrderDetailInner.Model.Order.Eticket");
			order.EnableStatus = context.IntegerValue("QueryOrderDetailInner.Model.Order.EnableStatus");
			order.TbOrderId = context.StringValue("QueryOrderDetailInner.Model.Order.TbOrderId");
			order.ExtInfo = context.StringValue("QueryOrderDetailInner.Model.Order.ExtInfo");

			QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model.QueryOrderDetailInner_Order.QueryOrderDetailInner_PostFee postFee = new QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model.QueryOrderDetailInner_Order.QueryOrderDetailInner_PostFee();
			postFee.LmOrderId = context.LongValue("QueryOrderDetailInner.Model.Order.PostFee.LmOrderId");
			postFee.TbSubOrderId = context.LongValue("QueryOrderDetailInner.Model.Order.PostFee.TbSubOrderId");
			postFee.FundType = context.StringValue("QueryOrderDetailInner.Model.Order.PostFee.FundType");
			postFee.FundAmount = context.LongValue("QueryOrderDetailInner.Model.Order.PostFee.FundAmount");
			postFee.FundAmountMoney = context.LongValue("QueryOrderDetailInner.Model.Order.PostFee.FundAmountMoney");
			order.PostFee = postFee;

			List<QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model.QueryOrderDetailInner_Order.QueryOrderDetailInner_SubItemOrder> order_subItemOrderList = new List<QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model.QueryOrderDetailInner_Order.QueryOrderDetailInner_SubItemOrder>();
			for (int i = 0; i < context.Length("QueryOrderDetailInner.Model.Order.SubItemOrderList.Length"); i++) {
				QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model.QueryOrderDetailInner_Order.QueryOrderDetailInner_SubItemOrder subItemOrder = new QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model.QueryOrderDetailInner_Order.QueryOrderDetailInner_SubItemOrder();
				subItemOrder.PayStatus = context.IntegerValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].PayStatus");
				subItemOrder.ItemTitle = context.StringValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].ItemTitle");
				subItemOrder.LmItemId = context.StringValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].LmItemId");
				subItemOrder.ItemId = context.LongValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].ItemId");
				subItemOrder.ItemPic = context.StringValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].ItemPic");
				subItemOrder.ItemPriceInfo = context.StringValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].ItemPriceInfo");
				subItemOrder.Number = context.IntegerValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].Number");
				subItemOrder.TbSubOrderId = context.LongValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].TbSubOrderId");
				subItemOrder.LmOrderId = context.LongValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].LmOrderId");
				subItemOrder.SkuName = context.StringValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].SkuName");
				subItemOrder.SkuId = context.LongValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].SkuId");
				subItemOrder.TotalPaymentInfo = context.StringValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].TotalPaymentInfo");
				subItemOrder.ChannelCode = context.StringValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].ChannelCode");

				List<QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model.QueryOrderDetailInner_Order.QueryOrderDetailInner_SubItemOrder.QueryOrderDetailInner_ItemPrice> subItemOrder_itemPriceList = new List<QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model.QueryOrderDetailInner_Order.QueryOrderDetailInner_SubItemOrder.QueryOrderDetailInner_ItemPrice>();
				for (int j = 0; j < context.Length("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].ItemPriceList.Length"); j++) {
					QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model.QueryOrderDetailInner_Order.QueryOrderDetailInner_SubItemOrder.QueryOrderDetailInner_ItemPrice itemPrice = new QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model.QueryOrderDetailInner_Order.QueryOrderDetailInner_SubItemOrder.QueryOrderDetailInner_ItemPrice();
					itemPrice.TbOrderId = context.LongValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].ItemPriceList["+ j +"].TbOrderId");
					itemPrice.TbSubOrderId = context.LongValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].ItemPriceList["+ j +"].TbSubOrderId");
					itemPrice.FundType = context.StringValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].ItemPriceList["+ j +"].FundType");
					itemPrice.FundAmount = context.LongValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].ItemPriceList["+ j +"].FundAmount");
					itemPrice.FundAmountMoney = context.LongValue("QueryOrderDetailInner.Model.Order.SubItemOrderList["+ i +"].ItemPriceList["+ j +"].FundAmountMoney");

					subItemOrder_itemPriceList.Add(itemPrice);
				}
				subItemOrder.ItemPriceList = subItemOrder_itemPriceList;

				order_subItemOrderList.Add(subItemOrder);
			}
			order.SubItemOrderList = order_subItemOrderList;

			List<QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model.QueryOrderDetailInner_Order.QueryOrderDetailInner_FundStructure> order_fundStructureModels = new List<QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model.QueryOrderDetailInner_Order.QueryOrderDetailInner_FundStructure>();
			for (int i = 0; i < context.Length("QueryOrderDetailInner.Model.Order.FundStructureModels.Length"); i++) {
				QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model.QueryOrderDetailInner_Order.QueryOrderDetailInner_FundStructure fundStructure = new QueryOrderDetailInnerResponse.QueryOrderDetailInner_Model.QueryOrderDetailInner_Order.QueryOrderDetailInner_FundStructure();
				fundStructure.LmOrderId = context.LongValue("QueryOrderDetailInner.Model.Order.FundStructureModels["+ i +"].LmOrderId");
				fundStructure.TbSubOrderId = context.LongValue("QueryOrderDetailInner.Model.Order.FundStructureModels["+ i +"].TbSubOrderId");
				fundStructure.FundType = context.StringValue("QueryOrderDetailInner.Model.Order.FundStructureModels["+ i +"].FundType");
				fundStructure.FundAmount = context.LongValue("QueryOrderDetailInner.Model.Order.FundStructureModels["+ i +"].FundAmount");
				fundStructure.FundAmountMoney = context.LongValue("QueryOrderDetailInner.Model.Order.FundStructureModels["+ i +"].FundAmountMoney");

				order_fundStructureModels.Add(fundStructure);
			}
			order.FundStructureModels = order_fundStructureModels;
			model.Order = order;
			queryOrderDetailInnerResponse.Model = model;
        
			return queryOrderDetailInnerResponse;
        }
    }
}
