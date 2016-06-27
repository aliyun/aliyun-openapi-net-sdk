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
    public class SubmitMetaInfoJobResponseUnmarshaller
    {
        public static SubmitMetaInfoJobResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitMetaInfoJobResponse submitMetaInfoJobResponse = new SubmitMetaInfoJobResponse();

			submitMetaInfoJobResponse.HttpResponse = context.HttpResponse;
			submitMetaInfoJobResponse.RequestId = context.StringValue("SubmitMetaInfoJob.RequestId");

			SubmitMetaInfoJobResponse.MetaInfoJob_ metaInfoJob = new SubmitMetaInfoJobResponse.MetaInfoJob_();
			metaInfoJob.JobId = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.JobId");
			metaInfoJob.UserData = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.UserData");
			metaInfoJob.PipelineId = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.PipelineId");
			metaInfoJob.State = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.State");
			metaInfoJob.Code = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Code");
			metaInfoJob.Message = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Message");
			metaInfoJob.CreationTime = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.CreationTime");

			SubmitMetaInfoJobResponse.MetaInfoJob_.Input_ input = new SubmitMetaInfoJobResponse.MetaInfoJob_.Input_();
			input.Bucket = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Input.Bucket");
			input.Location = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Input.Location");
			input.Object = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Input.Object");
			metaInfoJob.Input = input;

			SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_ properties = new SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_();
			properties.Width = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Width");
			properties.Height = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Height");
			properties.Bitrate = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Bitrate");
			properties.Duration = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Duration");
			properties.Fps = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Fps");
			properties.FileSize = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.FileSize");
			properties.FileFormat = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.FileFormat");

			SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_ streams = new SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_();

			List<SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.VideoStream> videoStreamList = new List<SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.VideoStream>();
			for (int i = 0; i < context.Length("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList.Length"); i++) {
				SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.VideoStream videoStream = new SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.VideoStream();
				videoStream.Index = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Index");
				videoStream.CodecName = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].CodecName");
				videoStream.CodecLongName = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].CodecLongName");
				videoStream.Profile = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Profile");
				videoStream.CodecTimeBase = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].CodecTimeBase");
				videoStream.CodecTagString = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].CodecTagString");
				videoStream.CodecTag = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].CodecTag");
				videoStream.Width = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Width");
				videoStream.Height = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Height");
				videoStream.HasBFrames = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].HasBFrames");
				videoStream.Sar = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Sar");
				videoStream.Dar = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Dar");
				videoStream.PixFmt = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].PixFmt");
				videoStream.Level = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Level");
				videoStream.Fps = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Fps");
				videoStream.AvgFPS = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].AvgFPS");
				videoStream.Timebase = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Timebase");
				videoStream.StartTime = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].StartTime");
				videoStream.Duration = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Duration");
				videoStream.Bitrate = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Bitrate");
				videoStream.NumFrames = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].NumFrames");
				videoStream.Lang = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].Lang");

				SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.VideoStream.NetworkCost_();
				networkCost.PreloadTime = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.PreloadTime");
				networkCost.CostBandwidth = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.CostBandwidth");
				networkCost.AvgBitrate = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.AvgBitrate");
				videoStream.NetworkCost = networkCost;

				videoStreamList.Add(videoStream);
			}
			streams.VideoStreamList = videoStreamList;

			List<SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.AudioStream> audioStreamList = new List<SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.AudioStream>();
			for (int i = 0; i < context.Length("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList.Length"); i++) {
				SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.AudioStream audioStream = new SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.AudioStream();
				audioStream.Index = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Index");
				audioStream.CodecName = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList["+ i +"].CodecName");
				audioStream.CodecTimeBase = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList["+ i +"].CodecTimeBase");
				audioStream.CodecLongName = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList["+ i +"].CodecLongName");
				audioStream.CodecTagString = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList["+ i +"].CodecTagString");
				audioStream.CodecTag = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList["+ i +"].CodecTag");
				audioStream.SampleFmt = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList["+ i +"].SampleFmt");
				audioStream.Samplerate = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Samplerate");
				audioStream.Channels = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Channels");
				audioStream.ChannelLayout = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList["+ i +"].ChannelLayout");
				audioStream.Timebase = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Timebase");
				audioStream.StartTime = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList["+ i +"].StartTime");
				audioStream.Duration = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Duration");
				audioStream.Bitrate = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Bitrate");
				audioStream.NumFrames = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList["+ i +"].NumFrames");
				audioStream.Lang = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList["+ i +"].Lang");

				audioStreamList.Add(audioStream);
			}
			streams.AudioStreamList = audioStreamList;

			List<SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.SubtitleStream>();
			for (int i = 0; i < context.Length("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.SubtitleStreamList.Length"); i++) {
				SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.SubtitleStream subtitleStream = new SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.SubtitleStream();
				subtitleStream.Index = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.SubtitleStreamList["+ i +"].Index");
				subtitleStream.Lang = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.SubtitleStreamList["+ i +"].Lang");

				subtitleStreamList.Add(subtitleStream);
			}
			streams.SubtitleStreamList = subtitleStreamList;
			properties.Streams = streams;

			SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Format_ format = new SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Format_();
			format.NumStreams = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Format.NumStreams");
			format.NumPrograms = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Format.NumPrograms");
			format.FormatName = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Format.FormatName");
			format.FormatLongName = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Format.FormatLongName");
			format.StartTime = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Format.StartTime");
			format.Duration = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Format.Duration");
			format.Size = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Format.Size");
			format.Bitrate = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Format.Bitrate");
			properties.Format = format;
			metaInfoJob.Properties = properties;
			submitMetaInfoJobResponse.MetaInfoJob = metaInfoJob;
        
			return submitMetaInfoJobResponse;
        }
    }
}