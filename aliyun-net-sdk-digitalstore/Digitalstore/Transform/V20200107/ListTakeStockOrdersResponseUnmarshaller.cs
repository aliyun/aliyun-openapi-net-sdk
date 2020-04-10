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
    public class ListTakeStockOrdersResponseUnmarshaller
    {
        public static ListTakeStockOrdersResponse Unmarshall(UnmarshallerContext context)
        {
			ListTakeStockOrdersResponse listTakeStockOrdersResponse = new ListTakeStockOrdersResponse();

			listTakeStockOrdersResponse.HttpResponse = context.HttpResponse;
			listTakeStockOrdersResponse.PageSize = context.IntegerValue("ListTakeStockOrders.PageSize");
			listTakeStockOrdersResponse.TotalCount = context.IntegerValue("ListTakeStockOrders.TotalCount");
			listTakeStockOrdersResponse.PageNumber = context.IntegerValue("ListTakeStockOrders.PageNumber");
			listTakeStockOrdersResponse.RequestId = context.StringValue("ListTakeStockOrders.RequestId");
			listTakeStockOrdersResponse.Success = context.BooleanValue("ListTakeStockOrders.Success");

			List<ListTakeStockOrdersResponse.ListTakeStockOrders_TakeStockOrderModel> listTakeStockOrdersResponse_takeStockOrders = new List<ListTakeStockOrdersResponse.ListTakeStockOrders_TakeStockOrderModel>();
			for (int i = 0; i < context.Length("ListTakeStockOrders.TakeStockOrders.Length"); i++) {
				ListTakeStockOrdersResponse.ListTakeStockOrders_TakeStockOrderModel takeStockOrderModel = new ListTakeStockOrdersResponse.ListTakeStockOrders_TakeStockOrderModel();
				takeStockOrderModel.WarehouseCode = context.StringValue("ListTakeStockOrders.TakeStockOrders["+ i +"].WarehouseCode");
				takeStockOrderModel.CreateDate = context.StringValue("ListTakeStockOrders.TakeStockOrders["+ i +"].CreateDate");
				takeStockOrderModel.WarehouseName = context.StringValue("ListTakeStockOrders.TakeStockOrders["+ i +"].WarehouseName");
				takeStockOrderModel.ConfirmDateTime = context.StringValue("ListTakeStockOrders.TakeStockOrders["+ i +"].ConfirmDateTime");
				takeStockOrderModel.Description = context.StringValue("ListTakeStockOrders.TakeStockOrders["+ i +"].Description");
				takeStockOrderModel.OrderId = context.StringValue("ListTakeStockOrders.TakeStockOrders["+ i +"].OrderId");
				takeStockOrderModel.UpdateDate = context.StringValue("ListTakeStockOrders.TakeStockOrders["+ i +"].UpdateDate");
				takeStockOrderModel.Code = context.StringValue("ListTakeStockOrders.TakeStockOrders["+ i +"].Code");
				takeStockOrderModel.SyncStatus = context.StringValue("ListTakeStockOrders.TakeStockOrders["+ i +"].SyncStatus");
				takeStockOrderModel.Status = context.StringValue("ListTakeStockOrders.TakeStockOrders["+ i +"].Status");
				takeStockOrderModel.MakeDateTime = context.StringValue("ListTakeStockOrders.TakeStockOrders["+ i +"].MakeDateTime");
				takeStockOrderModel.SourceOrderCode = context.StringValue("ListTakeStockOrders.TakeStockOrders["+ i +"].SourceOrderCode");
				takeStockOrderModel.LastSyncDateTime = context.StringValue("ListTakeStockOrders.TakeStockOrders["+ i +"].LastSyncDateTime");
				takeStockOrderModel.WarehouseId = context.StringValue("ListTakeStockOrders.TakeStockOrders["+ i +"].WarehouseId");

				listTakeStockOrdersResponse_takeStockOrders.Add(takeStockOrderModel);
			}
			listTakeStockOrdersResponse.TakeStockOrders = listTakeStockOrdersResponse_takeStockOrders;
        
			return listTakeStockOrdersResponse;
        }
    }
}
