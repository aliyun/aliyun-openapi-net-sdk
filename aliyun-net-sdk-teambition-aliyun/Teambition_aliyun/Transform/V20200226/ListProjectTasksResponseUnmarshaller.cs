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
using Aliyun.Acs.teambition_aliyun.Model.V20200226;

namespace Aliyun.Acs.teambition_aliyun.Transform.V20200226
{
    public class ListProjectTasksResponseUnmarshaller
    {
        public static ListProjectTasksResponse Unmarshall(UnmarshallerContext context)
        {
			ListProjectTasksResponse listProjectTasksResponse = new ListProjectTasksResponse();

			listProjectTasksResponse.HttpResponse = context.HttpResponse;
			listProjectTasksResponse.Successful = context.BooleanValue("ListProjectTasks.Successful");
			listProjectTasksResponse.ErrorCode = context.StringValue("ListProjectTasks.ErrorCode");
			listProjectTasksResponse.ErrorMsg = context.StringValue("ListProjectTasks.ErrorMsg");
			listProjectTasksResponse.RequestId = context.StringValue("ListProjectTasks.RequestId");

			List<ListProjectTasksResponse.ListProjectTasks_Task> listProjectTasksResponse_object = new List<ListProjectTasksResponse.ListProjectTasks_Task>();
			for (int i = 0; i < context.Length("ListProjectTasks.Object.Length"); i++) {
				ListProjectTasksResponse.ListProjectTasks_Task task = new ListProjectTasksResponse.ListProjectTasks_Task();
				task.TasklistId = context.StringValue("ListProjectTasks.Object["+ i +"].TasklistId");
				task.ProjectId = context.StringValue("ListProjectTasks.Object["+ i +"].ProjectId");
				task.TaskgroupId = context.StringValue("ListProjectTasks.Object["+ i +"].TaskgroupId");
				task.Name = context.StringValue("ListProjectTasks.Object["+ i +"].Name");
				task.CreatorId = context.StringValue("ListProjectTasks.Object["+ i +"].CreatorId");
				task.Created = context.StringValue("ListProjectTasks.Object["+ i +"].Created");
				task.ModifierId = context.StringValue("ListProjectTasks.Object["+ i +"].ModifierId");
				task.Updated = context.StringValue("ListProjectTasks.Object["+ i +"].Updated");
				task.Id = context.StringValue("ListProjectTasks.Object["+ i +"].Id");

				listProjectTasksResponse_object.Add(task);
			}
			listProjectTasksResponse._Object = listProjectTasksResponse_object;
        
			return listProjectTasksResponse;
        }
    }
}
