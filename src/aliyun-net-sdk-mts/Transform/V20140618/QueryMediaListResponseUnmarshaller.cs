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
    public class QueryMediaListResponseUnmarshaller
    {
        public static QueryMediaListResponse Unmarshall(UnmarshallerContext context)
        {
            QueryMediaListResponse queryMediaListResponse = new QueryMediaListResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryMediaList.RequestId")
            };
            List<string> nonExistMediaIds = new List<string>();
			for (int i = 0; i < context.Length("QueryMediaList.NonExistMediaIds.Length"); i++) {
				nonExistMediaIds.Add(context.StringValue($"QueryMediaList.NonExistMediaIds[{i}]"));
			}
			queryMediaListResponse.NonExistMediaIds = nonExistMediaIds;

			List<QueryMediaListResponse.Media> mediaList = new List<QueryMediaListResponse.Media>();
			for (int i = 0; i < context.Length("QueryMediaList.MediaList.Length"); i++) {
                QueryMediaListResponse.Media media = new QueryMediaListResponse.Media()
                {
                    MediaId = context.StringValue($"QueryMediaList.MediaList[{i}].MediaId"),
                    Title = context.StringValue($"QueryMediaList.MediaList[{i}].Title"),
                    Description = context.StringValue($"QueryMediaList.MediaList[{i}].Description"),
                    CoverURL = context.StringValue($"QueryMediaList.MediaList[{i}].CoverURL"),
                    CateId = context.LongValue($"QueryMediaList.MediaList[{i}].CateId"),
                    Duration = context.StringValue($"QueryMediaList.MediaList[{i}].Duration"),
                    Format = context.StringValue($"QueryMediaList.MediaList[{i}].Format"),
                    Size = context.StringValue($"QueryMediaList.MediaList[{i}].Size"),
                    Bitrate = context.StringValue($"QueryMediaList.MediaList[{i}].Bitrate"),
                    Width = context.StringValue($"QueryMediaList.MediaList[{i}].Width"),
                    Height = context.StringValue($"QueryMediaList.MediaList[{i}].Height"),
                    Fps = context.StringValue($"QueryMediaList.MediaList[{i}].Fps"),
                    PublishState = context.StringValue($"QueryMediaList.MediaList[{i}].PublishState"),
                    CreationTime = context.StringValue($"QueryMediaList.MediaList[{i}].CreationTime")
                };
                List<string> tags = new List<string>();
				for (int j = 0; j < context.Length($"QueryMediaList.MediaList[{i}].Tags.Length"); j++) {
					tags.Add(context.StringValue($"QueryMediaList.MediaList[{i}].Tags[{j}]"));
				}
				media.Tags = tags;

				List<string> runIdList = new List<string>();
				for (int j = 0; j < context.Length($"QueryMediaList.MediaList[{i}].RunIdList.Length"); j++) {
					runIdList.Add(context.StringValue($"QueryMediaList.MediaList[{i}].RunIdList[{j}]"));
				}
				media.RunIdList = runIdList;

                QueryMediaListResponse.Media.File_ file = new QueryMediaListResponse.Media.File_()
                {
                    URL = context.StringValue($"QueryMediaList.MediaList[{i}].File.URL"),
                    State = context.StringValue($"QueryMediaList.MediaList[{i}].File.State")
                };
                media.File = file;

				QueryMediaListResponse.Media.MediaInfo_ mediaInfo = new QueryMediaListResponse.Media.MediaInfo_();

				QueryMediaListResponse.Media.MediaInfo_.Streams_ streams = new QueryMediaListResponse.Media.MediaInfo_.Streams_();

				List<QueryMediaListResponse.Media.MediaInfo_.Streams_.VideoStream> videoStreamList = new List<QueryMediaListResponse.Media.MediaInfo_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList.Length"); j++) {
                    QueryMediaListResponse.Media.MediaInfo_.Streams_.VideoStream videoStream = new QueryMediaListResponse.Media.MediaInfo_.Streams_.VideoStream()
                    {
                        Index = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Index"),
                        CodecName = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].CodecName"),
                        CodecLongName = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].CodecLongName"),
                        Profile = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Profile"),
                        CodecTimeBase = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].CodecTimeBase"),
                        CodecTagString = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].CodecTag"),
                        Width = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Width"),
                        Height = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Height"),
                        HasBFrames = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].HasBFrames"),
                        Sar = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Sar"),
                        Dar = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Dar"),
                        PixFmt = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].PixFmt"),
                        Level = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Level"),
                        Fps = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Fps"),
                        AvgFps = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].AvgFPS"),
                        Timebase = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Lang"),
                        Rotate = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Rotate")
                    };
                    QueryMediaListResponse.Media.MediaInfo_.Streams_.VideoStream.NetworkCost_ networkCost = new QueryMediaListResponse.Media.MediaInfo_.Streams_.VideoStream.NetworkCost_()
                    {
                        PreloadTime = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].NetworkCost.PreloadTime"),
                        CostBandwidth = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].NetworkCost.CostBandwidth"),
                        AvgBitrate = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].NetworkCost.AvgBitrate")
                    };
                    videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<QueryMediaListResponse.Media.MediaInfo_.Streams_.AudioStream> audioStreamList = new List<QueryMediaListResponse.Media.MediaInfo_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList.Length"); j++) {
                    QueryMediaListResponse.Media.MediaInfo_.Streams_.AudioStream audioStream = new QueryMediaListResponse.Media.MediaInfo_.Streams_.AudioStream()
                    {
                        Index = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].Index"),
                        CodecName = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].CodecName"),
                        CodecTimeBase = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].CodecTimeBase"),
                        CodecLongName = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].CodecLongName"),
                        CodecTagString = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].CodecTag"),
                        SampleFmt = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].SampleFmt"),
                        Samplerate = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].Samplerate"),
                        Channels = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].Channels"),
                        ChannelLayout = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].ChannelLayout"),
                        Timebase = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].Lang")
                    };
                    audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<QueryMediaListResponse.Media.MediaInfo_.Streams_.SubtitleStream> subtitleStreamList = new List<QueryMediaListResponse.Media.MediaInfo_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.SubtitleStreamList.Length"); j++) {
                    QueryMediaListResponse.Media.MediaInfo_.Streams_.SubtitleStream subtitleStream = new QueryMediaListResponse.Media.MediaInfo_.Streams_.SubtitleStream()
                    {
                        Index = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.SubtitleStreamList[{j}].Index"),
                        Lang = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Streams.SubtitleStreamList[{j}].Lang")
                    };
                    subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				mediaInfo.Streams = streams;

                QueryMediaListResponse.Media.MediaInfo_.Format_ format = new QueryMediaListResponse.Media.MediaInfo_.Format_()
                {
                    NumStreams = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Format.NumStreams"),
                    NumPrograms = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Format.NumPrograms"),
                    FormatName = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Format.FormatName"),
                    FormatLongName = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Format.FormatLongName"),
                    StartTime = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Format.StartTime"),
                    Duration = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Format.Duration"),
                    Size = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Format.Size"),
                    Bitrate = context.StringValue($"QueryMediaList.MediaList[{i}].MediaInfo.Format.Bitrate")
                };
                mediaInfo.Format = format;
				media.MediaInfo = mediaInfo;

				List<QueryMediaListResponse.Media.Play> playList = new List<QueryMediaListResponse.Media.Play>();
				for (int j = 0; j < context.Length($"QueryMediaList.MediaList[{i}].PlayList.Length"); j++) {
                    QueryMediaListResponse.Media.Play play = new QueryMediaListResponse.Media.Play()
                    {
                        ActivityName = context.StringValue($"QueryMediaList.MediaList[{i}].PlayList[{j}].ActivityName"),
                        MediaWorkflowId = context.StringValue($"QueryMediaList.MediaList[{i}].PlayList[{j}].MediaWorkflowId"),
                        MediaWorkflowName = context.StringValue($"QueryMediaList.MediaList[{i}].PlayList[{j}].MediaWorkflowName"),
                        Duration = context.StringValue($"QueryMediaList.MediaList[{i}].PlayList[{j}].Duration"),
                        Format = context.StringValue($"QueryMediaList.MediaList[{i}].PlayList[{j}].Format"),
                        Size = context.StringValue($"QueryMediaList.MediaList[{i}].PlayList[{j}].Size"),
                        Bitrate = context.StringValue($"QueryMediaList.MediaList[{i}].PlayList[{j}].Bitrate"),
                        Width = context.StringValue($"QueryMediaList.MediaList[{i}].PlayList[{j}].Width"),
                        Height = context.StringValue($"QueryMediaList.MediaList[{i}].PlayList[{j}].Height"),
                        Fps = context.StringValue($"QueryMediaList.MediaList[{i}].PlayList[{j}].Fps")
                    };
                    QueryMediaListResponse.Media.Play.File_ playFile = new QueryMediaListResponse.Media.Play.File_()
                    {
                        URL = context.StringValue($"QueryMediaList.MediaList[{i}].PlayList[{j}].File.URL"),
                        State = context.StringValue($"QueryMediaList.MediaList[{i}].PlayList[{j}].File.State")
                    };
                    play.File = playFile;

					playList.Add(play);
				}
				media.PlayList = playList;

				List<QueryMediaListResponse.Media.Snapshot> snapshotList = new List<QueryMediaListResponse.Media.Snapshot>();
				for (int j = 0; j < context.Length($"QueryMediaList.MediaList[{i}].SnapshotList.Length"); j++) {
                    QueryMediaListResponse.Media.Snapshot snapshot = new QueryMediaListResponse.Media.Snapshot()
                    {
                        Type = context.StringValue($"QueryMediaList.MediaList[{i}].SnapshotList[{j}].Type"),
                        MediaWorkflowId = context.StringValue($"QueryMediaList.MediaList[{i}].SnapshotList[{j}].MediaWorkflowId"),
                        MediaWorkflowName = context.StringValue($"QueryMediaList.MediaList[{i}].SnapshotList[{j}].MediaWorkflowName"),
                        ActivityName = context.StringValue($"QueryMediaList.MediaList[{i}].SnapshotList[{j}].ActivityName"),
                        Count = context.StringValue($"QueryMediaList.MediaList[{i}].SnapshotList[{j}].Count")
                    };
                    QueryMediaListResponse.Media.Snapshot.File_ snapshotFile = new QueryMediaListResponse.Media.Snapshot.File_()
                    {
                        URL = context.StringValue($"QueryMediaList.MediaList[{i}].SnapshotList[{j}].File.URL"),
                        State = context.StringValue($"QueryMediaList.MediaList[{i}].SnapshotList[{j}].File.State")
                    };
                    snapshot.File = snapshotFile;

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