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
    public class ListJobResponseUnmarshaller
    {
        public static ListJobResponse Unmarshall(UnmarshallerContext context)
        {
            ListJobResponse listJobResponse = new ListJobResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("ListJob.RequestId"),
                NextPageToken = context.StringValue("ListJob.NextPageToken")
            };
            List<ListJobResponse.Job> jobList = new List<ListJobResponse.Job>();
			for (int i = 0; i < context.Length("ListJob.JobList.Length"); i++) {
                ListJobResponse.Job job = new ListJobResponse.Job()
                {
                    JobId = context.StringValue($"ListJob.JobList[{i}].JobId"),
                    State = context.StringValue($"ListJob.JobList[{i}].State"),
                    Code = context.StringValue($"ListJob.JobList[{i}].Code"),
                    Message = context.StringValue($"ListJob.JobList[{i}].Message"),
                    Percent = context.LongValue($"ListJob.JobList[{i}].Percent"),
                    PipelineId = context.StringValue($"ListJob.JobList[{i}].PipelineId"),
                    CreationTime = context.StringValue($"ListJob.JobList[{i}].CreationTime")
                };
                ListJobResponse.Job.Input_ input = new ListJobResponse.Job.Input_()
                {
                    Bucket = context.StringValue($"ListJob.JobList[{i}].Input.Bucket"),
                    Location = context.StringValue($"ListJob.JobList[{i}].Input.Location"),
                    Object = context.StringValue($"ListJob.JobList[{i}].Input.Object")
                };
                job.Input = input;

                ListJobResponse.Job.Output_ output = new ListJobResponse.Job.Output_()
                {
                    TemplateId = context.StringValue($"ListJob.JobList[{i}].Output.TemplateId"),
                    UserData = context.StringValue($"ListJob.JobList[{i}].Output.UserData"),
                    Rotate = context.StringValue($"ListJob.JobList[{i}].Output.Rotate"),
                    VideoStreamMap = context.StringValue($"ListJob.JobList[{i}].Output.VideoStreamMap"),
                    AudioStreamMap = context.StringValue($"ListJob.JobList[{i}].Output.AudioStreamMap"),
                    DeWatermark = context.StringValue($"ListJob.JobList[{i}].Output.DeWatermark"),
                    Priority = context.StringValue($"ListJob.JobList[{i}].Output.Priority")
                };
                ListJobResponse.Job.Output_.OutputFile_ outputFile = new ListJobResponse.Job.Output_.OutputFile_()
                {
                    Bucket = context.StringValue($"ListJob.JobList[{i}].Output.OutputFile.Bucket"),
                    Location = context.StringValue($"ListJob.JobList[{i}].Output.OutputFile.Location"),
                    Object = context.StringValue($"ListJob.JobList[{i}].Output.OutputFile.Object")
                };
                output.OutputFile = outputFile;

                ListJobResponse.Job.Output_.Properties_ properties = new ListJobResponse.Job.Output_.Properties_()
                {
                    Width = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Width"),
                    Height = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Height"),
                    Bitrate = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Bitrate"),
                    Duration = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Duration"),
                    Fps = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Fps"),
                    FileSize = context.StringValue($"ListJob.JobList[{i}].Output.Properties.FileSize"),
                    FileFormat = context.StringValue($"ListJob.JobList[{i}].Output.Properties.FileFormat")
                };
                ListJobResponse.Job.Output_.Properties_.Streams_ streams = new ListJobResponse.Job.Output_.Properties_.Streams_();

				List<ListJobResponse.Job.Output_.Properties_.Streams_.VideoStream> videoStreamList = new List<ListJobResponse.Job.Output_.Properties_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList.Length"); j++) {
                    ListJobResponse.Job.Output_.Properties_.Streams_.VideoStream videoStream = new ListJobResponse.Job.Output_.Properties_.Streams_.VideoStream()
                    {
                        Index = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Index"),
                        CodecName = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecName"),
                        CodecLongName = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecLongName"),
                        Profile = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Profile"),
                        CodecTimeBase = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecTimeBase"),
                        CodecTagString = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecTag"),
                        Width = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Width"),
                        Height = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Height"),
                        HasBFrames = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].HasBFrames"),
                        Sar = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Sar"),
                        Dar = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Dar"),
                        PixFmt = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].PixFmt"),
                        Level = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Level"),
                        Fps = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Fps"),
                        AvgFps = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].AvgFPS"),
                        Timebase = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Lang")
                    };
                    ListJobResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new ListJobResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_()
                    {
                        PreloadTime = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].NetworkCost.PreloadTime"),
                        CostBandwidth = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].NetworkCost.CostBandwidth"),
                        AvgBitrate = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].NetworkCost.AvgBitrate")
                    };
                    videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<ListJobResponse.Job.Output_.Properties_.Streams_.AudioStream> audioStreamList = new List<ListJobResponse.Job.Output_.Properties_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList.Length"); j++) {
                    ListJobResponse.Job.Output_.Properties_.Streams_.AudioStream audioStream = new ListJobResponse.Job.Output_.Properties_.Streams_.AudioStream()
                    {
                        Index = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Index"),
                        CodecName = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecName"),
                        CodecTimeBase = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecTimeBase"),
                        CodecLongName = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecLongName"),
                        CodecTagString = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecTag"),
                        SampleFmt = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].SampleFmt"),
                        Samplerate = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Samplerate"),
                        Channels = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Channels"),
                        ChannelLayout = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].ChannelLayout"),
                        Timebase = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Lang")
                    };
                    audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<ListJobResponse.Job.Output_.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<ListJobResponse.Job.Output_.Properties_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length($"ListJob.JobList[{i}].Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
                    ListJobResponse.Job.Output_.Properties_.Streams_.SubtitleStream subtitleStream = new ListJobResponse.Job.Output_.Properties_.Streams_.SubtitleStream()
                    {
                        Index = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.SubtitleStreamList[{j}].Index"),
                        Lang = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Streams.SubtitleStreamList[{j}].Lang")
                    };
                    subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				properties.Streams = streams;

                ListJobResponse.Job.Output_.Properties_.Format_ format = new ListJobResponse.Job.Output_.Properties_.Format_()
                {
                    NumStreams = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Format.NumStreams"),
                    NumPrograms = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Format.NumPrograms"),
                    FormatName = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Format.FormatName"),
                    FormatLongName = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Format.FormatLongName"),
                    StartTime = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Format.StartTime"),
                    Duration = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Format.Duration"),
                    Size = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Format.Size"),
                    Bitrate = context.StringValue($"ListJob.JobList[{i}].Output.Properties.Format.Bitrate")
                };
                properties.Format = format;
				output.Properties = properties;

				ListJobResponse.Job.Output_.Clip_ clip = new ListJobResponse.Job.Output_.Clip_();

                ListJobResponse.Job.Output_.Clip_.TimeSpan_ timeSpan = new ListJobResponse.Job.Output_.Clip_.TimeSpan_()
                {
                    Seek = context.StringValue($"ListJob.JobList[{i}].Output.Clip.TimeSpan.Seek"),
                    Duration = context.StringValue($"ListJob.JobList[{i}].Output.Clip.TimeSpan.Duration")
                };
                clip.TimeSpan = timeSpan;
				output.Clip = clip;

                ListJobResponse.Job.Output_.SuperReso_ superReso = new ListJobResponse.Job.Output_.SuperReso_()
                {
                    IsHalfSample = context.StringValue($"ListJob.JobList[{i}].Output.SuperReso.IsHalfSample")
                };
                output.SuperReso = superReso;

				ListJobResponse.Job.Output_.SubtitleConfig_ subtitleConfig = new ListJobResponse.Job.Output_.SubtitleConfig_();

				List<ListJobResponse.Job.Output_.SubtitleConfig_.Subtitle> subtitleList = new List<ListJobResponse.Job.Output_.SubtitleConfig_.Subtitle>();
				for (int j = 0; j < context.Length($"ListJob.JobList[{i}].Output.SubtitleConfig.SubtitleList.Length"); j++) {
                    ListJobResponse.Job.Output_.SubtitleConfig_.Subtitle subtitle = new ListJobResponse.Job.Output_.SubtitleConfig_.Subtitle()
                    {
                        Map = context.StringValue($"ListJob.JobList[{i}].Output.SubtitleConfig.SubtitleList[{j}].Map")
                    };
                    subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleList;

				List<ListJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle> extSubtitleList = new List<ListJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle>();
				for (int j = 0; j < context.Length($"ListJob.JobList[{i}].Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					ListJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle extSubtitle = new ListJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle();

                    ListJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_ extSubtitleInput = new ListJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_()
                    {
                        Bucket = context.StringValue($"ListJob.JobList[{i}].Output.SubtitleConfig.ExtSubtitleList[{j}].Input.Bucket"),
                        Location = context.StringValue($"ListJob.JobList[{i}].Output.SubtitleConfig.ExtSubtitleList[{j}].Input.Location"),
                        Object = context.StringValue($"ListJob.JobList[{i}].Output.SubtitleConfig.ExtSubtitleList[{j}].Input.Object")
                    };
                    extSubtitle.Input = extSubtitleInput;

					extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = extSubtitleList;
				output.SubtitleConfig = subtitleConfig;

                ListJobResponse.Job.Output_.TransConfig_ transConfig = new ListJobResponse.Job.Output_.TransConfig_()
                {
                    TransMode = context.StringValue($"ListJob.JobList[{i}].Output.TransConfig.TransMode"),
                    IsCheckReso = context.StringValue($"ListJob.JobList[{i}].Output.TransConfig.IsCheckReso"),
                    IsCheckResoFail = context.StringValue($"ListJob.JobList[{i}].Output.TransConfig.IsCheckResoFail"),
                    IsCheckVideoBitrate = context.StringValue($"ListJob.JobList[{i}].Output.TransConfig.IsCheckVideoBitrate"),
                    IsCheckAudioBitrate = context.StringValue($"ListJob.JobList[{i}].Output.TransConfig.IsCheckAudioBitrate"),
                    AdjDarMethod = context.StringValue($"ListJob.JobList[{i}].Output.TransConfig.AdjDarMethod")
                };
                output.TransConfig = transConfig;

				ListJobResponse.Job.Output_.MuxConfig_ muxConfig = new ListJobResponse.Job.Output_.MuxConfig_();

                ListJobResponse.Job.Output_.MuxConfig_.Segment_ segment = new ListJobResponse.Job.Output_.MuxConfig_.Segment_()
                {
                    Duration = context.StringValue($"ListJob.JobList[{i}].Output.MuxConfig.Segment.Duration")
                };
                muxConfig.Segment = segment;

                ListJobResponse.Job.Output_.MuxConfig_.Gif_ gif = new ListJobResponse.Job.Output_.MuxConfig_.Gif_()
                {
                    Loop = context.StringValue($"ListJob.JobList[{i}].Output.MuxConfig.Gif.Loop"),
                    FinalDelay = context.StringValue($"ListJob.JobList[{i}].Output.MuxConfig.Gif.FinalDelay"),
                    IsCustomPalette = context.StringValue($"ListJob.JobList[{i}].Output.MuxConfig.Gif.IsCustomPalette"),
                    DitherMode = context.StringValue($"ListJob.JobList[{i}].Output.MuxConfig.Gif.DitherMode")
                };
                muxConfig.Gif = gif;
				output.MuxConfig = muxConfig;

                ListJobResponse.Job.Output_.Audio_ audio = new ListJobResponse.Job.Output_.Audio_()
                {
                    Codec = context.StringValue($"ListJob.JobList[{i}].Output.Audio.Codec"),
                    Profile = context.StringValue($"ListJob.JobList[{i}].Output.Audio.Profile"),
                    Samplerate = context.StringValue($"ListJob.JobList[{i}].Output.Audio.Samplerate"),
                    Bitrate = context.StringValue($"ListJob.JobList[{i}].Output.Audio.Bitrate"),
                    Channels = context.StringValue($"ListJob.JobList[{i}].Output.Audio.Channels"),
                    Qscale = context.StringValue($"ListJob.JobList[{i}].Output.Audio.Qscale")
                };
                output.Audio = audio;

                ListJobResponse.Job.Output_.Video_ video = new ListJobResponse.Job.Output_.Video_()
                {
                    Codec = context.StringValue($"ListJob.JobList[{i}].Output.Video.Codec"),
                    Profile = context.StringValue($"ListJob.JobList[{i}].Output.Video.Profile"),
                    Bitrate = context.StringValue($"ListJob.JobList[{i}].Output.Video.Bitrate"),
                    Crf = context.StringValue($"ListJob.JobList[{i}].Output.Video.Crf"),
                    Width = context.StringValue($"ListJob.JobList[{i}].Output.Video.Width"),
                    Height = context.StringValue($"ListJob.JobList[{i}].Output.Video.Height"),
                    Fps = context.StringValue($"ListJob.JobList[{i}].Output.Video.Fps"),
                    Gop = context.StringValue($"ListJob.JobList[{i}].Output.Video.Gop"),
                    Preset = context.StringValue($"ListJob.JobList[{i}].Output.Video.Preset"),
                    ScanMode = context.StringValue($"ListJob.JobList[{i}].Output.Video.ScanMode"),
                    Bufsize = context.StringValue($"ListJob.JobList[{i}].Output.Video.Bufsize"),
                    Maxrate = context.StringValue($"ListJob.JobList[{i}].Output.Video.Maxrate"),
                    PixFmt = context.StringValue($"ListJob.JobList[{i}].Output.Video.PixFmt"),
                    Degrain = context.StringValue($"ListJob.JobList[{i}].Output.Video.Degrain"),
                    Qscale = context.StringValue($"ListJob.JobList[{i}].Output.Video.Qscale"),
                    Crop = context.StringValue($"ListJob.JobList[{i}].Output.Video.Crop"),
                    Pad = context.StringValue($"ListJob.JobList[{i}].Output.Video.Pad"),
                    MaxFps = context.StringValue($"ListJob.JobList[{i}].Output.Video.MaxFps")
                };
                ListJobResponse.Job.Output_.Video_.BitrateBnd_ bitrateBnd = new ListJobResponse.Job.Output_.Video_.BitrateBnd_()
                {
                    Max = context.StringValue($"ListJob.JobList[{i}].Output.Video.BitrateBnd.Max"),
                    Min = context.StringValue($"ListJob.JobList[{i}].Output.Video.BitrateBnd.Min")
                };
                video.BitrateBnd = bitrateBnd;
				output.Video = video;

                ListJobResponse.Job.Output_.Container_ container = new ListJobResponse.Job.Output_.Container_()
                {
                    Format = context.StringValue($"ListJob.JobList[{i}].Output.Container.Format")
                };
                output.Container = container;

				List<ListJobResponse.Job.Output_.WaterMark> waterMarkList = new List<ListJobResponse.Job.Output_.WaterMark>();
				for (int j = 0; j < context.Length($"ListJob.JobList[{i}].Output.WaterMarkList.Length"); j++) {
                    ListJobResponse.Job.Output_.WaterMark waterMark = new ListJobResponse.Job.Output_.WaterMark()
                    {
                        WaterMarkTemplateId = context.StringValue($"ListJob.JobList[{i}].Output.WaterMarkList[{j}].WaterMarkTemplateId"),
                        Width = context.StringValue($"ListJob.JobList[{i}].Output.WaterMarkList[{j}].Width"),
                        Height = context.StringValue($"ListJob.JobList[{i}].Output.WaterMarkList[{j}].Height"),
                        Dx = context.StringValue($"ListJob.JobList[{i}].Output.WaterMarkList[{j}].Dx"),
                        Dy = context.StringValue($"ListJob.JobList[{i}].Output.WaterMarkList[{j}].Dy"),
                        ReferPos = context.StringValue($"ListJob.JobList[{i}].Output.WaterMarkList[{j}].ReferPos"),
                        Type = context.StringValue($"ListJob.JobList[{i}].Output.WaterMarkList[{j}].Type")
                    };
                    ListJobResponse.Job.Output_.WaterMark.InputFile_ inputFile = new ListJobResponse.Job.Output_.WaterMark.InputFile_()
                    {
                        Bucket = context.StringValue($"ListJob.JobList[{i}].Output.WaterMarkList[{j}].InputFile.Bucket"),
                        Location = context.StringValue($"ListJob.JobList[{i}].Output.WaterMarkList[{j}].InputFile.Location"),
                        Object = context.StringValue($"ListJob.JobList[{i}].Output.WaterMarkList[{j}].InputFile.Object")
                    };
                    waterMark.InputFile = inputFile;

					waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = waterMarkList;

				List<ListJobResponse.Job.Output_.Merge> mergeList = new List<ListJobResponse.Job.Output_.Merge>();
				for (int j = 0; j < context.Length($"ListJob.JobList[{i}].Output.MergeList.Length"); j++) {
                    ListJobResponse.Job.Output_.Merge merge = new ListJobResponse.Job.Output_.Merge()
                    {
                        MergeURL = context.StringValue($"ListJob.JobList[{i}].Output.MergeList[{j}].MergeURL"),
                        Start = context.StringValue($"ListJob.JobList[{i}].Output.MergeList[{j}].Start"),
                        Duration = context.StringValue($"ListJob.JobList[{i}].Output.MergeList[{j}].Duration")
                    };
                    mergeList.Add(merge);
				}
				output.MergeList = mergeList;
				job.Output = output;

                ListJobResponse.Job.MnsMessageResult_ mNsMessageResult = new ListJobResponse.Job.MnsMessageResult_()
                {
                    MessageId = context.StringValue($"ListJob.JobList[{i}].MNSMessageResult.MessageId"),
                    ErrorMessage = context.StringValue($"ListJob.JobList[{i}].MNSMessageResult.ErrorMessage"),
                    ErrorCode = context.StringValue($"ListJob.JobList[{i}].MNSMessageResult.ErrorCode")
                };
                job.MnsMessageResult = mNsMessageResult;

				jobList.Add(job);
			}
			listJobResponse.JobList = jobList;
        
			return listJobResponse;
        }
    }
}