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
        public static GetJobResponse Unmarshall(UnmarshallerContext context)
        {
			GetJobResponse getJobResponse = new GetJobResponse();

			getJobResponse.HttpResponse = context.HttpResponse;
			getJobResponse.RequestId = context.StringValue("GetJob.RequestId");

			GetJobResponse.GetJob_Job job = new GetJobResponse.GetJob_Job();
			job.JobName = context.StringValue("GetJob.Job.JobName");
			job.ProjectName = context.StringValue("GetJob.Job.ProjectName");
			job.JobType = context.StringValue("GetJob.Job.JobType");
			job.ApiType = context.StringValue("GetJob.Job.ApiType");
			job.Code = context.StringValue("GetJob.Job.Code");
			job.PlanJson = context.StringValue("GetJob.Job.PlanJson");
			job.Properties = context.StringValue("GetJob.Job.Properties");
			job.Packages = context.StringValue("GetJob.Job.Packages");
			job.IsCommitted = context.BooleanValue("GetJob.Job.IsCommitted");
			job.Creator = context.StringValue("GetJob.Job.Creator");
			job.CreateTime = context.LongValue("GetJob.Job.CreateTime");
			job.Modifier = context.StringValue("GetJob.Job.Modifier");
			job.ModifyTime = context.LongValue("GetJob.Job.ModifyTime");
			job.Description = context.StringValue("GetJob.Job.Description");
			job.EngineVersion = context.StringValue("GetJob.Job.EngineVersion");
			job.ClusterId = context.StringValue("GetJob.Job.ClusterId");
			job.QueueName = context.StringValue("GetJob.Job.QueueName");
			job.FolderId = context.LongValue("GetJob.Job.FolderId");
			job.JobId = context.StringValue("GetJob.Job.JobId");
			getJobResponse.Job = job;
        
			return getJobResponse;
        }
    }
}
