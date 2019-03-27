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
        public static ListJobStatusResponse Unmarshall(UnmarshallerContext context)
        {
			ListJobStatusResponse listJobStatusResponse = new ListJobStatusResponse();

			listJobStatusResponse.HttpResponse = context.HttpResponse;
			listJobStatusResponse.RequestId = context.StringValue("ListJobStatus.RequestId");
			listJobStatusResponse.Success = context.BooleanValue("ListJobStatus.Success");
			listJobStatusResponse.Code = context.StringValue("ListJobStatus.Code");
			listJobStatusResponse.Message = context.StringValue("ListJobStatus.Message");
			listJobStatusResponse.HttpStatusCode = context.IntegerValue("ListJobStatus.HttpStatusCode");

			ListJobStatusResponse.ListJobStatus_Jobs jobs = new ListJobStatusResponse.ListJobStatus_Jobs();
			jobs.TotalCount = context.IntegerValue("ListJobStatus.Jobs.TotalCount");
			jobs.PageNumber = context.IntegerValue("ListJobStatus.Jobs.PageNumber");
			jobs.PageSize = context.IntegerValue("ListJobStatus.Jobs.PageSize");

			List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job> jobs_list = new List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job>();
			for (int i = 0; i < context.Length("ListJobStatus.Jobs.List.Length"); i++) {
				ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job job = new ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job();
				job.JobId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].JobId");
				job.GroupId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].GroupId");
				job.ScenarioId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].ScenarioId");
				job.StrategyId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].StrategyId");
				job.Priority = context.IntegerValue("ListJobStatus.Jobs.List["+ i +"].Priority");
				job.Status = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Status");
				job.ReferenceId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].ReferenceId");
				job.FailureReason = context.StringValue("ListJobStatus.Jobs.List["+ i +"].FailureReason");

				List<string> job_callingNumbers = new List<string>();
				for (int j = 0; j < context.Length("ListJobStatus.Jobs.List["+ i +"].CallingNumbers.Length"); j++) {
					job_callingNumbers.Add(context.StringValue("ListJobStatus.Jobs.List["+ i +"].CallingNumbers["+ j +"]"));
				}
				job.CallingNumbers = job_callingNumbers;

				List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Contact> job_contacts = new List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Contact>();
				for (int j = 0; j < context.Length("ListJobStatus.Jobs.List["+ i +"].Contacts.Length"); j++) {
					ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Contact contact = new ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Contact();
					contact.ContactId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].ContactId");
					contact.ContactName = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].ContactName");
					contact.Honorific = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].Honorific");
					contact.Role = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].Role");
					contact.PhoneNumber = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].PhoneNumber");
					contact.State = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].State");
					contact.ReferenceId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].ReferenceId");
					contact.JobId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].JobId");

					job_contacts.Add(contact);
				}
				job.Contacts = job_contacts;

				List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_KeyValuePair> job_extras = new List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_KeyValuePair>();
				for (int j = 0; j < context.Length("ListJobStatus.Jobs.List["+ i +"].Extras.Length"); j++) {
					ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_KeyValuePair keyValuePair = new ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_KeyValuePair();
					keyValuePair.Key = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Extras["+ j +"].Key");
					keyValuePair._Value = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Extras["+ j +"].Value");

					job_extras.Add(keyValuePair);
				}
				job.Extras = job_extras;

				List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Task> job_tasks = new List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Task>();
				for (int j = 0; j < context.Length("ListJobStatus.Jobs.List["+ i +"].Tasks.Length"); j++) {
					ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Task task = new ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Task();
					task.TaskId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].TaskId");
					task.JobId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].JobId");
					task.ScenarioId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].ScenarioId");
					task.ChatbotId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].ChatbotId");
					task.PlanedTime = context.LongValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].PlanedTime");
					task.ActualTime = context.LongValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].ActualTime");
					task.CallingNumber = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].CallingNumber");
					task.CalledNumber = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].CalledNumber");
					task.CallId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].CallId");
					task.Status = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Status");
					task.Brief = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Brief");
					task.Duration = context.IntegerValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Duration");

					ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Task.ListJobStatus_Contact1 contact1 = new ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_Task.ListJobStatus_Contact1();
					contact1.ContactId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.ContactId");
					contact1.ContactName = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.ContactName");
					contact1.Honorific = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.Honorific");
					contact1.Role = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.Role");
					contact1.PhoneNumber = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.PhoneNumber");
					contact1.State = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.State");
					contact1.ReferenceId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.ReferenceId");
					contact1.JobId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.JobId");
					task.Contact1 = contact1;

					job_tasks.Add(task);
				}
				job.Tasks = job_tasks;

				List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_SummaryItem> job_summary = new List<ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_SummaryItem>();
				for (int j = 0; j < context.Length("ListJobStatus.Jobs.List["+ i +"].Summary.Length"); j++) {
					ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_SummaryItem summaryItem = new ListJobStatusResponse.ListJobStatus_Jobs.ListJobStatus_Job.ListJobStatus_SummaryItem();
					summaryItem.SummaryId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Summary["+ j +"].SummaryId");
					summaryItem.GroupId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Summary["+ j +"].GroupId");
					summaryItem.JobId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Summary["+ j +"].JobId");
					summaryItem.TaskId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Summary["+ j +"].TaskId");
					summaryItem.ConversationDetailId = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Summary["+ j +"].ConversationDetailId");
					summaryItem.Category = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Summary["+ j +"].Category");
					summaryItem.SummaryName = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Summary["+ j +"].SummaryName");
					summaryItem.Content = context.StringValue("ListJobStatus.Jobs.List["+ i +"].Summary["+ j +"].Content");

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
