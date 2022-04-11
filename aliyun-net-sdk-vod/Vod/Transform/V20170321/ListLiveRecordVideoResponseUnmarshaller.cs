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
    public class ListLiveRecordVideoResponseUnmarshaller
    {
        public static ListLiveRecordVideoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLiveRecordVideoResponse listLiveRecordVideoResponse = new ListLiveRecordVideoResponse();

			listLiveRecordVideoResponse.HttpResponse = _ctx.HttpResponse;
			listLiveRecordVideoResponse.Total = _ctx.IntegerValue("ListLiveRecordVideo.Total");
			listLiveRecordVideoResponse.RequestId = _ctx.StringValue("ListLiveRecordVideo.RequestId");

			List<ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo> listLiveRecordVideoResponse_liveRecordVideoList = new List<ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo>();
			for (int i = 0; i < _ctx.Length("ListLiveRecordVideo.LiveRecordVideoList.Length"); i++) {
				ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo liveRecordVideo = new ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo();
				liveRecordVideo.AppName = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].AppName");
				liveRecordVideo.PlaylistId = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlaylistId");
				liveRecordVideo.StreamName = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].StreamName");
				liveRecordVideo.RecordEndTime = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].RecordEndTime");
				liveRecordVideo.RecordStartTime = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].RecordStartTime");
				liveRecordVideo.DomainName = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].DomainName");

				ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo.ListLiveRecordVideo_Video video = new ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo.ListLiveRecordVideo_Video();
				video.CreationTime = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.CreationTime");
				video.Status = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Status");
				video.CateId = _ctx.IntegerValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.CateId");
				video.Privilege = _ctx.IntegerValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Privilege");
				video.VideoId = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.VideoId");
				video.CreateTime = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.CreateTime");
				video.DownloadSwitch = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.DownloadSwitch");
				video.Tags = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Tags");
				video.CateName = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.CateName");
				video.Description = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Description");
				video.Size = _ctx.LongValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Size");
				video.CoverURL = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.CoverURL");
				video.TemplateGroupId = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.TemplateGroupId");
				video.CustomerId = _ctx.LongValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.CustomerId");
				video.Duration = _ctx.FloatValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Duration");
				video.Title = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Title");
				video.ModifyTime = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.ModifyTime");

				List<string> video_snapshots = new List<string>();
				for (int j = 0; j < _ctx.Length("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Snapshots.Length"); j++) {
					video_snapshots.Add(_ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Snapshots["+ j +"]"));
				}
				video.Snapshots = video_snapshots;
				liveRecordVideo.Video = video;

				List<ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo.ListLiveRecordVideo_PlayInfo> liveRecordVideo_playInfoList = new List<ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo.ListLiveRecordVideo_PlayInfo>();
				for (int j = 0; j < _ctx.Length("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList.Length"); j++) {
					ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo.ListLiveRecordVideo_PlayInfo playInfo = new ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo.ListLiveRecordVideo_PlayInfo();
					playInfo.Complexity = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Complexity");
					playInfo.Height = _ctx.LongValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Height");
					playInfo.Bitrate = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Bitrate");
					playInfo.Encrypt = _ctx.LongValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Encrypt");
					playInfo.Definition = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Definition");
					playInfo.Rand = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Rand");
					playInfo.StreamType = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].StreamType");
					playInfo.JobId = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].JobId");
					playInfo.Width = _ctx.LongValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Width");
					playInfo.Size = _ctx.LongValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Size");
					playInfo.Plaintext = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Plaintext");
					playInfo.PlayURL = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].PlayURL");
					playInfo.Duration = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Duration");
					playInfo.Fps = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Fps");
					playInfo.Format = _ctx.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Format");

					liveRecordVideo_playInfoList.Add(playInfo);
				}
				liveRecordVideo.PlayInfoList = liveRecordVideo_playInfoList;

				listLiveRecordVideoResponse_liveRecordVideoList.Add(liveRecordVideo);
			}
			listLiveRecordVideoResponse.LiveRecordVideoList = listLiveRecordVideoResponse_liveRecordVideoList;
        
			return listLiveRecordVideoResponse;
        }
    }
}
