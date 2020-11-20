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
        public static ListChangeOrdersResponse Unmarshall(UnmarshallerContext context)
        {
			ListChangeOrdersResponse listChangeOrdersResponse = new ListChangeOrdersResponse();

			listChangeOrdersResponse.HttpResponse = context.HttpResponse;
			listChangeOrdersResponse.RequestId = context.StringValue("ListChangeOrders.RequestId");
			listChangeOrdersResponse.Code = context.StringValue("ListChangeOrders.Code");
			listChangeOrdersResponse.Message = context.StringValue("ListChangeOrders.Message");
			listChangeOrdersResponse.Success = context.BooleanValue("ListChangeOrders.Success");
			listChangeOrdersResponse.ErrorCode = context.StringValue("ListChangeOrders.ErrorCode");
			listChangeOrdersResponse.TraceId = context.StringValue("ListChangeOrders.TraceId");

			ListChangeOrdersResponse.ListChangeOrders_Data data = new ListChangeOrdersResponse.ListChangeOrders_Data();
			data.CurrentPage = context.IntegerValue("ListChangeOrders.Data.CurrentPage");
			data.PageSize = context.IntegerValue("ListChangeOrders.Data.PageSize");
			data.TotalSize = context.IntegerValue("ListChangeOrders.Data.TotalSize");

			List<ListChangeOrdersResponse.ListChangeOrders_Data.ListChangeOrders_ChangeOrder> data_changeOrderList = new List<ListChangeOrdersResponse.ListChangeOrders_Data.ListChangeOrders_ChangeOrder>();
			for (int i = 0; i < context.Length("ListChangeOrders.Data.ChangeOrderList.Length"); i++) {
				ListChangeOrdersResponse.ListChangeOrders_Data.ListChangeOrders_ChangeOrder changeOrder = new ListChangeOrdersResponse.ListChangeOrders_Data.ListChangeOrders_ChangeOrder();
				changeOrder.AppId = context.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].AppId");
				changeOrder.BatchCount = context.IntegerValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].BatchCount");
				changeOrder.BatchType = context.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].BatchType");
				changeOrder.ChangeOrderId = context.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].ChangeOrderId");
				changeOrder.CoType = context.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].CoType");
				changeOrder.CoTypeCode = context.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].CoTypeCode");
				changeOrder.CreateTime = context.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].CreateTime");
				changeOrder.Description = context.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].Description");
				changeOrder.FinishTime = context.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].FinishTime");
				changeOrder.GroupId = context.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].GroupId");
				changeOrder.Pipelines = context.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].Pipelines");
				changeOrder.Source = context.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].Source");
				changeOrder.Status = context.IntegerValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].Status");
				changeOrder.UserId = context.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].UserId");
				changeOrder.CreateUserId = context.StringValue("ListChangeOrders.Data.ChangeOrderList["+ i +"].CreateUserId");

				data_changeOrderList.Add(changeOrder);
			}
			data.ChangeOrderList = data_changeOrderList;
			listChangeOrdersResponse.Data = data;
        
			return listChangeOrdersResponse;
        }
    }
}
