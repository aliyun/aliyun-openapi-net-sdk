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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class GetCodeCompletionResponseUnmarshaller
    {
        public static GetCodeCompletionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCodeCompletionResponse getCodeCompletionResponse = new GetCodeCompletionResponse();

			getCodeCompletionResponse.HttpResponse = _ctx.HttpResponse;
			getCodeCompletionResponse.RequestId = _ctx.StringValue("GetCodeCompletion.RequestId");
			getCodeCompletionResponse.ErrorCode = _ctx.StringValue("GetCodeCompletion.ErrorCode");
			getCodeCompletionResponse.Success = _ctx.BooleanValue("GetCodeCompletion.Success");
			getCodeCompletionResponse.ErrorMessage = _ctx.StringValue("GetCodeCompletion.ErrorMessage");

			GetCodeCompletionResponse.GetCodeCompletion_Result result = new GetCodeCompletionResponse.GetCodeCompletion_Result();
			result.Body = _ctx.StringValue("GetCodeCompletion.Result.Body");
			result.ClientTimestamp = _ctx.StringValue("GetCodeCompletion.Result.ClientTimestamp");
			result.ReceiveTimestamp = _ctx.StringValue("GetCodeCompletion.Result.ReceiveTimestamp");
			result.InvokeTimestamp = _ctx.StringValue("GetCodeCompletion.Result.InvokeTimestamp");
			result.FetchTimestamp = _ctx.StringValue("GetCodeCompletion.Result.FetchTimestamp");
			result.RspTimestamp = _ctx.StringValue("GetCodeCompletion.Result.RspTimestamp");
			getCodeCompletionResponse.Result = result;
        
			return getCodeCompletionResponse;
        }
    }
}
