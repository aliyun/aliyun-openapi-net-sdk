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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class QueryJobsWithResultResponseUnmarshaller
    {
        public static QueryJobsWithResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryJobsWithResultResponse queryJobsWithResultResponse = new QueryJobsWithResultResponse();

			queryJobsWithResultResponse.HttpResponse = _ctx.HttpResponse;
			queryJobsWithResultResponse.RequestId = _ctx.StringValue("QueryJobsWithResult.RequestId");
			queryJobsWithResultResponse.Success = _ctx.BooleanValue("QueryJobsWithResult.Success");
			queryJobsWithResultResponse.Code = _ctx.StringValue("QueryJobsWithResult.Code");
			queryJobsWithResultResponse.Message = _ctx.StringValue("QueryJobsWithResult.Message");
			queryJobsWithResultResponse.HttpStatusCode = _ctx.IntegerValue("QueryJobsWithResult.HttpStatusCode");

			List<string> queryJobsWithResultResponse_variableNames = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryJobsWithResult.VariableNames.Length"); i++) {
				queryJobsWithResultResponse_variableNames.Add(_ctx.StringValue("QueryJobsWithResult.VariableNames["+ i +"]"));
			}
			queryJobsWithResultResponse.VariableNames = queryJobsWithResultResponse_variableNames;

			QueryJobsWithResultResponse.QueryJobsWithResult_Jobs jobs = new QueryJobsWithResultResponse.QueryJobsWithResult_Jobs();
			jobs.PageCount = _ctx.IntegerValue("QueryJobsWithResult.Jobs.PageCount");
			jobs.PageNumber = _ctx.IntegerValue("QueryJobsWithResult.Jobs.PageNumber");
			jobs.PageSize = _ctx.IntegerValue("QueryJobsWithResult.Jobs.PageSize");
			jobs.RowCount = _ctx.IntegerValue("QueryJobsWithResult.Jobs.RowCount");

			List<QueryJobsWithResultResponse.QueryJobsWithResult_Jobs.QueryJobsWithResult_Job> jobs_list = new List<QueryJobsWithResultResponse.QueryJobsWithResult_Jobs.QueryJobsWithResult_Job>();
			for (int i = 0; i < _ctx.Length("QueryJobsWithResult.Jobs.List.Length"); i++) {
				QueryJobsWithResultResponse.QueryJobsWithResult_Jobs.QueryJobsWithResult_Job job = new QueryJobsWithResultResponse.QueryJobsWithResult_Jobs.QueryJobsWithResult_Job();
				job.JobFailureReason = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].JobFailureReason");
				job.StatusName = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].StatusName");
				job.Id = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].Id");
				job.Status = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].Status");

				QueryJobsWithResultResponse.QueryJobsWithResult_Jobs.QueryJobsWithResult_Job.QueryJobsWithResult_LatestTask latestTask = new QueryJobsWithResultResponse.QueryJobsWithResult_Jobs.QueryJobsWithResult_Job.QueryJobsWithResult_LatestTask();
				latestTask.TaskEndReason = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.TaskEndReason");
				latestTask.CallDuration = _ctx.IntegerValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.CallDuration");
				latestTask.CallDurationDisplay = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.CallDurationDisplay");
				latestTask.StatusName = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.StatusName");
				latestTask.HasAnswered = _ctx.BooleanValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.HasAnswered");
				latestTask.HasReachedEndOfFlow = _ctx.BooleanValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.HasReachedEndOfFlow");
				latestTask.CallTime = _ctx.LongValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.CallTime");
				latestTask.HasHangUpByRejection = _ctx.BooleanValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.HasHangUpByRejection");
				latestTask.Status = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.Status");

				QueryJobsWithResultResponse.QueryJobsWithResult_Jobs.QueryJobsWithResult_Job.QueryJobsWithResult_LatestTask.QueryJobsWithResult_Contact contact = new QueryJobsWithResultResponse.QueryJobsWithResult_Jobs.QueryJobsWithResult_Job.QueryJobsWithResult_LatestTask.QueryJobsWithResult_Contact();
				contact.PreferredPhoneNumber = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.Contact.PreferredPhoneNumber");
				contact.JobUuid = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.Contact.JobUuid");
				contact.PhoneNumber = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.Contact.PhoneNumber");
				contact.Role = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.Contact.Role");
				contact.Round = _ctx.IntegerValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.Contact.Round");
				contact.Name = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.Contact.Name");
				contact.Id = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.Contact.Id");
				contact.State = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.Contact.State");
				contact.ReferenceId = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.Contact.ReferenceId");
				contact.Honorific = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.Contact.Honorific");
				latestTask.Contact = contact;

				List<QueryJobsWithResultResponse.QueryJobsWithResult_Jobs.QueryJobsWithResult_Job.QueryJobsWithResult_LatestTask.QueryJobsWithResult_Extra> latestTask_extras = new List<QueryJobsWithResultResponse.QueryJobsWithResult_Jobs.QueryJobsWithResult_Job.QueryJobsWithResult_LatestTask.QueryJobsWithResult_Extra>();
				for (int j = 0; j < _ctx.Length("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.Extras.Length"); j++) {
					QueryJobsWithResultResponse.QueryJobsWithResult_Jobs.QueryJobsWithResult_Job.QueryJobsWithResult_LatestTask.QueryJobsWithResult_Extra extra = new QueryJobsWithResultResponse.QueryJobsWithResult_Jobs.QueryJobsWithResult_Job.QueryJobsWithResult_LatestTask.QueryJobsWithResult_Extra();
					extra.Key = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.Extras["+ j +"].Key");
					extra._Value = _ctx.StringValue("QueryJobsWithResult.Jobs.List["+ i +"].LatestTask.Extras["+ j +"].Value");

					latestTask_extras.Add(extra);
				}
				latestTask.Extras = latestTask_extras;
				job.LatestTask = latestTask;

				jobs_list.Add(job);
			}
			jobs.List = jobs_list;
			queryJobsWithResultResponse.Jobs = jobs;
        
			return queryJobsWithResultResponse;
        }
    }
}
