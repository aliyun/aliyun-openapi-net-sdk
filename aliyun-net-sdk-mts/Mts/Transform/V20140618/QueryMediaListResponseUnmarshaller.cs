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
    public class QueryMediaListResponseUnmarshaller
    {
        public static QueryMediaListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryMediaListResponse queryMediaListResponse = new QueryMediaListResponse();

			queryMediaListResponse.HttpResponse = _ctx.HttpResponse;
			queryMediaListResponse.RequestId = _ctx.StringValue("QueryMediaList.RequestId");

			List<string> queryMediaListResponse_nonExistMediaIds = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryMediaList.NonExistMediaIds.Length"); i++) {
				queryMediaListResponse_nonExistMediaIds.Add(_ctx.StringValue("QueryMediaList.NonExistMediaIds["+ i +"]"));
			}
			queryMediaListResponse.NonExistMediaIds = queryMediaListResponse_nonExistMediaIds;

			List<QueryMediaListResponse.QueryMediaList_Media> queryMediaListResponse_mediaList = new List<QueryMediaListResponse.QueryMediaList_Media>();
			for (int i = 0; i < _ctx.Length("QueryMediaList.MediaList.Length"); i++) {
				QueryMediaListResponse.QueryMediaList_Media media = new QueryMediaListResponse.QueryMediaList_Media();
				media.CreationTime = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].CreationTime");
				media.CateId = _ctx.LongValue("QueryMediaList.MediaList["+ i +"].CateId");
				media.Height = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].Height");
				media.CensorState = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].CensorState");
				media.Bitrate = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].Bitrate");
				media.MediaId = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaId");
				media.PublishState = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].PublishState");
				media.Description = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].Description");
				media.Size = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].Size");
				media.Width = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].Width");
				media.CoverURL = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].CoverURL");
				media.Duration = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].Duration");
				media.Fps = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].Fps");
				media.Title = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].Title");
				media.Format = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].Format");

				List<string> media_tags = new List<string>();
				for (int j = 0; j < _ctx.Length("QueryMediaList.MediaList["+ i +"].Tags.Length"); j++) {
					media_tags.Add(_ctx.StringValue("QueryMediaList.MediaList["+ i +"].Tags["+ j +"]"));
				}
				media.Tags = media_tags;

				List<string> media_runIdList = new List<string>();
				for (int j = 0; j < _ctx.Length("QueryMediaList.MediaList["+ i +"].RunIdList.Length"); j++) {
					media_runIdList.Add(_ctx.StringValue("QueryMediaList.MediaList["+ i +"].RunIdList["+ j +"]"));
				}
				media.RunIdList = media_runIdList;

				QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_File file = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_File();
				file.State = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].File.State");
				file.URL = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].File.URL");
				media.File = file;

				QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo mediaInfo = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo();

				QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams streams = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams();

				List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_VideoStream> streams_videoStreamList = new List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_VideoStream>();
				for (int j = 0; j < _ctx.Length("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList.Length"); j++) {
					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_VideoStream videoStream = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_VideoStream();
					videoStream.Sar = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Height = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Height");
					videoStream.CodecTagString = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.Width = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Index = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Index");
					videoStream.Timebase = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.AvgFPS = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.PixFmt = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Lang = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Lang");
					videoStream.CodecLongName = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.NumFrames = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Rotate = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Rotate");
					videoStream.Bitrate = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.HasBFrames = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Profile = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.StartTime = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Dar = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.CodecName = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.Duration = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Fps = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.CodecTag = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.CodecTimeBase = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.Level = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Level");

					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_VideoStream.QueryMediaList_NetworkCost networkCost = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_VideoStream.QueryMediaList_NetworkCost();
					networkCost.PreloadTime = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.AvgBitrate = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					networkCost.CostBandwidth = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;

				List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_AudioStream> streams_audioStreamList = new List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_AudioStream>();
				for (int j = 0; j < _ctx.Length("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList.Length"); j++) {
					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_AudioStream audioStream = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_AudioStream();
					audioStream.Timebase = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.Index = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Index");
					audioStream.SampleFmt = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.ChannelLayout = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Lang = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Lang");
					audioStream.Samplerate = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.CodecLongName = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.Channels = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.NumFrames = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Bitrate = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.CodecTagString = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.StartTime = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.CodecName = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.Duration = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.CodecTag = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.CodecTimeBase = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecTimeBase");

					streams_audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = streams_audioStreamList;

				List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_SubtitleStream> streams_subtitleStreamList = new List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_SubtitleStream>();
				for (int j = 0; j < _ctx.Length("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList.Length"); j++) {
					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_SubtitleStream subtitleStream = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_SubtitleStream();
					subtitleStream.Index = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList["+ j +"].Lang");

					streams_subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = streams_subtitleStreamList;
				mediaInfo.Streams = streams;

				QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Format format = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Format();
				format.StartTime = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Format.StartTime");
				format.NumPrograms = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Format.NumPrograms");
				format.Size = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Format.Size");
				format.NumStreams = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Format.NumStreams");
				format.FormatLongName = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Format.FormatLongName");
				format.Duration = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Format.Duration");
				format.Bitrate = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Format.Bitrate");
				format.FormatName = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Format.FormatName");
				mediaInfo.Format = format;
				media.MediaInfo = mediaInfo;

				List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Play> media_playList = new List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Play>();
				for (int j = 0; j < _ctx.Length("QueryMediaList.MediaList["+ i +"].PlayList.Length"); j++) {
					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Play play = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Play();
					play.Encryption = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].Encryption");
					play.Height = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].Height");
					play.Bitrate = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].Bitrate");
					play.MediaWorkflowId = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].MediaWorkflowId");
					play.Width = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].Width");
					play.Size = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].Size");
					play.Fps = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].Fps");
					play.Duration = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].Duration");
					play.ActivityName = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].ActivityName");
					play.Format = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].Format");
					play.MediaWorkflowName = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].MediaWorkflowName");

					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Play.QueryMediaList_File1 file1 = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Play.QueryMediaList_File1();
					file1.State = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].File.State");
					file1.URL = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].File.URL");
					play.File1 = file1;

					media_playList.Add(play);
				}
				media.PlayList = media_playList;

				List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Summary> media_summaryList = new List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Summary>();
				for (int j = 0; j < _ctx.Length("QueryMediaList.MediaList["+ i +"].SummaryList.Length"); j++) {
					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Summary summary = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Summary();
					summary.Type = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].SummaryList["+ j +"].Type");
					summary.MediaWorkflowId = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].SummaryList["+ j +"].MediaWorkflowId");
					summary.ActivityName = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].SummaryList["+ j +"].ActivityName");
					summary.MediaWorkflowName = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].SummaryList["+ j +"].MediaWorkflowName");

					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Summary.QueryMediaList_File2 file2 = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Summary.QueryMediaList_File2();
					file2.State = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].SummaryList["+ j +"].File.State");
					file2.URL = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].SummaryList["+ j +"].File.URL");
					summary.File2 = file2;

					media_summaryList.Add(summary);
				}
				media.SummaryList = media_summaryList;

				List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Snapshot> media_snapshotList = new List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Snapshot>();
				for (int j = 0; j < _ctx.Length("QueryMediaList.MediaList["+ i +"].SnapshotList.Length"); j++) {
					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Snapshot snapshot = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Snapshot();
					snapshot.Type = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].Type");
					snapshot.MediaWorkflowId = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].MediaWorkflowId");
					snapshot.ActivityName = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].ActivityName");
					snapshot.Count = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].Count");
					snapshot.MediaWorkflowName = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].MediaWorkflowName");

					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Snapshot.QueryMediaList_File3 file3 = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Snapshot.QueryMediaList_File3();
					file3.State = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].File.State");
					file3.URL = _ctx.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].File.URL");
					snapshot.File3 = file3;

					media_snapshotList.Add(snapshot);
				}
				media.SnapshotList = media_snapshotList;

				queryMediaListResponse_mediaList.Add(media);
			}
			queryMediaListResponse.MediaList = queryMediaListResponse_mediaList;
        
			return queryMediaListResponse;
        }
    }
}
