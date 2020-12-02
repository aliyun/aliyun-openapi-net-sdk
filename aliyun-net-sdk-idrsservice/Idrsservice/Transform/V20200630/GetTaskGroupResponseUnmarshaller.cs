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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class GetTaskGroupResponseUnmarshaller
    {
        public static GetTaskGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTaskGroupResponse getTaskGroupResponse = new GetTaskGroupResponse();

			getTaskGroupResponse.HttpResponse = _ctx.HttpResponse;
			getTaskGroupResponse.Code = _ctx.StringValue("GetTaskGroup.Code");
			getTaskGroupResponse.Message = _ctx.StringValue("GetTaskGroup.Message");
			getTaskGroupResponse.RequestId = _ctx.StringValue("GetTaskGroup.RequestId");

			GetTaskGroupResponse.GetTaskGroup_Data data = new GetTaskGroupResponse.GetTaskGroup_Data();
			data.CompletedTasks = _ctx.IntegerValue("GetTaskGroup.Data.CompletedTasks");
			data.CreatedAt = _ctx.StringValue("GetTaskGroup.Data.CreatedAt");
			data.Id = _ctx.StringValue("GetTaskGroup.Data.Id");
			data.Name = _ctx.StringValue("GetTaskGroup.Data.Name");
			data.RuleId = _ctx.StringValue("GetTaskGroup.Data.RuleId");
			data.RuleName = _ctx.StringValue("GetTaskGroup.Data.RuleName");
			data.Status = _ctx.StringValue("GetTaskGroup.Data.Status");
			data.TotalTasks = _ctx.IntegerValue("GetTaskGroup.Data.TotalTasks");

			List<string> data_taskIds = new List<string>();
			for (int i = 0; i < _ctx.Length("GetTaskGroup.Data.TaskIds.Length"); i++) {
				data_taskIds.Add(_ctx.StringValue("GetTaskGroup.Data.TaskIds["+ i +"]"));
			}
			data.TaskIds = data_taskIds;
			getTaskGroupResponse.Data = data;
        
			return getTaskGroupResponse;
        }
    }
}
