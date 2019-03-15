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
    public class QueryVideoPoseJobListResponseUnmarshaller
    {
        public static QueryVideoPoseJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryVideoPoseJobListResponse queryVideoPoseJobListResponse = new QueryVideoPoseJobListResponse();

			queryVideoPoseJobListResponse.HttpResponse = context.HttpResponse;
			queryVideoPoseJobListResponse.RequestId = context.StringValue("QueryVideoPoseJobList.RequestId");

			List<string> queryVideoPoseJobListResponse_nonExistJobIds = new List<string>();
			for (int i = 0; i < context.Length("QueryVideoPoseJobList.NonExistJobIds.Length"); i++) {
				queryVideoPoseJobListResponse_nonExistJobIds.Add(context.StringValue("QueryVideoPoseJobList.NonExistJobIds["+ i +"]"));
			}
			queryVideoPoseJobListResponse.NonExistJobIds = queryVideoPoseJobListResponse_nonExistJobIds;

			List<QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job> queryVideoPoseJobListResponse_jobList = new List<QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job>();
			for (int i = 0; i < context.Length("QueryVideoPoseJobList.JobList.Length"); i++) {
				QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job job = new QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job();
				job.JobId = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].JobId");
				job.PipelineId = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].PipelineId");
				job.UserData = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].UserData");
				job.State = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].State");

				QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Input input = new QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Input();
				input.Bucket = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Input.Object");
				input.RoleArn = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Input.RoleArn");
				job.Input = input;

				QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_OutputConfig outputConfig = new QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_OutputConfig();

				QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_OutputConfig.QueryVideoPoseJobList_VideoFile videoFile = new QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_OutputConfig.QueryVideoPoseJobList_VideoFile();
				videoFile.Bucket = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].OutputConfig.VideoFile.Bucket");
				videoFile.Location = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].OutputConfig.VideoFile.Location");
				videoFile._Object = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].OutputConfig.VideoFile.Object");
				videoFile.RoleArn = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].OutputConfig.VideoFile.RoleArn");
				outputConfig.VideoFile = videoFile;

				QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_OutputConfig.QueryVideoPoseJobList_DataFile dataFile = new QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_OutputConfig.QueryVideoPoseJobList_DataFile();
				dataFile.Bucket = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].OutputConfig.DataFile.Bucket");
				dataFile.Location = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].OutputConfig.DataFile.Location");
				dataFile._Object = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].OutputConfig.DataFile.Object");
				dataFile.RoleArn = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].OutputConfig.DataFile.RoleArn");
				outputConfig.DataFile = dataFile;
				job.OutputConfig = outputConfig;

				QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties properties = new QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties();
				properties.Width = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Width");
				properties.Height = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Height");
				properties.Bitrate = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Bitrate");
				properties.Duration = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Duration");
				properties.Fps = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Fps");
				properties.FileSize = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.FileSize");
				properties.FileFormat = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.FileFormat");

				QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Streams streams = new QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Streams();

				List<QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Streams.QueryVideoPoseJobList_VideoStream> streams_videoStreamList = new List<QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Streams.QueryVideoPoseJobList_VideoStream>();
				for (int j = 0; j < context.Length("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList.Length"); j++) {
					QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Streams.QueryVideoPoseJobList_VideoStream videoStream = new QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Streams.QueryVideoPoseJobList_VideoStream();
					videoStream.Index = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Index");
					videoStream.CodecName = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecName");
					videoStream.CodecLongName = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecLongName");
					videoStream.Profile = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Profile");
					videoStream.CodecTimeBase = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecTimeBase");
					videoStream.CodecTagString = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecTagString");
					videoStream.CodecTag = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].CodecTag");
					videoStream.Width = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Width");
					videoStream.Height = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Height");
					videoStream.HasBFrames = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].HasBFrames");
					videoStream.Sar = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Sar");
					videoStream.Dar = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Dar");
					videoStream.PixFmt = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].PixFmt");
					videoStream.Level = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Level");
					videoStream.Fps = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Fps");
					videoStream.AvgFPS = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].AvgFPS");
					videoStream.Timebase = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Timebase");
					videoStream.StartTime = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].StartTime");
					videoStream.Duration = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Duration");
					videoStream.Bitrate = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Bitrate");
					videoStream.NumFrames = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].NumFrames");
					videoStream.Lang = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Lang");
					videoStream.Rotate = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].Rotate");

					QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Streams.QueryVideoPoseJobList_VideoStream.QueryVideoPoseJobList_NetworkCost networkCost = new QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Streams.QueryVideoPoseJobList_VideoStream.QueryVideoPoseJobList_NetworkCost();
					networkCost.PreloadTime = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].NetworkCost.PreloadTime");
					networkCost.CostBandwidth = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].NetworkCost.CostBandwidth");
					networkCost.AvgBitrate = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.VideoStreamList["+ j +"].NetworkCost.AvgBitrate");
					videoStream.NetworkCost = networkCost;

					streams_videoStreamList.Add(videoStream);
				}
				streams.VideoStreamList = streams_videoStreamList;

				List<QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Streams.QueryVideoPoseJobList_AudioStream> streams_audioStreamList = new List<QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Streams.QueryVideoPoseJobList_AudioStream>();
				for (int j = 0; j < context.Length("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList.Length"); j++) {
					QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Streams.QueryVideoPoseJobList_AudioStream audioStream = new QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Streams.QueryVideoPoseJobList_AudioStream();
					audioStream.Index = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Index");
					audioStream.CodecName = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecName");
					audioStream.CodecTimeBase = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecTimeBase");
					audioStream.CodecLongName = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecLongName");
					audioStream.CodecTagString = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecTagString");
					audioStream.CodecTag = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].CodecTag");
					audioStream.SampleFmt = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].SampleFmt");
					audioStream.Samplerate = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Samplerate");
					audioStream.Channels = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Channels");
					audioStream.ChannelLayout = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].ChannelLayout");
					audioStream.Timebase = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Timebase");
					audioStream.StartTime = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].StartTime");
					audioStream.Duration = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Duration");
					audioStream.Bitrate = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Bitrate");
					audioStream.NumFrames = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].NumFrames");
					audioStream.Lang = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.AudioStreamList["+ j +"].Lang");

					streams_audioStreamList.Add(audioStream);
				}
				streams.AudioStreamList = streams_audioStreamList;

				List<QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Streams.QueryVideoPoseJobList_SubtitleStream> streams_subtitleStreamList = new List<QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Streams.QueryVideoPoseJobList_SubtitleStream>();
				for (int j = 0; j < context.Length("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.SubtitleStreamList.Length"); j++) {
					QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Streams.QueryVideoPoseJobList_SubtitleStream subtitleStream = new QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Streams.QueryVideoPoseJobList_SubtitleStream();
					subtitleStream.Index = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].Index");
					subtitleStream.CodecName = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].CodecName");
					subtitleStream.CodecTimeBase = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].CodecTimeBase");
					subtitleStream.CodecLongName = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].CodecLongName");
					subtitleStream.CodecTagString = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].CodecTagString");
					subtitleStream.CodecTag = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].CodecTag");
					subtitleStream.Timebase = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].Timebase");
					subtitleStream.StartTime = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].StartTime");
					subtitleStream.Duration = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].Duration");
					subtitleStream.Lang = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Streams.SubtitleStreamList["+ j +"].Lang");

					streams_subtitleStreamList.Add(subtitleStream);
				}
				streams.SubtitleStreamList = streams_subtitleStreamList;
				properties.Streams = streams;

				QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Format format = new QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_Properties.QueryVideoPoseJobList_Format();
				format.NumStreams = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Format.NumStreams");
				format.NumPrograms = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Format.NumPrograms");
				format.FormatName = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Format.FormatName");
				format.FormatLongName = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Format.FormatLongName");
				format.StartTime = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Format.StartTime");
				format.Duration = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Format.Duration");
				format.Size = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Format.Size");
				format.Bitrate = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].Properties.Format.Bitrate");
				properties.Format = format;
				job.Properties = properties;

				QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_MNSMessageResult mNSMessageResult = new QueryVideoPoseJobListResponse.QueryVideoPoseJobList_Job.QueryVideoPoseJobList_MNSMessageResult();
				mNSMessageResult.MessageId = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = context.StringValue("QueryVideoPoseJobList.JobList["+ i +"].MNSMessageResult.ErrorCode");
				job.MNSMessageResult = mNSMessageResult;

				queryVideoPoseJobListResponse_jobList.Add(job);
			}
			queryVideoPoseJobListResponse.JobList = queryVideoPoseJobListResponse_jobList;
        
			return queryVideoPoseJobListResponse;
        }
    }
}
