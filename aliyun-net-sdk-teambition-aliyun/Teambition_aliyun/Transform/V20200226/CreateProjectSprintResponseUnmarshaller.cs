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
    public class CreateProjectSprintResponseUnmarshaller
    {
        public static CreateProjectSprintResponse Unmarshall(UnmarshallerContext context)
        {
			CreateProjectSprintResponse createProjectSprintResponse = new CreateProjectSprintResponse();

			createProjectSprintResponse.HttpResponse = context.HttpResponse;
			createProjectSprintResponse.Successful = context.BooleanValue("CreateProjectSprint.Successful");
			createProjectSprintResponse.ErrorCode = context.StringValue("CreateProjectSprint.ErrorCode");
			createProjectSprintResponse.ErrorMsg = context.StringValue("CreateProjectSprint.ErrorMsg");
			createProjectSprintResponse.RequestId = context.StringValue("CreateProjectSprint.RequestId");

			CreateProjectSprintResponse.CreateProjectSprint__Object _object = new CreateProjectSprintResponse.CreateProjectSprint__Object();
			_object.Created = context.StringValue("CreateProjectSprint.Object.Created");
			_object.DueDate = context.StringValue("CreateProjectSprint.Object.DueDate");
			_object.Description = context.StringValue("CreateProjectSprint.Object.Description");
			_object.Accomplished = context.StringValue("CreateProjectSprint.Object.Accomplished");
			_object.IsDeleted = context.BooleanValue("CreateProjectSprint.Object.IsDeleted");
			_object.Executor = context.StringValue("CreateProjectSprint.Object.Executor");
			_object.Name = context.StringValue("CreateProjectSprint.Object.Name");
			_object.CreatorId = context.StringValue("CreateProjectSprint.Object.CreatorId");
			_object.Id = context.StringValue("CreateProjectSprint.Object.Id");
			_object.Updated = context.StringValue("CreateProjectSprint.Object.Updated");
			_object.StartDate = context.StringValue("CreateProjectSprint.Object.StartDate");
			_object.Status = context.StringValue("CreateProjectSprint.Object.Status");
			_object.ProjectId = context.StringValue("CreateProjectSprint.Object.ProjectId");

			CreateProjectSprintResponse.CreateProjectSprint__Object.CreateProjectSprint_PlanToDo planToDo = new CreateProjectSprintResponse.CreateProjectSprint__Object.CreateProjectSprint_PlanToDo();
			planToDo.StoryPoints = context.IntegerValue("CreateProjectSprint.Object.PlanToDo.StoryPoints");
			planToDo.WorkTimes = context.IntegerValue("CreateProjectSprint.Object.PlanToDo.WorkTimes");
			planToDo.Tasks = context.IntegerValue("CreateProjectSprint.Object.PlanToDo.Tasks");
			_object.PlanToDo = planToDo;
			createProjectSprintResponse._Object = _object;
        
			return createProjectSprintResponse;
        }
    }
}
