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
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeRefreshTasksResponseUnmarshaller
    {
        public static DescribeRefreshTasksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRefreshTasksResponse describeRefreshTasksResponse = new DescribeRefreshTasksResponse();

			describeRefreshTasksResponse.HttpResponse = context.HttpResponse;
			describeRefreshTasksResponse.RequestId = context.StringValue("DescribeRefreshTasks.RequestId");
			describeRefreshTasksResponse.PageSize = context.IntegerValue("DescribeRefreshTasks.PageSize");
			describeRefreshTasksResponse.PageNumber = context.IntegerValue("DescribeRefreshTasks.PageNumber");
			describeRefreshTasksResponse.TotalCount = context.IntegerValue("DescribeRefreshTasks.TotalCount");

			List<DescribeRefreshTasksResponse.DescribeRefreshTasks_Task> describeRefreshTasksResponse_tasks = new List<DescribeRefreshTasksResponse.DescribeRefreshTasks_Task>();
			for (int i = 0; i < context.Length("DescribeRefreshTasks.Tasks.Length"); i++) {
				DescribeRefreshTasksResponse.DescribeRefreshTasks_Task task = new DescribeRefreshTasksResponse.DescribeRefreshTasks_Task();
				task.TaskId = context.StringValue("DescribeRefreshTasks.Tasks["+ i +"].TaskId");
				task.ObjectPath = context.StringValue("DescribeRefreshTasks.Tasks["+ i +"].ObjectPath");
				task.Status = context.StringValue("DescribeRefreshTasks.Tasks["+ i +"].Status");
				task.Process = context.StringValue("DescribeRefreshTasks.Tasks["+ i +"].Process");
				task.ObjectType = context.StringValue("DescribeRefreshTasks.Tasks["+ i +"].ObjectType");
				task.CreationTime = context.StringValue("DescribeRefreshTasks.Tasks["+ i +"].CreationTime");
				task.Description = context.StringValue("DescribeRefreshTasks.Tasks["+ i +"].Description");

				describeRefreshTasksResponse_tasks.Add(task);
			}
			describeRefreshTasksResponse.Tasks = describeRefreshTasksResponse_tasks;
        
			return describeRefreshTasksResponse;
        }
    }
}