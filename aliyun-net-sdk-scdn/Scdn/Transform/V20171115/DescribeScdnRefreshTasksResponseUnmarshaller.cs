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
        public static DescribeScdnRefreshTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnRefreshTasksResponse describeScdnRefreshTasksResponse = new DescribeScdnRefreshTasksResponse();

			describeScdnRefreshTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnRefreshTasksResponse.RequestId = _ctx.StringValue("DescribeScdnRefreshTasks.RequestId");
			describeScdnRefreshTasksResponse.PageNumber = _ctx.LongValue("DescribeScdnRefreshTasks.PageNumber");
			describeScdnRefreshTasksResponse.PageSize = _ctx.LongValue("DescribeScdnRefreshTasks.PageSize");
			describeScdnRefreshTasksResponse.TotalCount = _ctx.LongValue("DescribeScdnRefreshTasks.TotalCount");

			List<DescribeScdnRefreshTasksResponse.DescribeScdnRefreshTasks_Task> describeScdnRefreshTasksResponse_tasks = new List<DescribeScdnRefreshTasksResponse.DescribeScdnRefreshTasks_Task>();
			for (int i = 0; i < _ctx.Length("DescribeScdnRefreshTasks.Tasks.Length"); i++) {
				DescribeScdnRefreshTasksResponse.DescribeScdnRefreshTasks_Task task = new DescribeScdnRefreshTasksResponse.DescribeScdnRefreshTasks_Task();
				task.TaskId = _ctx.StringValue("DescribeScdnRefreshTasks.Tasks["+ i +"].TaskId");
				task.ObjectPath = _ctx.StringValue("DescribeScdnRefreshTasks.Tasks["+ i +"].ObjectPath");
				task.Process = _ctx.StringValue("DescribeScdnRefreshTasks.Tasks["+ i +"].Process");
				task.Status = _ctx.StringValue("DescribeScdnRefreshTasks.Tasks["+ i +"].Status");
				task.CreationTime = _ctx.StringValue("DescribeScdnRefreshTasks.Tasks["+ i +"].CreationTime");
				task.Description = _ctx.StringValue("DescribeScdnRefreshTasks.Tasks["+ i +"].Description");
				task.ObjectType = _ctx.StringValue("DescribeScdnRefreshTasks.Tasks["+ i +"].ObjectType");

				describeScdnRefreshTasksResponse_tasks.Add(task);
			}
			describeScdnRefreshTasksResponse.Tasks = describeScdnRefreshTasksResponse_tasks;
        
			return describeScdnRefreshTasksResponse;
        }
    }
}
