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
    public class ListNamespaceChangeOrdersResponseUnmarshaller
    {
        public static ListNamespaceChangeOrdersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNamespaceChangeOrdersResponse listNamespaceChangeOrdersResponse = new ListNamespaceChangeOrdersResponse();

			listNamespaceChangeOrdersResponse.HttpResponse = _ctx.HttpResponse;
			listNamespaceChangeOrdersResponse.RequestId = _ctx.StringValue("ListNamespaceChangeOrders.RequestId");
			listNamespaceChangeOrdersResponse.ErrorCode = _ctx.StringValue("ListNamespaceChangeOrders.ErrorCode");
			listNamespaceChangeOrdersResponse.Success = _ctx.BooleanValue("ListNamespaceChangeOrders.Success");
			listNamespaceChangeOrdersResponse.Code = _ctx.StringValue("ListNamespaceChangeOrders.Code");
			listNamespaceChangeOrdersResponse.Message = _ctx.StringValue("ListNamespaceChangeOrders.Message");
			listNamespaceChangeOrdersResponse.TraceId = _ctx.StringValue("ListNamespaceChangeOrders.TraceId");

			ListNamespaceChangeOrdersResponse.ListNamespaceChangeOrders_Data data = new ListNamespaceChangeOrdersResponse.ListNamespaceChangeOrders_Data();
			data.CurrentPage = _ctx.IntegerValue("ListNamespaceChangeOrders.Data.CurrentPage");
			data.PageSize = _ctx.IntegerValue("ListNamespaceChangeOrders.Data.PageSize");
			data.TotalSize = _ctx.IntegerValue("ListNamespaceChangeOrders.Data.TotalSize");

			List<ListNamespaceChangeOrdersResponse.ListNamespaceChangeOrders_Data.ListNamespaceChangeOrders_ChangeOrder> data_changeOrderList = new List<ListNamespaceChangeOrdersResponse.ListNamespaceChangeOrders_Data.ListNamespaceChangeOrders_ChangeOrder>();
			for (int i = 0; i < _ctx.Length("ListNamespaceChangeOrders.Data.ChangeOrderList.Length"); i++) {
				ListNamespaceChangeOrdersResponse.ListNamespaceChangeOrders_Data.ListNamespaceChangeOrders_ChangeOrder changeOrder = new ListNamespaceChangeOrdersResponse.ListNamespaceChangeOrders_Data.ListNamespaceChangeOrders_ChangeOrder();
				changeOrder.Status = _ctx.IntegerValue("ListNamespaceChangeOrders.Data.ChangeOrderList["+ i +"].Status");
				changeOrder.FinishTime = _ctx.StringValue("ListNamespaceChangeOrders.Data.ChangeOrderList["+ i +"].FinishTime");
				changeOrder.NamespaceId = _ctx.StringValue("ListNamespaceChangeOrders.Data.ChangeOrderList["+ i +"].NamespaceId");
				changeOrder.CreateTime = _ctx.StringValue("ListNamespaceChangeOrders.Data.ChangeOrderList["+ i +"].CreateTime");
				changeOrder.UserId = _ctx.StringValue("ListNamespaceChangeOrders.Data.ChangeOrderList["+ i +"].UserId");
				changeOrder.Source = _ctx.StringValue("ListNamespaceChangeOrders.Data.ChangeOrderList["+ i +"].Source");
				changeOrder.CreateUserId = _ctx.StringValue("ListNamespaceChangeOrders.Data.ChangeOrderList["+ i +"].CreateUserId");
				changeOrder.BatchCount = _ctx.IntegerValue("ListNamespaceChangeOrders.Data.ChangeOrderList["+ i +"].BatchCount");
				changeOrder.CoTypeCode = _ctx.StringValue("ListNamespaceChangeOrders.Data.ChangeOrderList["+ i +"].CoTypeCode");
				changeOrder.ChangeOrderId = _ctx.StringValue("ListNamespaceChangeOrders.Data.ChangeOrderList["+ i +"].ChangeOrderId");
				changeOrder.BatchType = _ctx.StringValue("ListNamespaceChangeOrders.Data.ChangeOrderList["+ i +"].BatchType");
				changeOrder.Description = _ctx.StringValue("ListNamespaceChangeOrders.Data.ChangeOrderList["+ i +"].Description");
				changeOrder.GroupId = _ctx.StringValue("ListNamespaceChangeOrders.Data.ChangeOrderList["+ i +"].GroupId");
				changeOrder.CoType = _ctx.StringValue("ListNamespaceChangeOrders.Data.ChangeOrderList["+ i +"].CoType");
				changeOrder.Pipelines = _ctx.StringValue("ListNamespaceChangeOrders.Data.ChangeOrderList["+ i +"].Pipelines");

				data_changeOrderList.Add(changeOrder);
			}
			data.ChangeOrderList = data_changeOrderList;
			listNamespaceChangeOrdersResponse.Data = data;
        
			return listNamespaceChangeOrdersResponse;
        }
    }
}
