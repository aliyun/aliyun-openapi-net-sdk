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
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class DescribeTasksResponseUnmarshaller
    {
        public static DescribeTasksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTasksResponse describeTasksResponse = new DescribeTasksResponse();

			describeTasksResponse.HttpResponse = context.HttpResponse;
			describeTasksResponse.RequestId = context.StringValue("DescribeTasks.RequestId");
			describeTasksResponse.Success = context.BooleanValue("DescribeTasks.Success");
			describeTasksResponse.ErrorCode = context.IntegerValue("DescribeTasks.ErrorCode");
			describeTasksResponse.DynamicCode = context.StringValue("DescribeTasks.DynamicCode");
			describeTasksResponse.DynamicMessage = context.StringValue("DescribeTasks.DynamicMessage");

			List<DescribeTasksResponse.DescribeTasks_Task> describeTasksResponse_result = new List<DescribeTasksResponse.DescribeTasks_Task>();
			for (int i = 0; i < context.Length("DescribeTasks.Result.Length"); i++) {
				DescribeTasksResponse.DescribeTasks_Task task = new DescribeTasksResponse.DescribeTasks_Task();
				task.TaskId = context.IntegerValue("DescribeTasks.Result["+ i +"].TaskId");
				task.Action = context.StringValue("DescribeTasks.Result["+ i +"].Action");
				task.Target = context.StringValue("DescribeTasks.Result["+ i +"].Target");
				task.Sender = context.StringValue("DescribeTasks.Result["+ i +"].Sender");
				task.RequestTime = context.LongValue("DescribeTasks.Result["+ i +"].RequestTime");
				task.ResponseTime = context.StringValue("DescribeTasks.Result["+ i +"].ResponseTime");
				task.Handled = context.BooleanValue("DescribeTasks.Result["+ i +"].Handled");
				task.Result = context.StringValue("DescribeTasks.Result["+ i +"].Result");
				task.OperationType = context.StringValue("DescribeTasks.Result["+ i +"].OperationType");

				describeTasksResponse_result.Add(task);
			}
			describeTasksResponse.Result = describeTasksResponse_result;
        
			return describeTasksResponse;
        }
    }
}