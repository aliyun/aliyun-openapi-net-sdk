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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListJobsResponseUnmarshaller
    {
        public static ListJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJobsResponse listJobsResponse = new ListJobsResponse();

			listJobsResponse.HttpResponse = _ctx.HttpResponse;
			listJobsResponse.RequestId = _ctx.StringValue("ListJobs.RequestId");
			listJobsResponse.TotalCount = _ctx.IntegerValue("ListJobs.TotalCount");
			listJobsResponse.PageNumber = _ctx.IntegerValue("ListJobs.PageNumber");
			listJobsResponse.PageSize = _ctx.IntegerValue("ListJobs.PageSize");

			List<ListJobsResponse.ListJobs_JobInfo> listJobsResponse_jobs = new List<ListJobsResponse.ListJobs_JobInfo>();
			for (int i = 0; i < _ctx.Length("ListJobs.Jobs.Length"); i++) {
				ListJobsResponse.ListJobs_JobInfo jobInfo = new ListJobsResponse.ListJobs_JobInfo();
				jobInfo.Id = _ctx.StringValue("ListJobs.Jobs["+ i +"].Id");
				jobInfo.Name = _ctx.StringValue("ListJobs.Jobs["+ i +"].Name");
				jobInfo.Owner = _ctx.StringValue("ListJobs.Jobs["+ i +"].Owner");
				jobInfo.NodeList = _ctx.StringValue("ListJobs.Jobs["+ i +"].NodeList");
				jobInfo.Priority = _ctx.StringValue("ListJobs.Jobs["+ i +"].Priority");
				jobInfo.State = _ctx.StringValue("ListJobs.Jobs["+ i +"].State");
				jobInfo.SubmitTime = _ctx.StringValue("ListJobs.Jobs["+ i +"].SubmitTime");
				jobInfo.StartTime = _ctx.StringValue("ListJobs.Jobs["+ i +"].StartTime");
				jobInfo.LastModifyTime = _ctx.StringValue("ListJobs.Jobs["+ i +"].LastModifyTime");
				jobInfo.Stdout = _ctx.StringValue("ListJobs.Jobs["+ i +"].Stdout");
				jobInfo.Stderr = _ctx.StringValue("ListJobs.Jobs["+ i +"].Stderr");
				jobInfo.ShellPath = _ctx.StringValue("ListJobs.Jobs["+ i +"].ShellPath");
				jobInfo.Comment = _ctx.StringValue("ListJobs.Jobs["+ i +"].Comment");
				jobInfo.ArrayRequest = _ctx.StringValue("ListJobs.Jobs["+ i +"].ArrayRequest");

				ListJobsResponse.ListJobs_JobInfo.ListJobs_Resources resources = new ListJobsResponse.ListJobs_JobInfo.ListJobs_Resources();
				resources.Nodes = _ctx.IntegerValue("ListJobs.Jobs["+ i +"].Resources.Nodes");
				resources.Cores = _ctx.IntegerValue("ListJobs.Jobs["+ i +"].Resources.Cores");
				jobInfo.Resources = resources;

				listJobsResponse_jobs.Add(jobInfo);
			}
			listJobsResponse.Jobs = listJobsResponse_jobs;
        
			return listJobsResponse;
        }
    }
}
