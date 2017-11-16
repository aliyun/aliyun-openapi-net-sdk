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
    public class QueryMediaInfoJobListResponseUnmarshaller
    {
        public static QueryMediaInfoJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMediaInfoJobListResponse queryMediaInfoJobListResponse = new QueryMediaInfoJobListResponse();

			queryMediaInfoJobListResponse.HttpResponse = context.HttpResponse;
			queryMediaInfoJobListResponse.RequestId = context.StringValue("QueryMediaInfoJobList.RequestId");

			List<string> queryMediaInfoJobListResponse_nonExistMediaInfoJobIds = new List<string>();
			for (int i = 0; i < context.Length("QueryMediaInfoJobList.NonExistMediaInfoJobIds.Length"); i++) {
				queryMediaInfoJobListResponse_nonExistMediaInfoJobIds.Add(context.StringValue("QueryMediaInfoJobList.NonExistMediaInfoJobIds["+ i +"]"));
			}
			queryMediaInfoJobListResponse.NonExistMediaInfoJobIds = queryMediaInfoJobListResponse_nonExistMediaInfoJobIds;

			List<QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob> queryMediaInfoJobListResponse_mediaInfoJobList = new List<QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob>();
			for (int i = 0; i < context.Length("QueryMediaInfoJobList.MediaInfoJobList.Length"); i++) {
				QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob mediaInfoJob = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob();
				mediaInfoJob.JobId = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].JobId");
				mediaInfoJob.UserData = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].UserData");
				mediaInfoJob.PipelineId = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].PipelineId");
				mediaInfoJob.State = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].State");
				mediaInfoJob.Code = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Code");
				mediaInfoJob.Message = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Message");
				mediaInfoJob.CreationTime = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].CreationTime");

				QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Input input = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Input();
				input.Bucket = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Input.Object");
				mediaInfoJob.Input = input;

				QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties properties = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties();
				properties.Width = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Width");
				properties.Height = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Height");
				properties.Bitrate = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Bitrate");
				properties.Duration = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Duration");
				properties.Fps = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Fps");
				properties.FileSize = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.FileSize");
				properties.FileFormat = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.FileFormat");

				QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams streams = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams();

				List<QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_VideoStream> streams_videoStreamList = new List<QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_VideoStream>();
				for (int j = 0; j < context.Length("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList.Length"); j++) {
					QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_VideoStream videoStream = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_VideoStream();
					videoStream.Index = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.CodecName = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.CodecLongName = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Profile = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.CodecTimeBase = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.CodecTagString = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.CodecTag = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.Width = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Height = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.HasBFrames = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Sar = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Dar = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.PixFmt = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Level = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Level");
					videoStream.Fps = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.AvgFPS = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.Timebase = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.StartTime = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Duration = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Bitrate = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.NumFrames = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Lang = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Lang");
					videoStream.Rotate = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Rotate");

					QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_VideoStream.QueryMediaInfoJobList_NetworkCost networkCost = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_VideoStream.QueryMediaInfoJobList_NetworkCost();
					networkCost.PreloadTime = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;

				List<QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_AudioStream> streams_audioStreamList = new List<QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_AudioStream>();
				for (int j = 0; j < context.Length("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList.Length"); j++) {
					QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_AudioStream audioStream = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_AudioStream();
					audioStream.Index = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.CodecName = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.CodecTimeBase = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.CodecLongName = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.CodecTagString = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.CodecTag = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.SampleFmt = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.Samplerate = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.Channels = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.ChannelLayout = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Timebase = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.StartTime = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.Duration = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.Bitrate = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.NumFrames = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Lang = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Lang");

					streams_audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = streams_audioStreamList;

				List<QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_SubtitleStream> streams_subtitleStreamList = new List<QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_SubtitleStream>();
				for (int j = 0; j < context.Length("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList.Length"); j++) {
					QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_SubtitleStream subtitleStream = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_SubtitleStream();
					subtitleStream.Index = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					streams_subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = streams_subtitleStreamList;
				properties.Streams = streams;

				QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Format format = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Format();
				format.NumStreams = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Format.NumStreams");
				format.NumPrograms = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Format.NumPrograms");
				format.FormatName = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Format.FormatName");
				format.FormatLongName = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Format.FormatLongName");
				format.StartTime = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Format.StartTime");
				format.Duration = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Format.Duration");
				format.Size = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Format.Size");
				format.Bitrate = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Format.Bitrate");
				properties.Format = format;
				mediaInfoJob.Properties = properties;

				QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_MNSMessageResult mNSMessageResult = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_MNSMessageResult();
				mNSMessageResult.MessageId = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = context.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].MNSMessageResult.ErrorCode");
				mediaInfoJob.MNSMessageResult = mNSMessageResult;

				queryMediaInfoJobListResponse_mediaInfoJobList.Add(mediaInfoJob);
			}
			queryMediaInfoJobListResponse.MediaInfoJobList = queryMediaInfoJobListResponse_mediaInfoJobList;
        
			return queryMediaInfoJobListResponse;
        }
    }
}