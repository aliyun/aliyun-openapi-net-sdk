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
    public class DescribeDataFlowSubTasksResponseUnmarshaller
    {
        public static DescribeDataFlowSubTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataFlowSubTasksResponse describeDataFlowSubTasksResponse = new DescribeDataFlowSubTasksResponse();

			describeDataFlowSubTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeDataFlowSubTasksResponse.RequestId = _ctx.StringValue("DescribeDataFlowSubTasks.RequestId");
			describeDataFlowSubTasksResponse.NextToken = _ctx.StringValue("DescribeDataFlowSubTasks.NextToken");

			List<DescribeDataFlowSubTasksResponse.DescribeDataFlowSubTasks_DataFlowSubTaskItem> describeDataFlowSubTasksResponse_dataFlowSubTask = new List<DescribeDataFlowSubTasksResponse.DescribeDataFlowSubTasks_DataFlowSubTaskItem>();
			for (int i = 0; i < _ctx.Length("DescribeDataFlowSubTasks.DataFlowSubTask.Length"); i++) {
				DescribeDataFlowSubTasksResponse.DescribeDataFlowSubTasks_DataFlowSubTaskItem dataFlowSubTaskItem = new DescribeDataFlowSubTasksResponse.DescribeDataFlowSubTasks_DataFlowSubTaskItem();
				dataFlowSubTaskItem.FileSystemId = _ctx.StringValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].FileSystemId");
				dataFlowSubTaskItem.DataFlowId = _ctx.StringValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].DataFlowId");
				dataFlowSubTaskItem.DataFlowTaskId = _ctx.StringValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].DataFlowTaskId");
				dataFlowSubTaskItem.DataFlowSubTaskId = _ctx.StringValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].DataFlowSubTaskId");
				dataFlowSubTaskItem.SrcFilePath = _ctx.StringValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].SrcFilePath");
				dataFlowSubTaskItem.DstFilePath = _ctx.StringValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].DstFilePath");
				dataFlowSubTaskItem.Status = _ctx.StringValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].Status");
				dataFlowSubTaskItem.Progress = _ctx.IntegerValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].Progress");
				dataFlowSubTaskItem.CreateTime = _ctx.StringValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].CreateTime");
				dataFlowSubTaskItem.StartTime = _ctx.StringValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].StartTime");
				dataFlowSubTaskItem.EndTime = _ctx.StringValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].EndTime");
				dataFlowSubTaskItem.ErrorMsg = _ctx.StringValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].ErrorMsg");

				DescribeDataFlowSubTasksResponse.DescribeDataFlowSubTasks_DataFlowSubTaskItem.DescribeDataFlowSubTasks_ProgressStats progressStats = new DescribeDataFlowSubTasksResponse.DescribeDataFlowSubTasks_DataFlowSubTaskItem.DescribeDataFlowSubTasks_ProgressStats();
				progressStats.BytesTotal = _ctx.LongValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].ProgressStats.BytesTotal");
				progressStats.BytesDone = _ctx.LongValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].ProgressStats.BytesDone");
				progressStats.ActualBytes = _ctx.LongValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].ProgressStats.ActualBytes");
				progressStats.AverageSpeed = _ctx.LongValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].ProgressStats.AverageSpeed");
				dataFlowSubTaskItem.ProgressStats = progressStats;

				DescribeDataFlowSubTasksResponse.DescribeDataFlowSubTasks_DataFlowSubTaskItem.DescribeDataFlowSubTasks_FileDetail fileDetail = new DescribeDataFlowSubTasksResponse.DescribeDataFlowSubTasks_DataFlowSubTaskItem.DescribeDataFlowSubTasks_FileDetail();
				fileDetail.ModifyTime = _ctx.LongValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].FileDetail.ModifyTime");
				fileDetail.Size = _ctx.LongValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].FileDetail.Size");
				fileDetail.Checksum = _ctx.StringValue("DescribeDataFlowSubTasks.DataFlowSubTask["+ i +"].FileDetail.Checksum");
				dataFlowSubTaskItem.FileDetail = fileDetail;

				describeDataFlowSubTasksResponse_dataFlowSubTask.Add(dataFlowSubTaskItem);
			}
			describeDataFlowSubTasksResponse.DataFlowSubTask = describeDataFlowSubTasksResponse_dataFlowSubTask;
        
			return describeDataFlowSubTasksResponse;
        }
    }
}
