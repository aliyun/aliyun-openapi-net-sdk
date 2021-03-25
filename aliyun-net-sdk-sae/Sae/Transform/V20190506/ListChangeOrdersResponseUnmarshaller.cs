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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class ListChangeOrdersResponseUnmarshaller
    {
        public static ListChangeOrdersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListChangeOrdersResponse listChangeOrdersResponse = new ListChangeOrdersResponse();

			listChangeOrdersResponse.HttpResponse = _ctx.HttpResponse;
			listChangeOrdersResponse.Message = _ctx.StringValue("ListChangeOrders.Message");
			listChangeOrdersResponse.RequestId = _ctx.StringValue("ListChangeOrders.RequestId");
			listChangeOrdersResponse.TraceId = _ctx.StringValue("ListChangeOrders.TraceId");
			listChangeOrdersResponse.ErrorCode = _ctx.StringValue("ListChangeOrders.ErrorCode");
			listChangeOrdersResponse.Code = _ctx.StringValue("ListChangeOrders.Code");
			listChangeOrdersResponse.Success = _ctx.BooleanValue("ListChangeOrders.Success");

			ListChangeOrdersResponse.ListChangeOrders_Data data = new ListChangeOrdersResponse.ListChangeOrders_Data();
			data.PageSize = _ctx.IntegerValue("ListChangeOrders.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("ListChangeOrders.Data.CurrentPage");
			data.TotalSize = _ctx.IntegerValue("ListChangeOrders.Data.TotalSize");

			List<ListChangeOrdersResponse.ListChangeOrders_Data.ListChangeOrders_ChangeOrder> data_changeOrderList = new List<ListChangeOrdersResponse.ListChangeOrders_Data.ListChangeOrders_ChangeOrder>();
			for (int i = 0; i < _ctx.Length("ListChangeOrders.Data.ChangeOrderList.Length"); i++) {
				ListChangeOrdersResponse.ListChangeOrders_Data.ListChangeOrders_ChangeOrder changeOrder = new ListChangeOrdersResponse.ListChangeOrders_Data.ListChangeOrders_ChangeOrder();
				changeOrder.Status = _ctx.IntegerValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].Status");
				changeOrder.Description = _ctx.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].Description");
				changeOrder.CreateTime = _ctx.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].CreateTime");
				changeOrder.ChangeOrderId = _ctx.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].ChangeOrderId");
				changeOrder.CreateUserId = _ctx.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].CreateUserId");
				changeOrder.BatchType = _ctx.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].BatchType");
				changeOrder.Source = _ctx.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].Source");
				changeOrder.GroupId = _ctx.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].GroupId");
				changeOrder.AppId = _ctx.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].AppId");
				changeOrder.CoTypeCode = _ctx.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].CoTypeCode");
				changeOrder.FinishTime = _ctx.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].FinishTime");
				changeOrder.UserId = _ctx.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].UserId");
				changeOrder.CoType = _ctx.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].CoType");
				changeOrder.BatchCount = _ctx.IntegerValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].BatchCount");

				data_changeOrderList.Add(changeOrder);
			}
			data.ChangeOrderList = data_changeOrderList;
			listChangeOrdersResponse.Data = data;
        
			return listChangeOrdersResponse;
        }
    }
}
