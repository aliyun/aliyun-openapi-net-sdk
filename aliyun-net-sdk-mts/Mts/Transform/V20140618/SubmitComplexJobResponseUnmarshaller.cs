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
    public class SubmitComplexJobResponseUnmarshaller
    {
        public static SubmitComplexJobResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitComplexJobResponse submitComplexJobResponse = new SubmitComplexJobResponse();

			submitComplexJobResponse.HttpResponse = context.HttpResponse;
			submitComplexJobResponse.RequestId = context.StringValue("SubmitComplexJob.RequestId");

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob complexJob = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob();
			complexJob.JobId = context.StringValue("SubmitComplexJob.ComplexJob.JobId");
			complexJob.State = context.StringValue("SubmitComplexJob.ComplexJob.State");
			complexJob.Code = context.StringValue("SubmitComplexJob.ComplexJob.Code");
			complexJob.Message = context.StringValue("SubmitComplexJob.ComplexJob.Message");
			complexJob.Percent = context.LongValue("SubmitComplexJob.ComplexJob.Percent");
			complexJob.PipelineId = context.StringValue("SubmitComplexJob.ComplexJob.PipelineId");
			complexJob.CreationTime = context.StringValue("SubmitComplexJob.ComplexJob.CreationTime");
			complexJob.FinishTime = context.StringValue("SubmitComplexJob.ComplexJob.FinishTime");

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput transcodeOutput = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput();
			transcodeOutput.TemplateId = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.TemplateId");
			transcodeOutput.UserData = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.UserData");
			transcodeOutput.Rotate = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Rotate");
			transcodeOutput.VideoStreamMap = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.VideoStreamMap");
			transcodeOutput.AudioStreamMap = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.AudioStreamMap");
			transcodeOutput.DeWatermark = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.DeWatermark");
			transcodeOutput.Priority = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Priority");
			transcodeOutput.WaterMarkConfigUrl = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.WaterMarkConfigUrl");
			transcodeOutput.MergeConfigUrl = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.MergeConfigUrl");

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_DigiWaterMark digiWaterMark = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_DigiWaterMark();
			digiWaterMark.Type = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.DigiWaterMark.Type");
			digiWaterMark.Alpha = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.DigiWaterMark.Alpha");

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_DigiWaterMark.SubmitComplexJob_InputFile3 inputFile3 = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_DigiWaterMark.SubmitComplexJob_InputFile3();
			inputFile3.Bucket = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.DigiWaterMark.InputFile.Bucket");
			inputFile3.Location = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.DigiWaterMark.InputFile.Location");
			inputFile3._Object = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.DigiWaterMark.InputFile.Object");
			digiWaterMark.InputFile3 = inputFile3;
			transcodeOutput.DigiWaterMark = digiWaterMark;

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_OutputFile outputFile = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_OutputFile();
			outputFile.Bucket = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.OutputFile.Bucket");
			outputFile.Location = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.OutputFile.Location");
			outputFile._Object = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.OutputFile.Object");
			outputFile.RoleArn = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.OutputFile.RoleArn");
			transcodeOutput.OutputFile = outputFile;

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_M3U8NonStandardSupport m3U8NonStandardSupport = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_M3U8NonStandardSupport();

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_M3U8NonStandardSupport.SubmitComplexJob_TS tS = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_M3U8NonStandardSupport.SubmitComplexJob_TS();
			tS.Md5Support = context.BooleanValue("SubmitComplexJob.ComplexJob.TranscodeOutput.M3U8NonStandardSupport.TS.Md5Support");
			tS.SizeSupport = context.BooleanValue("SubmitComplexJob.ComplexJob.TranscodeOutput.M3U8NonStandardSupport.TS.SizeSupport");
			m3U8NonStandardSupport.TS = tS;
			transcodeOutput.M3U8NonStandardSupport = m3U8NonStandardSupport;

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties properties = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties();
			properties.Width = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Width");
			properties.Height = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Height");
			properties.Bitrate = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Bitrate");
			properties.Duration = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Duration");
			properties.Fps = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Fps");
			properties.FileSize = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.FileSize");
			properties.FileFormat = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.FileFormat");

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Streams streams = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Streams();

			List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Streams.SubmitComplexJob_VideoStream> streams_videoStreamList = new List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Streams.SubmitComplexJob_VideoStream>();
			for (int i = 0; i < context.Length("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList.Length"); i++) {
				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Streams.SubmitComplexJob_VideoStream videoStream = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Streams.SubmitComplexJob_VideoStream();
				videoStream.Index = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].Index");
				videoStream.CodecName = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].CodecName");
				videoStream.CodecLongName = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].CodecLongName");
				videoStream.Profile = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].Profile");
				videoStream.CodecTimeBase = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].CodecTimeBase");
				videoStream.CodecTagString = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].CodecTagString");
				videoStream.CodecTag = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].CodecTag");
				videoStream.Width = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].Width");
				videoStream.Height = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].Height");
				videoStream.HasBFrames = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].HasBFrames");
				videoStream.Sar = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].Sar");
				videoStream.Dar = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].Dar");
				videoStream.PixFmt = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].PixFmt");
				videoStream.Level = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].Level");
				videoStream.Fps = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].Fps");
				videoStream.AvgFPS = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].AvgFPS");
				videoStream.Timebase = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].Timebase");
				videoStream.StartTime = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].StartTime");
				videoStream.Duration = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].Duration");
				videoStream.Bitrate = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].Bitrate");
				videoStream.NumFrames = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].NumFrames");
				videoStream.Lang = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].Lang");

				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Streams.SubmitComplexJob_VideoStream.SubmitComplexJob_NetworkCost networkCost = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Streams.SubmitComplexJob_VideoStream.SubmitComplexJob_NetworkCost();
				networkCost.PreloadTime = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.PreloadTime");
				networkCost.CostBandwidth = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.CostBandwidth");
				networkCost.AvgBitrate = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.AvgBitrate");
				videoStream.NetworkCost = networkCost;

				streams_videoStreamList.Add(videoStream);
			}
			streams.VideoStreamList = streams_videoStreamList;

			List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Streams.SubmitComplexJob_AudioStream> streams_audioStreamList = new List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Streams.SubmitComplexJob_AudioStream>();
			for (int i = 0; i < context.Length("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList.Length"); i++) {
				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Streams.SubmitComplexJob_AudioStream audioStream = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Streams.SubmitComplexJob_AudioStream();
				audioStream.Index = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList["+ i +"].Index");
				audioStream.CodecName = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList["+ i +"].CodecName");
				audioStream.CodecTimeBase = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList["+ i +"].CodecTimeBase");
				audioStream.CodecLongName = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList["+ i +"].CodecLongName");
				audioStream.CodecTagString = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList["+ i +"].CodecTagString");
				audioStream.CodecTag = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList["+ i +"].CodecTag");
				audioStream.SampleFmt = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList["+ i +"].SampleFmt");
				audioStream.Samplerate = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList["+ i +"].Samplerate");
				audioStream.Channels = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList["+ i +"].Channels");
				audioStream.ChannelLayout = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList["+ i +"].ChannelLayout");
				audioStream.Timebase = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList["+ i +"].Timebase");
				audioStream.StartTime = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList["+ i +"].StartTime");
				audioStream.Duration = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList["+ i +"].Duration");
				audioStream.Bitrate = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList["+ i +"].Bitrate");
				audioStream.NumFrames = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList["+ i +"].NumFrames");
				audioStream.Lang = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.AudioStreamList["+ i +"].Lang");

				streams_audioStreamList.Add(audioStream);
			}
			streams.AudioStreamList = streams_audioStreamList;

			List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Streams.SubmitComplexJob_SubtitleStream> streams_subtitleStreamList = new List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Streams.SubmitComplexJob_SubtitleStream>();
			for (int i = 0; i < context.Length("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.SubtitleStreamList.Length"); i++) {
				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Streams.SubmitComplexJob_SubtitleStream subtitleStream = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Streams.SubmitComplexJob_SubtitleStream();
				subtitleStream.Index = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.SubtitleStreamList["+ i +"].Index");
				subtitleStream.Lang = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Streams.SubtitleStreamList["+ i +"].Lang");

				streams_subtitleStreamList.Add(subtitleStream);
			}
			streams.SubtitleStreamList = streams_subtitleStreamList;
			properties.Streams = streams;

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Format format = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Properties.SubmitComplexJob_Format();
			format.NumStreams = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Format.NumStreams");
			format.NumPrograms = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Format.NumPrograms");
			format.FormatName = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Format.FormatName");
			format.FormatLongName = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Format.FormatLongName");
			format.StartTime = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Format.StartTime");
			format.Duration = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Format.Duration");
			format.Size = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Format.Size");
			format.Bitrate = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Properties.Format.Bitrate");
			properties.Format = format;
			transcodeOutput.Properties = properties;

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Clip4 clip4 = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Clip4();

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Clip4.SubmitComplexJob_TimeSpan timeSpan = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Clip4.SubmitComplexJob_TimeSpan();
			timeSpan.Seek = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Clip.TimeSpan.Seek");
			timeSpan.Duration = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Clip.TimeSpan.Duration");
			clip4.TimeSpan = timeSpan;
			transcodeOutput.Clip4 = clip4;

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_SuperReso superReso = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_SuperReso();
			superReso.IsHalfSample = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.SuperReso.IsHalfSample");
			transcodeOutput.SuperReso = superReso;

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_SubtitleConfig subtitleConfig = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_SubtitleConfig();

			List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_SubtitleConfig.SubmitComplexJob_Subtitle> subtitleConfig_subtitleList = new List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_SubtitleConfig.SubmitComplexJob_Subtitle>();
			for (int i = 0; i < context.Length("SubmitComplexJob.ComplexJob.TranscodeOutput.SubtitleConfig.SubtitleList.Length"); i++) {
				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_SubtitleConfig.SubmitComplexJob_Subtitle subtitle = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_SubtitleConfig.SubmitComplexJob_Subtitle();
				subtitle.Map = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.SubtitleConfig.SubtitleList["+ i +"].Map");

				subtitleConfig_subtitleList.Add(subtitle);
			}
			subtitleConfig.SubtitleList = subtitleConfig_subtitleList;

			List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_SubtitleConfig.SubmitComplexJob_ExtSubtitle> subtitleConfig_extSubtitleList = new List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_SubtitleConfig.SubmitComplexJob_ExtSubtitle>();
			for (int i = 0; i < context.Length("SubmitComplexJob.ComplexJob.TranscodeOutput.SubtitleConfig.ExtSubtitleList.Length"); i++) {
				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_SubtitleConfig.SubmitComplexJob_ExtSubtitle extSubtitle = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_SubtitleConfig.SubmitComplexJob_ExtSubtitle();
				extSubtitle.FontName = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.SubtitleConfig.ExtSubtitleList["+ i +"].FontName");
				extSubtitle.CharEnc = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.SubtitleConfig.ExtSubtitleList["+ i +"].CharEnc");

				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_SubtitleConfig.SubmitComplexJob_ExtSubtitle.SubmitComplexJob_Input input = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_SubtitleConfig.SubmitComplexJob_ExtSubtitle.SubmitComplexJob_Input();
				input.Bucket = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.SubtitleConfig.ExtSubtitleList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.SubtitleConfig.ExtSubtitleList["+ i +"].Input.Location");
				input._Object = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.SubtitleConfig.ExtSubtitleList["+ i +"].Input.Object");
				extSubtitle.Input = input;

				subtitleConfig_extSubtitleList.Add(extSubtitle);
			}
			subtitleConfig.ExtSubtitleList = subtitleConfig_extSubtitleList;
			transcodeOutput.SubtitleConfig = subtitleConfig;

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_TransConfig transConfig = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_TransConfig();
			transConfig.TransMode = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.TransConfig.TransMode");
			transConfig.IsCheckReso = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.TransConfig.IsCheckReso");
			transConfig.IsCheckResoFail = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.TransConfig.IsCheckResoFail");
			transConfig.IsCheckVideoBitrate = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.TransConfig.IsCheckVideoBitrate");
			transConfig.IsCheckAudioBitrate = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.TransConfig.IsCheckAudioBitrate");
			transConfig.AdjDarMethod = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.TransConfig.AdjDarMethod");
			transConfig.IsCheckVideoBitrateFail = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.TransConfig.IsCheckVideoBitrateFail");
			transConfig.IsCheckAudioBitrateFail = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.TransConfig.IsCheckAudioBitrateFail");
			transConfig.Duration = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.TransConfig.Duration");
			transcodeOutput.TransConfig = transConfig;

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_MuxConfig muxConfig = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_MuxConfig();

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_MuxConfig.SubmitComplexJob_Segment segment = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_MuxConfig.SubmitComplexJob_Segment();
			segment.Duration = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.MuxConfig.Segment.Duration");
			muxConfig.Segment = segment;

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_MuxConfig.SubmitComplexJob_Gif gif = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_MuxConfig.SubmitComplexJob_Gif();
			gif.Loop = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.MuxConfig.Gif.Loop");
			gif.FinalDelay = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.MuxConfig.Gif.FinalDelay");
			gif.IsCustomPalette = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.MuxConfig.Gif.IsCustomPalette");
			gif.DitherMode = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.MuxConfig.Gif.DitherMode");
			muxConfig.Gif = gif;
			transcodeOutput.MuxConfig = muxConfig;

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Audio audio = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Audio();
			audio.Codec = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Audio.Codec");
			audio.Profile = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Audio.Profile");
			audio.Samplerate = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Audio.Samplerate");
			audio.Bitrate = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Audio.Bitrate");
			audio.Channels = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Audio.Channels");
			audio.Qscale = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Audio.Qscale");

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Audio.SubmitComplexJob_Volume volume = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Audio.SubmitComplexJob_Volume();
			volume.Level = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Audio.Volume.Level");
			volume.Method = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Audio.Volume.Method");
			audio.Volume = volume;
			transcodeOutput.Audio = audio;

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Video video = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Video();
			video.Codec = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.Codec");
			video.Profile = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.Profile");
			video.Bitrate = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.Bitrate");
			video.Crf = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.Crf");
			video.Width = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.Width");
			video.Height = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.Height");
			video.Fps = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.Fps");
			video.Gop = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.Gop");
			video.Preset = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.Preset");
			video.ScanMode = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.ScanMode");
			video.Bufsize = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.Bufsize");
			video.Maxrate = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.Maxrate");
			video.PixFmt = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.PixFmt");
			video.Degrain = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.Degrain");
			video.Qscale = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.Qscale");
			video.Crop = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.Crop");
			video.Pad = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.Pad");
			video.MaxFps = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.MaxFps");

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Video.SubmitComplexJob_BitrateBnd bitrateBnd = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Video.SubmitComplexJob_BitrateBnd();
			bitrateBnd.Max = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.BitrateBnd.Max");
			bitrateBnd.Min = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Video.BitrateBnd.Min");
			video.BitrateBnd = bitrateBnd;
			transcodeOutput.Video = video;

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Container container = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Container();
			container.Format = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Container.Format");
			transcodeOutput.Container = container;

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Encryption encryption = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Encryption();
			encryption.Type = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Encryption.Type");
			encryption.Id = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Encryption.Id");
			encryption.Key = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Encryption.Key");
			encryption.KeyUri = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Encryption.KeyUri");
			encryption.KeyType = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Encryption.KeyType");
			encryption.SkipCnt = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.Encryption.SkipCnt");
			transcodeOutput.Encryption = encryption;

			List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_WaterMark> transcodeOutput_waterMarkList = new List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_WaterMark>();
			for (int i = 0; i < context.Length("SubmitComplexJob.ComplexJob.TranscodeOutput.WaterMarkList.Length"); i++) {
				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_WaterMark waterMark = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_WaterMark();
				waterMark.WaterMarkTemplateId = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.WaterMarkList["+ i +"].WaterMarkTemplateId");
				waterMark.Width = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.WaterMarkList["+ i +"].Width");
				waterMark.Height = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.WaterMarkList["+ i +"].Height");
				waterMark.Dx = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.WaterMarkList["+ i +"].Dx");
				waterMark.Dy = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.WaterMarkList["+ i +"].Dy");
				waterMark.ReferPos = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.WaterMarkList["+ i +"].ReferPos");
				waterMark.Type = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.WaterMarkList["+ i +"].Type");

				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_WaterMark.SubmitComplexJob_InputFile2 inputFile2 = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_WaterMark.SubmitComplexJob_InputFile2();
				inputFile2.Bucket = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.WaterMarkList["+ i +"].InputFile.Bucket");
				inputFile2.Location = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.WaterMarkList["+ i +"].InputFile.Location");
				inputFile2._Object = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.WaterMarkList["+ i +"].InputFile.Object");
				waterMark.InputFile2 = inputFile2;

				transcodeOutput_waterMarkList.Add(waterMark);
			}
			transcodeOutput.WaterMarkList = transcodeOutput_waterMarkList;

			List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Merge> transcodeOutput_mergeList = new List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Merge>();
			for (int i = 0; i < context.Length("SubmitComplexJob.ComplexJob.TranscodeOutput.MergeList.Length"); i++) {
				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Merge merge = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_TranscodeOutput.SubmitComplexJob_Merge();
				merge.MergeURL = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.MergeList["+ i +"].MergeURL");
				merge.Start = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.MergeList["+ i +"].Start");
				merge.Duration = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.MergeList["+ i +"].Duration");
				merge.RoleArn = context.StringValue("SubmitComplexJob.ComplexJob.TranscodeOutput.MergeList["+ i +"].RoleArn");

				transcodeOutput_mergeList.Add(merge);
			}
			transcodeOutput.MergeList = transcodeOutput_mergeList;
			complexJob.TranscodeOutput = transcodeOutput;

			SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_MNSMessageResult mNSMessageResult = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_MNSMessageResult();
			mNSMessageResult.MessageId = context.StringValue("SubmitComplexJob.ComplexJob.MNSMessageResult.MessageId");
			mNSMessageResult.ErrorMessage = context.StringValue("SubmitComplexJob.ComplexJob.MNSMessageResult.ErrorMessage");
			mNSMessageResult.ErrorCode = context.StringValue("SubmitComplexJob.ComplexJob.MNSMessageResult.ErrorCode");
			complexJob.MNSMessageResult = mNSMessageResult;

			List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_InputsItem> complexJob_inputs = new List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_InputsItem>();
			for (int i = 0; i < context.Length("SubmitComplexJob.ComplexJob.Inputs.Length"); i++) {
				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_InputsItem inputsItem = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_InputsItem();

				List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_InputsItem.SubmitComplexJob_EditingInput> inputsItem_editingInputs = new List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_InputsItem.SubmitComplexJob_EditingInput>();
				for (int j = 0; j < context.Length("SubmitComplexJob.ComplexJob.Inputs["+ i +"].EditingInputs.Length"); j++) {
					SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_InputsItem.SubmitComplexJob_EditingInput editingInput = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_InputsItem.SubmitComplexJob_EditingInput();
					editingInput.Id = context.StringValue("SubmitComplexJob.ComplexJob.Inputs["+ i +"].EditingInputs["+ j +"].Id");

					SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_InputsItem.SubmitComplexJob_EditingInput.SubmitComplexJob_InputFile inputFile = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_InputsItem.SubmitComplexJob_EditingInput.SubmitComplexJob_InputFile();
					inputFile.Bucket = context.StringValue("SubmitComplexJob.ComplexJob.Inputs["+ i +"].EditingInputs["+ j +"].InputFile.Bucket");
					inputFile.Location = context.StringValue("SubmitComplexJob.ComplexJob.Inputs["+ i +"].EditingInputs["+ j +"].InputFile.Location");
					inputFile._Object = context.StringValue("SubmitComplexJob.ComplexJob.Inputs["+ i +"].EditingInputs["+ j +"].InputFile.Object");
					editingInput.InputFile = inputFile;

					SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_InputsItem.SubmitComplexJob_EditingInput.SubmitComplexJob_InputConfig inputConfig = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_InputsItem.SubmitComplexJob_EditingInput.SubmitComplexJob_InputConfig();
					inputConfig.DeinterlaceMethod = context.StringValue("SubmitComplexJob.ComplexJob.Inputs["+ i +"].EditingInputs["+ j +"].InputConfig.DeinterlaceMethod");
					inputConfig.IsNormalSar = context.StringValue("SubmitComplexJob.ComplexJob.Inputs["+ i +"].EditingInputs["+ j +"].InputConfig.IsNormalSar");
					editingInput.InputConfig = inputConfig;

					inputsItem_editingInputs.Add(editingInput);
				}
				inputsItem.EditingInputs = inputsItem_editingInputs;

				complexJob_inputs.Add(inputsItem);
			}
			complexJob.Inputs = complexJob_inputs;

			List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem> complexJob_complexEditingConfigs = new List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem>();
			for (int i = 0; i < context.Length("SubmitComplexJob.ComplexJob.ComplexEditingConfigs.Length"); i++) {
				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem complexEditingConfigsItem = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem();

				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing editing = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing();

				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline timeline = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline();

				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_TimelineConfig timelineConfig = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_TimelineConfig();

				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_TimelineConfig.SubmitComplexJob_TimelineConfigVideo timelineConfigVideo = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_TimelineConfig.SubmitComplexJob_TimelineConfigVideo();
				timelineConfigVideo.Width = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TimelineConfig.TimelineConfigVideo.Width");
				timelineConfigVideo.Height = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TimelineConfig.TimelineConfigVideo.Height");
				timelineConfigVideo.BgColor = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TimelineConfig.TimelineConfigVideo.BgColor");
				timelineConfigVideo.Fps = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TimelineConfig.TimelineConfigVideo.Fps");
				timelineConfigVideo.RenderRatio = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TimelineConfig.TimelineConfigVideo.RenderRatio");
				timelineConfigVideo.ReclosePrec = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TimelineConfig.TimelineConfigVideo.ReclosePrec");
				timelineConfigVideo.IsGpuData = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TimelineConfig.TimelineConfigVideo.IsGpuData");
				timelineConfigVideo.IsOneTrackData = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TimelineConfig.TimelineConfigVideo.IsOneTrackData");
				timelineConfig.TimelineConfigVideo = timelineConfigVideo;

				SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_TimelineConfig.SubmitComplexJob_TimelineConfigAudio timelineConfigAudio = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_TimelineConfig.SubmitComplexJob_TimelineConfigAudio();
				timelineConfigAudio.Samplerate = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TimelineConfig.TimelineConfigAudio.Samplerate");
				timelineConfigAudio.ChannelLayout = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TimelineConfig.TimelineConfigAudio.ChannelLayout");
				timelineConfigAudio.Channels = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TimelineConfig.TimelineConfigAudio.Channels");
				timelineConfig.TimelineConfigAudio = timelineConfigAudio;
				timeline.TimelineConfig = timelineConfig;

				List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_Track> timeline_trackList = new List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_Track>();
				for (int j = 0; j < context.Length("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TrackList.Length"); j++) {
					SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_Track track = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_Track();
					track.Id = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TrackList["+ j +"].Id");
					track.Type = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TrackList["+ j +"].Type");
					track.Order = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TrackList["+ j +"].Order");

					List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_Track.SubmitComplexJob_Clip1> track_clips = new List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_Track.SubmitComplexJob_Clip1>();
					for (int k = 0; k < context.Length("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TrackList["+ j +"].Clips.Length"); k++) {
						SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_Track.SubmitComplexJob_Clip1 clip1 = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_Track.SubmitComplexJob_Clip1();
						clip1.ClipID = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TrackList["+ j +"].Clips["+ k +"].clipID");
						clip1._In = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TrackList["+ j +"].Clips["+ k +"].In");
						clip1._Out = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TrackList["+ j +"].Clips["+ k +"].Out");

						SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_Track.SubmitComplexJob_Clip1.SubmitComplexJob_ClipsConfig clipsConfig = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_Track.SubmitComplexJob_Clip1.SubmitComplexJob_ClipsConfig();

						SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_Track.SubmitComplexJob_Clip1.SubmitComplexJob_ClipsConfig.SubmitComplexJob_ClipsConfigVideo clipsConfigVideo = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Timeline.SubmitComplexJob_Track.SubmitComplexJob_Clip1.SubmitComplexJob_ClipsConfig.SubmitComplexJob_ClipsConfigVideo();
						clipsConfigVideo.L = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TrackList["+ j +"].Clips["+ k +"].ClipsConfig.ClipsConfigVideo.L");
						clipsConfigVideo.T = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.Timeline.TrackList["+ j +"].Clips["+ k +"].ClipsConfig.ClipsConfigVideo.T");
						clipsConfig.ClipsConfigVideo = clipsConfigVideo;
						clip1.ClipsConfig = clipsConfig;

						track_clips.Add(clip1);
					}
					track.Clips = track_clips;

					timeline_trackList.Add(track);
				}
				timeline.TrackList = timeline_trackList;
				editing.Timeline = timeline;

				List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Clip> editing_clipList = new List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Clip>();
				for (int j = 0; j < context.Length("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.ClipList.Length"); j++) {
					SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Clip clip = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Clip();
					clip.Id = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.ClipList["+ j +"].Id");
					clip.Type = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.ClipList["+ j +"].Type");
					clip.SourceType = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.ClipList["+ j +"].SourceType");
					clip.SourceID = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.ClipList["+ j +"].SourceID");
					clip.SourceStrmMap = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.ClipList["+ j +"].SourceStrmMap");
					clip._In = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.ClipList["+ j +"].In");
					clip._Out = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.ClipList["+ j +"].Out");

					List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Clip.SubmitComplexJob_Effect> clip_effects = new List<SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Clip.SubmitComplexJob_Effect>();
					for (int k = 0; k < context.Length("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.ClipList["+ j +"].Effects.Length"); k++) {
						SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Clip.SubmitComplexJob_Effect effect = new SubmitComplexJobResponse.SubmitComplexJob_ComplexJob.SubmitComplexJob_ComplexEditingConfigsItem.SubmitComplexJob_Editing.SubmitComplexJob_Clip.SubmitComplexJob_Effect();
						effect.Effect = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.ClipList["+ j +"].Effects["+ k +"].Effect");
						effect.EffectConfig = context.StringValue("SubmitComplexJob.ComplexJob.ComplexEditingConfigs["+ i +"].Editing.ClipList["+ j +"].Effects["+ k +"].EffectConfig");

						clip_effects.Add(effect);
					}
					clip.Effects = clip_effects;

					editing_clipList.Add(clip);
				}
				editing.ClipList = editing_clipList;
				complexEditingConfigsItem.Editing = editing;

				complexJob_complexEditingConfigs.Add(complexEditingConfigsItem);
			}
			complexJob.ComplexEditingConfigs = complexJob_complexEditingConfigs;
			submitComplexJobResponse.ComplexJob = complexJob;
        
			return submitComplexJobResponse;
        }
    }
}
