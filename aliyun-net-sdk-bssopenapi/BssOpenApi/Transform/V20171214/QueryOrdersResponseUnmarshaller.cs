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
			queryOrdersResponse.Code = _ctx.StringValue("QueryOrders.Code");
			queryOrdersResponse.Message = _ctx.StringValue("QueryOrders.Message");
			queryOrdersResponse.RequestId = _ctx.StringValue("QueryOrders.RequestId");
			queryOrdersResponse.Success = _ctx.BooleanValue("QueryOrders.Success");

			QueryOrdersResponse.QueryOrders_Data data = new QueryOrdersResponse.QueryOrders_Data();
			data.HostName = _ctx.StringValue("QueryOrders.Data.HostName");
			data.PageNum = _ctx.IntegerValue("QueryOrders.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("QueryOrders.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QueryOrders.Data.TotalCount");

			List<QueryOrdersResponse.QueryOrders_Data.QueryOrders_Order> data_orderList = new List<QueryOrdersResponse.QueryOrders_Data.QueryOrders_Order>();
			for (int i = 0; i < _ctx.Length("QueryOrders.Data.OrderList.Length"); i++) {
				QueryOrdersResponse.QueryOrders_Data.QueryOrders_Order order = new QueryOrdersResponse.QueryOrders_Data.QueryOrders_Order();
				order.PretaxAmount = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].PretaxAmount");
				order.CommodityCode = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].CommodityCode");
				order.RelatedOrderId = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].RelatedOrderId");
				order.CreateTime = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].CreateTime");
				order.Currency = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].Currency");
				order.SubscriptionType = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].SubscriptionType");
				order.PaymentCurrency = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].PaymentCurrency");
				order.ProductType = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].ProductType");
				order.AfterTaxAmount = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].AfterTaxAmount");
				order.PaymentTime = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].PaymentTime");
				order.PretaxGrossAmount = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].PretaxGrossAmount");
				order.OrderType = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].OrderType");
				order.PaymentStatus = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].PaymentStatus");
				order.OrderId = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].OrderId");
				order.Tax = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].Tax");
				order.PretaxAmountLocal = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].PretaxAmountLocal");
				order.ProductCode = _ctx.StringValue("QueryOrders.Data.OrderList["+ i +"].ProductCode");

				data_orderList.Add(order);
			}
			data.OrderList = data_orderList;
			queryOrdersResponse.Data = data;
        
			return queryOrdersResponse;
        }
    }
}
