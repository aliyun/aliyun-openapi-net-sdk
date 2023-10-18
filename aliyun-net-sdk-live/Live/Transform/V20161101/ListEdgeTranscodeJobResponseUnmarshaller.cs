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
    public class ListEdgeTranscodeJobResponseUnmarshaller
    {
        public static ListEdgeTranscodeJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEdgeTranscodeJobResponse listEdgeTranscodeJobResponse = new ListEdgeTranscodeJobResponse();

			listEdgeTranscodeJobResponse.HttpResponse = _ctx.HttpResponse;
			listEdgeTranscodeJobResponse.TotalCount = _ctx.IntegerValue("ListEdgeTranscodeJob.TotalCount");
			listEdgeTranscodeJobResponse.RequestId = _ctx.StringValue("ListEdgeTranscodeJob.RequestId");

			List<ListEdgeTranscodeJobResponse.ListEdgeTranscodeJob_Job> listEdgeTranscodeJobResponse_jobList = new List<ListEdgeTranscodeJobResponse.ListEdgeTranscodeJob_Job>();
			for (int i = 0; i < _ctx.Length("ListEdgeTranscodeJob.JobList.Length"); i++) {
				ListEdgeTranscodeJobResponse.ListEdgeTranscodeJob_Job job = new ListEdgeTranscodeJobResponse.ListEdgeTranscodeJob_Job();
				job.Status = _ctx.StringValue("ListEdgeTranscodeJob.JobList["+ i +"].Status");
				job.Type = _ctx.StringValue("ListEdgeTranscodeJob.JobList["+ i +"].Type");
				job.StreamInput = _ctx.StringValue("ListEdgeTranscodeJob.JobList["+ i +"].StreamInput");
				job.StreamOutput = _ctx.StringValue("ListEdgeTranscodeJob.JobList["+ i +"].StreamOutput");
				job.LastStopAt = _ctx.StringValue("ListEdgeTranscodeJob.JobList["+ i +"].LastStopAt");
				job.LastStartAt = _ctx.StringValue("ListEdgeTranscodeJob.JobList["+ i +"].LastStartAt");
				job.CreateTime = _ctx.StringValue("ListEdgeTranscodeJob.JobList["+ i +"].CreateTime");
				job.JobId = _ctx.StringValue("ListEdgeTranscodeJob.JobList["+ i +"].JobId");
				job.TemplateName = _ctx.StringValue("ListEdgeTranscodeJob.JobList["+ i +"].TemplateName");
				job.Name = _ctx.StringValue("ListEdgeTranscodeJob.JobList["+ i +"].Name");
				job.TemplateId = _ctx.StringValue("ListEdgeTranscodeJob.JobList["+ i +"].TemplateId");

				listEdgeTranscodeJobResponse_jobList.Add(job);
			}
			listEdgeTranscodeJobResponse.JobList = listEdgeTranscodeJobResponse_jobList;
        
			return listEdgeTranscodeJobResponse;
        }
    }
}
