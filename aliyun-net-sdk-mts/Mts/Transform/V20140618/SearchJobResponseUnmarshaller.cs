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
    public class SearchJobResponseUnmarshaller
    {
        public static SearchJobResponse Unmarshall(UnmarshallerContext context)
        {
			SearchJobResponse searchJobResponse = new SearchJobResponse();

			searchJobResponse.HttpResponse = context.HttpResponse;
			searchJobResponse.RequestId = context.StringValue("SearchJob.RequestId");
			searchJobResponse.TotalCount = context.LongValue("SearchJob.TotalCount");
			searchJobResponse.PageNumber = context.LongValue("SearchJob.PageNumber");
			searchJobResponse.PageSize = context.LongValue("SearchJob.PageSize");

			List<SearchJobResponse.Job> jobList = new List<SearchJobResponse.Job>();
			for (int i = 0; i < context.Length("SearchJob.JobList.Length"); i++) {
				SearchJobResponse.Job job = new SearchJobResponse.Job();
				job.JobId = context.StringValue("SearchJob.JobList["+ i +"].JobId");
				job.State = context.StringValue("SearchJob.JobList["+ i +"].State");
				job.Code = context.StringValue("SearchJob.JobList["+ i +"].Code");
				job.Message = context.StringValue("SearchJob.JobList["+ i +"].Message");
				job.Percent = context.LongValue("SearchJob.JobList["+ i +"].Percent");
				job.PipelineId = context.StringValue("SearchJob.JobList["+ i +"].PipelineId");
				job.CreationTime = context.StringValue("SearchJob.JobList["+ i +"].CreationTime");

				SearchJobResponse.Job.Input_ input = new SearchJobResponse.Job.Input_();
				input.Bucket = context.StringValue("SearchJob.JobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("SearchJob.JobList["+ i +"].Input.Location");
				input.Object = context.StringValue("SearchJob.JobList["+ i +"].Input.Object");
				job.Input = input;

				SearchJobResponse.Job.Output_ output = new SearchJobResponse.Job.Output_();
				output.TemplateId = context.StringValue("SearchJob.JobList["+ i +"].Output.TemplateId");
				output.UserData = context.StringValue("SearchJob.JobList["+ i +"].Output.UserData");
				output.Rotate = context.StringValue("SearchJob.JobList["+ i +"].Output.Rotate");
				output.VideoStreamMap = context.StringValue("SearchJob.JobList["+ i +"].Output.VideoStreamMap");
				output.AudioStreamMap = context.StringValue("SearchJob.JobList["+ i +"].Output.AudioStreamMap");
				output.DeWatermark = context.StringValue("SearchJob.JobList["+ i +"].Output.DeWatermark");
				output.Priority = context.StringValue("SearchJob.JobList["+ i +"].Output.Priority");

				SearchJobResponse.Job.Output_.OutputFile_ outputFile = new SearchJobResponse.Job.Output_.OutputFile_();
				outputFile.Bucket = context.StringValue("SearchJob.JobList["+ i +"].Output.OutputFile.Bucket");
				outputFile.Location = context.StringValue("SearchJob.JobList["+ i +"].Output.OutputFile.Location");
				outputFile.Object = context.StringValue("SearchJob.JobList["+ i +"].Output.OutputFile.Object");
				output.OutputFile = outputFile;

				SearchJobResponse.Job.Output_.Properties_ properties = new SearchJobResponse.Job.Output_.Properties_();
				properties.Width = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Width");
				properties.Height = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Height");
				properties.Bitrate = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Bitrate");
				properties.Duration = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Duration");
				properties.Fps = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Fps");
				properties.FileSize = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.FileSize");
				properties.FileFormat = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.FileFormat");

				SearchJobResponse.Job.Output_.Properties_.Streams_ streams = new SearchJobResponse.Job.Output_.Properties_.Streams_();

				List<SearchJobResponse.Job.Output_.Properties_.Streams_.VideoStream> videoStreamList = new List<SearchJobResponse.Job.Output_.Properties_.Streams_.VideoStream>();
				for (int j = 0; j < context.Length("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList.Length"); j++) {
					SearchJobResponse.Job.Output_.Properties_.Streams_.VideoStream videoStream = new SearchJobResponse.Job.Output_.Properties_.Streams_.VideoStream();
					videoStream.Index = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.CodecName = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.CodecLongName = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Profile = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.CodecTimeBase = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.CodecTagString = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.CodecTag = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.Width = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Height = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.HasBFrames = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Sar = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Dar = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.PixFmt = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Level = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Level");
					videoStream.Fps = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.AvgFPS = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.Timebase = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.StartTime = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Duration = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Bitrate = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.NumFrames = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Lang = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].Lang");

					SearchJobResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_ networkCost = new SearchJobResponse.Job.Output_.Properties_.Streams_.VideoStream.NetworkCost_();
					networkCost.PreloadTime = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = videoStreamList;

				List<SearchJobResponse.Job.Output_.Properties_.Streams_.AudioStream> audioStreamList = new List<SearchJobResponse.Job.Output_.Properties_.Streams_.AudioStream>();
				for (int j = 0; j < context.Length("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList.Length"); j++) {
					SearchJobResponse.Job.Output_.Properties_.Streams_.AudioStream audioStream = new SearchJobResponse.Job.Output_.Properties_.Streams_.AudioStream();
					audioStream.Index = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.CodecName = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.CodecTimeBase = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.CodecLongName = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.CodecTagString = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.CodecTag = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.SampleFmt = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.Samplerate = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.Channels = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.ChannelLayout = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Timebase = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.StartTime = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.Duration = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.Bitrate = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.NumFrames = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Lang = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.AudioStreamList["+ j +"].Lang");

					audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = audioStreamList;

				List<SearchJobResponse.Job.Output_.Properties_.Streams_.SubtitleStream> subtitleStreamList = new List<SearchJobResponse.Job.Output_.Properties_.Streams_.SubtitleStream>();
				for (int j = 0; j < context.Length("SearchJob.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList.Length"); j++) {
					SearchJobResponse.Job.Output_.Properties_.Streams_.SubtitleStream subtitleStream = new SearchJobResponse.Job.Output_.Properties_.Streams_.SubtitleStream();
					subtitleStream.Index = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.Lang = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = subtitleStreamList;
				properties.Streams = streams;

				SearchJobResponse.Job.Output_.Properties_.Format_ format = new SearchJobResponse.Job.Output_.Properties_.Format_();
				format.NumStreams = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Format.NumStreams");
				format.NumPrograms = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Format.NumPrograms");
				format.FormatName = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Format.FormatName");
				format.FormatLongName = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Format.FormatLongName");
				format.StartTime = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Format.StartTime");
				format.Duration = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Format.Duration");
				format.Size = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Format.Size");
				format.Bitrate = context.StringValue("SearchJob.JobList["+ i +"].Output.Properties.Format.Bitrate");
				properties.Format = format;
				output.Properties = properties;

				SearchJobResponse.Job.Output_.Clip_ clip = new SearchJobResponse.Job.Output_.Clip_();

				SearchJobResponse.Job.Output_.Clip_.TimeSpan_ timeSpan = new SearchJobResponse.Job.Output_.Clip_.TimeSpan_();
				timeSpan.Seek = context.StringValue("SearchJob.JobList["+ i +"].Output.Clip.TimeSpan.Seek");
				timeSpan.Duration = context.StringValue("SearchJob.JobList["+ i +"].Output.Clip.TimeSpan.Duration");
				clip.TimeSpan = timeSpan;
				output.Clip = clip;

				SearchJobResponse.Job.Output_.SuperReso_ superReso = new SearchJobResponse.Job.Output_.SuperReso_();
				superReso.IsHalfSample = context.StringValue("SearchJob.JobList["+ i +"].Output.SuperReso.IsHalfSample");
				output.SuperReso = superReso;

				SearchJobResponse.Job.Output_.SubtitleConfig_ subtitleConfig = new SearchJobResponse.Job.Output_.SubtitleConfig_();

				List<SearchJobResponse.Job.Output_.SubtitleConfig_.Subtitle> subtitleList = new List<SearchJobResponse.Job.Output_.SubtitleConfig_.Subtitle>();
				for (int j = 0; j < context.Length("SearchJob.JobList["+ i +"].Output.SubtitleConfig.SubtitleList.Length"); j++) {
					SearchJobResponse.Job.Output_.SubtitleConfig_.Subtitle subtitle = new SearchJobResponse.Job.Output_.SubtitleConfig_.Subtitle();
					subtitle.Map = context.StringValue("SearchJob.JobList["+ i +"].Output.SubtitleConfig.SubtitleList["+ j +"].Map");

					subtitleList.Add(subtitle);
				}
				subtitleConfig.SubtitleList = subtitleList;

				List<SearchJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle> extSubtitleList = new List<SearchJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle>();
				for (int j = 0; j < context.Length("SearchJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList.Length"); j++) {
					SearchJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle extSubtitle = new SearchJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle();

					SearchJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_ extSubtitleInput_ = new SearchJobResponse.Job.Output_.SubtitleConfig_.ExtSubtitle.Input_();
					extSubtitleInput_.Bucket = context.StringValue("SearchJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Bucket");
					extSubtitleInput_.Location = context.StringValue("SearchJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Location");
					extSubtitleInput_.Object = context.StringValue("SearchJob.JobList["+ i +"].Output.SubtitleConfig.ExtSubtitleList["+ j +"].Input.Object");
					extSubtitle.Input = extSubtitleInput_;

					extSubtitleList.Add(extSubtitle);
				}
				subtitleConfig.ExtSubtitleList = extSubtitleList;
				output.SubtitleConfig = subtitleConfig;

				SearchJobResponse.Job.Output_.TransConfig_ transConfig = new SearchJobResponse.Job.Output_.TransConfig_();
				transConfig.TransMode = context.StringValue("SearchJob.JobList["+ i +"].Output.TransConfig.TransMode");
				output.TransConfig = transConfig;

				SearchJobResponse.Job.Output_.MuxConfig_ muxConfig = new SearchJobResponse.Job.Output_.MuxConfig_();

				SearchJobResponse.Job.Output_.MuxConfig_.Segment_ segment = new SearchJobResponse.Job.Output_.MuxConfig_.Segment_();
				segment.Duration = context.StringValue("SearchJob.JobList["+ i +"].Output.MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				SearchJobResponse.Job.Output_.MuxConfig_.Gif_ gif = new SearchJobResponse.Job.Output_.MuxConfig_.Gif_();
				gif.Loop = context.StringValue("SearchJob.JobList["+ i +"].Output.MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("SearchJob.JobList["+ i +"].Output.MuxConfig.Gif.FinalDelay");
				muxConfig.Gif = gif;
				output.MuxConfig = muxConfig;

				SearchJobResponse.Job.Output_.TransFeatures_ transFeatures = new SearchJobResponse.Job.Output_.TransFeatures_();

				List<SearchJobResponse.Job.Output_.TransFeatures_.Merge> mergeList = new List<SearchJobResponse.Job.Output_.TransFeatures_.Merge>();
				for (int j = 0; j < context.Length("SearchJob.JobList["+ i +"].Output.TransFeatures.MergeList.Length"); j++) {
					SearchJobResponse.Job.Output_.TransFeatures_.Merge merge = new SearchJobResponse.Job.Output_.TransFeatures_.Merge();
					merge.MergeURL = context.StringValue("SearchJob.JobList["+ i +"].Output.TransFeatures.MergeList["+ j +"].MergeURL");
					merge.Start = context.StringValue("SearchJob.JobList["+ i +"].Output.TransFeatures.MergeList["+ j +"].Start");
					merge.Duration = context.StringValue("SearchJob.JobList["+ i +"].Output.TransFeatures.MergeList["+ j +"].Duration");

					mergeList.Add(merge);
				}
				transFeatures.MergeList = mergeList;
				output.TransFeatures = transFeatures;

				SearchJobResponse.Job.Output_.Audio_ audio = new SearchJobResponse.Job.Output_.Audio_();
				audio.Codec = context.StringValue("SearchJob.JobList["+ i +"].Output.Audio.Codec");
				audio.Profile = context.StringValue("SearchJob.JobList["+ i +"].Output.Audio.Profile");
				audio.Samplerate = context.StringValue("SearchJob.JobList["+ i +"].Output.Audio.Samplerate");
				audio.Bitrate = context.StringValue("SearchJob.JobList["+ i +"].Output.Audio.Bitrate");
				audio.Channels = context.StringValue("SearchJob.JobList["+ i +"].Output.Audio.Channels");
				audio.Qscale = context.StringValue("SearchJob.JobList["+ i +"].Output.Audio.Qscale");
				output.Audio = audio;

				SearchJobResponse.Job.Output_.Video_ video = new SearchJobResponse.Job.Output_.Video_();
				video.Codec = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.Codec");
				video.Profile = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.Profile");
				video.Bitrate = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.Bitrate");
				video.Crf = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.Crf");
				video.Width = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.Width");
				video.Height = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.Height");
				video.Fps = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.Fps");
				video.Gop = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.Gop");
				video.Preset = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.Preset");
				video.ScanMode = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.ScanMode");
				video.Bufsize = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.Bufsize");
				video.Maxrate = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.Maxrate");
				video.PixFmt = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.PixFmt");
				video.Degrain = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.Degrain");
				video.Qscale = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.Qscale");

				SearchJobResponse.Job.Output_.Video_.BitrateBnd_ bitrateBnd = new SearchJobResponse.Job.Output_.Video_.BitrateBnd_();
				bitrateBnd.Max = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("SearchJob.JobList["+ i +"].Output.Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				output.Video = video;

				SearchJobResponse.Job.Output_.Container_ container = new SearchJobResponse.Job.Output_.Container_();
				container.Format = context.StringValue("SearchJob.JobList["+ i +"].Output.Container.Format");
				output.Container = container;

				List<SearchJobResponse.Job.Output_.WaterMark> waterMarkList = new List<SearchJobResponse.Job.Output_.WaterMark>();
				for (int j = 0; j < context.Length("SearchJob.JobList["+ i +"].Output.WaterMarkList.Length"); j++) {
					SearchJobResponse.Job.Output_.WaterMark waterMark = new SearchJobResponse.Job.Output_.WaterMark();
					waterMark.WaterMarkTemplateId = context.StringValue("SearchJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].WaterMarkTemplateId");
					waterMark.Width = context.StringValue("SearchJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Width");
					waterMark.Height = context.StringValue("SearchJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Height");
					waterMark.Dx = context.StringValue("SearchJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dx");
					waterMark.Dy = context.StringValue("SearchJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Dy");
					waterMark.ReferPos = context.StringValue("SearchJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].ReferPos");
					waterMark.Type = context.StringValue("SearchJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].Type");

					SearchJobResponse.Job.Output_.WaterMark.InputFile_ inputFile = new SearchJobResponse.Job.Output_.WaterMark.InputFile_();
					inputFile.Bucket = context.StringValue("SearchJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Bucket");
					inputFile.Location = context.StringValue("SearchJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Location");
					inputFile.Object = context.StringValue("SearchJob.JobList["+ i +"].Output.WaterMarkList["+ j +"].InputFile.Object");
					waterMark.InputFile = inputFile;

					waterMarkList.Add(waterMark);
				}
				output.WaterMarkList = waterMarkList;
				job.Output = output;

				jobList.Add(job);
			}
			searchJobResponse.JobList = jobList;
        
			return searchJobResponse;
        }
    }
}