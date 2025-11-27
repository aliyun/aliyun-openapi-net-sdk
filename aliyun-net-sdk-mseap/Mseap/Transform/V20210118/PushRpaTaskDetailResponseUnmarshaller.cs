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
    public class PushRpaTaskDetailResponseUnmarshaller
    {
        public static PushRpaTaskDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PushRpaTaskDetailResponse pushRpaTaskDetailResponse = new PushRpaTaskDetailResponse();

			pushRpaTaskDetailResponse.HttpResponse = _ctx.HttpResponse;
			pushRpaTaskDetailResponse.AllowRetry = _ctx.BooleanValue("PushRpaTaskDetail.AllowRetry");
			pushRpaTaskDetailResponse.RequestId = _ctx.StringValue("PushRpaTaskDetail.RequestId");
			pushRpaTaskDetailResponse.ErrorMsg = _ctx.StringValue("PushRpaTaskDetail.ErrorMsg");
			pushRpaTaskDetailResponse.HttpStatusCode = _ctx.IntegerValue("PushRpaTaskDetail.HttpStatusCode");
			pushRpaTaskDetailResponse.DynamicCode = _ctx.StringValue("PushRpaTaskDetail.DynamicCode");
			pushRpaTaskDetailResponse.ErrorCode = _ctx.StringValue("PushRpaTaskDetail.ErrorCode");
			pushRpaTaskDetailResponse.DynamicMessage = _ctx.StringValue("PushRpaTaskDetail.DynamicMessage");
			pushRpaTaskDetailResponse.Module = _ctx.StringValue("PushRpaTaskDetail.Module");
			pushRpaTaskDetailResponse.Success = _ctx.BooleanValue("PushRpaTaskDetail.Success");
			pushRpaTaskDetailResponse.AppName = _ctx.StringValue("PushRpaTaskDetail.AppName");
        
			return pushRpaTaskDetailResponse;
        }
    }
}
