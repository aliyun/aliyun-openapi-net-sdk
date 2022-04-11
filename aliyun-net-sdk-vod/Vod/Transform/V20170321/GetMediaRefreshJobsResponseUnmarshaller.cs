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
    public class GetMediaRefreshJobsResponseUnmarshaller
    {
        public static GetMediaRefreshJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMediaRefreshJobsResponse getMediaRefreshJobsResponse = new GetMediaRefreshJobsResponse();

			getMediaRefreshJobsResponse.HttpResponse = _ctx.HttpResponse;
			getMediaRefreshJobsResponse.RequestId = _ctx.StringValue("GetMediaRefreshJobs.RequestId");

			List<GetMediaRefreshJobsResponse.GetMediaRefreshJobs_MediaRefreshJob> getMediaRefreshJobsResponse_mediaRefreshJobs = new List<GetMediaRefreshJobsResponse.GetMediaRefreshJobs_MediaRefreshJob>();
			for (int i = 0; i < _ctx.Length("GetMediaRefreshJobs.MediaRefreshJobs.Length"); i++) {
				GetMediaRefreshJobsResponse.GetMediaRefreshJobs_MediaRefreshJob mediaRefreshJob = new GetMediaRefreshJobsResponse.GetMediaRefreshJobs_MediaRefreshJob();
				mediaRefreshJob.MediaRefreshJobId = _ctx.StringValue("GetMediaRefreshJobs.MediaRefreshJobs["+ i +"].MediaRefreshJobId");
				mediaRefreshJob.MediaId = _ctx.StringValue("GetMediaRefreshJobs.MediaRefreshJobs["+ i +"].MediaId");
				mediaRefreshJob.TaskType = _ctx.StringValue("GetMediaRefreshJobs.MediaRefreshJobs["+ i +"].TaskType");
				mediaRefreshJob.FilterPolicy = _ctx.StringValue("GetMediaRefreshJobs.MediaRefreshJobs["+ i +"].FilterPolicy");
				mediaRefreshJob.Status = _ctx.StringValue("GetMediaRefreshJobs.MediaRefreshJobs["+ i +"].Status");
				mediaRefreshJob.SuccessPlayUrls = _ctx.StringValue("GetMediaRefreshJobs.MediaRefreshJobs["+ i +"].SuccessPlayUrls");
				mediaRefreshJob.TaskIds = _ctx.StringValue("GetMediaRefreshJobs.MediaRefreshJobs["+ i +"].TaskIds");
				mediaRefreshJob.ErrorCode = _ctx.StringValue("GetMediaRefreshJobs.MediaRefreshJobs["+ i +"].ErrorCode");
				mediaRefreshJob.ErrorMessage = _ctx.StringValue("GetMediaRefreshJobs.MediaRefreshJobs["+ i +"].ErrorMessage");
				mediaRefreshJob.UserData = _ctx.StringValue("GetMediaRefreshJobs.MediaRefreshJobs["+ i +"].UserData");
				mediaRefreshJob.GmtCreate = _ctx.StringValue("GetMediaRefreshJobs.MediaRefreshJobs["+ i +"].GmtCreate");
				mediaRefreshJob.GmtModified = _ctx.StringValue("GetMediaRefreshJobs.MediaRefreshJobs["+ i +"].GmtModified");

				getMediaRefreshJobsResponse_mediaRefreshJobs.Add(mediaRefreshJob);
			}
			getMediaRefreshJobsResponse.MediaRefreshJobs = getMediaRefreshJobsResponse_mediaRefreshJobs;
        
			return getMediaRefreshJobsResponse;
        }
    }
}
