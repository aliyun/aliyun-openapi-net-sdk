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
    public class SubmitJobsResponseUnmarshaller
    {
        public static SubmitJobsResponse Unmarshall(UnmarshallerContext context)
        {
            SubmitJobsResponse submitJobsResponse = new SubmitJobsResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("SubmitJobs.RequestId")
            };
            List<SubmitJobsResponse.JobResult> jobResultList = new List<SubmitJobsResponse.JobResult>();
			for (int i = 0; i < context.Length("SubmitJobs.JobResultList.Length"); i++) {
                SubmitJobsResponse.JobResult jobResult = new SubmitJobsResponse.JobResult()
                {
                    Success = context.BooleanValue($"SubmitJobs.JobResultList[{i}].Success"),
                    Code = context.StringValue($"SubmitJobs.JobResultList[{i}].Code"),
                    Message = context.StringValue($"SubmitJobs.JobResultList[{i}].Message")
                };
                SubmitJobsResponse.JobResult.Job_ job = new SubmitJobsResponse.JobResult.Job_()
                {
                    JobId = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.JobId"),
                    State = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.State"),
                    Code = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Code"),
                    Message = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Message"),
                    Percent = context.LongValue($"SubmitJobs.JobResultList[{i}].Job.Percent"),
                    PipelineId = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.PipelineId"),
                    CreationTime = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.CreationTime")
                };
                SubmitJobsResponse.JobResult.Job_.Input_ input = new SubmitJobsResponse.JobResult.Job_.Input_()
                {
                    Bucket = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Input.Bucket"),
                    Location = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Input.Location"),
                    Object = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Input.Object")
                };
                job.Input = input;

                SubmitJobsResponse.JobResult.Job_.Output_ output = new SubmitJobsResponse.JobResult.Job_.Output_()
                {
                    TemplateId = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.TemplateId"),
                    UserData = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.UserData"),
                    Rotate = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Rotate"),
                    VideoStreamMap = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.VideoStreamMap"),
                    AudioStreamMap = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.AudioStreamMap"),
                    DeWatermark = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.DeWatermark"),
                    Priority = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Priority")
                };
                SubmitJobsResponse.JobResult.Job_.Output_.OutputFile_ outputFile = new SubmitJobsResponse.JobResult.Job_.Output_.OutputFile_()
                {
                    Bucket = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.OutputFile.Bucket"),
                    Location = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.OutputFile.Location"),
                    Object = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.OutputFile.Object")
                };
                output.OutputFile = outputFile;

                SubmitJobsResponse.JobResult.Job_.Output_.Properties_ properties = new SubmitJobsResponse.JobResult.Job_.Output_.Properties_()
                {
                    Width = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Width"),
                    Height = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Height"),
                    Bitrate = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Bitrate"),
                    Duration = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Duration"),
                    Fps = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Fps"),
                    FileSize = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.FileSize"),
                    FileFormat = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.FileFormat")
                };
                SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_ streams = new SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_();

				List<SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.VideoStream> videoStreamList = new List<SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList.Length"); j++) {
                    SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.VideoStream videoStream = new SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.VideoStream()
                    {
                        Index = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].Index"),
                        CodecName = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].CodecName"),
                        CodecLongName = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].CodecLongName"),
                        Profile = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].Profile"),
                        CodecTimeBase = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].CodecTimeBase"),
                        CodecTagString = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].CodecTag"),
                        Width = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].Width"),
                        Height = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].Height"),
                        HasBFrames = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].HasBFrames"),
                        Sar = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].Sar"),
                        Dar = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].Dar"),
                        PixFmt = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].PixFmt"),
                        Level = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].Level"),
                        Fps = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].Fps"),
                        AvgFps = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].AvgFPS"),
                        Timebase = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].Lang")
                    };
                    SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.VideoStream.NetworkCost_()
                    {
                        PreloadTime = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].NetworkCost.PreloadTime"),
                        CostBandwidth = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].NetworkCost.CostBandwidth"),
                        AvgBitrate = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.VideoStreamList[{j}].NetworkCost.AvgBitrate")
                    };
                    videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.AudioStream> audioStreamList = new List<SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList.Length"); j++) {
                    SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.AudioStream audioStream = new SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.AudioStream()
                    {
                        Index = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList[{j}].Index"),
                        CodecName = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList[{j}].CodecName"),
                        CodecTimeBase = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList[{j}].CodecTimeBase"),
                        CodecLongName = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList[{j}].CodecLongName"),
                        CodecTagString = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList[{j}].CodecTag"),
                        SampleFmt = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList[{j}].SampleFmt"),
                        Samplerate = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList[{j}].Samplerate"),
                        Channels = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList[{j}].Channels"),
                        ChannelLayout = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList[{j}].ChannelLayout"),
                        Timebase = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.AudioStreamList[{j}].Lang")
                    };
                    audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
                    SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.SubtitleStream subtitleStream = new SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.SubtitleStream()
                    {
                        Index = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.SubtitleStreamList[{j}].Index"),
                        Lang = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Streams.SubtitleStreamList[{j}].Lang")
                    };
                    subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				properties.Streams = streams;

                SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Format_ format = new SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Format_()
                {
                    NumStreams = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Format.NumStreams"),
                    NumPrograms = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Format.NumPrograms"),
                    FormatName = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Format.FormatName"),
                    FormatLongName = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Format.FormatLongName"),
                    StartTime = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Format.StartTime"),
                    Duration = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Format.Duration"),
                    Size = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Format.Size"),
                    Bitrate = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Properties.Format.Bitrate")
                };
                properties.Format = format;
				output.Properties = properties;

				SubmitJobsResponse.JobResult.Job_.Output_.Clip_ clip = new SubmitJobsResponse.JobResult.Job_.Output_.Clip_();

                SubmitJobsResponse.JobResult.Job_.Output_.Clip_.TimeSpan_ timeSpan = new SubmitJobsResponse.JobResult.Job_.Output_.Clip_.TimeSpan_()
                {
                    Seek = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Clip.TimeSpan.Seek"),
                    Duration = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Clip.TimeSpan.Duration")
                };
                clip.TimeSpan = timeSpan;
				output.Clip = clip;

                SubmitJobsResponse.JobResult.Job_.Output_.SuperReso_ superReso = new SubmitJobsResponse.JobResult.Job_.Output_.SuperReso_()
                {
                    IsHalfSample = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.SuperReso.IsHalfSample")
                };
                output.SuperReso = superReso;

				SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_ subtitleConfig = new SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_();

				List<SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.Subtitle> subtitleList = new List<SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.Subtitle>();
				for (int j = 0; j < context.Length($"SubmitJobs.JobResultList[{i}].Job.Output.SubtitleConfig.SubtitleList.Length"); j++) {
                    SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.Subtitle subtitle = new SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.Subtitle()
                    {
                        Map = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.SubtitleConfig.SubtitleList[{j}].Map")
                    };
                    subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleList;

				List<SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.ExtSubtitle> extSubtitleList = new List<SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.ExtSubtitle>();
				for (int j = 0; j < context.Length($"SubmitJobs.JobResultList[{i}].Job.Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.ExtSubtitle extSubtitle = new SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.ExtSubtitle();

                    SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.ExtSubtitle.Input_ extSubtitleInput = new SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.ExtSubtitle.Input_()
                    {
                        Bucket = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.SubtitleConfig.ExtSubtitleList[{j}].Input.Bucket"),
                        Location = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.SubtitleConfig.ExtSubtitleList[{j}].Input.Location"),
                        Object = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.SubtitleConfig.ExtSubtitleList[{j}].Input.Object")
                    };
                    extSubtitle.Input = extSubtitleInput;

					extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = extSubtitleList;
				output.SubtitleConfig = subtitleConfig;

                SubmitJobsResponse.JobResult.Job_.Output_.TransConfig_ transConfig = new SubmitJobsResponse.JobResult.Job_.Output_.TransConfig_()
                {
                    TransMode = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.TransConfig.TransMode"),
                    IsCheckReso = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.TransConfig.IsCheckReso"),
                    IsCheckResoFail = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.TransConfig.IsCheckResoFail"),
                    IsCheckVideoBitrate = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.TransConfig.IsCheckVideoBitrate"),
                    IsCheckAudioBitrate = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.TransConfig.IsCheckAudioBitrate"),
                    AdjDarMethod = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.TransConfig.AdjDarMethod")
                };
                output.TransConfig = transConfig;

				SubmitJobsResponse.JobResult.Job_.Output_.MuxConfig_ muxConfig = new SubmitJobsResponse.JobResult.Job_.Output_.MuxConfig_();

                SubmitJobsResponse.JobResult.Job_.Output_.MuxConfig_.Segment_ segment = new SubmitJobsResponse.JobResult.Job_.Output_.MuxConfig_.Segment_()
                {
                    Duration = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.MuxConfig.Segment.Duration")
                };
                muxConfig.Segment = segment;

                SubmitJobsResponse.JobResult.Job_.Output_.MuxConfig_.Gif_ gif = new SubmitJobsResponse.JobResult.Job_.Output_.MuxConfig_.Gif_()
                {
                    Loop = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.MuxConfig.Gif.Loop"),
                    FinalDelay = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.MuxConfig.Gif.FinalDelay"),
                    IsCustomPalette = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.MuxConfig.Gif.IsCustomPalette"),
                    DitherMode = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.MuxConfig.Gif.DitherMode")
                };
                muxConfig.Gif = gif;
				output.MuxConfig = muxConfig;

                SubmitJobsResponse.JobResult.Job_.Output_.Audio_ audio = new SubmitJobsResponse.JobResult.Job_.Output_.Audio_()
                {
                    Codec = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Audio.Codec"),
                    Profile = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Audio.Profile"),
                    Samplerate = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Audio.Samplerate"),
                    Bitrate = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Audio.Bitrate"),
                    Channels = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Audio.Channels"),
                    Qscale = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Audio.Qscale")
                };
                output.Audio = audio;

                SubmitJobsResponse.JobResult.Job_.Output_.Video_ video = new SubmitJobsResponse.JobResult.Job_.Output_.Video_()
                {
                    Codec = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.Codec"),
                    Profile = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.Profile"),
                    Bitrate = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.Bitrate"),
                    Crf = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.Crf"),
                    Width = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.Width"),
                    Height = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.Height"),
                    Fps = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.Fps"),
                    Gop = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.Gop"),
                    Preset = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.Preset"),
                    ScanMode = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.ScanMode"),
                    Bufsize = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.Bufsize"),
                    Maxrate = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.Maxrate"),
                    PixFmt = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.PixFmt"),
                    Degrain = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.Degrain"),
                    Qscale = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.Qscale"),
                    Crop = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.Crop"),
                    Pad = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.Pad"),
                    MaxFps = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.MaxFps")
                };
                SubmitJobsResponse.JobResult.Job_.Output_.Video_.BitrateBnd_ bitrateBnd = new SubmitJobsResponse.JobResult.Job_.Output_.Video_.BitrateBnd_()
                {
                    Max = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.BitrateBnd.Max"),
                    Min = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Video.BitrateBnd.Min")
                };
                video.BitrateBnd = bitrateBnd;
				output.Video = video;

                SubmitJobsResponse.JobResult.Job_.Output_.Container_ container = new SubmitJobsResponse.JobResult.Job_.Output_.Container_()
                {
                    Format = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.Container.Format")
                };
                output.Container = container;

				List<SubmitJobsResponse.JobResult.Job_.Output_.WaterMark> waterMarkList = new List<SubmitJobsResponse.JobResult.Job_.Output_.WaterMark>();
				for (int j = 0; j < context.Length($"SubmitJobs.JobResultList[{i}].Job.Output.WaterMarkList.Length"); j++) {
                    SubmitJobsResponse.JobResult.Job_.Output_.WaterMark waterMark = new SubmitJobsResponse.JobResult.Job_.Output_.WaterMark()
                    {
                        WaterMarkTemplateId = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.WaterMarkList[{j}].WaterMarkTemplateId"),
                        Width = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.WaterMarkList[{j}].Width"),
                        Height = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.WaterMarkList[{j}].Height"),
                        Dx = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.WaterMarkList[{j}].Dx"),
                        Dy = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.WaterMarkList[{j}].Dy"),
                        ReferPos = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.WaterMarkList[{j}].ReferPos"),
                        Type = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.WaterMarkList[{j}].Type")
                    };
                    SubmitJobsResponse.JobResult.Job_.Output_.WaterMark.InputFile_ inputFile = new SubmitJobsResponse.JobResult.Job_.Output_.WaterMark.InputFile_()
                    {
                        Bucket = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.WaterMarkList[{j}].InputFile.Bucket"),
                        Location = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.WaterMarkList[{j}].InputFile.Location"),
                        Object = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.WaterMarkList[{j}].InputFile.Object")
                    };
                    waterMark.InputFile = inputFile;

					waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = waterMarkList;

				List<SubmitJobsResponse.JobResult.Job_.Output_.Merge> mergeList = new List<SubmitJobsResponse.JobResult.Job_.Output_.Merge>();
				for (int j = 0; j < context.Length($"SubmitJobs.JobResultList[{i}].Job.Output.MergeList.Length"); j++) {
                    SubmitJobsResponse.JobResult.Job_.Output_.Merge merge = new SubmitJobsResponse.JobResult.Job_.Output_.Merge()
                    {
                        MergeURL = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.MergeList[{j}].MergeURL"),
                        Start = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.MergeList[{j}].Start"),
                        Duration = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.Output.MergeList[{j}].Duration")
                    };
                    mergeList.Add(merge);
				}
				output.MergeList = mergeList;
				job.Output = output;

                SubmitJobsResponse.JobResult.Job_.MnsMessageResult_ mNsMessageResult = new SubmitJobsResponse.JobResult.Job_.MnsMessageResult_()
                {
                    MessageId = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.MNSMessageResult.MessageId"),
                    ErrorMessage = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.MNSMessageResult.ErrorMessage"),
                    ErrorCode = context.StringValue($"SubmitJobs.JobResultList[{i}].Job.MNSMessageResult.ErrorCode")
                };
                job.MnsMessageResult = mNsMessageResult;
				jobResult.Job = job;

				jobResultList.Add(jobResult);
			}
			submitJobsResponse.JobResultList = jobResultList;
        
			return submitJobsResponse;
        }
    }
}