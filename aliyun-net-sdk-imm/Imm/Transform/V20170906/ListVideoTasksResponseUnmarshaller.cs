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
        public static ListVideoTasksResponse Unmarshall(UnmarshallerContext context)
        {
			ListVideoTasksResponse listVideoTasksResponse = new ListVideoTasksResponse();

			listVideoTasksResponse.HttpResponse = context.HttpResponse;
			listVideoTasksResponse.RequestId = context.StringValue("ListVideoTasks.RequestId");
			listVideoTasksResponse.NextMarker = context.StringValue("ListVideoTasks.NextMarker");

			List<ListVideoTasksResponse.ListVideoTasks_TasksItem> listVideoTasksResponse_tasks = new List<ListVideoTasksResponse.ListVideoTasks_TasksItem>();
			for (int i = 0; i < context.Length("ListVideoTasks.Tasks.Length"); i++) {
				ListVideoTasksResponse.ListVideoTasks_TasksItem tasksItem = new ListVideoTasksResponse.ListVideoTasks_TasksItem();
				tasksItem.Status = context.StringValue("ListVideoTasks.Tasks["+ i +"].Status");
				tasksItem.TaskId = context.StringValue("ListVideoTasks.Tasks["+ i +"].TaskId");
				tasksItem.TaskType = context.StringValue("ListVideoTasks.Tasks["+ i +"].TaskType");
				tasksItem.Parameters = context.StringValue("ListVideoTasks.Tasks["+ i +"].Parameters");
				tasksItem.Result = context.StringValue("ListVideoTasks.Tasks["+ i +"].Result");
				tasksItem.StartTime = context.StringValue("ListVideoTasks.Tasks["+ i +"].StartTime");
				tasksItem.EndTime = context.StringValue("ListVideoTasks.Tasks["+ i +"].EndTime");
				tasksItem.ErrorMessage = context.StringValue("ListVideoTasks.Tasks["+ i +"].ErrorMessage");
				tasksItem.NotifyEndpoint = context.StringValue("ListVideoTasks.Tasks["+ i +"].NotifyEndpoint");
				tasksItem.NotifyTopicName = context.StringValue("ListVideoTasks.Tasks["+ i +"].NotifyTopicName");
				tasksItem.Progress = context.IntegerValue("ListVideoTasks.Tasks["+ i +"].Progress");

				listVideoTasksResponse_tasks.Add(tasksItem);
			}
			listVideoTasksResponse.Tasks = listVideoTasksResponse_tasks;
        
			return listVideoTasksResponse;
        }
    }
}
