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
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeRefreshTasksResponseUnmarshaller
    {
        public static DescribeRefreshTasksResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeRefreshTasksResponse describeRefreshTasksResponse = new DescribeRefreshTasksResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeRefreshTasks.RequestId"),
                PageNumber = context.LongValue("DescribeRefreshTasks.PageNumber"),
                PageSize = context.LongValue("DescribeRefreshTasks.PageSize"),
                TotalCount = context.LongValue("DescribeRefreshTasks.TotalCount")
            };
            List<DescribeRefreshTasksResponse.CdnTask> tasks = new List<DescribeRefreshTasksResponse.CdnTask>();
			for (int i = 0; i < context.Length("DescribeRefreshTasks.Tasks.Length"); i++) {
                DescribeRefreshTasksResponse.CdnTask cDnTask = new DescribeRefreshTasksResponse.CdnTask()
                {
                    TaskId = context.StringValue($"DescribeRefreshTasks.Tasks[{i}].TaskId"),
                    ObjectPath = context.StringValue($"DescribeRefreshTasks.Tasks[{i}].ObjectPath"),
                    Process = context.StringValue($"DescribeRefreshTasks.Tasks[{i}].Process"),
                    Status = context.StringValue($"DescribeRefreshTasks.Tasks[{i}].Status"),
                    CreationTime = context.StringValue($"DescribeRefreshTasks.Tasks[{i}].CreationTime")
                };
                tasks.Add(cDnTask);
			}
			describeRefreshTasksResponse.Tasks = tasks;
        
			return describeRefreshTasksResponse;
        }
    }
}