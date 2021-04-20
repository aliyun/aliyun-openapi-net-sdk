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
    public class GetJobResponseUnmarshaller
    {
        public static GetJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJobResponse getJobResponse = new GetJobResponse();

			getJobResponse.HttpResponse = _ctx.HttpResponse;
			getJobResponse.RequestId = _ctx.StringValue("GetJob.RequestId");
			getJobResponse.Success = _ctx.BooleanValue("GetJob.Success");
			getJobResponse.Code = _ctx.StringValue("GetJob.Code");
			getJobResponse.Message = _ctx.StringValue("GetJob.Message");
			getJobResponse.HttpStatusCode = _ctx.IntegerValue("GetJob.HttpStatusCode");

			GetJobResponse.GetJob_Job job = new GetJobResponse.GetJob_Job();
			job.JobId = _ctx.StringValue("GetJob.Job.JobId");
			job.GroupId = _ctx.StringValue("GetJob.Job.GroupId");
			job.ScenarioId = _ctx.StringValue("GetJob.Job.ScenarioId");
			job.StrategyId = _ctx.StringValue("GetJob.Job.StrategyId");
			job.Priority = _ctx.IntegerValue("GetJob.Job.Priority");
			job.SystemPriority = _ctx.IntegerValue("GetJob.Job.SystemPriority");
			job.Status = _ctx.StringValue("GetJob.Job.Status");
			job.ReferenceId = _ctx.StringValue("GetJob.Job.ReferenceId");
			job.FailureReason = _ctx.StringValue("GetJob.Job.FailureReason");

			List<string> job_callingNumbers = new List<string>();
			for (int i = 0; i < _ctx.Length("GetJob.Job.CallingNumbers.Length"); i++) {
				job_callingNumbers.Add(_ctx.StringValue("GetJob.Job.CallingNumbers["+ i +"]"));
			}
			job.CallingNumbers = job_callingNumbers;

			List<GetJobResponse.GetJob_Job.GetJob_Contact> job_contacts = new List<GetJobResponse.GetJob_Job.GetJob_Contact>();
			for (int i = 0; i < _ctx.Length("GetJob.Job.Contacts.Length"); i++) {
				GetJobResponse.GetJob_Job.GetJob_Contact contact = new GetJobResponse.GetJob_Job.GetJob_Contact();
				contact.ContactId = _ctx.StringValue("GetJob.Job.Contacts["+ i +"].ContactId");
				contact.ContactName = _ctx.StringValue("GetJob.Job.Contacts["+ i +"].ContactName");
				contact.Honorific = _ctx.StringValue("GetJob.Job.Contacts["+ i +"].Honorific");
				contact.Role = _ctx.StringValue("GetJob.Job.Contacts["+ i +"].Role");
				contact.PhoneNumber = _ctx.StringValue("GetJob.Job.Contacts["+ i +"].PhoneNumber");
				contact.State = _ctx.StringValue("GetJob.Job.Contacts["+ i +"].State");
				contact.ReferenceId = _ctx.StringValue("GetJob.Job.Contacts["+ i +"].ReferenceId");

				job_contacts.Add(contact);
			}
			job.Contacts = job_contacts;

			List<GetJobResponse.GetJob_Job.GetJob_KeyValuePair> job_extras = new List<GetJobResponse.GetJob_Job.GetJob_KeyValuePair>();
			for (int i = 0; i < _ctx.Length("GetJob.Job.Extras.Length"); i++) {
				GetJobResponse.GetJob_Job.GetJob_KeyValuePair keyValuePair = new GetJobResponse.GetJob_Job.GetJob_KeyValuePair();
				keyValuePair.Key = _ctx.StringValue("GetJob.Job.Extras["+ i +"].Key");
				keyValuePair._Value = _ctx.StringValue("GetJob.Job.Extras["+ i +"].Value");

				job_extras.Add(keyValuePair);
			}
			job.Extras = job_extras;

			List<GetJobResponse.GetJob_Job.GetJob_Task> job_tasks = new List<GetJobResponse.GetJob_Job.GetJob_Task>();
			for (int i = 0; i < _ctx.Length("GetJob.Job.Tasks.Length"); i++) {
				GetJobResponse.GetJob_Job.GetJob_Task task = new GetJobResponse.GetJob_Job.GetJob_Task();
				task.TaskId = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].TaskId");
				task.JobId = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].JobId");
				task.ScenarioId = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].ScenarioId");
				task.ChatbotId = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].ChatbotId");
				task.PlanedTime = _ctx.LongValue("GetJob.Job.Tasks["+ i +"].PlanedTime");
				task.ActualTime = _ctx.LongValue("GetJob.Job.Tasks["+ i +"].ActualTime");
				task.CallingNumber = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].CallingNumber");
				task.CalledNumber = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].CalledNumber");
				task.CallId = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].CallId");
				task.Status = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].Status");
				task.Brief = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].Brief");
				task.Duration = _ctx.IntegerValue("GetJob.Job.Tasks["+ i +"].Duration");

				GetJobResponse.GetJob_Job.GetJob_Task.GetJob_Contact2 contact2 = new GetJobResponse.GetJob_Job.GetJob_Task.GetJob_Contact2();
				contact2.ContactId = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].Contact.ContactId");
				contact2.ContactName = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].Contact.ContactName");
				contact2.Honorific = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].Contact.Honorific");
				contact2.Role = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].Contact.Role");
				contact2.PhoneNumber = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].Contact.PhoneNumber");
				contact2.State = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].Contact.State");
				contact2.ReferenceId = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].Contact.ReferenceId");
				task.Contact2 = contact2;

				List<GetJobResponse.GetJob_Job.GetJob_Task.GetJob_ConversationDetail> task_conversation = new List<GetJobResponse.GetJob_Job.GetJob_Task.GetJob_ConversationDetail>();
				for (int j = 0; j < _ctx.Length("GetJob.Job.Tasks["+ i +"].Conversation.Length"); j++) {
					GetJobResponse.GetJob_Job.GetJob_Task.GetJob_ConversationDetail conversationDetail = new GetJobResponse.GetJob_Job.GetJob_Task.GetJob_ConversationDetail();
					conversationDetail.Timestamp = _ctx.LongValue("GetJob.Job.Tasks["+ i +"].Conversation["+ j +"].Timestamp");
					conversationDetail.Speaker = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].Conversation["+ j +"].Speaker");
					conversationDetail.Script = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].Conversation["+ j +"].Script");

					List<GetJobResponse.GetJob_Job.GetJob_Task.GetJob_ConversationDetail.GetJob_SummaryItem> conversationDetail_summary1 = new List<GetJobResponse.GetJob_Job.GetJob_Task.GetJob_ConversationDetail.GetJob_SummaryItem>();
					for (int k = 0; k < _ctx.Length("GetJob.Job.Tasks["+ i +"].Conversation["+ j +"].Summary.Length"); k++) {
						GetJobResponse.GetJob_Job.GetJob_Task.GetJob_ConversationDetail.GetJob_SummaryItem summaryItem = new GetJobResponse.GetJob_Job.GetJob_Task.GetJob_ConversationDetail.GetJob_SummaryItem();
						summaryItem.Category = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].Category");
						summaryItem.SummaryName = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].SummaryName");
						summaryItem.Content = _ctx.StringValue("GetJob.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].Content");

						conversationDetail_summary1.Add(summaryItem);
					}
					conversationDetail.Summary1 = conversationDetail_summary1;

					task_conversation.Add(conversationDetail);
				}
				task.Conversation = task_conversation;

				job_tasks.Add(task);
			}
			job.Tasks = job_tasks;

			List<GetJobResponse.GetJob_Job.GetJob_SummaryItem3> job_summary = new List<GetJobResponse.GetJob_Job.GetJob_SummaryItem3>();
			for (int i = 0; i < _ctx.Length("GetJob.Job.Summary.Length"); i++) {
				GetJobResponse.GetJob_Job.GetJob_SummaryItem3 summaryItem3 = new GetJobResponse.GetJob_Job.GetJob_SummaryItem3();
				summaryItem3.Category = _ctx.StringValue("GetJob.Job.Summary["+ i +"].Category");
				summaryItem3.SummaryName = _ctx.StringValue("GetJob.Job.Summary["+ i +"].SummaryName");
				summaryItem3.Content = _ctx.StringValue("GetJob.Job.Summary["+ i +"].Content");

				job_summary.Add(summaryItem3);
			}
			job.Summary = job_summary;
			getJobResponse.Job = job;
        
			return getJobResponse;
        }
    }
}
