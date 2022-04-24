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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class GetOrderDetailResponseUnmarshaller
    {
        public static GetOrderDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOrderDetailResponse getOrderDetailResponse = new GetOrderDetailResponse();

			getOrderDetailResponse.HttpResponse = _ctx.HttpResponse;
			getOrderDetailResponse.Code = _ctx.StringValue("GetOrderDetail.Code");
			getOrderDetailResponse.Message = _ctx.StringValue("GetOrderDetail.Message");
			getOrderDetailResponse.RequestId = _ctx.StringValue("GetOrderDetail.RequestId");
			getOrderDetailResponse.Success = _ctx.BooleanValue("GetOrderDetail.Success");

			GetOrderDetailResponse.GetOrderDetail_Data data = new GetOrderDetailResponse.GetOrderDetail_Data();
			data.HostName = _ctx.StringValue("GetOrderDetail.Data.HostName");
			data.PageNum = _ctx.IntegerValue("GetOrderDetail.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("GetOrderDetail.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("GetOrderDetail.Data.TotalCount");

			List<GetOrderDetailResponse.GetOrderDetail_Data.GetOrderDetail_Order> data_orderList = new List<GetOrderDetailResponse.GetOrderDetail_Data.GetOrderDetail_Order>();
			for (int i = 0; i < _ctx.Length("GetOrderDetail.Data.OrderList.Length"); i++) {
				GetOrderDetailResponse.GetOrderDetail_Data.GetOrderDetail_Order order = new GetOrderDetailResponse.GetOrderDetail_Data.GetOrderDetail_Order();
				order.OrderSubType = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].OrderSubType");
				order.CreateTime = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].CreateTime");
				order.Currency = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].Currency");
				order.Config = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].Config");
				order.SubscriptionType = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].SubscriptionType");
				order.UsageStartTime = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].UsageStartTime");
				order.UsageEndTime = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].UsageEndTime");
				order.SubOrderId = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].SubOrderId");
				order.Region = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].Region");
				order.AfterTaxAmount = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].AfterTaxAmount");
				order.PaymentTime = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].PaymentTime");
				order._Operator = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].Operator");
				order.OrderType = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].OrderType");
				order.PaymentStatus = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].PaymentStatus");
				order.Quantity = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].Quantity");
				order.PretaxAmountLocal = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].PretaxAmountLocal");
				order.Tax = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].Tax");
				order.OriginalConfig = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].OriginalConfig");
				order.PretaxAmount = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].PretaxAmount");
				order.CommodityCode = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].CommodityCode");
				order.RelatedOrderId = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].RelatedOrderId");
				order.PaymentCurrency = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].PaymentCurrency");
				order.ProductType = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].ProductType");
				order.InstanceIDs = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].InstanceIDs");
				order.PretaxGrossAmount = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].PretaxGrossAmount");
				order.OrderId = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].OrderId");
				order.ProductCode = _ctx.StringValue("GetOrderDetail.Data.OrderList["+ i +"].ProductCode");

				data_orderList.Add(order);
			}
			data.OrderList = data_orderList;
			getOrderDetailResponse.Data = data;
        
			return getOrderDetailResponse;
        }
    }
}
