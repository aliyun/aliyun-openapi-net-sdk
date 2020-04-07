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
    public class QueryComplexJobListResponseUnmarshaller
    {
        public static QueryComplexJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryComplexJobListResponse queryComplexJobListResponse = new QueryComplexJobListResponse();

			queryComplexJobListResponse.HttpResponse = context.HttpResponse;
			queryComplexJobListResponse.RequestId = context.StringValue("QueryComplexJobList.RequestId");

			List<string> queryComplexJobListResponse_nonExistJobIds = new List<string>();
			for (int i = 0; i < context.Length("QueryComplexJobList.NonExistJobIds.Length"); i++) {
				queryComplexJobListResponse_nonExistJobIds.Add(context.StringValue("QueryComplexJobList.NonExistJobIds["+ i +"]"));
			}
			queryComplexJobListResponse.NonExistJobIds = queryComplexJobListResponse_nonExistJobIds;

			List<QueryComplexJobListResponse.QueryComplexJobList_Job> queryComplexJobListResponse_jobList = new List<QueryComplexJobListResponse.QueryComplexJobList_Job>();
			for (int i = 0; i < context.Length("QueryComplexJobList.JobList.Length"); i++) {
				QueryComplexJobListResponse.QueryComplexJobList_Job job = new QueryComplexJobListResponse.QueryComplexJobList_Job();
				job.JobId = context.StringValue("QueryComplexJobList.JobList["+ i +"].JobId");
				job.State = context.StringValue("QueryComplexJobList.JobList["+ i +"].State");
				job.Code = context.StringValue("QueryComplexJobList.JobList["+ i +"].Code");
				job.Message = context.StringValue("QueryComplexJobList.JobList["+ i +"].Message");
				job.Percent = context.LongValue("QueryComplexJobList.JobList["+ i +"].Percent");
				job.PipelineId = context.StringValue("QueryComplexJobList.JobList["+ i +"].PipelineId");
				job.CreationTime = context.StringValue("QueryComplexJobList.JobList["+ i +"].CreationTime");
				job.FinishTime = context.StringValue("QueryComplexJobList.JobList["+ i +"].FinishTime");

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput transcodeOutput = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput();
				transcodeOutput.TemplateId = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.TemplateId");
				transcodeOutput.UserData = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.UserData");
				transcodeOutput.Rotate = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Rotate");
				transcodeOutput.VideoStreamMap = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.VideoStreamMap");
				transcodeOutput.AudioStreamMap = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.AudioStreamMap");
				transcodeOutput.DeWatermark = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.DeWatermark");
				transcodeOutput.Priority = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Priority");
				transcodeOutput.WaterMarkConfigUrl = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.WaterMarkConfigUrl");
				transcodeOutput.MergeConfigUrl = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.MergeConfigUrl");

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_DigiWaterMark digiWaterMark = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_DigiWaterMark();
				digiWaterMark.Type = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.DigiWaterMark.Type");
				digiWaterMark.Alpha = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.DigiWaterMark.Alpha");

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_DigiWaterMark.QueryComplexJobList_InputFile3 inputFile3 = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_DigiWaterMark.QueryComplexJobList_InputFile3();
				inputFile3.Bucket = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.DigiWaterMark.InputFile.Bucket");
				inputFile3.Location = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.DigiWaterMark.InputFile.Location");
				inputFile3._Object = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.DigiWaterMark.InputFile.Object");
				digiWaterMark.InputFile3 = inputFile3;
				transcodeOutput.DigiWaterMark = digiWaterMark;

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_OutputFile outputFile = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_OutputFile();
				outputFile.Bucket = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.OutputFile.Bucket");
				outputFile.Location = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.OutputFile.Location");
				outputFile._Object = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.OutputFile.Object");
				outputFile.RoleArn = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.OutputFile.RoleArn");
				transcodeOutput.OutputFile = outputFile;

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_M3U8NonStandardSupport m3U8NonStandardSupport = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_M3U8NonStandardSupport();

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_M3U8NonStandardSupport.QueryComplexJobList_TS tS = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_M3U8NonStandardSupport.QueryComplexJobList_TS();
				tS.Md5Support = context.BooleanValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.M3U8NonStandardSupport.TS.Md5Support");
				tS.SizeSupport = context.BooleanValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.M3U8NonStandardSupport.TS.SizeSupport");
				m3U8NonStandardSupport.TS = tS;
				transcodeOutput.M3U8NonStandardSupport = m3U8NonStandardSupport;

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties properties = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties();
				properties.Width = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Width");
				properties.Height = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Height");
				properties.Bitrate = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Bitrate");
				properties.Duration = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Duration");
				properties.Fps = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Fps");
				properties.FileSize = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.FileSize");
				properties.FileFormat = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.FileFormat");

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Streams streams = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Streams();

				List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Streams.QueryComplexJobList_VideoStream> streams_videoStreamList = new List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Streams.QueryComplexJobList_VideoStream>();
				for (int j = 0; j < context.Length("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList.Length"); j++) {
					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Streams.QueryComplexJobList_VideoStream videoStream = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Streams.QueryComplexJobList_VideoStream();
					videoStream.Index = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.CodecName = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.CodecLongName = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Profile = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.CodecTimeBase = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.CodecTagString = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.CodecTag = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.Width = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Height = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.HasBFrames = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Sar = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Dar = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.PixFmt = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Level = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].Level");
					videoStream.Fps = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.AvgFPS = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.Timebase = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.StartTime = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Duration = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Bitrate = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.NumFrames = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Lang = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].Lang");

					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Streams.QueryComplexJobList_VideoStream.QueryComplexJobList_NetworkCost networkCost = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Streams.QueryComplexJobList_VideoStream.QueryComplexJobList_NetworkCost();
					networkCost.PreloadTime = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;

				List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Streams.QueryComplexJobList_AudioStream> streams_audioStreamList = new List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Streams.QueryComplexJobList_AudioStream>();
				for (int j = 0; j < context.Length("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList.Length"); j++) {
					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Streams.QueryComplexJobList_AudioStream audioStream = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Streams.QueryComplexJobList_AudioStream();
					audioStream.Index = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.CodecName = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.CodecTimeBase = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.CodecLongName = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.CodecTagString = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.CodecTag = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.SampleFmt = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.Samplerate = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.Channels = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.ChannelLayout = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Timebase = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.StartTime = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.Duration = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.Bitrate = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.NumFrames = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Lang = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.AudioStreamList["+ j +"].Lang");

					streams_audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = streams_audioStreamList;

				List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Streams.QueryComplexJobList_SubtitleStream> streams_subtitleStreamList = new List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Streams.QueryComplexJobList_SubtitleStream>();
				for (int j = 0; j < context.Length("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.SubtitleStreamList.Length"); j++) {
					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Streams.QueryComplexJobList_SubtitleStream subtitleStream = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Streams.QueryComplexJobList_SubtitleStream();
					subtitleStream.Index = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					streams_subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = streams_subtitleStreamList;
				properties.Streams = streams;

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Format format = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Properties.QueryComplexJobList_Format();
				format.NumStreams = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Format.NumStreams");
				format.NumPrograms = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Format.NumPrograms");
				format.FormatName = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Format.FormatName");
				format.FormatLongName = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Format.FormatLongName");
				format.StartTime = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Format.StartTime");
				format.Duration = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Format.Duration");
				format.Size = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Format.Size");
				format.Bitrate = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Properties.Format.Bitrate");
				properties.Format = format;
				transcodeOutput.Properties = properties;

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Clip4 clip4 = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Clip4();

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Clip4.QueryComplexJobList_TimeSpan timeSpan = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Clip4.QueryComplexJobList_TimeSpan();
				timeSpan.Seek = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Clip.TimeSpan.Seek");
				timeSpan.Duration = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Clip.TimeSpan.Duration");
				clip4.TimeSpan = timeSpan;
				transcodeOutput.Clip4 = clip4;

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_SuperReso superReso = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_SuperReso();
				superReso.IsHalfSample = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.SuperReso.IsHalfSample");
				transcodeOutput.SuperReso = superReso;

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_SubtitleConfig subtitleConfig = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_SubtitleConfig();

				List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_SubtitleConfig.QueryComplexJobList_Subtitle> subtitleConfig_subtitleList = new List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_SubtitleConfig.QueryComplexJobList_Subtitle>();
				for (int j = 0; j < context.Length("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.SubtitleConfig.SubtitleList.Length"); j++) {
					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_SubtitleConfig.QueryComplexJobList_Subtitle subtitle = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_SubtitleConfig.QueryComplexJobList_Subtitle();
					subtitle.Map = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.SubtitleConfig.SubtitleList["+ j +"].Map");

					subtitleConfig_subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleConfig_subtitleList;

				List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_SubtitleConfig.QueryComplexJobList_ExtSubtitle> subtitleConfig_extSubtitleList = new List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_SubtitleConfig.QueryComplexJobList_ExtSubtitle>();
				for (int j = 0; j < context.Length("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_SubtitleConfig.QueryComplexJobList_ExtSubtitle extSubtitle = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_SubtitleConfig.QueryComplexJobList_ExtSubtitle();
					extSubtitle.FontName = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.SubtitleConfig.ExtSubtitleList["+ j +"].FontName");
					extSubtitle.CharEnc = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.SubtitleConfig.ExtSubtitleList["+ j +"].CharEnc");

					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_SubtitleConfig.QueryComplexJobList_ExtSubtitle.QueryComplexJobList_Input input = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_SubtitleConfig.QueryComplexJobList_ExtSubtitle.QueryComplexJobList_Input();
					input.Bucket = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Bucket");
					input.Location = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Location");
					input._Object = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Object");
					extSubtitle.Input = input;

					subtitleConfig_extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = subtitleConfig_extSubtitleList;
				transcodeOutput.SubtitleConfig = subtitleConfig;

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_TransConfig transConfig = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_TransConfig();
				transConfig.TransMode = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.TransConfig.TransMode");
				transConfig.IsCheckReso = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.TransConfig.IsCheckReso");
				transConfig.IsCheckResoFail = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.TransConfig.IsCheckResoFail");
				transConfig.IsCheckVideoBitrate = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckAudioBitrate = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.TransConfig.IsCheckAudioBitrate");
				transConfig.AdjDarMethod = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.TransConfig.AdjDarMethod");
				transConfig.IsCheckVideoBitrateFail = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.TransConfig.IsCheckVideoBitrateFail");
				transConfig.IsCheckAudioBitrateFail = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.TransConfig.IsCheckAudioBitrateFail");
				transConfig.Duration = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.TransConfig.Duration");
				transcodeOutput.TransConfig = transConfig;

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_MuxConfig muxConfig = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_MuxConfig();

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_MuxConfig.QueryComplexJobList_Segment segment = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_MuxConfig.QueryComplexJobList_Segment();
				segment.Duration = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_MuxConfig.QueryComplexJobList_Gif gif = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_MuxConfig.QueryComplexJobList_Gif();
				gif.Loop = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.MuxConfig.Gif.FinalDelay");
				gif.IsCustomPalette = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.MuxConfig.Gif.IsCustomPalette");
				gif.DitherMode = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.MuxConfig.Gif.DitherMode");
				muxConfig.Gif = gif;
				transcodeOutput.MuxConfig = muxConfig;

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Audio audio = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Audio();
				audio.Codec = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Audio.Codec");
				audio.Profile = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Audio.Profile");
				audio.Samplerate = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Audio.Samplerate");
				audio.Bitrate = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Audio.Bitrate");
				audio.Channels = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Audio.Channels");
				audio.Qscale = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Audio.Qscale");

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Audio.QueryComplexJobList_Volume volume = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Audio.QueryComplexJobList_Volume();
				volume.Level = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Audio.Volume.Level");
				volume.Method = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Audio.Volume.Method");
				audio.Volume = volume;
				transcodeOutput.Audio = audio;

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Video video = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Video();
				video.Codec = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.Codec");
				video.Profile = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.Profile");
				video.Bitrate = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.Bitrate");
				video.Crf = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.Crf");
				video.Width = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.Width");
				video.Height = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.Height");
				video.Fps = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.Fps");
				video.Gop = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.Gop");
				video.Preset = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.Preset");
				video.ScanMode = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.ScanMode");
				video.Bufsize = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.Bufsize");
				video.Maxrate = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.Maxrate");
				video.PixFmt = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.PixFmt");
				video.Degrain = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.Degrain");
				video.Qscale = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.Qscale");
				video.Crop = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.Crop");
				video.Pad = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.Pad");
				video.MaxFps = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.MaxFps");

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Video.QueryComplexJobList_BitrateBnd bitrateBnd = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Video.QueryComplexJobList_BitrateBnd();
				bitrateBnd.Max = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				transcodeOutput.Video = video;

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Container container = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Container();
				container.Format = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Container.Format");
				transcodeOutput.Container = container;

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Encryption encryption = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Encryption();
				encryption.Type = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Encryption.Type");
				encryption.Id = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Encryption.Id");
				encryption.Key = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Encryption.Key");
				encryption.KeyUri = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Encryption.KeyUri");
				encryption.KeyType = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Encryption.KeyType");
				encryption.SkipCnt = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.Encryption.SkipCnt");
				transcodeOutput.Encryption = encryption;

				List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_WaterMark> transcodeOutput_waterMarkList = new List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_WaterMark>();
				for (int j = 0; j < context.Length("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.WaterMarkList.Length"); j++) {
					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_WaterMark waterMark = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_WaterMark();
					waterMark.WaterMarkTemplateId = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.WaterMarkList["+ j +"].WaterMarkTemplateId");
					waterMark.Width = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.WaterMarkList["+ j +"].Width");
					waterMark.Height = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.WaterMarkList["+ j +"].Height");
					waterMark.Dx = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.WaterMarkList["+ j +"].Dx");
					waterMark.Dy = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.WaterMarkList["+ j +"].Dy");
					waterMark.ReferPos = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.WaterMarkList["+ j +"].ReferPos");
					waterMark.Type = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.WaterMarkList["+ j +"].Type");

					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_WaterMark.QueryComplexJobList_InputFile2 inputFile2 = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_WaterMark.QueryComplexJobList_InputFile2();
					inputFile2.Bucket = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.WaterMarkList["+ j +"].InputFile.Bucket");
					inputFile2.Location = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.WaterMarkList["+ j +"].InputFile.Location");
					inputFile2._Object = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.WaterMarkList["+ j +"].InputFile.Object");
					waterMark.InputFile2 = inputFile2;

					transcodeOutput_waterMarkList.Add(waterMark);
				}
				transcodeOutput.WaterMarkList = transcodeOutput_waterMarkList;

				List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Merge> transcodeOutput_mergeList = new List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Merge>();
				for (int j = 0; j < context.Length("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.MergeList.Length"); j++) {
					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Merge merge = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_TranscodeOutput.QueryComplexJobList_Merge();
					merge.MergeURL = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.MergeList["+ j +"].MergeURL");
					merge.Start = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.MergeList["+ j +"].Start");
					merge.Duration = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.MergeList["+ j +"].Duration");
					merge.RoleArn = context.StringValue("QueryComplexJobList.JobList["+ i +"].TranscodeOutput.MergeList["+ j +"].RoleArn");

					transcodeOutput_mergeList.Add(merge);
				}
				transcodeOutput.MergeList = transcodeOutput_mergeList;
				job.TranscodeOutput = transcodeOutput;

				QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_MNSMessageResult mNSMessageResult = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_MNSMessageResult();
				mNSMessageResult.MessageId = context.StringValue("QueryComplexJobList.JobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = context.StringValue("QueryComplexJobList.JobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = context.StringValue("QueryComplexJobList.JobList["+ i +"].MNSMessageResult.ErrorCode");
				job.MNSMessageResult = mNSMessageResult;

				List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_InputsItem> job_inputs = new List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_InputsItem>();
				for (int j = 0; j < context.Length("QueryComplexJobList.JobList["+ i +"].Inputs.Length"); j++) {
					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_InputsItem inputsItem = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_InputsItem();

					List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_InputsItem.QueryComplexJobList_EditingInput> inputsItem_editingInputs = new List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_InputsItem.QueryComplexJobList_EditingInput>();
					for (int k = 0; k < context.Length("QueryComplexJobList.JobList["+ i +"].Inputs["+ j +"].EditingInputs.Length"); k++) {
						QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_InputsItem.QueryComplexJobList_EditingInput editingInput = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_InputsItem.QueryComplexJobList_EditingInput();
						editingInput.Id = context.StringValue("QueryComplexJobList.JobList["+ i +"].Inputs["+ j +"].EditingInputs["+ k +"].Id");

						QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_InputsItem.QueryComplexJobList_EditingInput.QueryComplexJobList_InputFile inputFile = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_InputsItem.QueryComplexJobList_EditingInput.QueryComplexJobList_InputFile();
						inputFile.Bucket = context.StringValue("QueryComplexJobList.JobList["+ i +"].Inputs["+ j +"].EditingInputs["+ k +"].InputFile.Bucket");
						inputFile.Location = context.StringValue("QueryComplexJobList.JobList["+ i +"].Inputs["+ j +"].EditingInputs["+ k +"].InputFile.Location");
						inputFile._Object = context.StringValue("QueryComplexJobList.JobList["+ i +"].Inputs["+ j +"].EditingInputs["+ k +"].InputFile.Object");
						editingInput.InputFile = inputFile;

						QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_InputsItem.QueryComplexJobList_EditingInput.QueryComplexJobList_InputConfig inputConfig = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_InputsItem.QueryComplexJobList_EditingInput.QueryComplexJobList_InputConfig();
						inputConfig.DeinterlaceMethod = context.StringValue("QueryComplexJobList.JobList["+ i +"].Inputs["+ j +"].EditingInputs["+ k +"].InputConfig.DeinterlaceMethod");
						inputConfig.IsNormalSar = context.StringValue("QueryComplexJobList.JobList["+ i +"].Inputs["+ j +"].EditingInputs["+ k +"].InputConfig.IsNormalSar");
						editingInput.InputConfig = inputConfig;

						inputsItem_editingInputs.Add(editingInput);
					}
					inputsItem.EditingInputs = inputsItem_editingInputs;

					job_inputs.Add(inputsItem);
				}
				job.Inputs = job_inputs;

				List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem> job_complexEditingConfigs = new List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem>();
				for (int j = 0; j < context.Length("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs.Length"); j++) {
					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem complexEditingConfigsItem = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem();

					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing editing = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing();

					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline timeline = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline();

					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_TimelineConfig timelineConfig = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_TimelineConfig();

					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_TimelineConfig.QueryComplexJobList_TimelineConfigVideo timelineConfigVideo = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_TimelineConfig.QueryComplexJobList_TimelineConfigVideo();
					timelineConfigVideo.Width = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TimelineConfig.TimelineConfigVideo.Width");
					timelineConfigVideo.Height = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TimelineConfig.TimelineConfigVideo.Height");
					timelineConfigVideo.BgColor = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TimelineConfig.TimelineConfigVideo.BgColor");
					timelineConfigVideo.Fps = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TimelineConfig.TimelineConfigVideo.Fps");
					timelineConfigVideo.RenderRatio = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TimelineConfig.TimelineConfigVideo.RenderRatio");
					timelineConfigVideo.ReclosePrec = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TimelineConfig.TimelineConfigVideo.ReclosePrec");
					timelineConfigVideo.IsGpuData = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TimelineConfig.TimelineConfigVideo.IsGpuData");
					timelineConfigVideo.IsOneTrackData = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TimelineConfig.TimelineConfigVideo.IsOneTrackData");
					timelineConfig.TimelineConfigVideo = timelineConfigVideo;

					QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_TimelineConfig.QueryComplexJobList_TimelineConfigAudio timelineConfigAudio = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_TimelineConfig.QueryComplexJobList_TimelineConfigAudio();
					timelineConfigAudio.Samplerate = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TimelineConfig.TimelineConfigAudio.Samplerate");
					timelineConfigAudio.ChannelLayout = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TimelineConfig.TimelineConfigAudio.ChannelLayout");
					timelineConfigAudio.Channels = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TimelineConfig.TimelineConfigAudio.Channels");
					timelineConfig.TimelineConfigAudio = timelineConfigAudio;
					timeline.TimelineConfig = timelineConfig;

					List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_Track> timeline_trackList = new List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_Track>();
					for (int k = 0; k < context.Length("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TrackList.Length"); k++) {
						QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_Track track = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_Track();
						track.Id = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TrackList["+ k +"].Id");
						track.Type = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TrackList["+ k +"].Type");
						track.Order = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TrackList["+ k +"].Order");

						List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_Track.QueryComplexJobList_Clip1> track_clips = new List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_Track.QueryComplexJobList_Clip1>();
						for (int l = 0; l < context.Length("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TrackList["+ k +"].Clips.Length"); l++) {
							QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_Track.QueryComplexJobList_Clip1 clip1 = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_Track.QueryComplexJobList_Clip1();
							clip1.ClipID = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TrackList["+ k +"].Clips["+ l +"].clipID");
							clip1._In = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TrackList["+ k +"].Clips["+ l +"].In");
							clip1._Out = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TrackList["+ k +"].Clips["+ l +"].Out");

							QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_Track.QueryComplexJobList_Clip1.QueryComplexJobList_ClipsConfig clipsConfig = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_Track.QueryComplexJobList_Clip1.QueryComplexJobList_ClipsConfig();

							QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_Track.QueryComplexJobList_Clip1.QueryComplexJobList_ClipsConfig.QueryComplexJobList_ClipsConfigVideo clipsConfigVideo = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Timeline.QueryComplexJobList_Track.QueryComplexJobList_Clip1.QueryComplexJobList_ClipsConfig.QueryComplexJobList_ClipsConfigVideo();
							clipsConfigVideo.L = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TrackList["+ k +"].Clips["+ l +"].ClipsConfig.ClipsConfigVideo.L");
							clipsConfigVideo.T = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.Timeline.TrackList["+ k +"].Clips["+ l +"].ClipsConfig.ClipsConfigVideo.T");
							clipsConfig.ClipsConfigVideo = clipsConfigVideo;
							clip1.ClipsConfig = clipsConfig;

							track_clips.Add(clip1);
						}
						track.Clips = track_clips;

						timeline_trackList.Add(track);
					}
					timeline.TrackList = timeline_trackList;
					editing.Timeline = timeline;

					List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Clip> editing_clipList = new List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Clip>();
					for (int k = 0; k < context.Length("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.ClipList.Length"); k++) {
						QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Clip clip = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Clip();
						clip.Id = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.ClipList["+ k +"].Id");
						clip.Type = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.ClipList["+ k +"].Type");
						clip.SourceType = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.ClipList["+ k +"].SourceType");
						clip.SourceID = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.ClipList["+ k +"].SourceID");
						clip.SourceStrmMap = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.ClipList["+ k +"].SourceStrmMap");
						clip._In = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.ClipList["+ k +"].In");
						clip._Out = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.ClipList["+ k +"].Out");

						List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Clip.QueryComplexJobList_Effect> clip_effects = new List<QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Clip.QueryComplexJobList_Effect>();
						for (int l = 0; l < context.Length("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.ClipList["+ k +"].Effects.Length"); l++) {
							QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Clip.QueryComplexJobList_Effect effect = new QueryComplexJobListResponse.QueryComplexJobList_Job.QueryComplexJobList_ComplexEditingConfigsItem.QueryComplexJobList_Editing.QueryComplexJobList_Clip.QueryComplexJobList_Effect();
							effect.Effect = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.ClipList["+ k +"].Effects["+ l +"].Effect");
							effect.EffectConfig = context.StringValue("QueryComplexJobList.JobList["+ i +"].ComplexEditingConfigs["+ j +"].Editing.ClipList["+ k +"].Effects["+ l +"].EffectConfig");

							clip_effects.Add(effect);
						}
						clip.Effects = clip_effects;

						editing_clipList.Add(clip);
					}
					editing.ClipList = editing_clipList;
					complexEditingConfigsItem.Editing = editing;

					job_complexEditingConfigs.Add(complexEditingConfigsItem);
				}
				job.ComplexEditingConfigs = job_complexEditingConfigs;

				queryComplexJobListResponse_jobList.Add(job);
			}
			queryComplexJobListResponse.JobList = queryComplexJobListResponse_jobList;
        
			return queryComplexJobListResponse;
        }
    }
}
