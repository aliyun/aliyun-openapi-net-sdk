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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnRefreshTasksResponseUnmarshaller
    {
        public static DescribeScdnRefreshTasksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnRefreshTasksResponse describeScdnRefreshTasksResponse = new DescribeScdnRefreshTasksResponse();

			describeScdnRefreshTasksResponse.HttpResponse = context.HttpResponse;
			describeScdnRefreshTasksResponse.RequestId = context.StringValue("DescribeScdnRefreshTasks.RequestId");
			describeScdnRefreshTasksResponse.PageNumber = context.LongValue("DescribeScdnRefreshTasks.PageNumber");
			describeScdnRefreshTasksResponse.PageSize = context.LongValue("DescribeScdnRefreshTasks.PageSize");
			describeScdnRefreshTasksResponse.TotalCount = context.LongValue("DescribeScdnRefreshTasks.TotalCount");

			List<DescribeScdnRefreshTasksResponse.DescribeScdnRefreshTasks_Task> describeScdnRefreshTasksResponse_tasks = new List<DescribeScdnRefreshTasksResponse.DescribeScdnRefreshTasks_Task>();
			for (int i = 0; i < context.Length("DescribeScdnRefreshTasks.Tasks.Length"); i++) {
				DescribeScdnRefreshTasksResponse.DescribeScdnRefreshTasks_Task task = new DescribeScdnRefreshTasksResponse.DescribeScdnRefreshTasks_Task();
				task.TaskId = context.StringValue("DescribeScdnRefreshTasks.Tasks["+ i +"].TaskId");
				task.ObjectPath = context.StringValue("DescribeScdnRefreshTasks.Tasks["+ i +"].ObjectPath");
				task.Process = context.StringValue("DescribeScdnRefreshTasks.Tasks["+ i +"].Process");
				task.Status = context.StringValue("DescribeScdnRefreshTasks.Tasks["+ i +"].Status");
				task.CreationTime = context.StringValue("DescribeScdnRefreshTasks.Tasks["+ i +"].CreationTime");
				task.Description = context.StringValue("DescribeScdnRefreshTasks.Tasks["+ i +"].Description");
				task.ObjectType = context.StringValue("DescribeScdnRefreshTasks.Tasks["+ i +"].ObjectType");

				describeScdnRefreshTasksResponse_tasks.Add(task);
			}
			describeScdnRefreshTasksResponse.Tasks = describeScdnRefreshTasksResponse_tasks;
        
			return describeScdnRefreshTasksResponse;
        }
    }
}
