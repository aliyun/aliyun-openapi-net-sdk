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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeRefreshTasksResponseUnmarshaller
    {
        public static DescribeRefreshTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRefreshTasksResponse describeRefreshTasksResponse = new DescribeRefreshTasksResponse();

			describeRefreshTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeRefreshTasksResponse.RequestId = _ctx.StringValue("DescribeRefreshTasks.RequestId");
			describeRefreshTasksResponse.PageNumber = _ctx.LongValue("DescribeRefreshTasks.PageNumber");
			describeRefreshTasksResponse.PageSize = _ctx.LongValue("DescribeRefreshTasks.PageSize");
			describeRefreshTasksResponse.TotalCount = _ctx.LongValue("DescribeRefreshTasks.TotalCount");

			List<DescribeRefreshTasksResponse.DescribeRefreshTasks_CDNTask> describeRefreshTasksResponse_tasks = new List<DescribeRefreshTasksResponse.DescribeRefreshTasks_CDNTask>();
			for (int i = 0; i < _ctx.Length("DescribeRefreshTasks.Tasks.Length"); i++) {
				DescribeRefreshTasksResponse.DescribeRefreshTasks_CDNTask cDNTask = new DescribeRefreshTasksResponse.DescribeRefreshTasks_CDNTask();
				cDNTask.TaskId = _ctx.StringValue("DescribeRefreshTasks.Tasks["+ i +"].TaskId");
				cDNTask.ObjectPath = _ctx.StringValue("DescribeRefreshTasks.Tasks["+ i +"].ObjectPath");
				cDNTask.Process = _ctx.StringValue("DescribeRefreshTasks.Tasks["+ i +"].Process");
				cDNTask.Status = _ctx.StringValue("DescribeRefreshTasks.Tasks["+ i +"].Status");
				cDNTask.CreationTime = _ctx.StringValue("DescribeRefreshTasks.Tasks["+ i +"].CreationTime");
				cDNTask.Description = _ctx.StringValue("DescribeRefreshTasks.Tasks["+ i +"].Description");
				cDNTask.ObjectType = _ctx.StringValue("DescribeRefreshTasks.Tasks["+ i +"].ObjectType");

				describeRefreshTasksResponse_tasks.Add(cDNTask);
			}
			describeRefreshTasksResponse.Tasks = describeRefreshTasksResponse_tasks;
        
			return describeRefreshTasksResponse;
        }
    }
}
