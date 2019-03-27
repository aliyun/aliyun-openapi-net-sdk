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
    public class GetJobListResponseUnmarshaller
    {
        public static GetJobListResponse Unmarshall(UnmarshallerContext context)
        {
			GetJobListResponse getJobListResponse = new GetJobListResponse();

			getJobListResponse.HttpResponse = context.HttpResponse;
			getJobListResponse.RequestId = context.StringValue("GetJobList.RequestId");
			getJobListResponse.Success = context.BooleanValue("GetJobList.Success");
			getJobListResponse.Code = context.StringValue("GetJobList.Code");
			getJobListResponse.Message = context.StringValue("GetJobList.Message");
			getJobListResponse.HttpStatusCode = context.IntegerValue("GetJobList.HttpStatusCode");

			GetJobListResponse.GetJobList_Jobs jobs = new GetJobListResponse.GetJobList_Jobs();
			jobs.TotalCount = context.IntegerValue("GetJobList.Jobs.TotalCount");
			jobs.PageNumber = context.IntegerValue("GetJobList.Jobs.PageNumber");
			jobs.PageSize = context.IntegerValue("GetJobList.Jobs.PageSize");

			List<GetJobListResponse.GetJobList_Jobs.GetJobList_Job> jobs_list = new List<GetJobListResponse.GetJobList_Jobs.GetJobList_Job>();
			for (int i = 0; i < context.Length("GetJobList.Jobs.List.Length"); i++) {
				GetJobListResponse.GetJobList_Jobs.GetJobList_Job job = new GetJobListResponse.GetJobList_Jobs.GetJobList_Job();
				job.JobId = context.StringValue("GetJobList.Jobs.List["+ i +"].JobId");
				job.GroupId = context.StringValue("GetJobList.Jobs.List["+ i +"].GroupId");
				job.ScenarioId = context.StringValue("GetJobList.Jobs.List["+ i +"].ScenarioId");
				job.StrategyId = context.StringValue("GetJobList.Jobs.List["+ i +"].StrategyId");
				job.Priority = context.IntegerValue("GetJobList.Jobs.List["+ i +"].Priority");
				job.SystemPriority = context.IntegerValue("GetJobList.Jobs.List["+ i +"].SystemPriority");
				job.Status = context.StringValue("GetJobList.Jobs.List["+ i +"].Status");
				job.ReferenceId = context.StringValue("GetJobList.Jobs.List["+ i +"].ReferenceId");
				job.FailureReason = context.StringValue("GetJobList.Jobs.List["+ i +"].FailureReason");

				List<string> job_callingNumbers = new List<string>();
				for (int j = 0; j < context.Length("GetJobList.Jobs.List["+ i +"].CallingNumbers.Length"); j++) {
					job_callingNumbers.Add(context.StringValue("GetJobList.Jobs.List["+ i +"].CallingNumbers["+ j +"]"));
				}
				job.CallingNumbers = job_callingNumbers;

				List<GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_Contact> job_contacts = new List<GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_Contact>();
				for (int j = 0; j < context.Length("GetJobList.Jobs.List["+ i +"].Contacts.Length"); j++) {
					GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_Contact contact = new GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_Contact();
					contact.ContactId = context.StringValue("GetJobList.Jobs.List["+ i +"].Contacts["+ j +"].ContactId");
					contact.ContactName = context.StringValue("GetJobList.Jobs.List["+ i +"].Contacts["+ j +"].ContactName");
					contact.Honorific = context.StringValue("GetJobList.Jobs.List["+ i +"].Contacts["+ j +"].Honorific");
					contact.Role = context.StringValue("GetJobList.Jobs.List["+ i +"].Contacts["+ j +"].Role");
					contact.PhoneNumber = context.StringValue("GetJobList.Jobs.List["+ i +"].Contacts["+ j +"].PhoneNumber");
					contact.State = context.StringValue("GetJobList.Jobs.List["+ i +"].Contacts["+ j +"].State");
					contact.ReferenceId = context.StringValue("GetJobList.Jobs.List["+ i +"].Contacts["+ j +"].ReferenceId");
					contact.JobId = context.StringValue("GetJobList.Jobs.List["+ i +"].Contacts["+ j +"].JobId");

					job_contacts.Add(contact);
				}
				job.Contacts = job_contacts;

				List<GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_KeyValuePair> job_extras = new List<GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_KeyValuePair>();
				for (int j = 0; j < context.Length("GetJobList.Jobs.List["+ i +"].Extras.Length"); j++) {
					GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_KeyValuePair keyValuePair = new GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_KeyValuePair();
					keyValuePair.Key = context.StringValue("GetJobList.Jobs.List["+ i +"].Extras["+ j +"].Key");
					keyValuePair._Value = context.StringValue("GetJobList.Jobs.List["+ i +"].Extras["+ j +"].Value");

					job_extras.Add(keyValuePair);
				}
				job.Extras = job_extras;

				List<GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_SummaryItem> job_summary = new List<GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_SummaryItem>();
				for (int j = 0; j < context.Length("GetJobList.Jobs.List["+ i +"].Summary.Length"); j++) {
					GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_SummaryItem summaryItem = new GetJobListResponse.GetJobList_Jobs.GetJobList_Job.GetJobList_SummaryItem();
					summaryItem.SummaryId = context.StringValue("GetJobList.Jobs.List["+ i +"].Summary["+ j +"].SummaryId");
					summaryItem.GroupId = context.StringValue("GetJobList.Jobs.List["+ i +"].Summary["+ j +"].GroupId");
					summaryItem.JobId = context.StringValue("GetJobList.Jobs.List["+ i +"].Summary["+ j +"].JobId");
					summaryItem.TaskId = context.StringValue("GetJobList.Jobs.List["+ i +"].Summary["+ j +"].TaskId");
					summaryItem.ConversationDetailId = context.StringValue("GetJobList.Jobs.List["+ i +"].Summary["+ j +"].ConversationDetailId");
					summaryItem.Category = context.StringValue("GetJobList.Jobs.List["+ i +"].Summary["+ j +"].Category");
					summaryItem.SummaryName = context.StringValue("GetJobList.Jobs.List["+ i +"].Summary["+ j +"].SummaryName");
					summaryItem.Content = context.StringValue("GetJobList.Jobs.List["+ i +"].Summary["+ j +"].Content");

					job_summary.Add(summaryItem);
				}
				job.Summary = job_summary;

				jobs_list.Add(job);
			}
			jobs.List = jobs_list;
			getJobListResponse.Jobs = jobs;
        
			return getJobListResponse;
        }
    }
}
