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
    public class ListTakeStockOrderTasksResponseUnmarshaller
    {
        public static ListTakeStockOrderTasksResponse Unmarshall(UnmarshallerContext context)
        {
			ListTakeStockOrderTasksResponse listTakeStockOrderTasksResponse = new ListTakeStockOrderTasksResponse();

			listTakeStockOrderTasksResponse.HttpResponse = context.HttpResponse;
			listTakeStockOrderTasksResponse.PageSize = context.IntegerValue("ListTakeStockOrderTasks.PageSize");
			listTakeStockOrderTasksResponse.TotalCount = context.IntegerValue("ListTakeStockOrderTasks.TotalCount");
			listTakeStockOrderTasksResponse.PageNumber = context.IntegerValue("ListTakeStockOrderTasks.PageNumber");
			listTakeStockOrderTasksResponse.RequestId = context.StringValue("ListTakeStockOrderTasks.RequestId");
			listTakeStockOrderTasksResponse.Success = context.BooleanValue("ListTakeStockOrderTasks.Success");

			List<ListTakeStockOrderTasksResponse.ListTakeStockOrderTasks_TakeStockOrderTaskModel> listTakeStockOrderTasksResponse_takeStockOrderTasks = new List<ListTakeStockOrderTasksResponse.ListTakeStockOrderTasks_TakeStockOrderTaskModel>();
			for (int i = 0; i < context.Length("ListTakeStockOrderTasks.TakeStockOrderTasks.Length"); i++) {
				ListTakeStockOrderTasksResponse.ListTakeStockOrderTasks_TakeStockOrderTaskModel takeStockOrderTaskModel = new ListTakeStockOrderTasksResponse.ListTakeStockOrderTasks_TakeStockOrderTaskModel();
				takeStockOrderTaskModel.DeviceNumber = context.StringValue("ListTakeStockOrderTasks.TakeStockOrderTasks["+ i +"].DeviceNumber");
				takeStockOrderTaskModel.CreateDate = context.StringValue("ListTakeStockOrderTasks.TakeStockOrderTasks["+ i +"].CreateDate");
				takeStockOrderTaskModel.OperateQuantity = context.IntegerValue("ListTakeStockOrderTasks.TakeStockOrderTasks["+ i +"].OperateQuantity");
				takeStockOrderTaskModel.Status = context.StringValue("ListTakeStockOrderTasks.TakeStockOrderTasks["+ i +"].Status");
				takeStockOrderTaskModel.TakeStockTaskId = context.StringValue("ListTakeStockOrderTasks.TakeStockOrderTasks["+ i +"].TakeStockTaskId");
				takeStockOrderTaskModel.SyncStatus = context.StringValue("ListTakeStockOrderTasks.TakeStockOrderTasks["+ i +"].SyncStatus");
				takeStockOrderTaskModel.Description = context.StringValue("ListTakeStockOrderTasks.TakeStockOrderTasks["+ i +"].Description");
				takeStockOrderTaskModel.TakeStockOrderId = context.StringValue("ListTakeStockOrderTasks.TakeStockOrderTasks["+ i +"].TakeStockOrderId");
				takeStockOrderTaskModel.Code = context.StringValue("ListTakeStockOrderTasks.TakeStockOrderTasks["+ i +"].Code");
				takeStockOrderTaskModel.UpdateDate = context.StringValue("ListTakeStockOrderTasks.TakeStockOrderTasks["+ i +"].UpdateDate");

				listTakeStockOrderTasksResponse_takeStockOrderTasks.Add(takeStockOrderTaskModel);
			}
			listTakeStockOrderTasksResponse.TakeStockOrderTasks = listTakeStockOrderTasksResponse_takeStockOrderTasks;
        
			return listTakeStockOrderTasksResponse;
        }
    }
}
