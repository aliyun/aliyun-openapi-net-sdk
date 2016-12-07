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

			AddTemplateResponse.Template_ template = new AddTemplateResponse.Template_();
			template.Id = context.StringValue("AddTemplate.Template.Id");
			template.Name = context.StringValue("AddTemplate.Template.Name");
			template.State = context.StringValue("AddTemplate.Template.State");

			AddTemplateResponse.Template_.Container_ container = new AddTemplateResponse.Template_.Container_();
			container.Format = context.StringValue("AddTemplate.Template.Container.Format");
			template.Container = container;

			AddTemplateResponse.Template_.Video_ video = new AddTemplateResponse.Template_.Video_();
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
			video.Remove = context.StringValue("AddTemplate.Template.Video.Remove");
			video.Crop = context.StringValue("AddTemplate.Template.Video.Crop");
			video.Pad = context.StringValue("AddTemplate.Template.Video.Pad");
			video.MaxFps = context.StringValue("AddTemplate.Template.Video.MaxFps");

			AddTemplateResponse.Template_.Video_.BitrateBnd_ bitrateBnd = new AddTemplateResponse.Template_.Video_.BitrateBnd_();
			bitrateBnd.Max = context.StringValue("AddTemplate.Template.Video.BitrateBnd.Max");
			bitrateBnd.Min = context.StringValue("AddTemplate.Template.Video.BitrateBnd.Min");
			video.BitrateBnd = bitrateBnd;
			template.Video = video;

			AddTemplateResponse.Template_.Audio_ audio = new AddTemplateResponse.Template_.Audio_();
			audio.Codec = context.StringValue("AddTemplate.Template.Audio.Codec");
			audio.Profile = context.StringValue("AddTemplate.Template.Audio.Profile");
			audio.Samplerate = context.StringValue("AddTemplate.Template.Audio.Samplerate");
			audio.Bitrate = context.StringValue("AddTemplate.Template.Audio.Bitrate");
			audio.Channels = context.StringValue("AddTemplate.Template.Audio.Channels");
			audio.Qscale = context.StringValue("AddTemplate.Template.Audio.Qscale");
			audio.Remove = context.StringValue("AddTemplate.Template.Audio.Remove");
			template.Audio = audio;

			AddTemplateResponse.Template_.TransConfig_ transConfig = new AddTemplateResponse.Template_.TransConfig_();
			transConfig.TransMode = context.StringValue("AddTemplate.Template.TransConfig.TransMode");
			transConfig.IsCheckReso = context.StringValue("AddTemplate.Template.TransConfig.IsCheckReso");
			transConfig.IsCheckResoFail = context.StringValue("AddTemplate.Template.TransConfig.IsCheckResoFail");
			transConfig.IsCheckVideoBitrate = context.StringValue("AddTemplate.Template.TransConfig.IsCheckVideoBitrate");
			transConfig.IsCheckAudioBitrate = context.StringValue("AddTemplate.Template.TransConfig.IsCheckAudioBitrate");
			transConfig.AdjDarMethod = context.StringValue("AddTemplate.Template.TransConfig.AdjDarMethod");
			template.TransConfig = transConfig;

			AddTemplateResponse.Template_.MuxConfig_ muxConfig = new AddTemplateResponse.Template_.MuxConfig_();

			AddTemplateResponse.Template_.MuxConfig_.Segment_ segment = new AddTemplateResponse.Template_.MuxConfig_.Segment_();
			segment.Duration = context.StringValue("AddTemplate.Template.MuxConfig.Segment.Duration");
			muxConfig.Segment = segment;

			AddTemplateResponse.Template_.MuxConfig_.Gif_ gif = new AddTemplateResponse.Template_.MuxConfig_.Gif_();
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