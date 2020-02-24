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
    public class ListJobsByGroupResponseUnmarshaller
    {
        public static ListJobsByGroupResponse Unmarshall(UnmarshallerContext context)
        {
			ListJobsByGroupResponse listJobsByGroupResponse = new ListJobsByGroupResponse();

			listJobsByGroupResponse.HttpResponse = context.HttpResponse;
			listJobsByGroupResponse.RequestId = context.StringValue("ListJobsByGroup.RequestId");
			listJobsByGroupResponse.Success = context.BooleanValue("ListJobsByGroup.Success");
			listJobsByGroupResponse.Code = context.StringValue("ListJobsByGroup.Code");
			listJobsByGroupResponse.Message = context.StringValue("ListJobsByGroup.Message");
			listJobsByGroupResponse.HttpStatusCode = context.IntegerValue("ListJobsByGroup.HttpStatusCode");

			ListJobsByGroupResponse.ListJobsByGroup_Jobs jobs = new ListJobsByGroupResponse.ListJobsByGroup_Jobs();
			jobs.TotalCount = context.IntegerValue("ListJobsByGroup.Jobs.TotalCount");
			jobs.PageNumber = context.IntegerValue("ListJobsByGroup.Jobs.PageNumber");
			jobs.PageSize = context.IntegerValue("ListJobsByGroup.Jobs.PageSize");

			List<ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job> jobs_list = new List<ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job>();
			for (int i = 0; i < context.Length("ListJobsByGroup.Jobs.List.Length"); i++) {
				ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job job = new ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job();
				job.JobId = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].JobId");
				job.JobGroupId = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].JobGroupId");
				job.ScenarioId = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].ScenarioId");
				job.StrategyId = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].StrategyId");
				job.Priority = context.IntegerValue("ListJobsByGroup.Jobs.List["+ i +"].Priority");
				job.SystemPriority = context.IntegerValue("ListJobsByGroup.Jobs.List["+ i +"].SystemPriority");
				job.Status = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Status");
				job.ReferenceId = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].ReferenceId");
				job.FailureReason = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].FailureReason");

				List<string> job_callingNumbers = new List<string>();
				for (int j = 0; j < context.Length("ListJobsByGroup.Jobs.List["+ i +"].CallingNumbers.Length"); j++) {
					job_callingNumbers.Add(context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].CallingNumbers["+ j +"]"));
				}
				job.CallingNumbers = job_callingNumbers;

				List<ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_Contact> job_contacts = new List<ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_Contact>();
				for (int j = 0; j < context.Length("ListJobsByGroup.Jobs.List["+ i +"].Contacts.Length"); j++) {
					ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_Contact contact = new ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_Contact();
					contact.ContactId = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Contacts["+ j +"].ContactId");
					contact.ContactName = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Contacts["+ j +"].ContactName");
					contact.Honorific = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Contacts["+ j +"].Honorific");
					contact.Role = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Contacts["+ j +"].Role");
					contact.PhoneNumber = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Contacts["+ j +"].PhoneNumber");
					contact.State = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Contacts["+ j +"].State");
					contact.ReferenceId = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Contacts["+ j +"].ReferenceId");
					contact.JobId = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Contacts["+ j +"].JobId");

					job_contacts.Add(contact);
				}
				job.Contacts = job_contacts;

				List<ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_KeyValuePair> job_extras = new List<ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_KeyValuePair>();
				for (int j = 0; j < context.Length("ListJobsByGroup.Jobs.List["+ i +"].Extras.Length"); j++) {
					ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_KeyValuePair keyValuePair = new ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_KeyValuePair();
					keyValuePair.Key = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Extras["+ j +"].Key");
					keyValuePair._Value = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Extras["+ j +"].Value");

					job_extras.Add(keyValuePair);
				}
				job.Extras = job_extras;

				List<ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_SummaryItem> job_summary = new List<ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_SummaryItem>();
				for (int j = 0; j < context.Length("ListJobsByGroup.Jobs.List["+ i +"].Summary.Length"); j++) {
					ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_SummaryItem summaryItem = new ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_SummaryItem();
					summaryItem.SummaryId = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Summary["+ j +"].SummaryId");
					summaryItem.JobGroupId = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Summary["+ j +"].JobGroupId");
					summaryItem.JobId = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Summary["+ j +"].JobId");
					summaryItem.TaskId = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Summary["+ j +"].TaskId");
					summaryItem.ConversationDetailId = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Summary["+ j +"].ConversationDetailId");
					summaryItem.Category = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Summary["+ j +"].Category");
					summaryItem.SummaryName = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Summary["+ j +"].SummaryName");
					summaryItem.Content = context.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Summary["+ j +"].Content");

					job_summary.Add(summaryItem);
				}
				job.Summary = job_summary;

				jobs_list.Add(job);
			}
			jobs.List = jobs_list;
			listJobsByGroupResponse.Jobs = jobs;
        
			return listJobsByGroupResponse;
        }
    }
}
