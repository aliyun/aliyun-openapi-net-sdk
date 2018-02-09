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
using Aliyun.Acs.EHPC.Model.V20170714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20170714
{
    public class ListJobsResponseUnmarshaller
    {
        public static ListJobsResponse Unmarshall(UnmarshallerContext context)
        {
			ListJobsResponse listJobsResponse = new ListJobsResponse();

			listJobsResponse.HttpResponse = context.HttpResponse;
			listJobsResponse.RequestId = context.StringValue("ListJobs.RequestId");
			listJobsResponse.TotalCount = context.IntegerValue("ListJobs.TotalCount");
			listJobsResponse.PageNumber = context.IntegerValue("ListJobs.PageNumber");
			listJobsResponse.PageSize = context.IntegerValue("ListJobs.PageSize");

			List<ListJobsResponse.ListJobs_JobInfo> listJobsResponse_jobs = new List<ListJobsResponse.ListJobs_JobInfo>();
			for (int i = 0; i < context.Length("ListJobs.Jobs.Length"); i++) {
				ListJobsResponse.ListJobs_JobInfo jobInfo = new ListJobsResponse.ListJobs_JobInfo();
				jobInfo.Id = context.StringValue("ListJobs.Jobs["+ i +"].Id");
				jobInfo.Name = context.StringValue("ListJobs.Jobs["+ i +"].Name");
				jobInfo.Owner = context.StringValue("ListJobs.Jobs["+ i +"].Owner");
				jobInfo.Priority = context.IntegerValue("ListJobs.Jobs["+ i +"].Priority");
				jobInfo.State = context.StringValue("ListJobs.Jobs["+ i +"].State");
				jobInfo.SubmitTime = context.StringValue("ListJobs.Jobs["+ i +"].SubmitTime");
				jobInfo.StartTime = context.StringValue("ListJobs.Jobs["+ i +"].StartTime");
				jobInfo.LastModifyTime = context.StringValue("ListJobs.Jobs["+ i +"].LastModifyTime");
				jobInfo.Stdout = context.StringValue("ListJobs.Jobs["+ i +"].Stdout");
				jobInfo.Stderr = context.StringValue("ListJobs.Jobs["+ i +"].Stderr");
				jobInfo.Comment = context.StringValue("ListJobs.Jobs["+ i +"].Comment");
				jobInfo.ArrayRequest = context.StringValue("ListJobs.Jobs["+ i +"].ArrayRequest");

				ListJobsResponse.ListJobs_JobInfo.ListJobs_Resources resources = new ListJobsResponse.ListJobs_JobInfo.ListJobs_Resources();
				resources.Nodes = context.IntegerValue("ListJobs.Jobs["+ i +"].Resources.Nodes");
				resources.Cores = context.IntegerValue("ListJobs.Jobs["+ i +"].Resources.Cores");
				jobInfo.Resources = resources;

				listJobsResponse_jobs.Add(jobInfo);
			}
			listJobsResponse.Jobs = listJobsResponse_jobs;
        
			return listJobsResponse;
        }
    }
}