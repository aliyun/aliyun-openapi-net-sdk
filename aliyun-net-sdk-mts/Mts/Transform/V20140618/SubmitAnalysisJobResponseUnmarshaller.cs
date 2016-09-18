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
    public class SubmitAnalysisJobResponseUnmarshaller
    {
        public static SubmitAnalysisJobResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitAnalysisJobResponse submitAnalysisJobResponse = new SubmitAnalysisJobResponse();

			submitAnalysisJobResponse.HttpResponse = context.HttpResponse;
			submitAnalysisJobResponse.RequestId = context.StringValue("SubmitAnalysisJob.RequestId");

			SubmitAnalysisJobResponse.AnalysisJob_ analysisJob = new SubmitAnalysisJobResponse.AnalysisJob_();
			analysisJob.Id = context.StringValue("SubmitAnalysisJob.AnalysisJob.Id");
			analysisJob.UserData = context.StringValue("SubmitAnalysisJob.AnalysisJob.UserData");
			analysisJob.State = context.StringValue("SubmitAnalysisJob.AnalysisJob.State");
			analysisJob.Code = context.StringValue("SubmitAnalysisJob.AnalysisJob.Code");
			analysisJob.Message = context.StringValue("SubmitAnalysisJob.AnalysisJob.Message");
			analysisJob.Percent = context.LongValue("SubmitAnalysisJob.AnalysisJob.Percent");
			analysisJob.CreationTime = context.StringValue("SubmitAnalysisJob.AnalysisJob.CreationTime");
			analysisJob.PipelineId = context.StringValue("SubmitAnalysisJob.AnalysisJob.PipelineId");
			analysisJob.Priority = context.StringValue("SubmitAnalysisJob.AnalysisJob.Priority");

			SubmitAnalysisJobResponse.AnalysisJob_.InputFile_ inputFile = new SubmitAnalysisJobResponse.AnalysisJob_.InputFile_();
			inputFile.Bucket = context.StringValue("SubmitAnalysisJob.AnalysisJob.InputFile.Bucket");
			inputFile.Location = context.StringValue("SubmitAnalysisJob.AnalysisJob.InputFile.Location");
			inputFile.Object = context.StringValue("SubmitAnalysisJob.AnalysisJob.InputFile.Object");
			analysisJob.InputFile = inputFile;

			SubmitAnalysisJobResponse.AnalysisJob_.AnalysisConfig_ analysisConfig = new SubmitAnalysisJobResponse.AnalysisJob_.AnalysisConfig_();

			SubmitAnalysisJobResponse.AnalysisJob_.AnalysisConfig_.QualityControl_ qualityControl = new SubmitAnalysisJobResponse.AnalysisJob_.AnalysisConfig_.QualityControl_();
			qualityControl.RateQuality = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.QualityControl.RateQuality");
			qualityControl.MethodStreaming = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.QualityControl.MethodStreaming");
			analysisConfig.QualityControl = qualityControl;

			SubmitAnalysisJobResponse.AnalysisJob_.AnalysisConfig_.PropertiesControl_ propertiesControl = new SubmitAnalysisJobResponse.AnalysisJob_.AnalysisConfig_.PropertiesControl_();
			propertiesControl.Deinterlace = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Deinterlace");

			SubmitAnalysisJobResponse.AnalysisJob_.AnalysisConfig_.PropertiesControl_.Crop_ crop = new SubmitAnalysisJobResponse.AnalysisJob_.AnalysisConfig_.PropertiesControl_.Crop_();
			crop.Mode = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Mode");
			crop.Width = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Width");
			crop.Height = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Height");
			crop.Top = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Top");
			crop.Left = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Left");
			propertiesControl.Crop = crop;
			analysisConfig.PropertiesControl = propertiesControl;
			analysisJob.AnalysisConfig = analysisConfig;

			SubmitAnalysisJobResponse.AnalysisJob_.MNSMessageResult_ mNSMessageResult = new SubmitAnalysisJobResponse.AnalysisJob_.MNSMessageResult_();
			mNSMessageResult.MessageId = context.StringValue("SubmitAnalysisJob.AnalysisJob.MNSMessageResult.MessageId");
			mNSMessageResult.ErrorMessage = context.StringValue("SubmitAnalysisJob.AnalysisJob.MNSMessageResult.ErrorMessage");
			mNSMessageResult.ErrorCode = context.StringValue("SubmitAnalysisJob.AnalysisJob.MNSMessageResult.ErrorCode");
			analysisJob.MNSMessageResult = mNSMessageResult;

			List<SubmitAnalysisJobResponse.AnalysisJob_.Template> templateList = new List<SubmitAnalysisJobResponse.AnalysisJob_.Template>();
			for (int i = 0; i < context.Length("SubmitAnalysisJob.AnalysisJob.TemplateList.Length"); i++) {
				SubmitAnalysisJobResponse.AnalysisJob_.Template template = new SubmitAnalysisJobResponse.AnalysisJob_.Template();
				template.Id = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Id");
				template.Name = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Name");
				template.State = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].State");

				SubmitAnalysisJobResponse.AnalysisJob_.Template.Container_ container = new SubmitAnalysisJobResponse.AnalysisJob_.Template.Container_();
				container.Format = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Container.Format");
				template.Container = container;

				SubmitAnalysisJobResponse.AnalysisJob_.Template.Video_ video = new SubmitAnalysisJobResponse.AnalysisJob_.Template.Video_();
				video.Codec = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Codec");
				video.Profile = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Profile");
				video.Bitrate = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Bitrate");
				video.Crf = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Crf");
				video.Width = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Width");
				video.Height = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Height");
				video.Fps = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Fps");
				video.Gop = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Gop");
				video.Preset = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Preset");
				video.ScanMode = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.ScanMode");
				video.Bufsize = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Bufsize");
				video.Maxrate = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Maxrate");
				video.PixFmt = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.PixFmt");
				video.Degrain = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Degrain");
				video.Qscale = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Qscale");

				SubmitAnalysisJobResponse.AnalysisJob_.Template.Video_.BitrateBnd_ bitrateBnd = new SubmitAnalysisJobResponse.AnalysisJob_.Template.Video_.BitrateBnd_();
				bitrateBnd.Max = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				template.Video = video;

				SubmitAnalysisJobResponse.AnalysisJob_.Template.Audio_ audio = new SubmitAnalysisJobResponse.AnalysisJob_.Template.Audio_();
				audio.Codec = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Codec");
				audio.Profile = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Profile");
				audio.Samplerate = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Samplerate");
				audio.Bitrate = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Bitrate");
				audio.Channels = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Channels");
				audio.Qscale = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Qscale");
				template.Audio = audio;

				SubmitAnalysisJobResponse.AnalysisJob_.Template.TransConfig_ transConfig = new SubmitAnalysisJobResponse.AnalysisJob_.Template.TransConfig_();
				transConfig.TransMode = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].TransConfig.TransMode");
				template.TransConfig = transConfig;

				SubmitAnalysisJobResponse.AnalysisJob_.Template.MuxConfig_ muxConfig = new SubmitAnalysisJobResponse.AnalysisJob_.Template.MuxConfig_();

				SubmitAnalysisJobResponse.AnalysisJob_.Template.MuxConfig_.Segment_ segment = new SubmitAnalysisJobResponse.AnalysisJob_.Template.MuxConfig_.Segment_();
				segment.Duration = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				SubmitAnalysisJobResponse.AnalysisJob_.Template.MuxConfig_.Gif_ gif = new SubmitAnalysisJobResponse.AnalysisJob_.Template.MuxConfig_.Gif_();
				gif.Loop = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].MuxConfig.Gif.FinalDelay");
				muxConfig.Gif = gif;
				template.MuxConfig = muxConfig;

				templateList.Add(template);
			}
			analysisJob.TemplateList = templateList;
			submitAnalysisJobResponse.AnalysisJob = analysisJob;
        
			return submitAnalysisJobResponse;
        }
    }
}