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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeOnceTaskResponseUnmarshaller
    {
        public static DescribeOnceTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOnceTaskResponse describeOnceTaskResponse = new DescribeOnceTaskResponse();

			describeOnceTaskResponse.HttpResponse = _ctx.HttpResponse;
			describeOnceTaskResponse.RequestId = _ctx.StringValue("DescribeOnceTask.RequestId");

			DescribeOnceTaskResponse.DescribeOnceTask_PageInfo pageInfo = new DescribeOnceTaskResponse.DescribeOnceTask_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeOnceTask.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeOnceTask.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeOnceTask.PageInfo.TotalCount");
			pageInfo.Count = _ctx.IntegerValue("DescribeOnceTask.PageInfo.Count");
			describeOnceTaskResponse.PageInfo = pageInfo;

			List<DescribeOnceTaskResponse.DescribeOnceTask_TaskManageResponse> describeOnceTaskResponse_taskManageResponseList = new List<DescribeOnceTaskResponse.DescribeOnceTask_TaskManageResponse>();
			for (int i = 0; i < _ctx.Length("DescribeOnceTask.TaskManageResponseList.Length"); i++) {
				DescribeOnceTaskResponse.DescribeOnceTask_TaskManageResponse taskManageResponse = new DescribeOnceTaskResponse.DescribeOnceTask_TaskManageResponse();
				taskManageResponse.TaskType = _ctx.StringValue("DescribeOnceTask.TaskManageResponseList["+ i +"].TaskType");
				taskManageResponse.Progress = _ctx.StringValue("DescribeOnceTask.TaskManageResponseList["+ i +"].Progress");
				taskManageResponse.TaskStatus = _ctx.IntegerValue("DescribeOnceTask.TaskManageResponseList["+ i +"].TaskStatus");
				taskManageResponse.DetailData = _ctx.StringValue("DescribeOnceTask.TaskManageResponseList["+ i +"].DetailData");
				taskManageResponse.TaskStatusText = _ctx.StringValue("DescribeOnceTask.TaskManageResponseList["+ i +"].TaskStatusText");
				taskManageResponse.TaskName = _ctx.StringValue("DescribeOnceTask.TaskManageResponseList["+ i +"].TaskName");
				taskManageResponse.TaskStartTime = _ctx.LongValue("DescribeOnceTask.TaskManageResponseList["+ i +"].TaskStartTime");
				taskManageResponse.TaskEndTime = _ctx.LongValue("DescribeOnceTask.TaskManageResponseList["+ i +"].TaskEndTime");
				taskManageResponse.TaskId = _ctx.StringValue("DescribeOnceTask.TaskManageResponseList["+ i +"].TaskId");

				describeOnceTaskResponse_taskManageResponseList.Add(taskManageResponse);
			}
			describeOnceTaskResponse.TaskManageResponseList = describeOnceTaskResponse_taskManageResponseList;
        
			return describeOnceTaskResponse;
        }
    }
}
