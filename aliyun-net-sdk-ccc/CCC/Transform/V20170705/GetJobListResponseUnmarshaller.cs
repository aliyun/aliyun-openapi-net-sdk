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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class GetJobListResponseUnmarshaller
    {
        public static GetJobListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJobListResponse getJobListResponse = new GetJobListResponse();

			getJobListResponse.HttpResponse = _ctx.HttpResponse;
			getJobListResponse.RequestId = _ctx.StringValue("GetJobList.RequestId");
			getJobListResponse.Success = _ctx.BooleanValue("GetJobList.Success");
			getJobListResponse.Code = _ctx.StringValue("GetJobList.Code");
			getJobListResponse.Message = _ctx.StringValue("GetJobList.Message");
			getJobListResponse.HttpStatusCode = _ctx.IntegerValue("GetJobList.HttpStatusCode");

			GetJobListResponse.GetJobList_Jobs jobs = new GetJobListResponse.GetJobList_Jobs();
			jobs.TotalCount = _ctx.IntegerValue("GetJobList.Jobs.TotalCount");
			jobs.PageNumber = _ctx.IntegerValue("GetJobList.Jobs.PageNumber");
			jobs.PageSize = _ctx.IntegerValue("GetJobList.Jobs.PageSize");

			List<GetJobListResponse.GetJobList_Jobs.GetJobList_Job> jobs_list = new List<GetJobListResponse.GetJobList_Jobs.GetJobList_Job>();
			for (int i = 0; i < _ctx.Length("GetJobList.Jobs.List.Length"); i++) {
				GetJobListResponse.GetJobList_Jobs.GetJobList_Job job = new GetJobListResponse.GetJobList_Jobs.GetJobList_Job();
				job.JobId = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].JobId");
				job.GroupId = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].GroupId");
				job.ScenarioId = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].ScenarioId");
				job.StrategyId = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].StrategyId");
				job.Priority = _ctx.IntegerValue("GetJobList.Jobs.List["+ i +"].Priority");
				job.SystemPriority = _ctx.IntegerValue("GetJobList.Jobs.List["+ i +"].SystemPriority");
				job.Status = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Status");
				job.ReferenceId = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].ReferenceId");
				job.FailureReason = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].FailureReason");

				List<string> job_callingNumbers = new List<string>();
				for (int j = 0; j < _ctx.Length("GetJobList.Jobs.List["+ i +"].CallingNumbers.Length"); j++) {
					job_callingNumbers.Add(_ctx.StringValue("GetJobList.Jobs.List["+ i +"].CallingNumbers["+ j +"]"));
				}
				job.CallingNumbers = job_callingNumbers;

				List<GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_Contact> job_contacts = new List<GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_Contact>();
				for (int j = 0; j < _ctx.Length("GetJobList.Jobs.List["+ i +"].Contacts.Length"); j++) {
					GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_Contact contact = new GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_Contact();
					contact.ContactId = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Contacts["+ j +"].ContactId");
					contact.ContactName = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Contacts["+ j +"].ContactName");
					contact.Honorific = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Contacts["+ j +"].Honorific");
					contact.Role = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Contacts["+ j +"].Role");
					contact.PhoneNumber = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Contacts["+ j +"].PhoneNumber");
					contact.State = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Contacts["+ j +"].State");
					contact.ReferenceId = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Contacts["+ j +"].ReferenceId");
					contact.JobId = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Contacts["+ j +"].JobId");

					job_contacts.Add(contact);
				}
				job.Contacts = job_contacts;

				List<GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_KeyValuePair> job_extras = new List<GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_KeyValuePair>();
				for (int j = 0; j < _ctx.Length("GetJobList.Jobs.List["+ i +"].Extras.Length"); j++) {
					GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_KeyValuePair keyValuePair = new GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_KeyValuePair();
					keyValuePair.Key = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Extras["+ j +"].Key");
					keyValuePair._Value = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Extras["+ j +"].Value");

					job_extras.Add(keyValuePair);
				}
				job.Extras = job_extras;

				List<GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_SummaryItem> job_summary = new List<GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_SummaryItem>();
				for (int j = 0; j < _ctx.Length("GetJobList.Jobs.List["+ i +"].Summary.Length"); j++) {
					GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_SummaryItem summaryItem = new GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_SummaryItem();
					summaryItem.SummaryId = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Summary["+ j +"].SummaryId");
					summaryItem.GroupId = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Summary["+ j +"].GroupId");
					summaryItem.JobId = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Summary["+ j +"].JobId");
					summaryItem.TaskId = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Summary["+ j +"].TaskId");
					summaryItem.ConversationDetailId = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Summary["+ j +"].ConversationDetailId");
					summaryItem.Category = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Summary["+ j +"].Category");
					summaryItem.SummaryName = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Summary["+ j +"].SummaryName");
					summaryItem.Content = _ctx.StringValue("GetJobList.Jobs.List["+ i +"].Summary["+ j +"].Content");

					job_summary.Add(summaryItem);
				}
				job.Summary = job_summary;

				jobs_list.Add(job);
			}
			jobs.List = jobs_list;
			getJobListResponse.Jobs = jobs;
        
			return getJobListResponse;
        }
    }
}
