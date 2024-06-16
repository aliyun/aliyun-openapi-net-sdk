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
using Aliyun.Acs.idaas_doraemon.Model.V20210520;

namespace Aliyun.Acs.idaas_doraemon.Transform.V20210520
{
    public class ListCostUnitOrdersResponseUnmarshaller
    {
        public static ListCostUnitOrdersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCostUnitOrdersResponse listCostUnitOrdersResponse = new ListCostUnitOrdersResponse();

			listCostUnitOrdersResponse.HttpResponse = _ctx.HttpResponse;
			listCostUnitOrdersResponse.RequestId = _ctx.StringValue("ListCostUnitOrders.RequestId");
			listCostUnitOrdersResponse.TotalPages = _ctx.LongValue("ListCostUnitOrders.TotalPages");
			listCostUnitOrdersResponse.TotalElements = _ctx.LongValue("ListCostUnitOrders.TotalElements");
			listCostUnitOrdersResponse.PageSize = _ctx.LongValue("ListCostUnitOrders.PageSize");

			List<ListCostUnitOrdersResponse.ListCostUnitOrders_Item> listCostUnitOrdersResponse_items = new List<ListCostUnitOrdersResponse.ListCostUnitOrders_Item>();
			for (int i = 0; i < _ctx.Length("ListCostUnitOrders.Items.Length"); i++) {
				ListCostUnitOrdersResponse.ListCostUnitOrders_Item item = new ListCostUnitOrdersResponse.ListCostUnitOrders_Item();
				item.AliOrderCode = _ctx.StringValue("ListCostUnitOrders.Items["+ i +"].AliOrderCode");
				item.AliOrderInstanceId = _ctx.StringValue("ListCostUnitOrders.Items["+ i +"].AliOrderInstanceId");
				item.TotalCostUnit = _ctx.LongValue("ListCostUnitOrders.Items["+ i +"].TotalCostUnit");
				item.UsedCostUnit = _ctx.LongValue("ListCostUnitOrders.Items["+ i +"].UsedCostUnit");
				item.OrderStatus = _ctx.StringValue("ListCostUnitOrders.Items["+ i +"].OrderStatus");
				item.CreateTime = _ctx.LongValue("ListCostUnitOrders.Items["+ i +"].CreateTime");
				item.ExpiredTime = _ctx.LongValue("ListCostUnitOrders.Items["+ i +"].ExpiredTime");
				item.RefundTime = _ctx.LongValue("ListCostUnitOrders.Items["+ i +"].RefundTime");
				item.Exhausted = _ctx.BooleanValue("ListCostUnitOrders.Items["+ i +"].Exhausted");

				listCostUnitOrdersResponse_items.Add(item);
			}
			listCostUnitOrdersResponse.Items = listCostUnitOrdersResponse_items;
        
			return listCostUnitOrdersResponse;
        }
    }
}
