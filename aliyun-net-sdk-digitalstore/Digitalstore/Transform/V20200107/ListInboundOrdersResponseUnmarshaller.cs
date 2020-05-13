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
using Aliyun.Acs.digitalstore.Model.V20200107;

namespace Aliyun.Acs.digitalstore.Transform.V20200107
{
    public class ListInboundOrdersResponseUnmarshaller
    {
        public static ListInboundOrdersResponse Unmarshall(UnmarshallerContext context)
        {
			ListInboundOrdersResponse listInboundOrdersResponse = new ListInboundOrdersResponse();

			listInboundOrdersResponse.HttpResponse = context.HttpResponse;
			listInboundOrdersResponse.PageSize = context.IntegerValue("ListInboundOrders.PageSize");
			listInboundOrdersResponse.TotalCount = context.IntegerValue("ListInboundOrders.TotalCount");
			listInboundOrdersResponse.PageNumber = context.IntegerValue("ListInboundOrders.PageNumber");
			listInboundOrdersResponse.RequestId = context.StringValue("ListInboundOrders.RequestId");
			listInboundOrdersResponse.Success = context.BooleanValue("ListInboundOrders.Success");

			List<ListInboundOrdersResponse.ListInboundOrders_InboundOrder> listInboundOrdersResponse_inboundOrders = new List<ListInboundOrdersResponse.ListInboundOrders_InboundOrder>();
			for (int i = 0; i < context.Length("ListInboundOrders.InboundOrders.Length"); i++) {
				ListInboundOrdersResponse.ListInboundOrders_InboundOrder inboundOrder = new ListInboundOrdersResponse.ListInboundOrders_InboundOrder();
				inboundOrder.ToWarehouseName = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].ToWarehouseName");
				inboundOrder.ConfirmTime = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].ConfirmTime");
				inboundOrder.OrderSubTypeCode = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].OrderSubTypeCode");
				inboundOrder.OrderStatus = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].OrderStatus");
				inboundOrder.Description = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].Description");
				inboundOrder.OperateQuantity = context.IntegerValue("ListInboundOrders.InboundOrders["+ i +"].OperateQuantity");
				inboundOrder.FromWarehouseId = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].FromWarehouseId");
				inboundOrder.LastSyncTime = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].LastSyncTime");
				inboundOrder.ConfirmQuantity = context.IntegerValue("ListInboundOrders.InboundOrders["+ i +"].ConfirmQuantity");
				inboundOrder.ModifiedTime = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].ModifiedTime");
				inboundOrder.FromBusinessUnitId = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].FromBusinessUnitId");
				inboundOrder.Id = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].Id");
				inboundOrder.FromBusinessUnitName = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].FromBusinessUnitName");
				inboundOrder.OrderCode = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].OrderCode");
				inboundOrder.CreatedTime = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].CreatedTime");
				inboundOrder.ToWarehouseId = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].ToWarehouseId");
				inboundOrder.SyncStatus = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].SyncStatus");
				inboundOrder.FromWarehouseName = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].FromWarehouseName");
				inboundOrder.Quantity = context.IntegerValue("ListInboundOrders.InboundOrders["+ i +"].Quantity");
				inboundOrder.SourceOrderCode = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].SourceOrderCode");
				inboundOrder.OrderId = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].OrderId");
				inboundOrder.ToBusinessUnitId = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].ToBusinessUnitId");
				inboundOrder.CaseCount = context.IntegerValue("ListInboundOrders.InboundOrders["+ i +"].CaseCount");
				inboundOrder.ToWarehouseCode = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].ToWarehouseCode");
				inboundOrder.FromWarehouseCode = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].FromWarehouseCode");
				inboundOrder.ToBusinessUnitCode = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].ToBusinessUnitCode");
				inboundOrder.FromBusinessUnitCode = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].FromBusinessUnitCode");
				inboundOrder.CreateUserId = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].CreateUserId");
				inboundOrder.CreateUserName = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].CreateUserName");
				inboundOrder.CreateDateTime = context.StringValue("ListInboundOrders.InboundOrders["+ i +"].CreateDateTime");

				listInboundOrdersResponse_inboundOrders.Add(inboundOrder);
			}
			listInboundOrdersResponse.InboundOrders = listInboundOrdersResponse_inboundOrders;
        
			return listInboundOrdersResponse;
        }
    }
}
