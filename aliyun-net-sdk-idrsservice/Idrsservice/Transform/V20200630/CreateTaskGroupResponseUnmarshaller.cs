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
    public class CreateTaskGroupResponseUnmarshaller
    {
        public static CreateTaskGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateTaskGroupResponse createTaskGroupResponse = new CreateTaskGroupResponse();

			createTaskGroupResponse.HttpResponse = _ctx.HttpResponse;
			createTaskGroupResponse.Code = _ctx.StringValue("CreateTaskGroup.Code");
			createTaskGroupResponse.Message = _ctx.StringValue("CreateTaskGroup.Message");
			createTaskGroupResponse.RequestId = _ctx.StringValue("CreateTaskGroup.RequestId");

			CreateTaskGroupResponse.CreateTaskGroup_Data data = new CreateTaskGroupResponse.CreateTaskGroup_Data();
			data.CompletedTasks = _ctx.IntegerValue("CreateTaskGroup.Data.CompletedTasks");
			data.CreatedAt = _ctx.StringValue("CreateTaskGroup.Data.CreatedAt");
			data.Id = _ctx.StringValue("CreateTaskGroup.Data.Id");
			data.Name = _ctx.StringValue("CreateTaskGroup.Data.Name");
			data.RuleId = _ctx.StringValue("CreateTaskGroup.Data.RuleId");
			data.RuleName = _ctx.StringValue("CreateTaskGroup.Data.RuleName");
			data.Status = _ctx.StringValue("CreateTaskGroup.Data.Status");
			data.TotalTasks = _ctx.IntegerValue("CreateTaskGroup.Data.TotalTasks");

			List<string> data_taskIds = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateTaskGroup.Data.TaskIds.Length"); i++) {
				data_taskIds.Add(_ctx.StringValue("CreateTaskGroup.Data.TaskIds["+ i +"]"));
			}
			data.TaskIds = data_taskIds;
			createTaskGroupResponse.Data = data;
        
			return createTaskGroupResponse;
        }
    }
}
