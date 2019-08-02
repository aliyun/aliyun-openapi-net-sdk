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
        public static GetOrderDetailResponse Unmarshall(UnmarshallerContext context)
        {
			GetOrderDetailResponse getOrderDetailResponse = new GetOrderDetailResponse();

			getOrderDetailResponse.HttpResponse = context.HttpResponse;
			getOrderDetailResponse.RequestId = context.StringValue("GetOrderDetail.RequestId");
			getOrderDetailResponse.Success = context.BooleanValue("GetOrderDetail.Success");
			getOrderDetailResponse.Code = context.StringValue("GetOrderDetail.Code");
			getOrderDetailResponse.Message = context.StringValue("GetOrderDetail.Message");

			GetOrderDetailResponse.GetOrderDetail_Data data = new GetOrderDetailResponse.GetOrderDetail_Data();
			data.HostName = context.StringValue("GetOrderDetail.Data.HostName");
			data.PageNum = context.IntegerValue("GetOrderDetail.Data.PageNum");
			data.PageSize = context.IntegerValue("GetOrderDetail.Data.PageSize");
			data.TotalCount = context.IntegerValue("GetOrderDetail.Data.TotalCount");

			List<GetOrderDetailResponse.GetOrderDetail_Data.GetOrderDetail_Order> data_orderList = new List<GetOrderDetailResponse.GetOrderDetail_Data.GetOrderDetail_Order>();
			for (int i = 0; i < context.Length("GetOrderDetail.Data.OrderList.Length"); i++) {
				GetOrderDetailResponse.GetOrderDetail_Data.GetOrderDetail_Order order = new GetOrderDetailResponse.GetOrderDetail_Data.GetOrderDetail_Order();
				order.OrderId = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].OrderId");
				order.SubOrderId = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].SubOrderId");
				order.ProductCode = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].ProductCode");
				order.ProductType = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].ProductType");
				order.SubscriptionType = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].SubscriptionType");
				order.OrderType = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].OrderType");
				order.CreateTime = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].CreateTime");
				order.PaymentTime = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].PaymentTime");
				order.PaymentStatus = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].PaymentStatus");
				order.Region = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].Region");
				order.Config = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].Config");
				order.Quantity = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].Quantity");
				order.UsageStartTime = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].UsageStartTime");
				order.UsageEndTime = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].UsageEndTime");
				order.InstanceIDs = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].InstanceIDs");
				order.PretaxGrossAmount = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].PretaxGrossAmount");
				order.PretaxAmount = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].PretaxAmount");
				order.Currency = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].Currency");
				order.PretaxAmountLocal = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].PretaxAmountLocal");
				order.Tax = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].Tax");
				order.AfterTaxAmount = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].AfterTaxAmount");
				order.PaymentCurrency = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].PaymentCurrency");
				order._Operator = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"]._Operator");
				order.RelatedOrderId = context.StringValue("GetOrderDetail.Data.OrderList["+ i +"].RelatedOrderId");

				data_orderList.Add(order);
			}
			data.OrderList = data_orderList;
			getOrderDetailResponse.Data = data;
        
			return getOrderDetailResponse;
        }
    }
}
