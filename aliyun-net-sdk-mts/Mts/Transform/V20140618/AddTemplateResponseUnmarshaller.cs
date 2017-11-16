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
    public class AddTemplateResponseUnmarshaller
    {
        public static AddTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			AddTemplateResponse addTemplateResponse = new AddTemplateResponse();

			addTemplateResponse.HttpResponse = context.HttpResponse;
			addTemplateResponse.RequestId = context.StringValue("AddTemplate.RequestId");

			AddTemplateResponse.AddTemplate_Template template = new AddTemplateResponse.AddTemplate_Template();
			template.Id = context.StringValue("AddTemplate.Template.Id");
			template.Name = context.StringValue("AddTemplate.Template.Name");
			template.State = context.StringValue("AddTemplate.Template.State");

			AddTemplateResponse.AddTemplate_Template.AddTemplate_Container container = new AddTemplateResponse.AddTemplate_Template.AddTemplate_Container();
			container.Format = context.StringValue("AddTemplate.Template.Container.Format");
			template.Container = container;

			AddTemplateResponse.AddTemplate_Template.AddTemplate_Video video = new AddTemplateResponse.AddTemplate_Template.AddTemplate_Video();
			video.Codec = context.StringValue("AddTemplate.Template.Video.Codec");
			video.Profile = context.StringValue("AddTemplate.Template.Video.Profile");
			video.Bitrate = context.StringValue("AddTemplate.Template.Video.Bitrate");
			video.Crf = context.StringValue("AddTemplate.Template.Video.Crf");
			video.Width = context.StringValue("AddTemplate.Template.Video.Width");
			video.Height = context.StringValue("AddTemplate.Template.Video.Height");
			video.Fps = context.StringValue("AddTemplate.Template.Video.Fps");
			video.Gop = context.StringValue("AddTemplate.Template.Video.Gop");
			video.Preset = context.StringValue("AddTemplate.Template.Video.Preset");
			video.ScanMode = context.StringValue("AddTemplate.Template.Video.ScanMode");
			video.Bufsize = context.StringValue("AddTemplate.Template.Video.Bufsize");
			video.Maxrate = context.StringValue("AddTemplate.Template.Video.Maxrate");
			video.PixFmt = context.StringValue("AddTemplate.Template.Video.PixFmt");
			video.Degrain = context.StringValue("AddTemplate.Template.Video.Degrain");
			video.Qscale = context.StringValue("AddTemplate.Template.Video.Qscale");
			video._Remove = context.StringValue("AddTemplate.Template.Video.Remove");
			video.Crop = context.StringValue("AddTemplate.Template.Video.Crop");
			video.Pad = context.StringValue("AddTemplate.Template.Video.Pad");
			video.MaxFps = context.StringValue("AddTemplate.Template.Video.MaxFps");

			AddTemplateResponse.AddTemplate_Template.AddTemplate_Video.AddTemplate_BitrateBnd bitrateBnd = new AddTemplateResponse.AddTemplate_Template.AddTemplate_Video.AddTemplate_BitrateBnd();
			bitrateBnd.Max = context.StringValue("AddTemplate.Template.Video.BitrateBnd.Max");
			bitrateBnd.Min = context.StringValue("AddTemplate.Template.Video.BitrateBnd.Min");
			video.BitrateBnd = bitrateBnd;
			template.Video = video;

			AddTemplateResponse.AddTemplate_Template.AddTemplate_Audio audio = new AddTemplateResponse.AddTemplate_Template.AddTemplate_Audio();
			audio.Codec = context.StringValue("AddTemplate.Template.Audio.Codec");
			audio.Profile = context.StringValue("AddTemplate.Template.Audio.Profile");
			audio.Samplerate = context.StringValue("AddTemplate.Template.Audio.Samplerate");
			audio.Bitrate = context.StringValue("AddTemplate.Template.Audio.Bitrate");
			audio.Channels = context.StringValue("AddTemplate.Template.Audio.Channels");
			audio.Qscale = context.StringValue("AddTemplate.Template.Audio.Qscale");
			audio._Remove = context.StringValue("AddTemplate.Template.Audio.Remove");

			AddTemplateResponse.AddTemplate_Template.AddTemplate_Audio.AddTemplate_Volume volume = new AddTemplateResponse.AddTemplate_Template.AddTemplate_Audio.AddTemplate_Volume();
			volume.Level = context.StringValue("AddTemplate.Template.Audio.Volume.Level");
			volume.Method = context.StringValue("AddTemplate.Template.Audio.Volume.Method");
			audio.Volume = volume;
			template.Audio = audio;

			AddTemplateResponse.AddTemplate_Template.AddTemplate_TransConfig transConfig = new AddTemplateResponse.AddTemplate_Template.AddTemplate_TransConfig();
			transConfig.TransMode = context.StringValue("AddTemplate.Template.TransConfig.TransMode");
			transConfig.IsCheckReso = context.StringValue("AddTemplate.Template.TransConfig.IsCheckReso");
			transConfig.IsCheckResoFail = context.StringValue("AddTemplate.Template.TransConfig.IsCheckResoFail");
			transConfig.IsCheckVideoBitrate = context.StringValue("AddTemplate.Template.TransConfig.IsCheckVideoBitrate");
			transConfig.IsCheckAudioBitrate = context.StringValue("AddTemplate.Template.TransConfig.IsCheckAudioBitrate");
			transConfig.AdjDarMethod = context.StringValue("AddTemplate.Template.TransConfig.AdjDarMethod");
			transConfig.IsCheckVideoBitrateFail = context.StringValue("AddTemplate.Template.TransConfig.IsCheckVideoBitrateFail");
			transConfig.IsCheckAudioBitrateFail = context.StringValue("AddTemplate.Template.TransConfig.IsCheckAudioBitrateFail");
			template.TransConfig = transConfig;

			AddTemplateResponse.AddTemplate_Template.AddTemplate_MuxConfig muxConfig = new AddTemplateResponse.AddTemplate_Template.AddTemplate_MuxConfig();

			AddTemplateResponse.AddTemplate_Template.AddTemplate_MuxConfig.AddTemplate_Segment segment = new AddTemplateResponse.AddTemplate_Template.AddTemplate_MuxConfig.AddTemplate_Segment();
			segment.Duration = context.StringValue("AddTemplate.Template.MuxConfig.Segment.Duration");
			muxConfig.Segment = segment;

			AddTemplateResponse.AddTemplate_Template.AddTemplate_MuxConfig.AddTemplate_Gif gif = new AddTemplateResponse.AddTemplate_Template.AddTemplate_MuxConfig.AddTemplate_Gif();
			gif.Loop = context.StringValue("AddTemplate.Template.MuxConfig.Gif.Loop");
			gif.FinalDelay = context.StringValue("AddTemplate.Template.MuxConfig.Gif.FinalDelay");
			gif.IsCustomPalette = context.StringValue("AddTemplate.Template.MuxConfig.Gif.IsCustomPalette");
			gif.DitherMode = context.StringValue("AddTemplate.Template.MuxConfig.Gif.DitherMode");
			muxConfig.Gif = gif;
			template.MuxConfig = muxConfig;
			addTemplateResponse.Template = template;
        
			return addTemplateResponse;
        }
    }
}