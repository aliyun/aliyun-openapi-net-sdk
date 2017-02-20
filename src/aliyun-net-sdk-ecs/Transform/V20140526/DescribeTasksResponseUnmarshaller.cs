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
using Aliyun.Acs.Ecs.Model.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeTasksResponseUnmarshaller
    {
        public static DescribeTasksResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeTasksResponse describeTasksResponse = new DescribeTasksResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeTasks.RequestId"),
                RegionId = context.StringValue("DescribeTasks.RegionId"),
                TotalCount = context.IntegerValue("DescribeTasks.TotalCount"),
                PageNumber = context.IntegerValue("DescribeTasks.PageNumber"),
                PageSize = context.IntegerValue("DescribeTasks.PageSize")
            };
            List<DescribeTasksResponse.Task> taskSet = new List<DescribeTasksResponse.Task>();
			for (int i = 0; i < context.Length("DescribeTasks.TaskSet.Length"); i++) {
                DescribeTasksResponse.Task task = new DescribeTasksResponse.Task()
                {
                    TaskId = context.StringValue($"DescribeTasks.TaskSet[{i}].TaskId"),
                    TaskAction = context.StringValue($"DescribeTasks.TaskSet[{i}].TaskAction"),
                    TaskStatus = context.StringValue($"DescribeTasks.TaskSet[{i}].TaskStatus"),
                    SupportCancel = context.StringValue($"DescribeTasks.TaskSet[{i}].SupportCancel"),
                    CreationTime = context.StringValue($"DescribeTasks.TaskSet[{i}].CreationTime"),
                    FinishedTime = context.StringValue($"DescribeTasks.TaskSet[{i}].FinishedTime")
                };
                taskSet.Add(task);
			}
			describeTasksResponse.TaskSet = taskSet;
        
			return describeTasksResponse;
        }
    }
}