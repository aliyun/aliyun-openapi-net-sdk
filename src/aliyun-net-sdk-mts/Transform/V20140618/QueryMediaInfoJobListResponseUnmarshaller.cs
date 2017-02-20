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
    public class QueryMediaInfoJobListResponseUnmarshaller
    {
        public static QueryMediaInfoJobListResponse Unmarshall(UnmarshallerContext context)
        {
            QueryMediaInfoJobListResponse queryMediaInfoJobListResponse = new QueryMediaInfoJobListResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryMediaInfoJobList.RequestId")
            };
            List<string> nonExistMediaInfoJobIds = new List<string>();
			for (int i = 0; i < context.Length("QueryMediaInfoJobList.NonExistMediaInfoJobIds.Length"); i++) {
				nonExistMediaInfoJobIds.Add(context.StringValue($"QueryMediaInfoJobList.NonExistMediaInfoJobIds[{i}]"));
			}
			queryMediaInfoJobListResponse.NonExistMediaInfoJobIds = nonExistMediaInfoJobIds;

			List<QueryMediaInfoJobListResponse.MediaInfoJob> mediaInfoJobList = new List<QueryMediaInfoJobListResponse.MediaInfoJob>();
			for (int i = 0; i < context.Length("QueryMediaInfoJobList.MediaInfoJobList.Length"); i++) {
                QueryMediaInfoJobListResponse.MediaInfoJob mediaInfoJob = new QueryMediaInfoJobListResponse.MediaInfoJob()
                {
                    JobId = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].JobId"),
                    UserData = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].UserData"),
                    PipelineId = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].PipelineId"),
                    State = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].State"),
                    Code = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Code"),
                    Message = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Message"),
                    CreationTime = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].CreationTime")
                };
                QueryMediaInfoJobListResponse.MediaInfoJob.Input_ input = new QueryMediaInfoJobListResponse.MediaInfoJob.Input_()
                {
                    Bucket = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Input.Bucket"),
                    Location = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Input.Location"),
                    Object = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Input.Object")
                };
                mediaInfoJob.Input = input;

                QueryMediaInfoJobListResponse.MediaInfoJob.Properties_ properties = new QueryMediaInfoJobListResponse.MediaInfoJob.Properties_()
                {
                    Width = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Width"),
                    Height = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Height"),
                    Bitrate = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Bitrate"),
                    Duration = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Duration"),
                    Fps = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Fps"),
                    FileSize = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.FileSize"),
                    FileFormat = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.FileFormat")
                };
                QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Streams_ streams = new QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Streams_();

				List<QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Streams_.VideoStream> videoStreamList = new List<QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList.Length"); j++) {
                    QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Streams_.VideoStream videoStream = new QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Streams_.VideoStream()
                    {
                        Index = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Index"),
                        CodecName = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].CodecName"),
                        CodecLongName = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].CodecLongName"),
                        Profile = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Profile"),
                        CodecTimeBase = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].CodecTimeBase"),
                        CodecTagString = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].CodecTag"),
                        Width = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Width"),
                        Height = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Height"),
                        HasBFrames = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].HasBFrames"),
                        Sar = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Sar"),
                        Dar = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Dar"),
                        PixFmt = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].PixFmt"),
                        Level = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Level"),
                        Fps = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Fps"),
                        AvgFps = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].AvgFPS"),
                        Timebase = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Lang"),
                        Rotate = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Rotate")
                    };
                    QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Streams_.VideoStream.NetworkCost_()
                    {
                        PreloadTime = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].NetworkCost.PreloadTime"),
                        CostBandwidth = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].NetworkCost.CostBandwidth"),
                        AvgBitrate = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].NetworkCost.AvgBitrate")
                    };
                    videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Streams_.AudioStream> audioStreamList = new List<QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList.Length"); j++) {
                    QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Streams_.AudioStream audioStream = new QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Streams_.AudioStream()
                    {
                        Index = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].Index"),
                        CodecName = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].CodecName"),
                        CodecTimeBase = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].CodecTimeBase"),
                        CodecLongName = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].CodecLongName"),
                        CodecTagString = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].CodecTag"),
                        SampleFmt = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].SampleFmt"),
                        Samplerate = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].Samplerate"),
                        Channels = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].Channels"),
                        ChannelLayout = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].ChannelLayout"),
                        Timebase = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].Lang")
                    };
                    audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.SubtitleStreamList.Length"); j++) {
                    QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Streams_.SubtitleStream subtitleStream = new QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Streams_.SubtitleStream()
                    {
                        Index = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.SubtitleStreamList[{j}].Index"),
                        Lang = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Streams.SubtitleStreamList[{j}].Lang")
                    };
                    subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				properties.Streams = streams;

                QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Format_ format = new QueryMediaInfoJobListResponse.MediaInfoJob.Properties_.Format_()
                {
                    NumStreams = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Format.NumStreams"),
                    NumPrograms = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Format.NumPrograms"),
                    FormatName = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Format.FormatName"),
                    FormatLongName = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Format.FormatLongName"),
                    StartTime = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Format.StartTime"),
                    Duration = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Format.Duration"),
                    Size = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Format.Size"),
                    Bitrate = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].Properties.Format.Bitrate")
                };
                properties.Format = format;
				mediaInfoJob.Properties = properties;

                QueryMediaInfoJobListResponse.MediaInfoJob.MnsMessageResult_ mNsMessageResult = new QueryMediaInfoJobListResponse.MediaInfoJob.MnsMessageResult_()
                {
                    MessageId = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].MNSMessageResult.MessageId"),
                    ErrorMessage = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].MNSMessageResult.ErrorMessage"),
                    ErrorCode = context.StringValue($"QueryMediaInfoJobList.MediaInfoJobList[{i}].MNSMessageResult.ErrorCode")
                };
                mediaInfoJob.MnsMessageResult = mNsMessageResult;

				mediaInfoJobList.Add(mediaInfoJob);
			}
			queryMediaInfoJobListResponse.MediaInfoJobList = mediaInfoJobList;
        
			return queryMediaInfoJobListResponse;
        }
    }
}