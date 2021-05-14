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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeDrdsDbTasksResponseUnmarshaller
    {
        public static DescribeDrdsDbTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsDbTasksResponse describeDrdsDbTasksResponse = new DescribeDrdsDbTasksResponse();

			describeDrdsDbTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsDbTasksResponse.RequestId = _ctx.StringValue("DescribeDrdsDbTasks.RequestId");
			describeDrdsDbTasksResponse.Success = _ctx.BooleanValue("DescribeDrdsDbTasks.Success");

			List<DescribeDrdsDbTasksResponse.DescribeDrdsDbTasks_Task> describeDrdsDbTasksResponse_tasks = new List<DescribeDrdsDbTasksResponse.DescribeDrdsDbTasks_Task>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsDbTasks.Tasks.Length"); i++) {
				DescribeDrdsDbTasksResponse.DescribeDrdsDbTasks_Task task = new DescribeDrdsDbTasksResponse.DescribeDrdsDbTasks_Task();
				task.TaskName = _ctx.StringValue("DescribeDrdsDbTasks.Tasks["+ i +"].TaskName");
				task.GmtCreate = _ctx.LongValue("DescribeDrdsDbTasks.Tasks["+ i +"].GmtCreate");
				task.TaskDetail = _ctx.StringValue("DescribeDrdsDbTasks.Tasks["+ i +"].TaskDetail");
				task.TaskType = _ctx.IntegerValue("DescribeDrdsDbTasks.Tasks["+ i +"].TaskType");
				task.TaskStatus = _ctx.IntegerValue("DescribeDrdsDbTasks.Tasks["+ i +"].TaskStatus");
				task.Progress = _ctx.IntegerValue("DescribeDrdsDbTasks.Tasks["+ i +"].Progress");
				task.TaskPhase = _ctx.StringValue("DescribeDrdsDbTasks.Tasks["+ i +"].TaskPhase");
				task.ShowProgress = _ctx.BooleanValue("DescribeDrdsDbTasks.Tasks["+ i +"].ShowProgress");
				task.AllowCancel = _ctx.BooleanValue("DescribeDrdsDbTasks.Tasks["+ i +"].AllowCancel");
				task.ParentJobId = _ctx.StringValue("DescribeDrdsDbTasks.Tasks["+ i +"].ParentJobId");
				task.ExpandType = _ctx.StringValue("DescribeDrdsDbTasks.Tasks["+ i +"].ExpandType");
				task.TargetId = _ctx.LongValue("DescribeDrdsDbTasks.Tasks["+ i +"].TargetId");
				task.Label = _ctx.StringValue("DescribeDrdsDbTasks.Tasks["+ i +"].Label");
				task.DetailTaskId = _ctx.StringValue("DescribeDrdsDbTasks.Tasks["+ i +"].DetailTaskId");
				task.TbComputeLength = _ctx.IntegerValue("DescribeDrdsDbTasks.Tasks["+ i +"].TbComputeLength");
				task.DbComputeLength = _ctx.IntegerValue("DescribeDrdsDbTasks.Tasks["+ i +"].DbComputeLength");

				describeDrdsDbTasksResponse_tasks.Add(task);
			}
			describeDrdsDbTasksResponse.Tasks = describeDrdsDbTasksResponse_tasks;
        
			return describeDrdsDbTasksResponse;
        }
    }
}
