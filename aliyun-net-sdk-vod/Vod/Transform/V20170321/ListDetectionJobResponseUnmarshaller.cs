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
    public class ListDetectionJobResponseUnmarshaller
    {
        public static ListDetectionJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDetectionJobResponse listDetectionJobResponse = new ListDetectionJobResponse();

			listDetectionJobResponse.HttpResponse = _ctx.HttpResponse;
			listDetectionJobResponse.RequestId = _ctx.StringValue("ListDetectionJob.RequestId");

			List<ListDetectionJobResponse.ListDetectionJob_DetectionJob> listDetectionJobResponse_detectionJobList = new List<ListDetectionJobResponse.ListDetectionJob_DetectionJob>();
			for (int i = 0; i < _ctx.Length("ListDetectionJob.DetectionJobList.Length"); i++) {
				ListDetectionJobResponse.ListDetectionJob_DetectionJob detectionJob = new ListDetectionJobResponse.ListDetectionJob_DetectionJob();
				detectionJob.JobId = _ctx.StringValue("ListDetectionJob.DetectionJobList["+ i +"].JobId");
				detectionJob.CreateTime = _ctx.StringValue("ListDetectionJob.DetectionJobList["+ i +"].CreateTime");
				detectionJob.ModifyTime = _ctx.StringValue("ListDetectionJob.DetectionJobList["+ i +"].ModifyTime");
				detectionJob.BeginTime = _ctx.StringValue("ListDetectionJob.DetectionJobList["+ i +"].BeginTime");
				detectionJob.EndTime = _ctx.StringValue("ListDetectionJob.DetectionJobList["+ i +"].EndTime");
				detectionJob.VideoId = _ctx.StringValue("ListDetectionJob.DetectionJobList["+ i +"].VideoId");
				detectionJob.CopyrightStatus = _ctx.StringValue("ListDetectionJob.DetectionJobList["+ i +"].CopyrightStatus");
				detectionJob.CopyrightBeginTime = _ctx.StringValue("ListDetectionJob.DetectionJobList["+ i +"].CopyrightBeginTime");
				detectionJob.CopyrightEndTime = _ctx.StringValue("ListDetectionJob.DetectionJobList["+ i +"].CopyrightEndTime");
				detectionJob.CopyrightFile = _ctx.StringValue("ListDetectionJob.DetectionJobList["+ i +"].CopyrightFile");
				detectionJob.WhitelistUrls = _ctx.StringValue("ListDetectionJob.DetectionJobList["+ i +"].WhitelistUrls");
				detectionJob.TemplateId = _ctx.StringValue("ListDetectionJob.DetectionJobList["+ i +"].TemplateId");

				listDetectionJobResponse_detectionJobList.Add(detectionJob);
			}
			listDetectionJobResponse.DetectionJobList = listDetectionJobResponse_detectionJobList;
        
			return listDetectionJobResponse;
        }
    }
}
