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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CCC.Model.V20170705;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListPredictiveJobStatusResponseUnmarshaller
    {
        public static ListPredictiveJobStatusResponse Unmarshall(UnmarshallerContext context)
        {
			ListPredictiveJobStatusResponse listPredictiveJobStatusResponse = new ListPredictiveJobStatusResponse();

			listPredictiveJobStatusResponse.HttpResponse = context.HttpResponse;
			listPredictiveJobStatusResponse.RequestId = context.StringValue("ListPredictiveJobStatus.RequestId");
			listPredictiveJobStatusResponse.Success = context.BooleanValue("ListPredictiveJobStatus.Success");
			listPredictiveJobStatusResponse.Code = context.StringValue("ListPredictiveJobStatus.Code");
			listPredictiveJobStatusResponse.Message = context.StringValue("ListPredictiveJobStatus.Message");
			listPredictiveJobStatusResponse.HttpStatusCode = context.IntegerValue("ListPredictiveJobStatus.HttpStatusCode");

			ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs jobs = new ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs();
			jobs.TotalCount = context.IntegerValue("ListPredictiveJobStatus.Jobs.TotalCount");
			jobs.PageNumber = context.IntegerValue("ListPredictiveJobStatus.Jobs.PageNumber");
			jobs.PageSize = context.IntegerValue("ListPredictiveJobStatus.Jobs.PageSize");

			List<ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job> jobs_list = new List<ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job>();
			for (int i = 0; i < context.Length("ListPredictiveJobStatus.Jobs.List.Length"); i++) {
				ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job job = new ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job();
				job.JobId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].JobId");
				job.GroupId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].GroupId");
				job.ScenarioId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].ScenarioId");
				job.StrategyId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].StrategyId");
				job.Priority = context.IntegerValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Priority");
				job.Status = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Status");
				job.ReferenceId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].ReferenceId");
				job.FailureReason = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].FailureReason");

				List<string> job_callingNumbers = new List<string>();
				for (int j = 0; j < context.Length("ListPredictiveJobStatus.Jobs.List["+ i +"].CallingNumbers.Length"); j++) {
					job_callingNumbers.Add(context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].CallingNumbers["+ j +"]"));
				}
				job.CallingNumbers = job_callingNumbers;

				List<ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_Contact> job_contacts = new List<ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_Contact>();
				for (int j = 0; j < context.Length("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts.Length"); j++) {
					ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_Contact contact = new ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_Contact();
					contact.ContactId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].ContactId");
					contact.ContactName = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].ContactName");
					contact.Honorific = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].Honorific");
					contact.Role = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].Role");
					contact.PhoneNumber = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].PhoneNumber");
					contact.State = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].State");
					contact.ReferenceId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].ReferenceId");
					contact.JobId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].JobId");

					job_contacts.Add(contact);
				}
				job.Contacts = job_contacts;

				List<ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_KeyValuePair> job_extras = new List<ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_KeyValuePair>();
				for (int j = 0; j < context.Length("ListPredictiveJobStatus.Jobs.List["+ i +"].Extras.Length"); j++) {
					ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_KeyValuePair keyValuePair = new ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_KeyValuePair();
					keyValuePair.Key = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Extras["+ j +"].Key");
					keyValuePair._Value = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Extras["+ j +"].Value");

					job_extras.Add(keyValuePair);
				}
				job.Extras = job_extras;

				List<ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_Task> job_tasks = new List<ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_Task>();
				for (int j = 0; j < context.Length("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks.Length"); j++) {
					ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_Task task = new ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_Task();
					task.TaskId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].TaskId");
					task.JobId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].JobId");
					task.ScenarioId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].ScenarioId");
					task.ChatbotId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].ChatbotId");
					task.PlanedTime = context.LongValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].PlanedTime");
					task.ActualTime = context.LongValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].ActualTime");
					task.CallingNumber = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].CallingNumber");
					task.CalledNumber = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].CalledNumber");
					task.CallId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].CallId");
					task.Status = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Status");
					task.Brief = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Brief");
					task.Duration = context.IntegerValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Duration");

					ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_Task.ListPredictiveJobStatus_Contact1 contact1 = new ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_Task.ListPredictiveJobStatus_Contact1();
					contact1.ContactId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.ContactId");
					contact1.ContactName = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.ContactName");
					contact1.Honorific = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.Honorific");
					contact1.Role = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.Role");
					contact1.PhoneNumber = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.PhoneNumber");
					contact1.State = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.State");
					contact1.ReferenceId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.ReferenceId");
					contact1.JobId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Tasks["+ j +"].Contact.JobId");
					task.Contact1 = contact1;

					job_tasks.Add(task);
				}
				job.Tasks = job_tasks;

				List<ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_SummaryItem> job_summary = new List<ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_SummaryItem>();
				for (int j = 0; j < context.Length("ListPredictiveJobStatus.Jobs.List["+ i +"].Summary.Length"); j++) {
					ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_SummaryItem summaryItem = new ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_SummaryItem();
					summaryItem.SummaryId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Summary["+ j +"].SummaryId");
					summaryItem.GroupId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Summary["+ j +"].GroupId");
					summaryItem.JobId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Summary["+ j +"].JobId");
					summaryItem.TaskId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Summary["+ j +"].TaskId");
					summaryItem.ConversationDetailId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Summary["+ j +"].ConversationDetailId");
					summaryItem.Category = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Summary["+ j +"].Category");
					summaryItem.SummaryName = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Summary["+ j +"].SummaryName");
					summaryItem.Content = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Summary["+ j +"].Content");

					job_summary.Add(summaryItem);
				}
				job.Summary = job_summary;

				jobs_list.Add(job);
			}
			jobs.List = jobs_list;
			listPredictiveJobStatusResponse.Jobs = jobs;
        
			return listPredictiveJobStatusResponse;
        }
    }
}