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
    public class ListPredictiveJobStatusResponseUnmarshaller
    {
        public static ListPredictiveJobStatusResponse Unmarshall(UnmarshallerContext context)
        {
			ListPredictiveJobStatusResponse listPredictiveJobStatusResponse = new ListPredictiveJobStatusResponse();

			listPredictiveJobStatusResponse.HttpResponse = context.HttpResponse;
			listPredictiveJobStatusResponse.RequestId = context.StringValue("ListPredictiveJobStatus.RequestId");
			listPredictiveJobStatusResponse.Success = context.BooleanValue("ListPredictiveJobStatus.Success");
			listPredictiveJobStatusResponse.Code = context.StringValue("ListPredictiveJobStatus.Code");
			listPredictiveJobStatusResponse.Message = context.StringValue("ListPredictiveJobStatus.Message");
			listPredictiveJobStatusResponse.HttpStatusCode = context.IntegerValue("ListPredictiveJobStatus.HttpStatusCode");

			ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs jobs = new ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs();
			jobs.TotalCount = context.IntegerValue("ListPredictiveJobStatus.Jobs.TotalCount");
			jobs.PageNumber = context.IntegerValue("ListPredictiveJobStatus.Jobs.PageNumber");
			jobs.PageSize = context.IntegerValue("ListPredictiveJobStatus.Jobs.PageSize");

			List<ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job> jobs_list = new List<ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job>();
			for (int i = 0; i < context.Length("ListPredictiveJobStatus.Jobs.List.Length"); i++) {
				ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job job = new ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job();
				job.JobId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].JobId");
				job.JobGroupId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].JobGroupId");
				job.ScenarioId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].ScenarioId");
				job.StrategyId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].StrategyId");
				job.Priority = context.IntegerValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Priority");
				job.SystemPriority = context.IntegerValue("ListPredictiveJobStatus.Jobs.List["+ i +"].SystemPriority");
				job.Status = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Status");
				job.ReferenceId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].ReferenceId");
				job.FailureReason = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].FailureReason");

				List<string> job_callingNumbers = new List<string>();
				for (int j = 0; j < context.Length("ListPredictiveJobStatus.Jobs.List["+ i +"].CallingNumbers.Length"); j++) {
					job_callingNumbers.Add(context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].CallingNumbers["+ j +"]"));
				}
				job.CallingNumbers = job_callingNumbers;

				List<ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_Contact> job_contacts = new List<ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_Contact>();
				for (int j = 0; j < context.Length("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts.Length"); j++) {
					ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_Contact contact = new ListPredictiveJobStatusResponse.ListPredictiveJobStatus_Jobs.ListPredictiveJobStatus_Job.ListPredictiveJobStatus_Contact();
					contact.ContactId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].ContactId");
					contact.ContactName = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].ContactName");
					contact.Honorific = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].Honorific");
					contact.Role = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].Role");
					contact.PhoneNumber = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].PhoneNumber");
					contact.State = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].State");
					contact.ReferenceId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].ReferenceId");
					contact.JobId = context.StringValue("ListPredictiveJobStatus.Jobs.List["+ i +"].Contacts["+ j +"].JobId");

					job_contacts.Add(contact);
				}
				job.Contacts = job_contacts;

				jobs_list.Add(job);
			}
			jobs.List = jobs_list;
			listPredictiveJobStatusResponse.Jobs = jobs;
        
			return listPredictiveJobStatusResponse;
        }
    }
}
