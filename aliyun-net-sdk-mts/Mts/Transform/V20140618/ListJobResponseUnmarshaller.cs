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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class ListJobResponseUnmarshaller
    {
        public static ListJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJobResponse listJobResponse = new ListJobResponse();

			listJobResponse.HttpResponse = _ctx.HttpResponse;
			listJobResponse.RequestId = _ctx.StringValue("ListJob.RequestId");
			listJobResponse.NextPageToken = _ctx.StringValue("ListJob.NextPageToken");

			List<ListJobResponse.ListJob_Job> listJobResponse_jobList = new List<ListJobResponse.ListJob_Job>();
			for (int i = 0; i < _ctx.Length("ListJob.JobList.Length"); i++) {
				ListJobResponse.ListJob_Job job = new ListJobResponse.ListJob_Job();
				job.CreationTime = _ctx.StringValue("ListJob.JobList["+ i +"].CreationTime");
				job.Percent = _ctx.LongValue("ListJob.JobList["+ i +"].Percent");
				job.FinishTime = _ctx.StringValue("ListJob.JobList["+ i +"].FinishTime");
				job.State = _ctx.StringValue("ListJob.JobList["+ i +"].State");
				job.JobId = _ctx.StringValue("ListJob.JobList["+ i +"].JobId");
				job.Code = _ctx.StringValue("ListJob.JobList["+ i +"].Code");
				job.Message = _ctx.StringValue("ListJob.JobList["+ i +"].Message");
				job.PipelineId = _ctx.StringValue("ListJob.JobList["+ i +"].PipelineId");

				ListJobResponse.ListJob_Job.ListJob_Output output = new ListJobResponse.ListJob_Job.ListJob_Output();
				output.WaterMarkConfigUrl = _ctx.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkConfigUrl");
				output.DeWatermark = _ctx.StringValue("ListJob.JobList["+ i +"].Output.DeWatermark");
				output.Priority = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Priority");
				output.AudioStreamMap = _ctx.StringValue("ListJob.JobList["+ i +"].Output.AudioStreamMap");
				output.UserData = _ctx.StringValue("ListJob.JobList["+ i +"].Output.UserData");
				output.VideoStreamMap = _ctx.StringValue("ListJob.JobList["+ i +"].Output.VideoStreamMap");
				output.Rotate = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Rotate");
				output.MergeConfigUrl = _ctx.StringValue("ListJob.JobList["+ i +"].Output.MergeConfigUrl");
				output.TemplateId = _ctx.StringValue("ListJob.JobList["+ i +"].Output.TemplateId");

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Video video = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Video();
				video.Bufsize = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.Bufsize");
				video.Degrain = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.Degrain");
				video.PixFmt = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.PixFmt");
				video.Pad = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.Pad");
				video.Codec = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.Codec");
				video.Height = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.Height");
				video.Qscale = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.Qscale");
				video.Crop = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.Crop");
				video.Bitrate = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.Bitrate");
				video.Maxrate = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.Maxrate");
				video.MaxFps = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.MaxFps");
				video.Profile = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.Profile");
				video.Crf = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.Crf");
				video.Gop = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.Gop");
				video.Width = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.Width");
				video.Fps = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.Fps");
				video.Preset = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.Preset");
				video.ScanMode = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.ScanMode");
				video.ResoPriority = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.ResoPriority");

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Video.ListJob_BitrateBnd bitrateBnd = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Video.ListJob_BitrateBnd();
				bitrateBnd.Max = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.BitrateBnd.Max");
				bitrateBnd.Min = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				output.Video = video;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_TransConfig transConfig = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_TransConfig();
				transConfig.IsCheckAudioBitrate = _ctx.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.IsCheckAudioBitrate");
				transConfig.TransMode = _ctx.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.TransMode");
				transConfig.IsCheckReso = _ctx.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.IsCheckReso");
				transConfig.IsCheckVideoBitrateFail = _ctx.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.IsCheckVideoBitrateFail");
				transConfig.AdjDarMethod = _ctx.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.AdjDarMethod");
				transConfig.IsCheckVideoBitrate = _ctx.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckResoFail = _ctx.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.IsCheckResoFail");
				transConfig.IsCheckAudioBitrateFail = _ctx.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.IsCheckAudioBitrateFail");
				output.TransConfig = transConfig;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Encryption encryption = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Encryption();
				encryption.Type = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Encryption.Type");
				encryption.Key = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Encryption.Key");
				encryption.KeyType = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Encryption.KeyType");
				encryption.Id = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Encryption.Id");
				encryption.KeyUri = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Encryption.KeyUri");
				encryption.SkipCnt = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Encryption.SkipCnt");
				output.Encryption = encryption;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_M3U8NonStandardSupport m3U8NonStandardSupport = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_M3U8NonStandardSupport();

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_M3U8NonStandardSupport.ListJob_TS tS = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_M3U8NonStandardSupport.ListJob_TS();
				tS.SizeSupport = _ctx.BooleanValue("ListJob.JobList["+ i +"].Output.M3U8NonStandardSupport.TS.SizeSupport");
				tS.Md5Support = _ctx.BooleanValue("ListJob.JobList["+ i +"].Output.M3U8NonStandardSupport.TS.Md5Support");
				m3U8NonStandardSupport.TS = tS;
				output.M3U8NonStandardSupport = m3U8NonStandardSupport;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Audio audio = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Audio();
				audio.Profile = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Audio.Profile");
				audio.Codec = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Audio.Codec");
				audio.Samplerate = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Audio.Samplerate");
				audio.Qscale = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Audio.Qscale");
				audio.Channels = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Audio.Channels");
				audio.Bitrate = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Audio.Bitrate");

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Audio.ListJob_Volume volume = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Audio.ListJob_Volume();
				volume.Method = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Audio.Volume.Method");
				volume.Level = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Audio.Volume.Level");
				audio.Volume = volume;
				output.Audio = audio;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SuperReso superReso = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SuperReso();
				superReso.IsHalfSample = _ctx.StringValue("ListJob.JobList["+ i +"].Output.SuperReso.IsHalfSample");
				output.SuperReso = superReso;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_OutputFile outputFile = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_OutputFile();
				outputFile.RoleArn = _ctx.StringValue("ListJob.JobList["+ i +"].Output.OutputFile.RoleArn");
				outputFile._Object = _ctx.StringValue("ListJob.JobList["+ i +"].Output.OutputFile.Object");
				outputFile.Location = _ctx.StringValue("ListJob.JobList["+ i +"].Output.OutputFile.Location");
				outputFile.Bucket = _ctx.StringValue("ListJob.JobList["+ i +"].Output.OutputFile.Bucket");
				output.OutputFile = outputFile;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Container container = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Container();
				container.Format = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Container.Format");
				output.Container = container;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Clip clip = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Clip();

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Clip.ListJob_TimeSpan timeSpan = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Clip.ListJob_TimeSpan();
				timeSpan.Seek = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Clip.TimeSpan.Seek");
				timeSpan.Duration = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Clip.TimeSpan.Duration");
				clip.TimeSpan = timeSpan;
				output.Clip = clip;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_MuxConfig muxConfig = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_MuxConfig();

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_MuxConfig.ListJob_Webp webp = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_MuxConfig.ListJob_Webp();
				webp.Loop = _ctx.StringValue("ListJob.JobList["+ i +"].Output.MuxConfig.Webp.Loop");
				muxConfig.Webp = webp;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_MuxConfig.ListJob_Gif gif = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_MuxConfig.ListJob_Gif();
				gif.FinalDelay = _ctx.StringValue("ListJob.JobList["+ i +"].Output.MuxConfig.Gif.FinalDelay");
				gif.DitherMode = _ctx.StringValue("ListJob.JobList["+ i +"].Output.MuxConfig.Gif.DitherMode");
				gif.Loop = _ctx.StringValue("ListJob.JobList["+ i +"].Output.MuxConfig.Gif.Loop");
				gif.IsCustomPalette = _ctx.StringValue("ListJob.JobList["+ i +"].Output.MuxConfig.Gif.IsCustomPalette");
				muxConfig.Gif = gif;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_MuxConfig.ListJob_Segment segment = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_MuxConfig.ListJob_Segment();
				segment.Duration = _ctx.StringValue("ListJob.JobList["+ i +"].Output.MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;
				output.MuxConfig = muxConfig;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig subtitleConfig = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig();

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_ExtSubtitle> subtitleConfig_extSubtitleList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_ExtSubtitle>();
				for (int j = 0; j < _ctx.Length("ListJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_ExtSubtitle extSubtitle = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_ExtSubtitle();
					extSubtitle.CharEnc = _ctx.StringValue("ListJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].CharEnc");
					extSubtitle.FontName = _ctx.StringValue("ListJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].FontName");

					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_ExtSubtitle.ListJob_Input1 input1 = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_ExtSubtitle.ListJob_Input1();
					input1._Object = _ctx.StringValue("ListJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Object");
					input1.Location = _ctx.StringValue("ListJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Location");
					input1.Bucket = _ctx.StringValue("ListJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Bucket");
					extSubtitle.Input1 = input1;

					subtitleConfig_extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = subtitleConfig_extSubtitleList;

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_Subtitle> subtitleConfig_subtitleList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_Subtitle>();
				for (int j = 0; j < _ctx.Length("ListJob.JobList["+ i +"].Output.SubtitleConfig.SubtitleList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_Subtitle subtitle = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_SubtitleConfig.ListJob_Subtitle();
					subtitle.Map = _ctx.StringValue("ListJob.JobList["+ i +"].Output.SubtitleConfig.SubtitleList["+ j +"].Map");

					subtitleConfig_subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleConfig_subtitleList;
				output.SubtitleConfig = subtitleConfig;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties properties = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties();
				properties.Width = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Width");
				properties.Height = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Height");
				properties.Duration = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Duration");
				properties.Fps = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Fps");
				properties.Bitrate = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Bitrate");
				properties.FileFormat = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.FileFormat");
				properties.FileSize = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.FileSize");

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams streams = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams();

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_VideoStream> streams_videoStreamList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_VideoStream>();
				for (int j = 0; j < _ctx.Length("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_VideoStream videoStream = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_VideoStream();
					videoStream.Index = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.Timebase = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.AvgFPS = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.PixFmt = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Sar = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Lang = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Lang");
					videoStream.CodecLongName = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Height = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.NumFrames = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Bitrate = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.CodecTagString = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.HasBFrames = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Profile = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.StartTime = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Dar = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.CodecName = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.Width = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Duration = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Fps = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.CodecTag = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.CodecTimeBase = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.Level = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Level");

					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_VideoStream.ListJob_NetworkCost networkCost = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_VideoStream.ListJob_NetworkCost();
					networkCost.PreloadTime = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.AvgBitrate = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					networkCost.CostBandwidth = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_AudioStream> streams_audioStreamList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_AudioStream>();
				for (int j = 0; j < _ctx.Length("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_AudioStream audioStream = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_AudioStream();
					audioStream.Timebase = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.Index = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.SampleFmt = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.ChannelLayout = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Lang = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Lang");
					audioStream.Samplerate = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.CodecLongName = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.Channels = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.NumFrames = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Bitrate = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.CodecTagString = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.StartTime = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.CodecName = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.Duration = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.CodecTag = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.CodecTimeBase = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");

					streams_audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = streams_audioStreamList;

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_SubtitleStream> streams_subtitleStreamList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_SubtitleStream>();
				for (int j = 0; j < _ctx.Length("ListJob.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_SubtitleStream subtitleStream = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Streams.ListJob_SubtitleStream();
					subtitleStream.Index = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					streams_subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = streams_subtitleStreamList;
				properties.Streams = streams;

				ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Format format = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Properties.ListJob_Format();
				format.StartTime = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Format.StartTime");
				format.NumPrograms = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Format.NumPrograms");
				format.Size = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Format.Size");
				format.NumStreams = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Format.NumStreams");
				format.FormatLongName = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Format.FormatLongName");
				format.Duration = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Format.Duration");
				format.Bitrate = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Format.Bitrate");
				format.FormatName = _ctx.StringValue("ListJob.JobList["+ i +"].Output.Properties.Format.FormatName");
				properties.Format = format;
				output.Properties = properties;

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_WaterMark> output_waterMarkList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_WaterMark>();
				for (int j = 0; j < _ctx.Length("ListJob.JobList["+ i +"].Output.WaterMarkList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_WaterMark waterMark = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_WaterMark();
					waterMark.Type = _ctx.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Type");
					waterMark.ReferPos = _ctx.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].ReferPos");
					waterMark.Dx = _ctx.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dx");
					waterMark.Width = _ctx.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Width");
					waterMark.Height = _ctx.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Height");
					waterMark.WaterMarkTemplateId = _ctx.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].WaterMarkTemplateId");
					waterMark.Dy = _ctx.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dy");

					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_WaterMark.ListJob_InputFile inputFile = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_WaterMark.ListJob_InputFile();
					inputFile._Object = _ctx.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Object");
					inputFile.Location = _ctx.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Location");
					inputFile.Bucket = _ctx.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Bucket");
					waterMark.InputFile = inputFile;

					output_waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = output_waterMarkList;

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Merge> output_mergeList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Merge>();
				for (int j = 0; j < _ctx.Length("ListJob.JobList["+ i +"].Output.MergeList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Merge merge = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Merge();
					merge.Start = _ctx.StringValue("ListJob.JobList["+ i +"].Output.MergeList["+ j +"].Start");
					merge.RoleArn = _ctx.StringValue("ListJob.JobList["+ i +"].Output.MergeList["+ j +"].RoleArn");
					merge.MergeURL = _ctx.StringValue("ListJob.JobList["+ i +"].Output.MergeList["+ j +"].MergeURL");
					merge.Duration = _ctx.StringValue("ListJob.JobList["+ i +"].Output.MergeList["+ j +"].Duration");

					output_mergeList.Add(merge);
				}
				output.MergeList = output_mergeList;

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_OutSubtitle> output_outSubtitleList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_OutSubtitle>();
				for (int j = 0; j < _ctx.Length("ListJob.JobList["+ i +"].Output.OutSubtitleList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_OutSubtitle outSubtitle = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_OutSubtitle();
					outSubtitle.Map = _ctx.StringValue("ListJob.JobList["+ i +"].Output.OutSubtitleList["+ j +"].Map");
					outSubtitle.Success = _ctx.BooleanValue("ListJob.JobList["+ i +"].Output.OutSubtitleList["+ j +"].Success");
					outSubtitle.Message = _ctx.StringValue("ListJob.JobList["+ i +"].Output.OutSubtitleList["+ j +"].Message");

					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_OutSubtitle.ListJob_OutSubtitleFile outSubtitleFile = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_OutSubtitle.ListJob_OutSubtitleFile();
					outSubtitleFile.RoleArn = _ctx.StringValue("ListJob.JobList["+ i +"].Output.OutSubtitleList["+ j +"].OutSubtitleFile.RoleArn");
					outSubtitleFile._Object = _ctx.StringValue("ListJob.JobList["+ i +"].Output.OutSubtitleList["+ j +"].OutSubtitleFile.Object");
					outSubtitleFile.Location = _ctx.StringValue("ListJob.JobList["+ i +"].Output.OutSubtitleList["+ j +"].OutSubtitleFile.Location");
					outSubtitleFile.Bucket = _ctx.StringValue("ListJob.JobList["+ i +"].Output.OutSubtitleList["+ j +"].OutSubtitleFile.Bucket");
					outSubtitle.OutSubtitleFile = outSubtitleFile;

					output_outSubtitleList.Add(outSubtitle);
				}
				output.OutSubtitleList = output_outSubtitleList;

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Opening> output_openingList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Opening>();
				for (int j = 0; j < _ctx.Length("ListJob.JobList["+ i +"].Output.OpeningList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Opening opening = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_Opening();
					opening.OpenUrl = _ctx.StringValue("ListJob.JobList["+ i +"].Output.OpeningList["+ j +"].openUrl");
					opening.Start = _ctx.StringValue("ListJob.JobList["+ i +"].Output.OpeningList["+ j +"].Start");
					opening.Width = _ctx.StringValue("ListJob.JobList["+ i +"].Output.OpeningList["+ j +"].Width");
					opening.Height = _ctx.StringValue("ListJob.JobList["+ i +"].Output.OpeningList["+ j +"].Height");

					output_openingList.Add(opening);
				}
				output.OpeningList = output_openingList;

				List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_TailSlate> output_tailSlateList = new List<ListJobResponse.ListJob_Job.ListJob_Output.ListJob_TailSlate>();
				for (int j = 0; j < _ctx.Length("ListJob.JobList["+ i +"].Output.TailSlateList.Length"); j++) {
					ListJobResponse.ListJob_Job.ListJob_Output.ListJob_TailSlate tailSlate = new ListJobResponse.ListJob_Job.ListJob_Output.ListJob_TailSlate();
					tailSlate.Start = _ctx.StringValue("ListJob.JobList["+ i +"].Output.TailSlateList["+ j +"].Start");
					tailSlate.BgColor = _ctx.StringValue("ListJob.JobList["+ i +"].Output.TailSlateList["+ j +"].BgColor");
					tailSlate.IsMergeAudio = _ctx.BooleanValue("ListJob.JobList["+ i +"].Output.TailSlateList["+ j +"].IsMergeAudio");
					tailSlate.Width = _ctx.StringValue("ListJob.JobList["+ i +"].Output.TailSlateList["+ j +"].Width");
					tailSlate.Height = _ctx.StringValue("ListJob.JobList["+ i +"].Output.TailSlateList["+ j +"].Height");
					tailSlate.BlendDuration = _ctx.StringValue("ListJob.JobList["+ i +"].Output.TailSlateList["+ j +"].BlendDuration");
					tailSlate.TailUrl = _ctx.StringValue("ListJob.JobList["+ i +"].Output.TailSlateList["+ j +"].TailUrl");

					output_tailSlateList.Add(tailSlate);
				}
				output.TailSlateList = output_tailSlateList;
				job.Output = output;

				ListJobResponse.ListJob_Job.ListJob_Input input = new ListJobResponse.ListJob_Job.ListJob_Input();
				input._Object = _ctx.StringValue("ListJob.JobList["+ i +"].Input.Object");
				input.Location = _ctx.StringValue("ListJob.JobList["+ i +"].Input.Location");
				input.Bucket = _ctx.StringValue("ListJob.JobList["+ i +"].Input.Bucket");
				job.Input = input;

				ListJobResponse.ListJob_Job.ListJob_MNSMessageResult mNSMessageResult = new ListJobResponse.ListJob_Job.ListJob_MNSMessageResult();
				mNSMessageResult.MessageId = _ctx.StringValue("ListJob.JobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = _ctx.StringValue("ListJob.JobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = _ctx.StringValue("ListJob.JobList["+ i +"].MNSMessageResult.ErrorCode");
				job.MNSMessageResult = mNSMessageResult;

				listJobResponse_jobList.Add(job);
			}
			listJobResponse.JobList = listJobResponse_jobList;
        
			return listJobResponse;
        }
    }
}
