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
    public class GetDetectionJobResponseUnmarshaller
    {
        public static GetDetectionJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDetectionJobResponse getDetectionJobResponse = new GetDetectionJobResponse();

			getDetectionJobResponse.HttpResponse = _ctx.HttpResponse;
			getDetectionJobResponse.RequestId = _ctx.StringValue("GetDetectionJob.RequestId");

			GetDetectionJobResponse.GetDetectionJob_DetectionJob detectionJob = new GetDetectionJobResponse.GetDetectionJob_DetectionJob();
			detectionJob.JobId = _ctx.StringValue("GetDetectionJob.DetectionJob.JobId");
			detectionJob.CreateTime = _ctx.StringValue("GetDetectionJob.DetectionJob.CreateTime");
			detectionJob.ModifyTime = _ctx.StringValue("GetDetectionJob.DetectionJob.ModifyTime");
			detectionJob.BeginTime = _ctx.StringValue("GetDetectionJob.DetectionJob.BeginTime");
			detectionJob.EndTime = _ctx.StringValue("GetDetectionJob.DetectionJob.EndTime");
			detectionJob.VideoId = _ctx.StringValue("GetDetectionJob.DetectionJob.VideoId");
			detectionJob.CopyrightStatus = _ctx.StringValue("GetDetectionJob.DetectionJob.CopyrightStatus");
			detectionJob.CopyrightBeginTime = _ctx.StringValue("GetDetectionJob.DetectionJob.CopyrightBeginTime");
			detectionJob.CopyrightEndTime = _ctx.StringValue("GetDetectionJob.DetectionJob.CopyrightEndTime");
			detectionJob.CopyrightFile = _ctx.StringValue("GetDetectionJob.DetectionJob.CopyrightFile");
			detectionJob.WhitelistUrls = _ctx.StringValue("GetDetectionJob.DetectionJob.WhitelistUrls");
			detectionJob.TemplateId = _ctx.StringValue("GetDetectionJob.DetectionJob.TemplateId");
			getDetectionJobResponse.DetectionJob = detectionJob;
        
			return getDetectionJobResponse;
        }
    }
}
