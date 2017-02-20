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
    public class QueryJobListByPidResponseUnmarshaller
    {
        public static QueryJobListByPidResponse Unmarshall(UnmarshallerContext context)
        {
            QueryJobListByPidResponse queryJobListByPidResponse = new QueryJobListByPidResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryJobListByPid.RequestId"),
                TotalCount = context.LongValue("QueryJobListByPid.TotalCount"),
                PageNumber = context.LongValue("QueryJobListByPid.PageNumber"),
                PageSize = context.LongValue("QueryJobListByPid.PageSize")
            };
            List<QueryJobListByPidResponse.Job> jobList = new List<QueryJobListByPidResponse.Job>();
			for (int i = 0; i < context.Length("QueryJobListByPid.JobList.Length"); i++) {
                QueryJobListByPidResponse.Job job = new QueryJobListByPidResponse.Job()
                {
                    JobId = context.StringValue($"QueryJobListByPid.JobList[{i}].JobId"),
                    State = context.StringValue($"QueryJobListByPid.JobList[{i}].State"),
                    Code = context.StringValue($"QueryJobListByPid.JobList[{i}].Code"),
                    Message = context.StringValue($"QueryJobListByPid.JobList[{i}].Message"),
                    Percent = context.LongValue($"QueryJobListByPid.JobList[{i}].Percent"),
                    PipelineId = context.StringValue($"QueryJobListByPid.JobList[{i}].PipelineId"),
                    CreationTime = context.StringValue($"QueryJobListByPid.JobList[{i}].CreationTime")
                };
                QueryJobListByPidResponse.Job.Input_ input = new QueryJobListByPidResponse.Job.Input_()
                {
                    Bucket = context.StringValue($"QueryJobListByPid.JobList[{i}].Input.Bucket"),
                    Location = context.StringValue($"QueryJobListByPid.JobList[{i}].Input.Location"),
                    Object = context.StringValue($"QueryJobListByPid.JobList[{i}].Input.Object")
                };
                job.Input = input;

                QueryJobListByPidResponse.Job.Output_ output = new QueryJobListByPidResponse.Job.Output_()
                {
                    TemplateId = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.TemplateId"),
                    UserData = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.UserData"),
                    Rotate = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Rotate"),
                    VideoStreamMap = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.VideoStreamMap"),
                    AudioStreamMap = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.AudioStreamMap"),
                    DeWatermark = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.DeWatermark"),
                    Priority = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Priority")
                };
                QueryJobListByPidResponse.Job.Output_.OutputFile_ outputFile = new QueryJobListByPidResponse.Job.Output_.OutputFile_()
                {
                    Bucket = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.OutputFile.Bucket"),
                    Location = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.OutputFile.Location"),
                    Object = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.OutputFile.Object")
                };
                output.OutputFile = outputFile;

                QueryJobListByPidResponse.Job.Output_.Properties_ properties = new QueryJobListByPidResponse.Job.Output_.Properties_()
                {
                    Width = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Width"),
                    Height = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Height"),
                    Bitrate = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Bitrate"),
                    Duration = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Duration"),
                    Fps = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Fps"),
                    FileSize = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.FileSize"),
                    FileFormat = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.FileFormat")
                };
                QueryJobListByPidResponse.Job.Output_.Properties_.Streams_ streams = new QueryJobListByPidResponse.Job.Output_.Properties_.Streams_();

				List<QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.VideoStream> videoStreamList = new List<QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList.Length"); j++) {
                    QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.VideoStream videoStream = new QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.VideoStream()
                    {
                        Index = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Index"),
                        CodecName = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecName"),
                        CodecLongName = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecLongName"),
                        Profile = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Profile"),
                        CodecTimeBase = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecTimeBase"),
                        CodecTagString = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecTag"),
                        Width = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Width"),
                        Height = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Height"),
                        HasBFrames = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].HasBFrames"),
                        Sar = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Sar"),
                        Dar = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Dar"),
                        PixFmt = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].PixFmt"),
                        Level = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Level"),
                        Fps = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Fps"),
                        AvgFps = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].AvgFPS"),
                        Timebase = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Lang")
                    };
                    QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_()
                    {
                        PreloadTime = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].NetworkCost.PreloadTime"),
                        CostBandwidth = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].NetworkCost.CostBandwidth"),
                        AvgBitrate = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].NetworkCost.AvgBitrate")
                    };
                    videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.AudioStream> audioStreamList = new List<QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList.Length"); j++) {
                    QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.AudioStream audioStream = new QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.AudioStream()
                    {
                        Index = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Index"),
                        CodecName = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecName"),
                        CodecTimeBase = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecTimeBase"),
                        CodecLongName = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecLongName"),
                        CodecTagString = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecTag"),
                        SampleFmt = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].SampleFmt"),
                        Samplerate = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Samplerate"),
                        Channels = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Channels"),
                        ChannelLayout = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].ChannelLayout"),
                        Timebase = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Lang")
                    };
                    audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
                    QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.SubtitleStream subtitleStream = new QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.SubtitleStream()
                    {
                        Index = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.SubtitleStreamList[{j}].Index"),
                        Lang = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Streams.SubtitleStreamList[{j}].Lang")
                    };
                    subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				properties.Streams = streams;

                QueryJobListByPidResponse.Job.Output_.Properties_.Format_ format = new QueryJobListByPidResponse.Job.Output_.Properties_.Format_()
                {
                    NumStreams = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Format.NumStreams"),
                    NumPrograms = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Format.NumPrograms"),
                    FormatName = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Format.FormatName"),
                    FormatLongName = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Format.FormatLongName"),
                    StartTime = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Format.StartTime"),
                    Duration = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Format.Duration"),
                    Size = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Format.Size"),
                    Bitrate = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Properties.Format.Bitrate")
                };
                properties.Format = format;
				output.Properties = properties;

				QueryJobListByPidResponse.Job.Output_.Clip_ clip = new QueryJobListByPidResponse.Job.Output_.Clip_();

                QueryJobListByPidResponse.Job.Output_.Clip_.TimeSpan_ timeSpan = new QueryJobListByPidResponse.Job.Output_.Clip_.TimeSpan_()
                {
                    Seek = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Clip.TimeSpan.Seek"),
                    Duration = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Clip.TimeSpan.Duration")
                };
                clip.TimeSpan = timeSpan;
				output.Clip = clip;

                QueryJobListByPidResponse.Job.Output_.SuperReso_ superReso = new QueryJobListByPidResponse.Job.Output_.SuperReso_()
                {
                    IsHalfSample = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.SuperReso.IsHalfSample")
                };
                output.SuperReso = superReso;

				QueryJobListByPidResponse.Job.Output_.SubtitleConfig_ subtitleConfig = new QueryJobListByPidResponse.Job.Output_.SubtitleConfig_();

				List<QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.Subtitle> subtitleList = new List<QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.Subtitle>();
				for (int j = 0; j < context.Length($"QueryJobListByPid.JobList[{i}].Output.SubtitleConfig.SubtitleList.Length"); j++) {
                    QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.Subtitle subtitle = new QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.Subtitle()
                    {
                        Map = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.SubtitleConfig.SubtitleList[{j}].Map")
                    };
                    subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleList;

				List<QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.ExtSubtitle> extSubtitleList = new List<QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.ExtSubtitle>();
				for (int j = 0; j < context.Length($"QueryJobListByPid.JobList[{i}].Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.ExtSubtitle extSubtitle = new QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.ExtSubtitle();

                    QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_ extSubtitleInput = new QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_()
                    {
                        Bucket = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.SubtitleConfig.ExtSubtitleList[{j}].Input.Bucket"),
                        Location = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.SubtitleConfig.ExtSubtitleList[{j}].Input.Location"),
                        Object = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.SubtitleConfig.ExtSubtitleList[{j}].Input.Object")
                    };
                    extSubtitle.Input = extSubtitleInput;

					extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = extSubtitleList;
				output.SubtitleConfig = subtitleConfig;

                QueryJobListByPidResponse.Job.Output_.TransConfig_ transConfig = new QueryJobListByPidResponse.Job.Output_.TransConfig_()
                {
                    TransMode = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.TransConfig.TransMode")
                };
                output.TransConfig = transConfig;

				QueryJobListByPidResponse.Job.Output_.MuxConfig_ muxConfig = new QueryJobListByPidResponse.Job.Output_.MuxConfig_();

                QueryJobListByPidResponse.Job.Output_.MuxConfig_.Segment_ segment = new QueryJobListByPidResponse.Job.Output_.MuxConfig_.Segment_()
                {
                    Duration = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.MuxConfig.Segment.Duration")
                };
                muxConfig.Segment = segment;

                QueryJobListByPidResponse.Job.Output_.MuxConfig_.Gif_ gif = new QueryJobListByPidResponse.Job.Output_.MuxConfig_.Gif_()
                {
                    Loop = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.MuxConfig.Gif.Loop"),
                    FinalDelay = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.MuxConfig.Gif.FinalDelay")
                };
                muxConfig.Gif = gif;
				output.MuxConfig = muxConfig;

				QueryJobListByPidResponse.Job.Output_.TransFeatures_ transFeatures = new QueryJobListByPidResponse.Job.Output_.TransFeatures_();

				List<QueryJobListByPidResponse.Job.Output_.TransFeatures_.Merge> mergeList = new List<QueryJobListByPidResponse.Job.Output_.TransFeatures_.Merge>();
				for (int j = 0; j < context.Length($"QueryJobListByPid.JobList[{i}].Output.TransFeatures.MergeList.Length"); j++) {
                    QueryJobListByPidResponse.Job.Output_.TransFeatures_.Merge merge = new QueryJobListByPidResponse.Job.Output_.TransFeatures_.Merge()
                    {
                        MergeURL = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.TransFeatures.MergeList[{j}].MergeURL"),
                        Start = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.TransFeatures.MergeList[{j}].Start"),
                        Duration = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.TransFeatures.MergeList[{j}].Duration")
                    };
                    mergeList.Add(merge);
				}
				transFeatures.MergeList = mergeList;
				output.TransFeatures = transFeatures;

                QueryJobListByPidResponse.Job.Output_.Audio_ audio = new QueryJobListByPidResponse.Job.Output_.Audio_()
                {
                    Codec = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Audio.Codec"),
                    Profile = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Audio.Profile"),
                    Samplerate = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Audio.Samplerate"),
                    Bitrate = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Audio.Bitrate"),
                    Channels = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Audio.Channels"),
                    Qscale = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Audio.Qscale")
                };
                output.Audio = audio;

                QueryJobListByPidResponse.Job.Output_.Video_ video = new QueryJobListByPidResponse.Job.Output_.Video_()
                {
                    Codec = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.Codec"),
                    Profile = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.Profile"),
                    Bitrate = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.Bitrate"),
                    Crf = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.Crf"),
                    Width = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.Width"),
                    Height = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.Height"),
                    Fps = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.Fps"),
                    Gop = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.Gop"),
                    Preset = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.Preset"),
                    ScanMode = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.ScanMode"),
                    Bufsize = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.Bufsize"),
                    Maxrate = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.Maxrate"),
                    PixFmt = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.PixFmt"),
                    Degrain = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.Degrain"),
                    Qscale = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.Qscale")
                };
                QueryJobListByPidResponse.Job.Output_.Video_.BitrateBnd_ bitrateBnd = new QueryJobListByPidResponse.Job.Output_.Video_.BitrateBnd_()
                {
                    Max = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.BitrateBnd.Max"),
                    Min = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Video.BitrateBnd.Min")
                };
                video.BitrateBnd = bitrateBnd;
				output.Video = video;

                QueryJobListByPidResponse.Job.Output_.Container_ container = new QueryJobListByPidResponse.Job.Output_.Container_()
                {
                    Format = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.Container.Format")
                };
                output.Container = container;

				List<QueryJobListByPidResponse.Job.Output_.WaterMark> waterMarkList = new List<QueryJobListByPidResponse.Job.Output_.WaterMark>();
				for (int j = 0; j < context.Length($"QueryJobListByPid.JobList[{i}].Output.WaterMarkList.Length"); j++) {
                    QueryJobListByPidResponse.Job.Output_.WaterMark waterMark = new QueryJobListByPidResponse.Job.Output_.WaterMark()
                    {
                        WaterMarkTemplateId = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.WaterMarkList[{j}].WaterMarkTemplateId"),
                        Width = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.WaterMarkList[{j}].Width"),
                        Height = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.WaterMarkList[{j}].Height"),
                        Dx = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.WaterMarkList[{j}].Dx"),
                        Dy = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.WaterMarkList[{j}].Dy"),
                        ReferPos = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.WaterMarkList[{j}].ReferPos"),
                        Type = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.WaterMarkList[{j}].Type")
                    };
                    QueryJobListByPidResponse.Job.Output_.WaterMark.InputFile_ inputFile = new QueryJobListByPidResponse.Job.Output_.WaterMark.InputFile_()
                    {
                        Bucket = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.WaterMarkList[{j}].InputFile.Bucket"),
                        Location = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.WaterMarkList[{j}].InputFile.Location"),
                        Object = context.StringValue($"QueryJobListByPid.JobList[{i}].Output.WaterMarkList[{j}].InputFile.Object")
                    };
                    waterMark.InputFile = inputFile;

					waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = waterMarkList;
				job.Output = output;

				jobList.Add(job);
			}
			queryJobListByPidResponse.JobList = jobList;
        
			return queryJobListByPidResponse;
        }
    }
}