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
        public static GetMezzanineInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetMezzanineInfoResponse getMezzanineInfoResponse = new GetMezzanineInfoResponse();

			getMezzanineInfoResponse.HttpResponse = context.HttpResponse;
			getMezzanineInfoResponse.RequestId = context.StringValue("GetMezzanineInfo.RequestId");

			GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine mezzanine = new GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine();
			mezzanine.VideoId = context.StringValue("GetMezzanineInfo.Mezzanine.VideoId");
			mezzanine.Bitrate = context.StringValue("GetMezzanineInfo.Mezzanine.Bitrate");
			mezzanine.CreationTime = context.StringValue("GetMezzanineInfo.Mezzanine.CreationTime");
			mezzanine.Duration = context.StringValue("GetMezzanineInfo.Mezzanine.Duration");
			mezzanine.Fps = context.StringValue("GetMezzanineInfo.Mezzanine.Fps");
			mezzanine.Height = context.LongValue("GetMezzanineInfo.Mezzanine.Height");
			mezzanine.Width = context.LongValue("GetMezzanineInfo.Mezzanine.Width");
			mezzanine.Size = context.LongValue("GetMezzanineInfo.Mezzanine.Size");
			mezzanine.Status = context.StringValue("GetMezzanineInfo.Mezzanine.Status");
			mezzanine.FileURL = context.StringValue("GetMezzanineInfo.Mezzanine.FileURL");
			mezzanine.FileName = context.StringValue("GetMezzanineInfo.Mezzanine.FileName");
			mezzanine.CRC64 = context.StringValue("GetMezzanineInfo.Mezzanine.CRC64");
			mezzanine.PreprocessStatus = context.StringValue("GetMezzanineInfo.Mezzanine.PreprocessStatus");
			mezzanine.OutputType = context.StringValue("GetMezzanineInfo.Mezzanine.OutputType");

			List<GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine.GetMezzanineInfo_AudioStream> mezzanine_audioStreamList = new List<GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine.GetMezzanineInfo_AudioStream>();
			for (int i = 0; i < context.Length("GetMezzanineInfo.Mezzanine.AudioStreamList.Length"); i++) {
				GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine.GetMezzanineInfo_AudioStream audioStream = new GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine.GetMezzanineInfo_AudioStream();
				audioStream.Index = context.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].Index");
				audioStream.CodecName = context.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].CodecName");
				audioStream.CodecLongName = context.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].CodecLongName");
				audioStream.CodecTimeBase = context.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].CodecTimeBase");
				audioStream.CodecTagString = context.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].CodecTagString");
				audioStream.CodecTag = context.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].CodecTag");
				audioStream.SampleFmt = context.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].SampleFmt");
				audioStream.SampleRate = context.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].SampleRate");
				audioStream.Channels = context.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].Channels");
				audioStream.ChannelLayout = context.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].ChannelLayout");
				audioStream.Timebase = context.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].Timebase");
				audioStream.StartTime = context.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].StartTime");
				audioStream.Duration = context.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].Duration");
				audioStream.Bitrate = context.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].Bitrate");
				audioStream.NumFrames = context.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].NumFrames");
				audioStream.Lang = context.StringValue("GetMezzanineInfo.Mezzanine.AudioStreamList["+ i +"].Lang");

				mezzanine_audioStreamList.Add(audioStream);
			}
			mezzanine.AudioStreamList = mezzanine_audioStreamList;

			List<GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine.GetMezzanineInfo_VideoStream> mezzanine_videoStreamList = new List<GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine.GetMezzanineInfo_VideoStream>();
			for (int i = 0; i < context.Length("GetMezzanineInfo.Mezzanine.VideoStreamList.Length"); i++) {
				GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine.GetMezzanineInfo_VideoStream videoStream = new GetMezzanineInfoResponse.GetMezzanineInfo_Mezzanine.GetMezzanineInfo_VideoStream();
				videoStream.Index = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Index");
				videoStream.CodecName = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].CodecName");
				videoStream.CodecLongName = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].CodecLongName");
				videoStream.Profile = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Profile");
				videoStream.CodecTimeBase = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].CodecTimeBase");
				videoStream.CodecTagString = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].CodecTagString");
				videoStream.CodecTag = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].CodecTag");
				videoStream.Width = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Width");
				videoStream.Height = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Height");
				videoStream.HasBFrames = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].HasBFrames");
				videoStream.Sar = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Sar");
				videoStream.Dar = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Dar");
				videoStream.PixFmt = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].PixFmt");
				videoStream.Level = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Level");
				videoStream.Fps = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Fps");
				videoStream.AvgFPS = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].AvgFPS");
				videoStream.Timebase = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Timebase");
				videoStream.StartTime = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].StartTime");
				videoStream.Duration = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Duration");
				videoStream.NumFrames = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].NumFrames");
				videoStream.Lang = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Lang");
				videoStream.Rotate = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Rotate");
				videoStream.Bitrate = context.StringValue("GetMezzanineInfo.Mezzanine.VideoStreamList["+ i +"].Bitrate");

				mezzanine_videoStreamList.Add(videoStream);
			}
			mezzanine.VideoStreamList = mezzanine_videoStreamList;
			getMezzanineInfoResponse.Mezzanine = mezzanine;
        
			return getMezzanineInfoResponse;
        }
    }
}
