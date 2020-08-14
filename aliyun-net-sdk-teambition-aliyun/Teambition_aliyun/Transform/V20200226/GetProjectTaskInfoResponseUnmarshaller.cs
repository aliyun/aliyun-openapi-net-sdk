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
    public class GetProjectTaskInfoResponseUnmarshaller
    {
        public static GetProjectTaskInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetProjectTaskInfoResponse getProjectTaskInfoResponse = new GetProjectTaskInfoResponse();

			getProjectTaskInfoResponse.HttpResponse = context.HttpResponse;
			getProjectTaskInfoResponse.Successful = context.BooleanValue("GetProjectTaskInfo.Successful");
			getProjectTaskInfoResponse.ErrorCode = context.StringValue("GetProjectTaskInfo.ErrorCode");
			getProjectTaskInfoResponse.ErrorMsg = context.StringValue("GetProjectTaskInfo.ErrorMsg");
			getProjectTaskInfoResponse.RequestId = context.StringValue("GetProjectTaskInfo.RequestId");

			GetProjectTaskInfoResponse.GetProjectTaskInfo__Object _object = new GetProjectTaskInfoResponse.GetProjectTaskInfo__Object();
			_object.TasklistId = context.StringValue("GetProjectTaskInfo.Object.TasklistId");
			_object.TaskflowstatusId = context.StringValue("GetProjectTaskInfo.Object.TaskflowstatusId");
			_object.TaskType = context.StringValue("GetProjectTaskInfo.Object.TaskType");
			_object.IsDeleted = context.BooleanValue("GetProjectTaskInfo.Object.IsDeleted");
			_object.CreatorId = context.StringValue("GetProjectTaskInfo.Object.CreatorId");
			_object.IsTopInProject = context.BooleanValue("GetProjectTaskInfo.Object.IsTopInProject");
			_object.ExecutorId = context.StringValue("GetProjectTaskInfo.Object.ExecutorId");
			_object.StoryPoint = context.StringValue("GetProjectTaskInfo.Object.StoryPoint");
			_object.Created = context.StringValue("GetProjectTaskInfo.Object.Created");
			_object.OrganizationId = context.StringValue("GetProjectTaskInfo.Object.OrganizationId");
			_object.IsDone = context.BooleanValue("GetProjectTaskInfo.Object.IsDone");
			_object.Id = context.StringValue("GetProjectTaskInfo.Object.Id");
			_object.Updated = context.StringValue("GetProjectTaskInfo.Object.Updated");
			_object.SprintId = context.StringValue("GetProjectTaskInfo.Object.SprintId");
			_object.ProjectId = context.StringValue("GetProjectTaskInfo.Object.ProjectId");
			_object.Content = context.StringValue("GetProjectTaskInfo.Object.Content");
			_object.Note = context.StringValue("GetProjectTaskInfo.Object.Note");
			_object.DueDate = context.StringValue("GetProjectTaskInfo.Object.DueDate");
			_object.StartDate = context.StringValue("GetProjectTaskInfo.Object.StartDate");
			_object.Visible = context.StringValue("GetProjectTaskInfo.Object.Visible");
			_object.Priority = context.StringValue("GetProjectTaskInfo.Object.Priority");

			List<string> _object_involveMembers = new List<string>();
			for (int i = 0; i < context.Length("GetProjectTaskInfo.Object.InvolveMembers.Length"); i++) {
				_object_involveMembers.Add(context.StringValue("GetProjectTaskInfo.Object.InvolveMembers["+ i +"]"));
			}
			_object.InvolveMembers = _object_involveMembers;
			getProjectTaskInfoResponse._Object = _object;
        
			return getProjectTaskInfoResponse;
        }
    }
}
