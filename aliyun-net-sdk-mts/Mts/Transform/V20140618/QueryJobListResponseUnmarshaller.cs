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
    public class QueryJobListResponseUnmarshaller
    {
        public static QueryJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryJobListResponse queryJobListResponse = new QueryJobListResponse();

			queryJobListResponse.HttpResponse = context.HttpResponse;
			queryJobListResponse.RequestId = context.StringValue("QueryJobList.RequestId");

			List<string> nonExistJobIds = new List<string>();
			for (int i = 0; i < context.Length("QueryJobList.NonExistJobIds.Length"); i++) {
				nonExistJobIds.Add(context.StringValue("QueryJobList.NonExistJobIds["+ i +"]"));
			}
			queryJobListResponse.NonExistJobIds = nonExistJobIds;

			List<QueryJobListResponse.Job> jobList = new List<QueryJobListResponse.Job>();
			for (int i = 0; i < context.Length("QueryJobList.JobList.Length"); i++) {
				QueryJobListResponse.Job job = new QueryJobListResponse.Job();
				job.JobId = context.StringValue("QueryJobList.JobList["+ i +"].JobId");
				job.State = context.StringValue("QueryJobList.JobList["+ i +"].State");
				job.Code = context.StringValue("QueryJobList.JobList["+ i +"].Code");
				job.Message = context.StringValue("QueryJobList.JobList["+ i +"].Message");
				job.Percent = context.LongValue("QueryJobList.JobList["+ i +"].Percent");
				job.PipelineId = context.StringValue("QueryJobList.JobList["+ i +"].PipelineId");
				job.CreationTime = context.StringValue("QueryJobList.JobList["+ i +"].CreationTime");

				QueryJobListResponse.Job.Input_ input = new QueryJobListResponse.Job.Input_();
				input.Bucket = context.StringValue("QueryJobList.JobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryJobList.JobList["+ i +"].Input.Location");
				input.Object = context.StringValue("QueryJobList.JobList["+ i +"].Input.Object");
				job.Input = input;

				QueryJobListResponse.Job.Output_ output = new QueryJobListResponse.Job.Output_();
				output.TemplateId = context.StringValue("QueryJobList.JobList["+ i +"].Output.TemplateId");
				output.UserData = context.StringValue("QueryJobList.JobList["+ i +"].Output.UserData");
				output.Rotate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Rotate");
				output.VideoStreamMap = context.StringValue("QueryJobList.JobList["+ i +"].Output.VideoStreamMap");
				output.AudioStreamMap = context.StringValue("QueryJobList.JobList["+ i +"].Output.AudioStreamMap");
				output.DeWatermark = context.StringValue("QueryJobList.JobList["+ i +"].Output.DeWatermark");
				output.Priority = context.StringValue("QueryJobList.JobList["+ i +"].Output.Priority");

				QueryJobListResponse.Job.Output_.OutputFile_ outputFile = new QueryJobListResponse.Job.Output_.OutputFile_();
				outputFile.Bucket = context.StringValue("QueryJobList.JobList["+ i +"].Output.OutputFile.Bucket");
				outputFile.Location = context.StringValue("QueryJobList.JobList["+ i +"].Output.OutputFile.Location");
				outputFile.Object = context.StringValue("QueryJobList.JobList["+ i +"].Output.OutputFile.Object");
				output.OutputFile = outputFile;

				QueryJobListResponse.Job.Output_.Properties_ properties = new QueryJobListResponse.Job.Output_.Properties_();
				properties.Width = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Width");
				properties.Height = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Height");
				properties.Bitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Bitrate");
				properties.Duration = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Duration");
				properties.Fps = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Fps");
				properties.FileSize = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.FileSize");
				properties.FileFormat = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.FileFormat");

				QueryJobListResponse.Job.Output_.Properties_.Streams_ streams = new QueryJobListResponse.Job.Output_.Properties_.Streams_();

				List<QueryJobListResponse.Job.Output_.Properties_.Streams_.VideoStream> videoStreamList = new List<QueryJobListResponse.Job.Output_.Properties_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList.Length"); j++) {
					QueryJobListResponse.Job.Output_.Properties_.Streams_.VideoStream videoStream = new QueryJobListResponse.Job.Output_.Properties_.Streams_.VideoStream();
					videoStream.Index = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.CodecName = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.CodecLongName = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Profile = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.CodecTimeBase = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.CodecTagString = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.CodecTag = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.Width = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Height = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.HasBFrames = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Sar = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Dar = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.PixFmt = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Level = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Level");
					videoStream.Fps = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.AvgFPS = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.Timebase = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.StartTime = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Duration = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Bitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.NumFrames = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Lang = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Lang");

					QueryJobListResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new QueryJobListResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_();
					networkCost.PreloadTime = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<QueryJobListResponse.Job.Output_.Properties_.Streams_.AudioStream> audioStreamList = new List<QueryJobListResponse.Job.Output_.Properties_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList.Length"); j++) {
					QueryJobListResponse.Job.Output_.Properties_.Streams_.AudioStream audioStream = new QueryJobListResponse.Job.Output_.Properties_.Streams_.AudioStream();
					audioStream.Index = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.CodecName = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.CodecTimeBase = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.CodecLongName = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.CodecTagString = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.CodecTag = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.SampleFmt = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.Samplerate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.Channels = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.ChannelLayout = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Timebase = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.StartTime = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.Duration = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.Bitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.NumFrames = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Lang = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Lang");

					audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<QueryJobListResponse.Job.Output_.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<QueryJobListResponse.Job.Output_.Properties_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
					QueryJobListResponse.Job.Output_.Properties_.Streams_.SubtitleStream subtitleStream = new QueryJobListResponse.Job.Output_.Properties_.Streams_.SubtitleStream();
					subtitleStream.Index = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				properties.Streams = streams;

				QueryJobListResponse.Job.Output_.Properties_.Format_ format = new QueryJobListResponse.Job.Output_.Properties_.Format_();
				format.NumStreams = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.NumStreams");
				format.NumPrograms = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.NumPrograms");
				format.FormatName = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.FormatName");
				format.FormatLongName = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.FormatLongName");
				format.StartTime = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.StartTime");
				format.Duration = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.Duration");
				format.Size = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.Size");
				format.Bitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Properties.Format.Bitrate");
				properties.Format = format;
				output.Properties = properties;

				QueryJobListResponse.Job.Output_.Clip_ clip = new QueryJobListResponse.Job.Output_.Clip_();

				QueryJobListResponse.Job.Output_.Clip_.TimeSpan_ timeSpan = new QueryJobListResponse.Job.Output_.Clip_.TimeSpan_();
				timeSpan.Seek = context.StringValue("QueryJobList.JobList["+ i +"].Output.Clip.TimeSpan.Seek");
				timeSpan.Duration = context.StringValue("QueryJobList.JobList["+ i +"].Output.Clip.TimeSpan.Duration");
				clip.TimeSpan = timeSpan;
				output.Clip = clip;

				QueryJobListResponse.Job.Output_.SuperReso_ superReso = new QueryJobListResponse.Job.Output_.SuperReso_();
				superReso.IsHalfSample = context.StringValue("QueryJobList.JobList["+ i +"].Output.SuperReso.IsHalfSample");
				output.SuperReso = superReso;

				QueryJobListResponse.Job.Output_.SubtitleConfig_ subtitleConfig = new QueryJobListResponse.Job.Output_.SubtitleConfig_();

				List<QueryJobListResponse.Job.Output_.SubtitleConfig_.Subtitle> subtitleList = new List<QueryJobListResponse.Job.Output_.SubtitleConfig_.Subtitle>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.SubtitleList.Length"); j++) {
					QueryJobListResponse.Job.Output_.SubtitleConfig_.Subtitle subtitle = new QueryJobListResponse.Job.Output_.SubtitleConfig_.Subtitle();
					subtitle.Map = context.StringValue("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.SubtitleList["+ j +"].Map");

					subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleList;

				List<QueryJobListResponse.Job.Output_.SubtitleConfig_.ExtSubtitle> extSubtitleList = new List<QueryJobListResponse.Job.Output_.SubtitleConfig_.ExtSubtitle>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					QueryJobListResponse.Job.Output_.SubtitleConfig_.ExtSubtitle extSubtitle = new QueryJobListResponse.Job.Output_.SubtitleConfig_.ExtSubtitle();

					QueryJobListResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_ extSubtitleInput_ = new QueryJobListResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_();
					extSubtitleInput_.Bucket = context.StringValue("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Bucket");
					extSubtitleInput_.Location = context.StringValue("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Location");
					extSubtitleInput_.Object = context.StringValue("QueryJobList.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Object");
					extSubtitle.Input = extSubtitleInput_;

					extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = extSubtitleList;
				output.SubtitleConfig = subtitleConfig;

				QueryJobListResponse.Job.Output_.TransConfig_ transConfig = new QueryJobListResponse.Job.Output_.TransConfig_();
				transConfig.TransMode = context.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.TransMode");
				transConfig.IsCheckReso = context.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.IsCheckReso");
				transConfig.IsCheckResoFail = context.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.IsCheckResoFail");
				transConfig.IsCheckVideoBitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckAudioBitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.IsCheckAudioBitrate");
				transConfig.AdjDarMethod = context.StringValue("QueryJobList.JobList["+ i +"].Output.TransConfig.AdjDarMethod");
				output.TransConfig = transConfig;

				QueryJobListResponse.Job.Output_.MuxConfig_ muxConfig = new QueryJobListResponse.Job.Output_.MuxConfig_();

				QueryJobListResponse.Job.Output_.MuxConfig_.Segment_ segment = new QueryJobListResponse.Job.Output_.MuxConfig_.Segment_();
				segment.Duration = context.StringValue("QueryJobList.JobList["+ i +"].Output.MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				QueryJobListResponse.Job.Output_.MuxConfig_.Gif_ gif = new QueryJobListResponse.Job.Output_.MuxConfig_.Gif_();
				gif.Loop = context.StringValue("QueryJobList.JobList["+ i +"].Output.MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("QueryJobList.JobList["+ i +"].Output.MuxConfig.Gif.FinalDelay");
				gif.IsCustomPalette = context.StringValue("QueryJobList.JobList["+ i +"].Output.MuxConfig.Gif.IsCustomPalette");
				gif.DitherMode = context.StringValue("QueryJobList.JobList["+ i +"].Output.MuxConfig.Gif.DitherMode");
				muxConfig.Gif = gif;
				output.MuxConfig = muxConfig;

				QueryJobListResponse.Job.Output_.Audio_ audio = new QueryJobListResponse.Job.Output_.Audio_();
				audio.Codec = context.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Codec");
				audio.Profile = context.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Profile");
				audio.Samplerate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Samplerate");
				audio.Bitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Bitrate");
				audio.Channels = context.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Channels");
				audio.Qscale = context.StringValue("QueryJobList.JobList["+ i +"].Output.Audio.Qscale");
				output.Audio = audio;

				QueryJobListResponse.Job.Output_.Video_ video = new QueryJobListResponse.Job.Output_.Video_();
				video.Codec = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Codec");
				video.Profile = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Profile");
				video.Bitrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Bitrate");
				video.Crf = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Crf");
				video.Width = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Width");
				video.Height = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Height");
				video.Fps = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Fps");
				video.Gop = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Gop");
				video.Preset = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Preset");
				video.ScanMode = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.ScanMode");
				video.Bufsize = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Bufsize");
				video.Maxrate = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Maxrate");
				video.PixFmt = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.PixFmt");
				video.Degrain = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Degrain");
				video.Qscale = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Qscale");
				video.Crop = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Crop");
				video.Pad = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.Pad");
				video.MaxFps = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.MaxFps");

				QueryJobListResponse.Job.Output_.Video_.BitrateBnd_ bitrateBnd = new QueryJobListResponse.Job.Output_.Video_.BitrateBnd_();
				bitrateBnd.Max = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("QueryJobList.JobList["+ i +"].Output.Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				output.Video = video;

				QueryJobListResponse.Job.Output_.Container_ container = new QueryJobListResponse.Job.Output_.Container_();
				container.Format = context.StringValue("QueryJobList.JobList["+ i +"].Output.Container.Format");
				output.Container = container;

				List<QueryJobListResponse.Job.Output_.WaterMark> waterMarkList = new List<QueryJobListResponse.Job.Output_.WaterMark>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.WaterMarkList.Length"); j++) {
					QueryJobListResponse.Job.Output_.WaterMark waterMark = new QueryJobListResponse.Job.Output_.WaterMark();
					waterMark.WaterMarkTemplateId = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].WaterMarkTemplateId");
					waterMark.Width = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].Width");
					waterMark.Height = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].Height");
					waterMark.Dx = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dx");
					waterMark.Dy = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dy");
					waterMark.ReferPos = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].ReferPos");
					waterMark.Type = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].Type");

					QueryJobListResponse.Job.Output_.WaterMark.InputFile_ inputFile = new QueryJobListResponse.Job.Output_.WaterMark.InputFile_();
					inputFile.Bucket = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Bucket");
					inputFile.Location = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Location");
					inputFile.Object = context.StringValue("QueryJobList.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Object");
					waterMark.InputFile = inputFile;

					waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = waterMarkList;

				List<QueryJobListResponse.Job.Output_.Merge> mergeList = new List<QueryJobListResponse.Job.Output_.Merge>();
				for (int j = 0; j < context.Length("QueryJobList.JobList["+ i +"].Output.MergeList.Length"); j++) {
					QueryJobListResponse.Job.Output_.Merge merge = new QueryJobListResponse.Job.Output_.Merge();
					merge.MergeURL = context.StringValue("QueryJobList.JobList["+ i +"].Output.MergeList["+ j +"].MergeURL");
					merge.Start = context.StringValue("QueryJobList.JobList["+ i +"].Output.MergeList["+ j +"].Start");
					merge.Duration = context.StringValue("QueryJobList.JobList["+ i +"].Output.MergeList["+ j +"].Duration");

					mergeList.Add(merge);
				}
				output.MergeList = mergeList;
				job.Output = output;

				QueryJobListResponse.Job.MNSMessageResult_ mNSMessageResult = new QueryJobListResponse.Job.MNSMessageResult_();
				mNSMessageResult.MessageId = context.StringValue("QueryJobList.JobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = context.StringValue("QueryJobList.JobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = context.StringValue("QueryJobList.JobList["+ i +"].MNSMessageResult.ErrorCode");
				job.MNSMessageResult = mNSMessageResult;

				jobList.Add(job);
			}
			queryJobListResponse.JobList = jobList;
        
			return queryJobListResponse;
        }
    }
}