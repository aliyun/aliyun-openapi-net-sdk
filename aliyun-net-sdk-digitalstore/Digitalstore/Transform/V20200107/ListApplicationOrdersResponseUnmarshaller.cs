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
    public class ListApplicationOrdersResponseUnmarshaller
    {
        public static ListApplicationOrdersResponse Unmarshall(UnmarshallerContext context)
        {
			ListApplicationOrdersResponse listApplicationOrdersResponse = new ListApplicationOrdersResponse();

			listApplicationOrdersResponse.HttpResponse = context.HttpResponse;
			listApplicationOrdersResponse.PageSize = context.IntegerValue("ListApplicationOrders.PageSize");
			listApplicationOrdersResponse.TotalCount = context.IntegerValue("ListApplicationOrders.TotalCount");
			listApplicationOrdersResponse.PageNumber = context.IntegerValue("ListApplicationOrders.PageNumber");
			listApplicationOrdersResponse.RequestId = context.StringValue("ListApplicationOrders.RequestId");
			listApplicationOrdersResponse.Success = context.BooleanValue("ListApplicationOrders.Success");

			List<ListApplicationOrdersResponse.ListApplicationOrders_ApplyOrderModel> listApplicationOrdersResponse_applyOrders = new List<ListApplicationOrdersResponse.ListApplicationOrders_ApplyOrderModel>();
			for (int i = 0; i < context.Length("ListApplicationOrders.ApplyOrders.Length"); i++) {
				ListApplicationOrdersResponse.ListApplicationOrders_ApplyOrderModel applyOrderModel = new ListApplicationOrdersResponse.ListApplicationOrders_ApplyOrderModel();
				applyOrderModel.OrderId = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].OrderId");
				applyOrderModel.ConfirmTotal = context.IntegerValue("ListApplicationOrders.ApplyOrders["+ i +"].ConfirmTotal");
				applyOrderModel.Code = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].Code");
				applyOrderModel.UpdateDate = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].UpdateDate");
				applyOrderModel.WarehouseName = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].WarehouseName");
				applyOrderModel.ProductionOrderQuantity = context.IntegerValue("ListApplicationOrders.ApplyOrders["+ i +"].ProductionOrderQuantity");
				applyOrderModel.WarehouseCode = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].WarehouseCode");
				applyOrderModel.ConfirmDateTime = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].ConfirmDateTime");
				applyOrderModel.ConfirmCaseQuantity = context.IntegerValue("ListApplicationOrders.ApplyOrders["+ i +"].ConfirmCaseQuantity");
				applyOrderModel.ProductionOrderSourceOrderCode = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].ProductionOrderSourceOrderCode");
				applyOrderModel.ConfirmDeliveryDate = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].ConfirmDeliveryDate");
				applyOrderModel.PurchaseOrderCode = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].PurchaseOrderCode");
				applyOrderModel.RejectReason = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].RejectReason");
				applyOrderModel.Total = context.IntegerValue("ListApplicationOrders.ApplyOrders["+ i +"].Total");
				applyOrderModel.DeliveryDate = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].DeliveryDate");
				applyOrderModel.ConfirmDeliveryDateTimeRange = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].ConfirmDeliveryDateTimeRange");
				applyOrderModel.ProductId = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].ProductId");
				applyOrderModel.FromBusinessUnitCode = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].FromBusinessUnitCode");
				applyOrderModel.FromBusinessUnitId = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].FromBusinessUnitId");
				applyOrderModel.CreateDate = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].CreateDate");
				applyOrderModel.ToWarehouseContact = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].ToWarehouseContact");
				applyOrderModel.ContractNumber = context.IntegerValue("ListApplicationOrders.ApplyOrders["+ i +"].ContractNumber");
				applyOrderModel.WarehouseId = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].WarehouseId");
				applyOrderModel.CaseQuantity = context.IntegerValue("ListApplicationOrders.ApplyOrders["+ i +"].CaseQuantity");
				applyOrderModel.PurchaseOrderId = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].PurchaseOrderId");
				applyOrderModel.SourceOrderCode = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].SourceOrderCode");
				applyOrderModel.ToWarehouseTel = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].ToWarehouseTel");
				applyOrderModel.ReceivedQuantity = context.IntegerValue("ListApplicationOrders.ApplyOrders["+ i +"].ReceivedQuantity");
				applyOrderModel.Status = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].Status");
				applyOrderModel.FromBusinessUnitName = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].FromBusinessUnitName");
				applyOrderModel.ScanType = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].ScanType");
				applyOrderModel.ToWarehouseAddress = context.StringValue("ListApplicationOrders.ApplyOrders["+ i +"].ToWarehouseAddress");

				listApplicationOrdersResponse_applyOrders.Add(applyOrderModel);
			}
			listApplicationOrdersResponse.ApplyOrders = listApplicationOrdersResponse_applyOrders;
        
			return listApplicationOrdersResponse;
        }
    }
}
