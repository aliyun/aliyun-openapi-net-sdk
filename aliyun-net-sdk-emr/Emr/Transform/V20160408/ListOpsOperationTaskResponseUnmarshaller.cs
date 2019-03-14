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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListOpsOperationTaskResponseUnmarshaller
    {
        public static ListOpsOperationTaskResponse Unmarshall(UnmarshallerContext context)
        {
			ListOpsOperationTaskResponse listOpsOperationTaskResponse = new ListOpsOperationTaskResponse();

			listOpsOperationTaskResponse.HttpResponse = context.HttpResponse;
			listOpsOperationTaskResponse.RequestId = context.StringValue("ListOpsOperationTask.RequestId");
			listOpsOperationTaskResponse.Total = context.IntegerValue("ListOpsOperationTask.Total");
			listOpsOperationTaskResponse.PageNumber = context.IntegerValue("ListOpsOperationTask.PageNumber");
			listOpsOperationTaskResponse.PageSize = context.IntegerValue("ListOpsOperationTask.PageSize");

			List<ListOpsOperationTaskResponse.ListOpsOperationTask_TaskListItem> listOpsOperationTaskResponse_taskList = new List<ListOpsOperationTaskResponse.ListOpsOperationTask_TaskListItem>();
			for (int i = 0; i < context.Length("ListOpsOperationTask.TaskList.Length"); i++) {
				ListOpsOperationTaskResponse.ListOpsOperationTask_TaskListItem taskListItem = new ListOpsOperationTaskResponse.ListOpsOperationTask_TaskListItem();
				taskListItem.Id = context.LongValue("ListOpsOperationTask.TaskList["+ i +"].Id");
				taskListItem.OpsOperationId = context.LongValue("ListOpsOperationTask.TaskList["+ i +"].OpsOperationId");
				taskListItem.TaskId = context.LongValue("ListOpsOperationTask.TaskList["+ i +"].TaskId");
				taskListItem.Status = context.StringValue("ListOpsOperationTask.TaskList["+ i +"].Status");
				taskListItem.RegionId = context.StringValue("ListOpsOperationTask.TaskList["+ i +"].RegionId");
				taskListItem.UserId = context.StringValue("ListOpsOperationTask.TaskList["+ i +"].UserId");
				taskListItem.ClusterId = context.LongValue("ListOpsOperationTask.TaskList["+ i +"].ClusterId");
				taskListItem.ExternalClusterId = context.StringValue("ListOpsOperationTask.TaskList["+ i +"].ExternalClusterId");
				taskListItem.HostId = context.LongValue("ListOpsOperationTask.TaskList["+ i +"].HostId");
				taskListItem.StartTime = context.StringValue("ListOpsOperationTask.TaskList["+ i +"].StartTime");
				taskListItem.EndTime = context.StringValue("ListOpsOperationTask.TaskList["+ i +"].EndTime");
				taskListItem.CommandName = context.StringValue("ListOpsOperationTask.TaskList["+ i +"].CommandName");
				taskListItem.HostName = context.StringValue("ListOpsOperationTask.TaskList["+ i +"].HostName");

				listOpsOperationTaskResponse_taskList.Add(taskListItem);
			}
			listOpsOperationTaskResponse.TaskList = listOpsOperationTaskResponse_taskList;
        
			return listOpsOperationTaskResponse;
        }
    }
}
