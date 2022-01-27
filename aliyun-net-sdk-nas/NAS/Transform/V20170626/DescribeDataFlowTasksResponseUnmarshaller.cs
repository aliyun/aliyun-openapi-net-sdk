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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeDataFlowTasksResponseUnmarshaller
    {
        public static DescribeDataFlowTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataFlowTasksResponse describeDataFlowTasksResponse = new DescribeDataFlowTasksResponse();

			describeDataFlowTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeDataFlowTasksResponse.RequestId = _ctx.StringValue("DescribeDataFlowTasks.RequestId");
			describeDataFlowTasksResponse.NextToken = _ctx.StringValue("DescribeDataFlowTasks.NextToken");

			List<DescribeDataFlowTasksResponse.DescribeDataFlowTasks_Task> describeDataFlowTasksResponse_taskInfo = new List<DescribeDataFlowTasksResponse.DescribeDataFlowTasks_Task>();
			for (int i = 0; i < _ctx.Length("DescribeDataFlowTasks.TaskInfo.Length"); i++) {
				DescribeDataFlowTasksResponse.DescribeDataFlowTasks_Task task = new DescribeDataFlowTasksResponse.DescribeDataFlowTasks_Task();
				task.FilesystemId = _ctx.StringValue("DescribeDataFlowTasks.TaskInfo["+ i +"].FilesystemId");
				task.DataFlowId = _ctx.StringValue("DescribeDataFlowTasks.TaskInfo["+ i +"].DataFlowId");
				task.TaskId = _ctx.StringValue("DescribeDataFlowTasks.TaskInfo["+ i +"].TaskId");
				task.SourceStorage = _ctx.StringValue("DescribeDataFlowTasks.TaskInfo["+ i +"].SourceStorage");
				task.FileSystemPath = _ctx.StringValue("DescribeDataFlowTasks.TaskInfo["+ i +"].FileSystemPath");
				task.Originator = _ctx.StringValue("DescribeDataFlowTasks.TaskInfo["+ i +"].Originator");
				task.TaskAction = _ctx.StringValue("DescribeDataFlowTasks.TaskInfo["+ i +"].TaskAction");
				task.DataType = _ctx.StringValue("DescribeDataFlowTasks.TaskInfo["+ i +"].DataType");
				task.Progress = _ctx.LongValue("DescribeDataFlowTasks.TaskInfo["+ i +"].Progress");
				task.Status = _ctx.StringValue("DescribeDataFlowTasks.TaskInfo["+ i +"].Status");
				task.ReportPath = _ctx.StringValue("DescribeDataFlowTasks.TaskInfo["+ i +"].ReportPath");
				task.CreateTime = _ctx.StringValue("DescribeDataFlowTasks.TaskInfo["+ i +"].CreateTime");
				task.StartTime = _ctx.StringValue("DescribeDataFlowTasks.TaskInfo["+ i +"].StartTime");
				task.EndTime = _ctx.StringValue("DescribeDataFlowTasks.TaskInfo["+ i +"].EndTime");
				task.FsPath = _ctx.StringValue("DescribeDataFlowTasks.TaskInfo["+ i +"].FsPath");

				describeDataFlowTasksResponse_taskInfo.Add(task);
			}
			describeDataFlowTasksResponse.TaskInfo = describeDataFlowTasksResponse_taskInfo;
        
			return describeDataFlowTasksResponse;
        }
    }
}
