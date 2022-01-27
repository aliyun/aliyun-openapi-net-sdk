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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class ListRecycleBinJobsResponseUnmarshaller
    {
        public static ListRecycleBinJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRecycleBinJobsResponse listRecycleBinJobsResponse = new ListRecycleBinJobsResponse();

			listRecycleBinJobsResponse.HttpResponse = _ctx.HttpResponse;
			listRecycleBinJobsResponse.RequestId = _ctx.StringValue("ListRecycleBinJobs.RequestId");
			listRecycleBinJobsResponse.TotalCount = _ctx.LongValue("ListRecycleBinJobs.TotalCount");
			listRecycleBinJobsResponse.PageNumber = _ctx.LongValue("ListRecycleBinJobs.PageNumber");
			listRecycleBinJobsResponse.PageSize = _ctx.LongValue("ListRecycleBinJobs.PageSize");

			List<ListRecycleBinJobsResponse.ListRecycleBinJobs_Job> listRecycleBinJobsResponse_jobs = new List<ListRecycleBinJobsResponse.ListRecycleBinJobs_Job>();
			for (int i = 0; i < _ctx.Length("ListRecycleBinJobs.Jobs.Length"); i++) {
				ListRecycleBinJobsResponse.ListRecycleBinJobs_Job job = new ListRecycleBinJobsResponse.ListRecycleBinJobs_Job();
				job.Id = _ctx.StringValue("ListRecycleBinJobs.Jobs["+ i +"].Id");
				job.Type = _ctx.StringValue("ListRecycleBinJobs.Jobs["+ i +"].Type");
				job.FileId = _ctx.StringValue("ListRecycleBinJobs.Jobs["+ i +"].FileId");
				job.Status = _ctx.StringValue("ListRecycleBinJobs.Jobs["+ i +"].Status");
				job.ErrorCode = _ctx.StringValue("ListRecycleBinJobs.Jobs["+ i +"].ErrorCode");
				job.Progress = _ctx.StringValue("ListRecycleBinJobs.Jobs["+ i +"].Progress");
				job.CreateTime = _ctx.StringValue("ListRecycleBinJobs.Jobs["+ i +"].CreateTime");
				job.FileName = _ctx.StringValue("ListRecycleBinJobs.Jobs["+ i +"].FileName");
				job.ErrorMessage = _ctx.StringValue("ListRecycleBinJobs.Jobs["+ i +"].ErrorMessage");

				listRecycleBinJobsResponse_jobs.Add(job);
			}
			listRecycleBinJobsResponse.Jobs = listRecycleBinJobsResponse_jobs;
        
			return listRecycleBinJobsResponse;
        }
    }
}
