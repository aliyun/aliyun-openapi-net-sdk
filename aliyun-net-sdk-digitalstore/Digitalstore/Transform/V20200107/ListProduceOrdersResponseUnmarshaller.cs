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
    public class ListProduceOrdersResponseUnmarshaller
    {
        public static ListProduceOrdersResponse Unmarshall(UnmarshallerContext context)
        {
			ListProduceOrdersResponse listProduceOrdersResponse = new ListProduceOrdersResponse();

			listProduceOrdersResponse.HttpResponse = context.HttpResponse;
			listProduceOrdersResponse.PageSize = context.IntegerValue("ListProduceOrders.PageSize");
			listProduceOrdersResponse.TotalCount = context.IntegerValue("ListProduceOrders.TotalCount");
			listProduceOrdersResponse.PageNumber = context.IntegerValue("ListProduceOrders.PageNumber");
			listProduceOrdersResponse.RequestId = context.StringValue("ListProduceOrders.RequestId");
			listProduceOrdersResponse.Success = context.BooleanValue("ListProduceOrders.Success");

			List<ListProduceOrdersResponse.ListProduceOrders_ProduceOrderModel> listProduceOrdersResponse_orders = new List<ListProduceOrdersResponse.ListProduceOrders_ProduceOrderModel>();
			for (int i = 0; i < context.Length("ListProduceOrders.Orders.Length"); i++) {
				ListProduceOrdersResponse.ListProduceOrders_ProduceOrderModel produceOrderModel = new ListProduceOrdersResponse.ListProduceOrders_ProduceOrderModel();
				produceOrderModel.OrderId = context.StringValue("ListProduceOrders.Orders["+ i +"].OrderId");
				produceOrderModel.TotalBinding = context.IntegerValue("ListProduceOrders.Orders["+ i +"].TotalBinding");
				produceOrderModel.Code = context.StringValue("ListProduceOrders.Orders["+ i +"].Code");
				produceOrderModel.UpdateDate = context.StringValue("ListProduceOrders.Orders["+ i +"].UpdateDate");
				produceOrderModel.WarehouseName = context.StringValue("ListProduceOrders.Orders["+ i +"].WarehouseName");
				produceOrderModel.InboundQuantity = context.IntegerValue("ListProduceOrders.Orders["+ i +"].InboundQuantity");
				produceOrderModel.BusinessUnitId = context.StringValue("ListProduceOrders.Orders["+ i +"].BusinessUnitId");
				produceOrderModel.WarehouseCode = context.StringValue("ListProduceOrders.Orders["+ i +"].WarehouseCode");
				produceOrderModel.Description = context.StringValue("ListProduceOrders.Orders["+ i +"].Description");
				produceOrderModel.StyleName = context.StringValue("ListProduceOrders.Orders["+ i +"].StyleName");
				produceOrderModel.StyleId = context.StringValue("ListProduceOrders.Orders["+ i +"].StyleId");
				produceOrderModel.PurchaseOrderCode = context.StringValue("ListProduceOrders.Orders["+ i +"].PurchaseOrderCode");
				produceOrderModel.BusinessAmount = context.FloatValue("ListProduceOrders.Orders["+ i +"].BusinessAmount");
				produceOrderModel.DeliveryDate = context.StringValue("ListProduceOrders.Orders["+ i +"].DeliveryDate");
				produceOrderModel.BusinessUnitCode = context.StringValue("ListProduceOrders.Orders["+ i +"].BusinessUnitCode");
				produceOrderModel.MakeDateTime = context.StringValue("ListProduceOrders.Orders["+ i +"].MakeDateTime");
				produceOrderModel.BusinessUnitName = context.StringValue("ListProduceOrders.Orders["+ i +"].BusinessUnitName");
				produceOrderModel.TotalBoxQuantity = context.IntegerValue("ListProduceOrders.Orders["+ i +"].TotalBoxQuantity");
				produceOrderModel.CreateDate = context.StringValue("ListProduceOrders.Orders["+ i +"].CreateDate");
				produceOrderModel.StyleCode = context.StringValue("ListProduceOrders.Orders["+ i +"].StyleCode");
				produceOrderModel.ContractNumber = context.StringValue("ListProduceOrders.Orders["+ i +"].ContractNumber");
				produceOrderModel.WarehouseId = context.StringValue("ListProduceOrders.Orders["+ i +"].WarehouseId");
				produceOrderModel.Quantity = context.IntegerValue("ListProduceOrders.Orders["+ i +"].Quantity");
				produceOrderModel.SourceOrderCode = context.StringValue("ListProduceOrders.Orders["+ i +"].SourceOrderCode");
				produceOrderModel.PurchaseOrderId = context.StringValue("ListProduceOrders.Orders["+ i +"].PurchaseOrderId");
				produceOrderModel.SourceOrderType = context.StringValue("ListProduceOrders.Orders["+ i +"].SourceOrderType");
				produceOrderModel.Status = context.StringValue("ListProduceOrders.Orders["+ i +"].Status");
				produceOrderModel.ScanType = context.StringValue("ListProduceOrders.Orders["+ i +"].ScanType");
				produceOrderModel.ApplyOrderQuantity = context.IntegerValue("ListProduceOrders.Orders["+ i +"].ApplyOrderQuantity");
				produceOrderModel.ApplyCaseQuantity = context.IntegerValue("ListProduceOrders.Orders["+ i +"].ApplyCaseQuantity");

				listProduceOrdersResponse_orders.Add(produceOrderModel);
			}
			listProduceOrdersResponse.Orders = listProduceOrdersResponse_orders;
        
			return listProduceOrdersResponse;
        }
    }
}
