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
    public class SubmitJobsResponseUnmarshaller
    {
        public static SubmitJobsResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitJobsResponse submitJobsResponse = new SubmitJobsResponse();

			submitJobsResponse.HttpResponse = context.HttpResponse;
			submitJobsResponse.RequestId = context.StringValue("SubmitJobs.RequestId");

			List<SubmitJobsResponse.JobResult> jobResultList = new List<SubmitJobsResponse.JobResult>();
			for (int i = 0; i < context.Length("SubmitJobs.JobResultList.Length"); i++) {
				SubmitJobsResponse.JobResult jobResult = new SubmitJobsResponse.JobResult();
				jobResult.Success = context.BooleanValue("SubmitJobs.JobResultList["+ i +"].Success");
				jobResult.Code = context.StringValue("SubmitJobs.JobResultList["+ i +"].Code");
				jobResult.Message = context.StringValue("SubmitJobs.JobResultList["+ i +"].Message");

				SubmitJobsResponse.JobResult.Job_ job = new SubmitJobsResponse.JobResult.Job_();
				job.JobId = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.JobId");
				job.State = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.State");
				job.Code = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Code");
				job.Message = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Message");
				job.Percent = context.LongValue("SubmitJobs.JobResultList["+ i +"].Job.Percent");
				job.PipelineId = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.PipelineId");
				job.CreationTime = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.CreationTime");

				SubmitJobsResponse.JobResult.Job_.Input_ input = new SubmitJobsResponse.JobResult.Job_.Input_();
				input.Bucket = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Input.Bucket");
				input.Location = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Input.Location");
				input.Object = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Input.Object");
				job.Input = input;

				SubmitJobsResponse.JobResult.Job_.Output_ output = new SubmitJobsResponse.JobResult.Job_.Output_();
				output.TemplateId = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TemplateId");
				output.UserData = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.UserData");
				output.Rotate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Rotate");
				output.VideoStreamMap = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.VideoStreamMap");
				output.AudioStreamMap = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.AudioStreamMap");
				output.DeWatermark = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DeWatermark");
				output.Priority = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Priority");

				SubmitJobsResponse.JobResult.Job_.Output_.OutputFile_ outputFile = new SubmitJobsResponse.JobResult.Job_.Output_.OutputFile_();
				outputFile.Bucket = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutputFile.Bucket");
				outputFile.Location = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutputFile.Location");
				outputFile.Object = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutputFile.Object");
				output.OutputFile = outputFile;

				SubmitJobsResponse.JobResult.Job_.Output_.Properties_ properties = new SubmitJobsResponse.JobResult.Job_.Output_.Properties_();
				properties.Width = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Width");
				properties.Height = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Height");
				properties.Bitrate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Bitrate");
				properties.Duration = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Duration");
				properties.Fps = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Fps");
				properties.FileSize = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.FileSize");
				properties.FileFormat = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.FileFormat");

				SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_ streams = new SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_();

				List<SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.VideoStream> videoStreamList = new List<SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList.Length"); j++) {
					SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.VideoStream videoStream = new SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.VideoStream();
					videoStream.Index = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.CodecName = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.CodecLongName = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Profile = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.CodecTimeBase = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.CodecTagString = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.CodecTag = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.Width = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Height = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.HasBFrames = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Sar = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Dar = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.PixFmt = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Level = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Level");
					videoStream.Fps = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.AvgFPS = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.Timebase = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.StartTime = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Duration = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Bitrate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.NumFrames = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Lang = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Lang");

					SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.VideoStream.NetworkCost_();
					networkCost.PreloadTime = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.AudioStream> audioStreamList = new List<SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList.Length"); j++) {
					SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.AudioStream audioStream = new SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.AudioStream();
					audioStream.Index = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.CodecName = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.CodecTimeBase = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.CodecLongName = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.CodecTagString = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.CodecTag = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.SampleFmt = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.Samplerate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.Channels = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.ChannelLayout = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Timebase = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.StartTime = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.Duration = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.Bitrate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.NumFrames = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Lang = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Lang");

					audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
					SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.SubtitleStream subtitleStream = new SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Streams_.SubtitleStream();
					subtitleStream.Index = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				properties.Streams = streams;

				SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Format_ format = new SubmitJobsResponse.JobResult.Job_.Output_.Properties_.Format_();
				format.NumStreams = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.NumStreams");
				format.NumPrograms = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.NumPrograms");
				format.FormatName = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.FormatName");
				format.FormatLongName = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.FormatLongName");
				format.StartTime = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.StartTime");
				format.Duration = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.Duration");
				format.Size = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.Size");
				format.Bitrate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.Bitrate");
				properties.Format = format;
				output.Properties = properties;

				SubmitJobsResponse.JobResult.Job_.Output_.Clip_ clip = new SubmitJobsResponse.JobResult.Job_.Output_.Clip_();

				SubmitJobsResponse.JobResult.Job_.Output_.Clip_.TimeSpan_ timeSpan = new SubmitJobsResponse.JobResult.Job_.Output_.Clip_.TimeSpan_();
				timeSpan.Seek = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Clip.TimeSpan.Seek");
				timeSpan.Duration = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Clip.TimeSpan.Duration");
				clip.TimeSpan = timeSpan;
				output.Clip = clip;

				SubmitJobsResponse.JobResult.Job_.Output_.SuperReso_ superReso = new SubmitJobsResponse.JobResult.Job_.Output_.SuperReso_();
				superReso.IsHalfSample = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SuperReso.IsHalfSample");
				output.SuperReso = superReso;

				SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_ subtitleConfig = new SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_();

				List<SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.Subtitle> subtitleList = new List<SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.Subtitle>();
				for (int j = 0; j < context.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.SubtitleList.Length"); j++) {
					SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.Subtitle subtitle = new SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.Subtitle();
					subtitle.Map = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.SubtitleList["+ j +"].Map");

					subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleList;

				List<SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.ExtSubtitle> extSubtitleList = new List<SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.ExtSubtitle>();
				for (int j = 0; j < context.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.ExtSubtitle extSubtitle = new SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.ExtSubtitle();

					SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.ExtSubtitle.Input_ extSubtitleInput_ = new SubmitJobsResponse.JobResult.Job_.Output_.SubtitleConfig_.ExtSubtitle.Input_();
					extSubtitleInput_.Bucket = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Bucket");
					extSubtitleInput_.Location = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Location");
					extSubtitleInput_.Object = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Object");
					extSubtitle.Input = extSubtitleInput_;

					extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = extSubtitleList;
				output.SubtitleConfig = subtitleConfig;

				SubmitJobsResponse.JobResult.Job_.Output_.TransConfig_ transConfig = new SubmitJobsResponse.JobResult.Job_.Output_.TransConfig_();
				transConfig.TransMode = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.TransMode");
				transConfig.IsCheckReso = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckReso");
				transConfig.IsCheckResoFail = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckResoFail");
				transConfig.IsCheckVideoBitrate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckAudioBitrate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckAudioBitrate");
				transConfig.AdjDarMethod = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.AdjDarMethod");
				output.TransConfig = transConfig;

				SubmitJobsResponse.JobResult.Job_.Output_.MuxConfig_ muxConfig = new SubmitJobsResponse.JobResult.Job_.Output_.MuxConfig_();

				SubmitJobsResponse.JobResult.Job_.Output_.MuxConfig_.Segment_ segment = new SubmitJobsResponse.JobResult.Job_.Output_.MuxConfig_.Segment_();
				segment.Duration = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				SubmitJobsResponse.JobResult.Job_.Output_.MuxConfig_.Gif_ gif = new SubmitJobsResponse.JobResult.Job_.Output_.MuxConfig_.Gif_();
				gif.Loop = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Gif.FinalDelay");
				gif.IsCustomPalette = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Gif.IsCustomPalette");
				gif.DitherMode = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Gif.DitherMode");
				muxConfig.Gif = gif;
				output.MuxConfig = muxConfig;

				SubmitJobsResponse.JobResult.Job_.Output_.Audio_ audio = new SubmitJobsResponse.JobResult.Job_.Output_.Audio_();
				audio.Codec = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Codec");
				audio.Profile = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Profile");
				audio.Samplerate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Samplerate");
				audio.Bitrate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Bitrate");
				audio.Channels = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Channels");
				audio.Qscale = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Qscale");
				output.Audio = audio;

				SubmitJobsResponse.JobResult.Job_.Output_.Video_ video = new SubmitJobsResponse.JobResult.Job_.Output_.Video_();
				video.Codec = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Codec");
				video.Profile = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Profile");
				video.Bitrate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Bitrate");
				video.Crf = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Crf");
				video.Width = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Width");
				video.Height = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Height");
				video.Fps = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Fps");
				video.Gop = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Gop");
				video.Preset = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Preset");
				video.ScanMode = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.ScanMode");
				video.Bufsize = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Bufsize");
				video.Maxrate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Maxrate");
				video.PixFmt = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.PixFmt");
				video.Degrain = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Degrain");
				video.Qscale = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Qscale");
				video.Crop = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Crop");
				video.Pad = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Pad");
				video.MaxFps = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.MaxFps");

				SubmitJobsResponse.JobResult.Job_.Output_.Video_.BitrateBnd_ bitrateBnd = new SubmitJobsResponse.JobResult.Job_.Output_.Video_.BitrateBnd_();
				bitrateBnd.Max = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				output.Video = video;

				SubmitJobsResponse.JobResult.Job_.Output_.Container_ container = new SubmitJobsResponse.JobResult.Job_.Output_.Container_();
				container.Format = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Container.Format");
				output.Container = container;

				List<SubmitJobsResponse.JobResult.Job_.Output_.WaterMark> waterMarkList = new List<SubmitJobsResponse.JobResult.Job_.Output_.WaterMark>();
				for (int j = 0; j < context.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList.Length"); j++) {
					SubmitJobsResponse.JobResult.Job_.Output_.WaterMark waterMark = new SubmitJobsResponse.JobResult.Job_.Output_.WaterMark();
					waterMark.WaterMarkTemplateId = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].WaterMarkTemplateId");
					waterMark.Width = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Width");
					waterMark.Height = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Height");
					waterMark.Dx = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Dx");
					waterMark.Dy = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Dy");
					waterMark.ReferPos = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].ReferPos");
					waterMark.Type = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Type");

					SubmitJobsResponse.JobResult.Job_.Output_.WaterMark.InputFile_ inputFile = new SubmitJobsResponse.JobResult.Job_.Output_.WaterMark.InputFile_();
					inputFile.Bucket = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].InputFile.Bucket");
					inputFile.Location = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].InputFile.Location");
					inputFile.Object = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].InputFile.Object");
					waterMark.InputFile = inputFile;

					waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = waterMarkList;

				List<SubmitJobsResponse.JobResult.Job_.Output_.Merge> mergeList = new List<SubmitJobsResponse.JobResult.Job_.Output_.Merge>();
				for (int j = 0; j < context.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList.Length"); j++) {
					SubmitJobsResponse.JobResult.Job_.Output_.Merge merge = new SubmitJobsResponse.JobResult.Job_.Output_.Merge();
					merge.MergeURL = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList["+ j +"].MergeURL");
					merge.Start = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList["+ j +"].Start");
					merge.Duration = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList["+ j +"].Duration");

					mergeList.Add(merge);
				}
				output.MergeList = mergeList;
				job.Output = output;

				SubmitJobsResponse.JobResult.Job_.MNSMessageResult_ mNSMessageResult = new SubmitJobsResponse.JobResult.Job_.MNSMessageResult_();
				mNSMessageResult.MessageId = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.MNSMessageResult.ErrorCode");
				job.MNSMessageResult = mNSMessageResult;
				jobResult.Job = job;

				jobResultList.Add(jobResult);
			}
			submitJobsResponse.JobResultList = jobResultList;
        
			return submitJobsResponse;
        }
    }
}