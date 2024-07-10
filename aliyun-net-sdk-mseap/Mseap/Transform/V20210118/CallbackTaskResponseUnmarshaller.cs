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
    public class CallbackTaskResponseUnmarshaller
    {
        public static CallbackTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CallbackTaskResponse callbackTaskResponse = new CallbackTaskResponse();

			callbackTaskResponse.HttpResponse = _ctx.HttpResponse;
			callbackTaskResponse.AllowRetry = _ctx.BooleanValue("CallbackTask.AllowRetry");
			callbackTaskResponse.RequestId = _ctx.StringValue("CallbackTask.RequestId");
			callbackTaskResponse.ErrorMsg = _ctx.StringValue("CallbackTask.ErrorMsg");
			callbackTaskResponse.HttpStatusCode = _ctx.IntegerValue("CallbackTask.HttpStatusCode");
			callbackTaskResponse.DynamicCode = _ctx.StringValue("CallbackTask.DynamicCode");
			callbackTaskResponse.ErrorCode = _ctx.StringValue("CallbackTask.ErrorCode");
			callbackTaskResponse.DynamicMessage = _ctx.StringValue("CallbackTask.DynamicMessage");
			callbackTaskResponse.Module = _ctx.BooleanValue("CallbackTask.Module");
			callbackTaskResponse.Success = _ctx.BooleanValue("CallbackTask.Success");
			callbackTaskResponse.AppName = _ctx.StringValue("CallbackTask.AppName");
        
			return callbackTaskResponse;
        }
    }
}
