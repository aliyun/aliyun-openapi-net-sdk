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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class GetTaskByUuidResponseUnmarshaller
    {
        public static GetTaskByUuidResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTaskByUuidResponse getTaskByUuidResponse = new GetTaskByUuidResponse();

			getTaskByUuidResponse.HttpResponse = _ctx.HttpResponse;
			getTaskByUuidResponse.RequestId = _ctx.StringValue("GetTaskByUuid.RequestId");

			GetTaskByUuidResponse.GetTaskByUuid_Task task = new GetTaskByUuidResponse.GetTaskByUuid_Task();
			task.Id = _ctx.StringValue("GetTaskByUuid.Task.Id");
			task.JobId = _ctx.StringValue("GetTaskByUuid.Task.JobId");
			task.PlannedTime = _ctx.LongValue("GetTaskByUuid.Task.PlannedTime");
			task.ActualTime = _ctx.LongValue("GetTaskByUuid.Task.ActualTime");
			task.EndTime = _ctx.LongValue("GetTaskByUuid.Task.EndTime");
			task.CallingNumber = _ctx.StringValue("GetTaskByUuid.Task.CallingNumber");
			task.CalledNumber = _ctx.StringValue("GetTaskByUuid.Task.CalledNumber");
			task.CallId = _ctx.StringValue("GetTaskByUuid.Task.CallId");
			task.EndReason = _ctx.IntegerValue("GetTaskByUuid.Task.EndReason");
			task.InstanceId = _ctx.StringValue("GetTaskByUuid.Task.InstanceId");
			task.JobGroupId = _ctx.StringValue("GetTaskByUuid.Task.JobGroupId");
			getTaskByUuidResponse.Task = task;
        
			return getTaskByUuidResponse;
        }
    }
}
