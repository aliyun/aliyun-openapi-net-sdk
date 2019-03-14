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
        public static ListFlowJobResponse Unmarshall(UnmarshallerContext context)
        {
			ListFlowJobResponse listFlowJobResponse = new ListFlowJobResponse();

			listFlowJobResponse.HttpResponse = context.HttpResponse;
			listFlowJobResponse.RequestId = context.StringValue("ListFlowJob.RequestId");
			listFlowJobResponse.PageNumber = context.IntegerValue("ListFlowJob.PageNumber");
			listFlowJobResponse.PageSize = context.IntegerValue("ListFlowJob.PageSize");
			listFlowJobResponse.Total = context.IntegerValue("ListFlowJob.Total");

			List<ListFlowJobResponse.ListFlowJob_Job> listFlowJobResponse_jobList = new List<ListFlowJobResponse.ListFlowJob_Job>();
			for (int i = 0; i < context.Length("ListFlowJob.JobList.Length"); i++) {
				ListFlowJobResponse.ListFlowJob_Job job = new ListFlowJobResponse.ListFlowJob_Job();
				job.Id = context.StringValue("ListFlowJob.JobList["+ i +"].Id");
				job.GmtCreate = context.LongValue("ListFlowJob.JobList["+ i +"].GmtCreate");
				job.GmtModified = context.LongValue("ListFlowJob.JobList["+ i +"].GmtModified");
				job.Name = context.StringValue("ListFlowJob.JobList["+ i +"].Name");
				job.Type = context.StringValue("ListFlowJob.JobList["+ i +"].Type");
				job.Description = context.StringValue("ListFlowJob.JobList["+ i +"].Description");
				job.FailAct = context.StringValue("ListFlowJob.JobList["+ i +"].FailAct");
				job.MaxRetry = context.IntegerValue("ListFlowJob.JobList["+ i +"].MaxRetry");
				job.RetryInterval = context.LongValue("ListFlowJob.JobList["+ i +"].RetryInterval");
				job._Params = context.StringValue("ListFlowJob.JobList["+ i +"].Params");
				job.ParamConf = context.StringValue("ListFlowJob.JobList["+ i +"].ParamConf");
				job.CustomVariables = context.StringValue("ListFlowJob.JobList["+ i +"].CustomVariables");
				job.EnvConf = context.StringValue("ListFlowJob.JobList["+ i +"].EnvConf");
				job.RunConf = context.StringValue("ListFlowJob.JobList["+ i +"].RunConf");
				job.MonitorConf = context.StringValue("ListFlowJob.JobList["+ i +"].MonitorConf");
				job.CategoryId = context.StringValue("ListFlowJob.JobList["+ i +"].CategoryId");
				job.Mode = context.StringValue("ListFlowJob.JobList["+ i +"].Mode");
				job.Adhoc = context.StringValue("ListFlowJob.JobList["+ i +"].Adhoc");
				job.AlertConf = context.StringValue("ListFlowJob.JobList["+ i +"].AlertConf");
				job.LastInstanceDetail = context.StringValue("ListFlowJob.JobList["+ i +"].LastInstanceDetail");

				List<ListFlowJobResponse.ListFlowJob_Job.ListFlowJob_Resource> job_resourceList = new List<ListFlowJobResponse.ListFlowJob_Job.ListFlowJob_Resource>();
				for (int j = 0; j < context.Length("ListFlowJob.JobList["+ i +"].ResourceList.Length"); j++) {
					ListFlowJobResponse.ListFlowJob_Job.ListFlowJob_Resource resource = new ListFlowJobResponse.ListFlowJob_Job.ListFlowJob_Resource();
					resource.Path = context.StringValue("ListFlowJob.JobList["+ i +"].ResourceList["+ j +"].Path");
					resource.Alias = context.StringValue("ListFlowJob.JobList["+ i +"].ResourceList["+ j +"].Alias");

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
