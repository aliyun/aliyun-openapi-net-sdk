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
    public class QueryTemplateListResponseUnmarshaller
    {
        public static QueryTemplateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTemplateListResponse queryTemplateListResponse = new QueryTemplateListResponse();

			queryTemplateListResponse.HttpResponse = _ctx.HttpResponse;
			queryTemplateListResponse.RequestId = _ctx.StringValue("QueryTemplateList.RequestId");

			List<string> queryTemplateListResponse_nonExistTids = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryTemplateList.NonExistTids.Length"); i++) {
				queryTemplateListResponse_nonExistTids.Add(_ctx.StringValue("QueryTemplateList.NonExistTids["+ i +"]"));
			}
			queryTemplateListResponse.NonExistTids = queryTemplateListResponse_nonExistTids;

			List<QueryTemplateListResponse.QueryTemplateList_Template> queryTemplateListResponse_templateList = new List<QueryTemplateListResponse.QueryTemplateList_Template>();
			for (int i = 0; i < _ctx.Length("QueryTemplateList.TemplateList.Length"); i++) {
				QueryTemplateListResponse.QueryTemplateList_Template template = new QueryTemplateListResponse.QueryTemplateList_Template();
				template.State = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].State");
				template.Name = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Name");
				template.Id = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Id");
				template.CreationTime = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].CreationTime");

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Video video = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Video();
				video.Bufsize = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Bufsize");
				video.LongShortMode = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.LongShortMode");
				video.Degrain = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Degrain");
				video.PixFmt = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.PixFmt");
				video.Pad = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Pad");
				video.Codec = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Codec");
				video.Height = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Height");
				video.Qscale = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Qscale");
				video.Crop = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Crop");
				video.Bitrate = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Bitrate");
				video.Maxrate = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Maxrate");
				video.MaxFps = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.MaxFps");
				video.Profile = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Profile");
				video.Crf = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Crf");
				video._Remove = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Remove");
				video.Gop = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Gop");
				video.Width = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Width");
				video.Fps = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Fps");
				video.Preset = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Preset");
				video.ScanMode = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.ScanMode");
				video.ResoPriority = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.ResoPriority");
				video.Hdr2sdr = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.Hdr2sdr");

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Video.QueryTemplateList_BitrateBnd bitrateBnd = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Video.QueryTemplateList_BitrateBnd();
				bitrateBnd.Max = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.BitrateBnd.Max");
				bitrateBnd.Min = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Video.QueryTemplateList_NarrowBand narrowBand = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Video.QueryTemplateList_NarrowBand();
				narrowBand.Version = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Video.NarrowBand.Version");
				narrowBand.Abrmax = _ctx.FloatValue("QueryTemplateList.TemplateList["+ i +"].Video.NarrowBand.Abrmax");
				narrowBand.MaxAbrRatio = _ctx.FloatValue("QueryTemplateList.TemplateList["+ i +"].Video.NarrowBand.MaxAbrRatio");
				video.NarrowBand = narrowBand;
				template.Video = video;

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_TransConfig transConfig = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_TransConfig();
				transConfig.IsCheckAudioBitrate = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.IsCheckAudioBitrate");
				transConfig.TransMode = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.TransMode");
				transConfig.IsCheckReso = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.IsCheckReso");
				transConfig.IsCheckVideoBitrateFail = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.IsCheckVideoBitrateFail");
				transConfig.AdjDarMethod = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.AdjDarMethod");
				transConfig.IsCheckVideoBitrate = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckResoFail = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.IsCheckResoFail");
				transConfig.IsCheckAudioBitrateFail = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].TransConfig.IsCheckAudioBitrateFail");
				template.TransConfig = transConfig;

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_MuxConfig muxConfig = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_MuxConfig();

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_MuxConfig.QueryTemplateList_Webp webp = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_MuxConfig.QueryTemplateList_Webp();
				webp.Loop = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].MuxConfig.Webp.Loop");
				muxConfig.Webp = webp;

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_MuxConfig.QueryTemplateList_Gif gif = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_MuxConfig.QueryTemplateList_Gif();
				gif.FinalDelay = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].MuxConfig.Gif.FinalDelay");
				gif.DitherMode = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].MuxConfig.Gif.DitherMode");
				gif.Loop = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].MuxConfig.Gif.Loop");
				gif.IsCustomPalette = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].MuxConfig.Gif.IsCustomPalette");
				muxConfig.Gif = gif;

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_MuxConfig.QueryTemplateList_Segment segment = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_MuxConfig.QueryTemplateList_Segment();
				segment.Duration = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;
				template.MuxConfig = muxConfig;

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Audio audio = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Audio();
				audio.Profile = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Profile");
				audio._Remove = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Remove");
				audio.Codec = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Codec");
				audio.Samplerate = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Samplerate");
				audio.Qscale = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Qscale");
				audio.Channels = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Channels");
				audio.Bitrate = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Bitrate");

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Audio.QueryTemplateList_Volume volume = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Audio.QueryTemplateList_Volume();
				volume.Method = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Volume.Method");
				volume.TruePeak = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Volume.TruePeak");
				volume.IntegratedLoudnessTarget = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Volume.IntegratedLoudnessTarget");
				volume.LoudnessRangeTarget = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Volume.LoudnessRangeTarget");
				volume.Level = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Volume.Level");
				volume.PeakLevel = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Audio.Volume.PeakLevel");
				audio.Volume = volume;
				template.Audio = audio;

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Container container = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_Container();
				container.Format = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].Container.Format");
				template.Container = container;

				QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_FrontendHint frontendHint = new QueryTemplateListResponse.QueryTemplateList_Template.QueryTemplateList_FrontendHint();
				frontendHint.TranscodeType = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].FrontendHint.TranscodeType");
				frontendHint.BitrateControlType = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].FrontendHint.BitrateControlType");
				frontendHint.Source = _ctx.StringValue("QueryTemplateList.TemplateList["+ i +"].FrontendHint.Source");
				frontendHint.IsDynamic = _ctx.BooleanValue("QueryTemplateList.TemplateList["+ i +"].FrontendHint.IsDynamic");
				frontendHint.HasOldHdr2Sdr = _ctx.BooleanValue("QueryTemplateList.TemplateList["+ i +"].FrontendHint.HasOldHdr2Sdr");
				template.FrontendHint = frontendHint;

				queryTemplateListResponse_templateList.Add(template);
			}
			queryTemplateListResponse.TemplateList = queryTemplateListResponse_templateList;
        
			return queryTemplateListResponse;
        }
    }
}
