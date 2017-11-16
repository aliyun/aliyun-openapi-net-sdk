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

			List<string> queryMediaListResponse_nonExistMediaIds = new List<string>();
			for (int i = 0; i < context.Length("QueryMediaList.NonExistMediaIds.Length"); i++) {
				queryMediaListResponse_nonExistMediaIds.Add(context.StringValue("QueryMediaList.NonExistMediaIds["+ i +"]"));
			}
			queryMediaListResponse.NonExistMediaIds = queryMediaListResponse_nonExistMediaIds;

			List<QueryMediaListResponse.QueryMediaList_Media> queryMediaListResponse_mediaList = new List<QueryMediaListResponse.QueryMediaList_Media>();
			for (int i = 0; i < context.Length("QueryMediaList.MediaList.Length"); i++) {
				QueryMediaListResponse.QueryMediaList_Media media = new QueryMediaListResponse.QueryMediaList_Media();
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

				List<string> media_tags = new List<string>();
				for (int j = 0; j < context.Length("QueryMediaList.MediaList["+ i +"].Tags.Length"); j++) {
					media_tags.Add(context.StringValue("QueryMediaList.MediaList["+ i +"].Tags["+ j +"]"));
				}
				media.Tags = media_tags;

				List<string> media_runIdList = new List<string>();
				for (int j = 0; j < context.Length("QueryMediaList.MediaList["+ i +"].RunIdList.Length"); j++) {
					media_runIdList.Add(context.StringValue("QueryMediaList.MediaList["+ i +"].RunIdList["+ j +"]"));
				}
				media.RunIdList = media_runIdList;

				QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_File file = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_File();
				file.URL = context.StringValue("QueryMediaList.MediaList["+ i +"].File.URL");
				file.State = context.StringValue("QueryMediaList.MediaList["+ i +"].File.State");
				media.File = file;

				QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo mediaInfo = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo();

				QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams streams = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams();

				List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_VideoStream> streams_videoStreamList = new List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_VideoStream>();
				for (int j = 0; j < context.Length("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList.Length"); j++) {
					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_VideoStream videoStream = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_VideoStream();
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

					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_VideoStream.QueryMediaList_NetworkCost networkCost = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_VideoStream.QueryMediaList_NetworkCost();
					networkCost.PreloadTime = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;

				List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_AudioStream> streams_audioStreamList = new List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_AudioStream>();
				for (int j = 0; j < context.Length("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList.Length"); j++) {
					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_AudioStream audioStream = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_AudioStream();
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

					streams_audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = streams_audioStreamList;

				List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_SubtitleStream> streams_subtitleStreamList = new List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_SubtitleStream>();
				for (int j = 0; j < context.Length("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList.Length"); j++) {
					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_SubtitleStream subtitleStream = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Streams.QueryMediaList_SubtitleStream();
					subtitleStream.Index = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("QueryMediaList.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList["+ j +"].Lang");

					streams_subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = streams_subtitleStreamList;
				mediaInfo.Streams = streams;

				QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Format format = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_MediaInfo.QueryMediaList_Format();
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

				List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Play> media_playList = new List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Play>();
				for (int j = 0; j < context.Length("QueryMediaList.MediaList["+ i +"].PlayList.Length"); j++) {
					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Play play = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Play();
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
					play.Encryption = context.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].Encryption");

					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Play.QueryMediaList_File1 file1 = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Play.QueryMediaList_File1();
					file1.URL = context.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].File.URL");
					file1.State = context.StringValue("QueryMediaList.MediaList["+ i +"].PlayList["+ j +"].File.State");
					play.File1 = file1;

					media_playList.Add(play);
				}
				media.PlayList = media_playList;

				List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Snapshot> media_snapshotList = new List<QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Snapshot>();
				for (int j = 0; j < context.Length("QueryMediaList.MediaList["+ i +"].SnapshotList.Length"); j++) {
					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Snapshot snapshot = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Snapshot();
					snapshot.Type = context.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].Type");
					snapshot.MediaWorkflowId = context.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].MediaWorkflowId");
					snapshot.MediaWorkflowName = context.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].MediaWorkflowName");
					snapshot.ActivityName = context.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].ActivityName");
					snapshot.Count = context.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].Count");

					QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Snapshot.QueryMediaList_File2 file2 = new QueryMediaListResponse.QueryMediaList_Media.QueryMediaList_Snapshot.QueryMediaList_File2();
					file2.URL = context.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].File.URL");
					file2.State = context.StringValue("QueryMediaList.MediaList["+ i +"].SnapshotList["+ j +"].File.State");
					snapshot.File2 = file2;

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