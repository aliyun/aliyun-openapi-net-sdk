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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class GetFunctionTaskResponseUnmarshaller
    {
        public static GetFunctionTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetFunctionTaskResponse getFunctionTaskResponse = new GetFunctionTaskResponse();

			getFunctionTaskResponse.HttpResponse = _ctx.HttpResponse;
			getFunctionTaskResponse.Status = _ctx.StringValue("GetFunctionTask.Status");
			getFunctionTaskResponse.HttpCode = _ctx.LongValue("GetFunctionTask.HttpCode");
			getFunctionTaskResponse.RequestId = _ctx.StringValue("GetFunctionTask.RequestId");
			getFunctionTaskResponse.Message = _ctx.StringValue("GetFunctionTask.Message");
			getFunctionTaskResponse.Code = _ctx.StringValue("GetFunctionTask.Code");
			getFunctionTaskResponse.Latency = _ctx.LongValue("GetFunctionTask.Latency");

			GetFunctionTaskResponse.GetFunctionTask_Result result = new GetFunctionTaskResponse.GetFunctionTask_Result();
			result.EndTime = _ctx.LongValue("GetFunctionTask.Result.EndTime");
			result.ExtendInfo = _ctx.StringValue("GetFunctionTask.Result.ExtendInfo");
			result.FunctionName = _ctx.StringValue("GetFunctionTask.Result.FunctionName");
			result.Generation = _ctx.StringValue("GetFunctionTask.Result.Generation");
			result.Progress = _ctx.LongValue("GetFunctionTask.Result.Progress");
			result.RunId = _ctx.StringValue("GetFunctionTask.Result.RunId");
			result.StartTime = _ctx.LongValue("GetFunctionTask.Result.StartTime");
			result.Status = _ctx.StringValue("GetFunctionTask.Result.Status");
			getFunctionTaskResponse.Result = result;
        
			return getFunctionTaskResponse;
        }
    }
}
