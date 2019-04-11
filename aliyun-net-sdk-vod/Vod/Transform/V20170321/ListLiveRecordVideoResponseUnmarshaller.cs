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
        public static ListLiveRecordVideoResponse Unmarshall(UnmarshallerContext context)
        {
			ListLiveRecordVideoResponse listLiveRecordVideoResponse = new ListLiveRecordVideoResponse();

			listLiveRecordVideoResponse.HttpResponse = context.HttpResponse;
			listLiveRecordVideoResponse.RequestId = context.StringValue("ListLiveRecordVideo.RequestId");
			listLiveRecordVideoResponse.Total = context.IntegerValue("ListLiveRecordVideo.Total");

			List<ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo> listLiveRecordVideoResponse_liveRecordVideoList = new List<ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo>();
			for (int i = 0; i < context.Length("ListLiveRecordVideo.LiveRecordVideoList.Length"); i++) {
				ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo liveRecordVideo = new ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo();
				liveRecordVideo.StreamName = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].StreamName");
				liveRecordVideo.DomainName = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].DomainName");
				liveRecordVideo.AppName = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].AppName");
				liveRecordVideo.PlaylistId = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlaylistId");
				liveRecordVideo.RecordStartTime = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].RecordStartTime");
				liveRecordVideo.RecordEndTime = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].RecordEndTime");

				ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo.ListLiveRecordVideo_Video video = new ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo.ListLiveRecordVideo_Video();
				video.VideoId = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.VideoId");
				video.Title = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Title");
				video.Tags = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Tags");
				video.Status = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Status");
				video.Size = context.LongValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Size");
				video.Privilege = context.IntegerValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Privilege");
				video.Duration = context.FloatValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Duration");
				video.Description = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Description");
				video.CustomerId = context.LongValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.CustomerId");
				video.CreateTime = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.CreateTime");
				video.CreationTime = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.CreationTime");
				video.ModifyTime = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.ModifyTime");
				video.CoverURL = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.CoverURL");
				video.CateId = context.IntegerValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.CateId");
				video.CateName = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.CateName");
				video.DownloadSwitch = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.DownloadSwitch");
				video.TemplateGroupId = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.TemplateGroupId");

				List<string> video_snapshots = new List<string>();
				for (int j = 0; j < context.Length("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Snapshots.Length"); j++) {
					video_snapshots.Add(context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].Video.Snapshots["+ j +"]"));
				}
				video.Snapshots = video_snapshots;
				liveRecordVideo.Video = video;

				List<ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo.ListLiveRecordVideo_PlayInfo> liveRecordVideo_playInfoList = new List<ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo.ListLiveRecordVideo_PlayInfo>();
				for (int j = 0; j < context.Length("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList.Length"); j++) {
					ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo.ListLiveRecordVideo_PlayInfo playInfo = new ListLiveRecordVideoResponse.ListLiveRecordVideo_LiveRecordVideo.ListLiveRecordVideo_PlayInfo();
					playInfo.Width = context.LongValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Width");
					playInfo.Height = context.LongValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Height");
					playInfo.Size = context.LongValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Size");
					playInfo.PlayURL = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].PlayURL");
					playInfo.Bitrate = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Bitrate");
					playInfo.Definition = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Definition");
					playInfo.Duration = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Duration");
					playInfo.Format = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Format");
					playInfo.Fps = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Fps");
					playInfo.Encrypt = context.LongValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Encrypt");
					playInfo.Plaintext = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Plaintext");
					playInfo.Complexity = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Complexity");
					playInfo.StreamType = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].StreamType");
					playInfo.Rand = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].Rand");
					playInfo.JobId = context.StringValue("ListLiveRecordVideo.LiveRecordVideoList["+ i +"].PlayInfoList["+ j +"].JobId");

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
