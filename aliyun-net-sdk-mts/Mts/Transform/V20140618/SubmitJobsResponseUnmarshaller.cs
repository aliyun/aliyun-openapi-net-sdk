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
    public class SubmitJobsResponseUnmarshaller
    {
        public static SubmitJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitJobsResponse submitJobsResponse = new SubmitJobsResponse();

			submitJobsResponse.HttpResponse = _ctx.HttpResponse;
			submitJobsResponse.RequestId = _ctx.StringValue("SubmitJobs.RequestId");

			List<SubmitJobsResponse.SubmitJobs_JobResult> submitJobsResponse_jobResultList = new List<SubmitJobsResponse.SubmitJobs_JobResult>();
			for (int i = 0; i < _ctx.Length("SubmitJobs.JobResultList.Length"); i++) {
				SubmitJobsResponse.SubmitJobs_JobResult jobResult = new SubmitJobsResponse.SubmitJobs_JobResult();
				jobResult.Success = _ctx.BooleanValue("SubmitJobs.JobResultList["+ i +"].Success");
				jobResult.Code = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Code");
				jobResult.Message = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Message");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job job = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job();
				job.CreationTime = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.CreationTime");
				job.Percent = _ctx.LongValue("SubmitJobs.JobResultList["+ i +"].Job.Percent");
				job.FinishTime = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.FinishTime");
				job.State = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.State");
				job.JobId = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.JobId");
				job.Code = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Code");
				job.Message = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Message");
				job.PipelineId = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.PipelineId");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output output = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output();
				output.WaterMarkConfigUrl = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkConfigUrl");
				output.DeWatermark = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DeWatermark");
				output.Priority = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Priority");
				output.AudioStreamMap = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.AudioStreamMap");
				output.UserData = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.UserData");
				output.VideoStreamMap = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.VideoStreamMap");
				output.Rotate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Rotate");
				output.MergeConfigUrl = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeConfigUrl");
				output.TemplateId = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TemplateId");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Video video = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Video();
				video.Bufsize = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Bufsize");
				video.Degrain = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Degrain");
				video.PixFmt = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.PixFmt");
				video.Pad = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Pad");
				video.Codec = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Codec");
				video.Height = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Height");
				video.Qscale = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Qscale");
				video.Crop = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Crop");
				video.Bitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Bitrate");
				video.Maxrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Maxrate");
				video.MaxFps = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.MaxFps");
				video.Profile = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Profile");
				video.Crf = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Crf");
				video.Gop = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Gop");
				video.Width = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Width");
				video.Fps = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Fps");
				video.Preset = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Preset");
				video.ScanMode = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.ScanMode");
				video.ResoPriority = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.ResoPriority");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Video.SubmitJobs_BitrateBnd bitrateBnd = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Video.SubmitJobs_BitrateBnd();
				bitrateBnd.Max = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.BitrateBnd.Max");
				bitrateBnd.Min = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				output.Video = video;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TransConfig transConfig = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TransConfig();
				transConfig.IsCheckAudioBitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckAudioBitrate");
				transConfig.TransMode = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.TransMode");
				transConfig.IsCheckReso = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckReso");
				transConfig.IsCheckVideoBitrateFail = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckVideoBitrateFail");
				transConfig.AdjDarMethod = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.AdjDarMethod");
				transConfig.IsCheckVideoBitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckResoFail = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckResoFail");
				transConfig.IsCheckAudioBitrateFail = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckAudioBitrateFail");
				output.TransConfig = transConfig;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Encryption encryption = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Encryption();
				encryption.Type = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.Type");
				encryption.Key = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.Key");
				encryption.KeyType = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.KeyType");
				encryption.Id = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.Id");
				encryption.KeyUri = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.KeyUri");
				encryption.SkipCnt = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.SkipCnt");
				output.Encryption = encryption;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_M3U8NonStandardSupport m3U8NonStandardSupport = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_M3U8NonStandardSupport();

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_M3U8NonStandardSupport.SubmitJobs_TS tS = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_M3U8NonStandardSupport.SubmitJobs_TS();
				tS.SizeSupport = _ctx.BooleanValue("SubmitJobs.JobResultList["+ i +"].Job.Output.M3U8NonStandardSupport.TS.SizeSupport");
				tS.Md5Support = _ctx.BooleanValue("SubmitJobs.JobResultList["+ i +"].Job.Output.M3U8NonStandardSupport.TS.Md5Support");
				m3U8NonStandardSupport.TS = tS;
				output.M3U8NonStandardSupport = m3U8NonStandardSupport;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Audio audio = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Audio();
				audio.Profile = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Profile");
				audio.Codec = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Codec");
				audio.Samplerate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Samplerate");
				audio.Qscale = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Qscale");
				audio.Channels = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Channels");
				audio.Bitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Bitrate");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Audio.SubmitJobs_Volume volume = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Audio.SubmitJobs_Volume();
				volume.Method = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Volume.Method");
				volume.Level = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Volume.Level");
				audio.Volume = volume;
				output.Audio = audio;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SuperReso superReso = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SuperReso();
				superReso.IsHalfSample = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SuperReso.IsHalfSample");
				output.SuperReso = superReso;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_DigiWaterMark digiWaterMark = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_DigiWaterMark();
				digiWaterMark.Type = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DigiWaterMark.Type");
				digiWaterMark.Alpha = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DigiWaterMark.Alpha");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_DigiWaterMark.SubmitJobs_InputFile1 inputFile1 = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_DigiWaterMark.SubmitJobs_InputFile1();
				inputFile1._Object = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DigiWaterMark.InputFile.Object");
				inputFile1.Location = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DigiWaterMark.InputFile.Location");
				inputFile1.Bucket = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DigiWaterMark.InputFile.Bucket");
				digiWaterMark.InputFile1 = inputFile1;
				output.DigiWaterMark = digiWaterMark;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutputFile outputFile = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutputFile();
				outputFile.RoleArn = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutputFile.RoleArn");
				outputFile._Object = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutputFile.Object");
				outputFile.Location = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutputFile.Location");
				outputFile.Bucket = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutputFile.Bucket");
				output.OutputFile = outputFile;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Container container = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Container();
				container.Format = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Container.Format");
				output.Container = container;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Clip clip = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Clip();

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Clip.SubmitJobs_TimeSpan timeSpan = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Clip.SubmitJobs_TimeSpan();
				timeSpan.Seek = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Clip.TimeSpan.Seek");
				timeSpan.Duration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Clip.TimeSpan.Duration");
				clip.TimeSpan = timeSpan;
				output.Clip = clip;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig muxConfig = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig();

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig.SubmitJobs_Webp webp = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig.SubmitJobs_Webp();
				webp.Loop = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Webp.Loop");
				muxConfig.Webp = webp;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig.SubmitJobs_Gif gif = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig.SubmitJobs_Gif();
				gif.FinalDelay = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Gif.FinalDelay");
				gif.DitherMode = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Gif.DitherMode");
				gif.Loop = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Gif.Loop");
				gif.IsCustomPalette = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Gif.IsCustomPalette");
				muxConfig.Gif = gif;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig.SubmitJobs_Segment segment = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig.SubmitJobs_Segment();
				segment.Duration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;
				output.MuxConfig = muxConfig;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig subtitleConfig = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig();

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle> subtitleConfig_extSubtitleList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle extSubtitle = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle();
					extSubtitle.CharEnc = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].CharEnc");
					extSubtitle.FontName = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].FontName");

					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle.SubmitJobs_Input2 input2 = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle.SubmitJobs_Input2();
					input2._Object = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Object");
					input2.Location = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Location");
					input2.Bucket = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Bucket");
					extSubtitle.Input2 = input2;

					subtitleConfig_extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = subtitleConfig_extSubtitleList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_Subtitle> subtitleConfig_subtitleList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_Subtitle>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.SubtitleList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_Subtitle subtitle = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_Subtitle();
					subtitle.Map = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.SubtitleList["+ j +"].Map");

					subtitleConfig_subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleConfig_subtitleList;
				output.SubtitleConfig = subtitleConfig;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties properties = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties();
				properties.Width = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Width");
				properties.Height = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Height");
				properties.Duration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Duration");
				properties.Fps = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Fps");
				properties.Bitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Bitrate");
				properties.FileFormat = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.FileFormat");
				properties.FileSize = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.FileSize");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams streams = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams();

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream> streams_videoStreamList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream videoStream = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream();
					videoStream.Index = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.Timebase = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.AvgFPS = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.PixFmt = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Sar = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Lang = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Lang");
					videoStream.CodecLongName = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Height = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.NumFrames = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Bitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.CodecTagString = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.HasBFrames = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Profile = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.StartTime = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Dar = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.CodecName = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.Width = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Duration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Fps = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.CodecTag = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.CodecTimeBase = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.Level = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Level");

					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream.SubmitJobs_NetworkCost networkCost = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream.SubmitJobs_NetworkCost();
					networkCost.PreloadTime = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.AvgBitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					networkCost.CostBandwidth = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_AudioStream> streams_audioStreamList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_AudioStream>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_AudioStream audioStream = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_AudioStream();
					audioStream.Timebase = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.Index = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.SampleFmt = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.ChannelLayout = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Lang = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Lang");
					audioStream.Samplerate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.CodecLongName = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.Channels = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.NumFrames = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Bitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.CodecTagString = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.StartTime = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.CodecName = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.Duration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.CodecTag = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.CodecTimeBase = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");

					streams_audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = streams_audioStreamList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_SubtitleStream> streams_subtitleStreamList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_SubtitleStream>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_SubtitleStream subtitleStream = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_SubtitleStream();
					subtitleStream.Index = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					streams_subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = streams_subtitleStreamList;
				properties.Streams = streams;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Format format = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Format();
				format.StartTime = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.StartTime");
				format.NumPrograms = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.NumPrograms");
				format.Size = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.Size");
				format.NumStreams = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.NumStreams");
				format.FormatLongName = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.FormatLongName");
				format.Duration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.Duration");
				format.Bitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.Bitrate");
				format.FormatName = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.FormatName");
				properties.Format = format;
				output.Properties = properties;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark> output_waterMarkList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark waterMark = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark();
					waterMark.Type = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Type");
					waterMark.ReferPos = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].ReferPos");
					waterMark.Dx = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Dx");
					waterMark.Width = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Width");
					waterMark.Height = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Height");
					waterMark.WaterMarkTemplateId = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].WaterMarkTemplateId");
					waterMark.Dy = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Dy");

					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark.SubmitJobs_InputFile inputFile = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark.SubmitJobs_InputFile();
					inputFile._Object = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].InputFile.Object");
					inputFile.Location = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].InputFile.Location");
					inputFile.Bucket = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].InputFile.Bucket");
					waterMark.InputFile = inputFile;

					output_waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = output_waterMarkList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Merge> output_mergeList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Merge>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Merge merge = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Merge();
					merge.Start = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList["+ j +"].Start");
					merge.RoleArn = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList["+ j +"].RoleArn");
					merge.MergeURL = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList["+ j +"].MergeURL");
					merge.Duration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList["+ j +"].Duration");

					output_mergeList.Add(merge);
				}
				output.MergeList = output_mergeList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutSubtitle> output_outSubtitleList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutSubtitle>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.OutSubtitleList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutSubtitle outSubtitle = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutSubtitle();
					outSubtitle.Map = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutSubtitleList["+ j +"].Map");
					outSubtitle.Success = _ctx.BooleanValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutSubtitleList["+ j +"].Success");
					outSubtitle.Message = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutSubtitleList["+ j +"].Message");

					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutSubtitle.SubmitJobs_OutSubtitleFile outSubtitleFile = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutSubtitle.SubmitJobs_OutSubtitleFile();
					outSubtitleFile.RoleArn = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutSubtitleList["+ j +"].OutSubtitleFile.RoleArn");
					outSubtitleFile._Object = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutSubtitleList["+ j +"].OutSubtitleFile.Object");
					outSubtitleFile.Location = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutSubtitleList["+ j +"].OutSubtitleFile.Location");
					outSubtitleFile.Bucket = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutSubtitleList["+ j +"].OutSubtitleFile.Bucket");
					outSubtitle.OutSubtitleFile = outSubtitleFile;

					output_outSubtitleList.Add(outSubtitle);
				}
				output.OutSubtitleList = output_outSubtitleList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Amix> output_amixList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Amix>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.AmixList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Amix amix = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Amix();
					amix.Map = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.AmixList["+ j +"].Map");
					amix.Start = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.AmixList["+ j +"].Start");
					amix.AmixURL = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.AmixList["+ j +"].AmixURL");
					amix.Duration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.AmixList["+ j +"].Duration");
					amix.MixDurMode = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.AmixList["+ j +"].MixDurMode");

					output_amixList.Add(amix);
				}
				output.AmixList = output_amixList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Opening> output_openingList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Opening>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.OpeningList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Opening opening = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Opening();
					opening.OpenUrl = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OpeningList["+ j +"].openUrl");
					opening.Start = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OpeningList["+ j +"].Start");
					opening.Width = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OpeningList["+ j +"].Width");
					opening.Height = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OpeningList["+ j +"].Height");

					output_openingList.Add(opening);
				}
				output.OpeningList = output_openingList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TailSlate> output_tailSlateList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TailSlate>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TailSlate tailSlate = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TailSlate();
					tailSlate.Start = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].Start");
					tailSlate.BgColor = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].BgColor");
					tailSlate.IsMergeAudio = _ctx.BooleanValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].IsMergeAudio");
					tailSlate.Width = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].Width");
					tailSlate.Height = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].Height");
					tailSlate.BlendDuration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].BlendDuration");
					tailSlate.TailUrl = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].TailUrl");

					output_tailSlateList.Add(tailSlate);
				}
				output.TailSlateList = output_tailSlateList;
				job.Output = output;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Input input = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Input();
				input._Object = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Input.Object");
				input.Location = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Input.Location");
				input.Bucket = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Input.Bucket");
				job.Input = input;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_MNSMessageResult mNSMessageResult = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_MNSMessageResult();
				mNSMessageResult.MessageId = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.MNSMessageResult.ErrorCode");
				job.MNSMessageResult = mNSMessageResult;
				jobResult.Job = job;

				submitJobsResponse_jobResultList.Add(jobResult);
			}
			submitJobsResponse.JobResultList = submitJobsResponse_jobResultList;
        
			return submitJobsResponse;
        }
    }
}
