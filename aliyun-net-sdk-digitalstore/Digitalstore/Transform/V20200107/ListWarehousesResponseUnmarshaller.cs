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
    public class ListWarehousesResponseUnmarshaller
    {
        public static ListWarehousesResponse Unmarshall(UnmarshallerContext context)
        {
			ListWarehousesResponse listWarehousesResponse = new ListWarehousesResponse();

			listWarehousesResponse.HttpResponse = context.HttpResponse;
			listWarehousesResponse.PageSize = context.IntegerValue("ListWarehouses.PageSize");
			listWarehousesResponse.TotalCount = context.IntegerValue("ListWarehouses.TotalCount");
			listWarehousesResponse.PageNumber = context.IntegerValue("ListWarehouses.PageNumber");
			listWarehousesResponse.RequestId = context.StringValue("ListWarehouses.RequestId");
			listWarehousesResponse.Success = context.BooleanValue("ListWarehouses.Success");

			List<ListWarehousesResponse.ListWarehouses_WarehouseModel> listWarehousesResponse_warehouses = new List<ListWarehousesResponse.ListWarehouses_WarehouseModel>();
			for (int i = 0; i < context.Length("ListWarehouses.Warehouses.Length"); i++) {
				ListWarehousesResponse.ListWarehouses_WarehouseModel warehouseModel = new ListWarehousesResponse.ListWarehouses_WarehouseModel();
				warehouseModel.Tel = context.StringValue("ListWarehouses.Warehouses["+ i +"].Tel");
				warehouseModel.Description = context.StringValue("ListWarehouses.Warehouses["+ i +"].Description");
				warehouseModel.Name = context.StringValue("ListWarehouses.Warehouses["+ i +"].Name");
				warehouseModel.WarehouseCategoryCode = context.StringValue("ListWarehouses.Warehouses["+ i +"].WarehouseCategoryCode");
				warehouseModel.CreateDate = context.StringValue("ListWarehouses.Warehouses["+ i +"].CreateDate");
				warehouseModel.Code = context.StringValue("ListWarehouses.Warehouses["+ i +"].Code");
				warehouseModel.Address = context.StringValue("ListWarehouses.Warehouses["+ i +"].Address");
				warehouseModel.UpdateDate = context.StringValue("ListWarehouses.Warehouses["+ i +"].UpdateDate");
				warehouseModel.Contact = context.StringValue("ListWarehouses.Warehouses["+ i +"].Contact");
				warehouseModel.Disable = context.IntegerValue("ListWarehouses.Warehouses["+ i +"].Disable");
				warehouseModel.WarehouseId = context.StringValue("ListWarehouses.Warehouses["+ i +"].WarehouseId");

				listWarehousesResponse_warehouses.Add(warehouseModel);
			}
			listWarehousesResponse.Warehouses = listWarehousesResponse_warehouses;
        
			return listWarehousesResponse;
        }
    }
}
