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
    public class ListSparkLogAnalyzeTasksResponseUnmarshaller
    {
        public static ListSparkLogAnalyzeTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSparkLogAnalyzeTasksResponse listSparkLogAnalyzeTasksResponse = new ListSparkLogAnalyzeTasksResponse();

			listSparkLogAnalyzeTasksResponse.HttpResponse = _ctx.HttpResponse;
			listSparkLogAnalyzeTasksResponse.RequestId = _ctx.StringValue("ListSparkLogAnalyzeTasks.RequestId");

			ListSparkLogAnalyzeTasksResponse.ListSparkLogAnalyzeTasks_Data data = new ListSparkLogAnalyzeTasksResponse.ListSparkLogAnalyzeTasks_Data();
			data.PageNumber = _ctx.LongValue("ListSparkLogAnalyzeTasks.Data.PageNumber");
			data.PageSize = _ctx.LongValue("ListSparkLogAnalyzeTasks.Data.PageSize");
			data.TotalCount = _ctx.LongValue("ListSparkLogAnalyzeTasks.Data.TotalCount");

			List<ListSparkLogAnalyzeTasksResponse.ListSparkLogAnalyzeTasks_Data.ListSparkLogAnalyzeTasks_Task> data_taskList = new List<ListSparkLogAnalyzeTasksResponse.ListSparkLogAnalyzeTasks_Data.ListSparkLogAnalyzeTasks_Task>();
			for (int i = 0; i < _ctx.Length("ListSparkLogAnalyzeTasks.Data.TaskList.Length"); i++) {
				ListSparkLogAnalyzeTasksResponse.ListSparkLogAnalyzeTasks_Data.ListSparkLogAnalyzeTasks_Task task = new ListSparkLogAnalyzeTasksResponse.ListSparkLogAnalyzeTasks_Data.ListSparkLogAnalyzeTasks_Task();
				task.TaskId = _ctx.LongValue("ListSparkLogAnalyzeTasks.Data.TaskList["+ i +"].TaskId");
				task.UserId = _ctx.LongValue("ListSparkLogAnalyzeTasks.Data.TaskList["+ i +"].UserId");
				task.SubmittedTimeInMillis = _ctx.LongValue("ListSparkLogAnalyzeTasks.Data.TaskList["+ i +"].SubmittedTimeInMillis");
				task.TerminatedTimeInMillis = _ctx.LongValue("ListSparkLogAnalyzeTasks.Data.TaskList["+ i +"].TerminatedTimeInMillis");
				task.TaskState = _ctx.StringValue("ListSparkLogAnalyzeTasks.Data.TaskList["+ i +"].TaskState");
				task.StartedTimeInMillis = _ctx.LongValue("ListSparkLogAnalyzeTasks.Data.TaskList["+ i +"].StartedTimeInMillis");
				task.RuleMatched = _ctx.BooleanValue("ListSparkLogAnalyzeTasks.Data.TaskList["+ i +"].RuleMatched");
				task.TaskErrMsg = _ctx.StringValue("ListSparkLogAnalyzeTasks.Data.TaskList["+ i +"].TaskErrMsg");
				task.DBClusterId = _ctx.StringValue("ListSparkLogAnalyzeTasks.Data.TaskList["+ i +"].DBClusterId");

				ListSparkLogAnalyzeTasksResponse.ListSparkLogAnalyzeTasks_Data.ListSparkLogAnalyzeTasks_Task.ListSparkLogAnalyzeTasks_Result result = new ListSparkLogAnalyzeTasksResponse.ListSparkLogAnalyzeTasks_Data.ListSparkLogAnalyzeTasks_Task.ListSparkLogAnalyzeTasks_Result();
				result.AppErrorCode = _ctx.StringValue("ListSparkLogAnalyzeTasks.Data.TaskList["+ i +"].Result.AppErrorCode");
				result.AppErrorLog = _ctx.StringValue("ListSparkLogAnalyzeTasks.Data.TaskList["+ i +"].Result.AppErrorLog");
				result.AppErrorAdvice = _ctx.StringValue("ListSparkLogAnalyzeTasks.Data.TaskList["+ i +"].Result.AppErrorAdvice");
				task.Result = result;

				data_taskList.Add(task);
			}
			data.TaskList = data_taskList;
			listSparkLogAnalyzeTasksResponse.Data = data;
        
			return listSparkLogAnalyzeTasksResponse;
        }
    }
}
