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
        public static PollTaskResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PollTaskResultResponse pollTaskResultResponse = new PollTaskResultResponse();

			pollTaskResultResponse.HttpResponse = _ctx.HttpResponse;
			pollTaskResultResponse.RequestId = _ctx.StringValue("PollTaskResult.RequestId");
			pollTaskResultResponse.TotalItemNum = _ctx.IntegerValue("PollTaskResult.TotalItemNum");
			pollTaskResultResponse.CurrentPageNum = _ctx.IntegerValue("PollTaskResult.CurrentPageNum");
			pollTaskResultResponse.TotalPageNum = _ctx.IntegerValue("PollTaskResult.TotalPageNum");
			pollTaskResultResponse.PageSize = _ctx.IntegerValue("PollTaskResult.PageSize");
			pollTaskResultResponse.PrePage = _ctx.BooleanValue("PollTaskResult.PrePage");
			pollTaskResultResponse.NextPage = _ctx.BooleanValue("PollTaskResult.NextPage");

			List<PollTaskResultResponse.PollTaskResult_TaskDetail> pollTaskResultResponse_data = new List<PollTaskResultResponse.PollTaskResult_TaskDetail>();
			for (int i = 0; i < _ctx.Length("PollTaskResult.Data.Length"); i++) {
				PollTaskResultResponse.PollTaskResult_TaskDetail taskDetail = new PollTaskResultResponse.PollTaskResult_TaskDetail();
				taskDetail.TaskNo = _ctx.StringValue("PollTaskResult.Data["+ i +"].TaskNo");
				taskDetail.TaskDetailNo = _ctx.StringValue("PollTaskResult.Data["+ i +"].TaskDetailNo");
				taskDetail.TaskType = _ctx.StringValue("PollTaskResult.Data["+ i +"].TaskType");
				taskDetail.InstanceId = _ctx.StringValue("PollTaskResult.Data["+ i +"].InstanceId");
				taskDetail.DomainName = _ctx.StringValue("PollTaskResult.Data["+ i +"].DomainName");
				taskDetail.TaskStatus = _ctx.StringValue("PollTaskResult.Data["+ i +"].TaskStatus");
				taskDetail.UpdateTime = _ctx.StringValue("PollTaskResult.Data["+ i +"].UpdateTime");
				taskDetail.CreateTime = _ctx.StringValue("PollTaskResult.Data["+ i +"].CreateTime");
				taskDetail.TryCount = _ctx.IntegerValue("PollTaskResult.Data["+ i +"].TryCount");
				taskDetail.ErrorMsg = _ctx.StringValue("PollTaskResult.Data["+ i +"].ErrorMsg");
				taskDetail.TaskStatusCode = _ctx.IntegerValue("PollTaskResult.Data["+ i +"].TaskStatusCode");
				taskDetail.TaskResult = _ctx.StringValue("PollTaskResult.Data["+ i +"].TaskResult");
				taskDetail.TaskTypeDescription = _ctx.StringValue("PollTaskResult.Data["+ i +"].TaskTypeDescription");

				pollTaskResultResponse_data.Add(taskDetail);
			}
			pollTaskResultResponse.Data = pollTaskResultResponse_data;
        
			return pollTaskResultResponse;
        }
    }
}
