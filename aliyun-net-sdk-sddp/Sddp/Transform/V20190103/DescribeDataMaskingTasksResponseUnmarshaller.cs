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
        public static DescribeDataMaskingTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataMaskingTasksResponse describeDataMaskingTasksResponse = new DescribeDataMaskingTasksResponse();

			describeDataMaskingTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeDataMaskingTasksResponse.CurrentPage = _ctx.IntegerValue("DescribeDataMaskingTasks.CurrentPage");
			describeDataMaskingTasksResponse.RequestId = _ctx.StringValue("DescribeDataMaskingTasks.RequestId");
			describeDataMaskingTasksResponse.PageSize = _ctx.IntegerValue("DescribeDataMaskingTasks.PageSize");
			describeDataMaskingTasksResponse.TotalCount = _ctx.IntegerValue("DescribeDataMaskingTasks.TotalCount");

			List<DescribeDataMaskingTasksResponse.DescribeDataMaskingTasks_Task> describeDataMaskingTasksResponse_items = new List<DescribeDataMaskingTasksResponse.DescribeDataMaskingTasks_Task>();
			for (int i = 0; i < _ctx.Length("DescribeDataMaskingTasks.Items.Length"); i++) {
				DescribeDataMaskingTasksResponse.DescribeDataMaskingTasks_Task task = new DescribeDataMaskingTasksResponse.DescribeDataMaskingTasks_Task();
				task.Status = _ctx.IntegerValue("DescribeDataMaskingTasks.Items["+ i +"].Status");
				task.Owner = _ctx.StringValue("DescribeDataMaskingTasks.Items["+ i +"].Owner");
				task.TaskName = _ctx.StringValue("DescribeDataMaskingTasks.Items["+ i +"].TaskName");
				task.SrcType = _ctx.IntegerValue("DescribeDataMaskingTasks.Items["+ i +"].SrcType");
				task.DstType = _ctx.IntegerValue("DescribeDataMaskingTasks.Items["+ i +"].DstType");
				task.HasUnfinishProcess = _ctx.BooleanValue("DescribeDataMaskingTasks.Items["+ i +"].HasUnfinishProcess");
				task.OriginalTable = _ctx.BooleanValue("DescribeDataMaskingTasks.Items["+ i +"].OriginalTable");
				task.TriggerType = _ctx.IntegerValue("DescribeDataMaskingTasks.Items["+ i +"].TriggerType");
				task.DstTypeCode = _ctx.StringValue("DescribeDataMaskingTasks.Items["+ i +"].DstTypeCode");
				task.RunCount = _ctx.IntegerValue("DescribeDataMaskingTasks.Items["+ i +"].RunCount");
				task.GmtCreate = _ctx.LongValue("DescribeDataMaskingTasks.Items["+ i +"].GmtCreate");
				task.TaskId = _ctx.StringValue("DescribeDataMaskingTasks.Items["+ i +"].TaskId");
				task.DstPath = _ctx.StringValue("DescribeDataMaskingTasks.Items["+ i +"].DstPath");
				task.SrcTypeCode = _ctx.StringValue("DescribeDataMaskingTasks.Items["+ i +"].SrcTypeCode");
				task.Id = _ctx.LongValue("DescribeDataMaskingTasks.Items["+ i +"].Id");
				task.SrcPath = _ctx.StringValue("DescribeDataMaskingTasks.Items["+ i +"].SrcPath");

				describeDataMaskingTasksResponse_items.Add(task);
			}
			describeDataMaskingTasksResponse.Items = describeDataMaskingTasksResponse_items;
        
			return describeDataMaskingTasksResponse;
        }
    }
}
