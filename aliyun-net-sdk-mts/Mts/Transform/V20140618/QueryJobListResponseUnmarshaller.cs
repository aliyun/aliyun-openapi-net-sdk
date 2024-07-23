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
    public class QueryJobListResponseUnmarshaller
    {
        public static QueryJobListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryJobListResponse queryJobListResponse = new QueryJobListResponse();

			queryJobListResponse.HttpResponse = _ctx.HttpResponse;
			queryJobListResponse.RequestId = _ctx.StringValue("QueryJobList.RequestId");

			List<string> queryJobListResponse_nonExistJobIds = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryJobList.NonExistJobIds.Length"); i++) {
				queryJobListResponse_nonExistJobIds.Add(_ctx.StringValue("QueryJobList.NonExistJobIds["+ i +"]"));
			}
			queryJobListResponse.NonExistJobIds = queryJobListResponse_nonExistJobIds;

			List<QueryJobListResponse.QueryJobList_Job> queryJobListResponse_jobList = new List<QueryJobListResponse.QueryJobList_Job>();
			for (int i = 0; i < _ctx.Length("QueryJobList.JobList.Length"); i++) {
				QueryJobListResponse.QueryJobList_Job job = new QueryJobListResponse.QueryJobList_Job();
				job.CreationTime = _ctx.StringValue("QueryJobList.JobList["+ i +"].CreationTime");
				job.Percent = _ctx.LongValue("QueryJobList.JobList["+ i +"].Percent");
				job.FinishTime = _ctx.StringValue("QueryJobList.JobList["+ i +"].FinishTime");
				job.State = _ctx.StringValue("QueryJobList.JobList["+ i +"].State");
				job.JobId = _ctx.StringValue("QueryJobList.JobList["+ i +"].JobId");
				job.Code = _ctx.StringValue("QueryJobList.JobList["+ i +"].Code");
				job.Message = _ctx.StringValue("QueryJobList.JobList["+ i +"].Message");
				job.PipelineId = _ctx.StringValue("QueryJobList.JobList["+ i +"].PipelineId");
				job.SubmitTime = _ctx.StringValue("QueryJobList.JobList["+ i +"].SubmitTime");

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output output = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output();
				output.WaterMarkConfigUrl = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkConfigUrl");
				output.DeWatermark = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.DeWatermark");
				output.Priority = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Priority");
				output.AudioStreamMap = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.AudioStreamMap");
				output.UserData = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.UserData");
				output.ExtendData = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.ExtendData");
				output.VideoStreamMap = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.VideoStreamMap");
				output.Rotate = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Rotate");
				output.MergeConfigUrl = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.MergeConfigUrl");
				output.TemplateId = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.TemplateId");

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Video video = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Video();
				video.Bufsize = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Bufsize");
				video.Degrain = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Degrain");
				video.PixFmt = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.PixFmt");
				video.Pad = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Pad");
				video.Codec = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Codec");
				video.Height = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Height");
				video.Qscale = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Qscale");
				video.Crop = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Crop");
				video.Bitrate = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Bitrate");
				video.Maxrate = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Maxrate");
				video.MaxFps = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.MaxFps");
				video.Profile = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Profile");
				video.Crf = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Crf");
				video.Gop = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Gop");
				video.Width = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Width");
				video.Fps = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Fps");
				video.Preset = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Preset");
				video.ScanMode = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.ScanMode");
				video.ResoPriority = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.ResoPriority");

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Video.QueryJobList_BitrateBnd bitrateBnd = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Video.QueryJobList_BitrateBnd();
				bitrateBnd.Max = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.BitrateBnd.Max");
				bitrateBnd.Min = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				output.Video = video;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_TransConfig transConfig = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_TransConfig();
				transConfig.IsCheckAudioBitrate = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.IsCheckAudioBitrate");
				transConfig.TransMode = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.TransMode");
				transConfig.IsCheckReso = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.IsCheckReso");
				transConfig.IsCheckVideoBitrateFail = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.IsCheckVideoBitrateFail");
				transConfig.AdjDarMethod = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.AdjDarMethod");
				transConfig.IsCheckVideoBitrate = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckResoFail = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.IsCheckResoFail");
				transConfig.IsCheckAudioBitrateFail = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.IsCheckAudioBitrateFail");
				output.TransConfig = transConfig;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Encryption encryption = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Encryption();
				encryption.Type = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Encryption.Type");
				encryption.Key = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Encryption.Key");
				encryption.KeyType = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Encryption.KeyType");
				encryption.Id = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Encryption.Id");
				encryption.KeyUri = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Encryption.KeyUri");
				encryption.SkipCnt = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Encryption.SkipCnt");
				output.Encryption = encryption;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_M3U8NonStandardSupport m3U8NonStandardSupport = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_M3U8NonStandardSupport();

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_M3U8NonStandardSupport.QueryJobList_TS tS = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_M3U8NonStandardSupport.QueryJobList_TS();
				tS.SizeSupport = _ctx.BooleanValue("QueryJobList.JobList["+ i +"].Output.M3U8NonStandardSupport.TS.SizeSupport");
				tS.Md5Support = _ctx.BooleanValue("QueryJobList.JobList["+ i +"].Output.M3U8NonStandardSupport.TS.Md5Support");
				m3U8NonStandardSupport.TS = tS;
				output.M3U8NonStandardSupport = m3U8NonStandardSupport;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Audio audio = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Audio();
				audio.Profile = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Profile");
				audio.Codec = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Codec");
				audio.Samplerate = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Samplerate");
				audio.Qscale = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Qscale");
				audio.Channels = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Channels");
				audio.Bitrate = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Bitrate");

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Audio.QueryJobList_Volume volume = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Audio.QueryJobList_Volume();
				volume.Method = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Volume.Method");
				volume.Level = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Volume.Level");
				audio.Volume = volume;
				output.Audio = audio;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SuperReso superReso = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SuperReso();
				superReso.IsHalfSample = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.SuperReso.IsHalfSample");
				output.SuperReso = superReso;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_OutputFile outputFile = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_OutputFile();
				outputFile.RoleArn = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.OutputFile.RoleArn");
				outputFile._Object = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.OutputFile.Object");
				outputFile.Location = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.OutputFile.Location");
				outputFile.Bucket = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.OutputFile.Bucket");
				output.OutputFile = outputFile;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Container container = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Container();
				container.Format = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Container.Format");
				output.Container = container;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Clip clip = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Clip();

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Clip.QueryJobList_TimeSpan timeSpan = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Clip.QueryJobList_TimeSpan();
				timeSpan.Seek = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Clip.TimeSpan.Seek");
				timeSpan.Duration = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Clip.TimeSpan.Duration");
				clip.TimeSpan = timeSpan;
				output.Clip = clip;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_MuxConfig muxConfig = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_MuxConfig();

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_MuxConfig.QueryJobList_Webp webp = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_MuxConfig.QueryJobList_Webp();
				webp.Loop = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.MuxConfig.Webp.Loop");
				muxConfig.Webp = webp;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_MuxConfig.QueryJobList_Gif gif = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_MuxConfig.QueryJobList_Gif();
				gif.FinalDelay = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.MuxConfig.Gif.FinalDelay");
				gif.DitherMode = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.MuxConfig.Gif.DitherMode");
				gif.Loop = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.MuxConfig.Gif.Loop");
				gif.IsCustomPalette = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.MuxConfig.Gif.IsCustomPalette");
				muxConfig.Gif = gif;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_MuxConfig.QueryJobList_Segment segment = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_MuxConfig.QueryJobList_Segment();
				segment.Duration = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;
				output.MuxConfig = muxConfig;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig subtitleConfig = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig();

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_ExtSubtitle> subtitleConfig_extSubtitleList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_ExtSubtitle>();
				for (int j = 0; j < _ctx.Length("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_ExtSubtitle extSubtitle = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_ExtSubtitle();
					extSubtitle.CharEnc = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].CharEnc");
					extSubtitle.FontName = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].FontName");

					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_ExtSubtitle.QueryJobList_Input1 input1 = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_ExtSubtitle.QueryJobList_Input1();
					input1._Object = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Object");
					input1.Location = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Location");
					input1.Bucket = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Bucket");
					extSubtitle.Input1 = input1;

					subtitleConfig_extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = subtitleConfig_extSubtitleList;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_Subtitle> subtitleConfig_subtitleList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_Subtitle>();
				for (int j = 0; j < _ctx.Length("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.SubtitleList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_Subtitle subtitle = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_SubtitleConfig.QueryJobList_Subtitle();
					subtitle.Map = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.SubtitleList["+ j +"].Map");

					subtitleConfig_subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleConfig_subtitleList;
				output.SubtitleConfig = subtitleConfig;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties properties = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties();
				properties.Width = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Width");
				properties.Height = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Height");
				properties.Duration = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Duration");
				properties.Fps = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Fps");
				properties.Bitrate = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Bitrate");
				properties.FileFormat = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.FileFormat");
				properties.FileSize = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.FileSize");

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams streams = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams();

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_VideoStream> streams_videoStreamList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_VideoStream>();
				for (int j = 0; j < _ctx.Length("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_VideoStream videoStream = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_VideoStream();
					videoStream.Index = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.Timebase = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.AvgFPS = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.PixFmt = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Sar = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Lang = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Lang");
					videoStream.CodecLongName = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Height = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.NumFrames = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Bitrate = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.CodecTagString = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.HasBFrames = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Profile = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.StartTime = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Dar = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.CodecName = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.Width = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Duration = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Fps = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.CodecTag = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.CodecTimeBase = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.Level = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Level");
					videoStream.ColorTransfer = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].colorTransfer");
					videoStream.ColorPrimaries = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].colorPrimaries");
					videoStream.BitsPerRawSample = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].bitsPerRawSample");

					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_VideoStream.QueryJobList_NetworkCost networkCost = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_VideoStream.QueryJobList_NetworkCost();
					networkCost.PreloadTime = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.AvgBitrate = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					networkCost.CostBandwidth = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_AudioStream> streams_audioStreamList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_AudioStream>();
				for (int j = 0; j < _ctx.Length("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_AudioStream audioStream = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_AudioStream();
					audioStream.Timebase = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.Index = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.SampleFmt = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.ChannelLayout = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Lang = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Lang");
					audioStream.Samplerate = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.CodecLongName = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.Channels = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.NumFrames = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Bitrate = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.CodecTagString = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.StartTime = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.CodecName = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.Duration = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.CodecTag = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.CodecTimeBase = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");

					streams_audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = streams_audioStreamList;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_SubtitleStream> streams_subtitleStreamList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_SubtitleStream>();
				for (int j = 0; j < _ctx.Length("QueryJobList.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_SubtitleStream subtitleStream = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Streams.QueryJobList_SubtitleStream();
					subtitleStream.Index = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					streams_subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = streams_subtitleStreamList;
				properties.Streams = streams;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Format format = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_Format();
				format.StartTime = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.StartTime");
				format.NumPrograms = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.NumPrograms");
				format.Size = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.Size");
				format.NumStreams = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.NumStreams");
				format.FormatLongName = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.FormatLongName");
				format.Duration = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.Duration");
				format.Bitrate = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.Bitrate");
				format.FormatName = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.FormatName");
				properties.Format = format;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_SourceLogo> properties_sourceLogos = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_SourceLogo>();
				for (int j = 0; j < _ctx.Length("QueryJobList.JobList["+ i +"].Output.Properties.SourceLogos.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_SourceLogo sourceLogo = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Properties.QueryJobList_SourceLogo();
					sourceLogo.Source = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.SourceLogos["+ j +"].Source");

					properties_sourceLogos.Add(sourceLogo);
				}
				properties.SourceLogos = properties_sourceLogos;
				output.Properties = properties;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_MultiSpeedInfo multiSpeedInfo = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_MultiSpeedInfo();
				multiSpeedInfo.Enable = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.MultiSpeedInfo.Enable");
				multiSpeedInfo.Code = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.MultiSpeedInfo.Code");
				multiSpeedInfo.Message = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.MultiSpeedInfo.Message");
				multiSpeedInfo.SettingSpeed = _ctx.IntegerValue("QueryJobList.JobList["+ i +"].Output.MultiSpeedInfo.SettingSpeed");
				multiSpeedInfo.DowngradePolicy = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.MultiSpeedInfo.DowngradePolicy");
				multiSpeedInfo.RealSpeed = _ctx.DoubleValue("QueryJobList.JobList["+ i +"].Output.MultiSpeedInfo.RealSpeed");
				multiSpeedInfo.Duration = _ctx.DoubleValue("QueryJobList.JobList["+ i +"].Output.MultiSpeedInfo.Duration");
				multiSpeedInfo.TimeCost = _ctx.DoubleValue("QueryJobList.JobList["+ i +"].Output.MultiSpeedInfo.TimeCost");
				output.MultiSpeedInfo = multiSpeedInfo;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_TraceMark traceMark = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_TraceMark();
				traceMark.Enable = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.TraceMark.Enable");
				output.TraceMark = traceMark;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_CopyrightMark copyrightMark = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_CopyrightMark();
				copyrightMark.Content = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.CopyrightMark.Content");
				output.CopyrightMark = copyrightMark;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_WaterMark> output_waterMarkList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_WaterMark>();
				for (int j = 0; j < _ctx.Length("QueryJobList.JobList["+ i +"].Output.WaterMarkList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_WaterMark waterMark = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_WaterMark();
					waterMark.Type = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].Type");
					waterMark.ReferPos = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].ReferPos");
					waterMark.Dx = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dx");
					waterMark.Width = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].Width");
					waterMark.Height = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].Height");
					waterMark.WaterMarkTemplateId = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].WaterMarkTemplateId");
					waterMark.Dy = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dy");

					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_WaterMark.QueryJobList_InputFile inputFile = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_WaterMark.QueryJobList_InputFile();
					inputFile._Object = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Object");
					inputFile.Location = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Location");
					inputFile.Bucket = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Bucket");
					waterMark.InputFile = inputFile;

					output_waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = output_waterMarkList;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Merge> output_mergeList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Merge>();
				for (int j = 0; j < _ctx.Length("QueryJobList.JobList["+ i +"].Output.MergeList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Merge merge = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Merge();
					merge.Start = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.MergeList["+ j +"].Start");
					merge.RoleArn = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.MergeList["+ j +"].RoleArn");
					merge.MergeURL = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.MergeList["+ j +"].MergeURL");
					merge.Duration = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.MergeList["+ j +"].Duration");

					output_mergeList.Add(merge);
				}
				output.MergeList = output_mergeList;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_OutSubtitle> output_outSubtitleList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_OutSubtitle>();
				for (int j = 0; j < _ctx.Length("QueryJobList.JobList["+ i +"].Output.OutSubtitleList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_OutSubtitle outSubtitle = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_OutSubtitle();
					outSubtitle.Map = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.OutSubtitleList["+ j +"].Map");
					outSubtitle.Success = _ctx.BooleanValue("QueryJobList.JobList["+ i +"].Output.OutSubtitleList["+ j +"].Success");
					outSubtitle.Message = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.OutSubtitleList["+ j +"].Message");

					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_OutSubtitle.QueryJobList_OutSubtitleFile outSubtitleFile = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_OutSubtitle.QueryJobList_OutSubtitleFile();
					outSubtitleFile.RoleArn = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.OutSubtitleList["+ j +"].OutSubtitleFile.RoleArn");
					outSubtitleFile._Object = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.OutSubtitleList["+ j +"].OutSubtitleFile.Object");
					outSubtitleFile.Location = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.OutSubtitleList["+ j +"].OutSubtitleFile.Location");
					outSubtitleFile.Bucket = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.OutSubtitleList["+ j +"].OutSubtitleFile.Bucket");
					outSubtitle.OutSubtitleFile = outSubtitleFile;

					output_outSubtitleList.Add(outSubtitle);
				}
				output.OutSubtitleList = output_outSubtitleList;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Opening> output_openingList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Opening>();
				for (int j = 0; j < _ctx.Length("QueryJobList.JobList["+ i +"].Output.OpeningList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Opening opening = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_Opening();
					opening.OpenUrl = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.OpeningList["+ j +"].openUrl");
					opening.Start = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.OpeningList["+ j +"].Start");
					opening.Width = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.OpeningList["+ j +"].Width");
					opening.Height = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.OpeningList["+ j +"].Height");

					output_openingList.Add(opening);
				}
				output.OpeningList = output_openingList;

				List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_TailSlate> output_tailSlateList = new List<QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_TailSlate>();
				for (int j = 0; j < _ctx.Length("QueryJobList.JobList["+ i +"].Output.TailSlateList.Length"); j++) {
					QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_TailSlate tailSlate = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Output.QueryJobList_TailSlate();
					tailSlate.Start = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.TailSlateList["+ j +"].Start");
					tailSlate.BgColor = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.TailSlateList["+ j +"].BgColor");
					tailSlate.IsMergeAudio = _ctx.BooleanValue("QueryJobList.JobList["+ i +"].Output.TailSlateList["+ j +"].IsMergeAudio");
					tailSlate.Width = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.TailSlateList["+ j +"].Width");
					tailSlate.Height = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.TailSlateList["+ j +"].Height");
					tailSlate.BlendDuration = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.TailSlateList["+ j +"].BlendDuration");
					tailSlate.TailUrl = _ctx.StringValue("QueryJobList.JobList["+ i +"].Output.TailSlateList["+ j +"].TailUrl");

					output_tailSlateList.Add(tailSlate);
				}
				output.TailSlateList = output_tailSlateList;
				job.Output = output;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Input input = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Input();
				input._Object = _ctx.StringValue("QueryJobList.JobList["+ i +"].Input.Object");
				input.Location = _ctx.StringValue("QueryJobList.JobList["+ i +"].Input.Location");
				input.Bucket = _ctx.StringValue("QueryJobList.JobList["+ i +"].Input.Bucket");
				job.Input = input;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_MNSMessageResult mNSMessageResult = new QueryJobListResponse.QueryJobList_Job.QueryJobList_MNSMessageResult();
				mNSMessageResult.MessageId = _ctx.StringValue("QueryJobList.JobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = _ctx.StringValue("QueryJobList.JobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = _ctx.StringValue("QueryJobList.JobList["+ i +"].MNSMessageResult.ErrorCode");
				job.MNSMessageResult = mNSMessageResult;

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Pipeline pipeline = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Pipeline();
				pipeline.Id = _ctx.StringValue("QueryJobList.JobList["+ i +"].Pipeline.Id");
				pipeline.Name = _ctx.StringValue("QueryJobList.JobList["+ i +"].Pipeline.Name");
				pipeline.Speed = _ctx.StringValue("QueryJobList.JobList["+ i +"].Pipeline.Speed");
				pipeline.State = _ctx.StringValue("QueryJobList.JobList["+ i +"].Pipeline.State");

				QueryJobListResponse.QueryJobList_Job.QueryJobList_Pipeline.QueryJobList_ExtendConfig extendConfig = new QueryJobListResponse.QueryJobList_Job.QueryJobList_Pipeline.QueryJobList_ExtendConfig();
				extendConfig.IsBoostNew = _ctx.BooleanValue("QueryJobList.JobList["+ i +"].Pipeline.ExtendConfig.IsBoostNew");
				extendConfig.MaxMultiSpeed = _ctx.IntegerValue("QueryJobList.JobList["+ i +"].Pipeline.ExtendConfig.MaxMultiSpeed");
				extendConfig.MultiSpeedDowngradePolicy = _ctx.StringValue("QueryJobList.JobList["+ i +"].Pipeline.ExtendConfig.MultiSpeedDowngradePolicy");
				pipeline.ExtendConfig = extendConfig;
				job.Pipeline = pipeline;

				queryJobListResponse_jobList.Add(job);
			}
			queryJobListResponse.JobList = queryJobListResponse_jobList;
        
			return queryJobListResponse;
        }
    }
}
