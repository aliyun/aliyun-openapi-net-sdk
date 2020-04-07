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
    public class GetJobStatusByCallIdResponseUnmarshaller
    {
        public static GetJobStatusByCallIdResponse Unmarshall(UnmarshallerContext context)
        {
			GetJobStatusByCallIdResponse getJobStatusByCallIdResponse = new GetJobStatusByCallIdResponse();

			getJobStatusByCallIdResponse.HttpResponse = context.HttpResponse;
			getJobStatusByCallIdResponse.RequestId = context.StringValue("GetJobStatusByCallId.RequestId");
			getJobStatusByCallIdResponse.Success = context.BooleanValue("GetJobStatusByCallId.Success");
			getJobStatusByCallIdResponse.Code = context.StringValue("GetJobStatusByCallId.Code");
			getJobStatusByCallIdResponse.Message = context.StringValue("GetJobStatusByCallId.Message");
			getJobStatusByCallIdResponse.HttpStatusCode = context.IntegerValue("GetJobStatusByCallId.HttpStatusCode");

			GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job job = new GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job();
			job.JobId = context.StringValue("GetJobStatusByCallId.Job.JobId");
			job.GroupId = context.StringValue("GetJobStatusByCallId.Job.GroupId");
			job.ScenarioId = context.StringValue("GetJobStatusByCallId.Job.ScenarioId");
			job.StrategyId = context.StringValue("GetJobStatusByCallId.Job.StrategyId");
			job.Priority = context.IntegerValue("GetJobStatusByCallId.Job.Priority");
			job.Status = context.StringValue("GetJobStatusByCallId.Job.Status");
			job.ReferenceId = context.StringValue("GetJobStatusByCallId.Job.ReferenceId");
			job.FailureReason = context.StringValue("GetJobStatusByCallId.Job.FailureReason");

			List<string> job_callingNumbers = new List<string>();
			for (int i = 0; i < context.Length("GetJobStatusByCallId.Job.CallingNumbers.Length"); i++) {
				job_callingNumbers.Add(context.StringValue("GetJobStatusByCallId.Job.CallingNumbers["+ i +"]"));
			}
			job.CallingNumbers = job_callingNumbers;

			List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Contact> job_contacts = new List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Contact>();
			for (int i = 0; i < context.Length("GetJobStatusByCallId.Job.Contacts.Length"); i++) {
				GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Contact contact = new GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Contact();
				contact.ContactId = context.StringValue("GetJobStatusByCallId.Job.Contacts["+ i +"].ContactId");
				contact.ContactName = context.StringValue("GetJobStatusByCallId.Job.Contacts["+ i +"].ContactName");
				contact.Honorific = context.StringValue("GetJobStatusByCallId.Job.Contacts["+ i +"].Honorific");
				contact.Role = context.StringValue("GetJobStatusByCallId.Job.Contacts["+ i +"].Role");
				contact.PhoneNumber = context.StringValue("GetJobStatusByCallId.Job.Contacts["+ i +"].PhoneNumber");
				contact.State = context.StringValue("GetJobStatusByCallId.Job.Contacts["+ i +"].State");
				contact.ReferenceId = context.StringValue("GetJobStatusByCallId.Job.Contacts["+ i +"].ReferenceId");
				contact.JobId = context.StringValue("GetJobStatusByCallId.Job.Contacts["+ i +"].JobId");

				job_contacts.Add(contact);
			}
			job.Contacts = job_contacts;

			List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_KeyValuePair> job_extras = new List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_KeyValuePair>();
			for (int i = 0; i < context.Length("GetJobStatusByCallId.Job.Extras.Length"); i++) {
				GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_KeyValuePair keyValuePair = new GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_KeyValuePair();
				keyValuePair.Key = context.StringValue("GetJobStatusByCallId.Job.Extras["+ i +"].Key");
				keyValuePair._Value = context.StringValue("GetJobStatusByCallId.Job.Extras["+ i +"].Value");

				job_extras.Add(keyValuePair);
			}
			job.Extras = job_extras;

			List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task> job_tasks = new List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task>();
			for (int i = 0; i < context.Length("GetJobStatusByCallId.Job.Tasks.Length"); i++) {
				GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task task = new GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task();
				task.TaskId = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].TaskId");
				task.JobId = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].JobId");
				task.ScenarioId = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].ScenarioId");
				task.ChatbotId = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].ChatbotId");
				task.PlanedTime = context.LongValue("GetJobStatusByCallId.Job.Tasks["+ i +"].PlanedTime");
				task.ActualTime = context.LongValue("GetJobStatusByCallId.Job.Tasks["+ i +"].ActualTime");
				task.EndTime = context.LongValue("GetJobStatusByCallId.Job.Tasks["+ i +"].EndTime");
				task.CallingNumber = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].CallingNumber");
				task.CalledNumber = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].CalledNumber");
				task.CallId = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].CallId");
				task.Status = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Status");
				task.Brief = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Brief");
				task.Duration = context.IntegerValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Duration");

				GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_Contact2 contact2 = new GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_Contact2();
				contact2.ContactId = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Contact.ContactId");
				contact2.ContactName = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Contact.ContactName");
				contact2.Honorific = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Contact.Honorific");
				contact2.Role = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Contact.Role");
				contact2.PhoneNumber = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Contact.PhoneNumber");
				contact2.State = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Contact.State");
				contact2.ReferenceId = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Contact.ReferenceId");
				contact2.JobId = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Contact.JobId");
				task.Contact2 = contact2;

				List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_ConversationDetail> task_conversation = new List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_ConversationDetail>();
				for (int j = 0; j < context.Length("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation.Length"); j++) {
					GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_ConversationDetail conversationDetail = new GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_ConversationDetail();
					conversationDetail.ConversationDetailId = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].ConversationDetailId");
					conversationDetail.TaskId = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].TaskId");
					conversationDetail.Timestamp = context.LongValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].Timestamp");
					conversationDetail.Speaker = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].Speaker");
					conversationDetail.Script = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].Script");

					List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_ConversationDetail.GetJobStatusByCallId_SummaryItem> conversationDetail_summary1 = new List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_ConversationDetail.GetJobStatusByCallId_SummaryItem>();
					for (int k = 0; k < context.Length("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].Summary.Length"); k++) {
						GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_ConversationDetail.GetJobStatusByCallId_SummaryItem summaryItem = new GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_ConversationDetail.GetJobStatusByCallId_SummaryItem();
						summaryItem.SummaryId = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].SummaryId");
						summaryItem.Category = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].Category");
						summaryItem.SummaryName = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].SummaryName");
						summaryItem.Content = context.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].Content");

						conversationDetail_summary1.Add(summaryItem);
					}
					conversationDetail.Summary1 = conversationDetail_summary1;

					task_conversation.Add(conversationDetail);
				}
				task.Conversation = task_conversation;

				job_tasks.Add(task);
			}
			job.Tasks = job_tasks;

			List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_SummaryItem3> job_summary = new List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_SummaryItem3>();
			for (int i = 0; i < context.Length("GetJobStatusByCallId.Job.Summary.Length"); i++) {
				GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_SummaryItem3 summaryItem3 = new GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_SummaryItem3();
				summaryItem3.SummaryId = context.StringValue("GetJobStatusByCallId.Job.Summary["+ i +"].SummaryId");
				summaryItem3.Category = context.StringValue("GetJobStatusByCallId.Job.Summary["+ i +"].Category");
				summaryItem3.SummaryName = context.StringValue("GetJobStatusByCallId.Job.Summary["+ i +"].SummaryName");
				summaryItem3.Content = context.StringValue("GetJobStatusByCallId.Job.Summary["+ i +"].Content");

				job_summary.Add(summaryItem3);
			}
			job.Summary = job_summary;
			getJobStatusByCallIdResponse.Job = job;
        
			return getJobStatusByCallIdResponse;
        }
    }
}
