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
    public class GetJobDetailResponseUnmarshaller
    {
        public static GetJobDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJobDetailResponse getJobDetailResponse = new GetJobDetailResponse();

			getJobDetailResponse.HttpResponse = _ctx.HttpResponse;
			getJobDetailResponse.RequestId = _ctx.StringValue("GetJobDetail.RequestId");
			getJobDetailResponse.JobType = _ctx.StringValue("GetJobDetail.JobType");

			GetJobDetailResponse.GetJobDetail_TranscodeJobDetail transcodeJobDetail = new GetJobDetailResponse.GetJobDetail_TranscodeJobDetail();
			transcodeJobDetail.JobId = _ctx.StringValue("GetJobDetail.TranscodeJobDetail.JobId");
			transcodeJobDetail.UserId = _ctx.LongValue("GetJobDetail.TranscodeJobDetail.UserId");
			transcodeJobDetail.VideoId = _ctx.StringValue("GetJobDetail.TranscodeJobDetail.VideoId");
			transcodeJobDetail.Status = _ctx.StringValue("GetJobDetail.TranscodeJobDetail.Status");
			transcodeJobDetail.TemplateId = _ctx.StringValue("GetJobDetail.TranscodeJobDetail.TemplateId");
			transcodeJobDetail.Definition = _ctx.StringValue("GetJobDetail.TranscodeJobDetail.Definition");
			transcodeJobDetail.CreateTime = _ctx.StringValue("GetJobDetail.TranscodeJobDetail.CreateTime");
			transcodeJobDetail.CompleteTime = _ctx.StringValue("GetJobDetail.TranscodeJobDetail.CompleteTime");
			getJobDetailResponse.TranscodeJobDetail = transcodeJobDetail;

			GetJobDetailResponse.GetJobDetail_SnapshotJobDetail snapshotJobDetail = new GetJobDetailResponse.GetJobDetail_SnapshotJobDetail();
			snapshotJobDetail.JobId = _ctx.StringValue("GetJobDetail.SnapshotJobDetail.JobId");
			snapshotJobDetail.UserId = _ctx.LongValue("GetJobDetail.SnapshotJobDetail.UserId");
			snapshotJobDetail.VideoId = _ctx.StringValue("GetJobDetail.SnapshotJobDetail.VideoId");
			snapshotJobDetail.Status = _ctx.StringValue("GetJobDetail.SnapshotJobDetail.Status");
			snapshotJobDetail.Trigger = _ctx.StringValue("GetJobDetail.SnapshotJobDetail.Trigger");
			snapshotJobDetail.NormalConfig = _ctx.StringValue("GetJobDetail.SnapshotJobDetail.NormalConfig");
			snapshotJobDetail.SpriteConfig = _ctx.StringValue("GetJobDetail.SnapshotJobDetail.SpriteConfig");
			snapshotJobDetail.CreateTime = _ctx.StringValue("GetJobDetail.SnapshotJobDetail.CreateTime");
			snapshotJobDetail.CompleteTime = _ctx.StringValue("GetJobDetail.SnapshotJobDetail.CompleteTime");
			getJobDetailResponse.SnapshotJobDetail = snapshotJobDetail;

			GetJobDetailResponse.GetJobDetail_AIJobDetail aIJobDetail = new GetJobDetailResponse.GetJobDetail_AIJobDetail();
			aIJobDetail.JobId = _ctx.StringValue("GetJobDetail.AIJobDetail.JobId");
			aIJobDetail.UserId = _ctx.LongValue("GetJobDetail.AIJobDetail.UserId");
			aIJobDetail.MediaId = _ctx.StringValue("GetJobDetail.AIJobDetail.MediaId");
			aIJobDetail.JobType = _ctx.StringValue("GetJobDetail.AIJobDetail.JobType");
			aIJobDetail.Status = _ctx.StringValue("GetJobDetail.AIJobDetail.Status");
			aIJobDetail.Trigger = _ctx.StringValue("GetJobDetail.AIJobDetail.Trigger");
			aIJobDetail.TemplateConfig = _ctx.StringValue("GetJobDetail.AIJobDetail.TemplateConfig");
			aIJobDetail.CreateTime = _ctx.StringValue("GetJobDetail.AIJobDetail.CreateTime");
			aIJobDetail.CompleteTime = _ctx.StringValue("GetJobDetail.AIJobDetail.CompleteTime");
			getJobDetailResponse.AIJobDetail = aIJobDetail;
        
			return getJobDetailResponse;
        }
    }
}
