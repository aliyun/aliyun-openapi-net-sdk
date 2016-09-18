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

			SubmitMediaInfoJobResponse.MediaInfoJob_ mediaInfoJob = new SubmitMediaInfoJobResponse.MediaInfoJob_();
			mediaInfoJob.JobId = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.JobId");
			mediaInfoJob.UserData = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.UserData");
			mediaInfoJob.PipelineId = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.PipelineId");
			mediaInfoJob.State = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.State");
			mediaInfoJob.Code = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Code");
			mediaInfoJob.Message = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Message");
			mediaInfoJob.CreationTime = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.CreationTime");

			SubmitMediaInfoJobResponse.MediaInfoJob_.Input_ input = new SubmitMediaInfoJobResponse.MediaInfoJob_.Input_();
			input.Bucket = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Input.Bucket");
			input.Location = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Input.Location");
			input.Object = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Input.Object");
			mediaInfoJob.Input = input;

			SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_ properties = new SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_();
			properties.Width = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Width");
			properties.Height = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Height");
			properties.Bitrate = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Bitrate");
			properties.Duration = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Duration");
			properties.Fps = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Fps");
			properties.FileSize = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.FileSize");
			properties.FileFormat = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.FileFormat");

			SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_ streams = new SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_();

			List<SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.VideoStream> videoStreamList = new List<SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.VideoStream>();
			for (int i = 0; i < context.Length("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList.Length"); i++) {
				SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.VideoStream videoStream = new SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.VideoStream();
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

				SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.VideoStream.NetworkCost_();
				networkCost.PreloadTime = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.PreloadTime");
				networkCost.CostBandwidth = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.CostBandwidth");
				networkCost.AvgBitrate = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.AvgBitrate");
				videoStream.NetworkCost = networkCost;

				videoStreamList.Add(videoStream);
			}
			streams.VideoStreamList = videoStreamList;

			List<SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.AudioStream> audioStreamList = new List<SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.AudioStream>();
			for (int i = 0; i < context.Length("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList.Length"); i++) {
				SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.AudioStream audioStream = new SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.AudioStream();
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

				audioStreamList.Add(audioStream);
			}
			streams.AudioStreamList = audioStreamList;

			List<SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.SubtitleStream>();
			for (int i = 0; i < context.Length("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList.Length"); i++) {
				SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.SubtitleStream subtitleStream = new SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.SubtitleStream();
				subtitleStream.Index = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList["+ i +"].Index");
				subtitleStream.Lang = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList["+ i +"].Lang");

				subtitleStreamList.Add(subtitleStream);
			}
			streams.SubtitleStreamList = subtitleStreamList;
			properties.Streams = streams;

			SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Format_ format = new SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Format_();
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

			SubmitMediaInfoJobResponse.MediaInfoJob_.MNSMessageResult_ mNSMessageResult = new SubmitMediaInfoJobResponse.MediaInfoJob_.MNSMessageResult_();
			mNSMessageResult.MessageId = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.MNSMessageResult.MessageId");
			mNSMessageResult.ErrorMessage = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.MNSMessageResult.ErrorMessage");
			mNSMessageResult.ErrorCode = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.MNSMessageResult.ErrorCode");
			mediaInfoJob.MNSMessageResult = mNSMessageResult;
			submitMediaInfoJobResponse.MediaInfoJob = mediaInfoJob;
        
			return submitMediaInfoJobResponse;
        }
    }
}