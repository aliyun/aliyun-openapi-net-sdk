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
using Aliyun.Acs.AnyTrans.Model.V20250707;

namespace Aliyun.Acs.AnyTrans.Transform.V20250707
{
    public class SubmitDocTranslateTaskResponseUnmarshaller
    {
        public static SubmitDocTranslateTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitDocTranslateTaskResponse submitDocTranslateTaskResponse = new SubmitDocTranslateTaskResponse();

			submitDocTranslateTaskResponse.HttpResponse = _ctx.HttpResponse;
			submitDocTranslateTaskResponse.Code = _ctx.StringValue("SubmitDocTranslateTask.code");
			submitDocTranslateTaskResponse.Message = _ctx.StringValue("SubmitDocTranslateTask.message");
			submitDocTranslateTaskResponse.RequestId = _ctx.StringValue("SubmitDocTranslateTask.requestId");
			submitDocTranslateTaskResponse.Success = _ctx.BooleanValue("SubmitDocTranslateTask.success");
			submitDocTranslateTaskResponse.HttpStatusCode = _ctx.StringValue("SubmitDocTranslateTask.httpStatusCode");

			SubmitDocTranslateTaskResponse.SubmitDocTranslateTask_Data data = new SubmitDocTranslateTaskResponse.SubmitDocTranslateTask_Data();
			data.TaskId = _ctx.StringValue("SubmitDocTranslateTask.Data.taskId");
			data.Status = _ctx.StringValue("SubmitDocTranslateTask.Data.status");
			submitDocTranslateTaskResponse.Data = data;
        
			return submitDocTranslateTaskResponse;
        }
    }
}
