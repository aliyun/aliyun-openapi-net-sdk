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

			List<SubmitJobsResponse.SubmitJobs_JobResult> submitJobsResponse_jobResultList = new List<SubmitJobsResponse.SubmitJobs_JobResult>();
			for (int i = 0; i < context.Length("SubmitJobs.JobResultList.Length"); i++) {
				SubmitJobsResponse.SubmitJobs_JobResult jobResult = new SubmitJobsResponse.SubmitJobs_JobResult();
				jobResult.Success = context.BooleanValue("SubmitJobs.JobResultList["+ i +"].Success");
				jobResult.Code = context.StringValue("SubmitJobs.JobResultList["+ i +"].Code");
				jobResult.Message = context.StringValue("SubmitJobs.JobResultList["+ i +"].Message");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job job = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job();
				job.JobId = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.JobId");
				job.State = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.State");
				job.Code = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Code");
				job.Message = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Message");
				job.Percent = context.LongValue("SubmitJobs.JobResultList["+ i +"].Job.Percent");
				job.PipelineId = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.PipelineId");
				job.CreationTime = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.CreationTime");
				job.FinishTime = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.FinishTime");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Input input = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Input();
				input.Bucket = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Input.Bucket");
				input.Location = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Input.Location");
				input._Object = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Input.Object");
				job.Input = input;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output output = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output();
				output.TemplateId = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TemplateId");
				output.UserData = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.UserData");
				output.Rotate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Rotate");
				output.VideoStreamMap = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.VideoStreamMap");
				output.AudioStreamMap = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.AudioStreamMap");
				output.DeWatermark = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DeWatermark");
				output.Priority = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Priority");
				output.WaterMarkConfigUrl = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkConfigUrl");
				output.MergeConfigUrl = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeConfigUrl");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_DigiWaterMark digiWaterMark = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_DigiWaterMark();
				digiWaterMark.Type = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DigiWaterMark.Type");
				digiWaterMark.Alpha = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DigiWaterMark.Alpha");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_DigiWaterMark.SubmitJobs_InputFile1 inputFile1 = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_DigiWaterMark.SubmitJobs_InputFile1();
				inputFile1.Bucket = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DigiWaterMark.InputFile.Bucket");
				inputFile1.Location = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DigiWaterMark.InputFile.Location");
				inputFile1._Object = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DigiWaterMark.InputFile.Object");
				digiWaterMark.InputFile1 = inputFile1;
				output.DigiWaterMark = digiWaterMark;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutputFile outputFile = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutputFile();
				outputFile.Bucket = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutputFile.Bucket");
				outputFile.Location = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutputFile.Location");
				outputFile._Object = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutputFile.Object");
				outputFile.RoleArn = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutputFile.RoleArn");
				output.OutputFile = outputFile;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_M3U8NonStandardSupport m3U8NonStandardSupport = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_M3U8NonStandardSupport();

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_M3U8NonStandardSupport.SubmitJobs_TS tS = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_M3U8NonStandardSupport.SubmitJobs_TS();
				tS.Md5Support = context.BooleanValue("SubmitJobs.JobResultList["+ i +"].Job.Output.M3U8NonStandardSupport.TS.Md5Support");
				tS.SizeSupport = context.BooleanValue("SubmitJobs.JobResultList["+ i +"].Job.Output.M3U8NonStandardSupport.TS.SizeSupport");
				m3U8NonStandardSupport.TS = tS;
				output.M3U8NonStandardSupport = m3U8NonStandardSupport;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties properties = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties();
				properties.Width = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Width");
				properties.Height = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Height");
				properties.Bitrate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Bitrate");
				properties.Duration = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Duration");
				properties.Fps = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Fps");
				properties.FileSize = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.FileSize");
				properties.FileFormat = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.FileFormat");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams streams = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams();

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream> streams_videoStreamList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream>();
				for (int j = 0; j < context.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream videoStream = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream();
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

					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream.SubmitJobs_NetworkCost networkCost = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream.SubmitJobs_NetworkCost();
					networkCost.PreloadTime = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_AudioStream> streams_audioStreamList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_AudioStream>();
				for (int j = 0; j < context.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_AudioStream audioStream = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_AudioStream();
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

					streams_audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = streams_audioStreamList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_SubtitleStream> streams_subtitleStreamList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_SubtitleStream>();
				for (int j = 0; j < context.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_SubtitleStream subtitleStream = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_SubtitleStream();
					subtitleStream.Index = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					streams_subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = streams_subtitleStreamList;
				properties.Streams = streams;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Format format = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Format();
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

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Clip clip = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Clip();

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Clip.SubmitJobs_TimeSpan timeSpan = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Clip.SubmitJobs_TimeSpan();
				timeSpan.Seek = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Clip.TimeSpan.Seek");
				timeSpan.Duration = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Clip.TimeSpan.Duration");
				clip.TimeSpan = timeSpan;
				output.Clip = clip;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SuperReso superReso = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SuperReso();
				superReso.IsHalfSample = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SuperReso.IsHalfSample");
				output.SuperReso = superReso;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig subtitleConfig = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig();

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_Subtitle> subtitleConfig_subtitleList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_Subtitle>();
				for (int j = 0; j < context.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.SubtitleList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_Subtitle subtitle = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_Subtitle();
					subtitle.Map = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.SubtitleList["+ j +"].Map");

					subtitleConfig_subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleConfig_subtitleList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle> subtitleConfig_extSubtitleList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle>();
				for (int j = 0; j < context.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle extSubtitle = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle();
					extSubtitle.FontName = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].FontName");
					extSubtitle.CharEnc = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].CharEnc");

					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle.SubmitJobs_Input2 input2 = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle.SubmitJobs_Input2();
					input2.Bucket = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Bucket");
					input2.Location = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Location");
					input2._Object = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Object");
					extSubtitle.Input2 = input2;

					subtitleConfig_extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = subtitleConfig_extSubtitleList;
				output.SubtitleConfig = subtitleConfig;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TransConfig transConfig = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TransConfig();
				transConfig.TransMode = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.TransMode");
				transConfig.IsCheckReso = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckReso");
				transConfig.IsCheckResoFail = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckResoFail");
				transConfig.IsCheckVideoBitrate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckAudioBitrate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckAudioBitrate");
				transConfig.AdjDarMethod = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.AdjDarMethod");
				transConfig.IsCheckVideoBitrateFail = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckVideoBitrateFail");
				transConfig.IsCheckAudioBitrateFail = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckAudioBitrateFail");
				output.TransConfig = transConfig;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig muxConfig = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig();

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig.SubmitJobs_Segment segment = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig.SubmitJobs_Segment();
				segment.Duration = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig.SubmitJobs_Gif gif = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig.SubmitJobs_Gif();
				gif.Loop = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Gif.FinalDelay");
				gif.IsCustomPalette = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Gif.IsCustomPalette");
				gif.DitherMode = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Gif.DitherMode");
				muxConfig.Gif = gif;
				output.MuxConfig = muxConfig;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Audio audio = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Audio();
				audio.Codec = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Codec");
				audio.Profile = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Profile");
				audio.Samplerate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Samplerate");
				audio.Bitrate = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Bitrate");
				audio.Channels = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Channels");
				audio.Qscale = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Qscale");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Audio.SubmitJobs_Volume volume = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Audio.SubmitJobs_Volume();
				volume.Level = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Volume.Level");
				volume.Method = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Volume.Method");
				audio.Volume = volume;
				output.Audio = audio;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Video video = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Video();
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

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Video.SubmitJobs_BitrateBnd bitrateBnd = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Video.SubmitJobs_BitrateBnd();
				bitrateBnd.Max = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				output.Video = video;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Container container = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Container();
				container.Format = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Container.Format");
				output.Container = container;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Encryption encryption = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Encryption();
				encryption.Type = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.Type");
				encryption.Id = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.Id");
				encryption.Key = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.Key");
				encryption.KeyUri = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.KeyUri");
				encryption.KeyType = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.KeyType");
				encryption.SkipCnt = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.SkipCnt");
				output.Encryption = encryption;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark> output_waterMarkList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark>();
				for (int j = 0; j < context.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark waterMark = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark();
					waterMark.WaterMarkTemplateId = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].WaterMarkTemplateId");
					waterMark.Width = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Width");
					waterMark.Height = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Height");
					waterMark.Dx = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Dx");
					waterMark.Dy = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Dy");
					waterMark.ReferPos = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].ReferPos");
					waterMark.Type = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Type");

					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark.SubmitJobs_InputFile inputFile = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark.SubmitJobs_InputFile();
					inputFile.Bucket = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].InputFile.Bucket");
					inputFile.Location = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].InputFile.Location");
					inputFile._Object = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].InputFile.Object");
					waterMark.InputFile = inputFile;

					output_waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = output_waterMarkList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Merge> output_mergeList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Merge>();
				for (int j = 0; j < context.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Merge merge = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Merge();
					merge.MergeURL = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList["+ j +"].MergeURL");
					merge.Start = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList["+ j +"].Start");
					merge.Duration = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList["+ j +"].Duration");
					merge.RoleArn = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList["+ j +"].RoleArn");

					output_mergeList.Add(merge);
				}
				output.MergeList = output_mergeList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Opening> output_openingList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Opening>();
				for (int j = 0; j < context.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.OpeningList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Opening opening = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Opening();
					opening.OpenUrl = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OpeningList["+ j +"].OpenUrl");
					opening.Start = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OpeningList["+ j +"].Start");
					opening.Width = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OpeningList["+ j +"].Width");
					opening.Height = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OpeningList["+ j +"].Height");

					output_openingList.Add(opening);
				}
				output.OpeningList = output_openingList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TailSlate> output_tailSlateList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TailSlate>();
				for (int j = 0; j < context.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TailSlate tailSlate = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TailSlate();
					tailSlate.TailUrl = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].TailUrl");
					tailSlate.Start = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].Start");
					tailSlate.BlendDuration = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].BlendDuration");
					tailSlate.Width = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].Width");
					tailSlate.Height = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].Height");
					tailSlate.IsMergeAudio = context.BooleanValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].IsMergeAudio");
					tailSlate.BgColor = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].BgColor");

					output_tailSlateList.Add(tailSlate);
				}
				output.TailSlateList = output_tailSlateList;
				job.Output = output;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_MNSMessageResult mNSMessageResult = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_MNSMessageResult();
				mNSMessageResult.MessageId = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = context.StringValue("SubmitJobs.JobResultList["+ i +"].Job.MNSMessageResult.ErrorCode");
				job.MNSMessageResult = mNSMessageResult;
				jobResult.Job = job;

				submitJobsResponse_jobResultList.Add(jobResult);
			}
			submitJobsResponse.JobResultList = submitJobsResponse_jobResultList;
        
			return submitJobsResponse;
        }
    }
}