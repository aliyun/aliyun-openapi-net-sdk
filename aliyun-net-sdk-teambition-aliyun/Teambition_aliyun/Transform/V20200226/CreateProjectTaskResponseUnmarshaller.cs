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
    public class CreateProjectTaskResponseUnmarshaller
    {
        public static CreateProjectTaskResponse Unmarshall(UnmarshallerContext context)
        {
			CreateProjectTaskResponse createProjectTaskResponse = new CreateProjectTaskResponse();

			createProjectTaskResponse.HttpResponse = context.HttpResponse;
			createProjectTaskResponse.Successful = context.BooleanValue("CreateProjectTask.Successful");
			createProjectTaskResponse.ErrorCode = context.StringValue("CreateProjectTask.ErrorCode");
			createProjectTaskResponse.ErrorMsg = context.StringValue("CreateProjectTask.ErrorMsg");
			createProjectTaskResponse.RequestId = context.StringValue("CreateProjectTask.RequestId");

			CreateProjectTaskResponse.CreateProjectTask__Object _object = new CreateProjectTaskResponse.CreateProjectTask__Object();
			_object.Note = context.StringValue("CreateProjectTask.Object.Note");
			_object.TasklistId = context.StringValue("CreateProjectTask.Object.TasklistId");
			_object.DueDate = context.StringValue("CreateProjectTask.Object.DueDate");
			_object.Rating = context.IntegerValue("CreateProjectTask.Object.Rating");
			_object.Source = context.StringValue("CreateProjectTask.Object.Source");
			_object.Content = context.StringValue("CreateProjectTask.Object.Content");
			_object.TaskflowstatusId = context.StringValue("CreateProjectTask.Object.TaskflowstatusId");
			_object.TaskType = context.StringValue("CreateProjectTask.Object.TaskType");
			_object.ScenarioFieldConfigId = context.StringValue("CreateProjectTask.Object.ScenarioFieldConfigId");
			_object.Pos = context.IntegerValue("CreateProjectTask.Object.Pos");
			_object.AncestorIds = context.StringValue("CreateProjectTask.Object.AncestorIds");
			_object.CreatorId = context.StringValue("CreateProjectTask.Object.CreatorId");
			_object.Visible = context.StringValue("CreateProjectTask.Object.Visible");
			_object.ExecutorId = context.StringValue("CreateProjectTask.Object.ExecutorId");
			_object.StoryPoint = context.StringValue("CreateProjectTask.Object.StoryPoint");
			_object.Created = context.StringValue("CreateProjectTask.Object.Created");
			_object.OrganizationId = context.StringValue("CreateProjectTask.Object.OrganizationId");
			_object.Priority = context.IntegerValue("CreateProjectTask.Object.Priority");
			_object.IsDone = context.BooleanValue("CreateProjectTask.Object.IsDone");
			_object.Id = context.StringValue("CreateProjectTask.Object.Id");
			_object.Updated = context.StringValue("CreateProjectTask.Object.Updated");
			_object.UniqueId = context.IntegerValue("CreateProjectTask.Object.UniqueId");
			_object.StartDate = context.StringValue("CreateProjectTask.Object.StartDate");
			_object.SprintId = context.StringValue("CreateProjectTask.Object.SprintId");
			_object.ProjectId = context.StringValue("CreateProjectTask.Object.ProjectId");
			createProjectTaskResponse._Object = _object;
        
			return createProjectTaskResponse;
        }
    }
}
