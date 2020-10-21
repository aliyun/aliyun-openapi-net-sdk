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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeTasksResponseUnmarshaller
    {
        public static DescribeTasksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTasksResponse describeTasksResponse = new DescribeTasksResponse();

			describeTasksResponse.HttpResponse = context.HttpResponse;
			describeTasksResponse.RequestId = context.StringValue("DescribeTasks.RequestId");
			describeTasksResponse.Success = context.BooleanValue("DescribeTasks.Success");
			describeTasksResponse.Code = context.StringValue("DescribeTasks.Code");
			describeTasksResponse.Message = context.StringValue("DescribeTasks.Message");
			describeTasksResponse.TotalCount = context.IntegerValue("DescribeTasks.TotalCount");
			describeTasksResponse.PageNumber = context.IntegerValue("DescribeTasks.PageNumber");
			describeTasksResponse.PageSize = context.IntegerValue("DescribeTasks.PageSize");

			List<DescribeTasksResponse.DescribeTasks_SimpleTask> describeTasksResponse_tasks = new List<DescribeTasksResponse.DescribeTasks_SimpleTask>();
			for (int i = 0; i < context.Length("DescribeTasks.Tasks.Length"); i++) {
				DescribeTasksResponse.DescribeTasks_SimpleTask simpleTask = new DescribeTasksResponse.DescribeTasks_SimpleTask();
				simpleTask.TaskId = context.StringValue("DescribeTasks.Tasks["+ i +"].TaskId");
				simpleTask.Name = context.StringValue("DescribeTasks.Tasks["+ i +"].Name");
				simpleTask.CreatedTime = context.LongValue("DescribeTasks.Tasks["+ i +"].CreatedTime");
				simpleTask.UpdatedTime = context.LongValue("DescribeTasks.Tasks["+ i +"].UpdatedTime");
				simpleTask.Progress = context.IntegerValue("DescribeTasks.Tasks["+ i +"].Progress");
				simpleTask.StateCode = context.StringValue("DescribeTasks.Tasks["+ i +"].StateCode");
				simpleTask.StageCode = context.StringValue("DescribeTasks.Tasks["+ i +"].StageCode");
				simpleTask.MessageKey = context.StringValue("DescribeTasks.Tasks["+ i +"].MessageKey");
				simpleTask.MessageParams = context.StringValue("DescribeTasks.Tasks["+ i +"].MessageParams");

				describeTasksResponse_tasks.Add(simpleTask);
			}
			describeTasksResponse.Tasks = describeTasksResponse_tasks;
        
			return describeTasksResponse;
        }
    }
}
