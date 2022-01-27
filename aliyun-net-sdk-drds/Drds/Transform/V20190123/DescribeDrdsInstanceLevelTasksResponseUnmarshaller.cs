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
    public class DescribeDrdsInstanceLevelTasksResponseUnmarshaller
    {
        public static DescribeDrdsInstanceLevelTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsInstanceLevelTasksResponse describeDrdsInstanceLevelTasksResponse = new DescribeDrdsInstanceLevelTasksResponse();

			describeDrdsInstanceLevelTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsInstanceLevelTasksResponse.RequestId = _ctx.StringValue("DescribeDrdsInstanceLevelTasks.RequestId");
			describeDrdsInstanceLevelTasksResponse.Success = _ctx.BooleanValue("DescribeDrdsInstanceLevelTasks.Success");

			List<DescribeDrdsInstanceLevelTasksResponse.DescribeDrdsInstanceLevelTasks_Task> describeDrdsInstanceLevelTasksResponse_tasks = new List<DescribeDrdsInstanceLevelTasksResponse.DescribeDrdsInstanceLevelTasks_Task>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsInstanceLevelTasks.Tasks.Length"); i++) {
				DescribeDrdsInstanceLevelTasksResponse.DescribeDrdsInstanceLevelTasks_Task task = new DescribeDrdsInstanceLevelTasksResponse.DescribeDrdsInstanceLevelTasks_Task();
				task.TaskName = _ctx.StringValue("DescribeDrdsInstanceLevelTasks.Tasks["+ i +"].TaskName");
				task.GmtCreate = _ctx.LongValue("DescribeDrdsInstanceLevelTasks.Tasks["+ i +"].GmtCreate");
				task.TaskType = _ctx.IntegerValue("DescribeDrdsInstanceLevelTasks.Tasks["+ i +"].TaskType");
				task.TargetId = _ctx.LongValue("DescribeDrdsInstanceLevelTasks.Tasks["+ i +"].TargetId");
				task.TaskStatus = _ctx.IntegerValue("DescribeDrdsInstanceLevelTasks.Tasks["+ i +"].TaskStatus");
				task.Progress = _ctx.IntegerValue("DescribeDrdsInstanceLevelTasks.Tasks["+ i +"].Progress");
				task.ProgressDescription = _ctx.StringValue("DescribeDrdsInstanceLevelTasks.Tasks["+ i +"].ProgressDescription");
				task.TaskPhase = _ctx.StringValue("DescribeDrdsInstanceLevelTasks.Tasks["+ i +"].TaskPhase");
				task.ErrMsg = _ctx.StringValue("DescribeDrdsInstanceLevelTasks.Tasks["+ i +"].ErrMsg");
				task.ShowProgress = _ctx.BooleanValue("DescribeDrdsInstanceLevelTasks.Tasks["+ i +"].ShowProgress");
				task.AllowCancel = _ctx.BooleanValue("DescribeDrdsInstanceLevelTasks.Tasks["+ i +"].AllowCancel");

				describeDrdsInstanceLevelTasksResponse_tasks.Add(task);
			}
			describeDrdsInstanceLevelTasksResponse.Tasks = describeDrdsInstanceLevelTasksResponse_tasks;
        
			return describeDrdsInstanceLevelTasksResponse;
        }
    }
}
