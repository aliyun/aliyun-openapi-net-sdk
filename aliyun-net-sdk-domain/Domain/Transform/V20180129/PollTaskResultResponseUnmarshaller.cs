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
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class PollTaskResultResponseUnmarshaller
    {
        public static PollTaskResultResponse Unmarshall(UnmarshallerContext context)
        {
			PollTaskResultResponse pollTaskResultResponse = new PollTaskResultResponse();

			pollTaskResultResponse.HttpResponse = context.HttpResponse;
			pollTaskResultResponse.RequestId = context.StringValue("PollTaskResult.RequestId");
			pollTaskResultResponse.TotalItemNum = context.IntegerValue("PollTaskResult.TotalItemNum");
			pollTaskResultResponse.CurrentPageNum = context.IntegerValue("PollTaskResult.CurrentPageNum");
			pollTaskResultResponse.TotalPageNum = context.IntegerValue("PollTaskResult.TotalPageNum");
			pollTaskResultResponse.PageSize = context.IntegerValue("PollTaskResult.PageSize");
			pollTaskResultResponse.PrePage = context.BooleanValue("PollTaskResult.PrePage");
			pollTaskResultResponse.NextPage = context.BooleanValue("PollTaskResult.NextPage");

			List<PollTaskResultResponse.PollTaskResult_TaskDetail> pollTaskResultResponse_data = new List<PollTaskResultResponse.PollTaskResult_TaskDetail>();
			for (int i = 0; i < context.Length("PollTaskResult.Data.Length"); i++) {
				PollTaskResultResponse.PollTaskResult_TaskDetail taskDetail = new PollTaskResultResponse.PollTaskResult_TaskDetail();
				taskDetail.TaskNo = context.StringValue("PollTaskResult.Data["+ i +"].TaskNo");
				taskDetail.TaskDetailNo = context.StringValue("PollTaskResult.Data["+ i +"].TaskDetailNo");
				taskDetail.TaskType = context.StringValue("PollTaskResult.Data["+ i +"].TaskType");
				taskDetail.InstanceId = context.StringValue("PollTaskResult.Data["+ i +"].InstanceId");
				taskDetail.DomainName = context.StringValue("PollTaskResult.Data["+ i +"].DomainName");
				taskDetail.TaskStatus = context.StringValue("PollTaskResult.Data["+ i +"].TaskStatus");
				taskDetail.UpdateTime = context.StringValue("PollTaskResult.Data["+ i +"].UpdateTime");
				taskDetail.CreateTime = context.StringValue("PollTaskResult.Data["+ i +"].CreateTime");
				taskDetail.TryCount = context.IntegerValue("PollTaskResult.Data["+ i +"].TryCount");
				taskDetail.ErrorMsg = context.StringValue("PollTaskResult.Data["+ i +"].ErrorMsg");
				taskDetail.TaskStatusCode = context.IntegerValue("PollTaskResult.Data["+ i +"].TaskStatusCode");
				taskDetail.TaskResult = context.StringValue("PollTaskResult.Data["+ i +"].TaskResult");
				taskDetail.TaskTypeDescription = context.StringValue("PollTaskResult.Data["+ i +"].TaskTypeDescription");

				pollTaskResultResponse_data.Add(taskDetail);
			}
			pollTaskResultResponse.Data = pollTaskResultResponse_data;
        
			return pollTaskResultResponse;
        }
    }
}
