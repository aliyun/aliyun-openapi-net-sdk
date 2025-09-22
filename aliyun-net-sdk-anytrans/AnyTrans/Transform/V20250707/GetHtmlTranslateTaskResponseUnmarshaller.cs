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
    public class GetHtmlTranslateTaskResponseUnmarshaller
    {
        public static GetHtmlTranslateTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetHtmlTranslateTaskResponse getHtmlTranslateTaskResponse = new GetHtmlTranslateTaskResponse();

			getHtmlTranslateTaskResponse.HttpResponse = _ctx.HttpResponse;
			getHtmlTranslateTaskResponse.Code = _ctx.StringValue("GetHtmlTranslateTask.code");
			getHtmlTranslateTaskResponse.Message = _ctx.StringValue("GetHtmlTranslateTask.message");
			getHtmlTranslateTaskResponse.RequestId = _ctx.StringValue("GetHtmlTranslateTask.requestId");
			getHtmlTranslateTaskResponse.Success = _ctx.BooleanValue("GetHtmlTranslateTask.success");
			getHtmlTranslateTaskResponse.HttpStatusCode = _ctx.StringValue("GetHtmlTranslateTask.httpStatusCode");

			GetHtmlTranslateTaskResponse.GetHtmlTranslateTask_Data data = new GetHtmlTranslateTaskResponse.GetHtmlTranslateTask_Data();
			data.Translation = _ctx.StringValue("GetHtmlTranslateTask.Data.translation");

			GetHtmlTranslateTaskResponse.GetHtmlTranslateTask_Data.GetHtmlTranslateTask_Usage usage = new GetHtmlTranslateTaskResponse.GetHtmlTranslateTask_Data.GetHtmlTranslateTask_Usage();
			usage.InputTokens = _ctx.LongValue("GetHtmlTranslateTask.Data.Usage.inputTokens");
			usage.OutputTokens = _ctx.LongValue("GetHtmlTranslateTask.Data.Usage.outputTokens");
			usage.TotalTokens = _ctx.LongValue("GetHtmlTranslateTask.Data.Usage.totalTokens");
			data.Usage = usage;
			getHtmlTranslateTaskResponse.Data = data;
        
			return getHtmlTranslateTaskResponse;
        }
    }
}
