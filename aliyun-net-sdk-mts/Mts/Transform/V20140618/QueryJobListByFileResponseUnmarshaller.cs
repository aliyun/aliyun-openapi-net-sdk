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
    public class QueryJobListByFileResponseUnmarshaller
    {
        public static QueryJobListByFileResponse Unmarshall(UnmarshallerContext context)
        {
			QueryJobListByFileResponse queryJobListByFileResponse = new QueryJobListByFileResponse();

			queryJobListByFileResponse.HttpResponse = context.HttpResponse;
			queryJobListByFileResponse.RequestId = context.StringValue("QueryJobListByFile.RequestId");

			List<QueryJobListByFileResponse.Job> jobList = new List<QueryJobListByFileResponse.Job>();
			for (int i = 0; i < context.Length("QueryJobListByFile.JobList.Length"); i++) {
				QueryJobListByFileResponse.Job job = new QueryJobListByFileResponse.Job();
				job.JobId = context.StringValue("QueryJobListByFile.JobList["+ i +"].JobId");
				job.State = context.StringValue("QueryJobListByFile.JobList["+ i +"].State");
				job.Code = context.StringValue("QueryJobListByFile.JobList["+ i +"].Code");
				job.Message = context.StringValue("QueryJobListByFile.JobList["+ i +"].Message");
				job.Percent = context.LongValue("QueryJobListByFile.JobList["+ i +"].Percent");
				job.PipelineId = context.StringValue("QueryJobListByFile.JobList["+ i +"].PipelineId");
				job.CreationTime = context.StringValue("QueryJobListByFile.JobList["+ i +"].CreationTime");

				QueryJobListByFileResponse.Job.Input_ input = new QueryJobListByFileResponse.Job.Input_();
				input.Bucket = context.StringValue("QueryJobListByFile.JobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryJobListByFile.JobList["+ i +"].Input.Location");
				input.Object = context.StringValue("QueryJobListByFile.JobList["+ i +"].Input.Object");
				job.Input = input;

				QueryJobListByFileResponse.Job.Output_ output = new QueryJobListByFileResponse.Job.Output_();
				output.TemplateId = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.TemplateId");
				output.UserData = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.UserData");
				output.Rotate = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Rotate");
				output.VideoStreamMap = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.VideoStreamMap");
				output.AudioStreamMap = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.AudioStreamMap");
				output.DeWatermark = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.DeWatermark");
				output.Priority = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Priority");

				QueryJobListByFileResponse.Job.Output_.OutputFile_ outputFile = new QueryJobListByFileResponse.Job.Output_.OutputFile_();
				outputFile.Bucket = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.OutputFile.Bucket");
				outputFile.Location = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.OutputFile.Location");
				outputFile.Object = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.OutputFile.Object");
				output.OutputFile = outputFile;

				QueryJobListByFileResponse.Job.Output_.Properties_ properties = new QueryJobListByFileResponse.Job.Output_.Properties_();
				properties.Width = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Width");
				properties.Height = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Height");
				properties.Bitrate = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Bitrate");
				properties.Duration = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Duration");
				properties.Fps = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Fps");
				properties.FileSize = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.FileSize");
				properties.FileFormat = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.FileFormat");

				QueryJobListByFileResponse.Job.Output_.Properties_.Streams_ streams = new QueryJobListByFileResponse.Job.Output_.Properties_.Streams_();

				List<QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.VideoStream> videoStreamList = new List<QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList.Length"); j++) {
					QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.VideoStream videoStream = new QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.VideoStream();
					videoStream.Index = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.CodecName = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.CodecLongName = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Profile = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.CodecTimeBase = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.CodecTagString = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.CodecTag = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.Width = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Height = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.HasBFrames = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Sar = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Dar = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.PixFmt = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Level = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Level");
					videoStream.Fps = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.AvgFPS = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.Timebase = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.StartTime = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Duration = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Bitrate = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.NumFrames = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Lang = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Lang");

					QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_();
					networkCost.PreloadTime = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.AudioStream> audioStreamList = new List<QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList.Length"); j++) {
					QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.AudioStream audioStream = new QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.AudioStream();
					audioStream.Index = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.CodecName = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.CodecTimeBase = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.CodecLongName = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.CodecTagString = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.CodecTag = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.SampleFmt = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.Samplerate = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.Channels = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.ChannelLayout = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Timebase = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.StartTime = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.Duration = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.Bitrate = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.NumFrames = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Lang = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Lang");

					audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
					QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.SubtitleStream subtitleStream = new QueryJobListByFileResponse.Job.Output_.Properties_.Streams_.SubtitleStream();
					subtitleStream.Index = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				properties.Streams = streams;

				QueryJobListByFileResponse.Job.Output_.Properties_.Format_ format = new QueryJobListByFileResponse.Job.Output_.Properties_.Format_();
				format.NumStreams = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Format.NumStreams");
				format.NumPrograms = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Format.NumPrograms");
				format.FormatName = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Format.FormatName");
				format.FormatLongName = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Format.FormatLongName");
				format.StartTime = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Format.StartTime");
				format.Duration = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Format.Duration");
				format.Size = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Format.Size");
				format.Bitrate = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Properties.Format.Bitrate");
				properties.Format = format;
				output.Properties = properties;

				QueryJobListByFileResponse.Job.Output_.Clip_ clip = new QueryJobListByFileResponse.Job.Output_.Clip_();

				QueryJobListByFileResponse.Job.Output_.Clip_.TimeSpan_ timeSpan = new QueryJobListByFileResponse.Job.Output_.Clip_.TimeSpan_();
				timeSpan.Seek = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Clip.TimeSpan.Seek");
				timeSpan.Duration = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Clip.TimeSpan.Duration");
				clip.TimeSpan = timeSpan;
				output.Clip = clip;

				QueryJobListByFileResponse.Job.Output_.SuperReso_ superReso = new QueryJobListByFileResponse.Job.Output_.SuperReso_();
				superReso.IsHalfSample = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.SuperReso.IsHalfSample");
				output.SuperReso = superReso;

				QueryJobListByFileResponse.Job.Output_.SubtitleConfig_ subtitleConfig = new QueryJobListByFileResponse.Job.Output_.SubtitleConfig_();

				List<QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.Subtitle> subtitleList = new List<QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.Subtitle>();
				for (int j = 0; j < context.Length("QueryJobListByFile.JobList["+ i +"].Output.SubtitleConfig.SubtitleList.Length"); j++) {
					QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.Subtitle subtitle = new QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.Subtitle();
					subtitle.Map = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.SubtitleConfig.SubtitleList["+ j +"].Map");

					subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleList;

				List<QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.ExtSubtitle> extSubtitleList = new List<QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.ExtSubtitle>();
				for (int j = 0; j < context.Length("QueryJobListByFile.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.ExtSubtitle extSubtitle = new QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.ExtSubtitle();

					QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_ extSubtitleInput_ = new QueryJobListByFileResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_();
					extSubtitleInput_.Bucket = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Bucket");
					extSubtitleInput_.Location = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Location");
					extSubtitleInput_.Object = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Object");
					extSubtitle.Input = extSubtitleInput_;

					extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = extSubtitleList;
				output.SubtitleConfig = subtitleConfig;

				QueryJobListByFileResponse.Job.Output_.TransConfig_ transConfig = new QueryJobListByFileResponse.Job.Output_.TransConfig_();
				transConfig.TransMode = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.TransConfig.TransMode");
				output.TransConfig = transConfig;

				QueryJobListByFileResponse.Job.Output_.MuxConfig_ muxConfig = new QueryJobListByFileResponse.Job.Output_.MuxConfig_();

				QueryJobListByFileResponse.Job.Output_.MuxConfig_.Segment_ segment = new QueryJobListByFileResponse.Job.Output_.MuxConfig_.Segment_();
				segment.Duration = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				QueryJobListByFileResponse.Job.Output_.MuxConfig_.Gif_ gif = new QueryJobListByFileResponse.Job.Output_.MuxConfig_.Gif_();
				gif.Loop = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.MuxConfig.Gif.FinalDelay");
				muxConfig.Gif = gif;
				output.MuxConfig = muxConfig;

				QueryJobListByFileResponse.Job.Output_.Audio_ audio = new QueryJobListByFileResponse.Job.Output_.Audio_();
				audio.Codec = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Audio.Codec");
				audio.Profile = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Audio.Profile");
				audio.Samplerate = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Audio.Samplerate");
				audio.Bitrate = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Audio.Bitrate");
				audio.Channels = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Audio.Channels");
				audio.Qscale = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Audio.Qscale");
				output.Audio = audio;

				QueryJobListByFileResponse.Job.Output_.Video_ video = new QueryJobListByFileResponse.Job.Output_.Video_();
				video.Codec = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.Codec");
				video.Profile = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.Profile");
				video.Bitrate = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.Bitrate");
				video.Crf = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.Crf");
				video.Width = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.Width");
				video.Height = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.Height");
				video.Fps = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.Fps");
				video.Gop = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.Gop");
				video.Preset = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.Preset");
				video.ScanMode = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.ScanMode");
				video.Bufsize = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.Bufsize");
				video.Maxrate = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.Maxrate");
				video.PixFmt = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.PixFmt");
				video.Degrain = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.Degrain");
				video.Qscale = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.Qscale");

				QueryJobListByFileResponse.Job.Output_.Video_.BitrateBnd_ bitrateBnd = new QueryJobListByFileResponse.Job.Output_.Video_.BitrateBnd_();
				bitrateBnd.Max = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				output.Video = video;

				QueryJobListByFileResponse.Job.Output_.Container_ container = new QueryJobListByFileResponse.Job.Output_.Container_();
				container.Format = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.Container.Format");
				output.Container = container;

				List<QueryJobListByFileResponse.Job.Output_.WaterMark> waterMarkList = new List<QueryJobListByFileResponse.Job.Output_.WaterMark>();
				for (int j = 0; j < context.Length("QueryJobListByFile.JobList["+ i +"].Output.WaterMarkList.Length"); j++) {
					QueryJobListByFileResponse.Job.Output_.WaterMark waterMark = new QueryJobListByFileResponse.Job.Output_.WaterMark();
					waterMark.WaterMarkTemplateId = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.WaterMarkList["+ j +"].WaterMarkTemplateId");
					waterMark.Width = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.WaterMarkList["+ j +"].Width");
					waterMark.Height = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.WaterMarkList["+ j +"].Height");
					waterMark.Dx = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dx");
					waterMark.Dy = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dy");
					waterMark.ReferPos = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.WaterMarkList["+ j +"].ReferPos");
					waterMark.Type = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.WaterMarkList["+ j +"].Type");

					QueryJobListByFileResponse.Job.Output_.WaterMark.InputFile_ inputFile = new QueryJobListByFileResponse.Job.Output_.WaterMark.InputFile_();
					inputFile.Bucket = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Bucket");
					inputFile.Location = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Location");
					inputFile.Object = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Object");
					waterMark.InputFile = inputFile;

					waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = waterMarkList;

				List<QueryJobListByFileResponse.Job.Output_.Merge> mergeList = new List<QueryJobListByFileResponse.Job.Output_.Merge>();
				for (int j = 0; j < context.Length("QueryJobListByFile.JobList["+ i +"].Output.MergeList.Length"); j++) {
					QueryJobListByFileResponse.Job.Output_.Merge merge = new QueryJobListByFileResponse.Job.Output_.Merge();
					merge.MergeURL = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.MergeList["+ j +"].MergeURL");
					merge.Start = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.MergeList["+ j +"].Start");
					merge.Duration = context.StringValue("QueryJobListByFile.JobList["+ i +"].Output.MergeList["+ j +"].Duration");

					mergeList.Add(merge);
				}
				output.MergeList = mergeList;
				job.Output = output;

				jobList.Add(job);
			}
			queryJobListByFileResponse.JobList = jobList;
        
			return queryJobListByFileResponse;
        }
    }
}