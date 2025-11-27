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
using Aliyun.Acs.PaiFeatureStore.Model.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Transform.V20230621
{
    public class ListTasksResponseUnmarshaller
    {
        public static ListTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTasksResponse listTasksResponse = new ListTasksResponse();

			listTasksResponse.HttpResponse = _ctx.HttpResponse;
			listTasksResponse.RequestId = _ctx.StringValue("ListTasks.RequestId");
			listTasksResponse.TotalCount = _ctx.IntegerValue("ListTasks.TotalCount");

			List<ListTasksResponse.ListTasks_TasksItem> listTasksResponse_tasks = new List<ListTasksResponse.ListTasks_TasksItem>();
			for (int i = 0; i < _ctx.Length("ListTasks.Tasks.Length"); i++) {
				ListTasksResponse.ListTasks_TasksItem tasksItem = new ListTasksResponse.ListTasks_TasksItem();
				tasksItem.GmtCreateTime = _ctx.StringValue("ListTasks.Tasks["+ i +"].GmtCreateTime");
				tasksItem.GmtExecutedTime = _ctx.StringValue("ListTasks.Tasks["+ i +"].GmtExecutedTime");
				tasksItem.GmtFinishedTime = _ctx.StringValue("ListTasks.Tasks["+ i +"].GmtFinishedTime");
				tasksItem.ObjectId = _ctx.StringValue("ListTasks.Tasks["+ i +"].ObjectId");
				tasksItem.ObjectType = _ctx.StringValue("ListTasks.Tasks["+ i +"].ObjectType");
				tasksItem.ProjectId = _ctx.StringValue("ListTasks.Tasks["+ i +"].ProjectId");
				tasksItem.ProjectName = _ctx.StringValue("ListTasks.Tasks["+ i +"].ProjectName");
				tasksItem.Status = _ctx.StringValue("ListTasks.Tasks["+ i +"].Status");
				tasksItem.TaskId = _ctx.StringValue("ListTasks.Tasks["+ i +"].TaskId");
				tasksItem.Type = _ctx.StringValue("ListTasks.Tasks["+ i +"].Type");

				listTasksResponse_tasks.Add(tasksItem);
			}
			listTasksResponse.Tasks = listTasksResponse_tasks;
        
			return listTasksResponse;
        }
    }
}
