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
        public static QueryOrdersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryOrdersResponse queryOrdersResponse = new QueryOrdersResponse();

			queryOrdersResponse.HttpResponse = _ctx.HttpResponse;
			queryOrdersResponse.RequestId = _ctx.StringValue("QueryOrders.RequestId");
			queryOrdersResponse.Success = _ctx.BooleanValue("QueryOrders.Success");
			queryOrdersResponse.Code = _ctx.StringValue("QueryOrders.Code");
			queryOrdersResponse.Message = _ctx.StringValue("QueryOrders.Message");

			QueryOrdersResponse.QueryOrders_Data data = new QueryOrdersResponse.QueryOrders_Data();
			data.HostName = _ctx.StringValue("QueryOrders.Data.HostName");
			data.PageNum = _ctx.IntegerValue("QueryOrders.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("QueryOrders.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QueryOrders.Data.TotalCount");

			List<QueryOrdersResponse.QueryOrders_Data.QueryOrders_Order> data_orderList = new List<QueryOrdersResponse.QueryOrders_Data.QueryOrders_Order>();
			for (int i = 0; i < _ctx.Length("QueryOrders.Data.OrderList.Length"); i++) {
				QueryOrdersResponse.QueryOrders_Data.QueryOrders_Order order = new QueryOrdersResponse.QueryOrders_Data.QueryOrders_Order();
				order.OrderId = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].OrderId");
				order.ProductCode = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].ProductCode");
				order.ProductType = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].ProductType");
				order.SubscriptionType = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].SubscriptionType");
				order.OrderType = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].OrderType");
				order.CreateTime = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].CreateTime");
				order.PaymentTime = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].PaymentTime");
				order.PaymentStatus = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].PaymentStatus");
				order.PretaxGrossAmount = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].PretaxGrossAmount");
				order.PretaxAmount = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].PretaxAmount");
				order.Currency = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].Currency");
				order.PretaxAmountLocal = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].PretaxAmountLocal");
				order.Tax = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].Tax");
				order.AfterTaxAmount = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].AfterTaxAmount");
				order.PaymentCurrency = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].PaymentCurrency");
				order.RelatedOrderId = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].RelatedOrderId");
				order.CommodityCode = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].CommodityCode");

				data_orderList.Add(order);
			}
			data.OrderList = data_orderList;
			queryOrdersResponse.Data = data;
        
			return queryOrdersResponse;
        }
    }
}
