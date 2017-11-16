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
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class SubmitMediaInfoJobResponseUnmarshaller
    {
        public static SubmitMediaInfoJobResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitMediaInfoJobResponse submitMediaInfoJobResponse = new SubmitMediaInfoJobResponse();

			submitMediaInfoJobResponse.HttpResponse = context.HttpResponse;
			submitMediaInfoJobResponse.RequestId = context.StringValue("SubmitMediaInfoJob.RequestId");

			SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob mediaInfoJob = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob();
			mediaInfoJob.JobId = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.JobId");
			mediaInfoJob.UserData = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.UserData");
			mediaInfoJob.PipelineId = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.PipelineId");
			mediaInfoJob.State = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.State");
			mediaInfoJob.Code = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Code");
			mediaInfoJob.Message = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Message");
			mediaInfoJob.CreationTime = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.CreationTime");

			SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Input input = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Input();
			input.Bucket = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Input.Bucket");
			input.Location = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Input.Location");
			input._Object = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Input.Object");
			mediaInfoJob.Input = input;

			SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties properties = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties();
			properties.Width = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Width");
			properties.Height = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Height");
			properties.Bitrate = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Bitrate");
			properties.Duration = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Duration");
			properties.Fps = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Fps");
			properties.FileSize = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.FileSize");
			properties.FileFormat = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.FileFormat");

			SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams streams = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams();

			List<SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_VideoStream> streams_videoStreamList = new List<SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_VideoStream>();
			for (int i = 0; i < context.Length("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList.Length"); i++) {
				SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_VideoStream videoStream = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_VideoStream();
				videoStream.Index = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Index");
				videoStream.CodecName = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].CodecName");
				videoStream.CodecLongName = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].CodecLongName");
				videoStream.Profile = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Profile");
				videoStream.CodecTimeBase = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].CodecTimeBase");
				videoStream.CodecTagString = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].CodecTagString");
				videoStream.CodecTag = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].CodecTag");
				videoStream.Width = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Width");
				videoStream.Height = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Height");
				videoStream.HasBFrames = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].HasBFrames");
				videoStream.Sar = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Sar");
				videoStream.Dar = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Dar");
				videoStream.PixFmt = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].PixFmt");
				videoStream.Level = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Level");
				videoStream.Fps = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Fps");
				videoStream.AvgFPS = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].AvgFPS");
				videoStream.Timebase = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Timebase");
				videoStream.StartTime = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].StartTime");
				videoStream.Duration = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Duration");
				videoStream.Bitrate = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Bitrate");
				videoStream.NumFrames = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].NumFrames");
				videoStream.Lang = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Lang");
				videoStream.Rotate = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Rotate");

				SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_VideoStream.SubmitMediaInfoJob_NetworkCost networkCost = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_VideoStream.SubmitMediaInfoJob_NetworkCost();
				networkCost.PreloadTime = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.PreloadTime");
				networkCost.CostBandwidth = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.CostBandwidth");
				networkCost.AvgBitrate = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.AvgBitrate");
				videoStream.NetworkCost = networkCost;

				streams_videoStreamList.Add(videoStream);
			}
			streams.VideoStreamList = streams_videoStreamList;

			List<SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_AudioStream> streams_audioStreamList = new List<SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_AudioStream>();
			for (int i = 0; i < context.Length("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList.Length"); i++) {
				SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_AudioStream audioStream = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_AudioStream();
				audioStream.Index = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Index");
				audioStream.CodecName = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].CodecName");
				audioStream.CodecTimeBase = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].CodecTimeBase");
				audioStream.CodecLongName = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].CodecLongName");
				audioStream.CodecTagString = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].CodecTagString");
				audioStream.CodecTag = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].CodecTag");
				audioStream.SampleFmt = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].SampleFmt");
				audioStream.Samplerate = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Samplerate");
				audioStream.Channels = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Channels");
				audioStream.ChannelLayout = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].ChannelLayout");
				audioStream.Timebase = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Timebase");
				audioStream.StartTime = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].StartTime");
				audioStream.Duration = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Duration");
				audioStream.Bitrate = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Bitrate");
				audioStream.NumFrames = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].NumFrames");
				audioStream.Lang = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Lang");

				streams_audioStreamList.Add(audioStream);
			}
			streams.AudioStreamList = streams_audioStreamList;

			List<SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_SubtitleStream> streams_subtitleStreamList = new List<SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_SubtitleStream>();
			for (int i = 0; i < context.Length("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList.Length"); i++) {
				SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_SubtitleStream subtitleStream = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Streams.SubmitMediaInfoJob_SubtitleStream();
				subtitleStream.Index = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList["+ i +"].Index");
				subtitleStream.Lang = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList["+ i +"].Lang");

				streams_subtitleStreamList.Add(subtitleStream);
			}
			streams.SubtitleStreamList = streams_subtitleStreamList;
			properties.Streams = streams;

			SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Format format = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_Properties.SubmitMediaInfoJob_Format();
			format.NumStreams = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.NumStreams");
			format.NumPrograms = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.NumPrograms");
			format.FormatName = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.FormatName");
			format.FormatLongName = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.FormatLongName");
			format.StartTime = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.StartTime");
			format.Duration = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.Duration");
			format.Size = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.Size");
			format.Bitrate = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.Bitrate");
			properties.Format = format;
			mediaInfoJob.Properties = properties;

			SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_MNSMessageResult mNSMessageResult = new SubmitMediaInfoJobResponse.SubmitMediaInfoJob_MediaInfoJob.SubmitMediaInfoJob_MNSMessageResult();
			mNSMessageResult.MessageId = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.MNSMessageResult.MessageId");
			mNSMessageResult.ErrorMessage = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.MNSMessageResult.ErrorMessage");
			mNSMessageResult.ErrorCode = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.MNSMessageResult.ErrorCode");
			mediaInfoJob.MNSMessageResult = mNSMessageResult;
			submitMediaInfoJobResponse.MediaInfoJob = mediaInfoJob;
        
			return submitMediaInfoJobResponse;
        }
    }
}