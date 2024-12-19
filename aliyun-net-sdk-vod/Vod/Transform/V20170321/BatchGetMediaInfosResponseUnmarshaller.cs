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
    public class BatchGetMediaInfosResponseUnmarshaller
    {
        public static BatchGetMediaInfosResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchGetMediaInfosResponse batchGetMediaInfosResponse = new BatchGetMediaInfosResponse();

			batchGetMediaInfosResponse.HttpResponse = _ctx.HttpResponse;
			batchGetMediaInfosResponse.RequestId = _ctx.StringValue("BatchGetMediaInfos.RequestId");

			List<string> batchGetMediaInfosResponse_nonExistMediaIds = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchGetMediaInfos.NonExistMediaIds.Length"); i++) {
				batchGetMediaInfosResponse_nonExistMediaIds.Add(_ctx.StringValue("BatchGetMediaInfos.NonExistMediaIds["+ i +"]"));
			}
			batchGetMediaInfosResponse.NonExistMediaIds = batchGetMediaInfosResponse_nonExistMediaIds;

			List<string> batchGetMediaInfosResponse_forbiddenMediaIds = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchGetMediaInfos.ForbiddenMediaIds.Length"); i++) {
				batchGetMediaInfosResponse_forbiddenMediaIds.Add(_ctx.StringValue("BatchGetMediaInfos.ForbiddenMediaIds["+ i +"]"));
			}
			batchGetMediaInfosResponse.ForbiddenMediaIds = batchGetMediaInfosResponse_forbiddenMediaIds;

			List<BatchGetMediaInfosResponse.BatchGetMediaInfos_MediaBasicInfo> batchGetMediaInfosResponse_mediaInfos = new List<BatchGetMediaInfosResponse.BatchGetMediaInfos_MediaBasicInfo>();
			for (int i = 0; i < _ctx.Length("BatchGetMediaInfos.MediaInfos.Length"); i++) {
				BatchGetMediaInfosResponse.BatchGetMediaInfos_MediaBasicInfo mediaBasicInfo = new BatchGetMediaInfosResponse.BatchGetMediaInfos_MediaBasicInfo();
				mediaBasicInfo.MediaId = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaId");

				BatchGetMediaInfosResponse.BatchGetMediaInfos_MediaBasicInfo.BatchGetMediaInfos_MediaInfo mediaInfo = new BatchGetMediaInfosResponse.BatchGetMediaInfos_MediaBasicInfo.BatchGetMediaInfos_MediaInfo();
				mediaInfo.StorageLocation = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.StorageLocation");
				mediaInfo.CreationTime = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.CreationTime");
				mediaInfo.Status = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.Status");
				mediaInfo.CateId = _ctx.LongValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.CateId");
				mediaInfo.MediaId = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.MediaId");
				mediaInfo.DownloadSwitch = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.DownloadSwitch");
				mediaInfo.Tags = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.Tags");
				mediaInfo.ModificationTime = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.ModificationTime");
				mediaInfo.RegionId = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.RegionId");
				mediaInfo.CateName = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.CateName");
				mediaInfo.Description = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.Description");
				mediaInfo.PreprocessStatus = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.PreprocessStatus");
				mediaInfo.AppId = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.AppId");
				mediaInfo.CoverURL = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.CoverURL");
				mediaInfo.TemplateGroupId = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.TemplateGroupId");
				mediaInfo.Title = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.Title");
				mediaInfo.StorageClass = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.StorageClass");
				mediaInfo.RestoreStatus = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.RestoreStatus");
				mediaInfo.RestoreExpiration = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.RestoreExpiration");
				mediaInfo.UserData = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.UserData");

				List<string> mediaInfo_snapshots = new List<string>();
				for (int j = 0; j < _ctx.Length("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.Snapshots.Length"); j++) {
					mediaInfo_snapshots.Add(_ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MediaInfo.Snapshots["+ j +"]"));
				}
				mediaInfo.Snapshots = mediaInfo_snapshots;
				mediaBasicInfo.MediaInfo = mediaInfo;

				BatchGetMediaInfosResponse.BatchGetMediaInfos_MediaBasicInfo.BatchGetMediaInfos_MezzanineInfo mezzanineInfo = new BatchGetMediaInfosResponse.BatchGetMediaInfos_MediaBasicInfo.BatchGetMediaInfos_MezzanineInfo();
				mezzanineInfo.CreationTime = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.CreationTime");
				mezzanineInfo.Status = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.Status");
				mezzanineInfo.FileURL = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.FileURL");
				mezzanineInfo.MediaId = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.MediaId");
				mezzanineInfo.Height = _ctx.LongValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.Height");
				mezzanineInfo.Bitrate = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.Bitrate");
				mezzanineInfo.FileName = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.FileName");
				mezzanineInfo.Width = _ctx.LongValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.Width");
				mezzanineInfo.Size = _ctx.LongValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.Size");
				mezzanineInfo.CRC64 = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.CRC64");
				mezzanineInfo.Duration = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.Duration");
				mezzanineInfo.Fps = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.Fps");

				List<BatchGetMediaInfosResponse.BatchGetMediaInfos_MediaBasicInfo.BatchGetMediaInfos_MezzanineInfo.BatchGetMediaInfos_AudioStream> mezzanineInfo_audioStreamList = new List<BatchGetMediaInfosResponse.BatchGetMediaInfos_MediaBasicInfo.BatchGetMediaInfos_MezzanineInfo.BatchGetMediaInfos_AudioStream>();
				for (int j = 0; j < _ctx.Length("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList.Length"); j++) {
					BatchGetMediaInfosResponse.BatchGetMediaInfos_MediaBasicInfo.BatchGetMediaInfos_MezzanineInfo.BatchGetMediaInfos_AudioStream audioStream = new BatchGetMediaInfosResponse.BatchGetMediaInfos_MediaBasicInfo.BatchGetMediaInfos_MezzanineInfo.BatchGetMediaInfos_AudioStream();
					audioStream.Index = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList["+ j +"].Index");
					audioStream.Timebase = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList["+ j +"].Timebase");
					audioStream.SampleFmt = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList["+ j +"].SampleFmt");
					audioStream.SampleRate = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList["+ j +"].SampleRate");
					audioStream.ChannelLayout = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Lang = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList["+ j +"].Lang");
					audioStream.CodecLongName = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList["+ j +"].CodecLongName");
					audioStream.Channels = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList["+ j +"].Channels");
					audioStream.NumFrames = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList["+ j +"].NumFrames");
					audioStream.Bitrate = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList["+ j +"].Bitrate");
					audioStream.CodecTagString = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList["+ j +"].CodecTagString");
					audioStream.StartTime = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList["+ j +"].StartTime");
					audioStream.CodecName = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList["+ j +"].CodecName");
					audioStream.Duration = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList["+ j +"].Duration");
					audioStream.CodecTag = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList["+ j +"].CodecTag");
					audioStream.CodecTimeBase = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.AudioStreamList["+ j +"].CodecTimeBase");

					mezzanineInfo_audioStreamList.Add(audioStream);
				}
				mezzanineInfo.AudioStreamList = mezzanineInfo_audioStreamList;

				List<BatchGetMediaInfosResponse.BatchGetMediaInfos_MediaBasicInfo.BatchGetMediaInfos_MezzanineInfo.BatchGetMediaInfos_VideoStream> mezzanineInfo_videoStreamList = new List<BatchGetMediaInfosResponse.BatchGetMediaInfos_MediaBasicInfo.BatchGetMediaInfos_MezzanineInfo.BatchGetMediaInfos_VideoStream>();
				for (int j = 0; j < _ctx.Length("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList.Length"); j++) {
					BatchGetMediaInfosResponse.BatchGetMediaInfos_MediaBasicInfo.BatchGetMediaInfos_MezzanineInfo.BatchGetMediaInfos_VideoStream videoStream = new BatchGetMediaInfosResponse.BatchGetMediaInfos_MediaBasicInfo.BatchGetMediaInfos_MezzanineInfo.BatchGetMediaInfos_VideoStream();
					videoStream.Timebase = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].Timebase");
					videoStream.Index = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].Index");
					videoStream.AvgFPS = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].AvgFPS");
					videoStream.PixFmt = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].PixFmt");
					videoStream.Lang = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].Lang");
					videoStream.Sar = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].Sar");
					videoStream.Height = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].Height");
					videoStream.CodecLongName = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].CodecLongName");
					videoStream.NumFrames = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].NumFrames");
					videoStream.Bitrate = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].Bitrate");
					videoStream.Rotate = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].Rotate");
					videoStream.CodecTagString = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].CodecTagString");
					videoStream.HasBFrames = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Profile = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].Profile");
					videoStream.StartTime = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].StartTime");
					videoStream.Dar = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].Dar");
					videoStream.CodecName = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].CodecName");
					videoStream.Width = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].Width");
					videoStream.Duration = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].Duration");
					videoStream.Fps = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].Fps");
					videoStream.CodecTag = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].CodecTag");
					videoStream.CodecTimeBase = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.Level = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].Level");
					videoStream.HDRType = _ctx.StringValue("BatchGetMediaInfos.MediaInfos["+ i +"].MezzanineInfo.VideoStreamList["+ j +"].HDRType");

					mezzanineInfo_videoStreamList.Add(videoStream);
				}
				mezzanineInfo.VideoStreamList = mezzanineInfo_videoStreamList;
				mediaBasicInfo.MezzanineInfo = mezzanineInfo;

				batchGetMediaInfosResponse_mediaInfos.Add(mediaBasicInfo);
			}
			batchGetMediaInfosResponse.MediaInfos = batchGetMediaInfosResponse_mediaInfos;
        
			return batchGetMediaInfosResponse;
        }
    }
}
