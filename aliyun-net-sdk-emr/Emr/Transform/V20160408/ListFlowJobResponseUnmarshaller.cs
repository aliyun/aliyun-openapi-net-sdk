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
    public class ListFlowJobResponseUnmarshaller
    {
        public static ListFlowJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFlowJobResponse listFlowJobResponse = new ListFlowJobResponse();

			listFlowJobResponse.HttpResponse = _ctx.HttpResponse;
			listFlowJobResponse.RequestId = _ctx.StringValue("ListFlowJob.RequestId");
			listFlowJobResponse.PageNumber = _ctx.IntegerValue("ListFlowJob.PageNumber");
			listFlowJobResponse.PageSize = _ctx.IntegerValue("ListFlowJob.PageSize");
			listFlowJobResponse.Total = _ctx.IntegerValue("ListFlowJob.Total");

			List<ListFlowJobResponse.ListFlowJob_Job> listFlowJobResponse_jobList = new List<ListFlowJobResponse.ListFlowJob_Job>();
			for (int i = 0; i < _ctx.Length("ListFlowJob.JobList.Length"); i++) {
				ListFlowJobResponse.ListFlowJob_Job job = new ListFlowJobResponse.ListFlowJob_Job();
				job.Id = _ctx.StringValue("ListFlowJob.JobList["+ i +"].Id");
				job.GmtCreate = _ctx.LongValue("ListFlowJob.JobList["+ i +"].GmtCreate");
				job.GmtModified = _ctx.LongValue("ListFlowJob.JobList["+ i +"].GmtModified");
				job.Name = _ctx.StringValue("ListFlowJob.JobList["+ i +"].Name");
				job.Type = _ctx.StringValue("ListFlowJob.JobList["+ i +"].Type");
				job.Description = _ctx.StringValue("ListFlowJob.JobList["+ i +"].Description");
				job.FailAct = _ctx.StringValue("ListFlowJob.JobList["+ i +"].FailAct");
				job.MaxRetry = _ctx.IntegerValue("ListFlowJob.JobList["+ i +"].MaxRetry");
				job.RetryInterval = _ctx.LongValue("ListFlowJob.JobList["+ i +"].RetryInterval");
				job._Params = _ctx.StringValue("ListFlowJob.JobList["+ i +"].Params");
				job.ParamConf = _ctx.StringValue("ListFlowJob.JobList["+ i +"].ParamConf");
				job.CustomVariables = _ctx.StringValue("ListFlowJob.JobList["+ i +"].CustomVariables");
				job.EnvConf = _ctx.StringValue("ListFlowJob.JobList["+ i +"].EnvConf");
				job.RunConf = _ctx.StringValue("ListFlowJob.JobList["+ i +"].RunConf");
				job.MonitorConf = _ctx.StringValue("ListFlowJob.JobList["+ i +"].MonitorConf");
				job.CategoryId = _ctx.StringValue("ListFlowJob.JobList["+ i +"].CategoryId");
				job.Mode = _ctx.StringValue("ListFlowJob.JobList["+ i +"].mode");
				job.Adhoc = _ctx.StringValue("ListFlowJob.JobList["+ i +"].Adhoc");
				job.AlertConf = _ctx.StringValue("ListFlowJob.JobList["+ i +"].AlertConf");
				job.LastInstanceDetail = _ctx.StringValue("ListFlowJob.JobList["+ i +"].LastInstanceDetail");

				List<ListFlowJobResponse.ListFlowJob_Job.ListFlowJob_Resource> job_resourceList = new List<ListFlowJobResponse.ListFlowJob_Job.ListFlowJob_Resource>();
				for (int j = 0; j < _ctx.Length("ListFlowJob.JobList["+ i +"].ResourceList.Length"); j++) {
					ListFlowJobResponse.ListFlowJob_Job.ListFlowJob_Resource resource = new ListFlowJobResponse.ListFlowJob_Job.ListFlowJob_Resource();
					resource.Path = _ctx.StringValue("ListFlowJob.JobList["+ i +"].ResourceList["+ j +"].Path");
					resource.Alias = _ctx.StringValue("ListFlowJob.JobList["+ i +"].ResourceList["+ j +"].Alias");

					job_resourceList.Add(resource);
				}
				job.ResourceList = job_resourceList;

				listFlowJobResponse_jobList.Add(job);
			}
			listFlowJobResponse.JobList = listFlowJobResponse_jobList;
        
			return listFlowJobResponse;
        }
    }
}
