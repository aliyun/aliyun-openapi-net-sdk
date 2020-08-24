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
    public class CreateDevopsProjectTaskResponseUnmarshaller
    {
        public static CreateDevopsProjectTaskResponse Unmarshall(UnmarshallerContext context)
        {
			CreateDevopsProjectTaskResponse createDevopsProjectTaskResponse = new CreateDevopsProjectTaskResponse();

			createDevopsProjectTaskResponse.HttpResponse = context.HttpResponse;
			createDevopsProjectTaskResponse.Successful = context.BooleanValue("CreateDevopsProjectTask.Successful");
			createDevopsProjectTaskResponse.ErrorCode = context.StringValue("CreateDevopsProjectTask.ErrorCode");
			createDevopsProjectTaskResponse.ErrorMsg = context.StringValue("CreateDevopsProjectTask.ErrorMsg");
			createDevopsProjectTaskResponse.RequestId = context.StringValue("CreateDevopsProjectTask.RequestId");

			CreateDevopsProjectTaskResponse.CreateDevopsProjectTask__Object _object = new CreateDevopsProjectTaskResponse.CreateDevopsProjectTask__Object();
			_object.Note = context.StringValue("CreateDevopsProjectTask.Object.Note");
			_object.TasklistId = context.StringValue("CreateDevopsProjectTask.Object.TasklistId");
			_object.DueDate = context.StringValue("CreateDevopsProjectTask.Object.DueDate");
			_object.Rating = context.IntegerValue("CreateDevopsProjectTask.Object.Rating");
			_object.Source = context.StringValue("CreateDevopsProjectTask.Object.Source");
			_object.Content = context.StringValue("CreateDevopsProjectTask.Object.Content");
			_object.TaskflowstatusId = context.StringValue("CreateDevopsProjectTask.Object.TaskflowstatusId");
			_object.TaskType = context.StringValue("CreateDevopsProjectTask.Object.TaskType");
			_object.ScenarioFieldConfigId = context.StringValue("CreateDevopsProjectTask.Object.ScenarioFieldConfigId");
			_object.Pos = context.IntegerValue("CreateDevopsProjectTask.Object.Pos");
			_object.AncestorIds = context.StringValue("CreateDevopsProjectTask.Object.AncestorIds");
			_object.CreatorId = context.StringValue("CreateDevopsProjectTask.Object.CreatorId");
			_object.Visible = context.StringValue("CreateDevopsProjectTask.Object.Visible");
			_object.ExecutorId = context.StringValue("CreateDevopsProjectTask.Object.ExecutorId");
			_object.StoryPoint = context.StringValue("CreateDevopsProjectTask.Object.StoryPoint");
			_object.Created = context.StringValue("CreateDevopsProjectTask.Object.Created");
			_object.OrganizationId = context.StringValue("CreateDevopsProjectTask.Object.OrganizationId");
			_object.Priority = context.IntegerValue("CreateDevopsProjectTask.Object.Priority");
			_object.IsDone = context.BooleanValue("CreateDevopsProjectTask.Object.IsDone");
			_object.Id = context.StringValue("CreateDevopsProjectTask.Object.Id");
			_object.Updated = context.StringValue("CreateDevopsProjectTask.Object.Updated");
			_object.UniqueId = context.IntegerValue("CreateDevopsProjectTask.Object.UniqueId");
			_object.StartDate = context.StringValue("CreateDevopsProjectTask.Object.StartDate");
			_object.SprintId = context.StringValue("CreateDevopsProjectTask.Object.SprintId");
			_object.ProjectId = context.StringValue("CreateDevopsProjectTask.Object.ProjectId");
			createDevopsProjectTaskResponse._Object = _object;
        
			return createDevopsProjectTaskResponse;
        }
    }
}
