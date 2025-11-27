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
    public class GetVideoInfosResponseUnmarshaller
    {
        public static GetVideoInfosResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVideoInfosResponse getVideoInfosResponse = new GetVideoInfosResponse();

			getVideoInfosResponse.HttpResponse = _ctx.HttpResponse;
			getVideoInfosResponse.RequestId = _ctx.StringValue("GetVideoInfos.RequestId");

			List<string> getVideoInfosResponse_nonExistVideoIds = new List<string>();
			for (int i = 0; i < _ctx.Length("GetVideoInfos.NonExistVideoIds.Length"); i++) {
				getVideoInfosResponse_nonExistVideoIds.Add(_ctx.StringValue("GetVideoInfos.NonExistVideoIds["+ i +"]"));
			}
			getVideoInfosResponse.NonExistVideoIds = getVideoInfosResponse_nonExistVideoIds;

			List<GetVideoInfosResponse.GetVideoInfos_Video> getVideoInfosResponse_videoList = new List<GetVideoInfosResponse.GetVideoInfos_Video>();
			for (int i = 0; i < _ctx.Length("GetVideoInfos.VideoList.Length"); i++) {
				GetVideoInfosResponse.GetVideoInfos_Video video = new GetVideoInfosResponse.GetVideoInfos_Video();
				video.StorageLocation = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].StorageLocation");
				video.CreationTime = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].CreationTime");
				video.Status = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].Status");
				video.CateId = _ctx.LongValue("GetVideoInfos.VideoList["+ i +"].CateId");
				video.VideoId = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].VideoId");
				video.DownloadSwitch = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].DownloadSwitch");
				video.Tags = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].Tags");
				video.ModificationTime = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].ModificationTime");
				video.RegionId = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].RegionId");
				video.CustomMediaInfo = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].CustomMediaInfo");
				video.CateName = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].CateName");
				video.Description = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].Description");
				video.PreprocessStatus = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].PreprocessStatus");
				video.AppId = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].AppId");
				video.Size = _ctx.LongValue("GetVideoInfos.VideoList["+ i +"].Size");
				video.CoverURL = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].CoverURL");
				video.TemplateGroupId = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].TemplateGroupId");
				video.Duration = _ctx.FloatValue("GetVideoInfos.VideoList["+ i +"].Duration");
				video.Title = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].Title");
				video.StorageClass = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].StorageClass");
				video.RestoreStatus = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].RestoreStatus");
				video.RestoreExpiration = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].RestoreExpiration");
				video.UserData = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].UserData");

				List<string> video_snapshots = new List<string>();
				for (int j = 0; j < _ctx.Length("GetVideoInfos.VideoList["+ i +"].Snapshots.Length"); j++) {
					video_snapshots.Add(_ctx.StringValue("GetVideoInfos.VideoList["+ i +"].Snapshots["+ j +"]"));
				}
				video.Snapshots = video_snapshots;

				List<GetVideoInfosResponse.GetVideoInfos_Video.GetVideoInfos_Thumbnail> video_thumbnailList = new List<GetVideoInfosResponse.GetVideoInfos_Video.GetVideoInfos_Thumbnail>();
				for (int j = 0; j < _ctx.Length("GetVideoInfos.VideoList["+ i +"].ThumbnailList.Length"); j++) {
					GetVideoInfosResponse.GetVideoInfos_Video.GetVideoInfos_Thumbnail thumbnail = new GetVideoInfosResponse.GetVideoInfos_Video.GetVideoInfos_Thumbnail();
					thumbnail.URL = _ctx.StringValue("GetVideoInfos.VideoList["+ i +"].ThumbnailList["+ j +"].URL");

					video_thumbnailList.Add(thumbnail);
				}
				video.ThumbnailList = video_thumbnailList;

				getVideoInfosResponse_videoList.Add(video);
			}
			getVideoInfosResponse.VideoList = getVideoInfosResponse_videoList;
        
			return getVideoInfosResponse;
        }
    }
}
