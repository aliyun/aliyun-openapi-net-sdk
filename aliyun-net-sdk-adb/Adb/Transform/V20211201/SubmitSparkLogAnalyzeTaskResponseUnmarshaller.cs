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
    public class SubmitSparkLogAnalyzeTaskResponseUnmarshaller
    {
        public static SubmitSparkLogAnalyzeTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitSparkLogAnalyzeTaskResponse submitSparkLogAnalyzeTaskResponse = new SubmitSparkLogAnalyzeTaskResponse();

			submitSparkLogAnalyzeTaskResponse.HttpResponse = _ctx.HttpResponse;
			submitSparkLogAnalyzeTaskResponse.RequestId = _ctx.StringValue("SubmitSparkLogAnalyzeTask.RequestId");

			SubmitSparkLogAnalyzeTaskResponse.SubmitSparkLogAnalyzeTask_Data data = new SubmitSparkLogAnalyzeTaskResponse.SubmitSparkLogAnalyzeTask_Data();
			data.TaskId = _ctx.LongValue("SubmitSparkLogAnalyzeTask.Data.TaskId");
			data.UserId = _ctx.LongValue("SubmitSparkLogAnalyzeTask.Data.UserId");
			data.SubmittedTimeInMillis = _ctx.LongValue("SubmitSparkLogAnalyzeTask.Data.SubmittedTimeInMillis");
			data.TerminatedTimeInMillis = _ctx.LongValue("SubmitSparkLogAnalyzeTask.Data.TerminatedTimeInMillis");
			data.TaskState = _ctx.StringValue("SubmitSparkLogAnalyzeTask.Data.TaskState");
			data.StartedTimeInMillis = _ctx.LongValue("SubmitSparkLogAnalyzeTask.Data.StartedTimeInMillis");
			data.RuleMatched = _ctx.BooleanValue("SubmitSparkLogAnalyzeTask.Data.RuleMatched");
			data.TaskErrMsg = _ctx.StringValue("SubmitSparkLogAnalyzeTask.Data.TaskErrMsg");
			data.DBClusterId = _ctx.StringValue("SubmitSparkLogAnalyzeTask.Data.DBClusterId");

			SubmitSparkLogAnalyzeTaskResponse.SubmitSparkLogAnalyzeTask_Data.SubmitSparkLogAnalyzeTask_Result result = new SubmitSparkLogAnalyzeTaskResponse.SubmitSparkLogAnalyzeTask_Data.SubmitSparkLogAnalyzeTask_Result();
			result.AppErrorCode = _ctx.StringValue("SubmitSparkLogAnalyzeTask.Data.Result.AppErrorCode");
			result.AppErrorLog = _ctx.StringValue("SubmitSparkLogAnalyzeTask.Data.Result.AppErrorLog");
			result.AppErrorAdvice = _ctx.StringValue("SubmitSparkLogAnalyzeTask.Data.Result.AppErrorAdvice");
			data.Result = result;
			submitSparkLogAnalyzeTaskResponse.Data = data;
        
			return submitSparkLogAnalyzeTaskResponse;
        }
    }
}
