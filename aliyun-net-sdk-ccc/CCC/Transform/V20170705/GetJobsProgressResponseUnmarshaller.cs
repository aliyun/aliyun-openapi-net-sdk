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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class GetJobsProgressResponseUnmarshaller
    {
        public static GetJobsProgressResponse Unmarshall(UnmarshallerContext context)
        {
			GetJobsProgressResponse getJobsProgressResponse = new GetJobsProgressResponse();

			getJobsProgressResponse.HttpResponse = context.HttpResponse;
			getJobsProgressResponse.RequestId = context.StringValue("GetJobsProgress.RequestId");
			getJobsProgressResponse.Success = context.BooleanValue("GetJobsProgress.Success");
			getJobsProgressResponse.Code = context.StringValue("GetJobsProgress.Code");
			getJobsProgressResponse.Message = context.StringValue("GetJobsProgress.Message");
			getJobsProgressResponse.HttpStatusCode = context.IntegerValue("GetJobsProgress.HttpStatusCode");

			GetJobsProgressResponse.GetJobsProgress_JobsProgress jobsProgress = new GetJobsProgressResponse.GetJobsProgress_JobsProgress();
			jobsProgress.Status = context.StringValue("GetJobsProgress.JobsProgress.Status");
			jobsProgress.StartTime = context.LongValue("GetJobsProgress.JobsProgress.StartTime");
			jobsProgress.Duration = context.IntegerValue("GetJobsProgress.JobsProgress.Duration");
			jobsProgress.TotalJobs = context.IntegerValue("GetJobsProgress.JobsProgress.TotalJobs");
			jobsProgress.TotalNotAnswered = context.IntegerValue("GetJobsProgress.JobsProgress.TotalNotAnswered");
			jobsProgress.TotalCompleted = context.IntegerValue("GetJobsProgress.JobsProgress.TotalCompleted");
			jobsProgress.Scheduling = context.IntegerValue("GetJobsProgress.JobsProgress.Scheduling");
			jobsProgress.Executing = context.IntegerValue("GetJobsProgress.JobsProgress.Executing");
			jobsProgress.Paused = context.IntegerValue("GetJobsProgress.JobsProgress.Paused");
			jobsProgress.Failed = context.IntegerValue("GetJobsProgress.JobsProgress.Failed");
			jobsProgress.Cancelled = context.IntegerValue("GetJobsProgress.JobsProgress.Cancelled");
			jobsProgress.RepeatCall = context.IntegerValue("GetJobsProgress.JobsProgress.RepeatCall");
			getJobsProgressResponse.JobsProgress = jobsProgress;
        
			return getJobsProgressResponse;
        }
    }
}
