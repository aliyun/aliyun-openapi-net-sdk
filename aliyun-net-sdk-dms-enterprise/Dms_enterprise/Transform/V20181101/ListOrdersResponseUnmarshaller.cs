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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class ListOrdersResponseUnmarshaller
    {
        public static ListOrdersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOrdersResponse listOrdersResponse = new ListOrdersResponse();

			listOrdersResponse.HttpResponse = _ctx.HttpResponse;
			listOrdersResponse.TotalCount = _ctx.LongValue("ListOrders.TotalCount");
			listOrdersResponse.RequestId = _ctx.StringValue("ListOrders.RequestId");
			listOrdersResponse.ErrorCode = _ctx.StringValue("ListOrders.ErrorCode");
			listOrdersResponse.ErrorMessage = _ctx.StringValue("ListOrders.ErrorMessage");
			listOrdersResponse.Success = _ctx.BooleanValue("ListOrders.Success");

			List<ListOrdersResponse.ListOrders_Order> listOrdersResponse_orders = new List<ListOrdersResponse.ListOrders_Order>();
			for (int i = 0; i < _ctx.Length("ListOrders.Orders.Length"); i++) {
				ListOrdersResponse.ListOrders_Order order = new ListOrdersResponse.ListOrders_Order();
				order.Comment = _ctx.StringValue("ListOrders.Orders["+ i +"].Comment");
				order.LastModifyTime = _ctx.StringValue("ListOrders.Orders["+ i +"].LastModifyTime");
				order.StatusCode = _ctx.StringValue("ListOrders.Orders["+ i +"].StatusCode");
				order.CreateTime = _ctx.StringValue("ListOrders.Orders["+ i +"].CreateTime");
				order.Committer = _ctx.StringValue("ListOrders.Orders["+ i +"].Committer");
				order.CommitterId = _ctx.LongValue("ListOrders.Orders["+ i +"].CommitterId");
				order.StatusDesc = _ctx.StringValue("ListOrders.Orders["+ i +"].StatusDesc");
				order.PluginType = _ctx.StringValue("ListOrders.Orders["+ i +"].PluginType");
				order.OrderId = _ctx.LongValue("ListOrders.Orders["+ i +"].OrderId");

				listOrdersResponse_orders.Add(order);
			}
			listOrdersResponse.Orders = listOrdersResponse_orders;
        
			return listOrdersResponse;
        }
    }
}
