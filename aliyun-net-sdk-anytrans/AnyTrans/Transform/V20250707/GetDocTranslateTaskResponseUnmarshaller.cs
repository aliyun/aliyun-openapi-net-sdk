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
    public class GetDocTranslateTaskResponseUnmarshaller
    {
        public static GetDocTranslateTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDocTranslateTaskResponse getDocTranslateTaskResponse = new GetDocTranslateTaskResponse();

			getDocTranslateTaskResponse.HttpResponse = _ctx.HttpResponse;
			getDocTranslateTaskResponse.Code = _ctx.StringValue("GetDocTranslateTask.code");
			getDocTranslateTaskResponse.Message = _ctx.StringValue("GetDocTranslateTask.message");
			getDocTranslateTaskResponse.RequestId = _ctx.StringValue("GetDocTranslateTask.requestId");
			getDocTranslateTaskResponse.Success = _ctx.BooleanValue("GetDocTranslateTask.success");
			getDocTranslateTaskResponse.HttpStatusCode = _ctx.StringValue("GetDocTranslateTask.httpStatusCode");

			GetDocTranslateTaskResponse.GetDocTranslateTask_Data data = new GetDocTranslateTaskResponse.GetDocTranslateTask_Data();
			data.TaskId = _ctx.StringValue("GetDocTranslateTask.Data.taskId");
			data.Status = _ctx.StringValue("GetDocTranslateTask.Data.status");
			data.CharactersCount = _ctx.IntegerValue("GetDocTranslateTask.Data.charactersCount");
			data.PageCount = _ctx.IntegerValue("GetDocTranslateTask.Data.pageCount");
			data.TranslateFileUrl = _ctx.StringValue("GetDocTranslateTask.Data.translateFileUrl");
			getDocTranslateTaskResponse.Data = data;
        
			return getDocTranslateTaskResponse;
        }
    }
}
