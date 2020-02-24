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
    public class DescribeJobResponseUnmarshaller
    {
        public static DescribeJobResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeJobResponse describeJobResponse = new DescribeJobResponse();

			describeJobResponse.HttpResponse = context.HttpResponse;
			describeJobResponse.RequestId = context.StringValue("DescribeJob.RequestId");
			describeJobResponse.Success = context.BooleanValue("DescribeJob.Success");
			describeJobResponse.Code = context.StringValue("DescribeJob.Code");
			describeJobResponse.Message = context.StringValue("DescribeJob.Message");
			describeJobResponse.HttpStatusCode = context.IntegerValue("DescribeJob.HttpStatusCode");

			DescribeJobResponse.DescribeJob_Job job = new DescribeJobResponse.DescribeJob_Job();
			job.JobId = context.StringValue("DescribeJob.Job.JobId");
			job.JobGroupId = context.StringValue("DescribeJob.Job.JobGroupId");
			job.ScenarioId = context.StringValue("DescribeJob.Job.ScenarioId");
			job.StrategyId = context.StringValue("DescribeJob.Job.StrategyId");
			job.Priority = context.IntegerValue("DescribeJob.Job.Priority");
			job.SystemPriority = context.IntegerValue("DescribeJob.Job.SystemPriority");
			job.Status = context.StringValue("DescribeJob.Job.Status");
			job.ReferenceId = context.StringValue("DescribeJob.Job.ReferenceId");
			job.FailureReason = context.StringValue("DescribeJob.Job.FailureReason");

			List<string> job_callingNumbers = new List<string>();
			for (int i = 0; i < context.Length("DescribeJob.Job.CallingNumbers.Length"); i++) {
				job_callingNumbers.Add(context.StringValue("DescribeJob.Job.CallingNumbers["+ i +"]"));
			}
			job.CallingNumbers = job_callingNumbers;

			List<DescribeJobResponse.DescribeJob_Job.DescribeJob_Contact> job_contacts = new List<DescribeJobResponse.DescribeJob_Job.DescribeJob_Contact>();
			for (int i = 0; i < context.Length("DescribeJob.Job.Contacts.Length"); i++) {
				DescribeJobResponse.DescribeJob_Job.DescribeJob_Contact contact = new DescribeJobResponse.DescribeJob_Job.DescribeJob_Contact();
				contact.ContactId = context.StringValue("DescribeJob.Job.Contacts["+ i +"].ContactId");
				contact.ContactName = context.StringValue("DescribeJob.Job.Contacts["+ i +"].ContactName");
				contact.Honorific = context.StringValue("DescribeJob.Job.Contacts["+ i +"].Honorific");
				contact.Role = context.StringValue("DescribeJob.Job.Contacts["+ i +"].Role");
				contact.PhoneNumber = context.StringValue("DescribeJob.Job.Contacts["+ i +"].PhoneNumber");
				contact.State = context.StringValue("DescribeJob.Job.Contacts["+ i +"].State");
				contact.ReferenceId = context.StringValue("DescribeJob.Job.Contacts["+ i +"].ReferenceId");
				contact.JobId = context.StringValue("DescribeJob.Job.Contacts["+ i +"].JobId");

				job_contacts.Add(contact);
			}
			job.Contacts = job_contacts;

			List<DescribeJobResponse.DescribeJob_Job.DescribeJob_KeyValuePair> job_extras = new List<DescribeJobResponse.DescribeJob_Job.DescribeJob_KeyValuePair>();
			for (int i = 0; i < context.Length("DescribeJob.Job.Extras.Length"); i++) {
				DescribeJobResponse.DescribeJob_Job.DescribeJob_KeyValuePair keyValuePair = new DescribeJobResponse.DescribeJob_Job.DescribeJob_KeyValuePair();
				keyValuePair.Key = context.StringValue("DescribeJob.Job.Extras["+ i +"].Key");
				keyValuePair._Value = context.StringValue("DescribeJob.Job.Extras["+ i +"].Value");

				job_extras.Add(keyValuePair);
			}
			job.Extras = job_extras;

			List<DescribeJobResponse.DescribeJob_Job.DescribeJob_Task> job_tasks = new List<DescribeJobResponse.DescribeJob_Job.DescribeJob_Task>();
			for (int i = 0; i < context.Length("DescribeJob.Job.Tasks.Length"); i++) {
				DescribeJobResponse.DescribeJob_Job.DescribeJob_Task task = new DescribeJobResponse.DescribeJob_Job.DescribeJob_Task();
				task.TaskId = context.StringValue("DescribeJob.Job.Tasks["+ i +"].TaskId");
				task.JobId = context.StringValue("DescribeJob.Job.Tasks["+ i +"].JobId");
				task.ScenarioId = context.StringValue("DescribeJob.Job.Tasks["+ i +"].ScenarioId");
				task.ChatbotId = context.StringValue("DescribeJob.Job.Tasks["+ i +"].ChatbotId");
				task.PlanedTime = context.LongValue("DescribeJob.Job.Tasks["+ i +"].PlanedTime");
				task.ActualTime = context.LongValue("DescribeJob.Job.Tasks["+ i +"].ActualTime");
				task.CallingNumber = context.StringValue("DescribeJob.Job.Tasks["+ i +"].CallingNumber");
				task.CalledNumber = context.StringValue("DescribeJob.Job.Tasks["+ i +"].CalledNumber");
				task.CallId = context.StringValue("DescribeJob.Job.Tasks["+ i +"].CallId");
				task.Status = context.StringValue("DescribeJob.Job.Tasks["+ i +"].Status");
				task.Brief = context.StringValue("DescribeJob.Job.Tasks["+ i +"].Brief");
				task.Duration = context.IntegerValue("DescribeJob.Job.Tasks["+ i +"].Duration");

				DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_Contact2 contact2 = new DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_Contact2();
				contact2.ContactId = context.StringValue("DescribeJob.Job.Tasks["+ i +"].Contact.ContactId");
				contact2.ContactName = context.StringValue("DescribeJob.Job.Tasks["+ i +"].Contact.ContactName");
				contact2.Honorific = context.StringValue("DescribeJob.Job.Tasks["+ i +"].Contact.Honorific");
				contact2.Role = context.StringValue("DescribeJob.Job.Tasks["+ i +"].Contact.Role");
				contact2.PhoneNumber = context.StringValue("DescribeJob.Job.Tasks["+ i +"].Contact.PhoneNumber");
				contact2.State = context.StringValue("DescribeJob.Job.Tasks["+ i +"].Contact.State");
				contact2.ReferenceId = context.StringValue("DescribeJob.Job.Tasks["+ i +"].Contact.ReferenceId");
				contact2.JobId = context.StringValue("DescribeJob.Job.Tasks["+ i +"].Contact.JobId");
				task.Contact2 = contact2;

				List<DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_ConversationDetail> task_conversation = new List<DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_ConversationDetail>();
				for (int j = 0; j < context.Length("DescribeJob.Job.Tasks["+ i +"].Conversation.Length"); j++) {
					DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_ConversationDetail conversationDetail = new DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_ConversationDetail();
					conversationDetail.Timestamp = context.LongValue("DescribeJob.Job.Tasks["+ i +"].Conversation["+ j +"].Timestamp");
					conversationDetail.Speaker = context.StringValue("DescribeJob.Job.Tasks["+ i +"].Conversation["+ j +"].Speaker");
					conversationDetail.Script = context.StringValue("DescribeJob.Job.Tasks["+ i +"].Conversation["+ j +"].Script");

					List<DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_ConversationDetail.DescribeJob_SummaryItem> conversationDetail_summary1 = new List<DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_ConversationDetail.DescribeJob_SummaryItem>();
					for (int k = 0; k < context.Length("DescribeJob.Job.Tasks["+ i +"].Conversation["+ j +"].Summary.Length"); k++) {
						DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_ConversationDetail.DescribeJob_SummaryItem summaryItem = new DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_ConversationDetail.DescribeJob_SummaryItem();
						summaryItem.Category = context.StringValue("DescribeJob.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].Category");
						summaryItem.SummaryName = context.StringValue("DescribeJob.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].SummaryName");
						summaryItem.Content = context.StringValue("DescribeJob.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].Content");

						conversationDetail_summary1.Add(summaryItem);
					}
					conversationDetail.Summary1 = conversationDetail_summary1;

					task_conversation.Add(conversationDetail);
				}
				task.Conversation = task_conversation;

				job_tasks.Add(task);
			}
			job.Tasks = job_tasks;

			List<DescribeJobResponse.DescribeJob_Job.DescribeJob_SummaryItem3> job_summary = new List<DescribeJobResponse.DescribeJob_Job.DescribeJob_SummaryItem3>();
			for (int i = 0; i < context.Length("DescribeJob.Job.Summary.Length"); i++) {
				DescribeJobResponse.DescribeJob_Job.DescribeJob_SummaryItem3 summaryItem3 = new DescribeJobResponse.DescribeJob_Job.DescribeJob_SummaryItem3();
				summaryItem3.Category = context.StringValue("DescribeJob.Job.Summary["+ i +"].Category");
				summaryItem3.SummaryName = context.StringValue("DescribeJob.Job.Summary["+ i +"].SummaryName");
				summaryItem3.Content = context.StringValue("DescribeJob.Job.Summary["+ i +"].Content");

				job_summary.Add(summaryItem3);
			}
			job.Summary = job_summary;
			describeJobResponse.Job = job;
        
			return describeJobResponse;
        }
    }
}
