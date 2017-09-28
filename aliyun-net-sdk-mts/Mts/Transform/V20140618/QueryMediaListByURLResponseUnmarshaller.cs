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

			List<string> nonExistFileURLs = new List<string>();
			for (int i = 0; i < context.Length("QueryMediaListByURL.NonExistFileURLs.Length"); i++) {
				nonExistFileURLs.Add(context.StringValue("QueryMediaListByURL.NonExistFileURLs["+ i +"]"));
			}
			queryMediaListByURLResponse.NonExistFileURLs = nonExistFileURLs;

			List<QueryMediaListByURLResponse.Media> mediaList = new List<QueryMediaListByURLResponse.Media>();
			for (int i = 0; i < context.Length("QueryMediaListByURL.MediaList.Length"); i++) {
				QueryMediaListByURLResponse.Media media = new QueryMediaListByURLResponse.Media();
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

				List<string> tags = new List<string>();
				for (int j = 0; j < context.Length("QueryMediaListByURL.MediaList["+ i +"].Tags.Length"); j++) {
					tags.Add(context.StringValue("QueryMediaListByURL.MediaList["+ i +"].Tags["+ j +"]"));
				}
				media.Tags = tags;

				List<string> runIdList = new List<string>();
				for (int j = 0; j < context.Length("QueryMediaListByURL.MediaList["+ i +"].RunIdList.Length"); j++) {
					runIdList.Add(context.StringValue("QueryMediaListByURL.MediaList["+ i +"].RunIdList["+ j +"]"));
				}
				media.RunIdList = runIdList;

				QueryMediaListByURLResponse.Media.File_ file = new QueryMediaListByURLResponse.Media.File_();
				file.URL = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].File.URL");
				file.State = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].File.State");
				media.File = file;

				QueryMediaListByURLResponse.Media.MediaInfo_ mediaInfo = new QueryMediaListByURLResponse.Media.MediaInfo_();

				QueryMediaListByURLResponse.Media.MediaInfo_.Streams_ streams = new QueryMediaListByURLResponse.Media.MediaInfo_.Streams_();

				List<QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.VideoStream> videoStreamList = new List<QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList.Length"); j++) {
					QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.VideoStream videoStream = new QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.VideoStream();
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

					QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.VideoStream.NetworkCost_ networkCost = new QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.VideoStream.NetworkCost_();
					networkCost.PreloadTime = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.AudioStream> audioStreamList = new List<QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.AudioStreamList.Length"); j++) {
					QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.AudioStream audioStream = new QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.AudioStream();
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

					audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.SubtitleStream> subtitleStreamList = new List<QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList.Length"); j++) {
					QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.SubtitleStream subtitleStream = new QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.SubtitleStream();
					subtitleStream.Index = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].MediaInfo.Streams.SubtitleStreamList["+ j +"].Lang");

					subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				mediaInfo.Streams = streams;

				QueryMediaListByURLResponse.Media.MediaInfo_.Format_ format = new QueryMediaListByURLResponse.Media.MediaInfo_.Format_();
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

				List<QueryMediaListByURLResponse.Media.Play> playList = new List<QueryMediaListByURLResponse.Media.Play>();
				for (int j = 0; j < context.Length("QueryMediaListByURL.MediaList["+ i +"].PlayList.Length"); j++) {
					QueryMediaListByURLResponse.Media.Play play = new QueryMediaListByURLResponse.Media.Play();
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

					QueryMediaListByURLResponse.Media.Play.File_ playFile_ = new QueryMediaListByURLResponse.Media.Play.File_();
					playFile_.URL = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].File.URL");
					playFile_.State = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].PlayList["+ j +"].File.State");
					play.File = playFile_;

					playList.Add(play);
				}
				media.PlayList = playList;

				List<QueryMediaListByURLResponse.Media.Snapshot> snapshotList = new List<QueryMediaListByURLResponse.Media.Snapshot>();
				for (int j = 0; j < context.Length("QueryMediaListByURL.MediaList["+ i +"].SnapshotList.Length"); j++) {
					QueryMediaListByURLResponse.Media.Snapshot snapshot = new QueryMediaListByURLResponse.Media.Snapshot();
					snapshot.Type = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].Type");
					snapshot.MediaWorkflowId = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].MediaWorkflowId");
					snapshot.MediaWorkflowName = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].MediaWorkflowName");
					snapshot.ActivityName = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].ActivityName");
					snapshot.Count = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].Count");

					QueryMediaListByURLResponse.Media.Snapshot.File_ snapshotFile_ = new QueryMediaListByURLResponse.Media.Snapshot.File_();
					snapshotFile_.URL = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].File.URL");
					snapshotFile_.State = context.StringValue("QueryMediaListByURL.MediaList["+ i +"].SnapshotList["+ j +"].File.State");
					snapshot.File = snapshotFile_;

					snapshotList.Add(snapshot);
				}
				media.SnapshotList = snapshotList;

				mediaList.Add(media);
			}
			queryMediaListByURLResponse.MediaList = mediaList;
        
			return queryMediaListByURLResponse;
        }
    }
}