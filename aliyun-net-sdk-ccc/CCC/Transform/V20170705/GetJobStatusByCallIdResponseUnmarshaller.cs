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
        public static GetJobStatusByCallIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJobStatusByCallIdResponse getJobStatusByCallIdResponse = new GetJobStatusByCallIdResponse();

			getJobStatusByCallIdResponse.HttpResponse = _ctx.HttpResponse;
			getJobStatusByCallIdResponse.RequestId = _ctx.StringValue("GetJobStatusByCallId.RequestId");
			getJobStatusByCallIdResponse.Success = _ctx.BooleanValue("GetJobStatusByCallId.Success");
			getJobStatusByCallIdResponse.Code = _ctx.StringValue("GetJobStatusByCallId.Code");
			getJobStatusByCallIdResponse.Message = _ctx.StringValue("GetJobStatusByCallId.Message");
			getJobStatusByCallIdResponse.HttpStatusCode = _ctx.IntegerValue("GetJobStatusByCallId.HttpStatusCode");

			GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job job = new GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job();
			job.JobId = _ctx.StringValue("GetJobStatusByCallId.Job.JobId");
			job.GroupId = _ctx.StringValue("GetJobStatusByCallId.Job.GroupId");
			job.ScenarioId = _ctx.StringValue("GetJobStatusByCallId.Job.ScenarioId");
			job.StrategyId = _ctx.StringValue("GetJobStatusByCallId.Job.StrategyId");
			job.Priority = _ctx.IntegerValue("GetJobStatusByCallId.Job.Priority");
			job.Status = _ctx.StringValue("GetJobStatusByCallId.Job.Status");
			job.ReferenceId = _ctx.StringValue("GetJobStatusByCallId.Job.ReferenceId");
			job.FailureReason = _ctx.StringValue("GetJobStatusByCallId.Job.FailureReason");

			List<string> job_callingNumbers = new List<string>();
			for (int i = 0; i < _ctx.Length("GetJobStatusByCallId.Job.CallingNumbers.Length"); i++) {
				job_callingNumbers.Add(_ctx.StringValue("GetJobStatusByCallId.Job.CallingNumbers["+ i +"]"));
			}
			job.CallingNumbers = job_callingNumbers;

			List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Contact> job_contacts = new List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Contact>();
			for (int i = 0; i < _ctx.Length("GetJobStatusByCallId.Job.Contacts.Length"); i++) {
				GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Contact contact = new GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Contact();
				contact.ContactId = _ctx.StringValue("GetJobStatusByCallId.Job.Contacts["+ i +"].ContactId");
				contact.ContactName = _ctx.StringValue("GetJobStatusByCallId.Job.Contacts["+ i +"].ContactName");
				contact.Honorific = _ctx.StringValue("GetJobStatusByCallId.Job.Contacts["+ i +"].Honorific");
				contact.Role = _ctx.StringValue("GetJobStatusByCallId.Job.Contacts["+ i +"].Role");
				contact.PhoneNumber = _ctx.StringValue("GetJobStatusByCallId.Job.Contacts["+ i +"].PhoneNumber");
				contact.State = _ctx.StringValue("GetJobStatusByCallId.Job.Contacts["+ i +"].State");
				contact.ReferenceId = _ctx.StringValue("GetJobStatusByCallId.Job.Contacts["+ i +"].ReferenceId");
				contact.JobId = _ctx.StringValue("GetJobStatusByCallId.Job.Contacts["+ i +"].JobId");

				job_contacts.Add(contact);
			}
			job.Contacts = job_contacts;

			List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_KeyValuePair> job_extras = new List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_KeyValuePair>();
			for (int i = 0; i < _ctx.Length("GetJobStatusByCallId.Job.Extras.Length"); i++) {
				GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_KeyValuePair keyValuePair = new GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_KeyValuePair();
				keyValuePair.Key = _ctx.StringValue("GetJobStatusByCallId.Job.Extras["+ i +"].Key");
				keyValuePair._Value = _ctx.StringValue("GetJobStatusByCallId.Job.Extras["+ i +"].Value");

				job_extras.Add(keyValuePair);
			}
			job.Extras = job_extras;

			List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task> job_tasks = new List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task>();
			for (int i = 0; i < _ctx.Length("GetJobStatusByCallId.Job.Tasks.Length"); i++) {
				GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task task = new GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task();
				task.TaskId = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].TaskId");
				task.JobId = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].JobId");
				task.ScenarioId = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].ScenarioId");
				task.ChatbotId = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].ChatbotId");
				task.PlanedTime = _ctx.LongValue("GetJobStatusByCallId.Job.Tasks["+ i +"].PlanedTime");
				task.ActualTime = _ctx.LongValue("GetJobStatusByCallId.Job.Tasks["+ i +"].ActualTime");
				task.EndTime = _ctx.LongValue("GetJobStatusByCallId.Job.Tasks["+ i +"].EndTime");
				task.CallingNumber = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].CallingNumber");
				task.CalledNumber = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].CalledNumber");
				task.CallId = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].CallId");
				task.Status = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Status");
				task.Brief = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Brief");
				task.Duration = _ctx.IntegerValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Duration");

				GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_Contact2 contact2 = new GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_Contact2();
				contact2.ContactId = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Contact.ContactId");
				contact2.ContactName = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Contact.ContactName");
				contact2.Honorific = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Contact.Honorific");
				contact2.Role = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Contact.Role");
				contact2.PhoneNumber = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Contact.PhoneNumber");
				contact2.State = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Contact.State");
				contact2.ReferenceId = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Contact.ReferenceId");
				contact2.JobId = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Contact.JobId");
				task.Contact2 = contact2;

				List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_ConversationDetail> task_conversation = new List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_ConversationDetail>();
				for (int j = 0; j < _ctx.Length("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation.Length"); j++) {
					GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_ConversationDetail conversationDetail = new GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_ConversationDetail();
					conversationDetail.ConversationDetailId = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].ConversationDetailId");
					conversationDetail.TaskId = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].TaskId");
					conversationDetail.Timestamp = _ctx.LongValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].Timestamp");
					conversationDetail.Speaker = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].Speaker");
					conversationDetail.Script = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].Script");

					List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_ConversationDetail.GetJobStatusByCallId_SummaryItem> conversationDetail_summary1 = new List<GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_ConversationDetail.GetJobStatusByCallId_SummaryItem>();
					for (int k = 0; k < _ctx.Length("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].Summary.Length"); k++) {
						GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_ConversationDetail.GetJobStatusByCallId_SummaryItem summaryItem = new GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_Task.GetJobStatusByCallId_ConversationDetail.GetJobStatusByCallId_SummaryItem();
						summaryItem.SummaryId = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].SummaryId");
						summaryItem.Category = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].Category");
						summaryItem.SummaryName = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].SummaryName");
						summaryItem.Content = _ctx.StringValue("GetJobStatusByCallId.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].Content");

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
			for (int i = 0; i < _ctx.Length("GetJobStatusByCallId.Job.Summary.Length"); i++) {
				GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_SummaryItem3 summaryItem3 = new GetJobStatusByCallIdResponse.GetJobStatusByCallId_Job.GetJobStatusByCallId_SummaryItem3();
				summaryItem3.SummaryId = _ctx.StringValue("GetJobStatusByCallId.Job.Summary["+ i +"].SummaryId");
				summaryItem3.Category = _ctx.StringValue("GetJobStatusByCallId.Job.Summary["+ i +"].Category");
				summaryItem3.SummaryName = _ctx.StringValue("GetJobStatusByCallId.Job.Summary["+ i +"].SummaryName");
				summaryItem3.Content = _ctx.StringValue("GetJobStatusByCallId.Job.Summary["+ i +"].Content");

				job_summary.Add(summaryItem3);
			}
			job.Summary = job_summary;
			getJobStatusByCallIdResponse.Job = job;
        
			return getJobStatusByCallIdResponse;
        }
    }
}
