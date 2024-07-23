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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class SubmitMediaInfoJobResponseUnmarshaller
    {
        public static SubmitMediaInfoJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitMediaInfoJobResponse submitMediaInfoJobResponse = new SubmitMediaInfoJobResponse();

			submitMediaInfoJobResponse.HttpResponse = _ctx.HttpResponse;
			submitMediaInfoJobResponse.RequestId = _ctx.StringValue("SubmitMediaInfoJob.RequestId");

			SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob mediaInfoJob = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob();
			mediaInfoJob.CreationTime = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.CreationTime");
			mediaInfoJob.State = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.State");
			mediaInfoJob.JobId = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.JobId");
			mediaInfoJob.UserData = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.UserData");
			mediaInfoJob.Code = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Code");
			mediaInfoJob.Message = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Message");
			mediaInfoJob.PipelineId = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.PipelineId");
			mediaInfoJob.Async = _ctx.BooleanValue("SubmitMediaInfoJob.MediaInfoJob.Async");

			SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Input input = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Input();
			input._Object = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Input.Object");
			input.Location = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Input.Location");
			input.Bucket = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Input.Bucket");
			mediaInfoJob.Input = input;

			SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_MNSMessageResult mNSMessageResult = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_MNSMessageResult();
			mNSMessageResult.MessageId = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.MNSMessageResult.MessageId");
			mNSMessageResult.ErrorMessage = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.MNSMessageResult.ErrorMessage");
			mNSMessageResult.ErrorCode = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.MNSMessageResult.ErrorCode");
			mediaInfoJob.MNSMessageResult = mNSMessageResult;

			SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties properties = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties();
			properties.Width = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Width");
			properties.Height = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Height");
			properties.Duration = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Duration");
			properties.Fps = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Fps");
			properties.Bitrate = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Bitrate");
			properties.FileFormat = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.FileFormat");
			properties.FileSize = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.FileSize");

			SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams streams = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams();

			List<SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_VideoStream> streams_videoStreamList = new List<SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_VideoStream>();
			for (int i = 0; i < _ctx.Length("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList.Length"); i++) {
				SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_VideoStream videoStream = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_VideoStream();
				videoStream.Sar = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Sar");
				videoStream.Height = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Height");
				videoStream.CodecTagString = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].CodecTagString");
				videoStream.Width = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Width");
				videoStream.Index = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Index");
				videoStream.Timebase = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Timebase");
				videoStream.AvgFPS = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].AvgFPS");
				videoStream.PixFmt = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].PixFmt");
				videoStream.Lang = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Lang");
				videoStream.CodecLongName = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].CodecLongName");
				videoStream.NumFrames = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].NumFrames");
				videoStream.Rotate = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Rotate");
				videoStream.Bitrate = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Bitrate");
				videoStream.HasBFrames = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].HasBFrames");
				videoStream.Profile = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Profile");
				videoStream.StartTime = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].StartTime");
				videoStream.Dar = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Dar");
				videoStream.CodecName = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].CodecName");
				videoStream.Duration = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Duration");
				videoStream.Fps = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Fps");
				videoStream.CodecTag = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].CodecTag");
				videoStream.CodecTimeBase = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].CodecTimeBase");
				videoStream.Level = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Level");
				videoStream.ColorRange = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].ColorRange");
				videoStream.ColorTransfer = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].ColorTransfer");
				videoStream.ColorPrimaries = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].ColorPrimaries");

				SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_VideoStream.SubmitMediaInfoJob_NetworkCost networkCost = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_VideoStream.SubmitMediaInfoJob_NetworkCost();
				networkCost.PreloadTime = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.PreloadTime");
				networkCost.AvgBitrate = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.AvgBitrate");
				networkCost.CostBandwidth = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.CostBandwidth");
				videoStream.NetworkCost = networkCost;

				streams_videoStreamList.Add(videoStream);
			}
			streams.VideoStreamList = streams_videoStreamList;

			List<SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_AudioStream> streams_audioStreamList = new List<SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_AudioStream>();
			for (int i = 0; i < _ctx.Length("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList.Length"); i++) {
				SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_AudioStream audioStream = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_AudioStream();
				audioStream.Timebase = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Timebase");
				audioStream.Index = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Index");
				audioStream.SampleFmt = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].SampleFmt");
				audioStream.ChannelLayout = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].ChannelLayout");
				audioStream.Lang = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Lang");
				audioStream.Samplerate = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Samplerate");
				audioStream.CodecLongName = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].CodecLongName");
				audioStream.Channels = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Channels");
				audioStream.NumFrames = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].NumFrames");
				audioStream.Bitrate = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Bitrate");
				audioStream.CodecTagString = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].CodecTagString");
				audioStream.StartTime = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].StartTime");
				audioStream.CodecName = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].CodecName");
				audioStream.Duration = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Duration");
				audioStream.CodecTag = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].CodecTag");
				audioStream.CodecTimeBase = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].CodecTimeBase");

				streams_audioStreamList.Add(audioStream);
			}
			streams.AudioStreamList = streams_audioStreamList;

			List<SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_SubtitleStream> streams_subtitleStreamList = new List<SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_SubtitleStream>();
			for (int i = 0; i < _ctx.Length("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList.Length"); i++) {
				SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_SubtitleStream subtitleStream = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_SubtitleStream();
				subtitleStream.Timebase = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList["+ i +"].Timebase");
				subtitleStream.Index = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList["+ i +"].Index");
				subtitleStream.StartTime = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList["+ i +"].StartTime");
				subtitleStream.CodecName = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList["+ i +"].CodecName");
				subtitleStream.Lang = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList["+ i +"].Lang");
				subtitleStream.CodecLongName = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList["+ i +"].CodecLongName");
				subtitleStream.Duration = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList["+ i +"].Duration");
				subtitleStream.CodecTag = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList["+ i +"].CodecTag");
				subtitleStream.CodecTimeBase = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList["+ i +"].CodecTimeBase");
				subtitleStream.CodecTagString = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList["+ i +"].CodecTagString");

				streams_subtitleStreamList.Add(subtitleStream);
			}
			streams.SubtitleStreamList = streams_subtitleStreamList;
			properties.Streams = streams;

			SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Format format = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Format();
			format.StartTime = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.StartTime");
			format.NumPrograms = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.NumPrograms");
			format.Size = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.Size");
			format.NumStreams = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.NumStreams");
			format.FormatLongName = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.FormatLongName");
			format.Duration = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.Duration");
			format.Bitrate = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.Bitrate");
			format.FormatName = _ctx.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.FormatName");
			properties.Format = format;
			mediaInfoJob.Properties = properties;
			submitMediaInfoJobResponse.MediaInfoJob = mediaInfoJob;
        
			return submitMediaInfoJobResponse;
        }
    }
}
