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
    public class ListJobsResponseUnmarshaller
    {
        public static ListJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJobsResponse listJobsResponse = new ListJobsResponse();

			listJobsResponse.HttpResponse = _ctx.HttpResponse;
			listJobsResponse.Code = _ctx.StringValue("ListJobs.Code");
			listJobsResponse.HttpStatusCode = _ctx.IntegerValue("ListJobs.HttpStatusCode");
			listJobsResponse.Message = _ctx.StringValue("ListJobs.Message");
			listJobsResponse.RequestId = _ctx.StringValue("ListJobs.RequestId");
			listJobsResponse.Success = _ctx.BooleanValue("ListJobs.Success");

			List<ListJobsResponse.ListJobs_Job> listJobsResponse_jobs = new List<ListJobsResponse.ListJobs_Job>();
			for (int i = 0; i < _ctx.Length("ListJobs.Jobs.Length"); i++) {
				ListJobsResponse.ListJobs_Job job = new ListJobsResponse.ListJobs_Job();
				job.FailureReason = _ctx.StringValue("ListJobs.Jobs["+ i +"].FailureReason");
				job.JobGroupId = _ctx.StringValue("ListJobs.Jobs["+ i +"].JobGroupId");
				job.JobId = _ctx.StringValue("ListJobs.Jobs["+ i +"].JobId");
				job.Priority = _ctx.IntegerValue("ListJobs.Jobs["+ i +"].Priority");
				job.ReferenceId = _ctx.StringValue("ListJobs.Jobs["+ i +"].ReferenceId");
				job.ScenarioId = _ctx.StringValue("ListJobs.Jobs["+ i +"].ScenarioId");
				job.Status = _ctx.StringValue("ListJobs.Jobs["+ i +"].Status");
				job.StrategyId = _ctx.StringValue("ListJobs.Jobs["+ i +"].StrategyId");
				job.SystemPriority = _ctx.IntegerValue("ListJobs.Jobs["+ i +"].SystemPriority");

				List<string> job_callingNumbers = new List<string>();
				for (int j = 0; j < _ctx.Length("ListJobs.Jobs["+ i +"].CallingNumbers.Length"); j++) {
					job_callingNumbers.Add(_ctx.StringValue("ListJobs.Jobs["+ i +"].CallingNumbers["+ j +"]"));
				}
				job.CallingNumbers = job_callingNumbers;

				List<ListJobsResponse.ListJobs_Job.ListJobs_Contact> job_contacts = new List<ListJobsResponse.ListJobs_Job.ListJobs_Contact>();
				for (int j = 0; j < _ctx.Length("ListJobs.Jobs["+ i +"].Contacts.Length"); j++) {
					ListJobsResponse.ListJobs_Job.ListJobs_Contact contact = new ListJobsResponse.ListJobs_Job.ListJobs_Contact();
					contact.ContactId = _ctx.StringValue("ListJobs.Jobs["+ i +"].Contacts["+ j +"].ContactId");
					contact.ContactName = _ctx.StringValue("ListJobs.Jobs["+ i +"].Contacts["+ j +"].ContactName");
					contact.Honorific = _ctx.StringValue("ListJobs.Jobs["+ i +"].Contacts["+ j +"].Honorific");
					contact.JobId = _ctx.StringValue("ListJobs.Jobs["+ i +"].Contacts["+ j +"].JobId");
					contact.PhoneNumber = _ctx.StringValue("ListJobs.Jobs["+ i +"].Contacts["+ j +"].PhoneNumber");
					contact.ReferenceId = _ctx.StringValue("ListJobs.Jobs["+ i +"].Contacts["+ j +"].ReferenceId");
					contact.Role = _ctx.StringValue("ListJobs.Jobs["+ i +"].Contacts["+ j +"].Role");
					contact.State = _ctx.StringValue("ListJobs.Jobs["+ i +"].Contacts["+ j +"].State");

					job_contacts.Add(contact);
				}
				job.Contacts = job_contacts;

				List<ListJobsResponse.ListJobs_Job.ListJobs_KeyValuePair> job_extras = new List<ListJobsResponse.ListJobs_Job.ListJobs_KeyValuePair>();
				for (int j = 0; j < _ctx.Length("ListJobs.Jobs["+ i +"].Extras.Length"); j++) {
					ListJobsResponse.ListJobs_Job.ListJobs_KeyValuePair keyValuePair = new ListJobsResponse.ListJobs_Job.ListJobs_KeyValuePair();
					keyValuePair.Key = _ctx.StringValue("ListJobs.Jobs["+ i +"].Extras["+ j +"].Key");
					keyValuePair._Value = _ctx.StringValue("ListJobs.Jobs["+ i +"].Extras["+ j +"].Value");

					job_extras.Add(keyValuePair);
				}
				job.Extras = job_extras;

				List<ListJobsResponse.ListJobs_Job.ListJobs_SummaryItem> job_summary = new List<ListJobsResponse.ListJobs_Job.ListJobs_SummaryItem>();
				for (int j = 0; j < _ctx.Length("ListJobs.Jobs["+ i +"].Summary.Length"); j++) {
					ListJobsResponse.ListJobs_Job.ListJobs_SummaryItem summaryItem = new ListJobsResponse.ListJobs_Job.ListJobs_SummaryItem();
					summaryItem.Category = _ctx.StringValue("ListJobs.Jobs["+ i +"].Summary["+ j +"].Category");
					summaryItem.Content = _ctx.StringValue("ListJobs.Jobs["+ i +"].Summary["+ j +"].Content");
					summaryItem.SummaryName = _ctx.StringValue("ListJobs.Jobs["+ i +"].Summary["+ j +"].SummaryName");

					job_summary.Add(summaryItem);
				}
				job.Summary = job_summary;

				List<ListJobsResponse.ListJobs_Job.ListJobs_Task> job_tasks = new List<ListJobsResponse.ListJobs_Job.ListJobs_Task>();
				for (int j = 0; j < _ctx.Length("ListJobs.Jobs["+ i +"].Tasks.Length"); j++) {
					ListJobsResponse.ListJobs_Job.ListJobs_Task task = new ListJobsResponse.ListJobs_Job.ListJobs_Task();
					task.ActualTime = _ctx.LongValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].ActualTime");
					task.Brief = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Brief");
					task.CallId = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].CallId");
					task.CalledNumber = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].CalledNumber");
					task.CallingNumber = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].CallingNumber");
					task.ChatbotId = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].ChatbotId");
					task.Duration = _ctx.IntegerValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Duration");
					task.JobId = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].JobId");
					task.PlanedTime = _ctx.LongValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].PlanedTime");
					task.ScenarioId = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].ScenarioId");
					task.Status = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Status");
					task.TaskId = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].TaskId");

					ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_Contact3 contact3 = new ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_Contact3();
					contact3.ContactId = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Contact.ContactId");
					contact3.ContactName = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Contact.ContactName");
					contact3.Honorific = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Contact.Honorific");
					contact3.JobId = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Contact.JobId");
					contact3.PhoneNumber = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Contact.PhoneNumber");
					contact3.ReferenceId = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Contact.ReferenceId");
					contact3.Role = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Contact.Role");
					contact3.State = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Contact.State");
					task.Contact3 = contact3;

					List<ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_ConversationDetail> task_conversation = new List<ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_ConversationDetail>();
					for (int k = 0; k < _ctx.Length("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Conversation.Length"); k++) {
						ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_ConversationDetail conversationDetail = new ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_ConversationDetail();
						conversationDetail.Script = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Script");
						conversationDetail.Speaker = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Speaker");
						conversationDetail.Timestamp = _ctx.LongValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Timestamp");

						List<ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_ConversationDetail.ListJobs_SummaryItem2> conversationDetail_summary1 = new List<ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_ConversationDetail.ListJobs_SummaryItem2>();
						for (int l = 0; l < _ctx.Length("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Summary.Length"); l++) {
							ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_ConversationDetail.ListJobs_SummaryItem2 summaryItem2 = new ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_ConversationDetail.ListJobs_SummaryItem2();
							summaryItem2.Category = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Summary["+ l +"].Category");
							summaryItem2.Content = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Summary["+ l +"].Content");
							summaryItem2.SummaryName = _ctx.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Summary["+ l +"].SummaryName");

							conversationDetail_summary1.Add(summaryItem2);
						}
						conversationDetail.Summary1 = conversationDetail_summary1;

						task_conversation.Add(conversationDetail);
					}
					task.Conversation = task_conversation;

					job_tasks.Add(task);
				}
				job.Tasks = job_tasks;

				listJobsResponse_jobs.Add(job);
			}
			listJobsResponse.Jobs = listJobsResponse_jobs;
        
			return listJobsResponse;
        }
    }
}
