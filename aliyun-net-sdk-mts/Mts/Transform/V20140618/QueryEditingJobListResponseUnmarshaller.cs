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
    public class QueryEditingJobListResponseUnmarshaller
    {
        public static QueryEditingJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryEditingJobListResponse queryEditingJobListResponse = new QueryEditingJobListResponse();

			queryEditingJobListResponse.HttpResponse = context.HttpResponse;
			queryEditingJobListResponse.RequestId = context.StringValue("QueryEditingJobList.RequestId");

			List<string> queryEditingJobListResponse_nonExistJobIds = new List<string>();
			for (int i = 0; i < context.Length("QueryEditingJobList.NonExistJobIds.Length"); i++) {
				queryEditingJobListResponse_nonExistJobIds.Add(context.StringValue("QueryEditingJobList.NonExistJobIds["+ i +"]"));
			}
			queryEditingJobListResponse.NonExistJobIds = queryEditingJobListResponse_nonExistJobIds;

			List<QueryEditingJobListResponse.QueryEditingJobList_Job> queryEditingJobListResponse_jobList = new List<QueryEditingJobListResponse.QueryEditingJobList_Job>();
			for (int i = 0; i < context.Length("QueryEditingJobList.JobList.Length"); i++) {
				QueryEditingJobListResponse.QueryEditingJobList_Job job = new QueryEditingJobListResponse.QueryEditingJobList_Job();
				job.JobId = context.StringValue("QueryEditingJobList.JobList["+ i +"].JobId");
				job.State = context.StringValue("QueryEditingJobList.JobList["+ i +"].State");
				job.Code = context.StringValue("QueryEditingJobList.JobList["+ i +"].Code");
				job.Message = context.StringValue("QueryEditingJobList.JobList["+ i +"].Message");
				job.Percent = context.LongValue("QueryEditingJobList.JobList["+ i +"].Percent");
				job.PipelineId = context.StringValue("QueryEditingJobList.JobList["+ i +"].PipelineId");
				job.CreationTime = context.StringValue("QueryEditingJobList.JobList["+ i +"].CreationTime");
				job.FinishTime = context.StringValue("QueryEditingJobList.JobList["+ i +"].FinishTime");

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig editingConfig = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig();
				editingConfig.TemplateId = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.TemplateId");
				editingConfig.UserData = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.UserData");
				editingConfig.Rotate = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Rotate");
				editingConfig.VideoStreamMap = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.VideoStreamMap");
				editingConfig.AudioStreamMap = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.AudioStreamMap");
				editingConfig.DeWatermark = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.DeWatermark");
				editingConfig.Priority = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Priority");
				editingConfig.WaterMarkConfigUrl = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.WaterMarkConfigUrl");
				editingConfig.MergeConfigUrl = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.MergeConfigUrl");

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_DigiWaterMark digiWaterMark = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_DigiWaterMark();
				digiWaterMark.Type = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.DigiWaterMark.Type");
				digiWaterMark.Alpha = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.DigiWaterMark.Alpha");

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_DigiWaterMark.QueryEditingJobList_InputFile2 inputFile2 = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_DigiWaterMark.QueryEditingJobList_InputFile2();
				inputFile2.Bucket = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.DigiWaterMark.InputFile.Bucket");
				inputFile2.Location = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.DigiWaterMark.InputFile.Location");
				inputFile2._Object = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.DigiWaterMark.InputFile.Object");
				digiWaterMark.InputFile2 = inputFile2;
				editingConfig.DigiWaterMark = digiWaterMark;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_OutputFile outputFile = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_OutputFile();
				outputFile.Bucket = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.OutputFile.Bucket");
				outputFile.Location = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.OutputFile.Location");
				outputFile._Object = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.OutputFile.Object");
				outputFile.RoleArn = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.OutputFile.RoleArn");
				editingConfig.OutputFile = outputFile;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_M3U8NonStandardSupport m3U8NonStandardSupport = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_M3U8NonStandardSupport();

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_M3U8NonStandardSupport.QueryEditingJobList_TS tS = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_M3U8NonStandardSupport.QueryEditingJobList_TS();
				tS.Md5Support = context.BooleanValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.M3U8NonStandardSupport.TS.Md5Support");
				tS.SizeSupport = context.BooleanValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.M3U8NonStandardSupport.TS.SizeSupport");
				m3U8NonStandardSupport.TS = tS;
				editingConfig.M3U8NonStandardSupport = m3U8NonStandardSupport;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties properties = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties();
				properties.Width = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Width");
				properties.Height = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Height");
				properties.Bitrate = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Bitrate");
				properties.Duration = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Duration");
				properties.Fps = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Fps");
				properties.FileSize = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.FileSize");
				properties.FileFormat = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.FileFormat");

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Streams streams = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Streams();

				List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Streams.QueryEditingJobList_VideoStream> streams_videoStreamList = new List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Streams.QueryEditingJobList_VideoStream>();
				for (int j = 0; j < context.Length("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList.Length"); j++) {
					QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Streams.QueryEditingJobList_VideoStream videoStream = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Streams.QueryEditingJobList_VideoStream();
					videoStream.Index = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.CodecName = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.CodecLongName = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Profile = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.CodecTimeBase = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.CodecTagString = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.CodecTag = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.Width = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Height = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.HasBFrames = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Sar = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Dar = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.PixFmt = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Level = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Level");
					videoStream.Fps = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.AvgFPS = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.Timebase = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.StartTime = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Duration = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Bitrate = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.NumFrames = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Lang = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Lang");

					QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Streams.QueryEditingJobList_VideoStream.QueryEditingJobList_NetworkCost networkCost = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Streams.QueryEditingJobList_VideoStream.QueryEditingJobList_NetworkCost();
					networkCost.PreloadTime = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;

				List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Streams.QueryEditingJobList_AudioStream> streams_audioStreamList = new List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Streams.QueryEditingJobList_AudioStream>();
				for (int j = 0; j < context.Length("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList.Length"); j++) {
					QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Streams.QueryEditingJobList_AudioStream audioStream = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Streams.QueryEditingJobList_AudioStream();
					audioStream.Index = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.CodecName = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.CodecTimeBase = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.CodecLongName = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.CodecTagString = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.CodecTag = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.SampleFmt = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.Samplerate = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.Channels = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.ChannelLayout = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Timebase = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.StartTime = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.Duration = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.Bitrate = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.NumFrames = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Lang = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.AudioStreamList["+ j +"].Lang");

					streams_audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = streams_audioStreamList;

				List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Streams.QueryEditingJobList_SubtitleStream> streams_subtitleStreamList = new List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Streams.QueryEditingJobList_SubtitleStream>();
				for (int j = 0; j < context.Length("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.SubtitleStreamList.Length"); j++) {
					QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Streams.QueryEditingJobList_SubtitleStream subtitleStream = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Streams.QueryEditingJobList_SubtitleStream();
					subtitleStream.Index = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					streams_subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = streams_subtitleStreamList;
				properties.Streams = streams;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Format format = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Properties.QueryEditingJobList_Format();
				format.NumStreams = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Format.NumStreams");
				format.NumPrograms = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Format.NumPrograms");
				format.FormatName = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Format.FormatName");
				format.FormatLongName = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Format.FormatLongName");
				format.StartTime = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Format.StartTime");
				format.Duration = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Format.Duration");
				format.Size = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Format.Size");
				format.Bitrate = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Properties.Format.Bitrate");
				properties.Format = format;
				editingConfig.Properties = properties;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Clip clip = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Clip();

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Clip.QueryEditingJobList_TimeSpan timeSpan = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Clip.QueryEditingJobList_TimeSpan();
				timeSpan.Seek = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Clip.TimeSpan.Seek");
				timeSpan.Duration = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Clip.TimeSpan.Duration");
				clip.TimeSpan = timeSpan;
				editingConfig.Clip = clip;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_SuperReso superReso = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_SuperReso();
				superReso.IsHalfSample = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.SuperReso.IsHalfSample");
				editingConfig.SuperReso = superReso;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_SubtitleConfig subtitleConfig = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_SubtitleConfig();

				List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_SubtitleConfig.QueryEditingJobList_Subtitle> subtitleConfig_subtitleList = new List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_SubtitleConfig.QueryEditingJobList_Subtitle>();
				for (int j = 0; j < context.Length("QueryEditingJobList.JobList["+ i +"].EditingConfig.SubtitleConfig.SubtitleList.Length"); j++) {
					QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_SubtitleConfig.QueryEditingJobList_Subtitle subtitle = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_SubtitleConfig.QueryEditingJobList_Subtitle();
					subtitle.Map = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.SubtitleConfig.SubtitleList["+ j +"].Map");

					subtitleConfig_subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleConfig_subtitleList;

				List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_SubtitleConfig.QueryEditingJobList_ExtSubtitle> subtitleConfig_extSubtitleList = new List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_SubtitleConfig.QueryEditingJobList_ExtSubtitle>();
				for (int j = 0; j < context.Length("QueryEditingJobList.JobList["+ i +"].EditingConfig.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_SubtitleConfig.QueryEditingJobList_ExtSubtitle extSubtitle = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_SubtitleConfig.QueryEditingJobList_ExtSubtitle();
					extSubtitle.FontName = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.SubtitleConfig.ExtSubtitleList["+ j +"].FontName");
					extSubtitle.CharEnc = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.SubtitleConfig.ExtSubtitleList["+ j +"].CharEnc");

					QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_SubtitleConfig.QueryEditingJobList_ExtSubtitle.QueryEditingJobList_Input input = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_SubtitleConfig.QueryEditingJobList_ExtSubtitle.QueryEditingJobList_Input();
					input.Bucket = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Bucket");
					input.Location = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Location");
					input._Object = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Object");
					extSubtitle.Input = input;

					subtitleConfig_extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = subtitleConfig_extSubtitleList;
				editingConfig.SubtitleConfig = subtitleConfig;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_TransConfig transConfig = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_TransConfig();
				transConfig.TransMode = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.TransConfig.TransMode");
				transConfig.IsCheckReso = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.TransConfig.IsCheckReso");
				transConfig.IsCheckResoFail = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.TransConfig.IsCheckResoFail");
				transConfig.IsCheckVideoBitrate = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckAudioBitrate = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.TransConfig.IsCheckAudioBitrate");
				transConfig.AdjDarMethod = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.TransConfig.AdjDarMethod");
				transConfig.IsCheckVideoBitrateFail = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.TransConfig.IsCheckVideoBitrateFail");
				transConfig.IsCheckAudioBitrateFail = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.TransConfig.IsCheckAudioBitrateFail");
				transConfig.Duration = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.TransConfig.Duration");
				editingConfig.TransConfig = transConfig;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_MuxConfig muxConfig = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_MuxConfig();

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_MuxConfig.QueryEditingJobList_Segment segment = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_MuxConfig.QueryEditingJobList_Segment();
				segment.Duration = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_MuxConfig.QueryEditingJobList_Gif gif = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_MuxConfig.QueryEditingJobList_Gif();
				gif.Loop = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.MuxConfig.Gif.FinalDelay");
				gif.IsCustomPalette = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.MuxConfig.Gif.IsCustomPalette");
				gif.DitherMode = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.MuxConfig.Gif.DitherMode");
				muxConfig.Gif = gif;
				editingConfig.MuxConfig = muxConfig;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Audio audio = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Audio();
				audio.Codec = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Audio.Codec");
				audio.Profile = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Audio.Profile");
				audio.Samplerate = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Audio.Samplerate");
				audio.Bitrate = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Audio.Bitrate");
				audio.Channels = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Audio.Channels");
				audio.Qscale = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Audio.Qscale");

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Audio.QueryEditingJobList_Volume volume = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Audio.QueryEditingJobList_Volume();
				volume.Level = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Audio.Volume.Level");
				volume.Method = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Audio.Volume.Method");
				audio.Volume = volume;
				editingConfig.Audio = audio;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Video video = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Video();
				video.Codec = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.Codec");
				video.Profile = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.Profile");
				video.Bitrate = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.Bitrate");
				video.Crf = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.Crf");
				video.Width = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.Width");
				video.Height = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.Height");
				video.Fps = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.Fps");
				video.Gop = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.Gop");
				video.Preset = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.Preset");
				video.ScanMode = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.ScanMode");
				video.Bufsize = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.Bufsize");
				video.Maxrate = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.Maxrate");
				video.PixFmt = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.PixFmt");
				video.Degrain = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.Degrain");
				video.Qscale = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.Qscale");
				video.Crop = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.Crop");
				video.Pad = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.Pad");
				video.MaxFps = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.MaxFps");

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Video.QueryEditingJobList_BitrateBnd bitrateBnd = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Video.QueryEditingJobList_BitrateBnd();
				bitrateBnd.Max = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				editingConfig.Video = video;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Container container = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Container();
				container.Format = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Container.Format");
				editingConfig.Container = container;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Encryption encryption = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Encryption();
				encryption.Type = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Encryption.Type");
				encryption.Id = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Encryption.Id");
				encryption.Key = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Encryption.Key");
				encryption.KeyUri = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Encryption.KeyUri");
				encryption.KeyType = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Encryption.KeyType");
				encryption.SkipCnt = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Encryption.SkipCnt");
				editingConfig.Encryption = encryption;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing editing = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing();

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline timeline = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline();

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_TimelineConfig timelineConfig = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_TimelineConfig();

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_TimelineConfig.QueryEditingJobList_TimelineConfigVideo timelineConfigVideo = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_TimelineConfig.QueryEditingJobList_TimelineConfigVideo();
				timelineConfigVideo.Width = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigVideo.Width");
				timelineConfigVideo.Height = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigVideo.Height");
				timelineConfigVideo.BgColor = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigVideo.BgColor");
				timelineConfigVideo.Fps = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigVideo.Fps");
				timelineConfigVideo.RenderRatio = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigVideo.RenderRatio");
				timelineConfigVideo.ReclosePrec = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigVideo.ReclosePrec");
				timelineConfigVideo.IsGpuData = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigVideo.IsGpuData");
				timelineConfigVideo.IsOneTrackData = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigVideo.IsOneTrackData");
				timelineConfig.TimelineConfigVideo = timelineConfigVideo;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_TimelineConfig.QueryEditingJobList_TimelineConfigAudio timelineConfigAudio = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_TimelineConfig.QueryEditingJobList_TimelineConfigAudio();
				timelineConfigAudio.Samplerate = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigAudio.Samplerate");
				timelineConfigAudio.ChannelLayout = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigAudio.ChannelLayout");
				timelineConfigAudio.Channels = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigAudio.Channels");
				timelineConfig.TimelineConfigAudio = timelineConfigAudio;
				timeline.TimelineConfig = timelineConfig;

				List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_Track> timeline_trackList = new List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_Track>();
				for (int j = 0; j < context.Length("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TrackList.Length"); j++) {
					QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_Track track = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_Track();
					track.Id = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TrackList["+ j +"].Id");
					track.Type = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TrackList["+ j +"].Type");
					track.Order = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TrackList["+ j +"].Order");

					List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_Track.QueryEditingJobList_Clip4> track_clips = new List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_Track.QueryEditingJobList_Clip4>();
					for (int k = 0; k < context.Length("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TrackList["+ j +"].Clips.Length"); k++) {
						QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_Track.QueryEditingJobList_Clip4 clip4 = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_Track.QueryEditingJobList_Clip4();
						clip4.ClipID = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TrackList["+ j +"].Clips["+ k +"].clipID");
						clip4._In = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TrackList["+ j +"].Clips["+ k +"].In");
						clip4._Out = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TrackList["+ j +"].Clips["+ k +"].Out");

						QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_Track.QueryEditingJobList_Clip4.QueryEditingJobList_ClipsConfig clipsConfig = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_Track.QueryEditingJobList_Clip4.QueryEditingJobList_ClipsConfig();

						QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_Track.QueryEditingJobList_Clip4.QueryEditingJobList_ClipsConfig.QueryEditingJobList_ClipsConfigVideo clipsConfigVideo = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Timeline.QueryEditingJobList_Track.QueryEditingJobList_Clip4.QueryEditingJobList_ClipsConfig.QueryEditingJobList_ClipsConfigVideo();
						clipsConfigVideo.L = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TrackList["+ j +"].Clips["+ k +"].ClipsConfig.ClipsConfigVideo.L");
						clipsConfigVideo.T = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.Timeline.TrackList["+ j +"].Clips["+ k +"].ClipsConfig.ClipsConfigVideo.T");
						clipsConfig.ClipsConfigVideo = clipsConfigVideo;
						clip4.ClipsConfig = clipsConfig;

						track_clips.Add(clip4);
					}
					track.Clips = track_clips;

					timeline_trackList.Add(track);
				}
				timeline.TrackList = timeline_trackList;
				editing.Timeline = timeline;

				List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Clip3> editing_clipList = new List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Clip3>();
				for (int j = 0; j < context.Length("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.ClipList.Length"); j++) {
					QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Clip3 clip3 = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Clip3();
					clip3.Id = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.ClipList["+ j +"].Id");
					clip3.Type = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.ClipList["+ j +"].Type");
					clip3.SourceType = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.ClipList["+ j +"].SourceType");
					clip3.SourceID = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.ClipList["+ j +"].SourceID");
					clip3.SourceStrmMap = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.ClipList["+ j +"].SourceStrmMap");
					clip3._In = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.ClipList["+ j +"].In");
					clip3._Out = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.ClipList["+ j +"].Out");

					List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Clip3.QueryEditingJobList_Effect> clip3_effects = new List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Clip3.QueryEditingJobList_Effect>();
					for (int k = 0; k < context.Length("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.ClipList["+ j +"].Effects.Length"); k++) {
						QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Clip3.QueryEditingJobList_Effect effect = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Editing.QueryEditingJobList_Clip3.QueryEditingJobList_Effect();
						effect.Effect = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.ClipList["+ j +"].Effects["+ k +"].Effect");
						effect.EffectConfig = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.Editing.ClipList["+ j +"].Effects["+ k +"].EffectConfig");

						clip3_effects.Add(effect);
					}
					clip3.Effects = clip3_effects;

					editing_clipList.Add(clip3);
				}
				editing.ClipList = editing_clipList;
				editingConfig.Editing = editing;

				List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_WaterMark> editingConfig_waterMarkList = new List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_WaterMark>();
				for (int j = 0; j < context.Length("QueryEditingJobList.JobList["+ i +"].EditingConfig.WaterMarkList.Length"); j++) {
					QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_WaterMark waterMark = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_WaterMark();
					waterMark.WaterMarkTemplateId = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.WaterMarkList["+ j +"].WaterMarkTemplateId");
					waterMark.Width = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.WaterMarkList["+ j +"].Width");
					waterMark.Height = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.WaterMarkList["+ j +"].Height");
					waterMark.Dx = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.WaterMarkList["+ j +"].Dx");
					waterMark.Dy = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.WaterMarkList["+ j +"].Dy");
					waterMark.ReferPos = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.WaterMarkList["+ j +"].ReferPos");
					waterMark.Type = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.WaterMarkList["+ j +"].Type");

					QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_WaterMark.QueryEditingJobList_InputFile1 inputFile1 = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_WaterMark.QueryEditingJobList_InputFile1();
					inputFile1.Bucket = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.WaterMarkList["+ j +"].InputFile.Bucket");
					inputFile1.Location = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.WaterMarkList["+ j +"].InputFile.Location");
					inputFile1._Object = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.WaterMarkList["+ j +"].InputFile.Object");
					waterMark.InputFile1 = inputFile1;

					editingConfig_waterMarkList.Add(waterMark);
				}
				editingConfig.WaterMarkList = editingConfig_waterMarkList;

				List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Merge> editingConfig_mergeList = new List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Merge>();
				for (int j = 0; j < context.Length("QueryEditingJobList.JobList["+ i +"].EditingConfig.MergeList.Length"); j++) {
					QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Merge merge = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingConfig.QueryEditingJobList_Merge();
					merge.MergeURL = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.MergeList["+ j +"].MergeURL");
					merge.Start = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.MergeList["+ j +"].Start");
					merge.Duration = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.MergeList["+ j +"].Duration");
					merge.RoleArn = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingConfig.MergeList["+ j +"].RoleArn");

					editingConfig_mergeList.Add(merge);
				}
				editingConfig.MergeList = editingConfig_mergeList;
				job.EditingConfig = editingConfig;

				QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_MNSMessageResult mNSMessageResult = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_MNSMessageResult();
				mNSMessageResult.MessageId = context.StringValue("QueryEditingJobList.JobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = context.StringValue("QueryEditingJobList.JobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = context.StringValue("QueryEditingJobList.JobList["+ i +"].MNSMessageResult.ErrorCode");
				job.MNSMessageResult = mNSMessageResult;

				List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingInput> job_editingInputs = new List<QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingInput>();
				for (int j = 0; j < context.Length("QueryEditingJobList.JobList["+ i +"].EditingInputs.Length"); j++) {
					QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingInput editingInput = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingInput();
					editingInput.Id = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingInputs["+ j +"].Id");

					QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingInput.QueryEditingJobList_InputFile inputFile = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingInput.QueryEditingJobList_InputFile();
					inputFile.Bucket = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingInputs["+ j +"].InputFile.Bucket");
					inputFile.Location = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingInputs["+ j +"].InputFile.Location");
					inputFile._Object = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingInputs["+ j +"].InputFile.Object");
					editingInput.InputFile = inputFile;

					QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingInput.QueryEditingJobList_InputConfig inputConfig = new QueryEditingJobListResponse.QueryEditingJobList_Job.QueryEditingJobList_EditingInput.QueryEditingJobList_InputConfig();
					inputConfig.DeinterlaceMethod = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingInputs["+ j +"].InputConfig.DeinterlaceMethod");
					inputConfig.IsNormalSar = context.StringValue("QueryEditingJobList.JobList["+ i +"].EditingInputs["+ j +"].InputConfig.IsNormalSar");
					editingInput.InputConfig = inputConfig;

					job_editingInputs.Add(editingInput);
				}
				job.EditingInputs = job_editingInputs;

				queryEditingJobListResponse_jobList.Add(job);
			}
			queryEditingJobListResponse.JobList = queryEditingJobListResponse_jobList;
        
			return queryEditingJobListResponse;
        }
    }
}
