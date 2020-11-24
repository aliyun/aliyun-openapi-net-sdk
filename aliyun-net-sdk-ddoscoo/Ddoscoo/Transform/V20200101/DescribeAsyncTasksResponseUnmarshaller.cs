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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeAsyncTasksResponseUnmarshaller
    {
        public static DescribeAsyncTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAsyncTasksResponse describeAsyncTasksResponse = new DescribeAsyncTasksResponse();

			describeAsyncTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeAsyncTasksResponse.RequestId = _ctx.StringValue("DescribeAsyncTasks.RequestId");
			describeAsyncTasksResponse.TotalCount = _ctx.IntegerValue("DescribeAsyncTasks.TotalCount");

			List<DescribeAsyncTasksResponse.DescribeAsyncTasks_AsyncTask> describeAsyncTasksResponse_asyncTasks = new List<DescribeAsyncTasksResponse.DescribeAsyncTasks_AsyncTask>();
			for (int i = 0; i < _ctx.Length("DescribeAsyncTasks.AsyncTasks.Length"); i++) {
				DescribeAsyncTasksResponse.DescribeAsyncTasks_AsyncTask asyncTask = new DescribeAsyncTasksResponse.DescribeAsyncTasks_AsyncTask();
				asyncTask.TaskId = _ctx.LongValue("DescribeAsyncTasks.AsyncTasks["+ i +"].TaskId");
				asyncTask.EndTime = _ctx.LongValue("DescribeAsyncTasks.AsyncTasks["+ i +"].EndTime");
				asyncTask.StartTime = _ctx.LongValue("DescribeAsyncTasks.AsyncTasks["+ i +"].StartTime");
				asyncTask.TaskStatus = _ctx.IntegerValue("DescribeAsyncTasks.AsyncTasks["+ i +"].TaskStatus");
				asyncTask.TaskResult = _ctx.StringValue("DescribeAsyncTasks.AsyncTasks["+ i +"].TaskResult");
				asyncTask.TaskParams = _ctx.StringValue("DescribeAsyncTasks.AsyncTasks["+ i +"].TaskParams");
				asyncTask.TaskType = _ctx.IntegerValue("DescribeAsyncTasks.AsyncTasks["+ i +"].TaskType");

				describeAsyncTasksResponse_asyncTasks.Add(asyncTask);
			}
			describeAsyncTasksResponse.AsyncTasks = describeAsyncTasksResponse_asyncTasks;
        
			return describeAsyncTasksResponse;
        }
    }
}
