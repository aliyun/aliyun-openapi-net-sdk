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
    public class GetVideoListResponseUnmarshaller
    {
        public static GetVideoListResponse Unmarshall(UnmarshallerContext context)
        {
			GetVideoListResponse getVideoListResponse = new GetVideoListResponse();

			getVideoListResponse.HttpResponse = context.HttpResponse;
			getVideoListResponse.RequestId = context.StringValue("GetVideoList.RequestId");
			getVideoListResponse.Total = context.IntegerValue("GetVideoList.Total");

			List<GetVideoListResponse.GetVideoList_Video> getVideoListResponse_videoList = new List<GetVideoListResponse.GetVideoList_Video>();
			for (int i = 0; i < context.Length("GetVideoList.VideoList.Length"); i++) {
				GetVideoListResponse.GetVideoList_Video video = new GetVideoListResponse.GetVideoList_Video();
				video.VideoId = context.StringValue("GetVideoList.VideoList["+ i +"].VideoId");
				video.Title = context.StringValue("GetVideoList.VideoList["+ i +"].Title");
				video.Tags = context.StringValue("GetVideoList.VideoList["+ i +"].Tags");
				video.Status = context.StringValue("GetVideoList.VideoList["+ i +"].Status");
				video.Size = context.LongValue("GetVideoList.VideoList["+ i +"].Size");
				video.Duration = context.FloatValue("GetVideoList.VideoList["+ i +"].Duration");
				video.Description = context.StringValue("GetVideoList.VideoList["+ i +"].Description");
				video.CreateTime = context.StringValue("GetVideoList.VideoList["+ i +"].CreateTime");
				video.CreationTime = context.StringValue("GetVideoList.VideoList["+ i +"].CreationTime");
				video.ModifyTime = context.StringValue("GetVideoList.VideoList["+ i +"].ModifyTime");
				video.CoverURL = context.StringValue("GetVideoList.VideoList["+ i +"].CoverURL");
				video.CateId = context.IntegerValue("GetVideoList.VideoList["+ i +"].CateId");
				video.CateName = context.StringValue("GetVideoList.VideoList["+ i +"].CateName");

				List<string> video_snapshots = new List<string>();
				for (int j = 0; j < context.Length("GetVideoList.VideoList["+ i +"].Snapshots.Length"); j++) {
					video_snapshots.Add(context.StringValue("GetVideoList.VideoList["+ i +"].Snapshots["+ j +"]"));
				}
				video.Snapshots = video_snapshots;

				getVideoListResponse_videoList.Add(video);
			}
			getVideoListResponse.VideoList = getVideoListResponse_videoList;
        
			return getVideoListResponse;
        }
    }
}