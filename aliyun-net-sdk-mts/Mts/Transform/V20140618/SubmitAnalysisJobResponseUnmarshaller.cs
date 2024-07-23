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
    public class SubmitAnalysisJobResponseUnmarshaller
    {
        public static SubmitAnalysisJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitAnalysisJobResponse submitAnalysisJobResponse = new SubmitAnalysisJobResponse();

			submitAnalysisJobResponse.HttpResponse = _ctx.HttpResponse;
			submitAnalysisJobResponse.RequestId = _ctx.StringValue("SubmitAnalysisJob.RequestId");

			SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob analysisJob = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob();
			analysisJob.CreationTime = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.CreationTime");
			analysisJob.Percent = _ctx.LongValue("SubmitAnalysisJob.AnalysisJob.Percent");
			analysisJob.State = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.State");
			analysisJob.Message = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.Message");
			analysisJob.Priority = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.Priority");
			analysisJob.UserData = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.UserData");
			analysisJob.Code = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.Code");
			analysisJob.PipelineId = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.PipelineId");
			analysisJob.Id = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.Id");

			SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_AnalysisConfig analysisConfig = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_AnalysisConfig();

			SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_AnalysisConfig.SubmitAnalysisJob_QualityControl qualityControl = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_AnalysisConfig.SubmitAnalysisJob_QualityControl();
			qualityControl.MethodStreaming = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.QualityControl.MethodStreaming");
			qualityControl.RateQuality = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.QualityControl.RateQuality");
			analysisConfig.QualityControl = qualityControl;

			SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_AnalysisConfig.SubmitAnalysisJob_PropertiesControl propertiesControl = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_AnalysisConfig.SubmitAnalysisJob_PropertiesControl();
			propertiesControl.Deinterlace = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Deinterlace");

			SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_AnalysisConfig.SubmitAnalysisJob_PropertiesControl.SubmitAnalysisJob_Crop crop = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_AnalysisConfig.SubmitAnalysisJob_PropertiesControl.SubmitAnalysisJob_Crop();
			crop.Top = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Top");
			crop.Width = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Width");
			crop.Height = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Height");
			crop.Left = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Left");
			crop.Mode = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.AnalysisConfig.PropertiesControl.Crop.Mode");
			propertiesControl.Crop = crop;
			analysisConfig.PropertiesControl = propertiesControl;
			analysisJob.AnalysisConfig = analysisConfig;

			SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_MNSMessageResult mNSMessageResult = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_MNSMessageResult();
			mNSMessageResult.MessageId = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.MNSMessageResult.MessageId");
			mNSMessageResult.ErrorMessage = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.MNSMessageResult.ErrorMessage");
			mNSMessageResult.ErrorCode = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.MNSMessageResult.ErrorCode");
			analysisJob.MNSMessageResult = mNSMessageResult;

			SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_InputFile inputFile = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_InputFile();
			inputFile._Object = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.InputFile.Object");
			inputFile.Location = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.InputFile.Location");
			inputFile.Bucket = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.InputFile.Bucket");
			analysisJob.InputFile = inputFile;

			List<SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template> analysisJob_templateList = new List<SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template>();
			for (int i = 0; i < _ctx.Length("SubmitAnalysisJob.AnalysisJob.TemplateList.Length"); i++) {
				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template template = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template();
				template.State = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].State");
				template.Name = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Name");
				template.Id = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Id");

				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_Video video = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_Video();
				video.Bufsize = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Bufsize");
				video.Degrain = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Degrain");
				video.PixFmt = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.PixFmt");
				video.Codec = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Codec");
				video.Height = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Height");
				video.Qscale = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Qscale");
				video.Bitrate = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Bitrate");
				video.Maxrate = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Maxrate");
				video.Profile = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Profile");
				video.Crf = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Crf");
				video.Gop = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Gop");
				video.Width = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Width");
				video.Fps = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Fps");
				video.Preset = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.Preset");
				video.ScanMode = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.ScanMode");

				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_Video.SubmitAnalysisJob_BitrateBnd bitrateBnd = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_Video.SubmitAnalysisJob_BitrateBnd();
				bitrateBnd.Max = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.BitrateBnd.Max");
				bitrateBnd.Min = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				template.Video = video;

				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_TransConfig transConfig = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_TransConfig();
				transConfig.TransMode = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].TransConfig.TransMode");
				template.TransConfig = transConfig;

				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_MuxConfig muxConfig = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_MuxConfig();

				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_MuxConfig.SubmitAnalysisJob_Gif gif = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_MuxConfig.SubmitAnalysisJob_Gif();
				gif.FinalDelay = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].MuxConfig.Gif.FinalDelay");
				gif.Loop = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].MuxConfig.Gif.Loop");
				muxConfig.Gif = gif;

				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_MuxConfig.SubmitAnalysisJob_Segment segment = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_MuxConfig.SubmitAnalysisJob_Segment();
				segment.Duration = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;
				template.MuxConfig = muxConfig;

				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_Audio audio = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_Audio();
				audio.Profile = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Profile");
				audio.Codec = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Codec");
				audio.Samplerate = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Samplerate");
				audio.Qscale = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Qscale");
				audio.Channels = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Channels");
				audio.Bitrate = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Audio.Bitrate");
				template.Audio = audio;

				SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_Container container = new SubmitAnalysisJobResponse.SubmitAnalysisJob_AnalysisJob.SubmitAnalysisJob_Template.SubmitAnalysisJob_Container();
				container.Format = _ctx.StringValue("SubmitAnalysisJob.AnalysisJob.TemplateList["+ i +"].Container.Format");
				template.Container = container;

				analysisJob_templateList.Add(template);
			}
			analysisJob.TemplateList = analysisJob_templateList;
			submitAnalysisJobResponse.AnalysisJob = analysisJob;
        
			return submitAnalysisJobResponse;
        }
    }
}
