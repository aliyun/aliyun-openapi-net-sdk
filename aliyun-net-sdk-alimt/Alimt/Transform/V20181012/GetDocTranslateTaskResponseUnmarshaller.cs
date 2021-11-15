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
using Aliyun.Acs.alimt.Model.V20181012;

namespace Aliyun.Acs.alimt.Transform.V20181012
{
    public class GetDocTranslateTaskResponseUnmarshaller
    {
        public static GetDocTranslateTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDocTranslateTaskResponse getDocTranslateTaskResponse = new GetDocTranslateTaskResponse();

			getDocTranslateTaskResponse.HttpResponse = _ctx.HttpResponse;
			getDocTranslateTaskResponse.Status = _ctx.StringValue("GetDocTranslateTask.Status");
			getDocTranslateTaskResponse.RequestId = _ctx.StringValue("GetDocTranslateTask.RequestId");
			getDocTranslateTaskResponse.TranslateFileUrl = _ctx.StringValue("GetDocTranslateTask.TranslateFileUrl");
			getDocTranslateTaskResponse.TranslateErrorCode = _ctx.StringValue("GetDocTranslateTask.TranslateErrorCode");
			getDocTranslateTaskResponse.PageCount = _ctx.IntegerValue("GetDocTranslateTask.PageCount");
			getDocTranslateTaskResponse.TaskId = _ctx.StringValue("GetDocTranslateTask.TaskId");
			getDocTranslateTaskResponse.TranslateErrorMessage = _ctx.StringValue("GetDocTranslateTask.TranslateErrorMessage");
        
			return getDocTranslateTaskResponse;
        }
    }
}
