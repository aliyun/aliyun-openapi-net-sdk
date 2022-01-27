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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListImageJobsResponseUnmarshaller
    {
        public static ListImageJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListImageJobsResponse listImageJobsResponse = new ListImageJobsResponse();

			listImageJobsResponse.HttpResponse = _ctx.HttpResponse;
			listImageJobsResponse.RequestId = _ctx.StringValue("ListImageJobs.RequestId");
			listImageJobsResponse.NextMarker = _ctx.StringValue("ListImageJobs.NextMarker");

			List<ListImageJobsResponse.ListImageJobs_JobsItem> listImageJobsResponse_jobs = new List<ListImageJobsResponse.ListImageJobs_JobsItem>();
			for (int i = 0; i < _ctx.Length("ListImageJobs.Jobs.Length"); i++) {
				ListImageJobsResponse.ListImageJobs_JobsItem jobsItem = new ListImageJobsResponse.ListImageJobs_JobsItem();
				jobsItem.Status = _ctx.StringValue("ListImageJobs.Jobs["+ i +"].Status");
				jobsItem.JobId = _ctx.StringValue("ListImageJobs.Jobs["+ i +"].JobId");
				jobsItem.JobType = _ctx.StringValue("ListImageJobs.Jobs["+ i +"].JobType");
				jobsItem.Parameters = _ctx.StringValue("ListImageJobs.Jobs["+ i +"].Parameters");
				jobsItem.Result = _ctx.StringValue("ListImageJobs.Jobs["+ i +"].Result");
				jobsItem.StartTime = _ctx.StringValue("ListImageJobs.Jobs["+ i +"].StartTime");
				jobsItem.EndTime = _ctx.StringValue("ListImageJobs.Jobs["+ i +"].EndTime");
				jobsItem.ErrorMessage = _ctx.StringValue("ListImageJobs.Jobs["+ i +"].ErrorMessage");
				jobsItem.NotifyEndpoint = _ctx.StringValue("ListImageJobs.Jobs["+ i +"].NotifyEndpoint");
				jobsItem.NotifyTopicName = _ctx.StringValue("ListImageJobs.Jobs["+ i +"].NotifyTopicName");
				jobsItem.Progress = _ctx.IntegerValue("ListImageJobs.Jobs["+ i +"].Progress");

				listImageJobsResponse_jobs.Add(jobsItem);
			}
			listImageJobsResponse.Jobs = listImageJobsResponse_jobs;
        
			return listImageJobsResponse;
        }
    }
}
