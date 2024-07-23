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
    public class AddTemplateResponseUnmarshaller
    {
        public static AddTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddTemplateResponse addTemplateResponse = new AddTemplateResponse();

			addTemplateResponse.HttpResponse = _ctx.HttpResponse;
			addTemplateResponse.RequestId = _ctx.StringValue("AddTemplate.RequestId");

			AddTemplateResponse.AddTemplate_Template template = new AddTemplateResponse.AddTemplate_Template();
			template.State = _ctx.StringValue("AddTemplate.Template.State");
			template.Name = _ctx.StringValue("AddTemplate.Template.Name");
			template.Id = _ctx.StringValue("AddTemplate.Template.Id");

			AddTemplateResponse.AddTemplate_Template.AddTemplate_Video video = new AddTemplateResponse.AddTemplate_Template.AddTemplate_Video();
			video.Bufsize = _ctx.StringValue("AddTemplate.Template.Video.Bufsize");
			video.LongShortMode = _ctx.StringValue("AddTemplate.Template.Video.LongShortMode");
			video.Degrain = _ctx.StringValue("AddTemplate.Template.Video.Degrain");
			video.PixFmt = _ctx.StringValue("AddTemplate.Template.Video.PixFmt");
			video.Pad = _ctx.StringValue("AddTemplate.Template.Video.Pad");
			video.Codec = _ctx.StringValue("AddTemplate.Template.Video.Codec");
			video.Height = _ctx.StringValue("AddTemplate.Template.Video.Height");
			video.Qscale = _ctx.StringValue("AddTemplate.Template.Video.Qscale");
			video.Crop = _ctx.StringValue("AddTemplate.Template.Video.Crop");
			video.Bitrate = _ctx.StringValue("AddTemplate.Template.Video.Bitrate");
			video.Maxrate = _ctx.StringValue("AddTemplate.Template.Video.Maxrate");
			video.MaxFps = _ctx.StringValue("AddTemplate.Template.Video.MaxFps");
			video.Profile = _ctx.StringValue("AddTemplate.Template.Video.Profile");
			video.Crf = _ctx.StringValue("AddTemplate.Template.Video.Crf");
			video._Remove = _ctx.StringValue("AddTemplate.Template.Video.Remove");
			video.Gop = _ctx.StringValue("AddTemplate.Template.Video.Gop");
			video.Width = _ctx.StringValue("AddTemplate.Template.Video.Width");
			video.Fps = _ctx.StringValue("AddTemplate.Template.Video.Fps");
			video.Preset = _ctx.StringValue("AddTemplate.Template.Video.Preset");
			video.ScanMode = _ctx.StringValue("AddTemplate.Template.Video.ScanMode");
			video.ResoPriority = _ctx.StringValue("AddTemplate.Template.Video.ResoPriority");
			video.Hdr2sdr = _ctx.StringValue("AddTemplate.Template.Video.Hdr2sdr");

			AddTemplateResponse.AddTemplate_Template.AddTemplate_Video.AddTemplate_BitrateBnd bitrateBnd = new AddTemplateResponse.AddTemplate_Template.AddTemplate_Video.AddTemplate_BitrateBnd();
			bitrateBnd.Max = _ctx.StringValue("AddTemplate.Template.Video.BitrateBnd.Max");
			bitrateBnd.Min = _ctx.StringValue("AddTemplate.Template.Video.BitrateBnd.Min");
			video.BitrateBnd = bitrateBnd;

			AddTemplateResponse.AddTemplate_Template.AddTemplate_Video.AddTemplate_NarrowBand narrowBand = new AddTemplateResponse.AddTemplate_Template.AddTemplate_Video.AddTemplate_NarrowBand();
			narrowBand.Version = _ctx.StringValue("AddTemplate.Template.Video.NarrowBand.Version");
			narrowBand.Abrmax = _ctx.FloatValue("AddTemplate.Template.Video.NarrowBand.Abrmax");
			narrowBand.MaxAbrRatio = _ctx.FloatValue("AddTemplate.Template.Video.NarrowBand.MaxAbrRatio");
			video.NarrowBand = narrowBand;
			template.Video = video;

			AddTemplateResponse.AddTemplate_Template.AddTemplate_TransConfig transConfig = new AddTemplateResponse.AddTemplate_Template.AddTemplate_TransConfig();
			transConfig.IsCheckAudioBitrate = _ctx.StringValue("AddTemplate.Template.TransConfig.IsCheckAudioBitrate");
			transConfig.TransMode = _ctx.StringValue("AddTemplate.Template.TransConfig.TransMode");
			transConfig.IsCheckReso = _ctx.StringValue("AddTemplate.Template.TransConfig.IsCheckReso");
			transConfig.IsCheckVideoBitrateFail = _ctx.StringValue("AddTemplate.Template.TransConfig.IsCheckVideoBitrateFail");
			transConfig.AdjDarMethod = _ctx.StringValue("AddTemplate.Template.TransConfig.AdjDarMethod");
			transConfig.IsCheckVideoBitrate = _ctx.StringValue("AddTemplate.Template.TransConfig.IsCheckVideoBitrate");
			transConfig.IsCheckResoFail = _ctx.StringValue("AddTemplate.Template.TransConfig.IsCheckResoFail");
			transConfig.IsCheckAudioBitrateFail = _ctx.StringValue("AddTemplate.Template.TransConfig.IsCheckAudioBitrateFail");
			template.TransConfig = transConfig;

			AddTemplateResponse.AddTemplate_Template.AddTemplate_MuxConfig muxConfig = new AddTemplateResponse.AddTemplate_Template.AddTemplate_MuxConfig();

			AddTemplateResponse.AddTemplate_Template.AddTemplate_MuxConfig.AddTemplate_Webp webp = new AddTemplateResponse.AddTemplate_Template.AddTemplate_MuxConfig.AddTemplate_Webp();
			webp.Loop = _ctx.StringValue("AddTemplate.Template.MuxConfig.Webp.Loop");
			muxConfig.Webp = webp;

			AddTemplateResponse.AddTemplate_Template.AddTemplate_MuxConfig.AddTemplate_Gif gif = new AddTemplateResponse.AddTemplate_Template.AddTemplate_MuxConfig.AddTemplate_Gif();
			gif.FinalDelay = _ctx.StringValue("AddTemplate.Template.MuxConfig.Gif.FinalDelay");
			gif.DitherMode = _ctx.StringValue("AddTemplate.Template.MuxConfig.Gif.DitherMode");
			gif.Loop = _ctx.StringValue("AddTemplate.Template.MuxConfig.Gif.Loop");
			gif.IsCustomPalette = _ctx.StringValue("AddTemplate.Template.MuxConfig.Gif.IsCustomPalette");
			muxConfig.Gif = gif;

			AddTemplateResponse.AddTemplate_Template.AddTemplate_MuxConfig.AddTemplate_Segment segment = new AddTemplateResponse.AddTemplate_Template.AddTemplate_MuxConfig.AddTemplate_Segment();
			segment.Duration = _ctx.StringValue("AddTemplate.Template.MuxConfig.Segment.Duration");
			muxConfig.Segment = segment;
			template.MuxConfig = muxConfig;

			AddTemplateResponse.AddTemplate_Template.AddTemplate_Audio audio = new AddTemplateResponse.AddTemplate_Template.AddTemplate_Audio();
			audio.Profile = _ctx.StringValue("AddTemplate.Template.Audio.Profile");
			audio._Remove = _ctx.StringValue("AddTemplate.Template.Audio.Remove");
			audio.Codec = _ctx.StringValue("AddTemplate.Template.Audio.Codec");
			audio.Samplerate = _ctx.StringValue("AddTemplate.Template.Audio.Samplerate");
			audio.Qscale = _ctx.StringValue("AddTemplate.Template.Audio.Qscale");
			audio.Channels = _ctx.StringValue("AddTemplate.Template.Audio.Channels");
			audio.Bitrate = _ctx.StringValue("AddTemplate.Template.Audio.Bitrate");

			AddTemplateResponse.AddTemplate_Template.AddTemplate_Audio.AddTemplate_Volume volume = new AddTemplateResponse.AddTemplate_Template.AddTemplate_Audio.AddTemplate_Volume();
			volume.Method = _ctx.StringValue("AddTemplate.Template.Audio.Volume.Method");
			volume.Level = _ctx.StringValue("AddTemplate.Template.Audio.Volume.Level");
			volume.IntegratedLoudnessTarget = _ctx.StringValue("AddTemplate.Template.Audio.Volume.IntegratedLoudnessTarget");
			volume.TruePeak = _ctx.StringValue("AddTemplate.Template.Audio.Volume.TruePeak");
			volume.LoudnessRangeTarget = _ctx.StringValue("AddTemplate.Template.Audio.Volume.LoudnessRangeTarget");
			volume.PeakLevel = _ctx.StringValue("AddTemplate.Template.Audio.Volume.PeakLevel");
			audio.Volume = volume;
			template.Audio = audio;

			AddTemplateResponse.AddTemplate_Template.AddTemplate_Container container = new AddTemplateResponse.AddTemplate_Template.AddTemplate_Container();
			container.Format = _ctx.StringValue("AddTemplate.Template.Container.Format");
			template.Container = container;
			addTemplateResponse.Template = template;
        
			return addTemplateResponse;
        }
    }
}
