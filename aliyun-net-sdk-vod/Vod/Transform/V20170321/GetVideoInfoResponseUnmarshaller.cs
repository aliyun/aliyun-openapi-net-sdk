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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetVideoInfoResponseUnmarshaller
    {
        public static GetVideoInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetVideoInfoResponse getVideoInfoResponse = new GetVideoInfoResponse();

			getVideoInfoResponse.HttpResponse = context.HttpResponse;
			getVideoInfoResponse.RequestId = context.StringValue("GetVideoInfo.RequestId");

			GetVideoInfoResponse.GetVideoInfo_Video video = new GetVideoInfoResponse.GetVideoInfo_Video();
			video.VideoId = context.StringValue("GetVideoInfo.Video.VideoId");
			video.Title = context.StringValue("GetVideoInfo.Video.Title");
			video.Tags = context.StringValue("GetVideoInfo.Video.Tags");
			video.Status = context.StringValue("GetVideoInfo.Video.Status");
			video.Size = context.LongValue("GetVideoInfo.Video.Size");
			video.Duration = context.FloatValue("GetVideoInfo.Video.Duration");
			video.Description = context.StringValue("GetVideoInfo.Video.Description");
			video.CreateTime = context.StringValue("GetVideoInfo.Video.CreateTime");
			video.CreationTime = context.StringValue("GetVideoInfo.Video.CreationTime");
			video.ModifyTime = context.StringValue("GetVideoInfo.Video.ModifyTime");
			video.CoverURL = context.StringValue("GetVideoInfo.Video.CoverURL");
			video.CateId = context.IntegerValue("GetVideoInfo.Video.CateId");
			video.CateName = context.StringValue("GetVideoInfo.Video.CateName");

			List<string> video_snapshots = new List<string>();
			for (int i = 0; i < context.Length("GetVideoInfo.Video.Snapshots.Length"); i++) {
				video_snapshots.Add(context.StringValue("GetVideoInfo.Video.Snapshots["+ i +"]"));
			}
			video.Snapshots = video_snapshots;
			getVideoInfoResponse.Video = video;
        
			return getVideoInfoResponse;
        }
    }
}