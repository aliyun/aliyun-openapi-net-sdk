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
        public static ListJobsResponse Unmarshall(UnmarshallerContext context)
        {
			ListJobsResponse listJobsResponse = new ListJobsResponse();

			listJobsResponse.HttpResponse = context.HttpResponse;
			listJobsResponse.RequestId = context.StringValue("ListJobs.RequestId");
			listJobsResponse.Success = context.BooleanValue("ListJobs.Success");
			listJobsResponse.Code = context.StringValue("ListJobs.Code");
			listJobsResponse.Message = context.StringValue("ListJobs.Message");
			listJobsResponse.HttpStatusCode = context.IntegerValue("ListJobs.HttpStatusCode");

			List<ListJobsResponse.ListJobs_Job> listJobsResponse_jobs = new List<ListJobsResponse.ListJobs_Job>();
			for (int i = 0; i < context.Length("ListJobs.Jobs.Length"); i++) {
				ListJobsResponse.ListJobs_Job job = new ListJobsResponse.ListJobs_Job();
				job.JobId = context.StringValue("ListJobs.Jobs["+ i +"].JobId");
				job.JobGroupId = context.StringValue("ListJobs.Jobs["+ i +"].JobGroupId");
				job.ScenarioId = context.StringValue("ListJobs.Jobs["+ i +"].ScenarioId");
				job.StrategyId = context.StringValue("ListJobs.Jobs["+ i +"].StrategyId");
				job.Priority = context.IntegerValue("ListJobs.Jobs["+ i +"].Priority");
				job.SystemPriority = context.IntegerValue("ListJobs.Jobs["+ i +"].SystemPriority");
				job.Status = context.StringValue("ListJobs.Jobs["+ i +"].Status");
				job.ReferenceId = context.StringValue("ListJobs.Jobs["+ i +"].ReferenceId");
				job.FailureReason = context.StringValue("ListJobs.Jobs["+ i +"].FailureReason");

				List<string> job_callingNumbers = new List<string>();
				for (int j = 0; j < context.Length("ListJobs.Jobs["+ i +"].CallingNumbers.Length"); j++) {
					job_callingNumbers.Add(context.StringValue("ListJobs.Jobs["+ i +"].CallingNumbers["+ j +"]"));
				}
				job.CallingNumbers = job_callingNumbers;

				List<ListJobsResponse.ListJobs_Job.ListJobs_Contact> job_contacts = new List<ListJobsResponse.ListJobs_Job.ListJobs_Contact>();
				for (int j = 0; j < context.Length("ListJobs.Jobs["+ i +"].Contacts.Length"); j++) {
					ListJobsResponse.ListJobs_Job.ListJobs_Contact contact = new ListJobsResponse.ListJobs_Job.ListJobs_Contact();
					contact.ContactId = context.StringValue("ListJobs.Jobs["+ i +"].Contacts["+ j +"].ContactId");
					contact.ContactName = context.StringValue("ListJobs.Jobs["+ i +"].Contacts["+ j +"].ContactName");
					contact.Honorific = context.StringValue("ListJobs.Jobs["+ i +"].Contacts["+ j +"].Honorific");
					contact.Role = context.StringValue("ListJobs.Jobs["+ i +"].Contacts["+ j +"].Role");
					contact.PhoneNumber = context.StringValue("ListJobs.Jobs["+ i +"].Contacts["+ j +"].PhoneNumber");
					contact.State = context.StringValue("ListJobs.Jobs["+ i +"].Contacts["+ j +"].State");
					contact.ReferenceId = context.StringValue("ListJobs.Jobs["+ i +"].Contacts["+ j +"].ReferenceId");
					contact.JobId = context.StringValue("ListJobs.Jobs["+ i +"].Contacts["+ j +"].JobId");

					job_contacts.Add(contact);
				}
				job.Contacts = job_contacts;

				List<ListJobsResponse.ListJobs_Job.ListJobs_KeyValuePair> job_extras = new List<ListJobsResponse.ListJobs_Job.ListJobs_KeyValuePair>();
				for (int j = 0; j < context.Length("ListJobs.Jobs["+ i +"].Extras.Length"); j++) {
					ListJobsResponse.ListJobs_Job.ListJobs_KeyValuePair keyValuePair = new ListJobsResponse.ListJobs_Job.ListJobs_KeyValuePair();
					keyValuePair.Key = context.StringValue("ListJobs.Jobs["+ i +"].Extras["+ j +"].Key");
					keyValuePair._Value = context.StringValue("ListJobs.Jobs["+ i +"].Extras["+ j +"].Value");

					job_extras.Add(keyValuePair);
				}
				job.Extras = job_extras;

				List<ListJobsResponse.ListJobs_Job.ListJobs_Task> job_tasks = new List<ListJobsResponse.ListJobs_Job.ListJobs_Task>();
				for (int j = 0; j < context.Length("ListJobs.Jobs["+ i +"].Tasks.Length"); j++) {
					ListJobsResponse.ListJobs_Job.ListJobs_Task task = new ListJobsResponse.ListJobs_Job.ListJobs_Task();
					task.TaskId = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].TaskId");
					task.JobId = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].JobId");
					task.ScenarioId = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].ScenarioId");
					task.ChatbotId = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].ChatbotId");
					task.PlanedTime = context.LongValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].PlanedTime");
					task.ActualTime = context.LongValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].ActualTime");
					task.CallingNumber = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].CallingNumber");
					task.CalledNumber = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].CalledNumber");
					task.CallId = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].CallId");
					task.Status = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Status");
					task.Brief = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Brief");
					task.Duration = context.IntegerValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Duration");

					ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_Contact2 contact2 = new ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_Contact2();
					contact2.ContactId = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Contact.ContactId");
					contact2.ContactName = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Contact.ContactName");
					contact2.Honorific = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Contact.Honorific");
					contact2.Role = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Contact.Role");
					contact2.PhoneNumber = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Contact.PhoneNumber");
					contact2.State = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Contact.State");
					contact2.ReferenceId = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Contact.ReferenceId");
					contact2.JobId = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Contact.JobId");
					task.Contact2 = contact2;

					List<ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_ConversationDetail> task_conversation = new List<ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_ConversationDetail>();
					for (int k = 0; k < context.Length("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Conversation.Length"); k++) {
						ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_ConversationDetail conversationDetail = new ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_ConversationDetail();
						conversationDetail.Timestamp = context.LongValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Timestamp");
						conversationDetail.Speaker = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Speaker");
						conversationDetail.Script = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Script");

						List<ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_ConversationDetail.ListJobs_SummaryItem> conversationDetail_summary1 = new List<ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_ConversationDetail.ListJobs_SummaryItem>();
						for (int l = 0; l < context.Length("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Summary.Length"); l++) {
							ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_ConversationDetail.ListJobs_SummaryItem summaryItem = new ListJobsResponse.ListJobs_Job.ListJobs_Task.ListJobs_ConversationDetail.ListJobs_SummaryItem();
							summaryItem.Category = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Summary["+ l +"].Category");
							summaryItem.SummaryName = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Summary["+ l +"].SummaryName");
							summaryItem.Content = context.StringValue("ListJobs.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Summary["+ l +"].Content");

							conversationDetail_summary1.Add(summaryItem);
						}
						conversationDetail.Summary1 = conversationDetail_summary1;

						task_conversation.Add(conversationDetail);
					}
					task.Conversation = task_conversation;

					job_tasks.Add(task);
				}
				job.Tasks = job_tasks;

				List<ListJobsResponse.ListJobs_Job.ListJobs_SummaryItem3> job_summary = new List<ListJobsResponse.ListJobs_Job.ListJobs_SummaryItem3>();
				for (int j = 0; j < context.Length("ListJobs.Jobs["+ i +"].Summary.Length"); j++) {
					ListJobsResponse.ListJobs_Job.ListJobs_SummaryItem3 summaryItem3 = new ListJobsResponse.ListJobs_Job.ListJobs_SummaryItem3();
					summaryItem3.Category = context.StringValue("ListJobs.Jobs["+ i +"].Summary["+ j +"].Category");
					summaryItem3.SummaryName = context.StringValue("ListJobs.Jobs["+ i +"].Summary["+ j +"].SummaryName");
					summaryItem3.Content = context.StringValue("ListJobs.Jobs["+ i +"].Summary["+ j +"].Content");

					job_summary.Add(summaryItem3);
				}
				job.Summary = job_summary;

				listJobsResponse_jobs.Add(job);
			}
			listJobsResponse.Jobs = listJobsResponse_jobs;
        
			return listJobsResponse;
        }
    }
}
