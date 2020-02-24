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
    public class GetJobByPhoneNumberResponseUnmarshaller
    {
        public static GetJobByPhoneNumberResponse Unmarshall(UnmarshallerContext context)
        {
			GetJobByPhoneNumberResponse getJobByPhoneNumberResponse = new GetJobByPhoneNumberResponse();

			getJobByPhoneNumberResponse.HttpResponse = context.HttpResponse;
			getJobByPhoneNumberResponse.RequestId = context.StringValue("GetJobByPhoneNumber.RequestId");
			getJobByPhoneNumberResponse.Success = context.BooleanValue("GetJobByPhoneNumber.Success");
			getJobByPhoneNumberResponse.Code = context.StringValue("GetJobByPhoneNumber.Code");
			getJobByPhoneNumberResponse.Message = context.StringValue("GetJobByPhoneNumber.Message");
			getJobByPhoneNumberResponse.HttpStatusCode = context.IntegerValue("GetJobByPhoneNumber.HttpStatusCode");

			List<GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job> getJobByPhoneNumberResponse_jobs = new List<GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job>();
			for (int i = 0; i < context.Length("GetJobByPhoneNumber.Jobs.Length"); i++) {
				GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job job = new GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job();
				job.JobId = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].JobId");
				job.GroupId = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].GroupId");
				job.ScenarioId = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].ScenarioId");
				job.StrategyId = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].StrategyId");
				job.Priority = context.IntegerValue("GetJobByPhoneNumber.Jobs["+ i +"].Priority");
				job.SystemPriority = context.IntegerValue("GetJobByPhoneNumber.Jobs["+ i +"].SystemPriority");
				job.Status = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Status");
				job.ReferenceId = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].ReferenceId");
				job.FailureReason = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].FailureReason");

				List<string> job_callingNumbers = new List<string>();
				for (int j = 0; j < context.Length("GetJobByPhoneNumber.Jobs["+ i +"].CallingNumbers.Length"); j++) {
					job_callingNumbers.Add(context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].CallingNumbers["+ j +"]"));
				}
				job.CallingNumbers = job_callingNumbers;

				List<GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Contact> job_contacts = new List<GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Contact>();
				for (int j = 0; j < context.Length("GetJobByPhoneNumber.Jobs["+ i +"].Contacts.Length"); j++) {
					GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Contact contact = new GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Contact();
					contact.ContactId = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Contacts["+ j +"].ContactId");
					contact.ContactName = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Contacts["+ j +"].ContactName");
					contact.Honorific = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Contacts["+ j +"].Honorific");
					contact.Role = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Contacts["+ j +"].Role");
					contact.PhoneNumber = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Contacts["+ j +"].PhoneNumber");
					contact.State = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Contacts["+ j +"].State");
					contact.ReferenceId = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Contacts["+ j +"].ReferenceId");
					contact.JobId = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Contacts["+ j +"].JobId");

					job_contacts.Add(contact);
				}
				job.Contacts = job_contacts;

				List<GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_KeyValuePair> job_extras = new List<GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_KeyValuePair>();
				for (int j = 0; j < context.Length("GetJobByPhoneNumber.Jobs["+ i +"].Extras.Length"); j++) {
					GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_KeyValuePair keyValuePair = new GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_KeyValuePair();
					keyValuePair.Key = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Extras["+ j +"].Key");
					keyValuePair._Value = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Extras["+ j +"].Value");

					job_extras.Add(keyValuePair);
				}
				job.Extras = job_extras;

				List<GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Task> job_tasks = new List<GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Task>();
				for (int j = 0; j < context.Length("GetJobByPhoneNumber.Jobs["+ i +"].Tasks.Length"); j++) {
					GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Task task = new GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Task();
					task.TaskId = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].TaskId");
					task.JobId = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].JobId");
					task.ScenarioId = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].ScenarioId");
					task.ChatbotId = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].ChatbotId");
					task.PlanedTime = context.LongValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].PlanedTime");
					task.ActualTime = context.LongValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].ActualTime");
					task.CallingNumber = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].CallingNumber");
					task.CalledNumber = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].CalledNumber");
					task.CallId = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].CallId");
					task.Status = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Status");
					task.Brief = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Brief");
					task.Duration = context.IntegerValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Duration");

					GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Task.GetJobByPhoneNumber_Contact2 contact2 = new GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Task.GetJobByPhoneNumber_Contact2();
					contact2.ContactId = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Contact.ContactId");
					contact2.ContactName = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Contact.ContactName");
					contact2.Honorific = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Contact.Honorific");
					contact2.Role = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Contact.Role");
					contact2.PhoneNumber = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Contact.PhoneNumber");
					contact2.State = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Contact.State");
					contact2.ReferenceId = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Contact.ReferenceId");
					contact2.JobId = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Contact.JobId");
					task.Contact2 = contact2;

					List<GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Task.GetJobByPhoneNumber_ConversationDetail> task_conversation = new List<GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Task.GetJobByPhoneNumber_ConversationDetail>();
					for (int k = 0; k < context.Length("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Conversation.Length"); k++) {
						GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Task.GetJobByPhoneNumber_ConversationDetail conversationDetail = new GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Task.GetJobByPhoneNumber_ConversationDetail();
						conversationDetail.Timestamp = context.LongValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Timestamp");
						conversationDetail.Speaker = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Speaker");
						conversationDetail.Script = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Script");

						List<GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Task.GetJobByPhoneNumber_ConversationDetail.GetJobByPhoneNumber_SummaryItem> conversationDetail_summary1 = new List<GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Task.GetJobByPhoneNumber_ConversationDetail.GetJobByPhoneNumber_SummaryItem>();
						for (int l = 0; l < context.Length("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Summary.Length"); l++) {
							GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Task.GetJobByPhoneNumber_ConversationDetail.GetJobByPhoneNumber_SummaryItem summaryItem = new GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_Task.GetJobByPhoneNumber_ConversationDetail.GetJobByPhoneNumber_SummaryItem();
							summaryItem.Category = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Summary["+ l +"].Category");
							summaryItem.SummaryName = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Summary["+ l +"].SummaryName");
							summaryItem.Content = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Tasks["+ j +"].Conversation["+ k +"].Summary["+ l +"].Content");

							conversationDetail_summary1.Add(summaryItem);
						}
						conversationDetail.Summary1 = conversationDetail_summary1;

						task_conversation.Add(conversationDetail);
					}
					task.Conversation = task_conversation;

					job_tasks.Add(task);
				}
				job.Tasks = job_tasks;

				List<GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_SummaryItem3> job_summary = new List<GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_SummaryItem3>();
				for (int j = 0; j < context.Length("GetJobByPhoneNumber.Jobs["+ i +"].Summary.Length"); j++) {
					GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_SummaryItem3 summaryItem3 = new GetJobByPhoneNumberResponse.GetJobByPhoneNumber_Job.GetJobByPhoneNumber_SummaryItem3();
					summaryItem3.Category = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Summary["+ j +"].Category");
					summaryItem3.SummaryName = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Summary["+ j +"].SummaryName");
					summaryItem3.Content = context.StringValue("GetJobByPhoneNumber.Jobs["+ i +"].Summary["+ j +"].Content");

					job_summary.Add(summaryItem3);
				}
				job.Summary = job_summary;

				getJobByPhoneNumberResponse_jobs.Add(job);
			}
			getJobByPhoneNumberResponse.Jobs = getJobByPhoneNumberResponse_jobs;
        
			return getJobByPhoneNumberResponse;
        }
    }
}
