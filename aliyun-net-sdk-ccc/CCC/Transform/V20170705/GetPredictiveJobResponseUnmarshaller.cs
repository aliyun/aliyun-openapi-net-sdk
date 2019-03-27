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
    public class GetPredictiveJobResponseUnmarshaller
    {
        public static GetPredictiveJobResponse Unmarshall(UnmarshallerContext context)
        {
			GetPredictiveJobResponse getPredictiveJobResponse = new GetPredictiveJobResponse();

			getPredictiveJobResponse.HttpResponse = context.HttpResponse;
			getPredictiveJobResponse.RequestId = context.StringValue("GetPredictiveJob.RequestId");
			getPredictiveJobResponse.Success = context.BooleanValue("GetPredictiveJob.Success");
			getPredictiveJobResponse.Code = context.StringValue("GetPredictiveJob.Code");
			getPredictiveJobResponse.Message = context.StringValue("GetPredictiveJob.Message");
			getPredictiveJobResponse.HttpStatusCode = context.IntegerValue("GetPredictiveJob.HttpStatusCode");

			GetPredictiveJobResponse.GetPredictiveJob_Job job = new GetPredictiveJobResponse.GetPredictiveJob_Job();
			job.JobId = context.StringValue("GetPredictiveJob.Job.JobId");
			job.JobGroupId = context.StringValue("GetPredictiveJob.Job.JobGroupId");
			job.ScenarioId = context.StringValue("GetPredictiveJob.Job.ScenarioId");
			job.StrategyId = context.StringValue("GetPredictiveJob.Job.StrategyId");
			job.Priority = context.IntegerValue("GetPredictiveJob.Job.Priority");
			job.SystemPriority = context.IntegerValue("GetPredictiveJob.Job.SystemPriority");
			job.Status = context.StringValue("GetPredictiveJob.Job.Status");
			job.ReferenceId = context.StringValue("GetPredictiveJob.Job.ReferenceId");
			job.FailureReason = context.StringValue("GetPredictiveJob.Job.FailureReason");

			List<string> job_callingNumbers = new List<string>();
			for (int i = 0; i < context.Length("GetPredictiveJob.Job.CallingNumbers.Length"); i++) {
				job_callingNumbers.Add(context.StringValue("GetPredictiveJob.Job.CallingNumbers["+ i +"]"));
			}
			job.CallingNumbers = job_callingNumbers;

			List<GetPredictiveJobResponse.GetPredictiveJob_Job.GetPredictiveJob_Contact> job_contacts = new List<GetPredictiveJobResponse.GetPredictiveJob_Job.GetPredictiveJob_Contact>();
			for (int i = 0; i < context.Length("GetPredictiveJob.Job.Contacts.Length"); i++) {
				GetPredictiveJobResponse.GetPredictiveJob_Job.GetPredictiveJob_Contact contact = new GetPredictiveJobResponse.GetPredictiveJob_Job.GetPredictiveJob_Contact();
				contact.ContactId = context.StringValue("GetPredictiveJob.Job.Contacts["+ i +"].ContactId");
				contact.ContactName = context.StringValue("GetPredictiveJob.Job.Contacts["+ i +"].ContactName");
				contact.Honorific = context.StringValue("GetPredictiveJob.Job.Contacts["+ i +"].Honorific");
				contact.Role = context.StringValue("GetPredictiveJob.Job.Contacts["+ i +"].Role");
				contact.PhoneNumber = context.StringValue("GetPredictiveJob.Job.Contacts["+ i +"].PhoneNumber");
				contact.State = context.StringValue("GetPredictiveJob.Job.Contacts["+ i +"].State");
				contact.ReferenceId = context.StringValue("GetPredictiveJob.Job.Contacts["+ i +"].ReferenceId");
				contact.JobId = context.StringValue("GetPredictiveJob.Job.Contacts["+ i +"].JobId");

				job_contacts.Add(contact);
			}
			job.Contacts = job_contacts;

			List<GetPredictiveJobResponse.GetPredictiveJob_Job.GetPredictiveJob_Task> job_tasks = new List<GetPredictiveJobResponse.GetPredictiveJob_Job.GetPredictiveJob_Task>();
			for (int i = 0; i < context.Length("GetPredictiveJob.Job.Tasks.Length"); i++) {
				GetPredictiveJobResponse.GetPredictiveJob_Job.GetPredictiveJob_Task task = new GetPredictiveJobResponse.GetPredictiveJob_Job.GetPredictiveJob_Task();
				task.TaskId = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].TaskId");
				task.JobId = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].JobId");
				task.ScenarioId = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].ScenarioId");
				task.ChatbotId = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].ChatbotId");
				task.PlanedTime = context.LongValue("GetPredictiveJob.Job.Tasks["+ i +"].PlanedTime");
				task.ActualTime = context.LongValue("GetPredictiveJob.Job.Tasks["+ i +"].ActualTime");
				task.CallingNumber = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].CallingNumber");
				task.CalledNumber = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].CalledNumber");
				task.CallId = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].CallId");
				task.Status = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].Status");
				task.Brief = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].Brief");
				task.Duration = context.IntegerValue("GetPredictiveJob.Job.Tasks["+ i +"].Duration");

				GetPredictiveJobResponse.GetPredictiveJob_Job.GetPredictiveJob_Task.GetPredictiveJob_Contact1 contact1 = new GetPredictiveJobResponse.GetPredictiveJob_Job.GetPredictiveJob_Task.GetPredictiveJob_Contact1();
				contact1.ContactId = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].Contact.ContactId");
				contact1.ContactName = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].Contact.ContactName");
				contact1.Honorific = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].Contact.Honorific");
				contact1.Role = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].Contact.Role");
				contact1.PhoneNumber = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].Contact.PhoneNumber");
				contact1.State = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].Contact.State");
				contact1.ReferenceId = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].Contact.ReferenceId");
				contact1.JobId = context.StringValue("GetPredictiveJob.Job.Tasks["+ i +"].Contact.JobId");
				task.Contact1 = contact1;

				job_tasks.Add(task);
			}
			job.Tasks = job_tasks;
			getPredictiveJobResponse.Job = job;
        
			return getPredictiveJobResponse;
        }
    }
}
