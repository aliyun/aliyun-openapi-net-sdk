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
    public class QueryJobListByPidResponseUnmarshaller
    {
        public static QueryJobListByPidResponse Unmarshall(UnmarshallerContext context)
        {
			QueryJobListByPidResponse queryJobListByPidResponse = new QueryJobListByPidResponse();

			queryJobListByPidResponse.HttpResponse = context.HttpResponse;
			queryJobListByPidResponse.RequestId = context.StringValue("QueryJobListByPid.RequestId");
			queryJobListByPidResponse.TotalCount = context.LongValue("QueryJobListByPid.TotalCount");
			queryJobListByPidResponse.PageNumber = context.LongValue("QueryJobListByPid.PageNumber");
			queryJobListByPidResponse.PageSize = context.LongValue("QueryJobListByPid.PageSize");

			List<QueryJobListByPidResponse.Job> jobList = new List<QueryJobListByPidResponse.Job>();
			for (int i = 0; i < context.Length("QueryJobListByPid.JobList.Length"); i++) {
				QueryJobListByPidResponse.Job job = new QueryJobListByPidResponse.Job();
				job.JobId = context.StringValue("QueryJobListByPid.JobList["+ i +"].JobId");
				job.State = context.StringValue("QueryJobListByPid.JobList["+ i +"].State");
				job.Code = context.StringValue("QueryJobListByPid.JobList["+ i +"].Code");
				job.Message = context.StringValue("QueryJobListByPid.JobList["+ i +"].Message");
				job.Percent = context.LongValue("QueryJobListByPid.JobList["+ i +"].Percent");
				job.PipelineId = context.StringValue("QueryJobListByPid.JobList["+ i +"].PipelineId");
				job.CreationTime = context.StringValue("QueryJobListByPid.JobList["+ i +"].CreationTime");

				QueryJobListByPidResponse.Job.Input_ input = new QueryJobListByPidResponse.Job.Input_();
				input.Bucket = context.StringValue("QueryJobListByPid.JobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryJobListByPid.JobList["+ i +"].Input.Location");
				input.Object = context.StringValue("QueryJobListByPid.JobList["+ i +"].Input.Object");
				job.Input = input;

				QueryJobListByPidResponse.Job.Output_ output = new QueryJobListByPidResponse.Job.Output_();
				output.TemplateId = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.TemplateId");
				output.UserData = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.UserData");
				output.Rotate = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Rotate");
				output.VideoStreamMap = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.VideoStreamMap");
				output.AudioStreamMap = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.AudioStreamMap");
				output.DeWatermark = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.DeWatermark");
				output.Priority = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Priority");

				QueryJobListByPidResponse.Job.Output_.OutputFile_ outputFile = new QueryJobListByPidResponse.Job.Output_.OutputFile_();
				outputFile.Bucket = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.OutputFile.Bucket");
				outputFile.Location = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.OutputFile.Location");
				outputFile.Object = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.OutputFile.Object");
				output.OutputFile = outputFile;

				QueryJobListByPidResponse.Job.Output_.Properties_ properties = new QueryJobListByPidResponse.Job.Output_.Properties_();
				properties.Width = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Width");
				properties.Height = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Height");
				properties.Bitrate = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Bitrate");
				properties.Duration = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Duration");
				properties.Fps = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Fps");
				properties.FileSize = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.FileSize");
				properties.FileFormat = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.FileFormat");

				QueryJobListByPidResponse.Job.Output_.Properties_.Streams_ streams = new QueryJobListByPidResponse.Job.Output_.Properties_.Streams_();

				List<QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.VideoStream> videoStreamList = new List<QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList.Length"); j++) {
					QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.VideoStream videoStream = new QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.VideoStream();
					videoStream.Index = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.CodecName = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.CodecLongName = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Profile = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.CodecTimeBase = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.CodecTagString = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.CodecTag = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.Width = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Height = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.HasBFrames = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Sar = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Dar = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.PixFmt = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Level = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Level");
					videoStream.Fps = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.AvgFPS = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.Timebase = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.StartTime = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Duration = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Bitrate = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.NumFrames = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Lang = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Lang");

					QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_();
					networkCost.PreloadTime = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.AudioStream> audioStreamList = new List<QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList.Length"); j++) {
					QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.AudioStream audioStream = new QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.AudioStream();
					audioStream.Index = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.CodecName = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.CodecTimeBase = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.CodecLongName = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.CodecTagString = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.CodecTag = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.SampleFmt = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.Samplerate = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.Channels = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.ChannelLayout = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Timebase = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.StartTime = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.Duration = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.Bitrate = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.NumFrames = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Lang = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Lang");

					audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
					QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.SubtitleStream subtitleStream = new QueryJobListByPidResponse.Job.Output_.Properties_.Streams_.SubtitleStream();
					subtitleStream.Index = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				properties.Streams = streams;

				QueryJobListByPidResponse.Job.Output_.Properties_.Format_ format = new QueryJobListByPidResponse.Job.Output_.Properties_.Format_();
				format.NumStreams = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Format.NumStreams");
				format.NumPrograms = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Format.NumPrograms");
				format.FormatName = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Format.FormatName");
				format.FormatLongName = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Format.FormatLongName");
				format.StartTime = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Format.StartTime");
				format.Duration = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Format.Duration");
				format.Size = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Format.Size");
				format.Bitrate = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Properties.Format.Bitrate");
				properties.Format = format;
				output.Properties = properties;

				QueryJobListByPidResponse.Job.Output_.Clip_ clip = new QueryJobListByPidResponse.Job.Output_.Clip_();

				QueryJobListByPidResponse.Job.Output_.Clip_.TimeSpan_ timeSpan = new QueryJobListByPidResponse.Job.Output_.Clip_.TimeSpan_();
				timeSpan.Seek = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Clip.TimeSpan.Seek");
				timeSpan.Duration = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Clip.TimeSpan.Duration");
				clip.TimeSpan = timeSpan;
				output.Clip = clip;

				QueryJobListByPidResponse.Job.Output_.SuperReso_ superReso = new QueryJobListByPidResponse.Job.Output_.SuperReso_();
				superReso.IsHalfSample = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.SuperReso.IsHalfSample");
				output.SuperReso = superReso;

				QueryJobListByPidResponse.Job.Output_.SubtitleConfig_ subtitleConfig = new QueryJobListByPidResponse.Job.Output_.SubtitleConfig_();

				List<QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.Subtitle> subtitleList = new List<QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.Subtitle>();
				for (int j = 0; j < context.Length("QueryJobListByPid.JobList["+ i +"].Output.SubtitleConfig.SubtitleList.Length"); j++) {
					QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.Subtitle subtitle = new QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.Subtitle();
					subtitle.Map = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.SubtitleConfig.SubtitleList["+ j +"].Map");

					subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleList;

				List<QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.ExtSubtitle> extSubtitleList = new List<QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.ExtSubtitle>();
				for (int j = 0; j < context.Length("QueryJobListByPid.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.ExtSubtitle extSubtitle = new QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.ExtSubtitle();

					QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_ extSubtitleInput_ = new QueryJobListByPidResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_();
					extSubtitleInput_.Bucket = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Bucket");
					extSubtitleInput_.Location = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Location");
					extSubtitleInput_.Object = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Object");
					extSubtitle.Input = extSubtitleInput_;

					extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = extSubtitleList;
				output.SubtitleConfig = subtitleConfig;

				QueryJobListByPidResponse.Job.Output_.TransConfig_ transConfig = new QueryJobListByPidResponse.Job.Output_.TransConfig_();
				transConfig.TransMode = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.TransConfig.TransMode");
				output.TransConfig = transConfig;

				QueryJobListByPidResponse.Job.Output_.MuxConfig_ muxConfig = new QueryJobListByPidResponse.Job.Output_.MuxConfig_();

				QueryJobListByPidResponse.Job.Output_.MuxConfig_.Segment_ segment = new QueryJobListByPidResponse.Job.Output_.MuxConfig_.Segment_();
				segment.Duration = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				QueryJobListByPidResponse.Job.Output_.MuxConfig_.Gif_ gif = new QueryJobListByPidResponse.Job.Output_.MuxConfig_.Gif_();
				gif.Loop = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.MuxConfig.Gif.FinalDelay");
				muxConfig.Gif = gif;
				output.MuxConfig = muxConfig;

				QueryJobListByPidResponse.Job.Output_.TransFeatures_ transFeatures = new QueryJobListByPidResponse.Job.Output_.TransFeatures_();

				List<QueryJobListByPidResponse.Job.Output_.TransFeatures_.Merge> mergeList = new List<QueryJobListByPidResponse.Job.Output_.TransFeatures_.Merge>();
				for (int j = 0; j < context.Length("QueryJobListByPid.JobList["+ i +"].Output.TransFeatures.MergeList.Length"); j++) {
					QueryJobListByPidResponse.Job.Output_.TransFeatures_.Merge merge = new QueryJobListByPidResponse.Job.Output_.TransFeatures_.Merge();
					merge.MergeURL = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.TransFeatures.MergeList["+ j +"].MergeURL");
					merge.Start = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.TransFeatures.MergeList["+ j +"].Start");
					merge.Duration = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.TransFeatures.MergeList["+ j +"].Duration");

					mergeList.Add(merge);
				}
				transFeatures.MergeList = mergeList;
				output.TransFeatures = transFeatures;

				QueryJobListByPidResponse.Job.Output_.Audio_ audio = new QueryJobListByPidResponse.Job.Output_.Audio_();
				audio.Codec = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Audio.Codec");
				audio.Profile = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Audio.Profile");
				audio.Samplerate = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Audio.Samplerate");
				audio.Bitrate = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Audio.Bitrate");
				audio.Channels = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Audio.Channels");
				audio.Qscale = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Audio.Qscale");
				output.Audio = audio;

				QueryJobListByPidResponse.Job.Output_.Video_ video = new QueryJobListByPidResponse.Job.Output_.Video_();
				video.Codec = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.Codec");
				video.Profile = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.Profile");
				video.Bitrate = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.Bitrate");
				video.Crf = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.Crf");
				video.Width = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.Width");
				video.Height = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.Height");
				video.Fps = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.Fps");
				video.Gop = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.Gop");
				video.Preset = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.Preset");
				video.ScanMode = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.ScanMode");
				video.Bufsize = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.Bufsize");
				video.Maxrate = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.Maxrate");
				video.PixFmt = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.PixFmt");
				video.Degrain = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.Degrain");
				video.Qscale = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.Qscale");

				QueryJobListByPidResponse.Job.Output_.Video_.BitrateBnd_ bitrateBnd = new QueryJobListByPidResponse.Job.Output_.Video_.BitrateBnd_();
				bitrateBnd.Max = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				output.Video = video;

				QueryJobListByPidResponse.Job.Output_.Container_ container = new QueryJobListByPidResponse.Job.Output_.Container_();
				container.Format = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.Container.Format");
				output.Container = container;

				List<QueryJobListByPidResponse.Job.Output_.WaterMark> waterMarkList = new List<QueryJobListByPidResponse.Job.Output_.WaterMark>();
				for (int j = 0; j < context.Length("QueryJobListByPid.JobList["+ i +"].Output.WaterMarkList.Length"); j++) {
					QueryJobListByPidResponse.Job.Output_.WaterMark waterMark = new QueryJobListByPidResponse.Job.Output_.WaterMark();
					waterMark.WaterMarkTemplateId = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.WaterMarkList["+ j +"].WaterMarkTemplateId");
					waterMark.Width = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.WaterMarkList["+ j +"].Width");
					waterMark.Height = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.WaterMarkList["+ j +"].Height");
					waterMark.Dx = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dx");
					waterMark.Dy = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dy");
					waterMark.ReferPos = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.WaterMarkList["+ j +"].ReferPos");
					waterMark.Type = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.WaterMarkList["+ j +"].Type");

					QueryJobListByPidResponse.Job.Output_.WaterMark.InputFile_ inputFile = new QueryJobListByPidResponse.Job.Output_.WaterMark.InputFile_();
					inputFile.Bucket = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Bucket");
					inputFile.Location = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Location");
					inputFile.Object = context.StringValue("QueryJobListByPid.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Object");
					waterMark.InputFile = inputFile;

					waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = waterMarkList;
				job.Output = output;

				jobList.Add(job);
			}
			queryJobListByPidResponse.JobList = jobList;
        
			return queryJobListByPidResponse;
        }
    }
}