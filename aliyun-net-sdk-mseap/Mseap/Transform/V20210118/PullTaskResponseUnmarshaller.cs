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
using Aliyun.Acs.mseap.Model.V20210118;

namespace Aliyun.Acs.mseap.Transform.V20210118
{
    public class PullTaskResponseUnmarshaller
    {
        public static PullTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PullTaskResponse pullTaskResponse = new PullTaskResponse();

			pullTaskResponse.HttpResponse = _ctx.HttpResponse;
			pullTaskResponse.AllowRetry = _ctx.BooleanValue("PullTask.AllowRetry");
			pullTaskResponse.RequestId = _ctx.StringValue("PullTask.RequestId");
			pullTaskResponse.ErrorMsg = _ctx.StringValue("PullTask.ErrorMsg");
			pullTaskResponse.HttpStatusCode = _ctx.IntegerValue("PullTask.HttpStatusCode");
			pullTaskResponse.DynamicCode = _ctx.StringValue("PullTask.DynamicCode");
			pullTaskResponse.ErrorCode = _ctx.StringValue("PullTask.ErrorCode");
			pullTaskResponse.DynamicMessage = _ctx.StringValue("PullTask.DynamicMessage");
			pullTaskResponse.Success = _ctx.BooleanValue("PullTask.Success");
			pullTaskResponse.AppName = _ctx.StringValue("PullTask.AppName");

			PullTaskResponse.PullTask_Module module = new PullTaskResponse.PullTask_Module();
			module.TaskId = _ctx.StringValue("PullTask.Module.TaskId");
			module.OutTaskId = _ctx.StringValue("PullTask.Module.OutTaskId");
			module.TaskType = _ctx.StringValue("PullTask.Module.TaskType");
			module.TaskData = _ctx.StringValue("PullTask.Module.TaskData");
			module.OrderId = _ctx.StringValue("PullTask.Module.OrderId");
			module.BizCode = _ctx.StringValue("PullTask.Module.BizCode");
			module.PrincipalKey = _ctx.StringValue("PullTask.Module.PrincipalKey");
			pullTaskResponse.Module = module;
        
			return pullTaskResponse;
        }
    }
}
