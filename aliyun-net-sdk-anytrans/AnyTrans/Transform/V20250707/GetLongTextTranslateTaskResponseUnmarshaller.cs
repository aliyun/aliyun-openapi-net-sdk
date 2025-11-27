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
    public class GetLongTextTranslateTaskResponseUnmarshaller
    {
        public static GetLongTextTranslateTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLongTextTranslateTaskResponse getLongTextTranslateTaskResponse = new GetLongTextTranslateTaskResponse();

			getLongTextTranslateTaskResponse.HttpResponse = _ctx.HttpResponse;
			getLongTextTranslateTaskResponse.Code = _ctx.StringValue("GetLongTextTranslateTask.code");
			getLongTextTranslateTaskResponse.Message = _ctx.StringValue("GetLongTextTranslateTask.message");
			getLongTextTranslateTaskResponse.RequestId = _ctx.StringValue("GetLongTextTranslateTask.requestId");
			getLongTextTranslateTaskResponse.Success = _ctx.BooleanValue("GetLongTextTranslateTask.success");
			getLongTextTranslateTaskResponse.HttpStatusCode = _ctx.StringValue("GetLongTextTranslateTask.httpStatusCode");

			GetLongTextTranslateTaskResponse.GetLongTextTranslateTask_Data data = new GetLongTextTranslateTaskResponse.GetLongTextTranslateTask_Data();
			data.Translation = _ctx.StringValue("GetLongTextTranslateTask.Data.translation");

			GetLongTextTranslateTaskResponse.GetLongTextTranslateTask_Data.GetLongTextTranslateTask_Usage usage = new GetLongTextTranslateTaskResponse.GetLongTextTranslateTask_Data.GetLongTextTranslateTask_Usage();
			usage.InputTokens = _ctx.LongValue("GetLongTextTranslateTask.Data.Usage.inputTokens");
			usage.OutputTokens = _ctx.LongValue("GetLongTextTranslateTask.Data.Usage.outputTokens");
			usage.TotalTokens = _ctx.LongValue("GetLongTextTranslateTask.Data.Usage.totalTokens");
			data.Usage = usage;
			getLongTextTranslateTaskResponse.Data = data;
        
			return getLongTextTranslateTaskResponse;
        }
    }
}
