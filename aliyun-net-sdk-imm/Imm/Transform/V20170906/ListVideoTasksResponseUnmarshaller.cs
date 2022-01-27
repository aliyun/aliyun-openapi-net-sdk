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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListVideoTasksResponseUnmarshaller
    {
        public static ListVideoTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVideoTasksResponse listVideoTasksResponse = new ListVideoTasksResponse();

			listVideoTasksResponse.HttpResponse = _ctx.HttpResponse;
			listVideoTasksResponse.RequestId = _ctx.StringValue("ListVideoTasks.RequestId");
			listVideoTasksResponse.NextMarker = _ctx.StringValue("ListVideoTasks.NextMarker");

			List<ListVideoTasksResponse.ListVideoTasks_TasksItem> listVideoTasksResponse_tasks = new List<ListVideoTasksResponse.ListVideoTasks_TasksItem>();
			for (int i = 0; i < _ctx.Length("ListVideoTasks.Tasks.Length"); i++) {
				ListVideoTasksResponse.ListVideoTasks_TasksItem tasksItem = new ListVideoTasksResponse.ListVideoTasks_TasksItem();
				tasksItem.Status = _ctx.StringValue("ListVideoTasks.Tasks["+ i +"].Status");
				tasksItem.TaskId = _ctx.StringValue("ListVideoTasks.Tasks["+ i +"].TaskId");
				tasksItem.TaskType = _ctx.StringValue("ListVideoTasks.Tasks["+ i +"].TaskType");
				tasksItem.Parameters = _ctx.StringValue("ListVideoTasks.Tasks["+ i +"].Parameters");
				tasksItem.Result = _ctx.StringValue("ListVideoTasks.Tasks["+ i +"].Result");
				tasksItem.StartTime = _ctx.StringValue("ListVideoTasks.Tasks["+ i +"].StartTime");
				tasksItem.EndTime = _ctx.StringValue("ListVideoTasks.Tasks["+ i +"].EndTime");
				tasksItem.ErrorMessage = _ctx.StringValue("ListVideoTasks.Tasks["+ i +"].ErrorMessage");
				tasksItem.NotifyEndpoint = _ctx.StringValue("ListVideoTasks.Tasks["+ i +"].NotifyEndpoint");
				tasksItem.NotifyTopicName = _ctx.StringValue("ListVideoTasks.Tasks["+ i +"].NotifyTopicName");
				tasksItem.Progress = _ctx.IntegerValue("ListVideoTasks.Tasks["+ i +"].Progress");

				listVideoTasksResponse_tasks.Add(tasksItem);
			}
			listVideoTasksResponse.Tasks = listVideoTasksResponse_tasks;
        
			return listVideoTasksResponse;
        }
    }
}
