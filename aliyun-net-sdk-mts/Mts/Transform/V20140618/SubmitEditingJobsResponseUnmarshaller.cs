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
    public class SubmitEditingJobsResponseUnmarshaller
    {
        public static SubmitEditingJobsResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitEditingJobsResponse submitEditingJobsResponse = new SubmitEditingJobsResponse();

			submitEditingJobsResponse.HttpResponse = context.HttpResponse;
			submitEditingJobsResponse.RequestId = context.StringValue("SubmitEditingJobs.RequestId");

			List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult> submitEditingJobsResponse_jobResultList = new List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult>();
			for (int i = 0; i < context.Length("SubmitEditingJobs.JobResultList.Length"); i++) {
				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult jobResult = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult();
				jobResult.Success = context.BooleanValue("SubmitEditingJobs.JobResultList["+ i +"].Success");
				jobResult.Code = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Code");
				jobResult.Message = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Message");

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job job = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job();
				job.JobId = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.JobId");
				job.State = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.State");
				job.Code = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.Code");
				job.Message = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.Message");
				job.Percent = context.LongValue("SubmitEditingJobs.JobResultList["+ i +"].Job.Percent");
				job.PipelineId = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.PipelineId");
				job.CreationTime = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.CreationTime");
				job.FinishTime = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.FinishTime");

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig editingConfig = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig();
				editingConfig.TemplateId = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.TemplateId");
				editingConfig.UserData = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.UserData");
				editingConfig.Rotate = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Rotate");
				editingConfig.VideoStreamMap = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.VideoStreamMap");
				editingConfig.AudioStreamMap = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.AudioStreamMap");
				editingConfig.DeWatermark = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.DeWatermark");
				editingConfig.Priority = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Priority");
				editingConfig.WaterMarkConfigUrl = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.WaterMarkConfigUrl");
				editingConfig.MergeConfigUrl = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.MergeConfigUrl");

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_DigiWaterMark digiWaterMark = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_DigiWaterMark();
				digiWaterMark.Type = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.DigiWaterMark.Type");
				digiWaterMark.Alpha = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.DigiWaterMark.Alpha");

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_DigiWaterMark.SubmitEditingJobs_InputFile2 inputFile2 = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_DigiWaterMark.SubmitEditingJobs_InputFile2();
				inputFile2.Bucket = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.DigiWaterMark.InputFile.Bucket");
				inputFile2.Location = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.DigiWaterMark.InputFile.Location");
				inputFile2._Object = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.DigiWaterMark.InputFile.Object");
				digiWaterMark.InputFile2 = inputFile2;
				editingConfig.DigiWaterMark = digiWaterMark;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_OutputFile outputFile = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_OutputFile();
				outputFile.Bucket = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.OutputFile.Bucket");
				outputFile.Location = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.OutputFile.Location");
				outputFile._Object = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.OutputFile.Object");
				outputFile.RoleArn = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.OutputFile.RoleArn");
				editingConfig.OutputFile = outputFile;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_M3U8NonStandardSupport m3U8NonStandardSupport = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_M3U8NonStandardSupport();

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_M3U8NonStandardSupport.SubmitEditingJobs_TS tS = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_M3U8NonStandardSupport.SubmitEditingJobs_TS();
				tS.Md5Support = context.BooleanValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.M3U8NonStandardSupport.TS.Md5Support");
				tS.SizeSupport = context.BooleanValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.M3U8NonStandardSupport.TS.SizeSupport");
				m3U8NonStandardSupport.TS = tS;
				editingConfig.M3U8NonStandardSupport = m3U8NonStandardSupport;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties properties = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties();
				properties.Width = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Width");
				properties.Height = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Height");
				properties.Bitrate = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Bitrate");
				properties.Duration = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Duration");
				properties.Fps = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Fps");
				properties.FileSize = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.FileSize");
				properties.FileFormat = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.FileFormat");

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Streams streams = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Streams();

				List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Streams.SubmitEditingJobs_VideoStream> streams_videoStreamList = new List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Streams.SubmitEditingJobs_VideoStream>();
				for (int j = 0; j < context.Length("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList.Length"); j++) {
					SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Streams.SubmitEditingJobs_VideoStream videoStream = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Streams.SubmitEditingJobs_VideoStream();
					videoStream.Index = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.CodecName = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.CodecLongName = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Profile = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.CodecTimeBase = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.CodecTagString = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.CodecTag = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.Width = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Height = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.HasBFrames = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Sar = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Dar = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.PixFmt = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Level = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Level");
					videoStream.Fps = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.AvgFPS = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.Timebase = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.StartTime = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Duration = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Bitrate = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.NumFrames = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Lang = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].Lang");

					SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Streams.SubmitEditingJobs_VideoStream.SubmitEditingJobs_NetworkCost networkCost = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Streams.SubmitEditingJobs_VideoStream.SubmitEditingJobs_NetworkCost();
					networkCost.PreloadTime = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;

				List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Streams.SubmitEditingJobs_AudioStream> streams_audioStreamList = new List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Streams.SubmitEditingJobs_AudioStream>();
				for (int j = 0; j < context.Length("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList.Length"); j++) {
					SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Streams.SubmitEditingJobs_AudioStream audioStream = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Streams.SubmitEditingJobs_AudioStream();
					audioStream.Index = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.CodecName = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.CodecTimeBase = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.CodecLongName = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.CodecTagString = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.CodecTag = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.SampleFmt = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.Samplerate = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.Channels = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.ChannelLayout = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Timebase = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.StartTime = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.Duration = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.Bitrate = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.NumFrames = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Lang = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.AudioStreamList["+ j +"].Lang");

					streams_audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = streams_audioStreamList;

				List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Streams.SubmitEditingJobs_SubtitleStream> streams_subtitleStreamList = new List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Streams.SubmitEditingJobs_SubtitleStream>();
				for (int j = 0; j < context.Length("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.SubtitleStreamList.Length"); j++) {
					SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Streams.SubmitEditingJobs_SubtitleStream subtitleStream = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Streams.SubmitEditingJobs_SubtitleStream();
					subtitleStream.Index = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					streams_subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = streams_subtitleStreamList;
				properties.Streams = streams;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Format format = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Properties.SubmitEditingJobs_Format();
				format.NumStreams = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Format.NumStreams");
				format.NumPrograms = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Format.NumPrograms");
				format.FormatName = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Format.FormatName");
				format.FormatLongName = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Format.FormatLongName");
				format.StartTime = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Format.StartTime");
				format.Duration = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Format.Duration");
				format.Size = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Format.Size");
				format.Bitrate = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Properties.Format.Bitrate");
				properties.Format = format;
				editingConfig.Properties = properties;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Clip clip = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Clip();

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Clip.SubmitEditingJobs_TimeSpan timeSpan = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Clip.SubmitEditingJobs_TimeSpan();
				timeSpan.Seek = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Clip.TimeSpan.Seek");
				timeSpan.Duration = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Clip.TimeSpan.Duration");
				clip.TimeSpan = timeSpan;
				editingConfig.Clip = clip;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_SuperReso superReso = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_SuperReso();
				superReso.IsHalfSample = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.SuperReso.IsHalfSample");
				editingConfig.SuperReso = superReso;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_SubtitleConfig subtitleConfig = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_SubtitleConfig();

				List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_SubtitleConfig.SubmitEditingJobs_Subtitle> subtitleConfig_subtitleList = new List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_SubtitleConfig.SubmitEditingJobs_Subtitle>();
				for (int j = 0; j < context.Length("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.SubtitleConfig.SubtitleList.Length"); j++) {
					SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_SubtitleConfig.SubmitEditingJobs_Subtitle subtitle = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_SubtitleConfig.SubmitEditingJobs_Subtitle();
					subtitle.Map = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.SubtitleConfig.SubtitleList["+ j +"].Map");

					subtitleConfig_subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleConfig_subtitleList;

				List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_SubtitleConfig.SubmitEditingJobs_ExtSubtitle> subtitleConfig_extSubtitleList = new List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_SubtitleConfig.SubmitEditingJobs_ExtSubtitle>();
				for (int j = 0; j < context.Length("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_SubtitleConfig.SubmitEditingJobs_ExtSubtitle extSubtitle = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_SubtitleConfig.SubmitEditingJobs_ExtSubtitle();
					extSubtitle.FontName = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.SubtitleConfig.ExtSubtitleList["+ j +"].FontName");
					extSubtitle.CharEnc = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.SubtitleConfig.ExtSubtitleList["+ j +"].CharEnc");

					SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_SubtitleConfig.SubmitEditingJobs_ExtSubtitle.SubmitEditingJobs_Input input = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_SubtitleConfig.SubmitEditingJobs_ExtSubtitle.SubmitEditingJobs_Input();
					input.Bucket = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Bucket");
					input.Location = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Location");
					input._Object = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Object");
					extSubtitle.Input = input;

					subtitleConfig_extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = subtitleConfig_extSubtitleList;
				editingConfig.SubtitleConfig = subtitleConfig;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_TransConfig transConfig = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_TransConfig();
				transConfig.TransMode = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.TransConfig.TransMode");
				transConfig.IsCheckReso = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.TransConfig.IsCheckReso");
				transConfig.IsCheckResoFail = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.TransConfig.IsCheckResoFail");
				transConfig.IsCheckVideoBitrate = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckAudioBitrate = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.TransConfig.IsCheckAudioBitrate");
				transConfig.AdjDarMethod = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.TransConfig.AdjDarMethod");
				transConfig.IsCheckVideoBitrateFail = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.TransConfig.IsCheckVideoBitrateFail");
				transConfig.IsCheckAudioBitrateFail = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.TransConfig.IsCheckAudioBitrateFail");
				transConfig.Duration = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.TransConfig.Duration");
				editingConfig.TransConfig = transConfig;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_MuxConfig muxConfig = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_MuxConfig();

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_MuxConfig.SubmitEditingJobs_Segment segment = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_MuxConfig.SubmitEditingJobs_Segment();
				segment.Duration = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_MuxConfig.SubmitEditingJobs_Gif gif = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_MuxConfig.SubmitEditingJobs_Gif();
				gif.Loop = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.MuxConfig.Gif.FinalDelay");
				gif.IsCustomPalette = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.MuxConfig.Gif.IsCustomPalette");
				gif.DitherMode = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.MuxConfig.Gif.DitherMode");
				muxConfig.Gif = gif;
				editingConfig.MuxConfig = muxConfig;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Audio audio = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Audio();
				audio.Codec = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Audio.Codec");
				audio.Profile = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Audio.Profile");
				audio.Samplerate = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Audio.Samplerate");
				audio.Bitrate = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Audio.Bitrate");
				audio.Channels = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Audio.Channels");
				audio.Qscale = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Audio.Qscale");

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Audio.SubmitEditingJobs_Volume volume = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Audio.SubmitEditingJobs_Volume();
				volume.Level = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Audio.Volume.Level");
				volume.Method = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Audio.Volume.Method");
				audio.Volume = volume;
				editingConfig.Audio = audio;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Video video = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Video();
				video.Codec = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.Codec");
				video.Profile = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.Profile");
				video.Bitrate = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.Bitrate");
				video.Crf = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.Crf");
				video.Width = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.Width");
				video.Height = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.Height");
				video.Fps = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.Fps");
				video.Gop = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.Gop");
				video.Preset = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.Preset");
				video.ScanMode = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.ScanMode");
				video.Bufsize = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.Bufsize");
				video.Maxrate = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.Maxrate");
				video.PixFmt = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.PixFmt");
				video.Degrain = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.Degrain");
				video.Qscale = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.Qscale");
				video.Crop = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.Crop");
				video.Pad = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.Pad");
				video.MaxFps = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.MaxFps");

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Video.SubmitEditingJobs_BitrateBnd bitrateBnd = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Video.SubmitEditingJobs_BitrateBnd();
				bitrateBnd.Max = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				editingConfig.Video = video;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Container container = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Container();
				container.Format = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Container.Format");
				editingConfig.Container = container;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Encryption encryption = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Encryption();
				encryption.Type = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Encryption.Type");
				encryption.Id = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Encryption.Id");
				encryption.Key = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Encryption.Key");
				encryption.KeyUri = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Encryption.KeyUri");
				encryption.KeyType = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Encryption.KeyType");
				encryption.SkipCnt = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Encryption.SkipCnt");
				editingConfig.Encryption = encryption;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing editing = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing();

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline timeline = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline();

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_TimelineConfig timelineConfig = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_TimelineConfig();

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_TimelineConfig.SubmitEditingJobs_TimelineConfigVideo timelineConfigVideo = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_TimelineConfig.SubmitEditingJobs_TimelineConfigVideo();
				timelineConfigVideo.Width = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigVideo.Width");
				timelineConfigVideo.Height = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigVideo.Height");
				timelineConfigVideo.BgColor = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigVideo.BgColor");
				timelineConfigVideo.Fps = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigVideo.Fps");
				timelineConfigVideo.RenderRatio = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigVideo.RenderRatio");
				timelineConfigVideo.ReclosePrec = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigVideo.ReclosePrec");
				timelineConfigVideo.IsGpuData = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigVideo.IsGpuData");
				timelineConfigVideo.IsOneTrackData = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigVideo.IsOneTrackData");
				timelineConfig.TimelineConfigVideo = timelineConfigVideo;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_TimelineConfig.SubmitEditingJobs_TimelineConfigAudio timelineConfigAudio = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_TimelineConfig.SubmitEditingJobs_TimelineConfigAudio();
				timelineConfigAudio.Samplerate = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigAudio.Samplerate");
				timelineConfigAudio.ChannelLayout = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigAudio.ChannelLayout");
				timelineConfigAudio.Channels = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TimelineConfig.TimelineConfigAudio.Channels");
				timelineConfig.TimelineConfigAudio = timelineConfigAudio;
				timeline.TimelineConfig = timelineConfig;

				List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_Track> timeline_trackList = new List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_Track>();
				for (int j = 0; j < context.Length("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TrackList.Length"); j++) {
					SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_Track track = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_Track();
					track.Id = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TrackList["+ j +"].Id");
					track.Type = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TrackList["+ j +"].Type");
					track.Order = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TrackList["+ j +"].Order");

					List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_Track.SubmitEditingJobs_Clip4> track_clips = new List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_Track.SubmitEditingJobs_Clip4>();
					for (int k = 0; k < context.Length("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TrackList["+ j +"].Clips.Length"); k++) {
						SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_Track.SubmitEditingJobs_Clip4 clip4 = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_Track.SubmitEditingJobs_Clip4();
						clip4.ClipID = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TrackList["+ j +"].Clips["+ k +"].clipID");
						clip4._In = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TrackList["+ j +"].Clips["+ k +"].In");
						clip4._Out = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TrackList["+ j +"].Clips["+ k +"].Out");

						SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_Track.SubmitEditingJobs_Clip4.SubmitEditingJobs_ClipsConfig clipsConfig = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_Track.SubmitEditingJobs_Clip4.SubmitEditingJobs_ClipsConfig();

						SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_Track.SubmitEditingJobs_Clip4.SubmitEditingJobs_ClipsConfig.SubmitEditingJobs_ClipsConfigVideo clipsConfigVideo = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Timeline.SubmitEditingJobs_Track.SubmitEditingJobs_Clip4.SubmitEditingJobs_ClipsConfig.SubmitEditingJobs_ClipsConfigVideo();
						clipsConfigVideo.L = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TrackList["+ j +"].Clips["+ k +"].ClipsConfig.ClipsConfigVideo.L");
						clipsConfigVideo.T = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.Timeline.TrackList["+ j +"].Clips["+ k +"].ClipsConfig.ClipsConfigVideo.T");
						clipsConfig.ClipsConfigVideo = clipsConfigVideo;
						clip4.ClipsConfig = clipsConfig;

						track_clips.Add(clip4);
					}
					track.Clips = track_clips;

					timeline_trackList.Add(track);
				}
				timeline.TrackList = timeline_trackList;
				editing.Timeline = timeline;

				List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Clip3> editing_clipList = new List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Clip3>();
				for (int j = 0; j < context.Length("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.ClipList.Length"); j++) {
					SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Clip3 clip3 = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Clip3();
					clip3.Id = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.ClipList["+ j +"].Id");
					clip3.Type = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.ClipList["+ j +"].Type");
					clip3.SourceType = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.ClipList["+ j +"].SourceType");
					clip3.SourceID = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.ClipList["+ j +"].SourceID");
					clip3.SourceStrmMap = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.ClipList["+ j +"].SourceStrmMap");
					clip3._In = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.ClipList["+ j +"].In");
					clip3._Out = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.ClipList["+ j +"].Out");

					List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Clip3.SubmitEditingJobs_Effect> clip3_effects = new List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Clip3.SubmitEditingJobs_Effect>();
					for (int k = 0; k < context.Length("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.ClipList["+ j +"].Effects.Length"); k++) {
						SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Clip3.SubmitEditingJobs_Effect effect = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Editing.SubmitEditingJobs_Clip3.SubmitEditingJobs_Effect();
						effect.Effect = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.ClipList["+ j +"].Effects["+ k +"].Effect");
						effect.EffectConfig = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.Editing.ClipList["+ j +"].Effects["+ k +"].EffectConfig");

						clip3_effects.Add(effect);
					}
					clip3.Effects = clip3_effects;

					editing_clipList.Add(clip3);
				}
				editing.ClipList = editing_clipList;
				editingConfig.Editing = editing;

				List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_WaterMark> editingConfig_waterMarkList = new List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_WaterMark>();
				for (int j = 0; j < context.Length("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.WaterMarkList.Length"); j++) {
					SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_WaterMark waterMark = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_WaterMark();
					waterMark.WaterMarkTemplateId = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.WaterMarkList["+ j +"].WaterMarkTemplateId");
					waterMark.Width = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.WaterMarkList["+ j +"].Width");
					waterMark.Height = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.WaterMarkList["+ j +"].Height");
					waterMark.Dx = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.WaterMarkList["+ j +"].Dx");
					waterMark.Dy = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.WaterMarkList["+ j +"].Dy");
					waterMark.ReferPos = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.WaterMarkList["+ j +"].ReferPos");
					waterMark.Type = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.WaterMarkList["+ j +"].Type");

					SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_WaterMark.SubmitEditingJobs_InputFile1 inputFile1 = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_WaterMark.SubmitEditingJobs_InputFile1();
					inputFile1.Bucket = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.WaterMarkList["+ j +"].InputFile.Bucket");
					inputFile1.Location = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.WaterMarkList["+ j +"].InputFile.Location");
					inputFile1._Object = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.WaterMarkList["+ j +"].InputFile.Object");
					waterMark.InputFile1 = inputFile1;

					editingConfig_waterMarkList.Add(waterMark);
				}
				editingConfig.WaterMarkList = editingConfig_waterMarkList;

				List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Merge> editingConfig_mergeList = new List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Merge>();
				for (int j = 0; j < context.Length("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.MergeList.Length"); j++) {
					SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Merge merge = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingConfig.SubmitEditingJobs_Merge();
					merge.MergeURL = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.MergeList["+ j +"].MergeURL");
					merge.Start = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.MergeList["+ j +"].Start");
					merge.Duration = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.MergeList["+ j +"].Duration");
					merge.RoleArn = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingConfig.MergeList["+ j +"].RoleArn");

					editingConfig_mergeList.Add(merge);
				}
				editingConfig.MergeList = editingConfig_mergeList;
				job.EditingConfig = editingConfig;

				SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_MNSMessageResult mNSMessageResult = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_MNSMessageResult();
				mNSMessageResult.MessageId = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.MNSMessageResult.ErrorCode");
				job.MNSMessageResult = mNSMessageResult;

				List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingInput> job_editingInputs = new List<SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingInput>();
				for (int j = 0; j < context.Length("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingInputs.Length"); j++) {
					SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingInput editingInput = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingInput();
					editingInput.Id = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingInputs["+ j +"].Id");

					SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingInput.SubmitEditingJobs_InputFile inputFile = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingInput.SubmitEditingJobs_InputFile();
					inputFile.Bucket = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingInputs["+ j +"].InputFile.Bucket");
					inputFile.Location = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingInputs["+ j +"].InputFile.Location");
					inputFile._Object = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingInputs["+ j +"].InputFile.Object");
					editingInput.InputFile = inputFile;

					SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingInput.SubmitEditingJobs_InputConfig inputConfig = new SubmitEditingJobsResponse.SubmitEditingJobs_JobResult.SubmitEditingJobs_Job.SubmitEditingJobs_EditingInput.SubmitEditingJobs_InputConfig();
					inputConfig.DeinterlaceMethod = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingInputs["+ j +"].InputConfig.DeinterlaceMethod");
					inputConfig.IsNormalSar = context.StringValue("SubmitEditingJobs.JobResultList["+ i +"].Job.EditingInputs["+ j +"].InputConfig.IsNormalSar");
					editingInput.InputConfig = inputConfig;

					job_editingInputs.Add(editingInput);
				}
				job.EditingInputs = job_editingInputs;
				jobResult.Job = job;

				submitEditingJobsResponse_jobResultList.Add(jobResult);
			}
			submitEditingJobsResponse.JobResultList = submitEditingJobsResponse_jobResultList;
        
			return submitEditingJobsResponse;
        }
    }
}
