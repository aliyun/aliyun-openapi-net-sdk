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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeRefreshTasksResponseUnmarshaller
    {
        public static DescribeRefreshTasksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRefreshTasksResponse describeRefreshTasksResponse = new DescribeRefreshTasksResponse();

			describeRefreshTasksResponse.HttpResponse = context.HttpResponse;
			describeRefreshTasksResponse.RequestId = context.StringValue("DescribeRefreshTasks.RequestId");
			describeRefreshTasksResponse.PageNumber = context.LongValue("DescribeRefreshTasks.PageNumber");
			describeRefreshTasksResponse.PageSize = context.LongValue("DescribeRefreshTasks.PageSize");
			describeRefreshTasksResponse.TotalCount = context.LongValue("DescribeRefreshTasks.TotalCount");

			List<DescribeRefreshTasksResponse.DescribeRefreshTasks_CDNTask> describeRefreshTasksResponse_tasks = new List<DescribeRefreshTasksResponse.DescribeRefreshTasks_CDNTask>();
			for (int i = 0; i < context.Length("DescribeRefreshTasks.Tasks.Length"); i++) {
				DescribeRefreshTasksResponse.DescribeRefreshTasks_CDNTask cDNTask = new DescribeRefreshTasksResponse.DescribeRefreshTasks_CDNTask();
				cDNTask.TaskId = context.StringValue("DescribeRefreshTasks.Tasks["+ i +"].TaskId");
				cDNTask.ObjectPath = context.StringValue("DescribeRefreshTasks.Tasks["+ i +"].ObjectPath");
				cDNTask.Process = context.StringValue("DescribeRefreshTasks.Tasks["+ i +"].Process");
				cDNTask.Status = context.StringValue("DescribeRefreshTasks.Tasks["+ i +"].Status");
				cDNTask.CreationTime = context.StringValue("DescribeRefreshTasks.Tasks["+ i +"].CreationTime");
				cDNTask.Description = context.StringValue("DescribeRefreshTasks.Tasks["+ i +"].Description");

				describeRefreshTasksResponse_tasks.Add(cDNTask);
			}
			describeRefreshTasksResponse.Tasks = describeRefreshTasksResponse_tasks;
        
			return describeRefreshTasksResponse;
        }
    }
}