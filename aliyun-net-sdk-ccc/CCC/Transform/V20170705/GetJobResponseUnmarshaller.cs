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
        public static GetJobResponse Unmarshall(UnmarshallerContext context)
        {
			GetJobResponse getJobResponse = new GetJobResponse();

			getJobResponse.HttpResponse = context.HttpResponse;
			getJobResponse.RequestId = context.StringValue("GetJob.RequestId");
			getJobResponse.Success = context.BooleanValue("GetJob.Success");
			getJobResponse.Code = context.StringValue("GetJob.Code");
			getJobResponse.Message = context.StringValue("GetJob.Message");
			getJobResponse.HttpStatusCode = context.IntegerValue("GetJob.HttpStatusCode");

			GetJobResponse.GetJob_Job job = new GetJobResponse.GetJob_Job();
			job.JobId = context.StringValue("GetJob.Job.JobId");
			job.GroupId = context.StringValue("GetJob.Job.GroupId");
			job.ScenarioId = context.StringValue("GetJob.Job.ScenarioId");
			job.StrategyId = context.StringValue("GetJob.Job.StrategyId");
			job.Priority = context.IntegerValue("GetJob.Job.Priority");
			job.SystemPriority = context.IntegerValue("GetJob.Job.SystemPriority");
			job.Status = context.StringValue("GetJob.Job.Status");
			job.ReferenceId = context.StringValue("GetJob.Job.ReferenceId");
			job.FailureReason = context.StringValue("GetJob.Job.FailureReason");

			List<string> job_callingNumbers = new List<string>();
			for (int i = 0; i < context.Length("GetJob.Job.CallingNumbers.Length"); i++) {
				job_callingNumbers.Add(context.StringValue("GetJob.Job.CallingNumbers["+ i +"]"));
			}
			job.CallingNumbers = job_callingNumbers;

			List<GetJobResponse.GetJob_Job.GetJob_Contact> job_contacts = new List<GetJobResponse.GetJob_Job.GetJob_Contact>();
			for (int i = 0; i < context.Length("GetJob.Job.Contacts.Length"); i++) {
				GetJobResponse.GetJob_Job.GetJob_Contact contact = new GetJobResponse.GetJob_Job.GetJob_Contact();
				contact.ContactId = context.StringValue("GetJob.Job.Contacts["+ i +"].ContactId");
				contact.ContactName = context.StringValue("GetJob.Job.Contacts["+ i +"].ContactName");
				contact.Honorific = context.StringValue("GetJob.Job.Contacts["+ i +"].Honorific");
				contact.Role = context.StringValue("GetJob.Job.Contacts["+ i +"].Role");
				contact.PhoneNumber = context.StringValue("GetJob.Job.Contacts["+ i +"].PhoneNumber");
				contact.State = context.StringValue("GetJob.Job.Contacts["+ i +"].State");
				contact.ReferenceId = context.StringValue("GetJob.Job.Contacts["+ i +"].ReferenceId");

				job_contacts.Add(contact);
			}
			job.Contacts = job_contacts;

			List<GetJobResponse.GetJob_Job.GetJob_KeyValuePair> job_extras = new List<GetJobResponse.GetJob_Job.GetJob_KeyValuePair>();
			for (int i = 0; i < context.Length("GetJob.Job.Extras.Length"); i++) {
				GetJobResponse.GetJob_Job.GetJob_KeyValuePair keyValuePair = new GetJobResponse.GetJob_Job.GetJob_KeyValuePair();
				keyValuePair.Key = context.StringValue("GetJob.Job.Extras["+ i +"].Key");
				keyValuePair._Value = context.StringValue("GetJob.Job.Extras["+ i +"].Value");

				job_extras.Add(keyValuePair);
			}
			job.Extras = job_extras;

			List<GetJobResponse.GetJob_Job.GetJob_Task> job_tasks = new List<GetJobResponse.GetJob_Job.GetJob_Task>();
			for (int i = 0; i < context.Length("GetJob.Job.Tasks.Length"); i++) {
				GetJobResponse.GetJob_Job.GetJob_Task task = new GetJobResponse.GetJob_Job.GetJob_Task();
				task.TaskId = context.StringValue("GetJob.Job.Tasks["+ i +"].TaskId");
				task.JobId = context.StringValue("GetJob.Job.Tasks["+ i +"].JobId");
				task.ScenarioId = context.StringValue("GetJob.Job.Tasks["+ i +"].ScenarioId");
				task.ChatbotId = context.StringValue("GetJob.Job.Tasks["+ i +"].ChatbotId");
				task.PlanedTime = context.LongValue("GetJob.Job.Tasks["+ i +"].PlanedTime");
				task.ActualTime = context.LongValue("GetJob.Job.Tasks["+ i +"].ActualTime");
				task.CallingNumber = context.StringValue("GetJob.Job.Tasks["+ i +"].CallingNumber");
				task.CalledNumber = context.StringValue("GetJob.Job.Tasks["+ i +"].CalledNumber");
				task.CallId = context.StringValue("GetJob.Job.Tasks["+ i +"].CallId");
				task.Status = context.StringValue("GetJob.Job.Tasks["+ i +"].Status");
				task.Brief = context.StringValue("GetJob.Job.Tasks["+ i +"].Brief");
				task.Duration = context.IntegerValue("GetJob.Job.Tasks["+ i +"].Duration");

				GetJobResponse.GetJob_Job.GetJob_Task.GetJob_Contact2 contact2 = new GetJobResponse.GetJob_Job.GetJob_Task.GetJob_Contact2();
				contact2.ContactId = context.StringValue("GetJob.Job.Tasks["+ i +"].Contact.ContactId");
				contact2.ContactName = context.StringValue("GetJob.Job.Tasks["+ i +"].Contact.ContactName");
				contact2.Honorific = context.StringValue("GetJob.Job.Tasks["+ i +"].Contact.Honorific");
				contact2.Role = context.StringValue("GetJob.Job.Tasks["+ i +"].Contact.Role");
				contact2.PhoneNumber = context.StringValue("GetJob.Job.Tasks["+ i +"].Contact.PhoneNumber");
				contact2.State = context.StringValue("GetJob.Job.Tasks["+ i +"].Contact.State");
				contact2.ReferenceId = context.StringValue("GetJob.Job.Tasks["+ i +"].Contact.ReferenceId");
				task.Contact2 = contact2;

				List<GetJobResponse.GetJob_Job.GetJob_Task.GetJob_ConversationDetail> task_conversation = new List<GetJobResponse.GetJob_Job.GetJob_Task.GetJob_ConversationDetail>();
				for (int j = 0; j < context.Length("GetJob.Job.Tasks["+ i +"].Conversation.Length"); j++) {
					GetJobResponse.GetJob_Job.GetJob_Task.GetJob_ConversationDetail conversationDetail = new GetJobResponse.GetJob_Job.GetJob_Task.GetJob_ConversationDetail();
					conversationDetail.Timestamp = context.LongValue("GetJob.Job.Tasks["+ i +"].Conversation["+ j +"].Timestamp");
					conversationDetail.Speaker = context.StringValue("GetJob.Job.Tasks["+ i +"].Conversation["+ j +"].Speaker");
					conversationDetail.Script = context.StringValue("GetJob.Job.Tasks["+ i +"].Conversation["+ j +"].Script");

					List<GetJobResponse.GetJob_Job.GetJob_Task.GetJob_ConversationDetail.GetJob_SummaryItem> conversationDetail_summary1 = new List<GetJobResponse.GetJob_Job.GetJob_Task.GetJob_ConversationDetail.GetJob_SummaryItem>();
					for (int k = 0; k < context.Length("GetJob.Job.Tasks["+ i +"].Conversation["+ j +"].Summary.Length"); k++) {
						GetJobResponse.GetJob_Job.GetJob_Task.GetJob_ConversationDetail.GetJob_SummaryItem summaryItem = new GetJobResponse.GetJob_Job.GetJob_Task.GetJob_ConversationDetail.GetJob_SummaryItem();
						summaryItem.Category = context.StringValue("GetJob.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].Category");
						summaryItem.SummaryName = context.StringValue("GetJob.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].SummaryName");
						summaryItem.Content = context.StringValue("GetJob.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].Content");

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
			for (int i = 0; i < context.Length("GetJob.Job.Summary.Length"); i++) {
				GetJobResponse.GetJob_Job.GetJob_SummaryItem3 summaryItem3 = new GetJobResponse.GetJob_Job.GetJob_SummaryItem3();
				summaryItem3.Category = context.StringValue("GetJob.Job.Summary["+ i +"].Category");
				summaryItem3.SummaryName = context.StringValue("GetJob.Job.Summary["+ i +"].SummaryName");
				summaryItem3.Content = context.StringValue("GetJob.Job.Summary["+ i +"].Content");

				job_summary.Add(summaryItem3);
			}
			job.Summary = job_summary;
			getJobResponse.Job = job;
        
			return getJobResponse;
        }
    }
}
