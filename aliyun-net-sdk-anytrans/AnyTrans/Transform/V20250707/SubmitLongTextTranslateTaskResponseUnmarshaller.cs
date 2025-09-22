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
    public class SubmitLongTextTranslateTaskResponseUnmarshaller
    {
        public static SubmitLongTextTranslateTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitLongTextTranslateTaskResponse submitLongTextTranslateTaskResponse = new SubmitLongTextTranslateTaskResponse();

			submitLongTextTranslateTaskResponse.HttpResponse = _ctx.HttpResponse;
			submitLongTextTranslateTaskResponse.Code = _ctx.StringValue("SubmitLongTextTranslateTask.code");
			submitLongTextTranslateTaskResponse.Message = _ctx.StringValue("SubmitLongTextTranslateTask.message");
			submitLongTextTranslateTaskResponse.RequestId = _ctx.StringValue("SubmitLongTextTranslateTask.requestId");
			submitLongTextTranslateTaskResponse.Success = _ctx.BooleanValue("SubmitLongTextTranslateTask.success");
			submitLongTextTranslateTaskResponse.HttpStatusCode = _ctx.StringValue("SubmitLongTextTranslateTask.httpStatusCode");

			SubmitLongTextTranslateTaskResponse.SubmitLongTextTranslateTask_Data data = new SubmitLongTextTranslateTaskResponse.SubmitLongTextTranslateTask_Data();
			data.TaskId = _ctx.StringValue("SubmitLongTextTranslateTask.Data.taskId");
			data.Status = _ctx.StringValue("SubmitLongTextTranslateTask.Data.status");
			submitLongTextTranslateTaskResponse.Data = data;
        
			return submitLongTextTranslateTaskResponse;
        }
    }
}
