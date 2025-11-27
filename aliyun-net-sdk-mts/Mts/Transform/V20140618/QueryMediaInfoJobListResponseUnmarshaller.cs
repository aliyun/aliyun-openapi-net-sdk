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
    public class QueryMediaInfoJobListResponseUnmarshaller
    {
        public static QueryMediaInfoJobListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryMediaInfoJobListResponse queryMediaInfoJobListResponse = new QueryMediaInfoJobListResponse();

			queryMediaInfoJobListResponse.HttpResponse = _ctx.HttpResponse;
			queryMediaInfoJobListResponse.RequestId = _ctx.StringValue("QueryMediaInfoJobList.RequestId");

			List<string> queryMediaInfoJobListResponse_nonExistMediaInfoJobIds = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryMediaInfoJobList.NonExistMediaInfoJobIds.Length"); i++) {
				queryMediaInfoJobListResponse_nonExistMediaInfoJobIds.Add(_ctx.StringValue("QueryMediaInfoJobList.NonExistMediaInfoJobIds["+ i +"]"));
			}
			queryMediaInfoJobListResponse.NonExistMediaInfoJobIds = queryMediaInfoJobListResponse_nonExistMediaInfoJobIds;

			List<QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob> queryMediaInfoJobListResponse_mediaInfoJobList = new List<QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob>();
			for (int i = 0; i < _ctx.Length("QueryMediaInfoJobList.MediaInfoJobList.Length"); i++) {
				QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob mediaInfoJob = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob();
				mediaInfoJob.CreationTime = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].CreationTime");
				mediaInfoJob.State = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].State");
				mediaInfoJob.JobId = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].JobId");
				mediaInfoJob.UserData = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].UserData");
				mediaInfoJob.Code = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Code");
				mediaInfoJob.Message = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Message");
				mediaInfoJob.PipelineId = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].PipelineId");
				mediaInfoJob.Async = _ctx.BooleanValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Async");

				QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Input input = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Input();
				input._Object = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Input.Object");
				input.Location = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Input.Location");
				input.Bucket = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Input.Bucket");
				mediaInfoJob.Input = input;

				QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_MNSMessageResult mNSMessageResult = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_MNSMessageResult();
				mNSMessageResult.MessageId = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].MNSMessageResult.ErrorCode");
				mediaInfoJob.MNSMessageResult = mNSMessageResult;

				QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties properties = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties();
				properties.Width = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Width");
				properties.Height = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Height");
				properties.Duration = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Duration");
				properties.Fps = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Fps");
				properties.Bitrate = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Bitrate");
				properties.FileFormat = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.FileFormat");
				properties.FileSize = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.FileSize");

				QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams streams = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams();

				List<QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_VideoStream> streams_videoStreamList = new List<QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_VideoStream>();
				for (int j = 0; j < _ctx.Length("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList.Length"); j++) {
					QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_VideoStream videoStream = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_VideoStream();
					videoStream.Sar = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Height = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.CodecTagString = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.Width = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Index = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.Timebase = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.AvgFPS = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.PixFmt = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Lang = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Lang");
					videoStream.CodecLongName = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.NumFrames = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Rotate = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Rotate");
					videoStream.Bitrate = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.HasBFrames = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Profile = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.StartTime = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Dar = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.CodecName = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.Duration = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Fps = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.CodecTag = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.CodecTimeBase = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.Level = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Level");
					videoStream.ColorRange = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].ColorRange");
					videoStream.ColorTransfer = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].ColorTransfer");
					videoStream.ColorPrimaries = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].ColorPrimaries");
					videoStream.DurationInaccurate = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].DurationInaccurate");

					QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_VideoStream.QueryMediaInfoJobList_NetworkCost networkCost = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_VideoStream.QueryMediaInfoJobList_NetworkCost();
					networkCost.PreloadTime = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.AvgBitrate = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					networkCost.CostBandwidth = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;

				List<QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_AudioStream> streams_audioStreamList = new List<QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_AudioStream>();
				for (int j = 0; j < _ctx.Length("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList.Length"); j++) {
					QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_AudioStream audioStream = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_AudioStream();
					audioStream.Timebase = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.Index = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.SampleFmt = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.ChannelLayout = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Lang = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Lang");
					audioStream.Samplerate = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.CodecLongName = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.Channels = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.NumFrames = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Bitrate = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.CodecTagString = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.StartTime = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.CodecName = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.Duration = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.CodecTag = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.CodecTimeBase = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.DurationInaccurate = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].DurationInaccurate");

					streams_audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = streams_audioStreamList;

				List<QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_SubtitleStream> streams_subtitleStreamList = new List<QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_SubtitleStream>();
				for (int j = 0; j < _ctx.Length("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList.Length"); j++) {
					QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_SubtitleStream subtitleStream = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Streams.QueryMediaInfoJobList_SubtitleStream();
					subtitleStream.Timebase = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].Timebase");
					subtitleStream.Index = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.StartTime = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].StartTime");
					subtitleStream.CodecName = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].CodecName");
					subtitleStream.Lang = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].Lang");
					subtitleStream.CodecLongName = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].CodecLongName");
					subtitleStream.Duration = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].Duration");
					subtitleStream.CodecTag = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].CodecTag");
					subtitleStream.CodecTimeBase = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].CodecTimeBase");
					subtitleStream.CodecTagString = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].CodecTagString");

					streams_subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = streams_subtitleStreamList;
				properties.Streams = streams;

				QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Format format = new QueryMediaInfoJobListResponse.QueryMediaInfoJobList_MediaInfoJob.QueryMediaInfoJobList_Properties.QueryMediaInfoJobList_Format();
				format.StartTime = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Format.StartTime");
				format.NumPrograms = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Format.NumPrograms");
				format.Size = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Format.Size");
				format.NumStreams = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Format.NumStreams");
				format.FormatLongName = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Format.FormatLongName");
				format.Duration = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Format.Duration");
				format.Bitrate = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Format.Bitrate");
				format.FormatName = _ctx.StringValue("QueryMediaInfoJobList.MediaInfoJobList["+ i +"].Properties.Format.FormatName");
				properties.Format = format;
				mediaInfoJob.Properties = properties;

				queryMediaInfoJobListResponse_mediaInfoJobList.Add(mediaInfoJob);
			}
			queryMediaInfoJobListResponse.MediaInfoJobList = queryMediaInfoJobListResponse_mediaInfoJobList;
        
			return queryMediaInfoJobListResponse;
        }
    }
}
