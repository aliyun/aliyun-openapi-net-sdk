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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.R_kvstore.Model.V20150101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeCacheAnalysisReportListResponseUnmarshaller
    {
        public static DescribeCacheAnalysisReportListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCacheAnalysisReportListResponse describeCacheAnalysisReportListResponse = new DescribeCacheAnalysisReportListResponse();

			describeCacheAnalysisReportListResponse.HttpResponse = context.HttpResponse;
			describeCacheAnalysisReportListResponse.RequestId = context.StringValue("DescribeCacheAnalysisReportList.RequestId");
			describeCacheAnalysisReportListResponse.InstanceId = context.StringValue("DescribeCacheAnalysisReportList.InstanceId");
			describeCacheAnalysisReportListResponse.TotalRecordCount = context.IntegerValue("DescribeCacheAnalysisReportList.TotalRecordCount");
			describeCacheAnalysisReportListResponse.PageNumbers = context.IntegerValue("DescribeCacheAnalysisReportList.PageNumbers");
			describeCacheAnalysisReportListResponse.PageRecordCount = context.IntegerValue("DescribeCacheAnalysisReportList.PageRecordCount");

			List<DescribeCacheAnalysisReportListResponse.DescribeCacheAnalysisReportList_DailyTask> describeCacheAnalysisReportListResponse_dailyTasks = new List<DescribeCacheAnalysisReportListResponse.DescribeCacheAnalysisReportList_DailyTask>();
			for (int i = 0; i < context.Length("DescribeCacheAnalysisReportList.DailyTasks.Length"); i++) {
				DescribeCacheAnalysisReportListResponse.DescribeCacheAnalysisReportList_DailyTask dailyTask = new DescribeCacheAnalysisReportListResponse.DescribeCacheAnalysisReportList_DailyTask();
				dailyTask.Date = context.StringValue("DescribeCacheAnalysisReportList.DailyTasks["+ i +"].Date");

				List<DescribeCacheAnalysisReportListResponse.DescribeCacheAnalysisReportList_DailyTask.DescribeCacheAnalysisReportList_Task> dailyTask_tasks = new List<DescribeCacheAnalysisReportListResponse.DescribeCacheAnalysisReportList_DailyTask.DescribeCacheAnalysisReportList_Task>();
				for (int j = 0; j < context.Length("DescribeCacheAnalysisReportList.DailyTasks["+ i +"].Tasks.Length"); j++) {
					DescribeCacheAnalysisReportListResponse.DescribeCacheAnalysisReportList_DailyTask.DescribeCacheAnalysisReportList_Task task = new DescribeCacheAnalysisReportListResponse.DescribeCacheAnalysisReportList_DailyTask.DescribeCacheAnalysisReportList_Task();
					task.TaskId = context.StringValue("DescribeCacheAnalysisReportList.DailyTasks["+ i +"].Tasks["+ j +"].TaskId");
					task.NodeId = context.StringValue("DescribeCacheAnalysisReportList.DailyTasks["+ i +"].Tasks["+ j +"].NodeId");
					task.StartTime = context.StringValue("DescribeCacheAnalysisReportList.DailyTasks["+ i +"].Tasks["+ j +"].StartTime");
					task.Status = context.StringValue("DescribeCacheAnalysisReportList.DailyTasks["+ i +"].Tasks["+ j +"].Status");

					dailyTask_tasks.Add(task);
				}
				dailyTask.Tasks = dailyTask_tasks;

				describeCacheAnalysisReportListResponse_dailyTasks.Add(dailyTask);
			}
			describeCacheAnalysisReportListResponse.DailyTasks = describeCacheAnalysisReportListResponse_dailyTasks;
        
			return describeCacheAnalysisReportListResponse;
        }
    }
}