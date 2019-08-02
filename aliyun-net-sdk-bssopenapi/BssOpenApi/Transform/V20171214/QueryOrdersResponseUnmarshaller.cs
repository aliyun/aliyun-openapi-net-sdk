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
    public class QueryOrdersResponseUnmarshaller
    {
        public static QueryOrdersResponse Unmarshall(UnmarshallerContext context)
        {
			QueryOrdersResponse queryOrdersResponse = new QueryOrdersResponse();

			queryOrdersResponse.HttpResponse = context.HttpResponse;
			queryOrdersResponse.RequestId = context.StringValue("QueryOrders.RequestId");
			queryOrdersResponse.Success = context.BooleanValue("QueryOrders.Success");
			queryOrdersResponse.Code = context.StringValue("QueryOrders.Code");
			queryOrdersResponse.Message = context.StringValue("QueryOrders.Message");

			QueryOrdersResponse.QueryOrders_Data data = new QueryOrdersResponse.QueryOrders_Data();
			data.HostName = context.StringValue("QueryOrders.Data.HostName");
			data.PageNum = context.IntegerValue("QueryOrders.Data.PageNum");
			data.PageSize = context.IntegerValue("QueryOrders.Data.PageSize");
			data.TotalCount = context.IntegerValue("QueryOrders.Data.TotalCount");

			List<QueryOrdersResponse.QueryOrders_Data.QueryOrders_Order> data_orderList = new List<QueryOrdersResponse.QueryOrders_Data.QueryOrders_Order>();
			for (int i = 0; i < context.Length("QueryOrders.Data.OrderList.Length"); i++) {
				QueryOrdersResponse.QueryOrders_Data.QueryOrders_Order order = new QueryOrdersResponse.QueryOrders_Data.QueryOrders_Order();
				order.OrderId = context.StringValue("QueryOrders.Data.OrderList["+ i +"].OrderId");
				order.ProductCode = context.StringValue("QueryOrders.Data.OrderList["+ i +"].ProductCode");
				order.ProductType = context.StringValue("QueryOrders.Data.OrderList["+ i +"].ProductType");
				order.SubscriptionType = context.StringValue("QueryOrders.Data.OrderList["+ i +"].SubscriptionType");
				order.OrderType = context.StringValue("QueryOrders.Data.OrderList["+ i +"].OrderType");
				order.CreateTime = context.StringValue("QueryOrders.Data.OrderList["+ i +"].CreateTime");
				order.PaymentTime = context.StringValue("QueryOrders.Data.OrderList["+ i +"].PaymentTime");
				order.PaymentStatus = context.StringValue("QueryOrders.Data.OrderList["+ i +"].PaymentStatus");
				order.PretaxGrossAmount = context.StringValue("QueryOrders.Data.OrderList["+ i +"].PretaxGrossAmount");
				order.PretaxAmount = context.StringValue("QueryOrders.Data.OrderList["+ i +"].PretaxAmount");
				order.Currency = context.StringValue("QueryOrders.Data.OrderList["+ i +"].Currency");
				order.PretaxAmountLocal = context.StringValue("QueryOrders.Data.OrderList["+ i +"].PretaxAmountLocal");
				order.Tax = context.StringValue("QueryOrders.Data.OrderList["+ i +"].Tax");
				order.AfterTaxAmount = context.StringValue("QueryOrders.Data.OrderList["+ i +"].AfterTaxAmount");
				order.PaymentCurrency = context.StringValue("QueryOrders.Data.OrderList["+ i +"].PaymentCurrency");
				order.RelatedOrderId = context.StringValue("QueryOrders.Data.OrderList["+ i +"].RelatedOrderId");

				data_orderList.Add(order);
			}
			data.OrderList = data_orderList;
			queryOrdersResponse.Data = data;
        
			return queryOrdersResponse;
        }
    }
}
