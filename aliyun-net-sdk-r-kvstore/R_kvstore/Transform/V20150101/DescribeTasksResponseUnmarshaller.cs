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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeTasksResponseUnmarshaller
    {
        public static DescribeTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTasksResponse describeTasksResponse = new DescribeTasksResponse();

			describeTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeTasksResponse.RequestId = _ctx.StringValue("DescribeTasks.RequestId");
			describeTasksResponse.PageNumber = _ctx.IntegerValue("DescribeTasks.PageNumber");
			describeTasksResponse.PageSize = _ctx.IntegerValue("DescribeTasks.PageSize");
			describeTasksResponse.TotalRecordCount = _ctx.IntegerValue("DescribeTasks.TotalRecordCount");

			List<DescribeTasksResponse.DescribeTasks_TaskProgressInfo> describeTasksResponse_items = new List<DescribeTasksResponse.DescribeTasks_TaskProgressInfo>();
			for (int i = 0; i < _ctx.Length("DescribeTasks.Items.Length"); i++) {
				DescribeTasksResponse.DescribeTasks_TaskProgressInfo taskProgressInfo = new DescribeTasksResponse.DescribeTasks_TaskProgressInfo();
				taskProgressInfo.Status = _ctx.StringValue("DescribeTasks.Items["+ i +"].Status");
				taskProgressInfo.FinishTime = _ctx.StringValue("DescribeTasks.Items["+ i +"].FinishTime");
				taskProgressInfo.StepsInfo = _ctx.StringValue("DescribeTasks.Items["+ i +"].StepsInfo");
				taskProgressInfo.Progress = _ctx.FloatValue("DescribeTasks.Items["+ i +"].Progress");
				taskProgressInfo.BeginTime = _ctx.StringValue("DescribeTasks.Items["+ i +"].BeginTime");
				taskProgressInfo.Remain = _ctx.IntegerValue("DescribeTasks.Items["+ i +"].Remain");
				taskProgressInfo.CurrentStepName = _ctx.StringValue("DescribeTasks.Items["+ i +"].CurrentStepName");
				taskProgressInfo.StepProgressInfo = _ctx.StringValue("DescribeTasks.Items["+ i +"].StepProgressInfo");
				taskProgressInfo.TaskId = _ctx.StringValue("DescribeTasks.Items["+ i +"].TaskId");
				taskProgressInfo.TaskAction = _ctx.StringValue("DescribeTasks.Items["+ i +"].TaskAction");

				describeTasksResponse_items.Add(taskProgressInfo);
			}
			describeTasksResponse.Items = describeTasksResponse_items;
        
			return describeTasksResponse;
        }
    }
}
