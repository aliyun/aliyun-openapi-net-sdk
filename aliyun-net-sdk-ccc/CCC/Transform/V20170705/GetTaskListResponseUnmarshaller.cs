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
        public static GetTaskListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTaskListResponse getTaskListResponse = new GetTaskListResponse();

			getTaskListResponse.HttpResponse = _ctx.HttpResponse;
			getTaskListResponse.RequestId = _ctx.StringValue("GetTaskList.RequestId");
			getTaskListResponse.Success = _ctx.BooleanValue("GetTaskList.Success");
			getTaskListResponse.Code = _ctx.StringValue("GetTaskList.Code");
			getTaskListResponse.Message = _ctx.StringValue("GetTaskList.Message");
			getTaskListResponse.HttpStatusCode = _ctx.IntegerValue("GetTaskList.HttpStatusCode");

			List<GetTaskListResponse.GetTaskList_Task> getTaskListResponse_tasks = new List<GetTaskListResponse.GetTaskList_Task>();
			for (int i = 0; i < _ctx.Length("GetTaskList.Tasks.Length"); i++) {
				GetTaskListResponse.GetTaskList_Task task = new GetTaskListResponse.GetTaskList_Task();
				task.TaskId = _ctx.StringValue("GetTaskList.Tasks["+ i +"].TaskId");
				task.JobId = _ctx.StringValue("GetTaskList.Tasks["+ i +"].JobId");
				task.ScenarioId = _ctx.StringValue("GetTaskList.Tasks["+ i +"].ScenarioId");
				task.ChatbotId = _ctx.StringValue("GetTaskList.Tasks["+ i +"].ChatbotId");
				task.PlanedTime = _ctx.LongValue("GetTaskList.Tasks["+ i +"].PlanedTime");
				task.ActualTime = _ctx.LongValue("GetTaskList.Tasks["+ i +"].ActualTime");
				task.CallingNumber = _ctx.StringValue("GetTaskList.Tasks["+ i +"].CallingNumber");
				task.CalledNumber = _ctx.StringValue("GetTaskList.Tasks["+ i +"].CalledNumber");
				task.CallId = _ctx.StringValue("GetTaskList.Tasks["+ i +"].CallId");
				task.Status = _ctx.StringValue("GetTaskList.Tasks["+ i +"].Status");
				task.Brief = _ctx.StringValue("GetTaskList.Tasks["+ i +"].Brief");
				task.Duration = _ctx.IntegerValue("GetTaskList.Tasks["+ i +"].Duration");

				GetTaskListResponse.GetTaskList_Task.GetTaskList_Contact contact = new GetTaskListResponse.GetTaskList_Task.GetTaskList_Contact();
				contact.ContactId = _ctx.StringValue("GetTaskList.Tasks["+ i +"].Contact.ContactId");
				contact.ContactName = _ctx.StringValue("GetTaskList.Tasks["+ i +"].Contact.ContactName");
				contact.Honorific = _ctx.StringValue("GetTaskList.Tasks["+ i +"].Contact.Honorific");
				contact.Role = _ctx.StringValue("GetTaskList.Tasks["+ i +"].Contact.Role");
				contact.PhoneNumber = _ctx.StringValue("GetTaskList.Tasks["+ i +"].Contact.PhoneNumber");
				contact.State = _ctx.StringValue("GetTaskList.Tasks["+ i +"].Contact.State");
				contact.ReferenceId = _ctx.StringValue("GetTaskList.Tasks["+ i +"].Contact.ReferenceId");
				contact.JobId = _ctx.StringValue("GetTaskList.Tasks["+ i +"].Contact.JobId");
				task.Contact = contact;

				List<GetTaskListResponse.GetTaskList_Task.GetTaskList_ConversationDetail> task_conversation = new List<GetTaskListResponse.GetTaskList_Task.GetTaskList_ConversationDetail>();
				for (int j = 0; j < _ctx.Length("GetTaskList.Tasks["+ i +"].Conversation.Length"); j++) {
					GetTaskListResponse.GetTaskList_Task.GetTaskList_ConversationDetail conversationDetail = new GetTaskListResponse.GetTaskList_Task.GetTaskList_ConversationDetail();
					conversationDetail.Timestamp = _ctx.LongValue("GetTaskList.Tasks["+ i +"].Conversation["+ j +"].Timestamp");
					conversationDetail.Speaker = _ctx.StringValue("GetTaskList.Tasks["+ i +"].Conversation["+ j +"].Speaker");
					conversationDetail.Script = _ctx.StringValue("GetTaskList.Tasks["+ i +"].Conversation["+ j +"].Script");

					List<GetTaskListResponse.GetTaskList_Task.GetTaskList_ConversationDetail.GetTaskList_SummaryItem> conversationDetail_summary = new List<GetTaskListResponse.GetTaskList_Task.GetTaskList_ConversationDetail.GetTaskList_SummaryItem>();
					for (int k = 0; k < _ctx.Length("GetTaskList.Tasks["+ i +"].Conversation["+ j +"].Summary.Length"); k++) {
						GetTaskListResponse.GetTaskList_Task.GetTaskList_ConversationDetail.GetTaskList_SummaryItem summaryItem = new GetTaskListResponse.GetTaskList_Task.GetTaskList_ConversationDetail.GetTaskList_SummaryItem();
						summaryItem.Category = _ctx.StringValue("GetTaskList.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].Category");
						summaryItem.SummaryName = _ctx.StringValue("GetTaskList.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].SummaryName");
						summaryItem.Content = _ctx.StringValue("GetTaskList.Tasks["+ i +"].Conversation["+ j +"].Summary["+ k +"].Content");

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
