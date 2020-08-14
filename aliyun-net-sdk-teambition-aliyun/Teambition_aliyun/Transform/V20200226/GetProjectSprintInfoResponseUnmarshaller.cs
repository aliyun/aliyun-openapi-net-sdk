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
    public class GetProjectSprintInfoResponseUnmarshaller
    {
        public static GetProjectSprintInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetProjectSprintInfoResponse getProjectSprintInfoResponse = new GetProjectSprintInfoResponse();

			getProjectSprintInfoResponse.HttpResponse = context.HttpResponse;
			getProjectSprintInfoResponse.Successful = context.BooleanValue("GetProjectSprintInfo.Successful");
			getProjectSprintInfoResponse.ErrorCode = context.StringValue("GetProjectSprintInfo.ErrorCode");
			getProjectSprintInfoResponse.ErrorMsg = context.StringValue("GetProjectSprintInfo.ErrorMsg");
			getProjectSprintInfoResponse.RequestId = context.StringValue("GetProjectSprintInfo.RequestId");

			GetProjectSprintInfoResponse.GetProjectSprintInfo__Object _object = new GetProjectSprintInfoResponse.GetProjectSprintInfo__Object();
			_object.Accomplished = context.StringValue("GetProjectSprintInfo.Object.Accomplished");
			_object.IsDeleted = context.BooleanValue("GetProjectSprintInfo.Object.IsDeleted");
			_object.Created = context.StringValue("GetProjectSprintInfo.Object.Created");
			_object.DueDate = context.StringValue("GetProjectSprintInfo.Object.DueDate");
			_object.Name = context.StringValue("GetProjectSprintInfo.Object.Name");
			_object.CreatorId = context.StringValue("GetProjectSprintInfo.Object.CreatorId");
			_object.Id = context.StringValue("GetProjectSprintInfo.Object.Id");
			_object.Updated = context.StringValue("GetProjectSprintInfo.Object.Updated");
			_object.StartDate = context.StringValue("GetProjectSprintInfo.Object.StartDate");
			_object.Status = context.StringValue("GetProjectSprintInfo.Object.Status");
			_object.ProjectId = context.StringValue("GetProjectSprintInfo.Object.ProjectId");

			GetProjectSprintInfoResponse.GetProjectSprintInfo__Object.GetProjectSprintInfo_PlanToDo planToDo = new GetProjectSprintInfoResponse.GetProjectSprintInfo__Object.GetProjectSprintInfo_PlanToDo();
			planToDo.StoryPoints = context.IntegerValue("GetProjectSprintInfo.Object.PlanToDo.StoryPoints");
			planToDo.WorkTimes = context.IntegerValue("GetProjectSprintInfo.Object.PlanToDo.WorkTimes");
			planToDo.Tasks = context.IntegerValue("GetProjectSprintInfo.Object.PlanToDo.Tasks");
			_object.PlanToDo = planToDo;
			getProjectSprintInfoResponse._Object = _object;
        
			return getProjectSprintInfoResponse;
        }
    }
}
