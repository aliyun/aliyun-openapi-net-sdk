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
        public static GetDevopsProjectTaskInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetDevopsProjectTaskInfoResponse getDevopsProjectTaskInfoResponse = new GetDevopsProjectTaskInfoResponse();

			getDevopsProjectTaskInfoResponse.HttpResponse = context.HttpResponse;
			getDevopsProjectTaskInfoResponse.Successful = context.BooleanValue("GetDevopsProjectTaskInfo.Successful");
			getDevopsProjectTaskInfoResponse.ErrorCode = context.StringValue("GetDevopsProjectTaskInfo.ErrorCode");
			getDevopsProjectTaskInfoResponse.ErrorMsg = context.StringValue("GetDevopsProjectTaskInfo.ErrorMsg");
			getDevopsProjectTaskInfoResponse.RequestId = context.StringValue("GetDevopsProjectTaskInfo.RequestId");

			GetDevopsProjectTaskInfoResponse.GetDevopsProjectTaskInfo__Object _object = new GetDevopsProjectTaskInfoResponse.GetDevopsProjectTaskInfo__Object();
			_object.TasklistId = context.StringValue("GetDevopsProjectTaskInfo.Object.TasklistId");
			_object.TaskflowstatusId = context.StringValue("GetDevopsProjectTaskInfo.Object.TaskflowstatusId");
			_object.TaskType = context.StringValue("GetDevopsProjectTaskInfo.Object.TaskType");
			_object.IsDeleted = context.BooleanValue("GetDevopsProjectTaskInfo.Object.IsDeleted");
			_object.CreatorId = context.StringValue("GetDevopsProjectTaskInfo.Object.CreatorId");
			_object.IsTopInProject = context.BooleanValue("GetDevopsProjectTaskInfo.Object.IsTopInProject");
			_object.ExecutorId = context.StringValue("GetDevopsProjectTaskInfo.Object.ExecutorId");
			_object.StoryPoint = context.StringValue("GetDevopsProjectTaskInfo.Object.StoryPoint");
			_object.Created = context.StringValue("GetDevopsProjectTaskInfo.Object.Created");
			_object.OrganizationId = context.StringValue("GetDevopsProjectTaskInfo.Object.OrganizationId");
			_object.IsDone = context.BooleanValue("GetDevopsProjectTaskInfo.Object.IsDone");
			_object.Id = context.StringValue("GetDevopsProjectTaskInfo.Object.Id");
			_object.Updated = context.StringValue("GetDevopsProjectTaskInfo.Object.Updated");
			_object.SprintId = context.StringValue("GetDevopsProjectTaskInfo.Object.SprintId");
			_object.ProjectId = context.StringValue("GetDevopsProjectTaskInfo.Object.ProjectId");
			_object.Content = context.StringValue("GetDevopsProjectTaskInfo.Object.Content");
			_object.Note = context.StringValue("GetDevopsProjectTaskInfo.Object.Note");
			_object.DueDate = context.StringValue("GetDevopsProjectTaskInfo.Object.DueDate");
			_object.StartDate = context.StringValue("GetDevopsProjectTaskInfo.Object.StartDate");
			_object.Visible = context.StringValue("GetDevopsProjectTaskInfo.Object.Visible");
			_object.Priority = context.StringValue("GetDevopsProjectTaskInfo.Object.Priority");

			List<string> _object_involveMembers = new List<string>();
			for (int i = 0; i < context.Length("GetDevopsProjectTaskInfo.Object.InvolveMembers.Length"); i++) {
				_object_involveMembers.Add(context.StringValue("GetDevopsProjectTaskInfo.Object.InvolveMembers["+ i +"]"));
			}
			_object.InvolveMembers = _object_involveMembers;
			getDevopsProjectTaskInfoResponse._Object = _object;
        
			return getDevopsProjectTaskInfoResponse;
        }
    }
}
