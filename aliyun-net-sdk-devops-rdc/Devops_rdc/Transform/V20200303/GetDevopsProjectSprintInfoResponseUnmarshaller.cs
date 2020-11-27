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
        public static GetDevopsProjectSprintInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDevopsProjectSprintInfoResponse getDevopsProjectSprintInfoResponse = new GetDevopsProjectSprintInfoResponse();

			getDevopsProjectSprintInfoResponse.HttpResponse = _ctx.HttpResponse;
			getDevopsProjectSprintInfoResponse.Successful = _ctx.BooleanValue("GetDevopsProjectSprintInfo.Successful");
			getDevopsProjectSprintInfoResponse.ErrorCode = _ctx.StringValue("GetDevopsProjectSprintInfo.ErrorCode");
			getDevopsProjectSprintInfoResponse.ErrorMsg = _ctx.StringValue("GetDevopsProjectSprintInfo.ErrorMsg");
			getDevopsProjectSprintInfoResponse.RequestId = _ctx.StringValue("GetDevopsProjectSprintInfo.RequestId");

			GetDevopsProjectSprintInfoResponse.GetDevopsProjectSprintInfo__Object _object = new GetDevopsProjectSprintInfoResponse.GetDevopsProjectSprintInfo__Object();
			_object.Accomplished = _ctx.StringValue("GetDevopsProjectSprintInfo.Object.Accomplished");
			_object.IsDeleted = _ctx.BooleanValue("GetDevopsProjectSprintInfo.Object.IsDeleted");
			_object.Created = _ctx.StringValue("GetDevopsProjectSprintInfo.Object.Created");
			_object.DueDate = _ctx.StringValue("GetDevopsProjectSprintInfo.Object.DueDate");
			_object.Name = _ctx.StringValue("GetDevopsProjectSprintInfo.Object.Name");
			_object.CreatorId = _ctx.StringValue("GetDevopsProjectSprintInfo.Object.CreatorId");
			_object.Id = _ctx.StringValue("GetDevopsProjectSprintInfo.Object.Id");
			_object.Updated = _ctx.StringValue("GetDevopsProjectSprintInfo.Object.Updated");
			_object.StartDate = _ctx.StringValue("GetDevopsProjectSprintInfo.Object.StartDate");
			_object.Status = _ctx.StringValue("GetDevopsProjectSprintInfo.Object.Status");
			_object.ProjectId = _ctx.StringValue("GetDevopsProjectSprintInfo.Object.ProjectId");

			GetDevopsProjectSprintInfoResponse.GetDevopsProjectSprintInfo__Object.GetDevopsProjectSprintInfo_PlanToDo planToDo = new GetDevopsProjectSprintInfoResponse.GetDevopsProjectSprintInfo__Object.GetDevopsProjectSprintInfo_PlanToDo();
			planToDo.StoryPoints = _ctx.IntegerValue("GetDevopsProjectSprintInfo.Object.PlanToDo.StoryPoints");
			planToDo.WorkTimes = _ctx.IntegerValue("GetDevopsProjectSprintInfo.Object.PlanToDo.WorkTimes");
			planToDo.Tasks = _ctx.IntegerValue("GetDevopsProjectSprintInfo.Object.PlanToDo.Tasks");
			_object.PlanToDo = planToDo;
			getDevopsProjectSprintInfoResponse._Object = _object;
        
			return getDevopsProjectSprintInfoResponse;
        }
    }
}
