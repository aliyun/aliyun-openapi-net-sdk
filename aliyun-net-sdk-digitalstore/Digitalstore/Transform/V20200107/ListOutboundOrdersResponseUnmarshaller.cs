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
    public class ListOutboundOrdersResponseUnmarshaller
    {
        public static ListOutboundOrdersResponse Unmarshall(UnmarshallerContext context)
        {
			ListOutboundOrdersResponse listOutboundOrdersResponse = new ListOutboundOrdersResponse();

			listOutboundOrdersResponse.HttpResponse = context.HttpResponse;
			listOutboundOrdersResponse.PageSize = context.IntegerValue("ListOutboundOrders.PageSize");
			listOutboundOrdersResponse.TotalCount = context.IntegerValue("ListOutboundOrders.TotalCount");
			listOutboundOrdersResponse.PageNumber = context.IntegerValue("ListOutboundOrders.PageNumber");
			listOutboundOrdersResponse.RequestId = context.StringValue("ListOutboundOrders.RequestId");
			listOutboundOrdersResponse.Success = context.BooleanValue("ListOutboundOrders.Success");

			List<ListOutboundOrdersResponse.ListOutboundOrders_OutboundOrder> listOutboundOrdersResponse_outboundOrders = new List<ListOutboundOrdersResponse.ListOutboundOrders_OutboundOrder>();
			for (int i = 0; i < context.Length("ListOutboundOrders.OutboundOrders.Length"); i++) {
				ListOutboundOrdersResponse.ListOutboundOrders_OutboundOrder outboundOrder = new ListOutboundOrdersResponse.ListOutboundOrders_OutboundOrder();
				outboundOrder.ToWarehouseName = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].ToWarehouseName");
				outboundOrder.ConfirmTime = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].ConfirmTime");
				outboundOrder.OrderSubTypeCode = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].OrderSubTypeCode");
				outboundOrder.OrderStatus = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].OrderStatus");
				outboundOrder.Description = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].Description");
				outboundOrder.OperateQuantity = context.IntegerValue("ListOutboundOrders.OutboundOrders["+ i +"].OperateQuantity");
				outboundOrder.FromWarehouseId = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].FromWarehouseId");
				outboundOrder.LastSyncTime = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].LastSyncTime");
				outboundOrder.ConfirmQuantity = context.IntegerValue("ListOutboundOrders.OutboundOrders["+ i +"].ConfirmQuantity");
				outboundOrder.UpdateDate = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].UpdateDate");
				outboundOrder.FromBusinessUnitId = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].FromBusinessUnitId");
				outboundOrder.Id = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].Id");
				outboundOrder.FromBusinessUnitName = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].FromBusinessUnitName");
				outboundOrder.OrderCode = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].OrderCode");
				outboundOrder.CreateDate = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].CreateDate");
				outboundOrder.ToWarehouseId = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].ToWarehouseId");
				outboundOrder.SyncStatus = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].SyncStatus");
				outboundOrder.FromWarehouseName = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].FromWarehouseName");
				outboundOrder.Quantity = context.IntegerValue("ListOutboundOrders.OutboundOrders["+ i +"].Quantity");
				outboundOrder.SourceOrderCode = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].SourceOrderCode");
				outboundOrder.OrderId = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].OrderId");
				outboundOrder.ToBusinessUnitId = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].ToBusinessUnitId");
				outboundOrder.CaseCount = context.IntegerValue("ListOutboundOrders.OutboundOrders["+ i +"].CaseCount");
				outboundOrder.ToWarehouseCode = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].ToWarehouseCode");
				outboundOrder.FromWarehouseCode = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].FromWarehouseCode");
				outboundOrder.ToBusinessUnitCode = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].ToBusinessUnitCode");
				outboundOrder.FromBusinessUnitCode = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].FromBusinessUnitCode");
				outboundOrder.CreateUserId = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].CreateUserId");
				outboundOrder.CreateUserName = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].CreateUserName");
				outboundOrder.CreateDateTime = context.StringValue("ListOutboundOrders.OutboundOrders["+ i +"].CreateDateTime");

				listOutboundOrdersResponse_outboundOrders.Add(outboundOrder);
			}
			listOutboundOrdersResponse.OutboundOrders = listOutboundOrdersResponse_outboundOrders;
        
			return listOutboundOrdersResponse;
        }
    }
}
