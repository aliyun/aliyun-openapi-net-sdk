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
    public class ListJobResponseUnmarshaller
    {
        public static ListJobResponse Unmarshall(UnmarshallerContext context)
        {
			ListJobResponse listJobResponse = new ListJobResponse();

			listJobResponse.HttpResponse = context.HttpResponse;
			listJobResponse.RequestId = context.StringValue("ListJob.RequestId");
			listJobResponse.NextPageToken = context.StringValue("ListJob.NextPageToken");

			List<ListJobResponse.ListJob_Job> listJobResponse_jobList = new List<ListJobResponse.ListJob_Job>();
			for (int i = 0; i < context.Length("ListJob.JobList.Length"); i++) {
				ListJobResponse.ListJob_Job job = new ListJobResponse.ListJob_Job();
				job.JobId = context.StringValue("ListJob.JobList["+ i +"].JobId");
				job.State = context.StringValue("ListJob.JobList["+ i +"].State");
				job.Code = context.StringValue("ListJob.JobList["+ i +"].Code");
				job.Message = context.StringValue("ListJob.JobList["+ i +"].Message");
				job.Percent = context.LongValue("ListJob.JobList["+ i +"].Percent");
				job.PipelineId = context.StringValue("ListJob.JobList["+ i +"].PipelineId");
				job.CreationTime = context.StringValue("ListJob.JobList["+ i +"].CreationTime");
				job.FinishTime = context.StringValue("ListJob.JobList["+ i +"].FinishTime");

				ListJobResponse.ListJob_Job.ListJob_Input input = new ListJobResponse.ListJob_Job.ListJob_Input();
				input.Bucket = context.StringValue("ListJob.JobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("ListJob.JobList["+ i +"].Input.Location");
				input._Object = context.StringValue("ListJob.JobList["+ i +"].Input.Object");
				job.Input = input;

				ListJobResponse.ListJob_Job.ListJob_Output output = new ListJobResponse.ListJob_Job.ListJob_Output();
				output.TemplateId = context.StringValue("ListJob.JobList["+ i +"].Output.TemplateId");
				output.UserData = context.StringValue("ListJob.JobList["+ i +"].Output.UserData");
				output.Rotate = context.StringValue("ListJob.JobList["+ i +"].Output.Rotate");
				output.VideoStreamMap = context.StringValue("ListJob.JobList["+ i +"].Output.VideoStreamMap");
				output.AudioStreamMap = context.StringValue("ListJob.JobList["+ i +"].Output.AudioStreamMap");
				output.DeWatermark = context.StringValue("ListJob.JobList["+ i +"].Output.DeWatermark");
				output.Priority = context.StringValue("ListJob.JobList["+ i +"].Output.Priority");
				output.WaterMarkConfigUrl = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkConfigUrl");
				output.MergeConfigUrl = context.StringValue("ListJob.JobList["+ i +"].Output.MergeConfigUrl");

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_OutputFile outputFile = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_OutputFile();
				outputFile.Bucket = context.StringValue("ListJob.JobList["+ i +"].Output.OutputFile.Bucket");
				outputFile.Location = context.StringValue("ListJob.JobList["+ i +"].Output.OutputFile.Location");
				outputFile._Object = context.StringValue("ListJob.JobList["+ i +"].Output.OutputFile.Object");
				outputFile.RoleArn = context.StringValue("ListJob.JobList["+ i +"].Output.OutputFile.RoleArn");
				output.OutputFile = outputFile;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_M3U8NonStandardSupport m3U8NonStandardSupport = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_M3U8NonStandardSupport();

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_M3U8NonStandardSupport.ListJob_TS tS = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_M3U8NonStandardSupport.ListJob_TS();
				tS.Md5Support = context.BooleanValue("ListJob.JobList["+ i +"].Output.M3U8NonStandardSupport.TS.Md5Support");
				tS.SizeSupport = context.BooleanValue("ListJob.JobList["+ i +"].Output.M3U8NonStandardSupport.TS.SizeSupport");
				m3U8NonStandardSupport.TS = tS;
				output.M3U8NonStandardSupport = m3U8NonStandardSupport;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties properties = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties();
				properties.Width = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Width");
				properties.Height = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Height");
				properties.Bitrate = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Bitrate");
				properties.Duration = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Duration");
				properties.Fps = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Fps");
				properties.FileSize = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.FileSize");
				properties.FileFormat = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.FileFormat");

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams streams = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams();

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_VideoStream> streams_videoStreamList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_VideoStream>();
				for (int j = 0; j < context.Length("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_VideoStream videoStream = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_VideoStream();
					videoStream.Index = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.CodecName = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.CodecLongName = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Profile = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.CodecTimeBase = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.CodecTagString = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.CodecTag = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.Width = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Height = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.HasBFrames = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Sar = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Dar = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.PixFmt = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Level = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Level");
					videoStream.Fps = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.AvgFPS = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.Timebase = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.StartTime = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Duration = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Bitrate = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.NumFrames = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Lang = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Lang");

					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_VideoStream.ListJob_NetworkCost networkCost = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_VideoStream.ListJob_NetworkCost();
					networkCost.PreloadTime = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_AudioStream> streams_audioStreamList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_AudioStream>();
				for (int j = 0; j < context.Length("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_AudioStream audioStream = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_AudioStream();
					audioStream.Index = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.CodecName = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.CodecTimeBase = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.CodecLongName = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.CodecTagString = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.CodecTag = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.SampleFmt = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.Samplerate = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.Channels = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.ChannelLayout = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Timebase = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.StartTime = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.Duration = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.Bitrate = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.NumFrames = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Lang = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Lang");

					streams_audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = streams_audioStreamList;

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_SubtitleStream> streams_subtitleStreamList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_SubtitleStream>();
				for (int j = 0; j < context.Length("ListJob.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_SubtitleStream subtitleStream = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_SubtitleStream();
					subtitleStream.Index = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					streams_subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = streams_subtitleStreamList;
				properties.Streams = streams;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Format format = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Format();
				format.NumStreams = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Format.NumStreams");
				format.NumPrograms = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Format.NumPrograms");
				format.FormatName = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Format.FormatName");
				format.FormatLongName = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Format.FormatLongName");
				format.StartTime = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Format.StartTime");
				format.Duration = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Format.Duration");
				format.Size = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Format.Size");
				format.Bitrate = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Format.Bitrate");
				properties.Format = format;
				output.Properties = properties;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Clip clip = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Clip();

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Clip.ListJob_TimeSpan timeSpan = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Clip.ListJob_TimeSpan();
				timeSpan.Seek = context.StringValue("ListJob.JobList["+ i +"].Output.Clip.TimeSpan.Seek");
				timeSpan.Duration = context.StringValue("ListJob.JobList["+ i +"].Output.Clip.TimeSpan.Duration");
				clip.TimeSpan = timeSpan;
				output.Clip = clip;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SuperReso superReso = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SuperReso();
				superReso.IsHalfSample = context.StringValue("ListJob.JobList["+ i +"].Output.SuperReso.IsHalfSample");
				output.SuperReso = superReso;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig subtitleConfig = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig();

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_Subtitle> subtitleConfig_subtitleList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_Subtitle>();
				for (int j = 0; j < context.Length("ListJob.JobList["+ i +"].Output.SubtitleConfig.SubtitleList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_Subtitle subtitle = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_Subtitle();
					subtitle.Map = context.StringValue("ListJob.JobList["+ i +"].Output.SubtitleConfig.SubtitleList["+ j +"].Map");

					subtitleConfig_subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleConfig_subtitleList;

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_ExtSubtitle> subtitleConfig_extSubtitleList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_ExtSubtitle>();
				for (int j = 0; j < context.Length("ListJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_ExtSubtitle extSubtitle = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_ExtSubtitle();
					extSubtitle.FontName = context.StringValue("ListJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].FontName");
					extSubtitle.CharEnc = context.StringValue("ListJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].CharEnc");

					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_ExtSubtitle.ListJob_Input3 input3 = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_ExtSubtitle.ListJob_Input3();
					input3.Bucket = context.StringValue("ListJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Bucket");
					input3.Location = context.StringValue("ListJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Location");
					input3._Object = context.StringValue("ListJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Object");
					extSubtitle.Input3 = input3;

					subtitleConfig_extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = subtitleConfig_extSubtitleList;
				output.SubtitleConfig = subtitleConfig;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_TransConfig transConfig = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_TransConfig();
				transConfig.TransMode = context.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.TransMode");
				transConfig.IsCheckReso = context.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.IsCheckReso");
				transConfig.IsCheckResoFail = context.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.IsCheckResoFail");
				transConfig.IsCheckVideoBitrate = context.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckAudioBitrate = context.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.IsCheckAudioBitrate");
				transConfig.AdjDarMethod = context.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.AdjDarMethod");
				transConfig.IsCheckVideoBitrateFail = context.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.IsCheckVideoBitrateFail");
				transConfig.IsCheckAudioBitrateFail = context.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.IsCheckAudioBitrateFail");
				output.TransConfig = transConfig;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_MuxConfig muxConfig = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_MuxConfig();

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_MuxConfig.ListJob_Segment segment = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_MuxConfig.ListJob_Segment();
				segment.Duration = context.StringValue("ListJob.JobList["+ i +"].Output.MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_MuxConfig.ListJob_Gif gif = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_MuxConfig.ListJob_Gif();
				gif.Loop = context.StringValue("ListJob.JobList["+ i +"].Output.MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("ListJob.JobList["+ i +"].Output.MuxConfig.Gif.FinalDelay");
				gif.IsCustomPalette = context.StringValue("ListJob.JobList["+ i +"].Output.MuxConfig.Gif.IsCustomPalette");
				gif.DitherMode = context.StringValue("ListJob.JobList["+ i +"].Output.MuxConfig.Gif.DitherMode");
				muxConfig.Gif = gif;
				output.MuxConfig = muxConfig;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Audio audio = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Audio();
				audio.Codec = context.StringValue("ListJob.JobList["+ i +"].Output.Audio.Codec");
				audio.Profile = context.StringValue("ListJob.JobList["+ i +"].Output.Audio.Profile");
				audio.Samplerate = context.StringValue("ListJob.JobList["+ i +"].Output.Audio.Samplerate");
				audio.Bitrate = context.StringValue("ListJob.JobList["+ i +"].Output.Audio.Bitrate");
				audio.Channels = context.StringValue("ListJob.JobList["+ i +"].Output.Audio.Channels");
				audio.Qscale = context.StringValue("ListJob.JobList["+ i +"].Output.Audio.Qscale");

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Audio.ListJob_Volume volume = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Audio.ListJob_Volume();
				volume.Level = context.StringValue("ListJob.JobList["+ i +"].Output.Audio.Volume.Level");
				volume.Method = context.StringValue("ListJob.JobList["+ i +"].Output.Audio.Volume.Method");
				audio.Volume = volume;
				output.Audio = audio;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Video video = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Video();
				video.Codec = context.StringValue("ListJob.JobList["+ i +"].Output.Video.Codec");
				video.Profile = context.StringValue("ListJob.JobList["+ i +"].Output.Video.Profile");
				video.Bitrate = context.StringValue("ListJob.JobList["+ i +"].Output.Video.Bitrate");
				video.Crf = context.StringValue("ListJob.JobList["+ i +"].Output.Video.Crf");
				video.Width = context.StringValue("ListJob.JobList["+ i +"].Output.Video.Width");
				video.Height = context.StringValue("ListJob.JobList["+ i +"].Output.Video.Height");
				video.Fps = context.StringValue("ListJob.JobList["+ i +"].Output.Video.Fps");
				video.Gop = context.StringValue("ListJob.JobList["+ i +"].Output.Video.Gop");
				video.Preset = context.StringValue("ListJob.JobList["+ i +"].Output.Video.Preset");
				video.ScanMode = context.StringValue("ListJob.JobList["+ i +"].Output.Video.ScanMode");
				video.Bufsize = context.StringValue("ListJob.JobList["+ i +"].Output.Video.Bufsize");
				video.Maxrate = context.StringValue("ListJob.JobList["+ i +"].Output.Video.Maxrate");
				video.PixFmt = context.StringValue("ListJob.JobList["+ i +"].Output.Video.PixFmt");
				video.Degrain = context.StringValue("ListJob.JobList["+ i +"].Output.Video.Degrain");
				video.Qscale = context.StringValue("ListJob.JobList["+ i +"].Output.Video.Qscale");
				video.Crop = context.StringValue("ListJob.JobList["+ i +"].Output.Video.Crop");
				video.Pad = context.StringValue("ListJob.JobList["+ i +"].Output.Video.Pad");
				video.MaxFps = context.StringValue("ListJob.JobList["+ i +"].Output.Video.MaxFps");

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Video.ListJob_BitrateBnd bitrateBnd = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Video.ListJob_BitrateBnd();
				bitrateBnd.Max = context.StringValue("ListJob.JobList["+ i +"].Output.Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("ListJob.JobList["+ i +"].Output.Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				output.Video = video;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Container container = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Container();
				container.Format = context.StringValue("ListJob.JobList["+ i +"].Output.Container.Format");
				output.Container = container;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Encryption encryption = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Encryption();
				encryption.Type = context.StringValue("ListJob.JobList["+ i +"].Output.Encryption.Type");
				encryption.Id = context.StringValue("ListJob.JobList["+ i +"].Output.Encryption.Id");
				encryption.Key = context.StringValue("ListJob.JobList["+ i +"].Output.Encryption.Key");
				encryption.KeyUri = context.StringValue("ListJob.JobList["+ i +"].Output.Encryption.KeyUri");
				encryption.KeyType = context.StringValue("ListJob.JobList["+ i +"].Output.Encryption.KeyType");
				encryption.SkipCnt = context.StringValue("ListJob.JobList["+ i +"].Output.Encryption.SkipCnt");
				output.Encryption = encryption;

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_WaterMark> output_waterMarkList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_WaterMark>();
				for (int j = 0; j < context.Length("ListJob.JobList["+ i +"].Output.WaterMarkList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_WaterMark waterMark = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_WaterMark();
					waterMark.WaterMarkTemplateId = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].WaterMarkTemplateId");
					waterMark.Width = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Width");
					waterMark.Height = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Height");
					waterMark.Dx = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dx");
					waterMark.Dy = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dy");
					waterMark.ReferPos = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].ReferPos");
					waterMark.Type = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Type");

					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_WaterMark.ListJob_InputFile inputFile = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_WaterMark.ListJob_InputFile();
					inputFile.Bucket = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Bucket");
					inputFile.Location = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Location");
					inputFile._Object = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Object");
					waterMark.InputFile = inputFile;

					output_waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = output_waterMarkList;

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Merge> output_mergeList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Merge>();
				for (int j = 0; j < context.Length("ListJob.JobList["+ i +"].Output.MergeList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Merge merge = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Merge();
					merge.MergeURL = context.StringValue("ListJob.JobList["+ i +"].Output.MergeList["+ j +"].MergeURL");
					merge.Start = context.StringValue("ListJob.JobList["+ i +"].Output.MergeList["+ j +"].Start");
					merge.Duration = context.StringValue("ListJob.JobList["+ i +"].Output.MergeList["+ j +"].Duration");
					merge.RoleArn = context.StringValue("ListJob.JobList["+ i +"].Output.MergeList["+ j +"].RoleArn");

					output_mergeList.Add(merge);
				}
				output.MergeList = output_mergeList;

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Merge1> output_openingList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Merge1>();
				for (int j = 0; j < context.Length("ListJob.JobList["+ i +"].Output.OpeningList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Merge1 merge1 = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Merge1();
					merge1.OpenUrl = context.StringValue("ListJob.JobList["+ i +"].Output.OpeningList["+ j +"].OpenUrl");
					merge1.Start = context.StringValue("ListJob.JobList["+ i +"].Output.OpeningList["+ j +"].Start");
					merge1.Width = context.StringValue("ListJob.JobList["+ i +"].Output.OpeningList["+ j +"].Width");
					merge1.Height = context.StringValue("ListJob.JobList["+ i +"].Output.OpeningList["+ j +"].Height");

					output_openingList.Add(merge1);
				}
				output.OpeningList = output_openingList;

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Merge2> output_tailSlateList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Merge2>();
				for (int j = 0; j < context.Length("ListJob.JobList["+ i +"].Output.TailSlateList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Merge2 merge2 = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Merge2();
					merge2.TailUrl = context.StringValue("ListJob.JobList["+ i +"].Output.TailSlateList["+ j +"].TailUrl");
					merge2.Start = context.StringValue("ListJob.JobList["+ i +"].Output.TailSlateList["+ j +"].Start");
					merge2.BlendDuration = context.StringValue("ListJob.JobList["+ i +"].Output.TailSlateList["+ j +"].BlendDuration");
					merge2.Width = context.StringValue("ListJob.JobList["+ i +"].Output.TailSlateList["+ j +"].Width");
					merge2.Height = context.StringValue("ListJob.JobList["+ i +"].Output.TailSlateList["+ j +"].Height");
					merge2.IsMergeAudio = context.BooleanValue("ListJob.JobList["+ i +"].Output.TailSlateList["+ j +"].IsMergeAudio");
					merge2.BgColor = context.StringValue("ListJob.JobList["+ i +"].Output.TailSlateList["+ j +"].BgColor");

					output_tailSlateList.Add(merge2);
				}
				output.TailSlateList = output_tailSlateList;
				job.Output = output;

				ListJobResponse.ListJob_Job.ListJob_MNSMessageResult mNSMessageResult = new ListJobResponse.ListJob_Job.ListJob_MNSMessageResult();
				mNSMessageResult.MessageId = context.StringValue("ListJob.JobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = context.StringValue("ListJob.JobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = context.StringValue("ListJob.JobList["+ i +"].MNSMessageResult.ErrorCode");
				job.MNSMessageResult = mNSMessageResult;

				listJobResponse_jobList.Add(job);
			}
			listJobResponse.JobList = listJobResponse_jobList;
        
			return listJobResponse;
        }
    }
}