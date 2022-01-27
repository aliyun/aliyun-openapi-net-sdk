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
    public class ListNodeTupleOrdersResponseUnmarshaller
    {
        public static ListNodeTupleOrdersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodeTupleOrdersResponse listNodeTupleOrdersResponse = new ListNodeTupleOrdersResponse();

			listNodeTupleOrdersResponse.HttpResponse = _ctx.HttpResponse;
			listNodeTupleOrdersResponse.RequestId = _ctx.StringValue("ListNodeTupleOrders.RequestId");
			listNodeTupleOrdersResponse.Success = _ctx.BooleanValue("ListNodeTupleOrders.Success");

			ListNodeTupleOrdersResponse.ListNodeTupleOrders_Data data = new ListNodeTupleOrdersResponse.ListNodeTupleOrders_Data();
			data.TotalCount = _ctx.LongValue("ListNodeTupleOrders.Data.TotalCount");

			List<ListNodeTupleOrdersResponse.ListNodeTupleOrders_Data.ListNodeTupleOrders_Order> data_list = new List<ListNodeTupleOrdersResponse.ListNodeTupleOrders_Data.ListNodeTupleOrders_Order>();
			for (int i = 0; i < _ctx.Length("ListNodeTupleOrders.Data.List.Length"); i++) {
				ListNodeTupleOrdersResponse.ListNodeTupleOrders_Data.ListNodeTupleOrders_Order order = new ListNodeTupleOrdersResponse.ListNodeTupleOrders_Data.ListNodeTupleOrders_Order();
				order.OrderId = _ctx.StringValue("ListNodeTupleOrders.Data.List["+ i +"].OrderId");
				order.IsKpm = _ctx.BooleanValue("ListNodeTupleOrders.Data.List["+ i +"].IsKpm");
				order.OrderState = _ctx.StringValue("ListNodeTupleOrders.Data.List["+ i +"].OrderState");
				order.RequiredCount = _ctx.LongValue("ListNodeTupleOrders.Data.List["+ i +"].RequiredCount");
				order.CreatedMillis = _ctx.LongValue("ListNodeTupleOrders.Data.List["+ i +"].CreatedMillis");
				order.AcceptedMillis = _ctx.LongValue("ListNodeTupleOrders.Data.List["+ i +"].AcceptedMillis");
				order.LoraVersion = _ctx.StringValue("ListNodeTupleOrders.Data.List["+ i +"].LoraVersion");
				order.SuccessCount = _ctx.LongValue("ListNodeTupleOrders.Data.List["+ i +"].SuccessCount");
				order.FailedCount = _ctx.LongValue("ListNodeTupleOrders.Data.List["+ i +"].FailedCount");
				order.TupleType = _ctx.StringValue("ListNodeTupleOrders.Data.List["+ i +"].TupleType");

				data_list.Add(order);
			}
			data.List = data_list;
			listNodeTupleOrdersResponse.Data = data;
        
			return listNodeTupleOrdersResponse;
        }
    }
}
