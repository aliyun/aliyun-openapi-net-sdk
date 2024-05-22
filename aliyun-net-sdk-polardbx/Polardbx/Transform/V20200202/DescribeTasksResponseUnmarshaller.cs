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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeTasksResponseUnmarshaller
    {
        public static DescribeTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTasksResponse describeTasksResponse = new DescribeTasksResponse();

			describeTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeTasksResponse.RequestId = _ctx.StringValue("DescribeTasks.RequestId");
			describeTasksResponse.PageNumber = _ctx.IntegerValue("DescribeTasks.PageNumber");
			describeTasksResponse.PageRecordCount = _ctx.IntegerValue("DescribeTasks.PageRecordCount");
			describeTasksResponse.TotalRecordCount = _ctx.IntegerValue("DescribeTasks.TotalRecordCount");

			List<DescribeTasksResponse.DescribeTasks_TaskProgressInfo> describeTasksResponse_items = new List<DescribeTasksResponse.DescribeTasks_TaskProgressInfo>();
			for (int i = 0; i < _ctx.Length("DescribeTasks.Items.Length"); i++) {
				DescribeTasksResponse.DescribeTasks_TaskProgressInfo taskProgressInfo = new DescribeTasksResponse.DescribeTasks_TaskProgressInfo();
				taskProgressInfo.Status = _ctx.StringValue("DescribeTasks.Items["+ i +"].Status");
				taskProgressInfo.FinishTime = _ctx.StringValue("DescribeTasks.Items["+ i +"].FinishTime");
				taskProgressInfo.Progress = _ctx.StringValue("DescribeTasks.Items["+ i +"].Progress");
				taskProgressInfo.BeginTime = _ctx.StringValue("DescribeTasks.Items["+ i +"].BeginTime");
				taskProgressInfo.TaskErrorCode = _ctx.StringValue("DescribeTasks.Items["+ i +"].TaskErrorCode");
				taskProgressInfo.DBName = _ctx.StringValue("DescribeTasks.Items["+ i +"].DBName");
				taskProgressInfo.ProgressInfo = _ctx.StringValue("DescribeTasks.Items["+ i +"].ProgressInfo");
				taskProgressInfo.ScaleOutToken = _ctx.StringValue("DescribeTasks.Items["+ i +"].ScaleOutToken");
				taskProgressInfo.TaskId = _ctx.StringValue("DescribeTasks.Items["+ i +"].TaskId");
				taskProgressInfo.TaskErrorMessage = _ctx.StringValue("DescribeTasks.Items["+ i +"].TaskErrorMessage");
				taskProgressInfo.TaskAction = _ctx.StringValue("DescribeTasks.Items["+ i +"].TaskAction");

				describeTasksResponse_items.Add(taskProgressInfo);
			}
			describeTasksResponse.Items = describeTasksResponse_items;
        
			return describeTasksResponse;
        }
    }
}
