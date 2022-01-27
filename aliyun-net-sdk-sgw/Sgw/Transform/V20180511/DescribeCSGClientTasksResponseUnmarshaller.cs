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
    public class DescribeCSGClientTasksResponseUnmarshaller
    {
        public static DescribeCSGClientTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCSGClientTasksResponse describeCSGClientTasksResponse = new DescribeCSGClientTasksResponse();

			describeCSGClientTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeCSGClientTasksResponse.RequestId = _ctx.StringValue("DescribeCSGClientTasks.RequestId");
			describeCSGClientTasksResponse.Success = _ctx.BooleanValue("DescribeCSGClientTasks.Success");
			describeCSGClientTasksResponse.Code = _ctx.StringValue("DescribeCSGClientTasks.Code");
			describeCSGClientTasksResponse.Message = _ctx.StringValue("DescribeCSGClientTasks.Message");
			describeCSGClientTasksResponse.PageSize = _ctx.IntegerValue("DescribeCSGClientTasks.PageSize");
			describeCSGClientTasksResponse.PageNumber = _ctx.IntegerValue("DescribeCSGClientTasks.PageNumber");
			describeCSGClientTasksResponse.TotalCount = _ctx.IntegerValue("DescribeCSGClientTasks.TotalCount");

			List<DescribeCSGClientTasksResponse.DescribeCSGClientTasks_Task> describeCSGClientTasksResponse_tasks = new List<DescribeCSGClientTasksResponse.DescribeCSGClientTasks_Task>();
			for (int i = 0; i < _ctx.Length("DescribeCSGClientTasks.Tasks.Length"); i++) {
				DescribeCSGClientTasksResponse.DescribeCSGClientTasks_Task task = new DescribeCSGClientTasksResponse.DescribeCSGClientTasks_Task();
				task.StateCode = _ctx.StringValue("DescribeCSGClientTasks.Tasks["+ i +"].StateCode");
				task.Progress = _ctx.IntegerValue("DescribeCSGClientTasks.Tasks["+ i +"].Progress");
				task.MessageParams = _ctx.StringValue("DescribeCSGClientTasks.Tasks["+ i +"].MessageParams");
				task.UpdatedTime = _ctx.LongValue("DescribeCSGClientTasks.Tasks["+ i +"].UpdatedTime");
				task.MessageKey = _ctx.StringValue("DescribeCSGClientTasks.Tasks["+ i +"].MessageKey");
				task.Name = _ctx.StringValue("DescribeCSGClientTasks.Tasks["+ i +"].Name");
				task.TaskId = _ctx.StringValue("DescribeCSGClientTasks.Tasks["+ i +"].TaskId");
				task.CreatedTime = _ctx.LongValue("DescribeCSGClientTasks.Tasks["+ i +"].CreatedTime");

				describeCSGClientTasksResponse_tasks.Add(task);
			}
			describeCSGClientTasksResponse.Tasks = describeCSGClientTasksResponse_tasks;
        
			return describeCSGClientTasksResponse;
        }
    }
}
