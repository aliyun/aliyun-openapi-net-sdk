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
    public class GetMezzanineInfoResponseUnmarshaller
    {
        public static GetMezzanineInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMezzanineInfoResponse getMezzanineInfoResponse = new GetMezzanineInfoResponse();

			getMezzanineInfoResponse.HttpResponse = _ctx.HttpResponse;
			getMezzanineInfoResponse.RequestId = _ctx.StringValue("GetMezzanineInfo.RequestId");

			GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine mezzanine = new GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine();
			mezzanine.VideoId = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoId");
			mezzanine.Bitrate = _ctx.StringValue("GetMezzanineInfo.Mezzanine.Bitrate");
			mezzanine.CreationTime = _ctx.StringValue("GetMezzanineInfo.Mezzanine.CreationTime");
			mezzanine.Duration = _ctx.StringValue("GetMezzanineInfo.Mezzanine.Duration");
			mezzanine.Fps = _ctx.StringValue("GetMezzanineInfo.Mezzanine.Fps");
			mezzanine.Height = _ctx.LongValue("GetMezzanineInfo.Mezzanine.Height");
			mezzanine.Width = _ctx.LongValue("GetMezzanineInfo.Mezzanine.Width");
			mezzanine.Size = _ctx.LongValue("GetMezzanineInfo.Mezzanine.Size");
			mezzanine.Status = _ctx.StringValue("GetMezzanineInfo.Mezzanine.Status");
			mezzanine.FileURL = _ctx.StringValue("GetMezzanineInfo.Mezzanine.FileURL");
			mezzanine.FileName = _ctx.StringValue("GetMezzanineInfo.Mezzanine.FileName");
			mezzanine.CRC64 = _ctx.StringValue("GetMezzanineInfo.Mezzanine.CRC64");
			mezzanine.PreprocessStatus = _ctx.StringValue("GetMezzanineInfo.Mezzanine.PreprocessStatus");
			mezzanine.OutputType = _ctx.StringValue("GetMezzanineInfo.Mezzanine.OutputType");

			List<GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine.GetMezzanineInfo_AudioStream> mezzanine_audioStreamList = new List<GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine.GetMezzanineInfo_AudioStream>();
			for (int i = 0; i < _ctx.Length("GetMezzanineInfo.Mezzanine.AudioStreamList.Length"); i++) {
				GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine.GetMezzanineInfo_AudioStream audioStream = new GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine.GetMezzanineInfo_AudioStream();
				audioStream.Index = _ctx.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].Index");
				audioStream.CodecName = _ctx.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].CodecName");
				audioStream.CodecLongName = _ctx.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].CodecLongName");
				audioStream.CodecTimeBase = _ctx.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].CodecTimeBase");
				audioStream.CodecTagString = _ctx.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].CodecTagString");
				audioStream.CodecTag = _ctx.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].CodecTag");
				audioStream.SampleFmt = _ctx.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].SampleFmt");
				audioStream.SampleRate = _ctx.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].SampleRate");
				audioStream.Channels = _ctx.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].Channels");
				audioStream.ChannelLayout = _ctx.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].ChannelLayout");
				audioStream.Timebase = _ctx.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].Timebase");
				audioStream.StartTime = _ctx.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].StartTime");
				audioStream.Duration = _ctx.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].Duration");
				audioStream.Bitrate = _ctx.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].Bitrate");
				audioStream.NumFrames = _ctx.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].NumFrames");
				audioStream.Lang = _ctx.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].Lang");

				mezzanine_audioStreamList.Add(audioStream);
			}
			mezzanine.AudioStreamList = mezzanine_audioStreamList;

			List<GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine.GetMezzanineInfo_VideoStream> mezzanine_videoStreamList = new List<GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine.GetMezzanineInfo_VideoStream>();
			for (int i = 0; i < _ctx.Length("GetMezzanineInfo.Mezzanine.VideoStreamList.Length"); i++) {
				GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine.GetMezzanineInfo_VideoStream videoStream = new GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine.GetMezzanineInfo_VideoStream();
				videoStream.Index = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Index");
				videoStream.CodecName = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].CodecName");
				videoStream.CodecLongName = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].CodecLongName");
				videoStream.Profile = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Profile");
				videoStream.CodecTimeBase = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].CodecTimeBase");
				videoStream.CodecTagString = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].CodecTagString");
				videoStream.CodecTag = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].CodecTag");
				videoStream.Width = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Width");
				videoStream.Height = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Height");
				videoStream.HasBFrames = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].HasBFrames");
				videoStream.Sar = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Sar");
				videoStream.Dar = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Dar");
				videoStream.PixFmt = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].PixFmt");
				videoStream.Level = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Level");
				videoStream.Fps = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Fps");
				videoStream.AvgFPS = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].AvgFPS");
				videoStream.Timebase = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Timebase");
				videoStream.StartTime = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].StartTime");
				videoStream.Duration = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Duration");
				videoStream.NumFrames = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].NumFrames");
				videoStream.Lang = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Lang");
				videoStream.Rotate = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Rotate");
				videoStream.Bitrate = _ctx.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Bitrate");

				mezzanine_videoStreamList.Add(videoStream);
			}
			mezzanine.VideoStreamList = mezzanine_videoStreamList;
			getMezzanineInfoResponse.Mezzanine = mezzanine;
        
			return getMezzanineInfoResponse;
        }
    }
}
