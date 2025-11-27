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
    public class SubmitImageTranslateTaskResponseUnmarshaller
    {
        public static SubmitImageTranslateTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitImageTranslateTaskResponse submitImageTranslateTaskResponse = new SubmitImageTranslateTaskResponse();

			submitImageTranslateTaskResponse.HttpResponse = _ctx.HttpResponse;
			submitImageTranslateTaskResponse.Code = _ctx.StringValue("SubmitImageTranslateTask.code");
			submitImageTranslateTaskResponse.Message = _ctx.StringValue("SubmitImageTranslateTask.message");
			submitImageTranslateTaskResponse.RequestId = _ctx.StringValue("SubmitImageTranslateTask.requestId");
			submitImageTranslateTaskResponse.Success = _ctx.BooleanValue("SubmitImageTranslateTask.success");
			submitImageTranslateTaskResponse.HttpStatusCode = _ctx.StringValue("SubmitImageTranslateTask.httpStatusCode");

			SubmitImageTranslateTaskResponse.SubmitImageTranslateTask_Data data = new SubmitImageTranslateTaskResponse.SubmitImageTranslateTask_Data();
			data.TaskId = _ctx.StringValue("SubmitImageTranslateTask.Data.taskId");
			data.Status = _ctx.StringValue("SubmitImageTranslateTask.Data.status");
			submitImageTranslateTaskResponse.Data = data;
        
			return submitImageTranslateTaskResponse;
        }
    }
}
