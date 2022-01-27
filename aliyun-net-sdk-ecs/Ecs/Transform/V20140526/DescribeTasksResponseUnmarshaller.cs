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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeTasksResponseUnmarshaller
    {
        public static DescribeTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTasksResponse describeTasksResponse = new DescribeTasksResponse();

			describeTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeTasksResponse.PageSize = _ctx.IntegerValue("DescribeTasks.PageSize");
			describeTasksResponse.PageNumber = _ctx.IntegerValue("DescribeTasks.PageNumber");
			describeTasksResponse.RequestId = _ctx.StringValue("DescribeTasks.RequestId");
			describeTasksResponse.TotalCount = _ctx.IntegerValue("DescribeTasks.TotalCount");
			describeTasksResponse.RegionId = _ctx.StringValue("DescribeTasks.RegionId");

			List<DescribeTasksResponse.DescribeTasks_Task> describeTasksResponse_taskSet = new List<DescribeTasksResponse.DescribeTasks_Task>();
			for (int i = 0; i < _ctx.Length("DescribeTasks.TaskSet.Length"); i++) {
				DescribeTasksResponse.DescribeTasks_Task task = new DescribeTasksResponse.DescribeTasks_Task();
				task.CreationTime = _ctx.StringValue("DescribeTasks.TaskSet["+ i +"].CreationTime");
				task.TaskStatus = _ctx.StringValue("DescribeTasks.TaskSet["+ i +"].TaskStatus");
				task.FinishedTime = _ctx.StringValue("DescribeTasks.TaskSet["+ i +"].FinishedTime");
				task.SupportCancel = _ctx.StringValue("DescribeTasks.TaskSet["+ i +"].SupportCancel");
				task.TaskId = _ctx.StringValue("DescribeTasks.TaskSet["+ i +"].TaskId");
				task.TaskAction = _ctx.StringValue("DescribeTasks.TaskSet["+ i +"].TaskAction");

				describeTasksResponse_taskSet.Add(task);
			}
			describeTasksResponse.TaskSet = describeTasksResponse_taskSet;
        
			return describeTasksResponse;
        }
    }
}
