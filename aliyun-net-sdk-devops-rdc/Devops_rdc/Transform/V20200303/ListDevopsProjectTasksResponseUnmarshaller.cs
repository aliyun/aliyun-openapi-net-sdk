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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class ListDevopsProjectTasksResponseUnmarshaller
    {
        public static ListDevopsProjectTasksResponse Unmarshall(UnmarshallerContext context)
        {
			ListDevopsProjectTasksResponse listDevopsProjectTasksResponse = new ListDevopsProjectTasksResponse();

			listDevopsProjectTasksResponse.HttpResponse = context.HttpResponse;
			listDevopsProjectTasksResponse.Successful = context.BooleanValue("ListDevopsProjectTasks.Successful");
			listDevopsProjectTasksResponse.ErrorCode = context.StringValue("ListDevopsProjectTasks.ErrorCode");
			listDevopsProjectTasksResponse.ErrorMsg = context.StringValue("ListDevopsProjectTasks.ErrorMsg");
			listDevopsProjectTasksResponse.RequestId = context.StringValue("ListDevopsProjectTasks.RequestId");

			List<ListDevopsProjectTasksResponse.ListDevopsProjectTasks_Task> listDevopsProjectTasksResponse_object = new List<ListDevopsProjectTasksResponse.ListDevopsProjectTasks_Task>();
			for (int i = 0; i < context.Length("ListDevopsProjectTasks.Object.Length"); i++) {
				ListDevopsProjectTasksResponse.ListDevopsProjectTasks_Task task = new ListDevopsProjectTasksResponse.ListDevopsProjectTasks_Task();
				task.TasklistId = context.StringValue("ListDevopsProjectTasks.Object["+ i +"].TasklistId");
				task.ProjectId = context.StringValue("ListDevopsProjectTasks.Object["+ i +"].ProjectId");
				task.TaskgroupId = context.StringValue("ListDevopsProjectTasks.Object["+ i +"].TaskgroupId");
				task.Name = context.StringValue("ListDevopsProjectTasks.Object["+ i +"].Name");
				task.CreatorId = context.StringValue("ListDevopsProjectTasks.Object["+ i +"].CreatorId");
				task.Created = context.StringValue("ListDevopsProjectTasks.Object["+ i +"].Created");
				task.ModifierId = context.StringValue("ListDevopsProjectTasks.Object["+ i +"].ModifierId");
				task.Updated = context.StringValue("ListDevopsProjectTasks.Object["+ i +"].Updated");
				task.Id = context.StringValue("ListDevopsProjectTasks.Object["+ i +"].Id");

				listDevopsProjectTasksResponse_object.Add(task);
			}
			listDevopsProjectTasksResponse._Object = listDevopsProjectTasksResponse_object;
        
			return listDevopsProjectTasksResponse;
        }
    }
}
