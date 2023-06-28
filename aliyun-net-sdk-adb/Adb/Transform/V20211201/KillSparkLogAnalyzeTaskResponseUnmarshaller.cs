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
    public class KillSparkLogAnalyzeTaskResponseUnmarshaller
    {
        public static KillSparkLogAnalyzeTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			KillSparkLogAnalyzeTaskResponse killSparkLogAnalyzeTaskResponse = new KillSparkLogAnalyzeTaskResponse();

			killSparkLogAnalyzeTaskResponse.HttpResponse = _ctx.HttpResponse;
			killSparkLogAnalyzeTaskResponse.RequestId = _ctx.StringValue("KillSparkLogAnalyzeTask.RequestId");

			KillSparkLogAnalyzeTaskResponse.KillSparkLogAnalyzeTask_Data data = new KillSparkLogAnalyzeTaskResponse.KillSparkLogAnalyzeTask_Data();
			data.TaskId = _ctx.LongValue("KillSparkLogAnalyzeTask.Data.TaskId");
			data.UserId = _ctx.LongValue("KillSparkLogAnalyzeTask.Data.UserId");
			data.SubmittedTimeInMillis = _ctx.LongValue("KillSparkLogAnalyzeTask.Data.SubmittedTimeInMillis");
			data.TerminatedTimeInMillis = _ctx.LongValue("KillSparkLogAnalyzeTask.Data.TerminatedTimeInMillis");
			data.TaskState = _ctx.StringValue("KillSparkLogAnalyzeTask.Data.TaskState");
			data.StartedTimeInMillis = _ctx.LongValue("KillSparkLogAnalyzeTask.Data.StartedTimeInMillis");
			data.RuleMatched = _ctx.BooleanValue("KillSparkLogAnalyzeTask.Data.RuleMatched");
			data.TaskErrMsg = _ctx.StringValue("KillSparkLogAnalyzeTask.Data.TaskErrMsg");
			data.DBClusterId = _ctx.StringValue("KillSparkLogAnalyzeTask.Data.DBClusterId");

			KillSparkLogAnalyzeTaskResponse.KillSparkLogAnalyzeTask_Data.KillSparkLogAnalyzeTask_Result result = new KillSparkLogAnalyzeTaskResponse.KillSparkLogAnalyzeTask_Data.KillSparkLogAnalyzeTask_Result();
			result.AppErrorCode = _ctx.StringValue("KillSparkLogAnalyzeTask.Data.Result.AppErrorCode");
			result.AppErrorLog = _ctx.StringValue("KillSparkLogAnalyzeTask.Data.Result.AppErrorLog");
			result.AppErrorAdvice = _ctx.StringValue("KillSparkLogAnalyzeTask.Data.Result.AppErrorAdvice");
			data.Result = result;
			killSparkLogAnalyzeTaskResponse.Data = data;
        
			return killSparkLogAnalyzeTaskResponse;
        }
    }
}
