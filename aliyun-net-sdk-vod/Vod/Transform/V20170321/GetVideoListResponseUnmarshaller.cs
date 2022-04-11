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
    public class GetVideoListResponseUnmarshaller
    {
        public static GetVideoListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVideoListResponse getVideoListResponse = new GetVideoListResponse();

			getVideoListResponse.HttpResponse = _ctx.HttpResponse;
			getVideoListResponse.Total = _ctx.IntegerValue("GetVideoList.Total");
			getVideoListResponse.RequestId = _ctx.StringValue("GetVideoList.RequestId");

			List<GetVideoListResponse.GetVideoList_Video> getVideoListResponse_videoList = new List<GetVideoListResponse.GetVideoList_Video>();
			for (int i = 0; i < _ctx.Length("GetVideoList.VideoList.Length"); i++) {
				GetVideoListResponse.GetVideoList_Video video = new GetVideoListResponse.GetVideoList_Video();
				video.StorageLocation = _ctx.StringValue("GetVideoList.VideoList["+ i +"].StorageLocation");
				video.Status = _ctx.StringValue("GetVideoList.VideoList["+ i +"].Status");
				video.CreationTime = _ctx.StringValue("GetVideoList.VideoList["+ i +"].CreationTime");
				video.CateId = _ctx.LongValue("GetVideoList.VideoList["+ i +"].CateId");
				video.VideoId = _ctx.StringValue("GetVideoList.VideoList["+ i +"].VideoId");
				video.CreateTime = _ctx.StringValue("GetVideoList.VideoList["+ i +"].CreateTime");
				video.Tags = _ctx.StringValue("GetVideoList.VideoList["+ i +"].Tags");
				video.ModificationTime = _ctx.StringValue("GetVideoList.VideoList["+ i +"].ModificationTime");
				video.CateName = _ctx.StringValue("GetVideoList.VideoList["+ i +"].CateName");
				video.Description = _ctx.StringValue("GetVideoList.VideoList["+ i +"].Description");
				video.AppId = _ctx.StringValue("GetVideoList.VideoList["+ i +"].AppId");
				video.Size = _ctx.LongValue("GetVideoList.VideoList["+ i +"].Size");
				video.CoverURL = _ctx.StringValue("GetVideoList.VideoList["+ i +"].CoverURL");
				video.Duration = _ctx.FloatValue("GetVideoList.VideoList["+ i +"].Duration");
				video.Title = _ctx.StringValue("GetVideoList.VideoList["+ i +"].Title");
				video.ModifyTime = _ctx.StringValue("GetVideoList.VideoList["+ i +"].ModifyTime");

				List<string> video_snapshots = new List<string>();
				for (int j = 0; j < _ctx.Length("GetVideoList.VideoList["+ i +"].Snapshots.Length"); j++) {
					video_snapshots.Add(_ctx.StringValue("GetVideoList.VideoList["+ i +"].Snapshots["+ j +"]"));
				}
				video.Snapshots = video_snapshots;

				getVideoListResponse_videoList.Add(video);
			}
			getVideoListResponse.VideoList = getVideoListResponse_videoList;
        
			return getVideoListResponse;
        }
    }
}
