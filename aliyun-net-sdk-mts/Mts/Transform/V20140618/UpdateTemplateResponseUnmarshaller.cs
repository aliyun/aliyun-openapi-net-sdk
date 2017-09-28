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
    public class UpdateTemplateResponseUnmarshaller
    {
        public static UpdateTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateTemplateResponse updateTemplateResponse = new UpdateTemplateResponse();

			updateTemplateResponse.HttpResponse = context.HttpResponse;
			updateTemplateResponse.RequestId = context.StringValue("UpdateTemplate.RequestId");

			UpdateTemplateResponse.Template_ template = new UpdateTemplateResponse.Template_();
			template.Id = context.StringValue("UpdateTemplate.Template.Id");
			template.Name = context.StringValue("UpdateTemplate.Template.Name");
			template.State = context.StringValue("UpdateTemplate.Template.State");

			UpdateTemplateResponse.Template_.Container_ container = new UpdateTemplateResponse.Template_.Container_();
			container.Format = context.StringValue("UpdateTemplate.Template.Container.Format");
			template.Container = container;

			UpdateTemplateResponse.Template_.Video_ video = new UpdateTemplateResponse.Template_.Video_();
			video.Codec = context.StringValue("UpdateTemplate.Template.Video.Codec");
			video.Profile = context.StringValue("UpdateTemplate.Template.Video.Profile");
			video.Bitrate = context.StringValue("UpdateTemplate.Template.Video.Bitrate");
			video.Crf = context.StringValue("UpdateTemplate.Template.Video.Crf");
			video.Width = context.StringValue("UpdateTemplate.Template.Video.Width");
			video.Height = context.StringValue("UpdateTemplate.Template.Video.Height");
			video.Fps = context.StringValue("UpdateTemplate.Template.Video.Fps");
			video.Gop = context.StringValue("UpdateTemplate.Template.Video.Gop");
			video.Preset = context.StringValue("UpdateTemplate.Template.Video.Preset");
			video.ScanMode = context.StringValue("UpdateTemplate.Template.Video.ScanMode");
			video.Bufsize = context.StringValue("UpdateTemplate.Template.Video.Bufsize");
			video.Maxrate = context.StringValue("UpdateTemplate.Template.Video.Maxrate");
			video.PixFmt = context.StringValue("UpdateTemplate.Template.Video.PixFmt");
			video.Degrain = context.StringValue("UpdateTemplate.Template.Video.Degrain");
			video.Qscale = context.StringValue("UpdateTemplate.Template.Video.Qscale");
			video.Remove = context.StringValue("UpdateTemplate.Template.Video.Remove");
			video.Crop = context.StringValue("UpdateTemplate.Template.Video.Crop");
			video.Pad = context.StringValue("UpdateTemplate.Template.Video.Pad");
			video.MaxFps = context.StringValue("UpdateTemplate.Template.Video.MaxFps");

			UpdateTemplateResponse.Template_.Video_.BitrateBnd_ bitrateBnd = new UpdateTemplateResponse.Template_.Video_.BitrateBnd_();
			bitrateBnd.Max = context.StringValue("UpdateTemplate.Template.Video.BitrateBnd.Max");
			bitrateBnd.Min = context.StringValue("UpdateTemplate.Template.Video.BitrateBnd.Min");
			video.BitrateBnd = bitrateBnd;
			template.Video = video;

			UpdateTemplateResponse.Template_.Audio_ audio = new UpdateTemplateResponse.Template_.Audio_();
			audio.Codec = context.StringValue("UpdateTemplate.Template.Audio.Codec");
			audio.Profile = context.StringValue("UpdateTemplate.Template.Audio.Profile");
			audio.Samplerate = context.StringValue("UpdateTemplate.Template.Audio.Samplerate");
			audio.Bitrate = context.StringValue("UpdateTemplate.Template.Audio.Bitrate");
			audio.Channels = context.StringValue("UpdateTemplate.Template.Audio.Channels");
			audio.Qscale = context.StringValue("UpdateTemplate.Template.Audio.Qscale");
			audio.Remove = context.StringValue("UpdateTemplate.Template.Audio.Remove");
			template.Audio = audio;

			UpdateTemplateResponse.Template_.TransConfig_ transConfig = new UpdateTemplateResponse.Template_.TransConfig_();
			transConfig.TransMode = context.StringValue("UpdateTemplate.Template.TransConfig.TransMode");
			transConfig.IsCheckReso = context.StringValue("UpdateTemplate.Template.TransConfig.IsCheckReso");
			transConfig.IsCheckResoFail = context.StringValue("UpdateTemplate.Template.TransConfig.IsCheckResoFail");
			transConfig.IsCheckVideoBitrate = context.StringValue("UpdateTemplate.Template.TransConfig.IsCheckVideoBitrate");
			transConfig.IsCheckAudioBitrate = context.StringValue("UpdateTemplate.Template.TransConfig.IsCheckAudioBitrate");
			transConfig.AdjDarMethod = context.StringValue("UpdateTemplate.Template.TransConfig.AdjDarMethod");
			template.TransConfig = transConfig;

			UpdateTemplateResponse.Template_.MuxConfig_ muxConfig = new UpdateTemplateResponse.Template_.MuxConfig_();

			UpdateTemplateResponse.Template_.MuxConfig_.Segment_ segment = new UpdateTemplateResponse.Template_.MuxConfig_.Segment_();
			segment.Duration = context.StringValue("UpdateTemplate.Template.MuxConfig.Segment.Duration");
			muxConfig.Segment = segment;

			UpdateTemplateResponse.Template_.MuxConfig_.Gif_ gif = new UpdateTemplateResponse.Template_.MuxConfig_.Gif_();
			gif.Loop = context.StringValue("UpdateTemplate.Template.MuxConfig.Gif.Loop");
			gif.FinalDelay = context.StringValue("UpdateTemplate.Template.MuxConfig.Gif.FinalDelay");
			gif.IsCustomPalette = context.StringValue("UpdateTemplate.Template.MuxConfig.Gif.IsCustomPalette");
			gif.DitherMode = context.StringValue("UpdateTemplate.Template.MuxConfig.Gif.DitherMode");
			muxConfig.Gif = gif;
			template.MuxConfig = muxConfig;
			updateTemplateResponse.Template = template;
        
			return updateTemplateResponse;
        }
    }
}