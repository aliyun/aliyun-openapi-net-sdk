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
    public class DescribeTasksResponseUnmarshaller
    {
        public static DescribeTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTasksResponse describeTasksResponse = new DescribeTasksResponse();

			describeTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeTasksResponse.TotalCount = _ctx.IntegerValue("DescribeTasks.TotalCount");
			describeTasksResponse.RequestId = _ctx.StringValue("DescribeTasks.RequestId");
			describeTasksResponse.Message = _ctx.StringValue("DescribeTasks.Message");
			describeTasksResponse.PageSize = _ctx.IntegerValue("DescribeTasks.PageSize");
			describeTasksResponse.PageNumber = _ctx.IntegerValue("DescribeTasks.PageNumber");
			describeTasksResponse.Code = _ctx.StringValue("DescribeTasks.Code");
			describeTasksResponse.Success = _ctx.BooleanValue("DescribeTasks.Success");

			List<DescribeTasksResponse.DescribeTasks_SimpleTask> describeTasksResponse_tasks = new List<DescribeTasksResponse.DescribeTasks_SimpleTask>();
			for (int i = 0; i < _ctx.Length("DescribeTasks.Tasks.Length"); i++) {
				DescribeTasksResponse.DescribeTasks_SimpleTask simpleTask = new DescribeTasksResponse.DescribeTasks_SimpleTask();
				simpleTask.StateCode = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].StateCode");
				simpleTask.Progress = _ctx.IntegerValue("DescribeTasks.Tasks["+ i +"].Progress");
				simpleTask.MessageParams = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].MessageParams");
				simpleTask.UpdatedTime = _ctx.LongValue("DescribeTasks.Tasks["+ i +"].UpdatedTime");
				simpleTask.MessageKey = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].MessageKey");
				simpleTask.Name = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].Name");
				simpleTask.StageCode = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].StageCode");
				simpleTask.CreatedTime = _ctx.LongValue("DescribeTasks.Tasks["+ i +"].CreatedTime");
				simpleTask.TaskId = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].TaskId");
				simpleTask.RelatedResourceId = _ctx.StringValue("DescribeTasks.Tasks["+ i +"].RelatedResourceId");

				describeTasksResponse_tasks.Add(simpleTask);
			}
			describeTasksResponse.Tasks = describeTasksResponse_tasks;
        
			return describeTasksResponse;
        }
    }
}
