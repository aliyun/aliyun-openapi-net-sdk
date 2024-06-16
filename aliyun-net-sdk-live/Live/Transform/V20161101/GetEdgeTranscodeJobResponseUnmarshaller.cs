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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class GetEdgeTranscodeJobResponseUnmarshaller
    {
        public static GetEdgeTranscodeJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetEdgeTranscodeJobResponse getEdgeTranscodeJobResponse = new GetEdgeTranscodeJobResponse();

			getEdgeTranscodeJobResponse.HttpResponse = _ctx.HttpResponse;
			getEdgeTranscodeJobResponse.RequestId = _ctx.StringValue("GetEdgeTranscodeJob.RequestId");

			GetEdgeTranscodeJobResponse.GetEdgeTranscodeJob_Job job = new GetEdgeTranscodeJobResponse.GetEdgeTranscodeJob_Job();
			job.CreateTime = _ctx.StringValue("GetEdgeTranscodeJob.Job.CreateTime");
			job.JobId = _ctx.StringValue("GetEdgeTranscodeJob.Job.JobId");
			job.LastStartAt = _ctx.StringValue("GetEdgeTranscodeJob.Job.LastStartAt");
			job.LastStopAt = _ctx.StringValue("GetEdgeTranscodeJob.Job.LastStopAt");
			job.Name = _ctx.StringValue("GetEdgeTranscodeJob.Job.Name");
			job.Status = _ctx.StringValue("GetEdgeTranscodeJob.Job.Status");
			job.StreamInput = _ctx.StringValue("GetEdgeTranscodeJob.Job.StreamInput");
			job.StreamOutput = _ctx.StringValue("GetEdgeTranscodeJob.Job.StreamOutput");
			job.TemplateId = _ctx.StringValue("GetEdgeTranscodeJob.Job.TemplateId");
			job.TemplateName = _ctx.StringValue("GetEdgeTranscodeJob.Job.TemplateName");
			job.Type = _ctx.StringValue("GetEdgeTranscodeJob.Job.Type");
			getEdgeTranscodeJobResponse.Job = job;
        
			return getEdgeTranscodeJobResponse;
        }
    }
}
