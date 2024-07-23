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
    public class QueryMediaListByURLResponseUnmarshaller
    {
        public static QueryMediaListByURLResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryMediaListByURLResponse queryMediaListByURLResponse = new QueryMediaListByURLResponse();

			queryMediaListByURLResponse.HttpResponse = _ctx.HttpResponse;
			queryMediaListByURLResponse.RequestId = _ctx.StringValue("QueryMediaListByURL.RequestId");

			List<string> queryMediaListByURLResponse_nonExistFileURLs = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryMediaListByURL.NonExistFileURLs.Length"); i++) {
				queryMediaListByURLResponse_nonExistFileURLs.Add(_ctx.StringValue("QueryMediaListByURL.NonExistFileURLs["+ i +"]"));
			}
			queryMediaListByURLResponse.NonExistFileURLs = queryMediaListByURLResponse_nonExistFileURLs;

			List<QueryMediaListByURLResponse.QueryMediaListByURL_Media> queryMediaListByURLResponse_mediaList = new List<QueryMediaListByURLResponse.QueryMediaListByURL_Media>();
			for (int i = 0; i < _ctx.Length("QueryMediaListByURL.MediaList.Length"); i++) {
				QueryMediaListByURLResponse.QueryMediaListByURL_Media media = new QueryMediaListByURLResponse.QueryMediaListByURL_Media();
				media.CreationTime = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].CreationTime");
				media.CateId = _ctx.LongValue("QueryMediaListByURL.MediaList["+ i +"].CateId");
				media.Height = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].Height");
				media.CensorState = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].CensorState");
				media.Bitrate = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].Bitrate");
				media.MediaId = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaId");
				media.PublishState = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].PublishState");
				media.Description = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].Description");
				media.Size = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].Size");
				media.Width = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].Width");
				media.CoverURL = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].CoverURL");
				media.Duration = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].Duration");
				media.Fps = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].Fps");
				media.Title = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].Title");
				media.Format = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].Format");

				List<string> media_tags = new List<string>();
				for (int j = 0; j < _ctx.Length("QueryMediaListByURL.MediaList["+ i +"].Tags.Length"); j++) {
					media_tags.Add(_ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].Tags["+ j +"]"));
				}
				media.Tags = media_tags;

				List<string> media_runIdList = new List<string>();
				for (int j = 0; j < _ctx.Length("QueryMediaListByURL.MediaList["+ i +"].RunIdList.Length"); j++) {
					media_runIdList.Add(_ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].RunIdList["+ j +"]"));
				}
				media.RunIdList = media_runIdList;

				QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_File file = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_File();
				file.State = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].File.State");
				file.URL = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].File.URL");
				media.File = file;

				QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo mediaInfo = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo();

				QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams streams = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams();

				List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_VideoStream> streams_videoStreamList = new List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_VideoStream>();
				for (int j = 0; j < _ctx.Length("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList.Length"); j++) {
					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_VideoStream videoStream = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_VideoStream();
					videoStream.Sar = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Height = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Height");
					videoStream.CodecTagString = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.Width = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Index = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Index");
					videoStream.Timebase = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.AvgFPS = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.PixFmt = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Lang = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Lang");
					videoStream.CodecLongName = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.NumFrames = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Rotate = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Rotate");
					videoStream.Bitrate = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.HasBFrames = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Profile = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.StartTime = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Dar = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.CodecName = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.Duration = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Fps = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.CodecTag = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.CodecTimeBase = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.Level = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Level");

					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_VideoStream.QueryMediaListByURL_NetworkCost networkCost = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_VideoStream.QueryMediaListByURL_NetworkCost();
					networkCost.PreloadTime = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.AvgBitrate = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					networkCost.CostBandwidth = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;

				List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_AudioStream> streams_audioStreamList = new List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_AudioStream>();
				for (int j = 0; j < _ctx.Length("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList.Length"); j++) {
					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_AudioStream audioStream = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_AudioStream();
					audioStream.Timebase = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.Index = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Index");
					audioStream.SampleFmt = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.ChannelLayout = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Lang = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Lang");
					audioStream.Samplerate = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.CodecLongName = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.Channels = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.NumFrames = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Bitrate = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.CodecTagString = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.StartTime = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.CodecName = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.Duration = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.CodecTag = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.CodecTimeBase = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecTimeBase");

					streams_audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = streams_audioStreamList;

				List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_SubtitleStream> streams_subtitleStreamList = new List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_SubtitleStream>();
				for (int j = 0; j < _ctx.Length("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList.Length"); j++) {
					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_SubtitleStream subtitleStream = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_SubtitleStream();
					subtitleStream.Index = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList["+ j +"].Lang");

					streams_subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = streams_subtitleStreamList;
				mediaInfo.Streams = streams;

				QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Format format = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Format();
				format.StartTime = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Format.StartTime");
				format.NumPrograms = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Format.NumPrograms");
				format.Size = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Format.Size");
				format.NumStreams = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Format.NumStreams");
				format.FormatLongName = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Format.FormatLongName");
				format.Duration = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Format.Duration");
				format.Bitrate = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Format.Bitrate");
				format.FormatName = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Format.FormatName");
				mediaInfo.Format = format;
				media.MediaInfo = mediaInfo;

				List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Play> media_playList = new List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Play>();
				for (int j = 0; j < _ctx.Length("QueryMediaListByURL.MediaList["+ i +"].PlayList.Length"); j++) {
					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Play play = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Play();
					play.Encryption = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].Encryption");
					play.Height = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].Height");
					play.Bitrate = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].Bitrate");
					play.MediaWorkflowId = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].MediaWorkflowId");
					play.Width = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].Width");
					play.Size = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].Size");
					play.Fps = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].Fps");
					play.Duration = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].Duration");
					play.ActivityName = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].ActivityName");
					play.Format = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].Format");
					play.MediaWorkflowName = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].MediaWorkflowName");

					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Play.QueryMediaListByURL_File1 file1 = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Play.QueryMediaListByURL_File1();
					file1.State = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].File.State");
					file1.URL = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].File.URL");
					play.File1 = file1;

					media_playList.Add(play);
				}
				media.PlayList = media_playList;

				List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Summary> media_summaryList = new List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Summary>();
				for (int j = 0; j < _ctx.Length("QueryMediaListByURL.MediaList["+ i +"].SummaryList.Length"); j++) {
					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Summary summary = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Summary();
					summary.Type = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].SummaryList["+ j +"].Type");
					summary.MediaWorkflowId = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].SummaryList["+ j +"].MediaWorkflowId");
					summary.ActivityName = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].SummaryList["+ j +"].ActivityName");
					summary.MediaWorkflowName = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].SummaryList["+ j +"].MediaWorkflowName");

					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Summary.QueryMediaListByURL_File2 file2 = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Summary.QueryMediaListByURL_File2();
					file2.State = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].SummaryList["+ j +"].File.State");
					file2.URL = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].SummaryList["+ j +"].File.URL");
					summary.File2 = file2;

					media_summaryList.Add(summary);
				}
				media.SummaryList = media_summaryList;

				List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Snapshot> media_snapshotList = new List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Snapshot>();
				for (int j = 0; j < _ctx.Length("QueryMediaListByURL.MediaList["+ i +"].SnapshotList.Length"); j++) {
					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Snapshot snapshot = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Snapshot();
					snapshot.Type = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].Type");
					snapshot.MediaWorkflowId = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].MediaWorkflowId");
					snapshot.ActivityName = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].ActivityName");
					snapshot.Count = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].Count");
					snapshot.MediaWorkflowName = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].MediaWorkflowName");

					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Snapshot.QueryMediaListByURL_File3 file3 = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Snapshot.QueryMediaListByURL_File3();
					file3.State = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].File.State");
					file3.URL = _ctx.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].File.URL");
					snapshot.File3 = file3;

					media_snapshotList.Add(snapshot);
				}
				media.SnapshotList = media_snapshotList;

				queryMediaListByURLResponse_mediaList.Add(media);
			}
			queryMediaListByURLResponse.MediaList = queryMediaListByURLResponse_mediaList;
        
			return queryMediaListByURLResponse;
        }
    }
}
