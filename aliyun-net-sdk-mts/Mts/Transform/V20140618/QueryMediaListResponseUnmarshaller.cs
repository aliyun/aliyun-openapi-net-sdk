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
    public class QueryMediaListResponseUnmarshaller
    {
        public static QueryMediaListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMediaListResponse queryMediaListResponse = new QueryMediaListResponse();

			queryMediaListResponse.HttpResponse = context.HttpResponse;
			queryMediaListResponse.RequestId = context.StringValue("QueryMediaList.RequestId");

			List<string> nonExistMediaIds = new List<string>();
			for (int i = 0; i < context.Length("QueryMediaList.NonExistMediaIds.Length"); i++) {
				nonExistMediaIds.Add(context.StringValue("QueryMediaList.NonExistMediaIds["+ i +"]"));
			}
			queryMediaListResponse.NonExistMediaIds = nonExistMediaIds;

			List<QueryMediaListResponse.Media> mediaList = new List<QueryMediaListResponse.Media>();
			for (int i = 0; i < context.Length("QueryMediaList.MediaList.Length"); i++) {
				QueryMediaListResponse.Media media = new QueryMediaListResponse.Media();
				media.MediaId = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaId");
				media.Title = context.StringValue("QueryMediaList.MediaList["+ i +"].Title");
				media.Description = context.StringValue("QueryMediaList.MediaList["+ i +"].Description");
				media.CoverURL = context.StringValue("QueryMediaList.MediaList["+ i +"].CoverURL");
				media.CateId = context.LongValue("QueryMediaList.MediaList["+ i +"].CateId");
				media.Duration = context.StringValue("QueryMediaList.MediaList["+ i +"].Duration");
				media.Format = context.StringValue("QueryMediaList.MediaList["+ i +"].Format");
				media.Size = context.StringValue("QueryMediaList.MediaList["+ i +"].Size");
				media.Bitrate = context.StringValue("QueryMediaList.MediaList["+ i +"].Bitrate");
				media.Width = context.StringValue("QueryMediaList.MediaList["+ i +"].Width");
				media.Height = context.StringValue("QueryMediaList.MediaList["+ i +"].Height");
				media.Fps = context.StringValue("QueryMediaList.MediaList["+ i +"].Fps");
				media.PublishState = context.StringValue("QueryMediaList.MediaList["+ i +"].PublishState");
				media.CreationTime = context.StringValue("QueryMediaList.MediaList["+ i +"].CreationTime");

				List<string> tags = new List<string>();
				for (int j = 0; j < context.Length("QueryMediaList.MediaList["+ i +"].Tags.Length"); j++) {
					tags.Add(context.StringValue("QueryMediaList.MediaList["+ i +"].Tags["+ j +"]"));
				}
				media.Tags = tags;

				List<string> runIdList = new List<string>();
				for (int j = 0; j < context.Length("QueryMediaList.MediaList["+ i +"].RunIdList.Length"); j++) {
					runIdList.Add(context.StringValue("QueryMediaList.MediaList["+ i +"].RunIdList["+ j +"]"));
				}
				media.RunIdList = runIdList;

				QueryMediaListResponse.Media.File_ file = new QueryMediaListResponse.Media.File_();
				file.URL = context.StringValue("QueryMediaList.MediaList["+ i +"].File.URL");
				file.State = context.StringValue("QueryMediaList.MediaList["+ i +"].File.State");
				media.File = file;

				QueryMediaListResponse.Media.MediaInfo_ mediaInfo = new QueryMediaListResponse.Media.MediaInfo_();

				QueryMediaListResponse.Media.MediaInfo_.Streams_ streams = new QueryMediaListResponse.Media.MediaInfo_.Streams_();

				List<QueryMediaListResponse.Media.MediaInfo_.Streams_.VideoStream> videoStreamList = new List<QueryMediaListResponse.Media.MediaInfo_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList.Length"); j++) {
					QueryMediaListResponse.Media.MediaInfo_.Streams_.VideoStream videoStream = new QueryMediaListResponse.Media.MediaInfo_.Streams_.VideoStream();
					videoStream.Index = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Index");
					videoStream.CodecName = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.CodecLongName = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Profile = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.CodecTimeBase = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.CodecTagString = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.CodecTag = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.Width = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Height = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Height");
					videoStream.HasBFrames = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Sar = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Dar = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.PixFmt = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Level = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Level");
					videoStream.Fps = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.AvgFPS = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.Timebase = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.StartTime = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Duration = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Bitrate = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.NumFrames = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Lang = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Lang");
					videoStream.Rotate = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Rotate");

					QueryMediaListResponse.Media.MediaInfo_.Streams_.VideoStream.NetworkCost_ networkCost = new QueryMediaListResponse.Media.MediaInfo_.Streams_.VideoStream.NetworkCost_();
					networkCost.PreloadTime = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<QueryMediaListResponse.Media.MediaInfo_.Streams_.AudioStream> audioStreamList = new List<QueryMediaListResponse.Media.MediaInfo_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList.Length"); j++) {
					QueryMediaListResponse.Media.MediaInfo_.Streams_.AudioStream audioStream = new QueryMediaListResponse.Media.MediaInfo_.Streams_.AudioStream();
					audioStream.Index = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Index");
					audioStream.CodecName = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.CodecTimeBase = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.CodecLongName = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.CodecTagString = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.CodecTag = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.SampleFmt = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.Samplerate = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.Channels = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.ChannelLayout = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Timebase = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.StartTime = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.Duration = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.Bitrate = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.NumFrames = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Lang = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Lang");

					audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<QueryMediaListResponse.Media.MediaInfo_.Streams_.SubtitleStream> subtitleStreamList = new List<QueryMediaListResponse.Media.MediaInfo_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList.Length"); j++) {
					QueryMediaListResponse.Media.MediaInfo_.Streams_.SubtitleStream subtitleStream = new QueryMediaListResponse.Media.MediaInfo_.Streams_.SubtitleStream();
					subtitleStream.Index = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList["+ j +"].Lang");

					subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				mediaInfo.Streams = streams;

				QueryMediaListResponse.Media.MediaInfo_.Format_ format = new QueryMediaListResponse.Media.MediaInfo_.Format_();
				format.NumStreams = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Format.NumStreams");
				format.NumPrograms = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Format.NumPrograms");
				format.FormatName = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Format.FormatName");
				format.FormatLongName = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Format.FormatLongName");
				format.StartTime = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Format.StartTime");
				format.Duration = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Format.Duration");
				format.Size = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Format.Size");
				format.Bitrate = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Format.Bitrate");
				mediaInfo.Format = format;
				media.MediaInfo = mediaInfo;

				List<QueryMediaListResponse.Media.Play> playList = new List<QueryMediaListResponse.Media.Play>();
				for (int j = 0; j < context.Length("QueryMediaList.MediaList["+ i +"].PlayList.Length"); j++) {
					QueryMediaListResponse.Media.Play play = new QueryMediaListResponse.Media.Play();
					play.ActivityName = context.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].ActivityName");
					play.MediaWorkflowId = context.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].MediaWorkflowId");
					play.MediaWorkflowName = context.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].MediaWorkflowName");
					play.Duration = context.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].Duration");
					play.Format = context.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].Format");
					play.Size = context.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].Size");
					play.Bitrate = context.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].Bitrate");
					play.Width = context.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].Width");
					play.Height = context.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].Height");
					play.Fps = context.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].Fps");

					QueryMediaListResponse.Media.Play.File_ playFile_ = new QueryMediaListResponse.Media.Play.File_();
					playFile_.URL = context.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].File.URL");
					playFile_.State = context.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].File.State");
					play.File = playFile_;

					playList.Add(play);
				}
				media.PlayList = playList;

				List<QueryMediaListResponse.Media.Snapshot> snapshotList = new List<QueryMediaListResponse.Media.Snapshot>();
				for (int j = 0; j < context.Length("QueryMediaList.MediaList["+ i +"].SnapshotList.Length"); j++) {
					QueryMediaListResponse.Media.Snapshot snapshot = new QueryMediaListResponse.Media.Snapshot();
					snapshot.Type = context.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].Type");
					snapshot.MediaWorkflowId = context.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].MediaWorkflowId");
					snapshot.MediaWorkflowName = context.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].MediaWorkflowName");
					snapshot.ActivityName = context.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].ActivityName");
					snapshot.Count = context.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].Count");

					QueryMediaListResponse.Media.Snapshot.File_ snapshotFile_ = new QueryMediaListResponse.Media.Snapshot.File_();
					snapshotFile_.URL = context.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].File.URL");
					snapshotFile_.State = context.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].File.State");
					snapshot.File = snapshotFile_;

					snapshotList.Add(snapshot);
				}
				media.SnapshotList = snapshotList;

				mediaList.Add(media);
			}
			queryMediaListResponse.MediaList = mediaList;
        
			return queryMediaListResponse;
        }
    }
}