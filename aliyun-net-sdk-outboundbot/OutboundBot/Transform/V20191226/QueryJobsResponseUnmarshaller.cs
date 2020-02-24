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
        public static QueryJobsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryJobsResponse queryJobsResponse = new QueryJobsResponse();

			queryJobsResponse.HttpResponse = context.HttpResponse;
			queryJobsResponse.RequestId = context.StringValue("QueryJobs.RequestId");
			queryJobsResponse.Success = context.BooleanValue("QueryJobs.Success");
			queryJobsResponse.Code = context.StringValue("QueryJobs.Code");
			queryJobsResponse.Message = context.StringValue("QueryJobs.Message");
			queryJobsResponse.HttpStatusCode = context.IntegerValue("QueryJobs.HttpStatusCode");

			QueryJobsResponse.QueryJobs_Jobs jobs = new QueryJobsResponse.QueryJobs_Jobs();
			jobs.TotalCount = context.IntegerValue("QueryJobs.Jobs.TotalCount");
			jobs.PageNumber = context.IntegerValue("QueryJobs.Jobs.PageNumber");
			jobs.PageSize = context.IntegerValue("QueryJobs.Jobs.PageSize");

			List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job> jobs_list = new List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job>();
			for (int i = 0; i < context.Length("QueryJobs.Jobs.List.Length"); i++) {
				QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job job = new QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job();
				job.JobId = context.StringValue("QueryJobs.Jobs.List["+ i +"].JobId");
				job.JobGroupId = context.StringValue("QueryJobs.Jobs.List["+ i +"].JobGroupId");
				job.ScenarioId = context.StringValue("QueryJobs.Jobs.List["+ i +"].ScenarioId");
				job.StrategyId = context.StringValue("QueryJobs.Jobs.List["+ i +"].StrategyId");
				job.Priority = context.IntegerValue("QueryJobs.Jobs.List["+ i +"].Priority");
				job.Status = context.StringValue("QueryJobs.Jobs.List["+ i +"].Status");
				job.ReferenceId = context.StringValue("QueryJobs.Jobs.List["+ i +"].ReferenceId");
				job.FailureReason = context.StringValue("QueryJobs.Jobs.List["+ i +"].FailureReason");

				List<string> job_callingNumbers = new List<string>();
				for (int j = 0; j < context.Length("QueryJobs.Jobs.List["+ i +"].CallingNumbers.Length"); j++) {
					job_callingNumbers.Add(context.StringValue("QueryJobs.Jobs.List["+ i +"].CallingNumbers["+ j +"]"));
				}
				job.CallingNumbers = job_callingNumbers;

				List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Contact> job_contacts = new List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Contact>();
				for (int j = 0; j < context.Length("QueryJobs.Jobs.List["+ i +"].Contacts.Length"); j++) {
					QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Contact contact = new QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Contact();
					contact.ContactId = context.StringValue("QueryJobs.Jobs.List["+ i +"].Contacts["+ j +"].ContactId");
					contact.ContactName = context.StringValue("QueryJobs.Jobs.List["+ i +"].Contacts["+ j +"].ContactName");
					contact.Honorific = context.StringValue("QueryJobs.Jobs.List["+ i +"].Contacts["+ j +"].Honorific");
					contact.Role = context.StringValue("QueryJobs.Jobs.List["+ i +"].Contacts["+ j +"].Role");
					contact.PhoneNumber = context.StringValue("QueryJobs.Jobs.List["+ i +"].Contacts["+ j +"].PhoneNumber");
					contact.State = context.StringValue("QueryJobs.Jobs.List["+ i +"].Contacts["+ j +"].State");
					contact.ReferenceId = context.StringValue("QueryJobs.Jobs.List["+ i +"].Contacts["+ j +"].ReferenceId");
					contact.JobId = context.StringValue("QueryJobs.Jobs.List["+ i +"].Contacts["+ j +"].JobId");

					job_contacts.Add(contact);
				}
				job.Contacts = job_contacts;

				List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_KeyValuePair> job_extras = new List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_KeyValuePair>();
				for (int j = 0; j < context.Length("QueryJobs.Jobs.List["+ i +"].Extras.Length"); j++) {
					QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_KeyValuePair keyValuePair = new QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_KeyValuePair();
					keyValuePair.Key = context.StringValue("QueryJobs.Jobs.List["+ i +"].Extras["+ j +"].Key");
					keyValuePair._Value = context.StringValue("QueryJobs.Jobs.List["+ i +"].Extras["+ j +"].Value");

					job_extras.Add(keyValuePair);
				}
				job.Extras = job_extras;

				List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Task> job_tasks = new List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Task>();
				for (int j = 0; j < context.Length("QueryJobs.Jobs.List["+ i +"].Tasks.Length"); j++) {
					QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Task task = new QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Task();
					task.TaskId = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].TaskId");
					task.JobId = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].JobId");
					task.ScenarioId = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].ScenarioId");
					task.ChatbotId = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].ChatbotId");
					task.PlanedTime = context.LongValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].PlanedTime");
					task.ActualTime = context.LongValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].ActualTime");
					task.CallingNumber = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].CallingNumber");
					task.CalledNumber = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].CalledNumber");
					task.CallId = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].CallId");
					task.Status = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Status");
					task.Brief = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Brief");
					task.Duration = context.IntegerValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Duration");

					QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Task.QueryJobs_Contact1 contact1 = new QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_Task.QueryJobs_Contact1();
					contact1.ContactId = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Contact.ContactId");
					contact1.ContactName = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Contact.ContactName");
					contact1.Honorific = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Contact.Honorific");
					contact1.Role = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Contact.Role");
					contact1.PhoneNumber = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Contact.PhoneNumber");
					contact1.State = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Contact.State");
					contact1.ReferenceId = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Contact.ReferenceId");
					contact1.JobId = context.StringValue("QueryJobs.Jobs.List["+ i +"].Tasks["+ j +"].Contact.JobId");
					task.Contact1 = contact1;

					job_tasks.Add(task);
				}
				job.Tasks = job_tasks;

				List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_SummaryItem> job_summary = new List<QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_SummaryItem>();
				for (int j = 0; j < context.Length("QueryJobs.Jobs.List["+ i +"].Summary.Length"); j++) {
					QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_SummaryItem summaryItem = new QueryJobsResponse.QueryJobs_Jobs.QueryJobs_Job.QueryJobs_SummaryItem();
					summaryItem.SummaryId = context.StringValue("QueryJobs.Jobs.List["+ i +"].Summary["+ j +"].SummaryId");
					summaryItem.GroupId = context.StringValue("QueryJobs.Jobs.List["+ i +"].Summary["+ j +"].GroupId");
					summaryItem.JobId = context.StringValue("QueryJobs.Jobs.List["+ i +"].Summary["+ j +"].JobId");
					summaryItem.TaskId = context.StringValue("QueryJobs.Jobs.List["+ i +"].Summary["+ j +"].TaskId");
					summaryItem.ConversationDetailId = context.StringValue("QueryJobs.Jobs.List["+ i +"].Summary["+ j +"].ConversationDetailId");
					summaryItem.Category = context.StringValue("QueryJobs.Jobs.List["+ i +"].Summary["+ j +"].Category");
					summaryItem.SummaryName = context.StringValue("QueryJobs.Jobs.List["+ i +"].Summary["+ j +"].SummaryName");
					summaryItem.Content = context.StringValue("QueryJobs.Jobs.List["+ i +"].Summary["+ j +"].Content");

					job_summary.Add(summaryItem);
				}
				job.Summary = job_summary;

				jobs_list.Add(job);
			}
			jobs.List = jobs_list;
			queryJobsResponse.Jobs = jobs;
        
			return queryJobsResponse;
        }
    }
}
