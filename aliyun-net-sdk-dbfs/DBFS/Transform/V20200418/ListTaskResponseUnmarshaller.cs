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
using Aliyun.Acs.DBFS.Model.V20200418;

namespace Aliyun.Acs.DBFS.Transform.V20200418
{
    public class ListTaskResponseUnmarshaller
    {
        public static ListTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTaskResponse listTaskResponse = new ListTaskResponse();

			listTaskResponse.HttpResponse = _ctx.HttpResponse;
			listTaskResponse.RequestId = _ctx.StringValue("ListTask.RequestId");
			listTaskResponse.TotalCount = _ctx.IntegerValue("ListTask.TotalCount");
			listTaskResponse.PageNumber = _ctx.IntegerValue("ListTask.PageNumber");
			listTaskResponse.PageSize = _ctx.IntegerValue("ListTask.PageSize");

			List<ListTaskResponse.ListTask_TasksItem> listTaskResponse_tasks = new List<ListTaskResponse.ListTask_TasksItem>();
			for (int i = 0; i < _ctx.Length("ListTask.Tasks.Length"); i++) {
				ListTaskResponse.ListTask_TasksItem tasksItem = new ListTaskResponse.ListTask_TasksItem();
				tasksItem.Id = _ctx.IntegerValue("ListTask.Tasks["+ i +"].Id");
				tasksItem.TaskName = _ctx.StringValue("ListTask.Tasks["+ i +"].TaskName");
				tasksItem.TaskType = _ctx.StringValue("ListTask.Tasks["+ i +"].TaskType");
				tasksItem.TaskOwner = _ctx.StringValue("ListTask.Tasks["+ i +"].TaskOwner");
				tasksItem.TaskAdder = _ctx.StringValue("ListTask.Tasks["+ i +"].TaskAdder");
				tasksItem.TaskRunner = _ctx.StringValue("ListTask.Tasks["+ i +"].TaskRunner");
				tasksItem.TaskProgress = _ctx.IntegerValue("ListTask.Tasks["+ i +"].TaskProgress");
				tasksItem.TaskProgressDescription = _ctx.StringValue("ListTask.Tasks["+ i +"].TaskProgressDescription");
				tasksItem.TaskStatus = _ctx.StringValue("ListTask.Tasks["+ i +"].TaskStatus");
				tasksItem.ClientToken = _ctx.StringValue("ListTask.Tasks["+ i +"].ClientToken");
				tasksItem.CreatedTime = _ctx.StringValue("ListTask.Tasks["+ i +"].CreatedTime");
				tasksItem.CompletionTime = _ctx.StringValue("ListTask.Tasks["+ i +"].CompletionTime");
				tasksItem.Priority = _ctx.StringValue("ListTask.Tasks["+ i +"].Priority");
				tasksItem.MaxRetry = _ctx.IntegerValue("ListTask.Tasks["+ i +"].MaxRetry");
				tasksItem.NextExecutionTime = _ctx.StringValue("ListTask.Tasks["+ i +"].NextExecutionTime");
				tasksItem.TaskExecutionCounts = _ctx.IntegerValue("ListTask.Tasks["+ i +"].TaskExecutionCounts");
				tasksItem.TaskErrorReason = _ctx.StringValue("ListTask.Tasks["+ i +"].TaskErrorReason");
				tasksItem.TaskStatusCode = _ctx.IntegerValue("ListTask.Tasks["+ i +"].TaskStatusCode");

				listTaskResponse_tasks.Add(tasksItem);
			}
			listTaskResponse.Tasks = listTaskResponse_tasks;
        
			return listTaskResponse;
        }
    }
}
