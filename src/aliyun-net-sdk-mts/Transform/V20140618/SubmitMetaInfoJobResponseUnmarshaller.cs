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
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class SubmitMetaInfoJobResponseUnmarshaller
    {
        public static SubmitMetaInfoJobResponse Unmarshall(UnmarshallerContext context)
        {
            SubmitMetaInfoJobResponse submitMetaInfoJobResponse = new SubmitMetaInfoJobResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("SubmitMetaInfoJob.RequestId")
            };
            SubmitMetaInfoJobResponse.MetaInfoJob_ metaInfoJob = new SubmitMetaInfoJobResponse.MetaInfoJob_()
            {
                JobId = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.JobId"),
                UserData = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.UserData"),
                PipelineId = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.PipelineId"),
                State = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.State"),
                Code = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Code"),
                Message = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Message"),
                CreationTime = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.CreationTime")
            };
            SubmitMetaInfoJobResponse.MetaInfoJob_.Input_ input = new SubmitMetaInfoJobResponse.MetaInfoJob_.Input_()
            {
                Bucket = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Input.Bucket"),
                Location = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Input.Location"),
                Object = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Input.Object")
            };
            metaInfoJob.Input = input;

            SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_ properties = new SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_()
            {
                Width = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Width"),
                Height = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Height"),
                Bitrate = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Bitrate"),
                Duration = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Duration"),
                Fps = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Fps"),
                FileSize = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.FileSize"),
                FileFormat = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.FileFormat")
            };
            SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_ streams = new SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_();

			List<SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.VideoStream> videoStreamList = new List<SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.VideoStream>();
			for (int i = 0; i < context.Length("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList.Length"); i++) {
                SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.VideoStream videoStream = new SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.VideoStream()
                {
                    Index = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].Index"),
                    CodecName = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].CodecName"),
                    CodecLongName = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].CodecLongName"),
                    Profile = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].Profile"),
                    CodecTimeBase = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].CodecTimeBase"),
                    CodecTagString = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].CodecTagString"),
                    CodecTag = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].CodecTag"),
                    Width = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].Width"),
                    Height = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].Height"),
                    HasBFrames = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].HasBFrames"),
                    Sar = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].Sar"),
                    Dar = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].Dar"),
                    PixFmt = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].PixFmt"),
                    Level = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].Level"),
                    Fps = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].Fps"),
                    AvgFps = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].AvgFPS"),
                    Timebase = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].Timebase"),
                    StartTime = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].StartTime"),
                    Duration = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].Duration"),
                    Bitrate = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].Bitrate"),
                    NumFrames = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].NumFrames"),
                    Lang = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].Lang")
                };
                SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.VideoStream.NetworkCost_()
                {
                    PreloadTime = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].NetworkCost.PreloadTime"),
                    CostBandwidth = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].NetworkCost.CostBandwidth"),
                    AvgBitrate = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.VideoStreamList[{i}].NetworkCost.AvgBitrate")
                };
                videoStream.NetworkCost = networkCost;

				videoStreamList.Add(videoStream);
			}
			streams.VideoStreamList = videoStreamList;

			List<SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.AudioStream> audioStreamList = new List<SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.AudioStream>();
			for (int i = 0; i < context.Length("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList.Length"); i++) {
                SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.AudioStream audioStream = new SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.AudioStream()
                {
                    Index = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList[{i}].Index"),
                    CodecName = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList[{i}].CodecName"),
                    CodecTimeBase = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList[{i}].CodecTimeBase"),
                    CodecLongName = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList[{i}].CodecLongName"),
                    CodecTagString = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList[{i}].CodecTagString"),
                    CodecTag = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList[{i}].CodecTag"),
                    SampleFmt = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList[{i}].SampleFmt"),
                    Samplerate = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList[{i}].Samplerate"),
                    Channels = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList[{i}].Channels"),
                    ChannelLayout = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList[{i}].ChannelLayout"),
                    Timebase = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList[{i}].Timebase"),
                    StartTime = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList[{i}].StartTime"),
                    Duration = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList[{i}].Duration"),
                    Bitrate = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList[{i}].Bitrate"),
                    NumFrames = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList[{i}].NumFrames"),
                    Lang = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.AudioStreamList[{i}].Lang")
                };
                audioStreamList.Add(audioStream);
			}
			streams.AudioStreamList = audioStreamList;

			List<SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.SubtitleStream>();
			for (int i = 0; i < context.Length("SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.SubtitleStreamList.Length"); i++) {
                SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.SubtitleStream subtitleStream = new SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Streams_.SubtitleStream()
                {
                    Index = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.SubtitleStreamList[{i}].Index"),
                    Lang = context.StringValue($"SubmitMetaInfoJob.MetaInfoJob.Properties.Streams.SubtitleStreamList[{i}].Lang")
                };
                subtitleStreamList.Add(subtitleStream);
			}
			streams.SubtitleStreamList = subtitleStreamList;
			properties.Streams = streams;

            SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Format_ format = new SubmitMetaInfoJobResponse.MetaInfoJob_.Properties_.Format_()
            {
                NumStreams = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Format.NumStreams"),
                NumPrograms = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Format.NumPrograms"),
                FormatName = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Format.FormatName"),
                FormatLongName = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Format.FormatLongName"),
                StartTime = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Format.StartTime"),
                Duration = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Format.Duration"),
                Size = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Format.Size"),
                Bitrate = context.StringValue("SubmitMetaInfoJob.MetaInfoJob.Properties.Format.Bitrate")
            };
            properties.Format = format;
			metaInfoJob.Properties = properties;
			submitMetaInfoJobResponse.MetaInfoJob = metaInfoJob;
        
			return submitMetaInfoJobResponse;
        }
    }
}