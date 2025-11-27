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
    public class PushRpaTaskResponseUnmarshaller
    {
        public static PushRpaTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PushRpaTaskResponse pushRpaTaskResponse = new PushRpaTaskResponse();

			pushRpaTaskResponse.HttpResponse = _ctx.HttpResponse;
			pushRpaTaskResponse.AllowRetry = _ctx.BooleanValue("PushRpaTask.AllowRetry");
			pushRpaTaskResponse.RequestId = _ctx.StringValue("PushRpaTask.RequestId");
			pushRpaTaskResponse.ErrorMsg = _ctx.StringValue("PushRpaTask.ErrorMsg");
			pushRpaTaskResponse.HttpStatusCode = _ctx.IntegerValue("PushRpaTask.HttpStatusCode");
			pushRpaTaskResponse.DynamicCode = _ctx.StringValue("PushRpaTask.DynamicCode");
			pushRpaTaskResponse.ErrorCode = _ctx.StringValue("PushRpaTask.ErrorCode");
			pushRpaTaskResponse.DynamicMessage = _ctx.StringValue("PushRpaTask.DynamicMessage");
			pushRpaTaskResponse.Module = _ctx.StringValue("PushRpaTask.Module");
			pushRpaTaskResponse.Success = _ctx.BooleanValue("PushRpaTask.Success");
			pushRpaTaskResponse.AppName = _ctx.StringValue("PushRpaTask.AppName");
        
			return pushRpaTaskResponse;
        }
    }
}
