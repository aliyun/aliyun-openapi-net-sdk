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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class ListGatewayTupleOrdersResponseUnmarshaller
    {
        public static ListGatewayTupleOrdersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGatewayTupleOrdersResponse listGatewayTupleOrdersResponse = new ListGatewayTupleOrdersResponse();

			listGatewayTupleOrdersResponse.HttpResponse = _ctx.HttpResponse;
			listGatewayTupleOrdersResponse.RequestId = _ctx.StringValue("ListGatewayTupleOrders.RequestId");
			listGatewayTupleOrdersResponse.Success = _ctx.BooleanValue("ListGatewayTupleOrders.Success");

			ListGatewayTupleOrdersResponse.ListGatewayTupleOrders_Data data = new ListGatewayTupleOrdersResponse.ListGatewayTupleOrders_Data();
			data.TotalCount = _ctx.LongValue("ListGatewayTupleOrders.Data.TotalCount");

			List<ListGatewayTupleOrdersResponse.ListGatewayTupleOrders_Data.ListGatewayTupleOrders_GatewayTupleOrder> data_list = new List<ListGatewayTupleOrdersResponse.ListGatewayTupleOrders_Data.ListGatewayTupleOrders_GatewayTupleOrder>();
			for (int i = 0; i < _ctx.Length("ListGatewayTupleOrders.Data.List.Length"); i++) {
				ListGatewayTupleOrdersResponse.ListGatewayTupleOrders_Data.ListGatewayTupleOrders_GatewayTupleOrder gatewayTupleOrder = new ListGatewayTupleOrdersResponse.ListGatewayTupleOrders_Data.ListGatewayTupleOrders_GatewayTupleOrder();
				gatewayTupleOrder.OrderId = _ctx.StringValue("ListGatewayTupleOrders.Data.List["+ i +"].OrderId");
				gatewayTupleOrder.OrderState = _ctx.StringValue("ListGatewayTupleOrders.Data.List["+ i +"].OrderState");
				gatewayTupleOrder.RequiredCount = _ctx.LongValue("ListGatewayTupleOrders.Data.List["+ i +"].RequiredCount");
				gatewayTupleOrder.CreatedMillis = _ctx.LongValue("ListGatewayTupleOrders.Data.List["+ i +"].CreatedMillis");
				gatewayTupleOrder.AcceptedMillis = _ctx.LongValue("ListGatewayTupleOrders.Data.List["+ i +"].AcceptedMillis");
				gatewayTupleOrder.TupleType = _ctx.StringValue("ListGatewayTupleOrders.Data.List["+ i +"].TupleType");

				data_list.Add(gatewayTupleOrder);
			}
			data.List = data_list;
			listGatewayTupleOrdersResponse.Data = data;
        
			return listGatewayTupleOrdersResponse;
        }
    }
}
