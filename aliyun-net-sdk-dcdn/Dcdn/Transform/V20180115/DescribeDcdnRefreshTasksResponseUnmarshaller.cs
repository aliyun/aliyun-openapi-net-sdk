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
        public static DescribeDcdnRefreshTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnRefreshTasksResponse describeDcdnRefreshTasksResponse = new DescribeDcdnRefreshTasksResponse();

			describeDcdnRefreshTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnRefreshTasksResponse.RequestId = _ctx.StringValue("DescribeDcdnRefreshTasks.RequestId");
			describeDcdnRefreshTasksResponse.PageNumber = _ctx.LongValue("DescribeDcdnRefreshTasks.PageNumber");
			describeDcdnRefreshTasksResponse.PageSize = _ctx.LongValue("DescribeDcdnRefreshTasks.PageSize");
			describeDcdnRefreshTasksResponse.TotalCount = _ctx.LongValue("DescribeDcdnRefreshTasks.TotalCount");

			List<DescribeDcdnRefreshTasksResponse.DescribeDcdnRefreshTasks_Task> describeDcdnRefreshTasksResponse_tasks = new List<DescribeDcdnRefreshTasksResponse.DescribeDcdnRefreshTasks_Task>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnRefreshTasks.Tasks.Length"); i++) {
				DescribeDcdnRefreshTasksResponse.DescribeDcdnRefreshTasks_Task task = new DescribeDcdnRefreshTasksResponse.DescribeDcdnRefreshTasks_Task();
				task.TaskId = _ctx.StringValue("DescribeDcdnRefreshTasks.Tasks["+ i +"].TaskId");
				task.ObjectPath = _ctx.StringValue("DescribeDcdnRefreshTasks.Tasks["+ i +"].ObjectPath");
				task.Process = _ctx.StringValue("DescribeDcdnRefreshTasks.Tasks["+ i +"].Process");
				task.Status = _ctx.StringValue("DescribeDcdnRefreshTasks.Tasks["+ i +"].Status");
				task.CreationTime = _ctx.StringValue("DescribeDcdnRefreshTasks.Tasks["+ i +"].CreationTime");
				task.Description = _ctx.StringValue("DescribeDcdnRefreshTasks.Tasks["+ i +"].Description");
				task.ObjectType = _ctx.StringValue("DescribeDcdnRefreshTasks.Tasks["+ i +"].ObjectType");

				describeDcdnRefreshTasksResponse_tasks.Add(task);
			}
			describeDcdnRefreshTasksResponse.Tasks = describeDcdnRefreshTasksResponse_tasks;
        
			return describeDcdnRefreshTasksResponse;
        }
    }
}
