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
        public static CreateDevopsProjectSprintResponse Unmarshall(UnmarshallerContext context)
        {
			CreateDevopsProjectSprintResponse createDevopsProjectSprintResponse = new CreateDevopsProjectSprintResponse();

			createDevopsProjectSprintResponse.HttpResponse = context.HttpResponse;
			createDevopsProjectSprintResponse.Successful = context.BooleanValue("CreateDevopsProjectSprint.Successful");
			createDevopsProjectSprintResponse.ErrorCode = context.StringValue("CreateDevopsProjectSprint.ErrorCode");
			createDevopsProjectSprintResponse.ErrorMsg = context.StringValue("CreateDevopsProjectSprint.ErrorMsg");
			createDevopsProjectSprintResponse.RequestId = context.StringValue("CreateDevopsProjectSprint.RequestId");

			CreateDevopsProjectSprintResponse.CreateDevopsProjectSprint__Object _object = new CreateDevopsProjectSprintResponse.CreateDevopsProjectSprint__Object();
			_object.Created = context.StringValue("CreateDevopsProjectSprint.Object.Created");
			_object.DueDate = context.StringValue("CreateDevopsProjectSprint.Object.DueDate");
			_object.Description = context.StringValue("CreateDevopsProjectSprint.Object.Description");
			_object.Accomplished = context.StringValue("CreateDevopsProjectSprint.Object.Accomplished");
			_object.IsDeleted = context.BooleanValue("CreateDevopsProjectSprint.Object.IsDeleted");
			_object.Executor = context.StringValue("CreateDevopsProjectSprint.Object.Executor");
			_object.Name = context.StringValue("CreateDevopsProjectSprint.Object.Name");
			_object.CreatorId = context.StringValue("CreateDevopsProjectSprint.Object.CreatorId");
			_object.Id = context.StringValue("CreateDevopsProjectSprint.Object.Id");
			_object.Updated = context.StringValue("CreateDevopsProjectSprint.Object.Updated");
			_object.StartDate = context.StringValue("CreateDevopsProjectSprint.Object.StartDate");
			_object.Status = context.StringValue("CreateDevopsProjectSprint.Object.Status");
			_object.ProjectId = context.StringValue("CreateDevopsProjectSprint.Object.ProjectId");

			CreateDevopsProjectSprintResponse.CreateDevopsProjectSprint__Object.CreateDevopsProjectSprint_PlanToDo planToDo = new CreateDevopsProjectSprintResponse.CreateDevopsProjectSprint__Object.CreateDevopsProjectSprint_PlanToDo();
			planToDo.StoryPoints = context.IntegerValue("CreateDevopsProjectSprint.Object.PlanToDo.StoryPoints");
			planToDo.WorkTimes = context.IntegerValue("CreateDevopsProjectSprint.Object.PlanToDo.WorkTimes");
			planToDo.Tasks = context.IntegerValue("CreateDevopsProjectSprint.Object.PlanToDo.Tasks");
			_object.PlanToDo = planToDo;
			createDevopsProjectSprintResponse._Object = _object;
        
			return createDevopsProjectSprintResponse;
        }
    }
}
