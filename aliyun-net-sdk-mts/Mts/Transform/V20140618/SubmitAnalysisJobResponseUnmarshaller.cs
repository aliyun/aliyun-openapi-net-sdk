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

			SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob analysisJob = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob();
			analysisJob.Id = context.StringValue("SubmitAnalysisJob.AnalysisJob.Id");
			analysisJob.UserData = context.StringValue("SubmitAnalysisJob.AnalysisJob.UserData");
			analysisJob.State = context.StringValue("SubmitAnalysisJob.AnalysisJob.State");
			analysisJob.Code = context.StringValue("SubmitAnalysisJob.AnalysisJob.Code");
			analysisJob.Message = context.StringValue("SubmitAnalysisJob.AnalysisJob.Message");
			analysisJob.Percent = context.LongValue("SubmitAnalysisJob.AnalysisJob.Percent");
			analysisJob.CreationTime = context.StringValue("SubmitAnalysisJob.AnalysisJob.CreationTime");
			analysisJob.PipelineId = context.StringValue("SubmitAnalysisJob.AnalysisJob.PipelineId");
			analysisJob.Priority = context.StringValue("SubmitAnalysisJob.AnalysisJob.Priority");

			SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_InputFile inputFile = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_InputFile();
			inputFile.Bucket = context.StringValue("SubmitAnalysisJob.AnalysisJob.InputFile.Bucket");
			inputFile.Location = context.StringValue("SubmitAnalysisJob.AnalysisJob.InputFile.Location");
			inputFile._Object = context.StringValue("SubmitAnalysisJob.AnalysisJob.InputFile.Object");
			analysisJob.InputFile = inputFile;

			SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_AnalysisConfig analysisConfig = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_AnalysisConfig();

			SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_AnalysisConfig.SubmitAnalysisJob_QualityControl qualityControl = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_AnalysisConfig.SubmitAnalysisJob_QualityControl();
			qualityControl.RateQuality = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.QualityControl.RateQuality");
			qualityControl.MethodStreaming = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.QualityControl.MethodStreaming");
			analysisConfig.QualityControl = qualityControl;

			SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_AnalysisConfig.SubmitAnalysisJob_PropertiesControl propertiesControl = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_AnalysisConfig.SubmitAnalysisJob_PropertiesControl();
			propertiesControl.Deinterlace = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Deinterlace");

			SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_AnalysisConfig.SubmitAnalysisJob_PropertiesControl.SubmitAnalysisJob_Crop crop = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_AnalysisConfig.SubmitAnalysisJob_PropertiesControl.SubmitAnalysisJob_Crop();
			crop.Mode = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Mode");
			crop.Width = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Width");
			crop.Height = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Height");
			crop.Top = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Top");
			crop.Left = context.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Left");
			propertiesControl.Crop = crop;
			analysisConfig.PropertiesControl = propertiesControl;
			analysisJob.AnalysisConfig = analysisConfig;

			SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_MNSMessageResult mNSMessageResult = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_MNSMessageResult();
			mNSMessageResult.MessageId = context.StringValue("SubmitAnalysisJob.AnalysisJob.MNSMessageResult.MessageId");
			mNSMessageResult.ErrorMessage = context.StringValue("SubmitAnalysisJob.AnalysisJob.MNSMessageResult.ErrorMessage");
			mNSMessageResult.ErrorCode = context.StringValue("SubmitAnalysisJob.AnalysisJob.MNSMessageResult.ErrorCode");
			analysisJob.MNSMessageResult = mNSMessageResult;

			List<SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template> analysisJob_templateList = new List<SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template>();
			for (int i = 0; i < context.Length("SubmitAnalysisJob.AnalysisJob.TemplateList.Length"); i++) {
				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template template = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template();
				template.Id = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Id");
				template.Name = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Name");
				template.State = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].State");

				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_Container container = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_Container();
				container.Format = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Container.Format");
				template.Container = container;

				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_Video video = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_Video();
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

				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_Video.SubmitAnalysisJob_BitrateBnd bitrateBnd = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_Video.SubmitAnalysisJob_BitrateBnd();
				bitrateBnd.Max = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				template.Video = video;

				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_Audio audio = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_Audio();
				audio.Codec = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Codec");
				audio.Profile = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Profile");
				audio.Samplerate = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Samplerate");
				audio.Bitrate = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Bitrate");
				audio.Channels = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Channels");
				audio.Qscale = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Qscale");
				template.Audio = audio;

				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_TransConfig transConfig = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_TransConfig();
				transConfig.TransMode = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].TransConfig.TransMode");
				template.TransConfig = transConfig;

				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_MuxConfig muxConfig = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_MuxConfig();

				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_MuxConfig.SubmitAnalysisJob_Segment segment = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_MuxConfig.SubmitAnalysisJob_Segment();
				segment.Duration = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_MuxConfig.SubmitAnalysisJob_Gif gif = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_MuxConfig.SubmitAnalysisJob_Gif();
				gif.Loop = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].MuxConfig.Gif.FinalDelay");
				muxConfig.Gif = gif;
				template.MuxConfig = muxConfig;

				analysisJob_templateList.Add(template);
			}
			analysisJob.TemplateList = analysisJob_templateList;
			submitAnalysisJobResponse.AnalysisJob = analysisJob;
        
			return submitAnalysisJobResponse;
        }
    }
}