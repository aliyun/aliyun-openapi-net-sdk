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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeTasksResponseUnmarshaller
    {
        public static DescribeTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTasksResponse describeTasksResponse = new DescribeTasksResponse();

			describeTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeTasksResponse.RequestId = _ctx.StringValue("DescribeTasks.RequestId");
			describeTasksResponse.StartTime = _ctx.StringValue("DescribeTasks.StartTime");
			describeTasksResponse.EndTime = _ctx.StringValue("DescribeTasks.EndTime");
			describeTasksResponse.TotalRecordCount = _ctx.IntegerValue("DescribeTasks.TotalRecordCount");
			describeTasksResponse.PageNumber = _ctx.IntegerValue("DescribeTasks.PageNumber");
			describeTasksResponse.PageRecordCount = _ctx.IntegerValue("DescribeTasks.PageRecordCount");
			describeTasksResponse.DBClusterId = _ctx.StringValue("DescribeTasks.DBClusterId");

			List<DescribeTasksResponse.DescribeTasks_Task> describeTasksResponse_tasks = new List<DescribeTasksResponse.DescribeTasks_Task>();
			for (int i = 0; i < _ctx.Length("DescribeTasks.Tasks.Length"); i++) {
				DescribeTasksResponse.DescribeTasks_Task task = new DescribeTasksResponse.DescribeTasks_Task();
				task.TaskId = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].TaskId");
				task.BeginTime = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].BeginTime");
				task.FinishTime = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].FinishTime");
				task.ExpectedFinishTime = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].ExpectedFinishTime");
				task.TaskAction = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].TaskAction");
				task.Progress = _ctx.IntegerValue("DescribeTasks.Tasks["+ i +"].Progress");
				task.DBName = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].DBName");
				task.ProgressInfo = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].ProgressInfo");
				task.TaskErrorCode = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].TaskErrorCode");
				task.TaskErrorMessage = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].TaskErrorMessage");
				task.StepsInfo = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].StepsInfo");
				task.Remain = _ctx.IntegerValue("DescribeTasks.Tasks["+ i +"].Remain");
				task.StepProgressInfo = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].StepProgressInfo");
				task.CurrentStepName = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].CurrentStepName");

				describeTasksResponse_tasks.Add(task);
			}
			describeTasksResponse.Tasks = describeTasksResponse_tasks;
        
			return describeTasksResponse;
        }
    }
}
