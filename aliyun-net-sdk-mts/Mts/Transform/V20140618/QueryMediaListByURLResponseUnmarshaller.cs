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
    public class QueryMediaListByURLResponseUnmarshaller
    {
        public static QueryMediaListByURLResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMediaListByURLResponse queryMediaListByURLResponse = new QueryMediaListByURLResponse();

			queryMediaListByURLResponse.HttpResponse = context.HttpResponse;
			queryMediaListByURLResponse.RequestId = context.StringValue("QueryMediaListByURL.RequestId");

			List<string> queryMediaListByURLResponse_nonExistFileURLs = new List<string>();
			for (int i = 0; i < context.Length("QueryMediaListByURL.NonExistFileURLs.Length"); i++) {
				queryMediaListByURLResponse_nonExistFileURLs.Add(context.StringValue("QueryMediaListByURL.NonExistFileURLs["+ i +"]"));
			}
			queryMediaListByURLResponse.NonExistFileURLs = queryMediaListByURLResponse_nonExistFileURLs;

			List<QueryMediaListByURLResponse.QueryMediaListByURL_Media> queryMediaListByURLResponse_mediaList = new List<QueryMediaListByURLResponse.QueryMediaListByURL_Media>();
			for (int i = 0; i < context.Length("QueryMediaListByURL.MediaList.Length"); i++) {
				QueryMediaListByURLResponse.QueryMediaListByURL_Media media = new QueryMediaListByURLResponse.QueryMediaListByURL_Media();
				media.MediaId = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaId");
				media.Title = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].Title");
				media.Description = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].Description");
				media.CoverURL = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].CoverURL");
				media.CateId = context.LongValue("QueryMediaListByURL.MediaList["+ i +"].CateId");
				media.Duration = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].Duration");
				media.Format = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].Format");
				media.Size = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].Size");
				media.Bitrate = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].Bitrate");
				media.Width = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].Width");
				media.Height = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].Height");
				media.Fps = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].Fps");
				media.PublishState = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].PublishState");
				media.CreationTime = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].CreationTime");

				List<string> media_tags = new List<string>();
				for (int j = 0; j < context.Length("QueryMediaListByURL.MediaList["+ i +"].Tags.Length"); j++) {
					media_tags.Add(context.StringValue("QueryMediaListByURL.MediaList["+ i +"].Tags["+ j +"]"));
				}
				media.Tags = media_tags;

				List<string> media_runIdList = new List<string>();
				for (int j = 0; j < context.Length("QueryMediaListByURL.MediaList["+ i +"].RunIdList.Length"); j++) {
					media_runIdList.Add(context.StringValue("QueryMediaListByURL.MediaList["+ i +"].RunIdList["+ j +"]"));
				}
				media.RunIdList = media_runIdList;

				QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_File file = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_File();
				file.URL = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].File.URL");
				file.State = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].File.State");
				media.File = file;

				QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo mediaInfo = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo();

				QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams streams = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams();

				List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_VideoStream> streams_videoStreamList = new List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_VideoStream>();
				for (int j = 0; j < context.Length("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList.Length"); j++) {
					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_VideoStream videoStream = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_VideoStream();
					videoStream.Index = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Index");
					videoStream.CodecName = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.CodecLongName = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Profile = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.CodecTimeBase = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.CodecTagString = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.CodecTag = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.Width = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Height = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Height");
					videoStream.HasBFrames = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Sar = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Dar = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.PixFmt = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Level = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Level");
					videoStream.Fps = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.AvgFPS = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.Timebase = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.StartTime = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Duration = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Bitrate = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.NumFrames = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Lang = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Lang");
					videoStream.Rotate = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].Rotate");

					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_VideoStream.QueryMediaListByURL_NetworkCost networkCost = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_VideoStream.QueryMediaListByURL_NetworkCost();
					networkCost.PreloadTime = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;

				List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_AudioStream> streams_audioStreamList = new List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_AudioStream>();
				for (int j = 0; j < context.Length("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList.Length"); j++) {
					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_AudioStream audioStream = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_AudioStream();
					audioStream.Index = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Index");
					audioStream.CodecName = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.CodecTimeBase = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.CodecLongName = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.CodecTagString = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.CodecTag = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.SampleFmt = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.Samplerate = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.Channels = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.ChannelLayout = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Timebase = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.StartTime = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.Duration = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.Bitrate = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.NumFrames = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Lang = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList["+ j +"].Lang");

					streams_audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = streams_audioStreamList;

				List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_SubtitleStream> streams_subtitleStreamList = new List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_SubtitleStream>();
				for (int j = 0; j < context.Length("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList.Length"); j++) {
					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_SubtitleStream subtitleStream = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Streams.QueryMediaListByURL_SubtitleStream();
					subtitleStream.Index = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList["+ j +"].Lang");

					streams_subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = streams_subtitleStreamList;
				mediaInfo.Streams = streams;

				QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Format format = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_MediaInfo.QueryMediaListByURL_Format();
				format.NumStreams = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Format.NumStreams");
				format.NumPrograms = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Format.NumPrograms");
				format.FormatName = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Format.FormatName");
				format.FormatLongName = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Format.FormatLongName");
				format.StartTime = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Format.StartTime");
				format.Duration = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Format.Duration");
				format.Size = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Format.Size");
				format.Bitrate = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Format.Bitrate");
				mediaInfo.Format = format;
				media.MediaInfo = mediaInfo;

				List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Play> media_playList = new List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Play>();
				for (int j = 0; j < context.Length("QueryMediaListByURL.MediaList["+ i +"].PlayList.Length"); j++) {
					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Play play = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Play();
					play.ActivityName = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].ActivityName");
					play.MediaWorkflowId = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].MediaWorkflowId");
					play.MediaWorkflowName = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].MediaWorkflowName");
					play.Duration = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].Duration");
					play.Format = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].Format");
					play.Size = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].Size");
					play.Bitrate = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].Bitrate");
					play.Width = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].Width");
					play.Height = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].Height");
					play.Fps = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].Fps");
					play.Encryption = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].Encryption");

					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Play.QueryMediaListByURL_File1 file1 = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Play.QueryMediaListByURL_File1();
					file1.URL = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].File.URL");
					file1.State = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].File.State");
					play.File1 = file1;

					media_playList.Add(play);
				}
				media.PlayList = media_playList;

				List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Snapshot> media_snapshotList = new List<QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Snapshot>();
				for (int j = 0; j < context.Length("QueryMediaListByURL.MediaList["+ i +"].SnapshotList.Length"); j++) {
					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Snapshot snapshot = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Snapshot();
					snapshot.Type = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].Type");
					snapshot.MediaWorkflowId = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].MediaWorkflowId");
					snapshot.MediaWorkflowName = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].MediaWorkflowName");
					snapshot.ActivityName = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].ActivityName");
					snapshot.Count = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].Count");

					QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Snapshot.QueryMediaListByURL_File2 file2 = new QueryMediaListByURLResponse.QueryMediaListByURL_Media.QueryMediaListByURL_Snapshot.QueryMediaListByURL_File2();
					file2.URL = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].File.URL");
					file2.State = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].File.State");
					snapshot.File2 = file2;

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