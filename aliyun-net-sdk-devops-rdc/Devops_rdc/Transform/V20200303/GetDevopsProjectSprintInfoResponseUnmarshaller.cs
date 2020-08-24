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
    public class GetDevopsProjectSprintInfoResponseUnmarshaller
    {
        public static GetDevopsProjectSprintInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetDevopsProjectSprintInfoResponse getDevopsProjectSprintInfoResponse = new GetDevopsProjectSprintInfoResponse();

			getDevopsProjectSprintInfoResponse.HttpResponse = context.HttpResponse;
			getDevopsProjectSprintInfoResponse.Successful = context.BooleanValue("GetDevopsProjectSprintInfo.Successful");
			getDevopsProjectSprintInfoResponse.ErrorCode = context.StringValue("GetDevopsProjectSprintInfo.ErrorCode");
			getDevopsProjectSprintInfoResponse.ErrorMsg = context.StringValue("GetDevopsProjectSprintInfo.ErrorMsg");
			getDevopsProjectSprintInfoResponse.RequestId = context.StringValue("GetDevopsProjectSprintInfo.RequestId");

			GetDevopsProjectSprintInfoResponse.GetDevopsProjectSprintInfo__Object _object = new GetDevopsProjectSprintInfoResponse.GetDevopsProjectSprintInfo__Object();
			_object.Accomplished = context.StringValue("GetDevopsProjectSprintInfo.Object.Accomplished");
			_object.IsDeleted = context.BooleanValue("GetDevopsProjectSprintInfo.Object.IsDeleted");
			_object.Created = context.StringValue("GetDevopsProjectSprintInfo.Object.Created");
			_object.DueDate = context.StringValue("GetDevopsProjectSprintInfo.Object.DueDate");
			_object.Name = context.StringValue("GetDevopsProjectSprintInfo.Object.Name");
			_object.CreatorId = context.StringValue("GetDevopsProjectSprintInfo.Object.CreatorId");
			_object.Id = context.StringValue("GetDevopsProjectSprintInfo.Object.Id");
			_object.Updated = context.StringValue("GetDevopsProjectSprintInfo.Object.Updated");
			_object.StartDate = context.StringValue("GetDevopsProjectSprintInfo.Object.StartDate");
			_object.Status = context.StringValue("GetDevopsProjectSprintInfo.Object.Status");
			_object.ProjectId = context.StringValue("GetDevopsProjectSprintInfo.Object.ProjectId");

			GetDevopsProjectSprintInfoResponse.GetDevopsProjectSprintInfo__Object.GetDevopsProjectSprintInfo_PlanToDo planToDo = new GetDevopsProjectSprintInfoResponse.GetDevopsProjectSprintInfo__Object.GetDevopsProjectSprintInfo_PlanToDo();
			planToDo.StoryPoints = context.IntegerValue("GetDevopsProjectSprintInfo.Object.PlanToDo.StoryPoints");
			planToDo.WorkTimes = context.IntegerValue("GetDevopsProjectSprintInfo.Object.PlanToDo.WorkTimes");
			planToDo.Tasks = context.IntegerValue("GetDevopsProjectSprintInfo.Object.PlanToDo.Tasks");
			_object.PlanToDo = planToDo;
			getDevopsProjectSprintInfoResponse._Object = _object;
        
			return getDevopsProjectSprintInfoResponse;
        }
    }
}
