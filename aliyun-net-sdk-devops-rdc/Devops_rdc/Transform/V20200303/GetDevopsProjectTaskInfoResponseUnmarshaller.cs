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
    public class GetDevopsProjectTaskInfoResponseUnmarshaller
    {
        public static GetDevopsProjectTaskInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDevopsProjectTaskInfoResponse getDevopsProjectTaskInfoResponse = new GetDevopsProjectTaskInfoResponse();

			getDevopsProjectTaskInfoResponse.HttpResponse = _ctx.HttpResponse;
			getDevopsProjectTaskInfoResponse.Successful = _ctx.BooleanValue("GetDevopsProjectTaskInfo.Successful");
			getDevopsProjectTaskInfoResponse.ErrorCode = _ctx.StringValue("GetDevopsProjectTaskInfo.ErrorCode");
			getDevopsProjectTaskInfoResponse.ErrorMsg = _ctx.StringValue("GetDevopsProjectTaskInfo.ErrorMsg");
			getDevopsProjectTaskInfoResponse.RequestId = _ctx.StringValue("GetDevopsProjectTaskInfo.RequestId");

			GetDevopsProjectTaskInfoResponse.GetDevopsProjectTaskInfo__Object _object = new GetDevopsProjectTaskInfoResponse.GetDevopsProjectTaskInfo__Object();
			_object.TasklistId = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.TasklistId");
			_object.TaskflowstatusId = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.TaskflowstatusId");
			_object.TaskType = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.TaskType");
			_object.IsDeleted = _ctx.BooleanValue("GetDevopsProjectTaskInfo.Object.IsDeleted");
			_object.CreatorId = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.CreatorId");
			_object.IsTopInProject = _ctx.BooleanValue("GetDevopsProjectTaskInfo.Object.IsTopInProject");
			_object.ExecutorId = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.ExecutorId");
			_object.StoryPoint = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.StoryPoint");
			_object.Created = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.Created");
			_object.OrganizationId = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.OrganizationId");
			_object.IsDone = _ctx.BooleanValue("GetDevopsProjectTaskInfo.Object.IsDone");
			_object.Id = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.Id");
			_object.Updated = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.Updated");
			_object.SprintId = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.SprintId");
			_object.ProjectId = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.ProjectId");
			_object.Content = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.Content");
			_object.Note = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.Note");
			_object.DueDate = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.DueDate");
			_object.StartDate = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.StartDate");
			_object.Visible = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.Visible");
			_object.Priority = _ctx.StringValue("GetDevopsProjectTaskInfo.Object.Priority");

			List<string> _object_involveMembers = new List<string>();
			for (int i = 0; i < _ctx.Length("GetDevopsProjectTaskInfo.Object.InvolveMembers.Length"); i++) {
				_object_involveMembers.Add(_ctx.StringValue("GetDevopsProjectTaskInfo.Object.InvolveMembers["+ i +"]"));
			}
			_object.InvolveMembers = _object_involveMembers;
			getDevopsProjectTaskInfoResponse._Object = _object;
        
			return getDevopsProjectTaskInfoResponse;
        }
    }
}
