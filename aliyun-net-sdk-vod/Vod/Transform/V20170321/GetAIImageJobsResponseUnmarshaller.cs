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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetAIImageJobsResponseUnmarshaller
    {
        public static GetAIImageJobsResponse Unmarshall(UnmarshallerContext context)
        {
			GetAIImageJobsResponse getAIImageJobsResponse = new GetAIImageJobsResponse();

			getAIImageJobsResponse.HttpResponse = context.HttpResponse;
			getAIImageJobsResponse.RequestId = context.StringValue("GetAIImageJobs.RequestId");

			List<GetAIImageJobsResponse.GetAIImageJobs_AIImageJob> getAIImageJobsResponse_aIImageJobList = new List<GetAIImageJobsResponse.GetAIImageJobs_AIImageJob>();
			for (int i = 0; i < context.Length("GetAIImageJobs.AIImageJobList.Length"); i++) {
				GetAIImageJobsResponse.GetAIImageJobs_AIImageJob aIImageJob = new GetAIImageJobsResponse.GetAIImageJobs_AIImageJob();
				aIImageJob.CreationTime = context.StringValue("GetAIImageJobs.AIImageJobList["+ i +"].CreationTime");
				aIImageJob.JobId = context.StringValue("GetAIImageJobs.AIImageJobList["+ i +"].JobId");
				aIImageJob.TemplateId = context.StringValue("GetAIImageJobs.AIImageJobList["+ i +"].TemplateId");
				aIImageJob.VideoId = context.StringValue("GetAIImageJobs.AIImageJobList["+ i +"].VideoId");
				aIImageJob.AIImageResult = context.StringValue("GetAIImageJobs.AIImageJobList["+ i +"].AIImageResult");
				aIImageJob.UserData = context.StringValue("GetAIImageJobs.AIImageJobList["+ i +"].UserData");
				aIImageJob.Code = context.StringValue("GetAIImageJobs.AIImageJobList["+ i +"].Code");
				aIImageJob.Message = context.StringValue("GetAIImageJobs.AIImageJobList["+ i +"].Message");
				aIImageJob.Status = context.StringValue("GetAIImageJobs.AIImageJobList["+ i +"].Status");
				aIImageJob.TemplateConfig = context.StringValue("GetAIImageJobs.AIImageJobList["+ i +"].TemplateConfig");

				getAIImageJobsResponse_aIImageJobList.Add(aIImageJob);
			}
			getAIImageJobsResponse.AIImageJobList = getAIImageJobsResponse_aIImageJobList;
        
			return getAIImageJobsResponse;
        }
    }
}
