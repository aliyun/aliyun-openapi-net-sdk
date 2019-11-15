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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnRefreshTasksResponseUnmarshaller
    {
        public static DescribeDcdnRefreshTasksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnRefreshTasksResponse describeDcdnRefreshTasksResponse = new DescribeDcdnRefreshTasksResponse();

			describeDcdnRefreshTasksResponse.HttpResponse = context.HttpResponse;
			describeDcdnRefreshTasksResponse.RequestId = context.StringValue("DescribeDcdnRefreshTasks.RequestId");
			describeDcdnRefreshTasksResponse.PageNumber = context.LongValue("DescribeDcdnRefreshTasks.PageNumber");
			describeDcdnRefreshTasksResponse.PageSize = context.LongValue("DescribeDcdnRefreshTasks.PageSize");
			describeDcdnRefreshTasksResponse.TotalCount = context.LongValue("DescribeDcdnRefreshTasks.TotalCount");

			List<DescribeDcdnRefreshTasksResponse.DescribeDcdnRefreshTasks_Task> describeDcdnRefreshTasksResponse_tasks = new List<DescribeDcdnRefreshTasksResponse.DescribeDcdnRefreshTasks_Task>();
			for (int i = 0; i < context.Length("DescribeDcdnRefreshTasks.Tasks.Length"); i++) {
				DescribeDcdnRefreshTasksResponse.DescribeDcdnRefreshTasks_Task task = new DescribeDcdnRefreshTasksResponse.DescribeDcdnRefreshTasks_Task();
				task.TaskId = context.StringValue("DescribeDcdnRefreshTasks.Tasks["+ i +"].TaskId");
				task.ObjectPath = context.StringValue("DescribeDcdnRefreshTasks.Tasks["+ i +"].ObjectPath");
				task.Process = context.StringValue("DescribeDcdnRefreshTasks.Tasks["+ i +"].Process");
				task.Status = context.StringValue("DescribeDcdnRefreshTasks.Tasks["+ i +"].Status");
				task.CreationTime = context.StringValue("DescribeDcdnRefreshTasks.Tasks["+ i +"].CreationTime");
				task.Description = context.StringValue("DescribeDcdnRefreshTasks.Tasks["+ i +"].Description");
				task.ObjectType = context.StringValue("DescribeDcdnRefreshTasks.Tasks["+ i +"].ObjectType");

				describeDcdnRefreshTasksResponse_tasks.Add(task);
			}
			describeDcdnRefreshTasksResponse.Tasks = describeDcdnRefreshTasksResponse_tasks;
        
			return describeDcdnRefreshTasksResponse;
        }
    }
}
