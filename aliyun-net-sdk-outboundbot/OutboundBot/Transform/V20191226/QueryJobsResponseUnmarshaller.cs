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
    public class QueryJobsResponseUnmarshaller
    {
        public static QueryJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryJobsResponse queryJobsResponse = new QueryJobsResponse();

			queryJobsResponse.HttpResponse = _ctx.HttpResponse;
			queryJobsResponse.Code = _ctx.StringValue("QueryJobs.Code");
			queryJobsResponse.HttpStatusCode = _ctx.IntegerValue("QueryJobs.HttpStatusCode");
			queryJobsResponse.Message = _ctx.StringValue("QueryJobs.Message");
			queryJobsResponse.RequestId = _ctx.StringValue("QueryJobs.RequestId");
			queryJobsResponse.Success = _ctx.BooleanValue("QueryJobs.Success");

			QueryJobsResponse.QueryJobs_Jobs jobs = new QueryJobsResponse.QueryJobs_Jobs();
			jobs.PageNumber = _ctx.IntegerValue("QueryJobs.Jobs.PageNumber");
			jobs.PageSize = _ctx.IntegerValue("QueryJobs.Jobs.PageSize");
			jobs.TotalCount = _ctx.IntegerValue("QueryJobs.Jobs.TotalCount");

			List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job> jobs_list = new List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job>();
			for (int i = 0; i < _ctx.Length("QueryJobs.Jobs.List.Length"); i++) {
				QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job job = new QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job();
				job.FailureReason = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].FailureReason");
				job.JobGroupId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].JobGroupId");
				job.JobId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].JobId");
				job.Priority = _ctx.IntegerValue("QueryJobs.Jobs.List["+ i +"].Priority");
				job.ReferenceId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].ReferenceId");
				job.ScenarioId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].ScenarioId");
				job.Status = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Status");
				job.StrategyId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].StrategyId");

				List<string> job_callingNumbers = new List<string>();
				for (int j = 0; j < _ctx.Length("QueryJobs.Jobs.List["+ i +"].CallingNumbers.Length"); j++) {
					job_callingNumbers.Add(_ctx.StringValue("QueryJobs.Jobs.List["+ i +"].CallingNumbers["+ j +"]"));
				}
				job.CallingNumbers = job_callingNumbers;

				List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Contact> job_contacts = new List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Contact>();
				for (int j = 0; j < _ctx.Length("QueryJobs.Jobs.List["+ i +"].Contacts.Length"); j++) {
					QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Contact contact = new QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Contact();
					contact.ContactId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Contacts["+ j +"].ContactId");
					contact.ContactName = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Contacts["+ j +"].ContactName");
					contact.Honorific = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Contacts["+ j +"].Honorific");
					contact.JobId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Contacts["+ j +"].JobId");
					contact.PhoneNumber = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Contacts["+ j +"].PhoneNumber");
					contact.ReferenceId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Contacts["+ j +"].ReferenceId");
					contact.Role = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Contacts["+ j +"].Role");
					contact.State = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Contacts["+ j +"].State");

					job_contacts.Add(contact);
				}
				job.Contacts = job_contacts;

				List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_KeyValuePair> job_extras = new List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_KeyValuePair>();
				for (int j = 0; j < _ctx.Length("QueryJobs.Jobs.List["+ i +"].Extras.Length"); j++) {
					QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_KeyValuePair keyValuePair = new QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_KeyValuePair();
					keyValuePair.Key = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Extras["+ j +"].Key");
					keyValuePair._Value = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Extras["+ j +"].Value");

					job_extras.Add(keyValuePair);
				}
				job.Extras = job_extras;

				List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_SummaryItem> job_summary = new List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_SummaryItem>();
				for (int j = 0; j < _ctx.Length("QueryJobs.Jobs.List["+ i +"].Summary.Length"); j++) {
					QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_SummaryItem summaryItem = new QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_SummaryItem();
					summaryItem.Category = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Summary["+ j +"].Category");
					summaryItem.Content = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Summary["+ j +"].Content");
					summaryItem.ConversationDetailId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Summary["+ j +"].ConversationDetailId");
					summaryItem.GroupId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Summary["+ j +"].GroupId");
					summaryItem.JobId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Summary["+ j +"].JobId");
					summaryItem.SummaryId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Summary["+ j +"].SummaryId");
					summaryItem.SummaryName = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Summary["+ j +"].SummaryName");
					summaryItem.TaskId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Summary["+ j +"].TaskId");

					job_summary.Add(summaryItem);
				}
				job.Summary = job_summary;

				List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Task> job_tasks = new List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Task>();
				for (int j = 0; j < _ctx.Length("QueryJobs.Jobs.List["+ i +"].Tasks.Length"); j++) {
					QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Task task = new QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Task();
					task.ActualTime = _ctx.LongValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].ActualTime");
					task.Brief = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Brief");
					task.CallId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].CallId");
					task.CalledNumber = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].CalledNumber");
					task.CallingNumber = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].CallingNumber");
					task.ChatbotId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].ChatbotId");
					task.Duration = _ctx.IntegerValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Duration");
					task.JobId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].JobId");
					task.PlanedTime = _ctx.LongValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].PlanedTime");
					task.ScenarioId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].ScenarioId");
					task.Status = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Status");
					task.TaskId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].TaskId");

					QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Task.QueryJobs_Contact1 contact1 = new QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Task.QueryJobs_Contact1();
					contact1.ContactId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Contact.ContactId");
					contact1.ContactName = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Contact.ContactName");
					contact1.Honorific = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Contact.Honorific");
					contact1.JobId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Contact.JobId");
					contact1.PhoneNumber = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Contact.PhoneNumber");
					contact1.ReferenceId = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Contact.ReferenceId");
					contact1.Role = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Contact.Role");
					contact1.State = _ctx.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Contact.State");
					task.Contact1 = contact1;

					job_tasks.Add(task);
				}
				job.Tasks = job_tasks;

				jobs_list.Add(job);
			}
			jobs.List = jobs_list;
			queryJobsResponse.Jobs = jobs;
        
			return queryJobsResponse;
        }
    }
}
