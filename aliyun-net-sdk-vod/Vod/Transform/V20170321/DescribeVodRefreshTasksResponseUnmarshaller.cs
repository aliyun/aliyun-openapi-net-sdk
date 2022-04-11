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
        public static DescribeVodRefreshTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodRefreshTasksResponse describeVodRefreshTasksResponse = new DescribeVodRefreshTasksResponse();

			describeVodRefreshTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeVodRefreshTasksResponse.RequestId = _ctx.StringValue("DescribeVodRefreshTasks.RequestId");
			describeVodRefreshTasksResponse.PageNumber = _ctx.LongValue("DescribeVodRefreshTasks.PageNumber");
			describeVodRefreshTasksResponse.PageSize = _ctx.LongValue("DescribeVodRefreshTasks.PageSize");
			describeVodRefreshTasksResponse.TotalCount = _ctx.LongValue("DescribeVodRefreshTasks.TotalCount");

			List<DescribeVodRefreshTasksResponse.DescribeVodRefreshTasks_Task> describeVodRefreshTasksResponse_tasks = new List<DescribeVodRefreshTasksResponse.DescribeVodRefreshTasks_Task>();
			for (int i = 0; i < _ctx.Length("DescribeVodRefreshTasks.Tasks.Length"); i++) {
				DescribeVodRefreshTasksResponse.DescribeVodRefreshTasks_Task task = new DescribeVodRefreshTasksResponse.DescribeVodRefreshTasks_Task();
				task.Status = _ctx.StringValue("DescribeVodRefreshTasks.Tasks["+ i +"].Status");
				task.CreationTime = _ctx.StringValue("DescribeVodRefreshTasks.Tasks["+ i +"].CreationTime");
				task.ObjectType = _ctx.StringValue("DescribeVodRefreshTasks.Tasks["+ i +"].ObjectType");
				task.Process = _ctx.StringValue("DescribeVodRefreshTasks.Tasks["+ i +"].Process");
				task.Description = _ctx.StringValue("DescribeVodRefreshTasks.Tasks["+ i +"].Description");
				task.ObjectPath = _ctx.StringValue("DescribeVodRefreshTasks.Tasks["+ i +"].ObjectPath");
				task.TaskId = _ctx.StringValue("DescribeVodRefreshTasks.Tasks["+ i +"].TaskId");

				describeVodRefreshTasksResponse_tasks.Add(task);
			}
			describeVodRefreshTasksResponse.Tasks = describeVodRefreshTasksResponse_tasks;
        
			return describeVodRefreshTasksResponse;
        }
    }
}
