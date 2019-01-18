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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListImageJobsResponseUnmarshaller
    {
        public static ListImageJobsResponse Unmarshall(UnmarshallerContext context)
        {
			ListImageJobsResponse listImageJobsResponse = new ListImageJobsResponse();

			listImageJobsResponse.HttpResponse = context.HttpResponse;
			listImageJobsResponse.RequestId = context.StringValue("ListImageJobs.RequestId");
			listImageJobsResponse.NextMarker = context.StringValue("ListImageJobs.NextMarker");

			List<ListImageJobsResponse.ListImageJobs_JobsItem> listImageJobsResponse_jobs = new List<ListImageJobsResponse.ListImageJobs_JobsItem>();
			for (int i = 0; i < context.Length("ListImageJobs.Jobs.Length"); i++) {
				ListImageJobsResponse.ListImageJobs_JobsItem jobsItem = new ListImageJobsResponse.ListImageJobs_JobsItem();
				jobsItem.Status = context.StringValue("ListImageJobs.Jobs["+ i +"].Status");
				jobsItem.JobId = context.StringValue("ListImageJobs.Jobs["+ i +"].JobId");
				jobsItem.JobType = context.StringValue("ListImageJobs.Jobs["+ i +"].JobType");
				jobsItem.Parameters = context.StringValue("ListImageJobs.Jobs["+ i +"].Parameters");
				jobsItem.Result = context.StringValue("ListImageJobs.Jobs["+ i +"].Result");
				jobsItem.StartTime = context.StringValue("ListImageJobs.Jobs["+ i +"].StartTime");
				jobsItem.EndTime = context.StringValue("ListImageJobs.Jobs["+ i +"].EndTime");
				jobsItem.ErrorMessage = context.StringValue("ListImageJobs.Jobs["+ i +"].ErrorMessage");
				jobsItem.NotifyEndpoint = context.StringValue("ListImageJobs.Jobs["+ i +"].NotifyEndpoint");
				jobsItem.NotifyTopicName = context.StringValue("ListImageJobs.Jobs["+ i +"].NotifyTopicName");
				jobsItem.Progress = context.IntegerValue("ListImageJobs.Jobs["+ i +"].Progress");

				listImageJobsResponse_jobs.Add(jobsItem);
			}
			listImageJobsResponse.Jobs = listImageJobsResponse_jobs;
        
			return listImageJobsResponse;
        }
    }
}