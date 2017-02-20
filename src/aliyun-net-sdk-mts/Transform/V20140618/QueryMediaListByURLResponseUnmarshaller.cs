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
    public class QueryMediaListByURLResponseUnmarshaller
    {
        public static QueryMediaListByURLResponse Unmarshall(UnmarshallerContext context)
        {
            QueryMediaListByURLResponse queryMediaListByURLResponse = new QueryMediaListByURLResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryMediaListByURL.RequestId")
            };
            List<string> nonExistFileUrLs = new List<string>();
			for (int i = 0; i < context.Length("QueryMediaListByURL.NonExistFileURLs.Length"); i++) {
				nonExistFileUrLs.Add(context.StringValue($"QueryMediaListByURL.NonExistFileURLs[{i}]"));
			}
			queryMediaListByURLResponse.NonExistFileUrLs = nonExistFileUrLs;

			List<QueryMediaListByURLResponse.Media> mediaList = new List<QueryMediaListByURLResponse.Media>();
			for (int i = 0; i < context.Length("QueryMediaListByURL.MediaList.Length"); i++) {
                QueryMediaListByURLResponse.Media media = new QueryMediaListByURLResponse.Media()
                {
                    MediaId = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaId"),
                    Title = context.StringValue($"QueryMediaListByURL.MediaList[{i}].Title"),
                    Description = context.StringValue($"QueryMediaListByURL.MediaList[{i}].Description"),
                    CoverURL = context.StringValue($"QueryMediaListByURL.MediaList[{i}].CoverURL"),
                    CateId = context.LongValue($"QueryMediaListByURL.MediaList[{i}].CateId"),
                    Duration = context.StringValue($"QueryMediaListByURL.MediaList[{i}].Duration"),
                    Format = context.StringValue($"QueryMediaListByURL.MediaList[{i}].Format"),
                    Size = context.StringValue($"QueryMediaListByURL.MediaList[{i}].Size"),
                    Bitrate = context.StringValue($"QueryMediaListByURL.MediaList[{i}].Bitrate"),
                    Width = context.StringValue($"QueryMediaListByURL.MediaList[{i}].Width"),
                    Height = context.StringValue($"QueryMediaListByURL.MediaList[{i}].Height"),
                    Fps = context.StringValue($"QueryMediaListByURL.MediaList[{i}].Fps"),
                    PublishState = context.StringValue($"QueryMediaListByURL.MediaList[{i}].PublishState"),
                    CreationTime = context.StringValue($"QueryMediaListByURL.MediaList[{i}].CreationTime")
                };
                List<string> tags = new List<string>();
				for (int j = 0; j < context.Length($"QueryMediaListByURL.MediaList[{i}].Tags.Length"); j++) {
					tags.Add(context.StringValue($"QueryMediaListByURL.MediaList[{i}].Tags[{j}]"));
				}
				media.Tags = tags;

				List<string> runIdList = new List<string>();
				for (int j = 0; j < context.Length($"QueryMediaListByURL.MediaList[{i}].RunIdList.Length"); j++) {
					runIdList.Add(context.StringValue($"QueryMediaListByURL.MediaList[{i}].RunIdList[{j}]"));
				}
				media.RunIdList = runIdList;

                QueryMediaListByURLResponse.Media.File_ file = new QueryMediaListByURLResponse.Media.File_()
                {
                    URL = context.StringValue($"QueryMediaListByURL.MediaList[{i}].File.URL"),
                    State = context.StringValue($"QueryMediaListByURL.MediaList[{i}].File.State")
                };
                media.File = file;

				QueryMediaListByURLResponse.Media.MediaInfo_ mediaInfo = new QueryMediaListByURLResponse.Media.MediaInfo_();

				QueryMediaListByURLResponse.Media.MediaInfo_.Streams_ streams = new QueryMediaListByURLResponse.Media.MediaInfo_.Streams_();

				List<QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.VideoStream> videoStreamList = new List<QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList.Length"); j++) {
                    QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.VideoStream videoStream = new QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.VideoStream()
                    {
                        Index = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Index"),
                        CodecName = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].CodecName"),
                        CodecLongName = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].CodecLongName"),
                        Profile = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Profile"),
                        CodecTimeBase = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].CodecTimeBase"),
                        CodecTagString = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].CodecTag"),
                        Width = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Width"),
                        Height = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Height"),
                        HasBFrames = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].HasBFrames"),
                        Sar = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Sar"),
                        Dar = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Dar"),
                        PixFmt = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].PixFmt"),
                        Level = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Level"),
                        Fps = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Fps"),
                        AvgFps = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].AvgFPS"),
                        Timebase = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Lang"),
                        Rotate = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].Rotate")
                    };
                    QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.VideoStream.NetworkCost_ networkCost = new QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.VideoStream.NetworkCost_()
                    {
                        PreloadTime = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].NetworkCost.PreloadTime"),
                        CostBandwidth = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].NetworkCost.CostBandwidth"),
                        AvgBitrate = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.VideoStreamList[{j}].NetworkCost.AvgBitrate")
                    };
                    videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.AudioStream> audioStreamList = new List<QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList.Length"); j++) {
                    QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.AudioStream audioStream = new QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.AudioStream()
                    {
                        Index = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].Index"),
                        CodecName = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].CodecName"),
                        CodecTimeBase = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].CodecTimeBase"),
                        CodecLongName = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].CodecLongName"),
                        CodecTagString = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].CodecTag"),
                        SampleFmt = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].SampleFmt"),
                        Samplerate = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].Samplerate"),
                        Channels = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].Channels"),
                        ChannelLayout = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].ChannelLayout"),
                        Timebase = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.AudioStreamList[{j}].Lang")
                    };
                    audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.SubtitleStream> subtitleStreamList = new List<QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.SubtitleStreamList.Length"); j++) {
                    QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.SubtitleStream subtitleStream = new QueryMediaListByURLResponse.Media.MediaInfo_.Streams_.SubtitleStream()
                    {
                        Index = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.SubtitleStreamList[{j}].Index"),
                        Lang = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Streams.SubtitleStreamList[{j}].Lang")
                    };
                    subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				mediaInfo.Streams = streams;

                QueryMediaListByURLResponse.Media.MediaInfo_.Format_ format = new QueryMediaListByURLResponse.Media.MediaInfo_.Format_()
                {
                    NumStreams = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Format.NumStreams"),
                    NumPrograms = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Format.NumPrograms"),
                    FormatName = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Format.FormatName"),
                    FormatLongName = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Format.FormatLongName"),
                    StartTime = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Format.StartTime"),
                    Duration = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Format.Duration"),
                    Size = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Format.Size"),
                    Bitrate = context.StringValue($"QueryMediaListByURL.MediaList[{i}].MediaInfo.Format.Bitrate")
                };
                mediaInfo.Format = format;
				media.MediaInfo = mediaInfo;

				List<QueryMediaListByURLResponse.Media.Play> playList = new List<QueryMediaListByURLResponse.Media.Play>();
				for (int j = 0; j < context.Length($"QueryMediaListByURL.MediaList[{i}].PlayList.Length"); j++) {
                    QueryMediaListByURLResponse.Media.Play play = new QueryMediaListByURLResponse.Media.Play()
                    {
                        ActivityName = context.StringValue($"QueryMediaListByURL.MediaList[{i}].PlayList[{j}].ActivityName"),
                        MediaWorkflowId = context.StringValue($"QueryMediaListByURL.MediaList[{i}].PlayList[{j}].MediaWorkflowId"),
                        MediaWorkflowName = context.StringValue($"QueryMediaListByURL.MediaList[{i}].PlayList[{j}].MediaWorkflowName"),
                        Duration = context.StringValue($"QueryMediaListByURL.MediaList[{i}].PlayList[{j}].Duration"),
                        Format = context.StringValue($"QueryMediaListByURL.MediaList[{i}].PlayList[{j}].Format"),
                        Size = context.StringValue($"QueryMediaListByURL.MediaList[{i}].PlayList[{j}].Size"),
                        Bitrate = context.StringValue($"QueryMediaListByURL.MediaList[{i}].PlayList[{j}].Bitrate"),
                        Width = context.StringValue($"QueryMediaListByURL.MediaList[{i}].PlayList[{j}].Width"),
                        Height = context.StringValue($"QueryMediaListByURL.MediaList[{i}].PlayList[{j}].Height"),
                        Fps = context.StringValue($"QueryMediaListByURL.MediaList[{i}].PlayList[{j}].Fps")
                    };
                    QueryMediaListByURLResponse.Media.Play.File_ playFile = new QueryMediaListByURLResponse.Media.Play.File_()
                    {
                        URL = context.StringValue($"QueryMediaListByURL.MediaList[{i}].PlayList[{j}].File.URL"),
                        State = context.StringValue($"QueryMediaListByURL.MediaList[{i}].PlayList[{j}].File.State")
                    };
                    play.File = playFile;

					playList.Add(play);
				}
				media.PlayList = playList;

				List<QueryMediaListByURLResponse.Media.Snapshot> snapshotList = new List<QueryMediaListByURLResponse.Media.Snapshot>();
				for (int j = 0; j < context.Length($"QueryMediaListByURL.MediaList[{i}].SnapshotList.Length"); j++) {
                    QueryMediaListByURLResponse.Media.Snapshot snapshot = new QueryMediaListByURLResponse.Media.Snapshot()
                    {
                        Type = context.StringValue($"QueryMediaListByURL.MediaList[{i}].SnapshotList[{j}].Type"),
                        MediaWorkflowId = context.StringValue($"QueryMediaListByURL.MediaList[{i}].SnapshotList[{j}].MediaWorkflowId"),
                        MediaWorkflowName = context.StringValue($"QueryMediaListByURL.MediaList[{i}].SnapshotList[{j}].MediaWorkflowName"),
                        ActivityName = context.StringValue($"QueryMediaListByURL.MediaList[{i}].SnapshotList[{j}].ActivityName"),
                        Count = context.StringValue($"QueryMediaListByURL.MediaList[{i}].SnapshotList[{j}].Count")
                    };
                    QueryMediaListByURLResponse.Media.Snapshot.File_ snapshotFile = new QueryMediaListByURLResponse.Media.Snapshot.File_()
                    {
                        URL = context.StringValue($"QueryMediaListByURL.MediaList[{i}].SnapshotList[{j}].File.URL"),
                        State = context.StringValue($"QueryMediaListByURL.MediaList[{i}].SnapshotList[{j}].File.State")
                    };
                    snapshot.File = snapshotFile;

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