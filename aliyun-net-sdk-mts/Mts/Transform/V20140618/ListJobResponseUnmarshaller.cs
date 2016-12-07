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

			List<ListJobResponse.Job> jobList = new List<ListJobResponse.Job>();
			for (int i = 0; i < context.Length("ListJob.JobList.Length"); i++) {
				ListJobResponse.Job job = new ListJobResponse.Job();
				job.JobId = context.StringValue("ListJob.JobList["+ i +"].JobId");
				job.State = context.StringValue("ListJob.JobList["+ i +"].State");
				job.Code = context.StringValue("ListJob.JobList["+ i +"].Code");
				job.Message = context.StringValue("ListJob.JobList["+ i +"].Message");
				job.Percent = context.LongValue("ListJob.JobList["+ i +"].Percent");
				job.PipelineId = context.StringValue("ListJob.JobList["+ i +"].PipelineId");
				job.CreationTime = context.StringValue("ListJob.JobList["+ i +"].CreationTime");

				ListJobResponse.Job.Input_ input = new ListJobResponse.Job.Input_();
				input.Bucket = context.StringValue("ListJob.JobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("ListJob.JobList["+ i +"].Input.Location");
				input.Object = context.StringValue("ListJob.JobList["+ i +"].Input.Object");
				job.Input = input;

				ListJobResponse.Job.Output_ output = new ListJobResponse.Job.Output_();
				output.TemplateId = context.StringValue("ListJob.JobList["+ i +"].Output.TemplateId");
				output.UserData = context.StringValue("ListJob.JobList["+ i +"].Output.UserData");
				output.Rotate = context.StringValue("ListJob.JobList["+ i +"].Output.Rotate");
				output.VideoStreamMap = context.StringValue("ListJob.JobList["+ i +"].Output.VideoStreamMap");
				output.AudioStreamMap = context.StringValue("ListJob.JobList["+ i +"].Output.AudioStreamMap");
				output.DeWatermark = context.StringValue("ListJob.JobList["+ i +"].Output.DeWatermark");
				output.Priority = context.StringValue("ListJob.JobList["+ i +"].Output.Priority");

				ListJobResponse.Job.Output_.OutputFile_ outputFile = new ListJobResponse.Job.Output_.OutputFile_();
				outputFile.Bucket = context.StringValue("ListJob.JobList["+ i +"].Output.OutputFile.Bucket");
				outputFile.Location = context.StringValue("ListJob.JobList["+ i +"].Output.OutputFile.Location");
				outputFile.Object = context.StringValue("ListJob.JobList["+ i +"].Output.OutputFile.Object");
				output.OutputFile = outputFile;

				ListJobResponse.Job.Output_.Properties_ properties = new ListJobResponse.Job.Output_.Properties_();
				properties.Width = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Width");
				properties.Height = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Height");
				properties.Bitrate = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Bitrate");
				properties.Duration = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Duration");
				properties.Fps = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Fps");
				properties.FileSize = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.FileSize");
				properties.FileFormat = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.FileFormat");

				ListJobResponse.Job.Output_.Properties_.Streams_ streams = new ListJobResponse.Job.Output_.Properties_.Streams_();

				List<ListJobResponse.Job.Output_.Properties_.Streams_.VideoStream> videoStreamList = new List<ListJobResponse.Job.Output_.Properties_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList.Length"); j++) {
					ListJobResponse.Job.Output_.Properties_.Streams_.VideoStream videoStream = new ListJobResponse.Job.Output_.Properties_.Streams_.VideoStream();
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

					ListJobResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new ListJobResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_();
					networkCost.PreloadTime = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<ListJobResponse.Job.Output_.Properties_.Streams_.AudioStream> audioStreamList = new List<ListJobResponse.Job.Output_.Properties_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length("ListJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList.Length"); j++) {
					ListJobResponse.Job.Output_.Properties_.Streams_.AudioStream audioStream = new ListJobResponse.Job.Output_.Properties_.Streams_.AudioStream();
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

					audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<ListJobResponse.Job.Output_.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<ListJobResponse.Job.Output_.Properties_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length("ListJob.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
					ListJobResponse.Job.Output_.Properties_.Streams_.SubtitleStream subtitleStream = new ListJobResponse.Job.Output_.Properties_.Streams_.SubtitleStream();
					subtitleStream.Index = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("ListJob.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				properties.Streams = streams;

				ListJobResponse.Job.Output_.Properties_.Format_ format = new ListJobResponse.Job.Output_.Properties_.Format_();
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

				ListJobResponse.Job.Output_.Clip_ clip = new ListJobResponse.Job.Output_.Clip_();

				ListJobResponse.Job.Output_.Clip_.TimeSpan_ timeSpan = new ListJobResponse.Job.Output_.Clip_.TimeSpan_();
				timeSpan.Seek = context.StringValue("ListJob.JobList["+ i +"].Output.Clip.TimeSpan.Seek");
				timeSpan.Duration = context.StringValue("ListJob.JobList["+ i +"].Output.Clip.TimeSpan.Duration");
				clip.TimeSpan = timeSpan;
				output.Clip = clip;

				ListJobResponse.Job.Output_.SuperReso_ superReso = new ListJobResponse.Job.Output_.SuperReso_();
				superReso.IsHalfSample = context.StringValue("ListJob.JobList["+ i +"].Output.SuperReso.IsHalfSample");
				output.SuperReso = superReso;

				ListJobResponse.Job.Output_.SubtitleConfig_ subtitleConfig = new ListJobResponse.Job.Output_.SubtitleConfig_();

				List<ListJobResponse.Job.Output_.SubtitleConfig_.Subtitle> subtitleList = new List<ListJobResponse.Job.Output_.SubtitleConfig_.Subtitle>();
				for (int j = 0; j < context.Length("ListJob.JobList["+ i +"].Output.SubtitleConfig.SubtitleList.Length"); j++) {
					ListJobResponse.Job.Output_.SubtitleConfig_.Subtitle subtitle = new ListJobResponse.Job.Output_.SubtitleConfig_.Subtitle();
					subtitle.Map = context.StringValue("ListJob.JobList["+ i +"].Output.SubtitleConfig.SubtitleList["+ j +"].Map");

					subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleList;

				List<ListJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle> extSubtitleList = new List<ListJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle>();
				for (int j = 0; j < context.Length("ListJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					ListJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle extSubtitle = new ListJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle();

					ListJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_ extSubtitleInput_ = new ListJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_();
					extSubtitleInput_.Bucket = context.StringValue("ListJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Bucket");
					extSubtitleInput_.Location = context.StringValue("ListJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Location");
					extSubtitleInput_.Object = context.StringValue("ListJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Object");
					extSubtitle.Input = extSubtitleInput_;

					extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = extSubtitleList;
				output.SubtitleConfig = subtitleConfig;

				ListJobResponse.Job.Output_.TransConfig_ transConfig = new ListJobResponse.Job.Output_.TransConfig_();
				transConfig.TransMode = context.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.TransMode");
				transConfig.IsCheckReso = context.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.IsCheckReso");
				transConfig.IsCheckResoFail = context.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.IsCheckResoFail");
				transConfig.IsCheckVideoBitrate = context.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckAudioBitrate = context.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.IsCheckAudioBitrate");
				transConfig.AdjDarMethod = context.StringValue("ListJob.JobList["+ i +"].Output.TransConfig.AdjDarMethod");
				output.TransConfig = transConfig;

				ListJobResponse.Job.Output_.MuxConfig_ muxConfig = new ListJobResponse.Job.Output_.MuxConfig_();

				ListJobResponse.Job.Output_.MuxConfig_.Segment_ segment = new ListJobResponse.Job.Output_.MuxConfig_.Segment_();
				segment.Duration = context.StringValue("ListJob.JobList["+ i +"].Output.MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				ListJobResponse.Job.Output_.MuxConfig_.Gif_ gif = new ListJobResponse.Job.Output_.MuxConfig_.Gif_();
				gif.Loop = context.StringValue("ListJob.JobList["+ i +"].Output.MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("ListJob.JobList["+ i +"].Output.MuxConfig.Gif.FinalDelay");
				gif.IsCustomPalette = context.StringValue("ListJob.JobList["+ i +"].Output.MuxConfig.Gif.IsCustomPalette");
				gif.DitherMode = context.StringValue("ListJob.JobList["+ i +"].Output.MuxConfig.Gif.DitherMode");
				muxConfig.Gif = gif;
				output.MuxConfig = muxConfig;

				ListJobResponse.Job.Output_.Audio_ audio = new ListJobResponse.Job.Output_.Audio_();
				audio.Codec = context.StringValue("ListJob.JobList["+ i +"].Output.Audio.Codec");
				audio.Profile = context.StringValue("ListJob.JobList["+ i +"].Output.Audio.Profile");
				audio.Samplerate = context.StringValue("ListJob.JobList["+ i +"].Output.Audio.Samplerate");
				audio.Bitrate = context.StringValue("ListJob.JobList["+ i +"].Output.Audio.Bitrate");
				audio.Channels = context.StringValue("ListJob.JobList["+ i +"].Output.Audio.Channels");
				audio.Qscale = context.StringValue("ListJob.JobList["+ i +"].Output.Audio.Qscale");
				output.Audio = audio;

				ListJobResponse.Job.Output_.Video_ video = new ListJobResponse.Job.Output_.Video_();
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

				ListJobResponse.Job.Output_.Video_.BitrateBnd_ bitrateBnd = new ListJobResponse.Job.Output_.Video_.BitrateBnd_();
				bitrateBnd.Max = context.StringValue("ListJob.JobList["+ i +"].Output.Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("ListJob.JobList["+ i +"].Output.Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				output.Video = video;

				ListJobResponse.Job.Output_.Container_ container = new ListJobResponse.Job.Output_.Container_();
				container.Format = context.StringValue("ListJob.JobList["+ i +"].Output.Container.Format");
				output.Container = container;

				List<ListJobResponse.Job.Output_.WaterMark> waterMarkList = new List<ListJobResponse.Job.Output_.WaterMark>();
				for (int j = 0; j < context.Length("ListJob.JobList["+ i +"].Output.WaterMarkList.Length"); j++) {
					ListJobResponse.Job.Output_.WaterMark waterMark = new ListJobResponse.Job.Output_.WaterMark();
					waterMark.WaterMarkTemplateId = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].WaterMarkTemplateId");
					waterMark.Width = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Width");
					waterMark.Height = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Height");
					waterMark.Dx = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dx");
					waterMark.Dy = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dy");
					waterMark.ReferPos = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].ReferPos");
					waterMark.Type = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Type");

					ListJobResponse.Job.Output_.WaterMark.InputFile_ inputFile = new ListJobResponse.Job.Output_.WaterMark.InputFile_();
					inputFile.Bucket = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Bucket");
					inputFile.Location = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Location");
					inputFile.Object = context.StringValue("ListJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Object");
					waterMark.InputFile = inputFile;

					waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = waterMarkList;

				List<ListJobResponse.Job.Output_.Merge> mergeList = new List<ListJobResponse.Job.Output_.Merge>();
				for (int j = 0; j < context.Length("ListJob.JobList["+ i +"].Output.MergeList.Length"); j++) {
					ListJobResponse.Job.Output_.Merge merge = new ListJobResponse.Job.Output_.Merge();
					merge.MergeURL = context.StringValue("ListJob.JobList["+ i +"].Output.MergeList["+ j +"].MergeURL");
					merge.Start = context.StringValue("ListJob.JobList["+ i +"].Output.MergeList["+ j +"].Start");
					merge.Duration = context.StringValue("ListJob.JobList["+ i +"].Output.MergeList["+ j +"].Duration");

					mergeList.Add(merge);
				}
				output.MergeList = mergeList;
				job.Output = output;

				ListJobResponse.Job.MNSMessageResult_ mNSMessageResult = new ListJobResponse.Job.MNSMessageResult_();
				mNSMessageResult.MessageId = context.StringValue("ListJob.JobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = context.StringValue("ListJob.JobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = context.StringValue("ListJob.JobList["+ i +"].MNSMessageResult.ErrorCode");
				job.MNSMessageResult = mNSMessageResult;

				jobList.Add(job);
			}
			listJobResponse.JobList = jobList;
        
			return listJobResponse;
        }
    }
}