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
    public class UpdateDetectionJobResponseUnmarshaller
    {
        public static UpdateDetectionJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateDetectionJobResponse updateDetectionJobResponse = new UpdateDetectionJobResponse();

			updateDetectionJobResponse.HttpResponse = _ctx.HttpResponse;
			updateDetectionJobResponse.RequestId = _ctx.StringValue("UpdateDetectionJob.RequestId");

			UpdateDetectionJobResponse.UpdateDetectionJob_DetectionJob detectionJob = new UpdateDetectionJobResponse.UpdateDetectionJob_DetectionJob();
			detectionJob.JobId = _ctx.StringValue("UpdateDetectionJob.DetectionJob.JobId");
			detectionJob.CreateTime = _ctx.StringValue("UpdateDetectionJob.DetectionJob.CreateTime");
			detectionJob.ModifyTime = _ctx.StringValue("UpdateDetectionJob.DetectionJob.ModifyTime");
			detectionJob.BeginTime = _ctx.StringValue("UpdateDetectionJob.DetectionJob.BeginTime");
			detectionJob.EndTime = _ctx.StringValue("UpdateDetectionJob.DetectionJob.EndTime");
			detectionJob.VideoId = _ctx.StringValue("UpdateDetectionJob.DetectionJob.VideoId");
			detectionJob.CopyrightStatus = _ctx.StringValue("UpdateDetectionJob.DetectionJob.CopyrightStatus");
			detectionJob.CopyrightBeginTime = _ctx.StringValue("UpdateDetectionJob.DetectionJob.CopyrightBeginTime");
			detectionJob.CopyrightEndTime = _ctx.StringValue("UpdateDetectionJob.DetectionJob.CopyrightEndTime");
			detectionJob.CopyrightFile = _ctx.StringValue("UpdateDetectionJob.DetectionJob.CopyrightFile");
			detectionJob.WhitelistUrls = _ctx.StringValue("UpdateDetectionJob.DetectionJob.WhitelistUrls");
			detectionJob.TemplateId = _ctx.StringValue("UpdateDetectionJob.DetectionJob.TemplateId");
			updateDetectionJobResponse.DetectionJob = detectionJob;
        
			return updateDetectionJobResponse;
        }
    }
}
