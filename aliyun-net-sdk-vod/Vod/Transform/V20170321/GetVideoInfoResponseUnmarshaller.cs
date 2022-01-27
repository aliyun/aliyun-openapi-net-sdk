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
    public class GetVideoInfoResponseUnmarshaller
    {
        public static GetVideoInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVideoInfoResponse getVideoInfoResponse = new GetVideoInfoResponse();

			getVideoInfoResponse.HttpResponse = _ctx.HttpResponse;
			getVideoInfoResponse.RequestId = _ctx.StringValue("GetVideoInfo.RequestId");
			getVideoInfoResponse.AI = _ctx.StringValue("GetVideoInfo.AI");

			GetVideoInfoResponse.GetVideoInfo_Video video = new GetVideoInfoResponse.GetVideoInfo_Video();
			video.VideoId = _ctx.StringValue("GetVideoInfo.Video.VideoId");
			video.Title = _ctx.StringValue("GetVideoInfo.Video.Title");
			video.Tags = _ctx.StringValue("GetVideoInfo.Video.Tags");
			video.Status = _ctx.StringValue("GetVideoInfo.Video.Status");
			video.Size = _ctx.LongValue("GetVideoInfo.Video.Size");
			video.Duration = _ctx.FloatValue("GetVideoInfo.Video.Duration");
			video.Description = _ctx.StringValue("GetVideoInfo.Video.Description");
			video.CreateTime = _ctx.StringValue("GetVideoInfo.Video.CreateTime");
			video.ModifyTime = _ctx.StringValue("GetVideoInfo.Video.ModifyTime");
			video.ModificationTime = _ctx.StringValue("GetVideoInfo.Video.ModificationTime");
			video.CreationTime = _ctx.StringValue("GetVideoInfo.Video.CreationTime");
			video.CoverURL = _ctx.StringValue("GetVideoInfo.Video.CoverURL");
			video.CateId = _ctx.LongValue("GetVideoInfo.Video.CateId");
			video.CateName = _ctx.StringValue("GetVideoInfo.Video.CateName");
			video.DownloadSwitch = _ctx.StringValue("GetVideoInfo.Video.DownloadSwitch");
			video.TemplateGroupId = _ctx.StringValue("GetVideoInfo.Video.TemplateGroupId");
			video.PreprocessStatus = _ctx.StringValue("GetVideoInfo.Video.PreprocessStatus");
			video.StorageLocation = _ctx.StringValue("GetVideoInfo.Video.StorageLocation");
			video.RegionId = _ctx.StringValue("GetVideoInfo.Video.RegionId");
			video.CustomMediaInfo = _ctx.StringValue("GetVideoInfo.Video.CustomMediaInfo");
			video.AuditStatus = _ctx.StringValue("GetVideoInfo.Video.AuditStatus");
			video.AppId = _ctx.StringValue("GetVideoInfo.Video.AppId");

			List<string> video_snapshots = new List<string>();
			for (int i = 0; i < _ctx.Length("GetVideoInfo.Video.Snapshots.Length"); i++) {
				video_snapshots.Add(_ctx.StringValue("GetVideoInfo.Video.Snapshots["+ i +"]"));
			}
			video.Snapshots = video_snapshots;

			List<GetVideoInfoResponse.GetVideoInfo_Video.GetVideoInfo_Thumbnail> video_thumbnailList = new List<GetVideoInfoResponse.GetVideoInfo_Video.GetVideoInfo_Thumbnail>();
			for (int i = 0; i < _ctx.Length("GetVideoInfo.Video.ThumbnailList.Length"); i++) {
				GetVideoInfoResponse.GetVideoInfo_Video.GetVideoInfo_Thumbnail thumbnail = new GetVideoInfoResponse.GetVideoInfo_Video.GetVideoInfo_Thumbnail();
				thumbnail.URL = _ctx.StringValue("GetVideoInfo.Video.ThumbnailList["+ i +"].URL");

				video_thumbnailList.Add(thumbnail);
			}
			video.ThumbnailList = video_thumbnailList;
			getVideoInfoResponse.Video = video;
        
			return getVideoInfoResponse;
        }
    }
}
