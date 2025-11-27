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
    public class UpdateTemplateResponseUnmarshaller
    {
        public static UpdateTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateTemplateResponse updateTemplateResponse = new UpdateTemplateResponse();

			updateTemplateResponse.HttpResponse = _ctx.HttpResponse;
			updateTemplateResponse.RequestId = _ctx.StringValue("UpdateTemplate.RequestId");

			UpdateTemplateResponse.UpdateTemplate_Template template = new UpdateTemplateResponse.UpdateTemplate_Template();
			template.State = _ctx.StringValue("UpdateTemplate.Template.State");
			template.Name = _ctx.StringValue("UpdateTemplate.Template.Name");
			template.Id = _ctx.StringValue("UpdateTemplate.Template.Id");

			UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_Video video = new UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_Video();
			video.LongShortMode = _ctx.StringValue("UpdateTemplate.Template.Video.LongShortMode");
			video.Bufsize = _ctx.StringValue("UpdateTemplate.Template.Video.Bufsize");
			video.Degrain = _ctx.StringValue("UpdateTemplate.Template.Video.Degrain");
			video.PixFmt = _ctx.StringValue("UpdateTemplate.Template.Video.PixFmt");
			video.Pad = _ctx.StringValue("UpdateTemplate.Template.Video.Pad");
			video.Codec = _ctx.StringValue("UpdateTemplate.Template.Video.Codec");
			video.Height = _ctx.StringValue("UpdateTemplate.Template.Video.Height");
			video.Qscale = _ctx.StringValue("UpdateTemplate.Template.Video.Qscale");
			video.Crop = _ctx.StringValue("UpdateTemplate.Template.Video.Crop");
			video.Bitrate = _ctx.StringValue("UpdateTemplate.Template.Video.Bitrate");
			video.Maxrate = _ctx.StringValue("UpdateTemplate.Template.Video.Maxrate");
			video.MaxFps = _ctx.StringValue("UpdateTemplate.Template.Video.MaxFps");
			video.Profile = _ctx.StringValue("UpdateTemplate.Template.Video.Profile");
			video.Crf = _ctx.StringValue("UpdateTemplate.Template.Video.Crf");
			video._Remove = _ctx.StringValue("UpdateTemplate.Template.Video.Remove");
			video.Gop = _ctx.StringValue("UpdateTemplate.Template.Video.Gop");
			video.Width = _ctx.StringValue("UpdateTemplate.Template.Video.Width");
			video.Fps = _ctx.StringValue("UpdateTemplate.Template.Video.Fps");
			video.Preset = _ctx.StringValue("UpdateTemplate.Template.Video.Preset");
			video.ScanMode = _ctx.StringValue("UpdateTemplate.Template.Video.ScanMode");
			video.ResoPriority = _ctx.StringValue("UpdateTemplate.Template.Video.ResoPriority");
			video.Hdr2sdr = _ctx.StringValue("UpdateTemplate.Template.Video.Hdr2sdr");

			UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_Video.UpdateTemplate_BitrateBnd bitrateBnd = new UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_Video.UpdateTemplate_BitrateBnd();
			bitrateBnd.Max = _ctx.StringValue("UpdateTemplate.Template.Video.BitrateBnd.Max");
			bitrateBnd.Min = _ctx.StringValue("UpdateTemplate.Template.Video.BitrateBnd.Min");
			video.BitrateBnd = bitrateBnd;

			UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_Video.UpdateTemplate_NarrowBand narrowBand = new UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_Video.UpdateTemplate_NarrowBand();
			narrowBand.Version = _ctx.StringValue("UpdateTemplate.Template.Video.NarrowBand.Version");
			narrowBand.Abrmax = _ctx.FloatValue("UpdateTemplate.Template.Video.NarrowBand.Abrmax");
			narrowBand.MaxAbrRatio = _ctx.FloatValue("UpdateTemplate.Template.Video.NarrowBand.MaxAbrRatio");
			video.NarrowBand = narrowBand;
			template.Video = video;

			UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_TransConfig transConfig = new UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_TransConfig();
			transConfig.IsCheckAudioBitrate = _ctx.StringValue("UpdateTemplate.Template.TransConfig.IsCheckAudioBitrate");
			transConfig.TransMode = _ctx.StringValue("UpdateTemplate.Template.TransConfig.TransMode");
			transConfig.IsCheckReso = _ctx.StringValue("UpdateTemplate.Template.TransConfig.IsCheckReso");
			transConfig.IsCheckVideoBitrateFail = _ctx.StringValue("UpdateTemplate.Template.TransConfig.IsCheckVideoBitrateFail");
			transConfig.AdjDarMethod = _ctx.StringValue("UpdateTemplate.Template.TransConfig.AdjDarMethod");
			transConfig.IsCheckVideoBitrate = _ctx.StringValue("UpdateTemplate.Template.TransConfig.IsCheckVideoBitrate");
			transConfig.IsCheckResoFail = _ctx.StringValue("UpdateTemplate.Template.TransConfig.IsCheckResoFail");
			transConfig.IsCheckAudioBitrateFail = _ctx.StringValue("UpdateTemplate.Template.TransConfig.IsCheckAudioBitrateFail");
			template.TransConfig = transConfig;

			UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_MuxConfig muxConfig = new UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_MuxConfig();

			UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_MuxConfig.UpdateTemplate_Webp webp = new UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_MuxConfig.UpdateTemplate_Webp();
			webp.Loop = _ctx.StringValue("UpdateTemplate.Template.MuxConfig.Webp.Loop");
			muxConfig.Webp = webp;

			UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_MuxConfig.UpdateTemplate_Gif gif = new UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_MuxConfig.UpdateTemplate_Gif();
			gif.FinalDelay = _ctx.StringValue("UpdateTemplate.Template.MuxConfig.Gif.FinalDelay");
			gif.DitherMode = _ctx.StringValue("UpdateTemplate.Template.MuxConfig.Gif.DitherMode");
			gif.Loop = _ctx.StringValue("UpdateTemplate.Template.MuxConfig.Gif.Loop");
			gif.IsCustomPalette = _ctx.StringValue("UpdateTemplate.Template.MuxConfig.Gif.IsCustomPalette");
			muxConfig.Gif = gif;

			UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_MuxConfig.UpdateTemplate_Segment segment = new UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_MuxConfig.UpdateTemplate_Segment();
			segment.Duration = _ctx.StringValue("UpdateTemplate.Template.MuxConfig.Segment.Duration");
			muxConfig.Segment = segment;
			template.MuxConfig = muxConfig;

			UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_Audio audio = new UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_Audio();
			audio.Profile = _ctx.StringValue("UpdateTemplate.Template.Audio.Profile");
			audio._Remove = _ctx.StringValue("UpdateTemplate.Template.Audio.Remove");
			audio.Codec = _ctx.StringValue("UpdateTemplate.Template.Audio.Codec");
			audio.Samplerate = _ctx.StringValue("UpdateTemplate.Template.Audio.Samplerate");
			audio.Qscale = _ctx.StringValue("UpdateTemplate.Template.Audio.Qscale");
			audio.Channels = _ctx.StringValue("UpdateTemplate.Template.Audio.Channels");
			audio.Bitrate = _ctx.StringValue("UpdateTemplate.Template.Audio.Bitrate");

			UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_Audio.UpdateTemplate_Volume volume = new UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_Audio.UpdateTemplate_Volume();
			volume.Method = _ctx.StringValue("UpdateTemplate.Template.Audio.Volume.Method");
			volume.TruePeak = _ctx.StringValue("UpdateTemplate.Template.Audio.Volume.TruePeak");
			volume.IntegratedLoudnessTarget = _ctx.StringValue("UpdateTemplate.Template.Audio.Volume.IntegratedLoudnessTarget");
			volume.Level = _ctx.StringValue("UpdateTemplate.Template.Audio.Volume.Level");
			volume.LoudnessRangeTarget = _ctx.StringValue("UpdateTemplate.Template.Audio.Volume.LoudnessRangeTarget");
			volume.PeakLevel = _ctx.StringValue("UpdateTemplate.Template.Audio.Volume.PeakLevel");
			audio.Volume = volume;
			template.Audio = audio;

			UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_Container container = new UpdateTemplateResponse.UpdateTemplate_Template.UpdateTemplate_Container();
			container.Format = _ctx.StringValue("UpdateTemplate.Template.Container.Format");
			template.Container = container;
			updateTemplateResponse.Template = template;
        
			return updateTemplateResponse;
        }
    }
}
