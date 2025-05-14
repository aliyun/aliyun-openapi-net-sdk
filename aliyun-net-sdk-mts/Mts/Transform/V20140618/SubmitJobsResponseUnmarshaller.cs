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
				jobResult.Code = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Code");
				jobResult.Message = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Message");
				jobResult.Success = _ctx.BooleanValue("SubmitJobs.JobResultList["+ i +"].Success");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job job = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job();
				job.Code = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Code");
				job.CreationTime = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.CreationTime");
				job.FinishTime = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.FinishTime");
				job.JobId = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.JobId");
				job.Message = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Message");
				job.Percent = _ctx.LongValue("SubmitJobs.JobResultList["+ i +"].Job.Percent");
				job.PipelineId = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.PipelineId");
				job.State = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.State");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Input input = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Input();
				input.Bucket = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Input.Bucket");
				input.Location = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Input.Location");
				input._Object = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Input.Object");
				job.Input = input;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_MNSMessageResult mNSMessageResult = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_MNSMessageResult();
				mNSMessageResult.ErrorCode = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.MNSMessageResult.ErrorCode");
				mNSMessageResult.ErrorMessage = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.MNSMessageResult.ErrorMessage");
				mNSMessageResult.MessageId = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.MNSMessageResult.MessageId");
				job.MNSMessageResult = mNSMessageResult;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output output = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output();
				output.AudioStreamMap = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.AudioStreamMap");
				output.DeWatermark = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DeWatermark");
				output.MergeConfigUrl = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeConfigUrl");
				output.Priority = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Priority");
				output.Rotate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Rotate");
				output.TemplateId = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TemplateId");
				output.UserData = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.UserData");
				output.VideoStreamMap = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.VideoStreamMap");
				output.WaterMarkConfigUrl = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkConfigUrl");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Audio audio = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Audio();
				audio.Bitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Bitrate");
				audio.Channels = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Channels");
				audio.Codec = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Codec");
				audio.Profile = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Profile");
				audio.Qscale = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Qscale");
				audio.Samplerate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Samplerate");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Audio.SubmitJobs_Volume volume = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Audio.SubmitJobs_Volume();
				volume.Level = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Volume.Level");
				volume.Method = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Audio.Volume.Method");
				audio.Volume = volume;
				output.Audio = audio;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Clip clip = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Clip();

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Clip.SubmitJobs_TimeSpan timeSpan = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Clip.SubmitJobs_TimeSpan();
				timeSpan.Duration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Clip.TimeSpan.Duration");
				timeSpan.Seek = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Clip.TimeSpan.Seek");
				clip.TimeSpan = timeSpan;
				output.Clip = clip;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Container container = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Container();
				container.Format = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Container.Format");
				output.Container = container;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_DigiWaterMark digiWaterMark = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_DigiWaterMark();
				digiWaterMark.Alpha = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DigiWaterMark.Alpha");
				digiWaterMark.Type = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DigiWaterMark.Type");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_DigiWaterMark.SubmitJobs_InputFile1 inputFile1 = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_DigiWaterMark.SubmitJobs_InputFile1();
				inputFile1.Bucket = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DigiWaterMark.InputFile.Bucket");
				inputFile1.Location = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DigiWaterMark.InputFile.Location");
				inputFile1._Object = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.DigiWaterMark.InputFile.Object");
				digiWaterMark.InputFile1 = inputFile1;
				output.DigiWaterMark = digiWaterMark;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Encryption encryption = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Encryption();
				encryption.Id = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.Id");
				encryption.Key = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.Key");
				encryption.KeyType = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.KeyType");
				encryption.KeyUri = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.KeyUri");
				encryption.SkipCnt = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.SkipCnt");
				encryption.Type = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Encryption.Type");
				output.Encryption = encryption;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_M3U8NonStandardSupport m3U8NonStandardSupport = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_M3U8NonStandardSupport();

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_M3U8NonStandardSupport.SubmitJobs_TS tS = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_M3U8NonStandardSupport.SubmitJobs_TS();
				tS.Md5Support = _ctx.BooleanValue("SubmitJobs.JobResultList["+ i +"].Job.Output.M3U8NonStandardSupport.TS.Md5Support");
				tS.SizeSupport = _ctx.BooleanValue("SubmitJobs.JobResultList["+ i +"].Job.Output.M3U8NonStandardSupport.TS.SizeSupport");
				m3U8NonStandardSupport.TS = tS;
				output.M3U8NonStandardSupport = m3U8NonStandardSupport;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig muxConfig = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig();

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig.SubmitJobs_Gif gif = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig.SubmitJobs_Gif();
				gif.DitherMode = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Gif.DitherMode");
				gif.FinalDelay = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Gif.FinalDelay");
				gif.IsCustomPalette = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Gif.IsCustomPalette");
				gif.Loop = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Gif.Loop");
				muxConfig.Gif = gif;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig.SubmitJobs_Segment segment = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig.SubmitJobs_Segment();
				segment.Duration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig.SubmitJobs_Webp webp = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_MuxConfig.SubmitJobs_Webp();
				webp.Loop = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MuxConfig.Webp.Loop");
				muxConfig.Webp = webp;
				output.MuxConfig = muxConfig;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutputFile outputFile = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutputFile();
				outputFile.Bucket = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutputFile.Bucket");
				outputFile.Location = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutputFile.Location");
				outputFile._Object = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutputFile.Object");
				outputFile.RoleArn = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutputFile.RoleArn");
				output.OutputFile = outputFile;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties properties = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties();
				properties.Bitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Bitrate");
				properties.Duration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Duration");
				properties.FileFormat = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.FileFormat");
				properties.FileSize = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.FileSize");
				properties.Fps = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Fps");
				properties.Height = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Height");
				properties.Width = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Width");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Format format = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Format();
				format.Bitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.Bitrate");
				format.Duration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.Duration");
				format.FormatLongName = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.FormatLongName");
				format.FormatName = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.FormatName");
				format.NumPrograms = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.NumPrograms");
				format.NumStreams = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.NumStreams");
				format.Size = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.Size");
				format.StartTime = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Format.StartTime");
				properties.Format = format;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams streams = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams();

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_AudioStream> streams_audioStreamList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_AudioStream>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_AudioStream audioStream = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_AudioStream();
					audioStream.Bitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.ChannelLayout = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Channels = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.CodecLongName = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.CodecName = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.CodecTag = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.CodecTagString = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.CodecTimeBase = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.Duration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.Index = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.Lang = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Lang");
					audioStream.NumFrames = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.SampleFmt = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.Samplerate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.StartTime = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.Timebase = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.AudioStreamList["+ j +"].Timebase");

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

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream> streams_videoStreamList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream videoStream = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream();
					videoStream.AvgFPS = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.Bitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.CodecLongName = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.CodecName = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.CodecTag = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.CodecTagString = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.CodecTimeBase = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.Dar = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.Duration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Fps = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.HasBFrames = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Height = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.Index = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.Lang = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Lang");
					videoStream.Level = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Level");
					videoStream.NumFrames = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.PixFmt = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Profile = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.Sar = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.StartTime = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Timebase = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.Width = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].Width");

					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream.SubmitJobs_NetworkCost networkCost = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Properties.SubmitJobs_Streams.SubmitJobs_VideoStream.SubmitJobs_NetworkCost();
					networkCost.AvgBitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					networkCost.CostBandwidth = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.PreloadTime = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;
				properties.Streams = streams;
				output.Properties = properties;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig subtitleConfig = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig();

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle> subtitleConfig_extSubtitleList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle extSubtitle = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle();
					extSubtitle.CharEnc = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].CharEnc");
					extSubtitle.FontName = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].FontName");

					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle.SubmitJobs_Input2 input2 = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SubtitleConfig.SubmitJobs_ExtSubtitle.SubmitJobs_Input2();
					input2.Bucket = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Bucket");
					input2.Location = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Location");
					input2._Object = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Object");
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

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SuperReso superReso = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_SuperReso();
				superReso.IsHalfSample = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.SuperReso.IsHalfSample");
				output.SuperReso = superReso;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TransConfig transConfig = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TransConfig();
				transConfig.AdjDarMethod = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.AdjDarMethod");
				transConfig.IsCheckAudioBitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckAudioBitrate");
				transConfig.IsCheckAudioBitrateFail = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckAudioBitrateFail");
				transConfig.IsCheckReso = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckReso");
				transConfig.IsCheckResoFail = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckResoFail");
				transConfig.IsCheckVideoBitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckVideoBitrateFail = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.IsCheckVideoBitrateFail");
				transConfig.TransMode = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TransConfig.TransMode");
				output.TransConfig = transConfig;

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Video video = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Video();
				video.Bitrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Bitrate");
				video.Bufsize = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Bufsize");
				video.Codec = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Codec");
				video.Crf = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Crf");
				video.Crop = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Crop");
				video.Degrain = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Degrain");
				video.Fps = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Fps");
				video.Gop = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Gop");
				video.Height = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Height");
				video.MaxFps = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.MaxFps");
				video.Maxrate = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Maxrate");
				video.Pad = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Pad");
				video.PixFmt = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.PixFmt");
				video.Preset = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Preset");
				video.Profile = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Profile");
				video.Qscale = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Qscale");
				video.ResoPriority = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.ResoPriority");
				video.ScanMode = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.ScanMode");
				video.Width = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.Width");

				SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Video.SubmitJobs_BitrateBnd bitrateBnd = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Video.SubmitJobs_BitrateBnd();
				bitrateBnd.Max = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.BitrateBnd.Max");
				bitrateBnd.Min = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				output.Video = video;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Amix> output_amixList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Amix>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.AmixList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Amix amix = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Amix();
					amix.AmixURL = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.AmixList["+ j +"].AmixURL");
					amix.Duration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.AmixList["+ j +"].Duration");
					amix.Map = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.AmixList["+ j +"].Map");
					amix.MixDurMode = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.AmixList["+ j +"].MixDurMode");
					amix.Start = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.AmixList["+ j +"].Start");

					output_amixList.Add(amix);
				}
				output.AmixList = output_amixList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Merge> output_mergeList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Merge>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Merge merge = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Merge();
					merge.Duration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList["+ j +"].Duration");
					merge.MergeURL = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList["+ j +"].MergeURL");
					merge.RoleArn = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList["+ j +"].RoleArn");
					merge.Start = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.MergeList["+ j +"].Start");

					output_mergeList.Add(merge);
				}
				output.MergeList = output_mergeList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Opening> output_openingList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Opening>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.OpeningList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Opening opening = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_Opening();
					opening.Height = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OpeningList["+ j +"].Height");
					opening.Start = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OpeningList["+ j +"].Start");
					opening.Width = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OpeningList["+ j +"].Width");
					opening.OpenUrl = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OpeningList["+ j +"].openUrl");

					output_openingList.Add(opening);
				}
				output.OpeningList = output_openingList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutSubtitle> output_outSubtitleList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutSubtitle>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.OutSubtitleList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutSubtitle outSubtitle = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutSubtitle();
					outSubtitle.Map = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutSubtitleList["+ j +"].Map");
					outSubtitle.Message = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutSubtitleList["+ j +"].Message");
					outSubtitle.Success = _ctx.BooleanValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutSubtitleList["+ j +"].Success");

					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutSubtitle.SubmitJobs_OutSubtitleFile outSubtitleFile = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_OutSubtitle.SubmitJobs_OutSubtitleFile();
					outSubtitleFile.Bucket = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutSubtitleList["+ j +"].OutSubtitleFile.Bucket");
					outSubtitleFile.Location = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutSubtitleList["+ j +"].OutSubtitleFile.Location");
					outSubtitleFile._Object = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutSubtitleList["+ j +"].OutSubtitleFile.Object");
					outSubtitleFile.RoleArn = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.OutSubtitleList["+ j +"].OutSubtitleFile.RoleArn");
					outSubtitle.OutSubtitleFile = outSubtitleFile;

					output_outSubtitleList.Add(outSubtitle);
				}
				output.OutSubtitleList = output_outSubtitleList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TailSlate> output_tailSlateList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TailSlate>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TailSlate tailSlate = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_TailSlate();
					tailSlate.BgColor = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].BgColor");
					tailSlate.BlendDuration = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].BlendDuration");
					tailSlate.Height = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].Height");
					tailSlate.IsMergeAudio = _ctx.BooleanValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].IsMergeAudio");
					tailSlate.Start = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].Start");
					tailSlate.TailUrl = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].TailUrl");
					tailSlate.Width = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.TailSlateList["+ j +"].Width");

					output_tailSlateList.Add(tailSlate);
				}
				output.TailSlateList = output_tailSlateList;

				List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark> output_waterMarkList = new List<SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark>();
				for (int j = 0; j < _ctx.Length("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList.Length"); j++) {
					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark waterMark = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark();
					waterMark.Dx = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Dx");
					waterMark.Dy = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Dy");
					waterMark.Height = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Height");
					waterMark.ReferPos = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].ReferPos");
					waterMark.Type = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Type");
					waterMark.WaterMarkTemplateId = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].WaterMarkTemplateId");
					waterMark.Width = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].Width");

					SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark.SubmitJobs_InputFile inputFile = new SubmitJobsResponse.SubmitJobs_JobResult.SubmitJobs_Job.SubmitJobs_Output.SubmitJobs_WaterMark.SubmitJobs_InputFile();
					inputFile.Bucket = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].InputFile.Bucket");
					inputFile.Location = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].InputFile.Location");
					inputFile._Object = _ctx.StringValue("SubmitJobs.JobResultList["+ i +"].Job.Output.WaterMarkList["+ j +"].InputFile.Object");
					waterMark.InputFile = inputFile;

					output_waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = output_waterMarkList;
				job.Output = output;
				jobResult.Job = job;

				submitJobsResponse_jobResultList.Add(jobResult);
			}
			submitJobsResponse.JobResultList = submitJobsResponse_jobResultList;
        
			return submitJobsResponse;
        }
    }
}
