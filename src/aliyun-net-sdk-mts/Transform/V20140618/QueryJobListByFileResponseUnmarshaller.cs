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
    public class QueryJobListByFileResponseUnmarshaller
    {
        public static QueryJobListByFileResponse Unmarshall(UnmarshallerContext context)
        {
            QueryJobListByFileResponse queryJobListByFileResponse = new QueryJobListByFileResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryJobListByFile.RequestId")
            };
            List<QueryJobListByFileResponse.Job> jobList = new List<QueryJobListByFileResponse.Job>();
			for (int i = 0; i < context.Length("QueryJobListByFile.JobList.Length"); i++) {
                QueryJobListByFileResponse.Job job = new QueryJobListByFileResponse.Job()
                {
                    JobId = context.StringValue($"QueryJobListByFile.JobList[{i}].JobId"),
                    State = context.StringValue($"QueryJobListByFile.JobList[{i}].State"),
                    Code = context.StringValue($"QueryJobListByFile.JobList[{i}].Code"),
                    Message = context.StringValue($"QueryJobListByFile.JobList[{i}].Message"),
                    Percent = context.LongValue($"QueryJobListByFile.JobList[{i}].Percent"),
                    PipelineId = context.StringValue($"QueryJobListByFile.JobList[{i}].PipelineId"),
                    CreationTime = context.StringValue($"QueryJobListByFile.JobList[{i}].CreationTime")
                };
                QueryJobListByFileResponse.Job.Input_ input = new QueryJobListByFileResponse.Job.Input_()
                {
                    Bucket = context.StringValue($"QueryJobListByFile.JobList[{i}].Input.Bucket"),
                    Location = context.StringValue($"QueryJobListByFile.JobList[{i}].Input.Location"),
                    Object = context.StringValue($"QueryJobListByFile.JobList[{i}].Input.Object")
                };
                job.Input = input;

                QueryJobListByFileResponse.Job.Output_ output = new QueryJobListByFileResponse.Job.Output_()
                {
                    TemplateId = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.TemplateId"),
                    UserData = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.UserData"),
                    Rotate = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Rotate"),
                    VideoStreamMap = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.VideoStreamMap"),
                    AudioStreamMap = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.AudioStreamMap"),
                    DeWatermark = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.DeWatermark"),
                    Priority = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Priority")
                };
                QueryJobListByFileResponse.Job.Output_.OutputFile_ outputFile = new QueryJobListByFileResponse.Job.Output_.OutputFile_()
                {
                    Bucket = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.OutputFile.Bucket"),
                    Location = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.OutputFile.Location"),
                    Object = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.OutputFile.Object")
                };
                output.OutputFile = outputFile;

                QueryJobListByFileResponse.Job.Output_.Properties_ properties = new QueryJobListByFileResponse.Job.Output_.Properties_()
                {
                    Width = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Width"),
                    Height = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Height"),
                    Bitrate = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Bitrate"),
                    Duration = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Duration"),
                    Fps = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Fps"),
                    FileSize = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.FileSize"),
                    FileFormat = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.FileFormat")
                };
                QueryJobListByFileResponse.Job.Output_.Properties_.Streams_ streams = new QueryJobListByFileResponse.Job.Output_.Properties_.Streams_();

				List<QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.VideoStream> videoStreamList = new List<QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList.Length"); j++) {
                    QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.VideoStream videoStream = new QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.VideoStream()
                    {
                        Index = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Index"),
                        CodecName = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecName"),
                        CodecLongName = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecLongName"),
                        Profile = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Profile"),
                        CodecTimeBase = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecTimeBase"),
                        CodecTagString = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecTag"),
                        Width = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Width"),
                        Height = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Height"),
                        HasBFrames = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].HasBFrames"),
                        Sar = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Sar"),
                        Dar = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Dar"),
                        PixFmt = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].PixFmt"),
                        Level = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Level"),
                        Fps = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Fps"),
                        AvgFps = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].AvgFPS"),
                        Timebase = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Lang")
                    };
                    QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_()
                    {
                        PreloadTime = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].NetworkCost.PreloadTime"),
                        CostBandwidth = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].NetworkCost.CostBandwidth"),
                        AvgBitrate = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].NetworkCost.AvgBitrate")
                    };
                    videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.AudioStream> audioStreamList = new List<QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList.Length"); j++) {
                    QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.AudioStream audioStream = new QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.AudioStream()
                    {
                        Index = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Index"),
                        CodecName = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecName"),
                        CodecTimeBase = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecTimeBase"),
                        CodecLongName = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecLongName"),
                        CodecTagString = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecTag"),
                        SampleFmt = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].SampleFmt"),
                        Samplerate = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Samplerate"),
                        Channels = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Channels"),
                        ChannelLayout = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].ChannelLayout"),
                        Timebase = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Lang")
                    };
                    audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
                    QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.SubtitleStream subtitleStream = new QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.SubtitleStream()
                    {
                        Index = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.SubtitleStreamList[{j}].Index"),
                        Lang = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Streams.SubtitleStreamList[{j}].Lang")
                    };
                    subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				properties.Streams = streams;

                QueryJobListByFileResponse.Job.Output_.Properties_.Format_ format = new QueryJobListByFileResponse.Job.Output_.Properties_.Format_()
                {
                    NumStreams = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Format.NumStreams"),
                    NumPrograms = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Format.NumPrograms"),
                    FormatName = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Format.FormatName"),
                    FormatLongName = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Format.FormatLongName"),
                    StartTime = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Format.StartTime"),
                    Duration = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Format.Duration"),
                    Size = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Format.Size"),
                    Bitrate = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Properties.Format.Bitrate")
                };
                properties.Format = format;
				output.Properties = properties;

				QueryJobListByFileResponse.Job.Output_.Clip_ clip = new QueryJobListByFileResponse.Job.Output_.Clip_();

                QueryJobListByFileResponse.Job.Output_.Clip_.TimeSpan_ timeSpan = new QueryJobListByFileResponse.Job.Output_.Clip_.TimeSpan_()
                {
                    Seek = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Clip.TimeSpan.Seek"),
                    Duration = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Clip.TimeSpan.Duration")
                };
                clip.TimeSpan = timeSpan;
				output.Clip = clip;

                QueryJobListByFileResponse.Job.Output_.SuperReso_ superReso = new QueryJobListByFileResponse.Job.Output_.SuperReso_()
                {
                    IsHalfSample = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.SuperReso.IsHalfSample")
                };
                output.SuperReso = superReso;

				QueryJobListByFileResponse.Job.Output_.SubtitleConfig_ subtitleConfig = new QueryJobListByFileResponse.Job.Output_.SubtitleConfig_();

				List<QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.Subtitle> subtitleList = new List<QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.Subtitle>();
				for (int j = 0; j < context.Length($"QueryJobListByFile.JobList[{i}].Output.SubtitleConfig.SubtitleList.Length"); j++) {
                    QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.Subtitle subtitle = new QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.Subtitle()
                    {
                        Map = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.SubtitleConfig.SubtitleList[{j}].Map")
                    };
                    subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleList;

				List<QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.ExtSubtitle> extSubtitleList = new List<QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.ExtSubtitle>();
				for (int j = 0; j < context.Length($"QueryJobListByFile.JobList[{i}].Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.ExtSubtitle extSubtitle = new QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.ExtSubtitle();

                    QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_ extSubtitleInput = new QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_()
                    {
                        Bucket = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.SubtitleConfig.ExtSubtitleList[{j}].Input.Bucket"),
                        Location = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.SubtitleConfig.ExtSubtitleList[{j}].Input.Location"),
                        Object = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.SubtitleConfig.ExtSubtitleList[{j}].Input.Object")
                    };
                    extSubtitle.Input = extSubtitleInput;

					extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = extSubtitleList;
				output.SubtitleConfig = subtitleConfig;

                QueryJobListByFileResponse.Job.Output_.TransConfig_ transConfig = new QueryJobListByFileResponse.Job.Output_.TransConfig_()
                {
                    TransMode = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.TransConfig.TransMode")
                };
                output.TransConfig = transConfig;

				QueryJobListByFileResponse.Job.Output_.MuxConfig_ muxConfig = new QueryJobListByFileResponse.Job.Output_.MuxConfig_();

                QueryJobListByFileResponse.Job.Output_.MuxConfig_.Segment_ segment = new QueryJobListByFileResponse.Job.Output_.MuxConfig_.Segment_()
                {
                    Duration = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.MuxConfig.Segment.Duration")
                };
                muxConfig.Segment = segment;

                QueryJobListByFileResponse.Job.Output_.MuxConfig_.Gif_ gif = new QueryJobListByFileResponse.Job.Output_.MuxConfig_.Gif_()
                {
                    Loop = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.MuxConfig.Gif.Loop"),
                    FinalDelay = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.MuxConfig.Gif.FinalDelay")
                };
                muxConfig.Gif = gif;
				output.MuxConfig = muxConfig;

                QueryJobListByFileResponse.Job.Output_.Audio_ audio = new QueryJobListByFileResponse.Job.Output_.Audio_()
                {
                    Codec = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Audio.Codec"),
                    Profile = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Audio.Profile"),
                    Samplerate = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Audio.Samplerate"),
                    Bitrate = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Audio.Bitrate"),
                    Channels = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Audio.Channels"),
                    Qscale = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Audio.Qscale")
                };
                output.Audio = audio;

                QueryJobListByFileResponse.Job.Output_.Video_ video = new QueryJobListByFileResponse.Job.Output_.Video_()
                {
                    Codec = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.Codec"),
                    Profile = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.Profile"),
                    Bitrate = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.Bitrate"),
                    Crf = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.Crf"),
                    Width = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.Width"),
                    Height = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.Height"),
                    Fps = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.Fps"),
                    Gop = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.Gop"),
                    Preset = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.Preset"),
                    ScanMode = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.ScanMode"),
                    Bufsize = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.Bufsize"),
                    Maxrate = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.Maxrate"),
                    PixFmt = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.PixFmt"),
                    Degrain = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.Degrain"),
                    Qscale = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.Qscale")
                };
                QueryJobListByFileResponse.Job.Output_.Video_.BitrateBnd_ bitrateBnd = new QueryJobListByFileResponse.Job.Output_.Video_.BitrateBnd_()
                {
                    Max = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.BitrateBnd.Max"),
                    Min = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Video.BitrateBnd.Min")
                };
                video.BitrateBnd = bitrateBnd;
				output.Video = video;

                QueryJobListByFileResponse.Job.Output_.Container_ container = new QueryJobListByFileResponse.Job.Output_.Container_()
                {
                    Format = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.Container.Format")
                };
                output.Container = container;

				List<QueryJobListByFileResponse.Job.Output_.WaterMark> waterMarkList = new List<QueryJobListByFileResponse.Job.Output_.WaterMark>();
				for (int j = 0; j < context.Length($"QueryJobListByFile.JobList[{i}].Output.WaterMarkList.Length"); j++) {
                    QueryJobListByFileResponse.Job.Output_.WaterMark waterMark = new QueryJobListByFileResponse.Job.Output_.WaterMark()
                    {
                        WaterMarkTemplateId = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.WaterMarkList[{j}].WaterMarkTemplateId"),
                        Width = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.WaterMarkList[{j}].Width"),
                        Height = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.WaterMarkList[{j}].Height"),
                        Dx = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.WaterMarkList[{j}].Dx"),
                        Dy = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.WaterMarkList[{j}].Dy"),
                        ReferPos = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.WaterMarkList[{j}].ReferPos"),
                        Type = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.WaterMarkList[{j}].Type")
                    };
                    QueryJobListByFileResponse.Job.Output_.WaterMark.InputFile_ inputFile = new QueryJobListByFileResponse.Job.Output_.WaterMark.InputFile_()
                    {
                        Bucket = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.WaterMarkList[{j}].InputFile.Bucket"),
                        Location = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.WaterMarkList[{j}].InputFile.Location"),
                        Object = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.WaterMarkList[{j}].InputFile.Object")
                    };
                    waterMark.InputFile = inputFile;

					waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = waterMarkList;

				List<QueryJobListByFileResponse.Job.Output_.Merge> mergeList = new List<QueryJobListByFileResponse.Job.Output_.Merge>();
				for (int j = 0; j < context.Length($"QueryJobListByFile.JobList[{i}].Output.MergeList.Length"); j++) {
                    QueryJobListByFileResponse.Job.Output_.Merge merge = new QueryJobListByFileResponse.Job.Output_.Merge()
                    {
                        MergeURL = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.MergeList[{j}].MergeURL"),
                        Start = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.MergeList[{j}].Start"),
                        Duration = context.StringValue($"QueryJobListByFile.JobList[{i}].Output.MergeList[{j}].Duration")
                    };
                    mergeList.Add(merge);
				}
				output.MergeList = mergeList;
				job.Output = output;

				jobList.Add(job);
			}
			queryJobListByFileResponse.JobList = jobList;
        
			return queryJobListByFileResponse;
        }
    }
}