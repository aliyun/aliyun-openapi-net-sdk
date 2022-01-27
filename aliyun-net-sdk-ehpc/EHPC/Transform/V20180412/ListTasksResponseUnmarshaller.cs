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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListTasksResponseUnmarshaller
    {
        public static ListTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTasksResponse listTasksResponse = new ListTasksResponse();

			listTasksResponse.HttpResponse = _ctx.HttpResponse;
			listTasksResponse.RequestId = _ctx.StringValue("ListTasks.RequestId");
			listTasksResponse.TotalCount = _ctx.IntegerValue("ListTasks.TotalCount");
			listTasksResponse.PageNumber = _ctx.IntegerValue("ListTasks.PageNumber");
			listTasksResponse.PageSize = _ctx.IntegerValue("ListTasks.PageSize");

			List<ListTasksResponse.ListTasks_TaskInfo> listTasksResponse_tasks = new List<ListTasksResponse.ListTasks_TaskInfo>();
			for (int i = 0; i < _ctx.Length("ListTasks.Tasks.Length"); i++) {
				ListTasksResponse.ListTasks_TaskInfo taskInfo = new ListTasksResponse.ListTasks_TaskInfo();
				taskInfo.TaskId = _ctx.StringValue("ListTasks.Tasks["+ i +"].TaskId");
				taskInfo.TaskType = _ctx.StringValue("ListTasks.Tasks["+ i +"].TaskType");
				taskInfo.ClusterId = _ctx.StringValue("ListTasks.Tasks["+ i +"].ClusterId");
				taskInfo.Request = _ctx.StringValue("ListTasks.Tasks["+ i +"].Request");
				taskInfo.Status = _ctx.StringValue("ListTasks.Tasks["+ i +"].Status");
				taskInfo.CurrentStep = _ctx.IntegerValue("ListTasks.Tasks["+ i +"].CurrentStep");
				taskInfo.TotalSteps = _ctx.IntegerValue("ListTasks.Tasks["+ i +"].TotalSteps");
				taskInfo.Result = _ctx.StringValue("ListTasks.Tasks["+ i +"].Result");
				taskInfo.Errors = _ctx.StringValue("ListTasks.Tasks["+ i +"].Errors");

				listTasksResponse_tasks.Add(taskInfo);
			}
			listTasksResponse.Tasks = listTasksResponse_tasks;
        
			return listTasksResponse;
        }
    }
}
