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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class GetSparkLogAnalyzeTaskResponseUnmarshaller
    {
        public static GetSparkLogAnalyzeTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSparkLogAnalyzeTaskResponse getSparkLogAnalyzeTaskResponse = new GetSparkLogAnalyzeTaskResponse();

			getSparkLogAnalyzeTaskResponse.HttpResponse = _ctx.HttpResponse;
			getSparkLogAnalyzeTaskResponse.RequestId = _ctx.StringValue("GetSparkLogAnalyzeTask.RequestId");

			GetSparkLogAnalyzeTaskResponse.GetSparkLogAnalyzeTask_Data data = new GetSparkLogAnalyzeTaskResponse.GetSparkLogAnalyzeTask_Data();
			data.TaskId = _ctx.LongValue("GetSparkLogAnalyzeTask.Data.TaskId");
			data.UserId = _ctx.LongValue("GetSparkLogAnalyzeTask.Data.UserId");
			data.SubmittedTimeInMillis = _ctx.LongValue("GetSparkLogAnalyzeTask.Data.SubmittedTimeInMillis");
			data.TerminatedTimeInMillis = _ctx.LongValue("GetSparkLogAnalyzeTask.Data.TerminatedTimeInMillis");
			data.TaskState = _ctx.StringValue("GetSparkLogAnalyzeTask.Data.TaskState");
			data.StartedTimeInMillis = _ctx.LongValue("GetSparkLogAnalyzeTask.Data.StartedTimeInMillis");
			data.RuleMatched = _ctx.BooleanValue("GetSparkLogAnalyzeTask.Data.RuleMatched");
			data.TaskErrMsg = _ctx.StringValue("GetSparkLogAnalyzeTask.Data.TaskErrMsg");
			data.DBClusterId = _ctx.StringValue("GetSparkLogAnalyzeTask.Data.DBClusterId");

			GetSparkLogAnalyzeTaskResponse.GetSparkLogAnalyzeTask_Data.GetSparkLogAnalyzeTask_Result result = new GetSparkLogAnalyzeTaskResponse.GetSparkLogAnalyzeTask_Data.GetSparkLogAnalyzeTask_Result();
			result.AppErrorCode = _ctx.StringValue("GetSparkLogAnalyzeTask.Data.Result.AppErrorCode");
			result.AppErrorLog = _ctx.StringValue("GetSparkLogAnalyzeTask.Data.Result.AppErrorLog");
			result.AppErrorAdvice = _ctx.StringValue("GetSparkLogAnalyzeTask.Data.Result.AppErrorAdvice");
			data.Result = result;
			getSparkLogAnalyzeTaskResponse.Data = data;
        
			return getSparkLogAnalyzeTaskResponse;
        }
    }
}
