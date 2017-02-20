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
    public class QueryJobListResponseUnmarshaller
    {
        public static QueryJobListResponse Unmarshall(UnmarshallerContext context)
        {
            QueryJobListResponse queryJobListResponse = new QueryJobListResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryJobList.RequestId")
            };
            List<string> nonExistJobIds = new List<string>();
			for (int i = 0; i < context.Length("QueryJobList.NonExistJobIds.Length"); i++) {
				nonExistJobIds.Add(context.StringValue($"QueryJobList.NonExistJobIds[{i}]"));
			}
			queryJobListResponse.NonExistJobIds = nonExistJobIds;

			List<QueryJobListResponse.Job> jobList = new List<QueryJobListResponse.Job>();
			for (int i = 0; i < context.Length("QueryJobList.JobList.Length"); i++) {
                QueryJobListResponse.Job job = new QueryJobListResponse.Job()
                {
                    JobId = context.StringValue($"QueryJobList.JobList[{i}].JobId"),
                    State = context.StringValue($"QueryJobList.JobList[{i}].State"),
                    Code = context.StringValue($"QueryJobList.JobList[{i}].Code"),
                    Message = context.StringValue($"QueryJobList.JobList[{i}].Message"),
                    Percent = context.LongValue($"QueryJobList.JobList[{i}].Percent"),
                    PipelineId = context.StringValue($"QueryJobList.JobList[{i}].PipelineId"),
                    CreationTime = context.StringValue($"QueryJobList.JobList[{i}].CreationTime")
                };
                QueryJobListResponse.Job.Input_ input = new QueryJobListResponse.Job.Input_()
                {
                    Bucket = context.StringValue($"QueryJobList.JobList[{i}].Input.Bucket"),
                    Location = context.StringValue($"QueryJobList.JobList[{i}].Input.Location"),
                    Object = context.StringValue($"QueryJobList.JobList[{i}].Input.Object")
                };
                job.Input = input;

                QueryJobListResponse.Job.Output_ output = new QueryJobListResponse.Job.Output_()
                {
                    TemplateId = context.StringValue($"QueryJobList.JobList[{i}].Output.TemplateId"),
                    UserData = context.StringValue($"QueryJobList.JobList[{i}].Output.UserData"),
                    Rotate = context.StringValue($"QueryJobList.JobList[{i}].Output.Rotate"),
                    VideoStreamMap = context.StringValue($"QueryJobList.JobList[{i}].Output.VideoStreamMap"),
                    AudioStreamMap = context.StringValue($"QueryJobList.JobList[{i}].Output.AudioStreamMap"),
                    DeWatermark = context.StringValue($"QueryJobList.JobList[{i}].Output.DeWatermark"),
                    Priority = context.StringValue($"QueryJobList.JobList[{i}].Output.Priority")
                };
                QueryJobListResponse.Job.Output_.OutputFile_ outputFile = new QueryJobListResponse.Job.Output_.OutputFile_()
                {
                    Bucket = context.StringValue($"QueryJobList.JobList[{i}].Output.OutputFile.Bucket"),
                    Location = context.StringValue($"QueryJobList.JobList[{i}].Output.OutputFile.Location"),
                    Object = context.StringValue($"QueryJobList.JobList[{i}].Output.OutputFile.Object")
                };
                output.OutputFile = outputFile;

                QueryJobListResponse.Job.Output_.Properties_ properties = new QueryJobListResponse.Job.Output_.Properties_()
                {
                    Width = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Width"),
                    Height = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Height"),
                    Bitrate = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Bitrate"),
                    Duration = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Duration"),
                    Fps = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Fps"),
                    FileSize = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.FileSize"),
                    FileFormat = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.FileFormat")
                };
                QueryJobListResponse.Job.Output_.Properties_.Streams_ streams = new QueryJobListResponse.Job.Output_.Properties_.Streams_();

				List<QueryJobListResponse.Job.Output_.Properties_.Streams_.VideoStream> videoStreamList = new List<QueryJobListResponse.Job.Output_.Properties_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList.Length"); j++) {
                    QueryJobListResponse.Job.Output_.Properties_.Streams_.VideoStream videoStream = new QueryJobListResponse.Job.Output_.Properties_.Streams_.VideoStream()
                    {
                        Index = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Index"),
                        CodecName = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecName"),
                        CodecLongName = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecLongName"),
                        Profile = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Profile"),
                        CodecTimeBase = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecTimeBase"),
                        CodecTagString = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].CodecTag"),
                        Width = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Width"),
                        Height = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Height"),
                        HasBFrames = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].HasBFrames"),
                        Sar = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Sar"),
                        Dar = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Dar"),
                        PixFmt = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].PixFmt"),
                        Level = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Level"),
                        Fps = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Fps"),
                        AvgFps = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].AvgFPS"),
                        Timebase = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].Lang")
                    };
                    QueryJobListResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new QueryJobListResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_()
                    {
                        PreloadTime = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].NetworkCost.PreloadTime"),
                        CostBandwidth = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].NetworkCost.CostBandwidth"),
                        AvgBitrate = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.VideoStreamList[{j}].NetworkCost.AvgBitrate")
                    };
                    videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<QueryJobListResponse.Job.Output_.Properties_.Streams_.AudioStream> audioStreamList = new List<QueryJobListResponse.Job.Output_.Properties_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList.Length"); j++) {
                    QueryJobListResponse.Job.Output_.Properties_.Streams_.AudioStream audioStream = new QueryJobListResponse.Job.Output_.Properties_.Streams_.AudioStream()
                    {
                        Index = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Index"),
                        CodecName = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecName"),
                        CodecTimeBase = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecTimeBase"),
                        CodecLongName = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecLongName"),
                        CodecTagString = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecTagString"),
                        CodecTag = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].CodecTag"),
                        SampleFmt = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].SampleFmt"),
                        Samplerate = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Samplerate"),
                        Channels = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Channels"),
                        ChannelLayout = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].ChannelLayout"),
                        Timebase = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Timebase"),
                        StartTime = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].StartTime"),
                        Duration = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Duration"),
                        Bitrate = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Bitrate"),
                        NumFrames = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].NumFrames"),
                        Lang = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.AudioStreamList[{j}].Lang")
                    };
                    audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<QueryJobListResponse.Job.Output_.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<QueryJobListResponse.Job.Output_.Properties_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length($"QueryJobList.JobList[{i}].Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
                    QueryJobListResponse.Job.Output_.Properties_.Streams_.SubtitleStream subtitleStream = new QueryJobListResponse.Job.Output_.Properties_.Streams_.SubtitleStream()
                    {
                        Index = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.SubtitleStreamList[{j}].Index"),
                        Lang = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Streams.SubtitleStreamList[{j}].Lang")
                    };
                    subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				properties.Streams = streams;

                QueryJobListResponse.Job.Output_.Properties_.Format_ format = new QueryJobListResponse.Job.Output_.Properties_.Format_()
                {
                    NumStreams = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Format.NumStreams"),
                    NumPrograms = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Format.NumPrograms"),
                    FormatName = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Format.FormatName"),
                    FormatLongName = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Format.FormatLongName"),
                    StartTime = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Format.StartTime"),
                    Duration = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Format.Duration"),
                    Size = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Format.Size"),
                    Bitrate = context.StringValue($"QueryJobList.JobList[{i}].Output.Properties.Format.Bitrate")
                };
                properties.Format = format;
				output.Properties = properties;

				QueryJobListResponse.Job.Output_.Clip_ clip = new QueryJobListResponse.Job.Output_.Clip_();

                QueryJobListResponse.Job.Output_.Clip_.TimeSpan_ timeSpan = new QueryJobListResponse.Job.Output_.Clip_.TimeSpan_()
                {
                    Seek = context.StringValue($"QueryJobList.JobList[{i}].Output.Clip.TimeSpan.Seek"),
                    Duration = context.StringValue($"QueryJobList.JobList[{i}].Output.Clip.TimeSpan.Duration")
                };
                clip.TimeSpan = timeSpan;
				output.Clip = clip;

                QueryJobListResponse.Job.Output_.SuperReso_ superReso = new QueryJobListResponse.Job.Output_.SuperReso_()
                {
                    IsHalfSample = context.StringValue($"QueryJobList.JobList[{i}].Output.SuperReso.IsHalfSample")
                };
                output.SuperReso = superReso;

				QueryJobListResponse.Job.Output_.SubtitleConfig_ subtitleConfig = new QueryJobListResponse.Job.Output_.SubtitleConfig_();

				List<QueryJobListResponse.Job.Output_.SubtitleConfig_.Subtitle> subtitleList = new List<QueryJobListResponse.Job.Output_.SubtitleConfig_.Subtitle>();
				for (int j = 0; j < context.Length($"QueryJobList.JobList[{i}].Output.SubtitleConfig.SubtitleList.Length"); j++) {
                    QueryJobListResponse.Job.Output_.SubtitleConfig_.Subtitle subtitle = new QueryJobListResponse.Job.Output_.SubtitleConfig_.Subtitle()
                    {
                        Map = context.StringValue($"QueryJobList.JobList[{i}].Output.SubtitleConfig.SubtitleList[{j}].Map")
                    };
                    subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleList;

				List<QueryJobListResponse.Job.Output_.SubtitleConfig_.ExtSubtitle> extSubtitleList = new List<QueryJobListResponse.Job.Output_.SubtitleConfig_.ExtSubtitle>();
				for (int j = 0; j < context.Length($"QueryJobList.JobList[{i}].Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					QueryJobListResponse.Job.Output_.SubtitleConfig_.ExtSubtitle extSubtitle = new QueryJobListResponse.Job.Output_.SubtitleConfig_.ExtSubtitle();

                    QueryJobListResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_ extSubtitleInput = new QueryJobListResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_()
                    {
                        Bucket = context.StringValue($"QueryJobList.JobList[{i}].Output.SubtitleConfig.ExtSubtitleList[{j}].Input.Bucket"),
                        Location = context.StringValue($"QueryJobList.JobList[{i}].Output.SubtitleConfig.ExtSubtitleList[{j}].Input.Location"),
                        Object = context.StringValue($"QueryJobList.JobList[{i}].Output.SubtitleConfig.ExtSubtitleList[{j}].Input.Object")
                    };
                    extSubtitle.Input = extSubtitleInput;

					extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = extSubtitleList;
				output.SubtitleConfig = subtitleConfig;

                QueryJobListResponse.Job.Output_.TransConfig_ transConfig = new QueryJobListResponse.Job.Output_.TransConfig_()
                {
                    TransMode = context.StringValue($"QueryJobList.JobList[{i}].Output.TransConfig.TransMode"),
                    IsCheckReso = context.StringValue($"QueryJobList.JobList[{i}].Output.TransConfig.IsCheckReso"),
                    IsCheckResoFail = context.StringValue($"QueryJobList.JobList[{i}].Output.TransConfig.IsCheckResoFail"),
                    IsCheckVideoBitrate = context.StringValue($"QueryJobList.JobList[{i}].Output.TransConfig.IsCheckVideoBitrate"),
                    IsCheckAudioBitrate = context.StringValue($"QueryJobList.JobList[{i}].Output.TransConfig.IsCheckAudioBitrate"),
                    AdjDarMethod = context.StringValue($"QueryJobList.JobList[{i}].Output.TransConfig.AdjDarMethod")
                };
                output.TransConfig = transConfig;

				QueryJobListResponse.Job.Output_.MuxConfig_ muxConfig = new QueryJobListResponse.Job.Output_.MuxConfig_();

                QueryJobListResponse.Job.Output_.MuxConfig_.Segment_ segment = new QueryJobListResponse.Job.Output_.MuxConfig_.Segment_()
                {
                    Duration = context.StringValue($"QueryJobList.JobList[{i}].Output.MuxConfig.Segment.Duration")
                };
                muxConfig.Segment = segment;

                QueryJobListResponse.Job.Output_.MuxConfig_.Gif_ gif = new QueryJobListResponse.Job.Output_.MuxConfig_.Gif_()
                {
                    Loop = context.StringValue($"QueryJobList.JobList[{i}].Output.MuxConfig.Gif.Loop"),
                    FinalDelay = context.StringValue($"QueryJobList.JobList[{i}].Output.MuxConfig.Gif.FinalDelay"),
                    IsCustomPalette = context.StringValue($"QueryJobList.JobList[{i}].Output.MuxConfig.Gif.IsCustomPalette"),
                    DitherMode = context.StringValue($"QueryJobList.JobList[{i}].Output.MuxConfig.Gif.DitherMode")
                };
                muxConfig.Gif = gif;
				output.MuxConfig = muxConfig;

                QueryJobListResponse.Job.Output_.Audio_ audio = new QueryJobListResponse.Job.Output_.Audio_()
                {
                    Codec = context.StringValue($"QueryJobList.JobList[{i}].Output.Audio.Codec"),
                    Profile = context.StringValue($"QueryJobList.JobList[{i}].Output.Audio.Profile"),
                    Samplerate = context.StringValue($"QueryJobList.JobList[{i}].Output.Audio.Samplerate"),
                    Bitrate = context.StringValue($"QueryJobList.JobList[{i}].Output.Audio.Bitrate"),
                    Channels = context.StringValue($"QueryJobList.JobList[{i}].Output.Audio.Channels"),
                    Qscale = context.StringValue($"QueryJobList.JobList[{i}].Output.Audio.Qscale")
                };
                output.Audio = audio;

                QueryJobListResponse.Job.Output_.Video_ video = new QueryJobListResponse.Job.Output_.Video_()
                {
                    Codec = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.Codec"),
                    Profile = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.Profile"),
                    Bitrate = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.Bitrate"),
                    Crf = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.Crf"),
                    Width = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.Width"),
                    Height = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.Height"),
                    Fps = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.Fps"),
                    Gop = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.Gop"),
                    Preset = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.Preset"),
                    ScanMode = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.ScanMode"),
                    Bufsize = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.Bufsize"),
                    Maxrate = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.Maxrate"),
                    PixFmt = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.PixFmt"),
                    Degrain = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.Degrain"),
                    Qscale = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.Qscale"),
                    Crop = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.Crop"),
                    Pad = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.Pad"),
                    MaxFps = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.MaxFps")
                };
                QueryJobListResponse.Job.Output_.Video_.BitrateBnd_ bitrateBnd = new QueryJobListResponse.Job.Output_.Video_.BitrateBnd_()
                {
                    Max = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.BitrateBnd.Max"),
                    Min = context.StringValue($"QueryJobList.JobList[{i}].Output.Video.BitrateBnd.Min")
                };
                video.BitrateBnd = bitrateBnd;
				output.Video = video;

                QueryJobListResponse.Job.Output_.Container_ container = new QueryJobListResponse.Job.Output_.Container_()
                {
                    Format = context.StringValue($"QueryJobList.JobList[{i}].Output.Container.Format")
                };
                output.Container = container;

				List<QueryJobListResponse.Job.Output_.WaterMark> waterMarkList = new List<QueryJobListResponse.Job.Output_.WaterMark>();
				for (int j = 0; j < context.Length($"QueryJobList.JobList[{i}].Output.WaterMarkList.Length"); j++) {
                    QueryJobListResponse.Job.Output_.WaterMark waterMark = new QueryJobListResponse.Job.Output_.WaterMark()
                    {
                        WaterMarkTemplateId = context.StringValue($"QueryJobList.JobList[{i}].Output.WaterMarkList[{j}].WaterMarkTemplateId"),
                        Width = context.StringValue($"QueryJobList.JobList[{i}].Output.WaterMarkList[{j}].Width"),
                        Height = context.StringValue($"QueryJobList.JobList[{i}].Output.WaterMarkList[{j}].Height"),
                        Dx = context.StringValue($"QueryJobList.JobList[{i}].Output.WaterMarkList[{j}].Dx"),
                        Dy = context.StringValue($"QueryJobList.JobList[{i}].Output.WaterMarkList[{j}].Dy"),
                        ReferPos = context.StringValue($"QueryJobList.JobList[{i}].Output.WaterMarkList[{j}].ReferPos"),
                        Type = context.StringValue($"QueryJobList.JobList[{i}].Output.WaterMarkList[{j}].Type")
                    };
                    QueryJobListResponse.Job.Output_.WaterMark.InputFile_ inputFile = new QueryJobListResponse.Job.Output_.WaterMark.InputFile_()
                    {
                        Bucket = context.StringValue($"QueryJobList.JobList[{i}].Output.WaterMarkList[{j}].InputFile.Bucket"),
                        Location = context.StringValue($"QueryJobList.JobList[{i}].Output.WaterMarkList[{j}].InputFile.Location"),
                        Object = context.StringValue($"QueryJobList.JobList[{i}].Output.WaterMarkList[{j}].InputFile.Object")
                    };
                    waterMark.InputFile = inputFile;

					waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = waterMarkList;

				List<QueryJobListResponse.Job.Output_.Merge> mergeList = new List<QueryJobListResponse.Job.Output_.Merge>();
				for (int j = 0; j < context.Length($"QueryJobList.JobList[{i}].Output.MergeList.Length"); j++) {
                    QueryJobListResponse.Job.Output_.Merge merge = new QueryJobListResponse.Job.Output_.Merge()
                    {
                        MergeURL = context.StringValue($"QueryJobList.JobList[{i}].Output.MergeList[{j}].MergeURL"),
                        Start = context.StringValue($"QueryJobList.JobList[{i}].Output.MergeList[{j}].Start"),
                        Duration = context.StringValue($"QueryJobList.JobList[{i}].Output.MergeList[{j}].Duration")
                    };
                    mergeList.Add(merge);
				}
				output.MergeList = mergeList;
				job.Output = output;

                QueryJobListResponse.Job.MnsMessageResult_ mNsMessageResult = new QueryJobListResponse.Job.MnsMessageResult_()
                {
                    MessageId = context.StringValue($"QueryJobList.JobList[{i}].MNSMessageResult.MessageId"),
                    ErrorMessage = context.StringValue($"QueryJobList.JobList[{i}].MNSMessageResult.ErrorMessage"),
                    ErrorCode = context.StringValue($"QueryJobList.JobList[{i}].MNSMessageResult.ErrorCode")
                };
                job.MnsMessageResult = mNsMessageResult;

				jobList.Add(job);
			}
			queryJobListResponse.JobList = jobList;
        
			return queryJobListResponse;
        }
    }
}