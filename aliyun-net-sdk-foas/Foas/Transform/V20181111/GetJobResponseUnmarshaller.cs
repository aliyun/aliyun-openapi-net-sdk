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
using Aliyun.Acs.foas.Model.V20181111;

namespace Aliyun.Acs.foas.Transform.V20181111
{
    public class GetJobResponseUnmarshaller
    {
        public static GetJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJobResponse getJobResponse = new GetJobResponse();

			getJobResponse.HttpResponse = _ctx.HttpResponse;
			getJobResponse.RequestId = _ctx.StringValue("GetJob.RequestId");

			GetJobResponse.GetJob_Job job = new GetJobResponse.GetJob_Job();
			job.JobName = _ctx.StringValue("GetJob.Job.JobName");
			job.ProjectName = _ctx.StringValue("GetJob.Job.ProjectName");
			job.JobType = _ctx.StringValue("GetJob.Job.JobType");
			job.ApiType = _ctx.StringValue("GetJob.Job.ApiType");
			job.Code = _ctx.StringValue("GetJob.Job.Code");
			job.PlanJson = _ctx.StringValue("GetJob.Job.PlanJson");
			job.Properties = _ctx.StringValue("GetJob.Job.Properties");
			job.Packages = _ctx.StringValue("GetJob.Job.Packages");
			job.IsCommitted = _ctx.BooleanValue("GetJob.Job.IsCommitted");
			job.Creator = _ctx.StringValue("GetJob.Job.Creator");
			job.CreateTime = _ctx.LongValue("GetJob.Job.CreateTime");
			job.Modifier = _ctx.StringValue("GetJob.Job.Modifier");
			job.ModifyTime = _ctx.LongValue("GetJob.Job.ModifyTime");
			job.Description = _ctx.StringValue("GetJob.Job.Description");
			job.EngineVersion = _ctx.StringValue("GetJob.Job.EngineVersion");
			job.ClusterId = _ctx.StringValue("GetJob.Job.ClusterId");
			job.QueueName = _ctx.StringValue("GetJob.Job.QueueName");
			job.FolderId = _ctx.LongValue("GetJob.Job.FolderId");
			job.JobId = _ctx.StringValue("GetJob.Job.JobId");
			job.FileId = _ctx.StringValue("GetJob.Job.FileId");
			getJobResponse.Job = job;
        
			return getJobResponse;
        }
    }
}
