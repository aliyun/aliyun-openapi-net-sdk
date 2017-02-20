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
    public class QueryMetaInfoJobListResponseUnmarshaller
    {
        public static QueryMetaInfoJobListResponse Unmarshall(UnmarshallerContext context)
        {
            QueryMetaInfoJobListResponse queryMetaInfoJobListResponse = new QueryMetaInfoJobListResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryMetaInfoJobList.RequestId")
            };
            List<string> nonExistMetaInfoJobIds = new List<string>();
			for (int i = 0; i < context.Length("QueryMetaInfoJobList.NonExistMetaInfoJobIds.Length"); i++) {
				nonExistMetaInfoJobIds.Add(context.StringValue($"QueryMetaInfoJobList.NonExistMetaInfoJobIds[{i}]"));
			}
			queryMetaInfoJobListResponse.NonExistMetaInfoJobIds = nonExistMetaInfoJobIds;

			List<QueryMetaInfoJobListResponse.MetaInfoJob> metaInfoJobList = new List<QueryMetaInfoJobListResponse.MetaInfoJob>();
			for (int i = 0; i < context.Length("QueryMetaInfoJobList.MetaInfoJobList.Length"); i++) {
                QueryMetaInfoJobListResponse.MetaInfoJob metaInfoJob = new QueryMetaInfoJobListResponse.MetaInfoJob()
                {
                    JobId = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].JobId"),
                    UserData = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].UserData"),
                    PipelineId = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].PipelineId"),
                    State = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].State"),
                    Code = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Code"),
                    Message = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Message"),
                    CreationTime = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].CreationTime")
                };
                QueryMetaInfoJobListResponse.MetaInfoJob.Input_ input = new QueryMetaInfoJobListResponse.MetaInfoJob.Input_()
                {
                    Bucket = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Input.Bucket"),
                    Location = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Input.Location"),
                    Object = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Input.Object")
                };
                metaInfoJob.Input = input;

                QueryMetaInfoJobListResponse.MetaInfoJob.Properties_ properties = new QueryMetaInfoJobListResponse.MetaInfoJob.Properties_()
                {
                    Width = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Width"),
                    Height = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Height"),
                    Bitrate = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Bitrate"),
                    Duration = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Duration"),
                    Fps = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Fps"),
                    FileSize = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.FileSize"),
                    FileFormat = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.FileFormat")
                };
                QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_ streams = new QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_();

				List<QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.VideoStream> videoStreamList = new List<QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList.Length"); j++) {
                    QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.VideoStream videoStream = new QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.VideoStream()
                    {
                        Index = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Index"),
                        CodecName = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].CodecName"),
                        CodecLongName = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].CodecLongName"),
                        Profile = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Profile"),
                        CodecTimeBase = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].CodecTimeBase"),
                        CodecTagString = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].CodecTag"),
                        Width = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Width"),
                        Height = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Height"),
                        HasBFrames = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].HasBFrames"),
                        Sar = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Sar"),
                        Dar = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Dar"),
                        PixFmt = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].PixFmt"),
                        Level = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Level"),
                        Fps = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Fps"),
                        AvgFps = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].AvgFPS"),
                        Timebase = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].Lang")
                    };
                    QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.VideoStream.NetworkCost_()
                    {
                        PreloadTime = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].NetworkCost.PreloadTime"),
                        CostBandwidth = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].NetworkCost.CostBandwidth"),
                        AvgBitrate = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.VideoStreamList[{j}].NetworkCost.AvgBitrate")
                    };
                    videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.AudioStream> audioStreamList = new List<QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList.Length"); j++) {
                    QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.AudioStream audioStream = new QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.AudioStream()
                    {
                        Index = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].Index"),
                        CodecName = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].CodecName"),
                        CodecTimeBase = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].CodecTimeBase"),
                        CodecLongName = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].CodecLongName"),
                        CodecTagString = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].CodecTag"),
                        SampleFmt = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].SampleFmt"),
                        Samplerate = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].Samplerate"),
                        Channels = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].Channels"),
                        ChannelLayout = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].ChannelLayout"),
                        Timebase = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.AudioStreamList[{j}].Lang")
                    };
                    audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.SubtitleStreamList.Length"); j++) {
                    QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.SubtitleStream subtitleStream = new QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.SubtitleStream()
                    {
                        Index = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.SubtitleStreamList[{j}].Index"),
                        Lang = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Streams.SubtitleStreamList[{j}].Lang")
                    };
                    subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				properties.Streams = streams;

                QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Format_ format = new QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Format_()
                {
                    NumStreams = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Format.NumStreams"),
                    NumPrograms = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Format.NumPrograms"),
                    FormatName = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Format.FormatName"),
                    FormatLongName = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Format.FormatLongName"),
                    StartTime = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Format.StartTime"),
                    Duration = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Format.Duration"),
                    Size = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Format.Size"),
                    Bitrate = context.StringValue($"QueryMetaInfoJobList.MetaInfoJobList[{i}].Properties.Format.Bitrate")
                };
                properties.Format = format;
				metaInfoJob.Properties = properties;

				metaInfoJobList.Add(metaInfoJob);
			}
			queryMetaInfoJobListResponse.MetaInfoJobList = metaInfoJobList;
        
			return queryMetaInfoJobListResponse;
        }
    }
}