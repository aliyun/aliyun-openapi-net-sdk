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
    public class QueryMetaInfoJobListResponseUnmarshaller
    {
        public static QueryMetaInfoJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMetaInfoJobListResponse queryMetaInfoJobListResponse = new QueryMetaInfoJobListResponse();

			queryMetaInfoJobListResponse.HttpResponse = context.HttpResponse;
			queryMetaInfoJobListResponse.RequestId = context.StringValue("QueryMetaInfoJobList.RequestId");

			List<string> nonExistMetaInfoJobIds = new List<string>();
			for (int i = 0; i < context.Length("QueryMetaInfoJobList.NonExistMetaInfoJobIds.Length"); i++) {
				nonExistMetaInfoJobIds.Add(context.StringValue("QueryMetaInfoJobList.NonExistMetaInfoJobIds["+ i +"]"));
			}
			queryMetaInfoJobListResponse.NonExistMetaInfoJobIds = nonExistMetaInfoJobIds;

			List<QueryMetaInfoJobListResponse.MetaInfoJob> metaInfoJobList = new List<QueryMetaInfoJobListResponse.MetaInfoJob>();
			for (int i = 0; i < context.Length("QueryMetaInfoJobList.MetaInfoJobList.Length"); i++) {
				QueryMetaInfoJobListResponse.MetaInfoJob metaInfoJob = new QueryMetaInfoJobListResponse.MetaInfoJob();
				metaInfoJob.JobId = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].JobId");
				metaInfoJob.UserData = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].UserData");
				metaInfoJob.PipelineId = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].PipelineId");
				metaInfoJob.State = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].State");
				metaInfoJob.Code = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Code");
				metaInfoJob.Message = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Message");
				metaInfoJob.CreationTime = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].CreationTime");

				QueryMetaInfoJobListResponse.MetaInfoJob.Input_ input = new QueryMetaInfoJobListResponse.MetaInfoJob.Input_();
				input.Bucket = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Input.Location");
				input.Object = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Input.Object");
				metaInfoJob.Input = input;

				QueryMetaInfoJobListResponse.MetaInfoJob.Properties_ properties = new QueryMetaInfoJobListResponse.MetaInfoJob.Properties_();
				properties.Width = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Width");
				properties.Height = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Height");
				properties.Bitrate = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Bitrate");
				properties.Duration = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Duration");
				properties.Fps = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Fps");
				properties.FileSize = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.FileSize");
				properties.FileFormat = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.FileFormat");

				QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_ streams = new QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_();

				List<QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.VideoStream> videoStreamList = new List<QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList.Length"); j++) {
					QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.VideoStream videoStream = new QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.VideoStream();
					videoStream.Index = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.CodecName = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.CodecLongName = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Profile = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.CodecTimeBase = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.CodecTagString = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.CodecTag = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.Width = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Height = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.HasBFrames = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Sar = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Dar = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.PixFmt = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Level = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Level");
					videoStream.Fps = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.AvgFPS = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.Timebase = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.StartTime = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Duration = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Bitrate = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.NumFrames = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Lang = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Lang");

					QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.VideoStream.NetworkCost_();
					networkCost.PreloadTime = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.AudioStream> audioStreamList = new List<QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList.Length"); j++) {
					QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.AudioStream audioStream = new QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.AudioStream();
					audioStream.Index = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.CodecName = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.CodecTimeBase = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.CodecLongName = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.CodecTagString = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.CodecTag = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.SampleFmt = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.Samplerate = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.Channels = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.ChannelLayout = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Timebase = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.StartTime = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.Duration = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.Bitrate = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.NumFrames = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Lang = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Lang");

					audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList.Length"); j++) {
					QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.SubtitleStream subtitleStream = new QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Streams_.SubtitleStream();
					subtitleStream.Index = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				properties.Streams = streams;

				QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Format_ format = new QueryMetaInfoJobListResponse.MetaInfoJob.Properties_.Format_();
				format.NumStreams = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Format.NumStreams");
				format.NumPrograms = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Format.NumPrograms");
				format.FormatName = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Format.FormatName");
				format.FormatLongName = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Format.FormatLongName");
				format.StartTime = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Format.StartTime");
				format.Duration = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Format.Duration");
				format.Size = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Format.Size");
				format.Bitrate = context.StringValue("QueryMetaInfoJobList.MetaInfoJobList["+ i +"].Properties.Format.Bitrate");
				properties.Format = format;
				metaInfoJob.Properties = properties;

				metaInfoJobList.Add(metaInfoJob);
			}
			queryMetaInfoJobListResponse.MetaInfoJobList = metaInfoJobList;
        
			return queryMetaInfoJobListResponse;
        }
    }
}