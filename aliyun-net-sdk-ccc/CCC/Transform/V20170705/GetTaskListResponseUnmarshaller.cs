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
    public class GetTaskListResponseUnmarshaller
    {
        public static GetTaskListResponse Unmarshall(UnmarshallerContext context)
        {
			GetTaskListResponse getTaskListResponse = new GetTaskListResponse();

			getTaskListResponse.HttpResponse = context.HttpResponse;
			getTaskListResponse.RequestId = context.StringValue("GetTaskList.RequestId");
			getTaskListResponse.Success = context.BooleanValue("GetTaskList.Success");
			getTaskListResponse.Code = context.StringValue("GetTaskList.Code");
			getTaskListResponse.Message = context.StringValue("GetTaskList.Message");
			getTaskListResponse.HttpStatusCode = context.IntegerValue("GetTaskList.HttpStatusCode");

			List<GetTaskListResponse.GetTaskList_Task> getTaskListResponse_tasks = new List<GetTaskListResponse.GetTaskList_Task>();
			for (int i = 0; i < context.Length("GetTaskList.Tasks.Length"); i++) {
				GetTaskListResponse.GetTaskList_Task task = new GetTaskListResponse.GetTaskList_Task();
				task.TaskId = context.StringValue("GetTaskList.Tasks["+ i +"].TaskId");
				task.JobId = context.StringValue("GetTaskList.Tasks["+ i +"].JobId");
				task.ScenarioId = context.StringValue("GetTaskList.Tasks["+ i +"].ScenarioId");
				task.ChatbotId = context.StringValue("GetTaskList.Tasks["+ i +"].ChatbotId");
				task.PlanedTime = context.LongValue("GetTaskList.Tasks["+ i +"].PlanedTime");
				task.ActualTime = context.LongValue("GetTaskList.Tasks["+ i +"].ActualTime");
				task.CallingNumber = context.StringValue("GetTaskList.Tasks["+ i +"].CallingNumber");
				task.CalledNumber = context.StringValue("GetTaskList.Tasks["+ i +"].CalledNumber");
				task.CallId = context.StringValue("GetTaskList.Tasks["+ i +"].CallId");
				task.Status = context.StringValue("GetTaskList.Tasks["+ i +"].Status");
				task.Brief = context.StringValue("GetTaskList.Tasks["+ i +"].Brief");
				task.Duration = context.IntegerValue("GetTaskList.Tasks["+ i +"].Duration");

				GetTaskListResponse.GetTaskList_Task.GetTaskList_Contact contact = new GetTaskListResponse.GetTaskList_Task.GetTaskList_Contact();
				contact.ContactId = context.StringValue("GetTaskList.Tasks["+ i +"].Contact.ContactId");
				contact.ContactName = context.StringValue("GetTaskList.Tasks["+ i +"].Contact.ContactName");
				contact.Honorific = context.StringValue("GetTaskList.Tasks["+ i +"].Contact.Honorific");
				contact.Role = context.StringValue("GetTaskList.Tasks["+ i +"].Contact.Role");
				contact.PhoneNumber = context.StringValue("GetTaskList.Tasks["+ i +"].Contact.PhoneNumber");
				contact.State = context.StringValue("GetTaskList.Tasks["+ i +"].Contact.State");
				contact.ReferenceId = context.StringValue("GetTaskList.Tasks["+ i +"].Contact.ReferenceId");
				contact.JobId = context.StringValue("GetTaskList.Tasks["+ i +"].Contact.JobId");
				task.Contact = contact;

				List<GetTaskListResponse.GetTaskList_Task.GetTaskList_ConversationDetail> task_conversation = new List<GetTaskListResponse.GetTaskList_Task.GetTaskList_ConversationDetail>();
				for (int j = 0; j < context.Length("GetTaskList.Tasks["+ i +"].Conversation.Length"); j++) {
					GetTaskListResponse.GetTaskList_Task.GetTaskList_ConversationDetail conversationDetail = new GetTaskListResponse.GetTaskList_Task.GetTaskList_ConversationDetail();
					conversationDetail.Timestamp = context.LongValue("GetTaskList.Tasks["+ i +"].Conversation["+ j +"].Timestamp");
					conversationDetail.Speaker = context.StringValue("GetTaskList.Tasks["+ i +"].Conversation["+ j +"].Speaker");
					conversationDetail.Script = context.StringValue("GetTaskList.Tasks["+ i +"].Conversation["+ j +"].Script");

					List<GetTaskListResponse.GetTaskList_Task.GetTaskList_ConversationDetail.GetTaskList_SummaryItem> conversationDetail_summary = new List<GetTaskListResponse.GetTaskList_Task.GetTaskList_ConversationDetail.GetTaskList_SummaryItem>();
					for (int k = 0; k < context.Length("GetTaskList.Tasks["+ i +"].Conversation["+ j +"].Summary.Length"); k++) {
						GetTaskListResponse.GetTaskList_Task.GetTaskList_ConversationDetail.GetTaskList_SummaryItem summaryItem = new GetTaskListResponse.GetTaskList_Task.GetTaskList_ConversationDetail.GetTaskList_SummaryItem();
						summaryItem.Category = context.StringValue("GetTaskList.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].Category");
						summaryItem.SummaryName = context.StringValue("GetTaskList.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].SummaryName");
						summaryItem.Content = context.StringValue("GetTaskList.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].Content");

						conversationDetail_summary.Add(summaryItem);
					}
					conversationDetail.Summary = conversationDetail_summary;

					task_conversation.Add(conversationDetail);
				}
				task.Conversation = task_conversation;

				getTaskListResponse_tasks.Add(task);
			}
			getTaskListResponse.Tasks = getTaskListResponse_tasks;
        
			return getTaskListResponse;
        }
    }
}
