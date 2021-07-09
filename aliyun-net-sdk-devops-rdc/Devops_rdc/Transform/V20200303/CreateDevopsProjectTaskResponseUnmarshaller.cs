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
        public static CreateDevopsProjectTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateDevopsProjectTaskResponse createDevopsProjectTaskResponse = new CreateDevopsProjectTaskResponse();

			createDevopsProjectTaskResponse.HttpResponse = _ctx.HttpResponse;
			createDevopsProjectTaskResponse.ErrorMsg = _ctx.StringValue("CreateDevopsProjectTask.ErrorMsg");
			createDevopsProjectTaskResponse.RequestId = _ctx.StringValue("CreateDevopsProjectTask.RequestId");
			createDevopsProjectTaskResponse.Successful = _ctx.BooleanValue("CreateDevopsProjectTask.Successful");
			createDevopsProjectTaskResponse.ErrorCode = _ctx.StringValue("CreateDevopsProjectTask.ErrorCode");

			CreateDevopsProjectTaskResponse.CreateDevopsProjectTask__Object _object = new CreateDevopsProjectTaskResponse.CreateDevopsProjectTask__Object();
			_object.ExecutorId = _ctx.StringValue("CreateDevopsProjectTask.Object.ExecutorId");
			_object.ProjectId = _ctx.StringValue("CreateDevopsProjectTask.Object.ProjectId");
			_object.Priority = _ctx.IntegerValue("CreateDevopsProjectTask.Object.Priority");
			_object.ScenarioFieldConfigId = _ctx.StringValue("CreateDevopsProjectTask.Object.ScenarioFieldConfigId");
			_object.AncestorIds = _ctx.StringValue("CreateDevopsProjectTask.Object.AncestorIds");
			_object.TaskType = _ctx.StringValue("CreateDevopsProjectTask.Object.TaskType");
			_object.TasklistId = _ctx.StringValue("CreateDevopsProjectTask.Object.TasklistId");
			_object.TaskflowstatusId = _ctx.StringValue("CreateDevopsProjectTask.Object.TaskflowstatusId");
			_object.Note = _ctx.StringValue("CreateDevopsProjectTask.Object.Note");
			_object.Updated = _ctx.StringValue("CreateDevopsProjectTask.Object.Updated");
			_object.UniqueId = _ctx.IntegerValue("CreateDevopsProjectTask.Object.UniqueId");
			_object.Content = _ctx.StringValue("CreateDevopsProjectTask.Object.Content");
			_object.Rating = _ctx.IntegerValue("CreateDevopsProjectTask.Object.Rating");
			_object.Pos = _ctx.IntegerValue("CreateDevopsProjectTask.Object.Pos");
			_object.StoryPoint = _ctx.StringValue("CreateDevopsProjectTask.Object.StoryPoint");
			_object.StartDate = _ctx.StringValue("CreateDevopsProjectTask.Object.StartDate");
			_object.CreatorId = _ctx.StringValue("CreateDevopsProjectTask.Object.CreatorId");
			_object.Source = _ctx.StringValue("CreateDevopsProjectTask.Object.Source");
			_object.OrganizationId = _ctx.StringValue("CreateDevopsProjectTask.Object.OrganizationId");
			_object.Visible = _ctx.StringValue("CreateDevopsProjectTask.Object.Visible");
			_object.IsDone = _ctx.BooleanValue("CreateDevopsProjectTask.Object.IsDone");
			_object.SprintId = _ctx.StringValue("CreateDevopsProjectTask.Object.SprintId");
			_object.DueDate = _ctx.StringValue("CreateDevopsProjectTask.Object.DueDate");
			_object.Created = _ctx.StringValue("CreateDevopsProjectTask.Object.Created");
			_object.Id = _ctx.StringValue("CreateDevopsProjectTask.Object.Id");
			createDevopsProjectTaskResponse._Object = _object;
        
			return createDevopsProjectTaskResponse;
        }
    }
}
