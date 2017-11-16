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
    public class QueryJobListResponseUnmarshaller
    {
        public static QueryJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryJobListResponse queryJobListResponse = new QueryJobListResponse();

			queryJobListResponse.HttpResponse = context.HttpResponse;
			queryJobListResponse.RequestId = context.StringValue("QueryJobList.RequestId");

			List<string> queryJobListResponse_nonExistJobIds = new List<string>();
			for (int i = 0; i < context.Length("QueryJobList.NonExistJobIds.Length"); i++) {
				queryJobListResponse_nonExistJobIds.Add(context.StringValue("QueryJobList.NonExistJobIds["+ i +"]"));
			}
			queryJobListResponse.NonExistJobIds = queryJobListResponse_nonExistJobIds;

			List<QueryJobListResponse.QueryJobList_Job> queryJobListResponse_jobList = new List<QueryJobListResponse.QueryJobList_Job>();
			for (int i = 0; i < context.Length("QueryJobList.JobList.Length"); i++) {
				QueryJobListResponse.QueryJobList_Job job = new QueryJobListResponse.QueryJobList_Job();
				job.JobId = context.StringValue("QueryJobList.JobList["+ i +"].JobId");
				job.State = context.StringValue("QueryJobList.JobList["+ i +"].State");
				job.Code = context.StringValue("QueryJobList.JobList["+ i +"].Code");
				job.Message = context.StringValue("QueryJobList.JobList["+ i +"].Message");
				job.Percent = context.LongValue("QueryJobList.JobList["+ i +"].Percent");
				job.PipelineId = context.StringValue("QueryJobList.JobList["+ i +"].PipelineId");
				job.CreationTime = context.StringValue("QueryJobList.JobList["+ i +"].CreationTime");
				job.FinishTime = context.StringValue("QueryJobList.JobList["+ i +"].FinishTime");

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Input input = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Input();
				input.Bucket = context.StringValue("QueryJobList.JobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryJobList.JobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryJobList.JobList["+ i +"].Input.Object");
				job.Input = input;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output output = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output();
				output.TemplateId = context.StringValue("QueryJobList.JobList["+ i +"].Output.TemplateId");
				output.UserData = context.StringValue("QueryJobList.JobList["+ i +"].Output.UserData");
				output.Rotate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Rotate");
				output.VideoStreamMap = context.StringValue("QueryJobList.JobList["+ i +"].Output.VideoStreamMap");
				output.AudioStreamMap = context.StringValue("QueryJobList.JobList["+ i +"].Output.AudioStreamMap");
				output.DeWatermark = context.StringValue("QueryJobList.JobList["+ i +"].Output.DeWatermark");
				output.Priority = context.StringValue("QueryJobList.JobList["+ i +"].Output.Priority");
				output.WaterMarkConfigUrl = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkConfigUrl");
				output.MergeConfigUrl = context.StringValue("QueryJobList.JobList["+ i +"].Output.MergeConfigUrl");

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_OutputFile outputFile = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_OutputFile();
				outputFile.Bucket = context.StringValue("QueryJobList.JobList["+ i +"].Output.OutputFile.Bucket");
				outputFile.Location = context.StringValue("QueryJobList.JobList["+ i +"].Output.OutputFile.Location");
				outputFile._Object = context.StringValue("QueryJobList.JobList["+ i +"].Output.OutputFile.Object");
				outputFile.RoleArn = context.StringValue("QueryJobList.JobList["+ i +"].Output.OutputFile.RoleArn");
				output.OutputFile = outputFile;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_M3U8NonStandardSupport m3U8NonStandardSupport = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_M3U8NonStandardSupport();

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_M3U8NonStandardSupport.QueryJobList_TS tS = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_M3U8NonStandardSupport.QueryJobList_TS();
				tS.Md5Support = context.BooleanValue("QueryJobList.JobList["+ i +"].Output.M3U8NonStandardSupport.TS.Md5Support");
				tS.SizeSupport = context.BooleanValue("QueryJobList.JobList["+ i +"].Output.M3U8NonStandardSupport.TS.SizeSupport");
				m3U8NonStandardSupport.TS = tS;
				output.M3U8NonStandardSupport = m3U8NonStandardSupport;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties properties = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties();
				properties.Width = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Width");
				properties.Height = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Height");
				properties.Bitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Bitrate");
				properties.Duration = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Duration");
				properties.Fps = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Fps");
				properties.FileSize = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.FileSize");
				properties.FileFormat = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.FileFormat");

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams streams = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams();

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_VideoStream> streams_videoStreamList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_VideoStream>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_VideoStream videoStream = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_VideoStream();
					videoStream.Index = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.CodecName = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.CodecLongName = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Profile = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.CodecTimeBase = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.CodecTagString = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.CodecTag = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.Width = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Height = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.HasBFrames = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Sar = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Dar = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.PixFmt = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Level = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Level");
					videoStream.Fps = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.AvgFPS = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.Timebase = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.StartTime = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Duration = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Bitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.NumFrames = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Lang = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Lang");

					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_VideoStream.QueryJobList_NetworkCost networkCost = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_VideoStream.QueryJobList_NetworkCost();
					networkCost.PreloadTime = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_AudioStream> streams_audioStreamList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_AudioStream>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_AudioStream audioStream = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_AudioStream();
					audioStream.Index = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.CodecName = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.CodecTimeBase = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.CodecLongName = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.CodecTagString = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.CodecTag = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.SampleFmt = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.Samplerate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.Channels = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.ChannelLayout = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Timebase = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.StartTime = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.Duration = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.Bitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.NumFrames = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Lang = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Lang");

					streams_audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = streams_audioStreamList;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_SubtitleStream> streams_subtitleStreamList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_SubtitleStream>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_SubtitleStream subtitleStream = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_SubtitleStream();
					subtitleStream.Index = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					streams_subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = streams_subtitleStreamList;
				properties.Streams = streams;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Format format = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Format();
				format.NumStreams = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.NumStreams");
				format.NumPrograms = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.NumPrograms");
				format.FormatName = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.FormatName");
				format.FormatLongName = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.FormatLongName");
				format.StartTime = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.StartTime");
				format.Duration = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.Duration");
				format.Size = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.Size");
				format.Bitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.Bitrate");
				properties.Format = format;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_SourceLogo> properties_sourceLogos = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_SourceLogo>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.Properties.SourceLogos.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_SourceLogo sourceLogo = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_SourceLogo();
					sourceLogo.Source = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.SourceLogos["+ j +"].Source");

					properties_sourceLogos.Add(sourceLogo);
				}
				properties.SourceLogos = properties_sourceLogos;
				output.Properties = properties;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Clip clip = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Clip();

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Clip.QueryJobList_TimeSpan timeSpan = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Clip.QueryJobList_TimeSpan();
				timeSpan.Seek = context.StringValue("QueryJobList.JobList["+ i +"].Output.Clip.TimeSpan.Seek");
				timeSpan.Duration = context.StringValue("QueryJobList.JobList["+ i +"].Output.Clip.TimeSpan.Duration");
				clip.TimeSpan = timeSpan;
				output.Clip = clip;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SuperReso superReso = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SuperReso();
				superReso.IsHalfSample = context.StringValue("QueryJobList.JobList["+ i +"].Output.SuperReso.IsHalfSample");
				output.SuperReso = superReso;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig subtitleConfig = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig();

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_Subtitle> subtitleConfig_subtitleList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_Subtitle>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.SubtitleList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_Subtitle subtitle = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_Subtitle();
					subtitle.Map = context.StringValue("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.SubtitleList["+ j +"].Map");

					subtitleConfig_subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleConfig_subtitleList;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_ExtSubtitle> subtitleConfig_extSubtitleList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_ExtSubtitle>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_ExtSubtitle extSubtitle = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_ExtSubtitle();
					extSubtitle.FontName = context.StringValue("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].FontName");
					extSubtitle.CharEnc = context.StringValue("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].CharEnc");

					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_ExtSubtitle.QueryJobList_Input1 input1 = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_ExtSubtitle.QueryJobList_Input1();
					input1.Bucket = context.StringValue("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Bucket");
					input1.Location = context.StringValue("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Location");
					input1._Object = context.StringValue("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Object");
					extSubtitle.Input1 = input1;

					subtitleConfig_extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = subtitleConfig_extSubtitleList;
				output.SubtitleConfig = subtitleConfig;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_TransConfig transConfig = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_TransConfig();
				transConfig.TransMode = context.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.TransMode");
				transConfig.IsCheckReso = context.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.IsCheckReso");
				transConfig.IsCheckResoFail = context.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.IsCheckResoFail");
				transConfig.IsCheckVideoBitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckAudioBitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.IsCheckAudioBitrate");
				transConfig.AdjDarMethod = context.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.AdjDarMethod");
				transConfig.IsCheckVideoBitrateFail = context.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.IsCheckVideoBitrateFail");
				transConfig.IsCheckAudioBitrateFail = context.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.IsCheckAudioBitrateFail");
				output.TransConfig = transConfig;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_MuxConfig muxConfig = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_MuxConfig();

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_MuxConfig.QueryJobList_Segment segment = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_MuxConfig.QueryJobList_Segment();
				segment.Duration = context.StringValue("QueryJobList.JobList["+ i +"].Output.MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_MuxConfig.QueryJobList_Gif gif = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_MuxConfig.QueryJobList_Gif();
				gif.Loop = context.StringValue("QueryJobList.JobList["+ i +"].Output.MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("QueryJobList.JobList["+ i +"].Output.MuxConfig.Gif.FinalDelay");
				gif.IsCustomPalette = context.StringValue("QueryJobList.JobList["+ i +"].Output.MuxConfig.Gif.IsCustomPalette");
				gif.DitherMode = context.StringValue("QueryJobList.JobList["+ i +"].Output.MuxConfig.Gif.DitherMode");
				muxConfig.Gif = gif;
				output.MuxConfig = muxConfig;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Audio audio = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Audio();
				audio.Codec = context.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Codec");
				audio.Profile = context.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Profile");
				audio.Samplerate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Samplerate");
				audio.Bitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Bitrate");
				audio.Channels = context.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Channels");
				audio.Qscale = context.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Qscale");

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Audio.QueryJobList_Volume volume = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Audio.QueryJobList_Volume();
				volume.Level = context.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Volume.Level");
				volume.Method = context.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Volume.Method");
				audio.Volume = volume;
				output.Audio = audio;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Video video = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Video();
				video.Codec = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Codec");
				video.Profile = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Profile");
				video.Bitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Bitrate");
				video.Crf = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Crf");
				video.Width = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Width");
				video.Height = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Height");
				video.Fps = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Fps");
				video.Gop = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Gop");
				video.Preset = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Preset");
				video.ScanMode = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.ScanMode");
				video.Bufsize = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Bufsize");
				video.Maxrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Maxrate");
				video.PixFmt = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.PixFmt");
				video.Degrain = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Degrain");
				video.Qscale = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Qscale");
				video.Crop = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Crop");
				video.Pad = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Pad");
				video.MaxFps = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.MaxFps");

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Video.QueryJobList_BitrateBnd bitrateBnd = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Video.QueryJobList_BitrateBnd();
				bitrateBnd.Max = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				output.Video = video;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Container container = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Container();
				container.Format = context.StringValue("QueryJobList.JobList["+ i +"].Output.Container.Format");
				output.Container = container;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Encryption encryption = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Encryption();
				encryption.Type = context.StringValue("QueryJobList.JobList["+ i +"].Output.Encryption.Type");
				encryption.Id = context.StringValue("QueryJobList.JobList["+ i +"].Output.Encryption.Id");
				encryption.Key = context.StringValue("QueryJobList.JobList["+ i +"].Output.Encryption.Key");
				encryption.KeyUri = context.StringValue("QueryJobList.JobList["+ i +"].Output.Encryption.KeyUri");
				encryption.KeyType = context.StringValue("QueryJobList.JobList["+ i +"].Output.Encryption.KeyType");
				encryption.SkipCnt = context.StringValue("QueryJobList.JobList["+ i +"].Output.Encryption.SkipCnt");
				output.Encryption = encryption;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_WaterMark> output_waterMarkList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_WaterMark>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.WaterMarkList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_WaterMark waterMark = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_WaterMark();
					waterMark.WaterMarkTemplateId = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].WaterMarkTemplateId");
					waterMark.Width = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].Width");
					waterMark.Height = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].Height");
					waterMark.Dx = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dx");
					waterMark.Dy = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dy");
					waterMark.ReferPos = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].ReferPos");
					waterMark.Type = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].Type");

					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_WaterMark.QueryJobList_InputFile inputFile = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_WaterMark.QueryJobList_InputFile();
					inputFile.Bucket = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Bucket");
					inputFile.Location = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Location");
					inputFile._Object = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Object");
					waterMark.InputFile = inputFile;

					output_waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = output_waterMarkList;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Merge> output_mergeList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Merge>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.MergeList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Merge merge = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Merge();
					merge.MergeURL = context.StringValue("QueryJobList.JobList["+ i +"].Output.MergeList["+ j +"].MergeURL");
					merge.Start = context.StringValue("QueryJobList.JobList["+ i +"].Output.MergeList["+ j +"].Start");
					merge.Duration = context.StringValue("QueryJobList.JobList["+ i +"].Output.MergeList["+ j +"].Duration");
					merge.RoleArn = context.StringValue("QueryJobList.JobList["+ i +"].Output.MergeList["+ j +"].RoleArn");

					output_mergeList.Add(merge);
				}
				output.MergeList = output_mergeList;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Opening> output_openingList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Opening>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.OpeningList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Opening opening = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Opening();
					opening.OpenUrl = context.StringValue("QueryJobList.JobList["+ i +"].Output.OpeningList["+ j +"].OpenUrl");
					opening.Start = context.StringValue("QueryJobList.JobList["+ i +"].Output.OpeningList["+ j +"].Start");
					opening.Width = context.StringValue("QueryJobList.JobList["+ i +"].Output.OpeningList["+ j +"].Width");
					opening.Height = context.StringValue("QueryJobList.JobList["+ i +"].Output.OpeningList["+ j +"].Height");

					output_openingList.Add(opening);
				}
				output.OpeningList = output_openingList;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_TailSlate> output_tailSlateList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_TailSlate>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.TailSlateList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_TailSlate tailSlate = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_TailSlate();
					tailSlate.TailUrl = context.StringValue("QueryJobList.JobList["+ i +"].Output.TailSlateList["+ j +"].TailUrl");
					tailSlate.Start = context.StringValue("QueryJobList.JobList["+ i +"].Output.TailSlateList["+ j +"].Start");
					tailSlate.BlendDuration = context.StringValue("QueryJobList.JobList["+ i +"].Output.TailSlateList["+ j +"].BlendDuration");
					tailSlate.Width = context.StringValue("QueryJobList.JobList["+ i +"].Output.TailSlateList["+ j +"].Width");
					tailSlate.Height = context.StringValue("QueryJobList.JobList["+ i +"].Output.TailSlateList["+ j +"].Height");
					tailSlate.IsMergeAudio = context.BooleanValue("QueryJobList.JobList["+ i +"].Output.TailSlateList["+ j +"].IsMergeAudio");
					tailSlate.BgColor = context.StringValue("QueryJobList.JobList["+ i +"].Output.TailSlateList["+ j +"].BgColor");

					output_tailSlateList.Add(tailSlate);
				}
				output.TailSlateList = output_tailSlateList;
				job.Output = output;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_MNSMessageResult mNSMessageResult = new QueryJobListResponse.QueryJobList_Job.QueryJobList_MNSMessageResult();
				mNSMessageResult.MessageId = context.StringValue("QueryJobList.JobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = context.StringValue("QueryJobList.JobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = context.StringValue("QueryJobList.JobList["+ i +"].MNSMessageResult.ErrorCode");
				job.MNSMessageResult = mNSMessageResult;

				queryJobListResponse_jobList.Add(job);
			}
			queryJobListResponse.JobList = queryJobListResponse_jobList;
        
			return queryJobListResponse;
        }
    }
}