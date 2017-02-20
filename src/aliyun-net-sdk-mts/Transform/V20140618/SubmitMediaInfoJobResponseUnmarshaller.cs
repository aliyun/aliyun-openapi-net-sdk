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
    public class SubmitMediaInfoJobResponseUnmarshaller
    {
        public static SubmitMediaInfoJobResponse Unmarshall(UnmarshallerContext context)
        {
            SubmitMediaInfoJobResponse submitMediaInfoJobResponse = new SubmitMediaInfoJobResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("SubmitMediaInfoJob.RequestId")
            };
            SubmitMediaInfoJobResponse.MediaInfoJob_ mediaInfoJob = new SubmitMediaInfoJobResponse.MediaInfoJob_()
            {
                JobId = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.JobId"),
                UserData = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.UserData"),
                PipelineId = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.PipelineId"),
                State = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.State"),
                Code = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Code"),
                Message = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Message"),
                CreationTime = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.CreationTime")
            };
            SubmitMediaInfoJobResponse.MediaInfoJob_.Input_ input = new SubmitMediaInfoJobResponse.MediaInfoJob_.Input_()
            {
                Bucket = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Input.Bucket"),
                Location = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Input.Location"),
                Object = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Input.Object")
            };
            mediaInfoJob.Input = input;

            SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_ properties = new SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_()
            {
                Width = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Width"),
                Height = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Height"),
                Bitrate = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Bitrate"),
                Duration = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Duration"),
                Fps = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Fps"),
                FileSize = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.FileSize"),
                FileFormat = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.FileFormat")
            };
            SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_ streams = new SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_();

			List<SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.VideoStream> videoStreamList = new List<SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.VideoStream>();
			for (int i = 0; i < context.Length("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList.Length"); i++) {
                SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.VideoStream videoStream = new SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.VideoStream()
                {
                    Index = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].Index"),
                    CodecName = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].CodecName"),
                    CodecLongName = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].CodecLongName"),
                    Profile = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].Profile"),
                    CodecTimeBase = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].CodecTimeBase"),
                    CodecTagString = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].CodecTagString"),
                    CodecTag = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].CodecTag"),
                    Width = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].Width"),
                    Height = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].Height"),
                    HasBFrames = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].HasBFrames"),
                    Sar = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].Sar"),
                    Dar = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].Dar"),
                    PixFmt = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].PixFmt"),
                    Level = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].Level"),
                    Fps = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].Fps"),
                    AvgFps = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].AvgFPS"),
                    Timebase = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].Timebase"),
                    StartTime = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].StartTime"),
                    Duration = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].Duration"),
                    Bitrate = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].Bitrate"),
                    NumFrames = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].NumFrames"),
                    Lang = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].Lang"),
                    Rotate = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].Rotate")
                };
                SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.VideoStream.NetworkCost_()
                {
                    PreloadTime = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].NetworkCost.PreloadTime"),
                    CostBandwidth = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].NetworkCost.CostBandwidth"),
                    AvgBitrate = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.VideoStreamList[{i}].NetworkCost.AvgBitrate")
                };
                videoStream.NetworkCost = networkCost;

				videoStreamList.Add(videoStream);
			}
			streams.VideoStreamList = videoStreamList;

			List<SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.AudioStream> audioStreamList = new List<SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.AudioStream>();
			for (int i = 0; i < context.Length("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList.Length"); i++) {
                SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.AudioStream audioStream = new SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.AudioStream()
                {
                    Index = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList[{i}].Index"),
                    CodecName = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList[{i}].CodecName"),
                    CodecTimeBase = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList[{i}].CodecTimeBase"),
                    CodecLongName = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList[{i}].CodecLongName"),
                    CodecTagString = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList[{i}].CodecTagString"),
                    CodecTag = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList[{i}].CodecTag"),
                    SampleFmt = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList[{i}].SampleFmt"),
                    Samplerate = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList[{i}].Samplerate"),
                    Channels = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList[{i}].Channels"),
                    ChannelLayout = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList[{i}].ChannelLayout"),
                    Timebase = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList[{i}].Timebase"),
                    StartTime = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList[{i}].StartTime"),
                    Duration = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList[{i}].Duration"),
                    Bitrate = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList[{i}].Bitrate"),
                    NumFrames = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList[{i}].NumFrames"),
                    Lang = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.AudioStreamList[{i}].Lang")
                };
                audioStreamList.Add(audioStream);
			}
			streams.AudioStreamList = audioStreamList;

			List<SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.SubtitleStream>();
			for (int i = 0; i < context.Length("SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList.Length"); i++) {
                SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.SubtitleStream subtitleStream = new SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Streams_.SubtitleStream()
                {
                    Index = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList[{i}].Index"),
                    Lang = context.StringValue($"SubmitMediaInfoJob.MediaInfoJob.Properties.Streams.SubtitleStreamList[{i}].Lang")
                };
                subtitleStreamList.Add(subtitleStream);
			}
			streams.SubtitleStreamList = subtitleStreamList;
			properties.Streams = streams;

            SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Format_ format = new SubmitMediaInfoJobResponse.MediaInfoJob_.Properties_.Format_()
            {
                NumStreams = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.NumStreams"),
                NumPrograms = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.NumPrograms"),
                FormatName = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.FormatName"),
                FormatLongName = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.FormatLongName"),
                StartTime = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.StartTime"),
                Duration = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.Duration"),
                Size = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.Size"),
                Bitrate = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.Properties.Format.Bitrate")
            };
            properties.Format = format;
			mediaInfoJob.Properties = properties;

            SubmitMediaInfoJobResponse.MediaInfoJob_.MnsMessageResult_ mNsMessageResult = new SubmitMediaInfoJobResponse.MediaInfoJob_.MnsMessageResult_()
            {
                MessageId = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.MNSMessageResult.MessageId"),
                ErrorMessage = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.MNSMessageResult.ErrorMessage"),
                ErrorCode = context.StringValue("SubmitMediaInfoJob.MediaInfoJob.MNSMessageResult.ErrorCode")
            };
            mediaInfoJob.MnsMessageResult = mNsMessageResult;
			submitMediaInfoJobResponse.MediaInfoJob = mediaInfoJob;
        
			return submitMediaInfoJobResponse;
        }
    }
}