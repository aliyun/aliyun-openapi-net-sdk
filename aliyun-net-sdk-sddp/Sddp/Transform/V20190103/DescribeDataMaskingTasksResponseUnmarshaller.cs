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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeDataMaskingTasksResponseUnmarshaller
    {
        public static DescribeDataMaskingTasksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataMaskingTasksResponse describeDataMaskingTasksResponse = new DescribeDataMaskingTasksResponse();

			describeDataMaskingTasksResponse.HttpResponse = context.HttpResponse;
			describeDataMaskingTasksResponse.RequestId = context.StringValue("DescribeDataMaskingTasks.RequestId");
			describeDataMaskingTasksResponse.PageSize = context.IntegerValue("DescribeDataMaskingTasks.PageSize");
			describeDataMaskingTasksResponse.CurrentPage = context.IntegerValue("DescribeDataMaskingTasks.CurrentPage");
			describeDataMaskingTasksResponse.TotalCount = context.IntegerValue("DescribeDataMaskingTasks.TotalCount");

			List<DescribeDataMaskingTasksResponse.DescribeDataMaskingTasks_Task> describeDataMaskingTasksResponse_items = new List<DescribeDataMaskingTasksResponse.DescribeDataMaskingTasks_Task>();
			for (int i = 0; i < context.Length("DescribeDataMaskingTasks.Items.Length"); i++) {
				DescribeDataMaskingTasksResponse.DescribeDataMaskingTasks_Task task = new DescribeDataMaskingTasksResponse.DescribeDataMaskingTasks_Task();
				task.Id = context.LongValue("DescribeDataMaskingTasks.Items["+ i +"].Id");
				task.TaskId = context.StringValue("DescribeDataMaskingTasks.Items["+ i +"].TaskId");
				task.TaskName = context.StringValue("DescribeDataMaskingTasks.Items["+ i +"].TaskName");
				task.Owner = context.StringValue("DescribeDataMaskingTasks.Items["+ i +"].Owner");
				task.GmtCreate = context.LongValue("DescribeDataMaskingTasks.Items["+ i +"].GmtCreate");
				task.DstType = context.IntegerValue("DescribeDataMaskingTasks.Items["+ i +"].DstType");
				task.DstPath = context.StringValue("DescribeDataMaskingTasks.Items["+ i +"].DstPath");
				task.SrcType = context.IntegerValue("DescribeDataMaskingTasks.Items["+ i +"].SrcType");
				task.SrcPath = context.StringValue("DescribeDataMaskingTasks.Items["+ i +"].SrcPath");
				task.RunCount = context.IntegerValue("DescribeDataMaskingTasks.Items["+ i +"].RunCount");
				task.Status = context.IntegerValue("DescribeDataMaskingTasks.Items["+ i +"].Status");
				task.HasUnfinishProcess = context.BooleanValue("DescribeDataMaskingTasks.Items["+ i +"].HasUnfinishProcess");
				task.DstTypeCode = context.StringValue("DescribeDataMaskingTasks.Items["+ i +"].DstTypeCode");
				task.SrcTypeCode = context.StringValue("DescribeDataMaskingTasks.Items["+ i +"].SrcTypeCode");
				task.TriggerType = context.IntegerValue("DescribeDataMaskingTasks.Items["+ i +"].TriggerType");

				describeDataMaskingTasksResponse_items.Add(task);
			}
			describeDataMaskingTasksResponse.Items = describeDataMaskingTasksResponse_items;
        
			return describeDataMaskingTasksResponse;
        }
    }
}
