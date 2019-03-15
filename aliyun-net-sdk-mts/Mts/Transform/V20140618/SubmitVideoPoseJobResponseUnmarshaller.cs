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
    public class SubmitVideoPoseJobResponseUnmarshaller
    {
        public static SubmitVideoPoseJobResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitVideoPoseJobResponse submitVideoPoseJobResponse = new SubmitVideoPoseJobResponse();

			submitVideoPoseJobResponse.HttpResponse = context.HttpResponse;
			submitVideoPoseJobResponse.RequestId = context.StringValue("SubmitVideoPoseJob.RequestId");

			SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob videoPoseJob = new SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob();
			videoPoseJob.JobId = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.JobId");
			videoPoseJob.PipelineId = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.PipelineId");
			videoPoseJob.UserData = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.UserData");
			videoPoseJob.State = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.State");

			SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Input input = new SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Input();
			input.Bucket = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Input.Bucket");
			input.Location = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Input.Location");
			input._Object = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Input.Object");
			input.RoleArn = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Input.RoleArn");
			videoPoseJob.Input = input;

			SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_OutputConfig outputConfig = new SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_OutputConfig();

			SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_OutputConfig.SubmitVideoPoseJob_VideoFile videoFile = new SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_OutputConfig.SubmitVideoPoseJob_VideoFile();
			videoFile.Bucket = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.OutputConfig.VideoFile.Bucket");
			videoFile.Location = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.OutputConfig.VideoFile.Location");
			videoFile._Object = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.OutputConfig.VideoFile.Object");
			videoFile.RoleArn = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.OutputConfig.VideoFile.RoleArn");
			outputConfig.VideoFile = videoFile;

			SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_OutputConfig.SubmitVideoPoseJob_DataFile dataFile = new SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_OutputConfig.SubmitVideoPoseJob_DataFile();
			dataFile.Bucket = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.OutputConfig.DataFile.Bucket");
			dataFile.Location = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.OutputConfig.DataFile.Location");
			dataFile._Object = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.OutputConfig.DataFile.Object");
			dataFile.RoleArn = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.OutputConfig.DataFile.RoleArn");
			outputConfig.DataFile = dataFile;
			videoPoseJob.OutputConfig = outputConfig;

			SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties properties = new SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties();
			properties.Width = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Width");
			properties.Height = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Height");
			properties.Bitrate = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Bitrate");
			properties.Duration = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Duration");
			properties.Fps = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Fps");
			properties.FileSize = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.FileSize");
			properties.FileFormat = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.FileFormat");

			SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Streams streams = new SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Streams();

			List<SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Streams.SubmitVideoPoseJob_VideoStream> streams_videoStreamList = new List<SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Streams.SubmitVideoPoseJob_VideoStream>();
			for (int i = 0; i < context.Length("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList.Length"); i++) {
				SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Streams.SubmitVideoPoseJob_VideoStream videoStream = new SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Streams.SubmitVideoPoseJob_VideoStream();
				videoStream.Index = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].Index");
				videoStream.CodecName = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].CodecName");
				videoStream.CodecLongName = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].CodecLongName");
				videoStream.Profile = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].Profile");
				videoStream.CodecTimeBase = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].CodecTimeBase");
				videoStream.CodecTagString = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].CodecTagString");
				videoStream.CodecTag = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].CodecTag");
				videoStream.Width = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].Width");
				videoStream.Height = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].Height");
				videoStream.HasBFrames = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].HasBFrames");
				videoStream.Sar = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].Sar");
				videoStream.Dar = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].Dar");
				videoStream.PixFmt = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].PixFmt");
				videoStream.Level = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].Level");
				videoStream.Fps = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].Fps");
				videoStream.AvgFPS = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].AvgFPS");
				videoStream.Timebase = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].Timebase");
				videoStream.StartTime = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].StartTime");
				videoStream.Duration = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].Duration");
				videoStream.Bitrate = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].Bitrate");
				videoStream.NumFrames = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].NumFrames");
				videoStream.Lang = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].Lang");
				videoStream.Rotate = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].Rotate");

				SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Streams.SubmitVideoPoseJob_VideoStream.SubmitVideoPoseJob_NetworkCost networkCost = new SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Streams.SubmitVideoPoseJob_VideoStream.SubmitVideoPoseJob_NetworkCost();
				networkCost.PreloadTime = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.PreloadTime");
				networkCost.CostBandwidth = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.CostBandwidth");
				networkCost.AvgBitrate = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.VideoStreamList["+ i +"].NetworkCost.AvgBitrate");
				videoStream.NetworkCost = networkCost;

				streams_videoStreamList.Add(videoStream);
			}
			streams.VideoStreamList = streams_videoStreamList;

			List<SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Streams.SubmitVideoPoseJob_AudioStream> streams_audioStreamList = new List<SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Streams.SubmitVideoPoseJob_AudioStream>();
			for (int i = 0; i < context.Length("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList.Length"); i++) {
				SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Streams.SubmitVideoPoseJob_AudioStream audioStream = new SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Streams.SubmitVideoPoseJob_AudioStream();
				audioStream.Index = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList["+ i +"].Index");
				audioStream.CodecName = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList["+ i +"].CodecName");
				audioStream.CodecTimeBase = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList["+ i +"].CodecTimeBase");
				audioStream.CodecLongName = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList["+ i +"].CodecLongName");
				audioStream.CodecTagString = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList["+ i +"].CodecTagString");
				audioStream.CodecTag = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList["+ i +"].CodecTag");
				audioStream.SampleFmt = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList["+ i +"].SampleFmt");
				audioStream.Samplerate = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList["+ i +"].Samplerate");
				audioStream.Channels = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList["+ i +"].Channels");
				audioStream.ChannelLayout = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList["+ i +"].ChannelLayout");
				audioStream.Timebase = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList["+ i +"].Timebase");
				audioStream.StartTime = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList["+ i +"].StartTime");
				audioStream.Duration = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList["+ i +"].Duration");
				audioStream.Bitrate = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList["+ i +"].Bitrate");
				audioStream.NumFrames = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList["+ i +"].NumFrames");
				audioStream.Lang = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.AudioStreamList["+ i +"].Lang");

				streams_audioStreamList.Add(audioStream);
			}
			streams.AudioStreamList = streams_audioStreamList;

			List<SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Streams.SubmitVideoPoseJob_SubtitleStream> streams_subtitleStreamList = new List<SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Streams.SubmitVideoPoseJob_SubtitleStream>();
			for (int i = 0; i < context.Length("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.SubtitleStreamList.Length"); i++) {
				SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Streams.SubmitVideoPoseJob_SubtitleStream subtitleStream = new SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Streams.SubmitVideoPoseJob_SubtitleStream();
				subtitleStream.Index = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.SubtitleStreamList["+ i +"].Index");
				subtitleStream.CodecName = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.SubtitleStreamList["+ i +"].CodecName");
				subtitleStream.CodecTimeBase = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.SubtitleStreamList["+ i +"].CodecTimeBase");
				subtitleStream.CodecLongName = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.SubtitleStreamList["+ i +"].CodecLongName");
				subtitleStream.CodecTagString = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.SubtitleStreamList["+ i +"].CodecTagString");
				subtitleStream.CodecTag = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.SubtitleStreamList["+ i +"].CodecTag");
				subtitleStream.Timebase = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.SubtitleStreamList["+ i +"].Timebase");
				subtitleStream.StartTime = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.SubtitleStreamList["+ i +"].StartTime");
				subtitleStream.Duration = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.SubtitleStreamList["+ i +"].Duration");
				subtitleStream.Lang = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Streams.SubtitleStreamList["+ i +"].Lang");

				streams_subtitleStreamList.Add(subtitleStream);
			}
			streams.SubtitleStreamList = streams_subtitleStreamList;
			properties.Streams = streams;

			SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Format format = new SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_Properties.SubmitVideoPoseJob_Format();
			format.NumStreams = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Format.NumStreams");
			format.NumPrograms = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Format.NumPrograms");
			format.FormatName = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Format.FormatName");
			format.FormatLongName = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Format.FormatLongName");
			format.StartTime = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Format.StartTime");
			format.Duration = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Format.Duration");
			format.Size = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Format.Size");
			format.Bitrate = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.Properties.Format.Bitrate");
			properties.Format = format;
			videoPoseJob.Properties = properties;

			SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_MNSMessageResult mNSMessageResult = new SubmitVideoPoseJobResponse.SubmitVideoPoseJob_VideoPoseJob.SubmitVideoPoseJob_MNSMessageResult();
			mNSMessageResult.MessageId = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.MNSMessageResult.MessageId");
			mNSMessageResult.ErrorMessage = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.MNSMessageResult.ErrorMessage");
			mNSMessageResult.ErrorCode = context.StringValue("SubmitVideoPoseJob.VideoPoseJob.MNSMessageResult.ErrorCode");
			videoPoseJob.MNSMessageResult = mNSMessageResult;
			submitVideoPoseJobResponse.VideoPoseJob = videoPoseJob;
        
			return submitVideoPoseJobResponse;
        }
    }
}
