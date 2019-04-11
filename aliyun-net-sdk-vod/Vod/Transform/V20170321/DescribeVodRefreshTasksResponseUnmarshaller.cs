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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodRefreshTasksResponseUnmarshaller
    {
        public static DescribeVodRefreshTasksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodRefreshTasksResponse describeVodRefreshTasksResponse = new DescribeVodRefreshTasksResponse();

			describeVodRefreshTasksResponse.HttpResponse = context.HttpResponse;
			describeVodRefreshTasksResponse.RequestId = context.StringValue("DescribeVodRefreshTasks.RequestId");
			describeVodRefreshTasksResponse.PageNumber = context.LongValue("DescribeVodRefreshTasks.PageNumber");
			describeVodRefreshTasksResponse.PageSize = context.LongValue("DescribeVodRefreshTasks.PageSize");
			describeVodRefreshTasksResponse.TotalCount = context.LongValue("DescribeVodRefreshTasks.TotalCount");

			List<DescribeVodRefreshTasksResponse.DescribeVodRefreshTasks_Task> describeVodRefreshTasksResponse_tasks = new List<DescribeVodRefreshTasksResponse.DescribeVodRefreshTasks_Task>();
			for (int i = 0; i < context.Length("DescribeVodRefreshTasks.Tasks.Length"); i++) {
				DescribeVodRefreshTasksResponse.DescribeVodRefreshTasks_Task task = new DescribeVodRefreshTasksResponse.DescribeVodRefreshTasks_Task();
				task.TaskId = context.StringValue("DescribeVodRefreshTasks.Tasks["+ i +"].TaskId");
				task.ObjectPath = context.StringValue("DescribeVodRefreshTasks.Tasks["+ i +"].ObjectPath");
				task.Process = context.StringValue("DescribeVodRefreshTasks.Tasks["+ i +"].Process");
				task.Status = context.StringValue("DescribeVodRefreshTasks.Tasks["+ i +"].Status");
				task.CreationTime = context.StringValue("DescribeVodRefreshTasks.Tasks["+ i +"].CreationTime");
				task.Description = context.StringValue("DescribeVodRefreshTasks.Tasks["+ i +"].Description");
				task.ObjectType = context.StringValue("DescribeVodRefreshTasks.Tasks["+ i +"].ObjectType");

				describeVodRefreshTasksResponse_tasks.Add(task);
			}
			describeVodRefreshTasksResponse.Tasks = describeVodRefreshTasksResponse_tasks;
        
			return describeVodRefreshTasksResponse;
        }
    }
}
