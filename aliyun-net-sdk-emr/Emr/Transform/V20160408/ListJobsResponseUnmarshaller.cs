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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
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
				jobInfo.Type = context.StringValue("ListJobs.Jobs["+ i +"].Type");
				jobInfo.RunParameter = context.StringValue("ListJobs.Jobs["+ i +"].RunParameter");
				jobInfo.FailAct = context.StringValue("ListJobs.Jobs["+ i +"].FailAct");
				jobInfo.MaxRetry = context.IntegerValue("ListJobs.Jobs["+ i +"].MaxRetry");
				jobInfo.RetryInterval = context.IntegerValue("ListJobs.Jobs["+ i +"].RetryInterval");

				listJobsResponse_jobs.Add(jobInfo);
			}
			listJobsResponse.Jobs = listJobsResponse_jobs;
        
			return listJobsResponse;
        }
    }
}
