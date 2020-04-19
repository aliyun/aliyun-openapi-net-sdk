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
using Aliyun.Acs.multimediaai.Model.V20190810;

namespace Aliyun.Acs.multimediaai.Transform.V20190810
{
    public class GetTaskResultResponseUnmarshaller
    {
        public static GetTaskResultResponse Unmarshall(UnmarshallerContext context)
        {
			GetTaskResultResponse getTaskResultResponse = new GetTaskResultResponse();

			getTaskResultResponse.HttpResponse = context.HttpResponse;
			getTaskResultResponse.RequestId = context.StringValue("GetTaskResult.RequestId");
			getTaskResultResponse.Status = context.IntegerValue("GetTaskResult.Status");

			GetTaskResultResponse.GetTaskResult_Result result = new GetTaskResultResponse.GetTaskResult_Result();
			result.ApplicationId = context.StringValue("GetTaskResult.Result.ApplicationId");
			result.VideoName = context.StringValue("GetTaskResult.Result.VideoName");
			result.ProcessResultUrl = context.StringValue("GetTaskResult.Result.ProcessResultUrl");
			result.AnalysisUseTime = context.LongValue("GetTaskResult.Result.AnalysisUseTime");
			result.VideoUrl = context.StringValue("GetTaskResult.Result.VideoUrl");
			result.ErrorName = context.StringValue("GetTaskResult.Result.ErrorName");
			result.ErrorReason = context.StringValue("GetTaskResult.Result.ErrorReason");
			result.ErrorCode = context.StringValue("GetTaskResult.Result.ErrorCode");
			result.ErrorMessage = context.StringValue("GetTaskResult.Result.ErrorMessage");
			getTaskResultResponse.Result = result;
        
			return getTaskResultResponse;
        }
    }
}
