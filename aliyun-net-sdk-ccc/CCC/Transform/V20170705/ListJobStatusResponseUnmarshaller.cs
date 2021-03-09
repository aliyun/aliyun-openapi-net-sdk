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
    public class ListJobStatusResponseUnmarshaller
    {
        public static ListJobStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJobStatusResponse listJobStatusResponse = new ListJobStatusResponse();

			listJobStatusResponse.HttpResponse = _ctx.HttpResponse;
			listJobStatusResponse.RequestId = _ctx.StringValue("ListJobStatus.RequestId");
			listJobStatusResponse.Success = _ctx.BooleanValue("ListJobStatus.Success");
			listJobStatusResponse.Code = _ctx.StringValue("ListJobStatus.Code");
			listJobStatusResponse.Message = _ctx.StringValue("ListJobStatus.Message");
			listJobStatusResponse.HttpStatusCode = _ctx.IntegerValue("ListJobStatus.HttpStatusCode");

			ListJobStatusResponse.ListJobStatus_Jobs jobs = new ListJobStatusResponse.ListJobStatus_Jobs();
			jobs.TotalCount = _ctx.IntegerValue("ListJobStatus.Jobs.TotalCount");
			jobs.PageNumber = _ctx.IntegerValue("ListJobStatus.Jobs.PageNumber");
			jobs.PageSize = _ctx.IntegerValue("ListJobStatus.Jobs.PageSize");

			List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job> jobs_list = new List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job>();
			for (int i = 0; i < _ctx.Length("ListJobStatus.Jobs.List.Length"); i++) {
				ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job job = new ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job();
				job.JobId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].JobId");
				job.GroupId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].GroupId");
				job.ScenarioId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].ScenarioId");
				job.StrategyId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].StrategyId");
				job.Priority = _ctx.IntegerValue("ListJobStatus.Jobs.List["+ i +"].Priority");
				job.Status = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Status");
				job.ReferenceId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].ReferenceId");
				job.FailureReason = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].FailureReason");

				List<string> job_callingNumbers = new List<string>();
				for (int j = 0; j < _ctx.Length("ListJobStatus.Jobs.List["+ i +"].CallingNumbers.Length"); j++) {
					job_callingNumbers.Add(_ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].CallingNumbers["+ j +"]"));
				}
				job.CallingNumbers = job_callingNumbers;

				List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Contact> job_contacts = new List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Contact>();
				for (int j = 0; j < _ctx.Length("ListJobStatus.Jobs.List["+ i +"].Contacts.Length"); j++) {
					ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Contact contact = new ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Contact();
					contact.ContactId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].ContactId");
					contact.ContactName = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].ContactName");
					contact.Honorific = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].Honorific");
					contact.Role = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].Role");
					contact.PhoneNumber = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].PhoneNumber");
					contact.State = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].State");
					contact.ReferenceId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].ReferenceId");
					contact.JobId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].JobId");

					job_contacts.Add(contact);
				}
				job.Contacts = job_contacts;

				List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_KeyValuePair> job_extras = new List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_KeyValuePair>();
				for (int j = 0; j < _ctx.Length("ListJobStatus.Jobs.List["+ i +"].Extras.Length"); j++) {
					ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_KeyValuePair keyValuePair = new ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_KeyValuePair();
					keyValuePair.Key = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Extras["+ j +"].Key");
					keyValuePair._Value = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Extras["+ j +"].Value");

					job_extras.Add(keyValuePair);
				}
				job.Extras = job_extras;

				List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Task> job_tasks = new List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Task>();
				for (int j = 0; j < _ctx.Length("ListJobStatus.Jobs.List["+ i +"].Tasks.Length"); j++) {
					ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Task task = new ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Task();
					task.TaskId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].TaskId");
					task.JobId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].JobId");
					task.ScenarioId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].ScenarioId");
					task.ChatbotId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].ChatbotId");
					task.PlanedTime = _ctx.LongValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].PlanedTime");
					task.ActualTime = _ctx.LongValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].ActualTime");
					task.CallingNumber = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].CallingNumber");
					task.CalledNumber = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].CalledNumber");
					task.CallId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].CallId");
					task.Status = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Status");
					task.Brief = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Brief");
					task.Duration = _ctx.IntegerValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Duration");

					ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Task.ListJobStatus_Contact1 contact1 = new ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Task.ListJobStatus_Contact1();
					contact1.ContactId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.ContactId");
					contact1.ContactName = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.ContactName");
					contact1.Honorific = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.Honorific");
					contact1.Role = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.Role");
					contact1.PhoneNumber = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.PhoneNumber");
					contact1.State = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.State");
					contact1.ReferenceId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.ReferenceId");
					contact1.JobId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.JobId");
					task.Contact1 = contact1;

					job_tasks.Add(task);
				}
				job.Tasks = job_tasks;

				List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_SummaryItem> job_summary = new List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_SummaryItem>();
				for (int j = 0; j < _ctx.Length("ListJobStatus.Jobs.List["+ i +"].Summary.Length"); j++) {
					ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_SummaryItem summaryItem = new ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_SummaryItem();
					summaryItem.SummaryId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Summary["+ j +"].SummaryId");
					summaryItem.GroupId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Summary["+ j +"].GroupId");
					summaryItem.JobId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Summary["+ j +"].JobId");
					summaryItem.TaskId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Summary["+ j +"].TaskId");
					summaryItem.ConversationDetailId = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Summary["+ j +"].ConversationDetailId");
					summaryItem.Category = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Summary["+ j +"].Category");
					summaryItem.SummaryName = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Summary["+ j +"].SummaryName");
					summaryItem.Content = _ctx.StringValue("ListJobStatus.Jobs.List["+ i +"].Summary["+ j +"].Content");

					job_summary.Add(summaryItem);
				}
				job.Summary = job_summary;

				jobs_list.Add(job);
			}
			jobs.List = jobs_list;
			listJobStatusResponse.Jobs = jobs;
        
			return listJobStatusResponse;
        }
    }
}
