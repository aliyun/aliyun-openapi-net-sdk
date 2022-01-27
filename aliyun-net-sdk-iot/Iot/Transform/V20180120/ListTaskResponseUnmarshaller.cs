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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class ListTaskResponseUnmarshaller
    {
        public static ListTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTaskResponse listTaskResponse = new ListTaskResponse();

			listTaskResponse.HttpResponse = _ctx.HttpResponse;
			listTaskResponse.RequestId = _ctx.StringValue("ListTask.RequestId");
			listTaskResponse.Success = _ctx.BooleanValue("ListTask.Success");
			listTaskResponse.Code = _ctx.StringValue("ListTask.Code");
			listTaskResponse.ErrorMessage = _ctx.StringValue("ListTask.ErrorMessage");
			listTaskResponse.NextToken = _ctx.StringValue("ListTask.NextToken");

			List<ListTaskResponse.ListTask_DataItem> listTaskResponse_data = new List<ListTaskResponse.ListTask_DataItem>();
			for (int i = 0; i < _ctx.Length("ListTask.Data.Length"); i++) {
				ListTaskResponse.ListTask_DataItem dataItem = new ListTaskResponse.ListTask_DataItem();
				dataItem.JobId = _ctx.StringValue("ListTask.Data["+ i +"].JobId");
				dataItem.JobName = _ctx.StringValue("ListTask.Data["+ i +"].JobName");
				dataItem.TaskId = _ctx.StringValue("ListTask.Data["+ i +"].TaskId");
				dataItem.ProductKey = _ctx.StringValue("ListTask.Data["+ i +"].ProductKey");
				dataItem.DeviceName = _ctx.StringValue("ListTask.Data["+ i +"].DeviceName");
				dataItem.IotId = _ctx.StringValue("ListTask.Data["+ i +"].IotId");
				dataItem.Progress = _ctx.StringValue("ListTask.Data["+ i +"].Progress");
				dataItem.UtcQueueTime = _ctx.StringValue("ListTask.Data["+ i +"].UtcQueueTime");
				dataItem.UtcModified = _ctx.StringValue("ListTask.Data["+ i +"].UtcModified");
				dataItem.Status = _ctx.StringValue("ListTask.Data["+ i +"].Status");

				listTaskResponse_data.Add(dataItem);
			}
			listTaskResponse.Data = listTaskResponse_data;
        
			return listTaskResponse;
        }
    }
}
