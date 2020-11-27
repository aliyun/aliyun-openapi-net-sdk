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
    public class CreateDevopsProjectSprintResponseUnmarshaller
    {
        public static CreateDevopsProjectSprintResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateDevopsProjectSprintResponse createDevopsProjectSprintResponse = new CreateDevopsProjectSprintResponse();

			createDevopsProjectSprintResponse.HttpResponse = _ctx.HttpResponse;
			createDevopsProjectSprintResponse.Successful = _ctx.BooleanValue("CreateDevopsProjectSprint.Successful");
			createDevopsProjectSprintResponse.ErrorCode = _ctx.StringValue("CreateDevopsProjectSprint.ErrorCode");
			createDevopsProjectSprintResponse.ErrorMsg = _ctx.StringValue("CreateDevopsProjectSprint.ErrorMsg");
			createDevopsProjectSprintResponse.RequestId = _ctx.StringValue("CreateDevopsProjectSprint.RequestId");

			CreateDevopsProjectSprintResponse.CreateDevopsProjectSprint__Object _object = new CreateDevopsProjectSprintResponse.CreateDevopsProjectSprint__Object();
			_object.Created = _ctx.StringValue("CreateDevopsProjectSprint.Object.Created");
			_object.DueDate = _ctx.StringValue("CreateDevopsProjectSprint.Object.DueDate");
			_object.Description = _ctx.StringValue("CreateDevopsProjectSprint.Object.Description");
			_object.Accomplished = _ctx.StringValue("CreateDevopsProjectSprint.Object.Accomplished");
			_object.IsDeleted = _ctx.BooleanValue("CreateDevopsProjectSprint.Object.IsDeleted");
			_object.Executor = _ctx.StringValue("CreateDevopsProjectSprint.Object.Executor");
			_object.Name = _ctx.StringValue("CreateDevopsProjectSprint.Object.Name");
			_object.CreatorId = _ctx.StringValue("CreateDevopsProjectSprint.Object.CreatorId");
			_object.Id = _ctx.StringValue("CreateDevopsProjectSprint.Object.Id");
			_object.Updated = _ctx.StringValue("CreateDevopsProjectSprint.Object.Updated");
			_object.StartDate = _ctx.StringValue("CreateDevopsProjectSprint.Object.StartDate");
			_object.Status = _ctx.StringValue("CreateDevopsProjectSprint.Object.Status");
			_object.ProjectId = _ctx.StringValue("CreateDevopsProjectSprint.Object.ProjectId");

			CreateDevopsProjectSprintResponse.CreateDevopsProjectSprint__Object.CreateDevopsProjectSprint_PlanToDo planToDo = new CreateDevopsProjectSprintResponse.CreateDevopsProjectSprint__Object.CreateDevopsProjectSprint_PlanToDo();
			planToDo.StoryPoints = _ctx.IntegerValue("CreateDevopsProjectSprint.Object.PlanToDo.StoryPoints");
			planToDo.WorkTimes = _ctx.IntegerValue("CreateDevopsProjectSprint.Object.PlanToDo.WorkTimes");
			planToDo.Tasks = _ctx.IntegerValue("CreateDevopsProjectSprint.Object.PlanToDo.Tasks");
			_object.PlanToDo = planToDo;
			createDevopsProjectSprintResponse._Object = _object;
        
			return createDevopsProjectSprintResponse;
        }
    }
}
