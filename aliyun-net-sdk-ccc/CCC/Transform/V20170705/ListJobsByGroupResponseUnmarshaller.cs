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
    public class ListJobsByGroupResponseUnmarshaller
    {
        public static ListJobsByGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJobsByGroupResponse listJobsByGroupResponse = new ListJobsByGroupResponse();

			listJobsByGroupResponse.HttpResponse = _ctx.HttpResponse;
			listJobsByGroupResponse.RequestId = _ctx.StringValue("ListJobsByGroup.RequestId");
			listJobsByGroupResponse.Success = _ctx.BooleanValue("ListJobsByGroup.Success");
			listJobsByGroupResponse.Code = _ctx.StringValue("ListJobsByGroup.Code");
			listJobsByGroupResponse.Message = _ctx.StringValue("ListJobsByGroup.Message");
			listJobsByGroupResponse.HttpStatusCode = _ctx.IntegerValue("ListJobsByGroup.HttpStatusCode");

			ListJobsByGroupResponse.ListJobsByGroup_Jobs jobs = new ListJobsByGroupResponse.ListJobsByGroup_Jobs();
			jobs.TotalCount = _ctx.IntegerValue("ListJobsByGroup.Jobs.TotalCount");
			jobs.PageNumber = _ctx.IntegerValue("ListJobsByGroup.Jobs.PageNumber");
			jobs.PageSize = _ctx.IntegerValue("ListJobsByGroup.Jobs.PageSize");

			List<ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job> jobs_list = new List<ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job>();
			for (int i = 0; i < _ctx.Length("ListJobsByGroup.Jobs.List.Length"); i++) {
				ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job job = new ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job();
				job.JobId = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].JobId");
				job.GroupId = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].GroupId");
				job.ScenarioId = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].ScenarioId");
				job.StrategyId = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].StrategyId");
				job.Priority = _ctx.IntegerValue("ListJobsByGroup.Jobs.List["+ i +"].Priority");
				job.SystemPriority = _ctx.IntegerValue("ListJobsByGroup.Jobs.List["+ i +"].SystemPriority");
				job.Status = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Status");
				job.ReferenceId = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].ReferenceId");
				job.FailureReason = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].FailureReason");

				List<string> job_callingNumbers = new List<string>();
				for (int j = 0; j < _ctx.Length("ListJobsByGroup.Jobs.List["+ i +"].CallingNumbers.Length"); j++) {
					job_callingNumbers.Add(_ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].CallingNumbers["+ j +"]"));
				}
				job.CallingNumbers = job_callingNumbers;

				List<ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_Contact> job_contacts = new List<ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_Contact>();
				for (int j = 0; j < _ctx.Length("ListJobsByGroup.Jobs.List["+ i +"].Contacts.Length"); j++) {
					ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_Contact contact = new ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_Contact();
					contact.ContactId = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Contacts["+ j +"].ContactId");
					contact.ContactName = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Contacts["+ j +"].ContactName");
					contact.Honorific = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Contacts["+ j +"].Honorific");
					contact.Role = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Contacts["+ j +"].Role");
					contact.PhoneNumber = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Contacts["+ j +"].PhoneNumber");
					contact.State = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Contacts["+ j +"].State");
					contact.ReferenceId = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Contacts["+ j +"].ReferenceId");
					contact.JobId = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Contacts["+ j +"].JobId");

					job_contacts.Add(contact);
				}
				job.Contacts = job_contacts;

				List<ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_KeyValuePair> job_extras = new List<ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_KeyValuePair>();
				for (int j = 0; j < _ctx.Length("ListJobsByGroup.Jobs.List["+ i +"].Extras.Length"); j++) {
					ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_KeyValuePair keyValuePair = new ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_KeyValuePair();
					keyValuePair.Key = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Extras["+ j +"].Key");
					keyValuePair._Value = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Extras["+ j +"].Value");

					job_extras.Add(keyValuePair);
				}
				job.Extras = job_extras;

				List<ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_SummaryItem> job_summary = new List<ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_SummaryItem>();
				for (int j = 0; j < _ctx.Length("ListJobsByGroup.Jobs.List["+ i +"].Summary.Length"); j++) {
					ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_SummaryItem summaryItem = new ListJobsByGroupResponse.ListJobsByGroup_Jobs.ListJobsByGroup_Job.ListJobsByGroup_SummaryItem();
					summaryItem.SummaryId = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Summary["+ j +"].SummaryId");
					summaryItem.GroupId = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Summary["+ j +"].GroupId");
					summaryItem.JobId = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Summary["+ j +"].JobId");
					summaryItem.TaskId = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Summary["+ j +"].TaskId");
					summaryItem.ConversationDetailId = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Summary["+ j +"].ConversationDetailId");
					summaryItem.Category = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Summary["+ j +"].Category");
					summaryItem.SummaryName = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Summary["+ j +"].SummaryName");
					summaryItem.Content = _ctx.StringValue("ListJobsByGroup.Jobs.List["+ i +"].Summary["+ j +"].Content");

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
