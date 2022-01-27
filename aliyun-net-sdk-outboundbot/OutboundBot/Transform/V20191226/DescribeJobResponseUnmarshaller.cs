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
        public static DescribeJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeJobResponse describeJobResponse = new DescribeJobResponse();

			describeJobResponse.HttpResponse = _ctx.HttpResponse;
			describeJobResponse.HttpStatusCode = _ctx.IntegerValue("DescribeJob.HttpStatusCode");
			describeJobResponse.Code = _ctx.StringValue("DescribeJob.Code");
			describeJobResponse.Message = _ctx.StringValue("DescribeJob.Message");
			describeJobResponse.RequestId = _ctx.StringValue("DescribeJob.RequestId");
			describeJobResponse.Success = _ctx.BooleanValue("DescribeJob.Success");

			DescribeJobResponse.DescribeJob_Job job = new DescribeJobResponse.DescribeJob_Job();
			job.Status = _ctx.StringValue("DescribeJob.Job.Status");
			job.ActualTime = _ctx.LongValue("DescribeJob.Job.ActualTime");
			job.Priority = _ctx.IntegerValue("DescribeJob.Job.Priority");
			job.DsReport = _ctx.StringValue("DescribeJob.Job.DsReport");
			job.NextExecutionTime = _ctx.LongValue("DescribeJob.Job.NextExecutionTime");
			job.FailureReason = _ctx.StringValue("DescribeJob.Job.FailureReason");
			job.SystemPriority = _ctx.IntegerValue("DescribeJob.Job.SystemPriority");
			job.InstanceId = _ctx.StringValue("DescribeJob.Job.InstanceId");
			job.CalledNumber = _ctx.StringValue("DescribeJob.Job.CalledNumber");
			job.ReferenceId = _ctx.StringValue("DescribeJob.Job.ReferenceId");
			job.JobGroupId = _ctx.StringValue("DescribeJob.Job.JobGroupId");
			job.ScenarioId = _ctx.StringValue("DescribeJob.Job.ScenarioId");
			job.StrategyId = _ctx.StringValue("DescribeJob.Job.StrategyId");
			job.EndReason = _ctx.IntegerValue("DescribeJob.Job.EndReason");
			job.JobId = _ctx.StringValue("DescribeJob.Job.JobId");

			List<string> job_callingNumbers = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeJob.Job.CallingNumbers.Length"); i++) {
				job_callingNumbers.Add(_ctx.StringValue("DescribeJob.Job.CallingNumbers["+ i +"]"));
			}
			job.CallingNumbers = job_callingNumbers;

			List<DescribeJobResponse.DescribeJob_Job.DescribeJob_Contact> job_contacts = new List<DescribeJobResponse.DescribeJob_Job.DescribeJob_Contact>();
			for (int i = 0; i < _ctx.Length("DescribeJob.Job.Contacts.Length"); i++) {
				DescribeJobResponse.DescribeJob_Job.DescribeJob_Contact contact = new DescribeJobResponse.DescribeJob_Job.DescribeJob_Contact();
				contact.PhoneNumber = _ctx.StringValue("DescribeJob.Job.Contacts["+ i +"].PhoneNumber");
				contact.State = _ctx.StringValue("DescribeJob.Job.Contacts["+ i +"].State");
				contact.ContactId = _ctx.StringValue("DescribeJob.Job.Contacts["+ i +"].ContactId");
				contact.Honorific = _ctx.StringValue("DescribeJob.Job.Contacts["+ i +"].Honorific");
				contact.JobId = _ctx.StringValue("DescribeJob.Job.Contacts["+ i +"].JobId");
				contact.ContactName = _ctx.StringValue("DescribeJob.Job.Contacts["+ i +"].ContactName");
				contact.Role = _ctx.StringValue("DescribeJob.Job.Contacts["+ i +"].Role");
				contact.ReferenceId = _ctx.StringValue("DescribeJob.Job.Contacts["+ i +"].ReferenceId");

				job_contacts.Add(contact);
			}
			job.Contacts = job_contacts;

			List<DescribeJobResponse.DescribeJob_Job.DescribeJob_KeyValuePair> job_extras = new List<DescribeJobResponse.DescribeJob_Job.DescribeJob_KeyValuePair>();
			for (int i = 0; i < _ctx.Length("DescribeJob.Job.Extras.Length"); i++) {
				DescribeJobResponse.DescribeJob_Job.DescribeJob_KeyValuePair keyValuePair = new DescribeJobResponse.DescribeJob_Job.DescribeJob_KeyValuePair();
				keyValuePair.Key = _ctx.StringValue("DescribeJob.Job.Extras["+ i +"].Key");
				keyValuePair._Value = _ctx.StringValue("DescribeJob.Job.Extras["+ i +"].Value");

				job_extras.Add(keyValuePair);
			}
			job.Extras = job_extras;

			List<DescribeJobResponse.DescribeJob_Job.DescribeJob_SummaryItem> job_summary = new List<DescribeJobResponse.DescribeJob_Job.DescribeJob_SummaryItem>();
			for (int i = 0; i < _ctx.Length("DescribeJob.Job.Summary.Length"); i++) {
				DescribeJobResponse.DescribeJob_Job.DescribeJob_SummaryItem summaryItem = new DescribeJobResponse.DescribeJob_Job.DescribeJob_SummaryItem();
				summaryItem.SummaryName = _ctx.StringValue("DescribeJob.Job.Summary["+ i +"].SummaryName");
				summaryItem.Category = _ctx.StringValue("DescribeJob.Job.Summary["+ i +"].Category");
				summaryItem.Content = _ctx.StringValue("DescribeJob.Job.Summary["+ i +"].Content");

				job_summary.Add(summaryItem);
			}
			job.Summary = job_summary;

			List<DescribeJobResponse.DescribeJob_Job.DescribeJob_Task> job_tasks = new List<DescribeJobResponse.DescribeJob_Job.DescribeJob_Task>();
			for (int i = 0; i < _ctx.Length("DescribeJob.Job.Tasks.Length"); i++) {
				DescribeJobResponse.DescribeJob_Job.DescribeJob_Task task = new DescribeJobResponse.DescribeJob_Job.DescribeJob_Task();
				task.Status = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Status");
				task.PlanedTime = _ctx.LongValue("DescribeJob.Job.Tasks["+ i +"].PlanedTime");
				task.ChatbotId = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].ChatbotId");
				task.ActualTime = _ctx.LongValue("DescribeJob.Job.Tasks["+ i +"].ActualTime");
				task.CalledNumber = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].CalledNumber");
				task.EndTime = _ctx.LongValue("DescribeJob.Job.Tasks["+ i +"].EndTime");
				task.ScenarioId = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].ScenarioId");
				task.EndReason = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].EndReason");
				task.JobId = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].JobId");
				task.CallId = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].CallId");
				task.CallingNumber = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].CallingNumber");
				task.Brief = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Brief");
				task.Duration = _ctx.IntegerValue("DescribeJob.Job.Tasks["+ i +"].Duration");
				task.TaskId = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].TaskId");
				task.HangUpDirection = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].HangUpDirection");
				task.RingingDuration = _ctx.LongValue("DescribeJob.Job.Tasks["+ i +"].RingingDuration");

				DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_Contact3 contact3 = new DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_Contact3();
				contact3.PhoneNumber = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Contact.PhoneNumber");
				contact3.State = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Contact.State");
				contact3.ContactId = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Contact.ContactId");
				contact3.Honorific = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Contact.Honorific");
				contact3.JobId = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Contact.JobId");
				contact3.ContactName = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Contact.ContactName");
				contact3.Role = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Contact.Role");
				contact3.ReferenceId = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Contact.ReferenceId");
				task.Contact3 = contact3;

				List<DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_ConversationDetail> task_conversation = new List<DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_ConversationDetail>();
				for (int j = 0; j < _ctx.Length("DescribeJob.Job.Tasks["+ i +"].Conversation.Length"); j++) {
					DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_ConversationDetail conversationDetail = new DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_ConversationDetail();
					conversationDetail.ActionParams = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Conversation["+ j +"].ActionParams");
					conversationDetail.Action = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Conversation["+ j +"].Action");
					conversationDetail.Timestamp = _ctx.LongValue("DescribeJob.Job.Tasks["+ i +"].Conversation["+ j +"].Timestamp");
					conversationDetail.Speaker = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Conversation["+ j +"].Speaker");
					conversationDetail.Script = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Conversation["+ j +"].Script");

					List<DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_ConversationDetail.DescribeJob_SummaryItem2> conversationDetail_summary1 = new List<DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_ConversationDetail.DescribeJob_SummaryItem2>();
					for (int k = 0; k < _ctx.Length("DescribeJob.Job.Tasks["+ i +"].Conversation["+ j +"].Summary.Length"); k++) {
						DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_ConversationDetail.DescribeJob_SummaryItem2 summaryItem2 = new DescribeJobResponse.DescribeJob_Job.DescribeJob_Task.DescribeJob_ConversationDetail.DescribeJob_SummaryItem2();
						summaryItem2.SummaryName = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].SummaryName");
						summaryItem2.Category = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].Category");
						summaryItem2.Content = _ctx.StringValue("DescribeJob.Job.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].Content");

						conversationDetail_summary1.Add(summaryItem2);
					}
					conversationDetail.Summary1 = conversationDetail_summary1;

					task_conversation.Add(conversationDetail);
				}
				task.Conversation = task_conversation;

				job_tasks.Add(task);
			}
			job.Tasks = job_tasks;
			describeJobResponse.Job = job;
        
			return describeJobResponse;
        }
    }
}
